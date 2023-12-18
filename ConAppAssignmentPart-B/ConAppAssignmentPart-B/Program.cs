using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignmentPart_B
{
    internal class Program
    {
        static DataTable Create()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("PId", typeof(int));
            dt.Columns.Add("PPrice", typeof(int));
            dt.Columns.Add("MnfDate", typeof(DateTime));
            dt.Columns.Add("ExpDate", typeof(DateTime));
            dt.PrimaryKey = new DataColumn[] { dt.Columns["PId"] };

            return dt;
        }
        static void InsertData(DataTable table, int pid, int pPrice, DateTime mnfDate, DateTime expDate)
        {
            DataRow row = table.NewRow();
            row["PId"] = pid;
            row["PPrice"] = pPrice;
            row["MnfDate"] = mnfDate;
            row["ExpDate"] = expDate;
            table.Rows.Add(row);
        }


        static void UpdateData(DataTable table, int pid, int newPPrice)
        {
            DataRow row = table.Rows.Find(pid);
            if (row != null)
            {
                row["PPrice"] = newPPrice;
                Console.WriteLine($"Data for Pid {pid} updated successfully.");
            }
            else
            {
                Console.WriteLine($"Pid {pid} not found.");
            }
        }
        static void SearchData(DataTable dt, int id)
        {
            DataRow foundRow = dt.Rows.Find(id);
            if (foundRow == null)
            {
                Console.WriteLine($"No such Id{id} exist");
            }
            else
            {
                Console.WriteLine("Record found details as follow");
                Console.WriteLine($"PID:\t{foundRow["PId"]}");
                Console.WriteLine($"PPrice:\t{foundRow["PPrice"]}");

                Console.WriteLine($"MnfDate:\t{foundRow["MnfDate"]}");
                Console.WriteLine($"ExpDate:\t{foundRow["ExpDate"]}");

            }

        }
        static void DeleteData(DataTable dt, int id)
        {
            DataRow delRow = dt.Rows.Find(id);

            if (delRow == null)
            {
                Console.WriteLine($"No such {id} exist");
            }
            else
            {
                dt.Rows.Remove(delRow);
                Console.WriteLine($"record with Id{id}deleted from Table");
            }
        }

        static void Display(DataTable dt)
        {
            Console.WriteLine("Stored Current Data in table");
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine("ID:\t" + row["PId"]);

                Console.WriteLine("PPrice:\t" + row["PPrice"]);
                Console.WriteLine($"MnfDate:\t" + row["MnfDate"]);
                Console.WriteLine($"ExpDate:\t" + row["ExpDate"]);
            }
        }

        static void Main(string[] args)
        {
            DataTable productsTable = Create();


            InsertData(productsTable, 1, 19, DateTime.Parse("2023-01-01"), DateTime.Parse("2023-12-31"));
            InsertData(productsTable, 2, 29, DateTime.Parse("2023-02-15"), DateTime.Parse("2023-12-31"));


            Display(productsTable);


            UpdateData(productsTable, 1, 24);


            Display(productsTable);


            SearchData(productsTable, 2);


            DeleteData(productsTable, 1);


            Display(productsTable);

            Console.ReadLine();
        }

    }
}