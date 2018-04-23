using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPivotGrid.Data;

namespace WindowsApplication10
{
    class QueryStringBuilder
    {
        static string _select = " select ";
        static string _nonEmpty = " non empty ";
        static string _onColumns = " on columns ";
        static string _onRows = " on rows ";
        static string _from = " from ";
        static string _members = ".members";
        static string _measureSeparator = " , ";
        static string _dimensionSeparator = " * ";
        static string _filedNameSeparator = ".";
        static string _parametersSeparator = ", ";
        static string _generate = "generate";
        static string _curentMember = ".currentmember";
        static string _descendants = "descendants";        

        private static string CurlyBrackets(string str) { return "{" + str + "}"; }
        private static string SquareBrackets(string str) { return "[" + str + "]"; }
        private static string RoundBrackets(string str) { return "(" + str + ")"; }

        
        public static string GetQueryString(PivotGridControl pivot, string fullConnectionString)
        {
            return GetQueryString(pivot, fullConnectionString, true);
        }

        public static string GetQueryString(PivotGridControl pivot, string fullConnectionString, bool nonEmptyBehavior)
        {
            OLAPConnectionStringBuilder builder = new OLAPConnectionStringBuilder(fullConnectionString);
            string cubeName = builder.CubeName; 
            return _select + GetNonEmptyString(nonEmptyBehavior) + GetMeasuresString(pivot) + _onColumns + _parametersSeparator + GetNonEmptyString(nonEmptyBehavior) + GetDimensionsString(pivot) + _onRows + _from + SquareBrackets(cubeName);            
        }

        protected static string GetNonEmptyString(bool nonEmptyBehavior)
        {
            if (nonEmptyBehavior) return _nonEmpty;
            return string.Empty;
        }

        private static string GetDimensionsString(PivotGridControl pivot)
        {
            string dimensionString = string.Empty;
            bool _isFirstItem = true;
            foreach (PivotGridField field in pivot.Fields)
            {
                if (field.Area == PivotArea.DataArea || field.Visible == false || field.InnerGroupIndex > 0) continue;
                if (!_isFirstItem) 
                    dimensionString = dimensionString + _dimensionSeparator;
                else 
                    _isFirstItem = false;
                if (field.InnerGroupIndex < 0)
                    dimensionString = dimensionString + GetDimensionName(field);
                else
                    dimensionString = dimensionString + GetHierarchyString(pivot, field);

            }
            return dimensionString;
        }
        private static string GetMeasuresString(PivotGridControl pivot)
        {
            string measureString = string.Empty;
            bool _isFirstItem = true;
            foreach (PivotGridField field in pivot.GetFieldsByArea(PivotArea.DataArea))
            {
                if (!_isFirstItem)
                    measureString = measureString + _measureSeparator;
                else
                    _isFirstItem = false;
                measureString = measureString + field.FieldName;
            }
            return CurlyBrackets(measureString);
        }

        private static string GetHierarchyString(PivotGridControl pivot, PivotGridField field) 
        {
            return _generate + RoundBrackets(field.FieldName + _members + _parametersSeparator + GetDescendantsString(pivot, field));             
        }
        private static string GetDescendantsString(PivotGridControl pivot, PivotGridField field)         { 
            
            return _descendants + RoundBrackets(GetHierarchyName(field) + _curentMember + _parametersSeparator +  GetLastLevelFieldName(pivot, field));
        }

        private static string GetLastLevelFieldName(PivotGridControl pivot, PivotGridField field)
        {
            PivotGridGroup group = pivot.Groups[field.GroupIndex];
            PivotGridFieldBase lastLevelField =  group[group.Count - 1];
            return lastLevelField.FieldName;
        }

        private static string GetHierarchyName(PivotGridField field) 
        {
            string[] names = field.FieldName.Split(_filedNameSeparator.ToCharArray());
            string name = names[0];
            for (int i = 1; i < names.Length - 1; i++)
                name = name + _filedNameSeparator + names[i];
            return name;
        }

        private static string GetDimensionName(PivotGridField field) { return CurlyBrackets(field.FieldName + _members); }
        private static string GetMeasureName(PivotGridField field) { return field.FieldName; }
    }
}
