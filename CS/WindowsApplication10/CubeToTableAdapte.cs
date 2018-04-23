using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPivotGrid.Data;
using System.Data;
using System.Data.OleDb;

namespace WindowsApplication10
{
    public class CubeToTableAdapter
    {
        PivotGridControl pivot;
        string fullConnectionString;
        string providerConnectionString;

        public CubeToTableAdapter(PivotGridControl pivot)
        {
            this.pivot = pivot;
            if (pivot.IsOLAPDataSource)
            {
                fullConnectionString = pivot.OLAPConnectionString;
                OLAPConnectionStringBuilder builder = new OLAPConnectionStringBuilder(fullConnectionString);
                providerConnectionString = builder.ConnectionString;
            }
            else
            {
                fullConnectionString = string.Empty;
                providerConnectionString = string.Empty;
            }
        }

        public DataTable GetTable()
        {
            if (pivot == null || string.IsNullOrEmpty(fullConnectionString) || string.IsNullOrEmpty(providerConnectionString))
                return new DataTable();

            string query = QueryStringBuilder.GetQueryString(pivot, fullConnectionString);

            using (OleDbConnection connection = new OleDbConnection(providerConnectionString))
            {
                connection.Open();
                using (OleDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = query;
                    return ReadQueryResult(command);
                }
            }
        }

        public void RefreshDataSource()
        {
            if (pivot.IsOLAPDataSource)
            {
                List<GroupProperties> groups = new List<GroupProperties>();
                foreach (PivotGridGroup g in pivot.Groups)
                    groups.Add(new GroupProperties(g));
                pivot.OLAPConnectionString = string.Empty;
                pivot.Groups.Clear();
                foreach (GroupProperties gp in groups)
                    pivot.Groups.Add(gp.Fields.ToArray(), gp.Caption);
            }
            pivot.DataSource = GetTable();
            
        }

        string memberCaption = ".[MEMBER_CAPTION]";
        protected DataTable ReadQueryResult(OleDbCommand command)
        {
            DataTable table = new DataTable();
            using (OleDbDataReader reader = command.ExecuteReader())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                    table.Columns.Add(reader.GetName(i), reader.GetFieldType(i));
                object[] values = new object[reader.FieldCount];
                while (reader.Read())
                {
                    reader.GetValues(values);
                    table.Rows.Add(values);
                }
            }
            foreach (DataColumn col in table.Columns)
                if (col.ColumnName.Contains(memberCaption))
                    col.ColumnName = col.ColumnName.Remove(col.ColumnName.Length - memberCaption.Length);
            return table;
        }
    }
    public class GroupProperties
    {
        public string Caption;
        public List<PivotGridFieldBase> Fields;

        public GroupProperties(PivotGridGroup group)
        {
            Caption = group.Caption;
            Fields = new List<PivotGridFieldBase>();
            foreach (PivotGridFieldBase field in group)
                Fields.Add(field);
        }
    }
}
