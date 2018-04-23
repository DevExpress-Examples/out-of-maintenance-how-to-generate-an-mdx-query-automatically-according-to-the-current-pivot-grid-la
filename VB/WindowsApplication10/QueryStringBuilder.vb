Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPivotGrid.Data

Namespace WindowsApplication10
	Friend Class QueryStringBuilder
		Private Shared _select As String = " select "
		Private Shared _nonEmpty As String = " non empty "
		Private Shared _onColumns As String = " on columns "
		Private Shared _onRows As String = " on rows "
		Private Shared _from As String = " from "
		Private Shared _members As String = ".members"
		Private Shared _measureSeparator As String = " , "
		Private Shared _dimensionSeparator As String = " * "
		Private Shared _filedNameSeparator As String = "."
		Private Shared _parametersSeparator As String = ", "
		Private Shared _generate As String = "generate"
		Private Shared _curentMember As String = ".currentmember"
		Private Shared _descendants As String = "descendants"

		Private Shared Function CurlyBrackets(ByVal str As String) As String
			Return "{" & str & "}"
		End Function
		Private Shared Function SquareBrackets(ByVal str As String) As String
			Return "[" & str & "]"
		End Function
		Private Shared Function RoundBrackets(ByVal str As String) As String
			Return "(" & str & ")"
		End Function


		Public Shared Function GetQueryString(ByVal pivot As PivotGridControl, ByVal fullConnectionString As String) As String
			Return GetQueryString(pivot, fullConnectionString, True)
		End Function

		Public Shared Function GetQueryString(ByVal pivot As PivotGridControl, ByVal fullConnectionString As String, ByVal nonEmptyBehavior As Boolean) As String
			Dim builder As New OLAPConnectionStringBuilder(fullConnectionString)
			Dim cubeName As String = builder.CubeName
			Return _select & GetNonEmptyString(nonEmptyBehavior) + GetMeasuresString(pivot) & _onColumns & _parametersSeparator & GetNonEmptyString(nonEmptyBehavior) + GetDimensionsString(pivot) & _onRows & _from & SquareBrackets(cubeName)
		End Function

		Protected Shared Function GetNonEmptyString(ByVal nonEmptyBehavior As Boolean) As String
			If nonEmptyBehavior Then
				Return _nonEmpty
			End If
			Return String.Empty
		End Function

		Private Shared Function GetDimensionsString(ByVal pivot As PivotGridControl) As String
			Dim dimensionString As String = String.Empty
			Dim _isFirstItem As Boolean = True
			For Each field As PivotGridField In pivot.Fields
				If field.Area = PivotArea.DataArea OrElse field.Visible = False OrElse field.InnerGroupIndex > 0 Then
					Continue For
				End If
				If (Not _isFirstItem) Then
					dimensionString = dimensionString & _dimensionSeparator
				Else
					_isFirstItem = False
				End If
				If field.InnerGroupIndex < 0 Then
					dimensionString = dimensionString & GetDimensionName(field)
				Else
					dimensionString = dimensionString & GetHierarchyString(pivot, field)
				End If

			Next field
			Return dimensionString
		End Function
		Private Shared Function GetMeasuresString(ByVal pivot As PivotGridControl) As String
			Dim measureString As String = String.Empty
			Dim _isFirstItem As Boolean = True
			For Each field As PivotGridField In pivot.GetFieldsByArea(PivotArea.DataArea)
				If (Not _isFirstItem) Then
					measureString = measureString & _measureSeparator
				Else
					_isFirstItem = False
				End If
				measureString = measureString & field.FieldName
			Next field
			Return CurlyBrackets(measureString)
		End Function

		Private Shared Function GetHierarchyString(ByVal pivot As PivotGridControl, ByVal field As PivotGridField) As String
			Return _generate & RoundBrackets(field.FieldName & _members & _parametersSeparator & GetDescendantsString(pivot, field))
		End Function
		Private Shared Function GetDescendantsString(ByVal pivot As PivotGridControl, ByVal field As PivotGridField) As String

			Return _descendants & RoundBrackets(GetHierarchyName(field) & _curentMember & _parametersSeparator & GetLastLevelFieldName(pivot, field))
		End Function

		Private Shared Function GetLastLevelFieldName(ByVal pivot As PivotGridControl, ByVal field As PivotGridField) As String
			Dim group As PivotGridGroup = pivot.Groups(field.GroupIndex)
			Dim lastLevelField As PivotGridFieldBase = group(group.Count - 1)
			Return lastLevelField.FieldName
		End Function

		Private Shared Function GetHierarchyName(ByVal field As PivotGridField) As String
			Dim names() As String = field.FieldName.Split(_filedNameSeparator.ToCharArray())
			Dim name As String = names(0)
			For i As Integer = 1 To names.Length - 2
				name = name & _filedNameSeparator & names(i)
			Next i
			Return name
		End Function

		Private Shared Function GetDimensionName(ByVal field As PivotGridField) As String
			Return CurlyBrackets(field.FieldName & _members)
		End Function
		Private Shared Function GetMeasureName(ByVal field As PivotGridField) As String
			Return field.FieldName
		End Function
	End Class
End Namespace
