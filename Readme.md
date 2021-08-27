<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2299)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CubeToTableAdapte.cs](./CS/WindowsApplication10/CubeToTableAdapte.cs) (VB: [CubeToTableAdapte.vb](./VB/WindowsApplication10/CubeToTableAdapte.vb))
* [Form1.cs](./CS/WindowsApplication10/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication10/Form1.vb))
* [Program.cs](./CS/WindowsApplication10/Program.cs) (VB: [Program.vb](./VB/WindowsApplication10/Program.vb))
* [QueryStringBuilder.cs](./CS/WindowsApplication10/QueryStringBuilder.cs) (VB: [QueryStringBuilder.vb](./VB/WindowsApplication10/QueryStringBuilder.vb))
<!-- default file list end -->
# How to generate an MDX query automatically according to the current pivot grid layout


<p>This example demonstrates how to automatically create a custom MDX query according to the current pivot grid layout. Then, this query can be used to retrieve data from the OLAP cube and write it into a DataTable. This approach allows working around some of the <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument3253">OLAP Limitations </a>, but performance will be worse than in the original OLAP mode.</p><p>In this project, the PivotGridControl is bound to the OLAP in a designer that allows using design-time features to create a report.<br />
After launching the project, you can click the "Query Server" button to perform a custom MDX query and bind PivotGridControl to a local table populated from the OLAP server. </p><p>Please note that the attached project works with the Adventure Works Cube provided along with the MS Analysis Services installation. However, you can specify any other cube to work with.</p><p><strong>See Also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/E1265">How to perform custom MDX query</a></p>

<br/>


