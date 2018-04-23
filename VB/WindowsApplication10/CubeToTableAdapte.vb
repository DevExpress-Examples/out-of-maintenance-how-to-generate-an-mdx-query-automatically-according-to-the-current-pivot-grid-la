Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPivotGrid.Data
Imports System.Data
Imports System.Data.OleDb

Namespace WindowsApplication10
	Public Class CubeToTableAdapter
		Private pivot As PivotGridControl
		Private fullConnectionString As String
		Private providerConnectionString As String

		Public Sub New(ByVal pivot As PivotGridControl)
			Me.pivot = pivot
			If pivot.IsOLAPDataSource Then
				fullConnectionString = pivot.OLAPConnectionString
				Dim builder As New OLAPConnectionStringBuilder(fullConnectionString)
				providerConnectionString = builder.ConnectionString
			Else
				fullConnectionString = String.Empty
				providerConnectionString = String.Empty
			End If
		End Sub

		Public Function GetTable() As DataTable
			If pivot Is Nothing OrElse String.IsNullOrEmpty(fullConnectionString) OrElse String.IsNullOrEmpty(providerConnectionString) Then
				Return New DataTable()
			End If

			Dim query As String = QueryStringBuilder.GetQueryString(pivot, fullConnectionString)

			Using connection As New OleDbConnection(providerConnectionString)
				connection.Open()
				Using command As OleDbCommand = connection.CreateCommand()
					command.CommandText = query
					Return ReadQueryResult(command)
				End Using
			End Using
		End Function

		Public Sub RefreshDataSource()
			If pivot.IsOLAPDataSource Then
				Dim groups As New List(Of GroupProperties)()
				For Each g As PivotGridGroup In pivot.Groups
					groups.Add(New GroupProperties(g))
				Next g
				pivot.OLAPConnectionString = String.Empty
				pivot.Groups.Clear()
				For Each gp As GroupProperties In groups
					pivot.Groups.Add(gp.Fields.ToArray(), gp.Caption)
				Next gp
			End If
			pivot.DataSource = GetTable()

		End Sub

		Private memberCaption As String = ".[MEMBER_CAPTION]"
		Protected Function ReadQueryResult(ByVal command As OleDbCommand) As DataTable
			Dim table As New DataTable()
			Using reader As OleDbDataReader = command.ExecuteReader()
				For i As Integer = 0 To reader.FieldCount - 1
					table.Columns.Add(reader.GetName(i), reader.GetFieldType(i))
				Next i
				Dim values(reader.FieldCount - 1) As Object
				Do While reader.Read()
					reader.GetValues(values)
					table.Rows.Add(values)
				Loop
			End Using
			For Each col As DataColumn In table.Columns
				If col.ColumnName.Contains(memberCaption) Then
					col.ColumnName = col.ColumnName.Remove(col.ColumnName.Length - memberCaption.Length)
				End If
			Next col
			Return table
		End Function
	End Class
	Public Class GroupProperties
		Public Caption As String
		Public Fields As List(Of PivotGridFieldBase)

		Public Sub New(ByVal group As PivotGridGroup)
			Caption = group.Caption
			Fields = New List(Of PivotGridFieldBase)()
			For Each field As PivotGridFieldBase In group
				Fields.Add(field)
			Next field
		End Sub
	End Class
End Namespace
