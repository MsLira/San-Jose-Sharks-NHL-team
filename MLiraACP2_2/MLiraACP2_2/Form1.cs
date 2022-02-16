using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace MLiraACP2_2
{
    public partial class Form1 : Form
    {
        SQLiteConnection sqlite_conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Crreating connection
            sqlite_conn = CreateConnection();
        }
        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data Source=SJsharks.db");

            // open connection
            try
            {
                sqlite_conn.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return sqlite_conn;

        }
        private void bnt_CreateT_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd;
            cmd = sqlite_conn.CreateCommand();
            // Drop it if it there
            cmd.CommandText = "DROP TABLE IF EXISTS SJsharks";
            cmd.ExecuteNonQuery();
            //Create Table with 6 colums, primary key name ID
            cmd.CommandText = @"CREATE TABLE SJsharks(id INTEGER PRIMARY KEY, name TEXT, age INT, Jnumber TEXT, origin TEXT, position TEXT, shoots TEXT)";

            cmd.ExecuteNonQuery();
            MessageBox.Show("Table Created");
        }

        private void btn_Insert_Click(object sender, EventArgs e)

        {
            SQLiteCommand cmd;
            cmd = sqlite_conn.CreateCommand();
            // insert 15 rows into members SJsharks table (Note the id INTEGER PRIMARY KEY is AUTO generated so do Not add it here!)
            // 1
            cmd.CommandText = "INSERT INTO SJsharks(name, age, 'Jnumber', origin, position, shoots) VALUES ('Evander Kane', 30 , 9, 'Canada', 'Left wing' ,'Left' )";
            cmd.ExecuteNonQuery();
            //2
            cmd.CommandText = "INSERT INTO SJsharks(name, age, 'Jnumber', origin, position, shoots) VALUES ('Erik Karlsson', 31 , 65, 'Sweden', 'Defence' ,'Right' )";
            cmd.ExecuteNonQuery();
            //3
            cmd.CommandText = "INSERT INTO SJsharks(name, age, 'Jnumber', origin, position, shoots) VALUES ('Brent Burns', 36 , 88, 'Canada', 'Defence' ,'Right' )";
            cmd.ExecuteNonQuery();
            //4
            cmd.CommandText = "INSERT INTO SJsharks(name, age, 'Jnumber', origin, position, shoots) VALUES ('Tomáš Hertl', 27 , 17, 'Czech', 'Left wing' ,'Left' )";
            cmd.ExecuteNonQuery();
            //5
            cmd.CommandText = "INSERT INTO SJsharks(name, age, 'Jnumber', origin, position, shoots) VALUES ('Logan Couture', 32 , 39, 'Canada', 'Centre' ,'Left' )";
            cmd.ExecuteNonQuery();
            //6
            cmd.CommandText = "INSERT INTO SJsharks(name, age, 'Jnumber', origin, position, shoots) VALUES ('James Reimer', 33 , 47, 'Canada', 'Goaltender' ,'Catches Left' )";
            cmd.ExecuteNonQuery();
            //7
            cmd.CommandText = "INSERT INTO SJsharks(name, age, 'Jnumber', origin, position, shoots) VALUES ('Adin Hill', 25 , 31, 'Canada', 'Goaltender' ,'Catches Left' )";
            cmd.ExecuteNonQuery();
            //8
            cmd.CommandText = "INSERT INTO SJsharks(name, age, 'Jnumber', origin, position, shoots) VALUES ('Andrew Cogliano', 34 , 11, 'Canada', '	Left wing' ,'Left' )";
            cmd.ExecuteNonQuery();
            //9
            cmd.CommandText = "INSERT INTO SJsharks(name, age, 'Jnumber', origin, position, shoots) VALUES ('Nick Bonino', 33 , 13, 'United States', 'Centre' ,'Left' )";
            cmd.ExecuteNonQuery();
            //10
            cmd.CommandText = "INSERT INTO SJsharks(name, age, 'Jnumber', origin, position, shoots) VALUES ('Nicholas Merkley', 24 , 15, 'Canada', 'Forward' ,'Right' )";
            cmd.ExecuteNonQuery();
            //11
            cmd.CommandText = "INSERT INTO SJsharks(name, age, 'Jnumber', origin, position, shoots) VALUES ('Timo Meier', 24 , 28, 'Switzerland', '	Right wing' ,'Right' )";
            cmd.ExecuteNonQuery();
            //12
            cmd.CommandText = "INSERT INTO SJsharks(name, age, 'Jnumber', origin, position, shoots) VALUES ('Lane Pederson', 24 , 93, 'Canada', 'Centre' ,'Right' )";
            cmd.ExecuteNonQuery();
            //13
            cmd.CommandText = "INSERT INTO SJsharks(name, age, 'Jnumber', origin, position, shoots) VALUES ('Mario Ferraro', 23 , 38, 'Canada', 'Defence' ,'Left' )";
            cmd.ExecuteNonQuery();
            //14
            cmd.CommandText = "INSERT INTO SJsharks(name, age, 'Jnumber', origin, position, shoots) VALUES ('John Gerard', 23 , 43, 'United States', 'Left wing' ,'Left' )";
            cmd.ExecuteNonQuery();
            //15
            cmd.CommandText = "INSERT INTO SJsharks(name, age, 'Jnumber', origin, position, shoots) VALUES ('Dylan Gambrell', 25 , 14, 'United States', 'Center' ,'Right' )";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Rows Created");
        }
        string myInfo;
        private void btn_DisplayD_Click(object sender, EventArgs e)
        {

            SQLiteDataReader dr;
            SQLiteCommand cmd;
            cmd = sqlite_conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM SJsharks";
            //use reader to get data from table
            dr = cmd.ExecuteReader();
            listBox1.Items.Add("ID\tPlayer Name\t\tAge\t\tNumber\t\tOrigin\t\tPosition\t\tShoots");
            while (dr.Read())
            {
                // It is placing each field into the myInfo field and each has to be different number.
                //      (id INTEGER PRIMARY KEY,           name TEXT,                age INT,             Jnumber CHAR,             origin TEXT,            position TEXT,          shoots TEXT)
                myInfo = dr.GetInt32(0) + "\t" + dr.GetString(1) + "\t" + dr.GetInt32(2) + "\t" + dr.GetString(3) + "\t" + dr.GetString(4) + "\t" + dr.GetString(5) + "\t" + dr.GetString(6);// same order
                listBox1.Items.Add(myInfo);

            }
            // sqlite_conn.Close();
        }

        private StringBuilder GenerateReport()
        {
            //HTML
            StringBuilder html = new StringBuilder();
            //CSS
            StringBuilder css = new StringBuilder();
            //
            //EXAMPLES 
            //WWW/W3schools.com/Css/css_syntax.asp
            //_________________________________________________CSS / STYlE______________________________________
            css.Append("<style>");
            css.Append(
                "td {padding:7px;text-alig:center;" +
                "border: 10px solid #ddd;" +
                "font-family: Arial, Helvetica, sans-serif;" +
                "font-weight:bold;" +
                "text-align:center;}");

            css.Append("th {text-decoration: underline;}");

            css.Append("h1{color: #00afbb;" + " text-align: center;}");
            css.Append("div{position: absolute; width: 50 %; bottom: 25px; border: 5px solid #00afbb;} ");// my Name
            css.Append("</style>");
            // __________________________________________________HTML BODY______________________________________
            html.Append("<html>");
            html.Append($"<head>{css}<title>{"San Jose Sharks"} </title></head>");
            //html.Append(" <img src= https://www.sanjoseinside.com/wp-content/uploads/2020/05/maxresdefault-7.jpg>");
            html.Append("<body>");
            html.Append($"<h1>{"San Jose Sharks Hockey Team"}</h1>");
            


            // Create table data 
            // Craete table data 
            //<TABLE> and </TABLE> is the start and end of a table of rows and data.
            //<TR> and </TR> is one row of data. They contain <TD> and </TD> tags.
            //<TD> and </TD> represents the data inside of the table in a particular row
            // https://WWW.W3schools.com/tags/tag table.asp

            // I used an </HR> tag which is a "horizantol rule " as  table data.
            // You can "span" it across multiple columns of data.

            SQLiteDataReader dr;
            SQLiteCommand cmd;
            cmd = sqlite_conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM SJsharks";
            // use reader to get data from table
            dr = cmd.ExecuteReader();
            html.Append("<table>");
            // SUb Titles "ID\t\tPlayer Name\t\tAge\t\tNumber\t\tOrigin\t\tPosition\t\tShoots"
            html.Append($"<tr><th>{"ID"}</th><th>{"Player Name"}</th><th>{"Age"}</th><th>{"Number"}</th><th>{"Origin"}</th><th>{"Position"}</th><th>{"Shoots"}</th></tr>");

            html.Append("<tr><colspan=15></tr>");// (tr) row in the table (td)table data
            html.Append("<tr>");

            //html.Append("<hr/>");// ------????

            while (dr.Read())
            {
                //The numbers in the ( ) should be in ascending order and not be the same thing...you had 0 1 1 1 2 and itr is 0 1 2 3 4   
                // It is placing each field into the myInfo field and each has to be different number.
                myInfo = dr.GetInt32(0) + "\t" + dr.GetString(1) + "\t" + dr.GetInt32(2) + "\t" + dr.GetString(3) + "\t" + dr.GetString(4) + "\t" + dr.GetString(5) + "\t" + dr.GetString(6);// same order

                html.Append($"<td>{dr.GetInt32(0)} </td>");
                html.Append($"<td>{dr.GetString(1)} </td>");
                html.Append($"<td>{dr.GetInt32(2)} </td>");
                html.Append($"<td>{dr.GetString(3)} </td>");
                html.Append($"<td>{dr.GetString(4)} </td>");
                html.Append($"<td>{dr.GetString(5)} </td>");
                html.Append($"<td>{dr.GetString(6)} </td>");

                
                html.Append("<tr>"); // to Close the row
             
            }
            html.Append("<tr><td><colspan=6></td></tr>");
           
            
            html.Append("</table>");
            html.Append($"<div>{"Created by: Miriam Lira"}</div>");

            html.Append("</body></html");
            // ____________________________________________END OF HTML BODY_____________________________________
            return html;

        }
        private void PrintReport(StringBuilder html)
        {


            //    write to Hard Drive using the name report.html
            //   ___________________________________________________REPORT_____________________________________________________
            try
            {
                // using stament will automatically close a file after opening it
                using (StreamWriter wr = new StreamWriter("Report.html"))
                {
                    wr.WriteLine(html);
                }
                System.Diagnostics.Process.Start(@"Report.html");
            }
            catch (Exception)
            {
                MessageBox.Show("You do not have write permissions", "Error System Permissions",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            //  Current Date/ Time
            DateTime today = DateTime.Now;
            using (StreamWriter wr = new StreamWriter($"{today.ToString("yyyy-MM-dd-HHmmss")} - Report.html"))
            {
                wr.WriteLine(html);
            }

        }

        private void btn_GenReport_Click(object sender, EventArgs e)
        {
            PrintReport(GenerateReport());
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            About myForm = new About();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


