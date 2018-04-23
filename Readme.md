# How to generate an MDX query automatically according to the current pivot grid layout


<p>This example demonstrates how to automatically create a custom MDX query according to the current pivot grid layout. Then, this query can be used to retrieve data from the OLAP cube and write it into a DataTable. This approach allows working around some of the <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument3253">OLAP Limitations </a>, but performance will be worse than in the original OLAP mode.</p><p>In this project, the PivotGridControl is bound to the OLAP in a designer that allows using design-time features to create a report.<br />
After launching the project, you can click the "Query Server" button to perform a custom MDX query and bind PivotGridControl to a local table populated from the OLAP server. </p><p>Please note that the attached project works with the Adventure Works Cube provided along with the MS Analysis Services installation. However, you can specify any other cube to work with.</p><p><strong>See Also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/E1265">How to perform custom MDX query</a></p>

<br/>


