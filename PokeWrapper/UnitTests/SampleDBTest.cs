using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

/// <summary>
/// Demonstrates how to work with SqlConnection objects
/// </summary>

[TestClass]
public class SqlConnectionDemo
{
    private const string CREATE_TABLE =    @"CREATE TABLE Persons(PersonID int,LastName varchar(255),FirstName varchar(255),Address varchar(255),City varchar(255));";
    private const string DROP_TABLE = @"DROP TABLE dbo.Persons;";

    [TestMethod]
    public void TestDb()
    {
        // 1. Instantiate the connection
        SqlConnection conn = new SqlConnection(
            @"Data Source=(local);
            Initial Catalog=Sample;
            Integrated Security=SSPI");

        //SqlDataReader rdr = null;

        try
        {
            // 2. Open the connection
            conn.Open();
            

            // 3. Pass the connection to a command object
            SqlCommand cmd = new SqlCommand(CREATE_TABLE, conn);
            cmd.ExecuteReader();
            

            //
            // 4. Use the connection
            //

            // get query results
            //rdr = cmd.ExecuteReader();

            // print the CustomerID of each record
            //while (rdr.Read())
            //{
            //    Console.WriteLine(rdr[0]);
            //}

            Assert.IsTrue(true);
        }
        catch (Exception e)
        {
            Debug.WriteLine(e.StackTrace);
            Assert.IsTrue(false);
        }
        finally
        {
            // close the reader
            //if (rdr != null)
            //{
            //    rdr.Close();
            //}

            // 5. Close the connection
            if (conn != null)
            {
                conn.Close();
            }
        }

        //try
        //{
        //    conn.Open();

        //    SqlCommand cmd = new SqlCommand(DROP_TABLE, conn);
        //    cmd.ExecuteReader();

        //    Assert.IsTrue(true);
        //}
        //catch (Exception e)
        //{
        //    Debug.WriteLine(e.StackTrace);
        //    Assert.IsTrue(false);
        //}
        //finally
        //{
        //    if (conn != null)
        //    {
        //        conn.Close();
        //    }
        //}
    }
}