using System.Data;

namespace Evaluation.Collections;

public static class DataTableTest
{
    public static DataTable CreateDataTable()
    {
        // Create a new DataSet
        DataSet dataSet = new DataSet("ExampleDataSet");

        // Create a new DataTable
        DataTable table = new DataTable("Products");

        // Define columns for the DataTable
        DataColumn idColumn = new DataColumn("ID", typeof(int))
        {
            AutoIncrement = true,
            AutoIncrementSeed = 1,
            AutoIncrementStep = 1,
            ReadOnly = true
        };
        DataColumn nameColumn = new DataColumn("Name", typeof(string));
        DataColumn priceColumn = new DataColumn("Price", typeof(decimal));

        // Add the columns to the DataTable's Columns collection
        table.Columns.Add(idColumn);
        table.Columns.Add(nameColumn);
        table.Columns.Add(priceColumn);

        // Add the DataTable to the DataSet
        dataSet.Tables.Add(table);

        // Populate the DataTable with rows of data
        for (int i = 0; i < 50; i++)
        {
            DataRow row = table.NewRow();
            row["Name"] = $"Laptop {i}";
            row["Price"] = 1200.00m + i*15;
            table.Rows.Add(row);
        }
        
        return table;
    }
}
