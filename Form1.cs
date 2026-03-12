using System.Data;
using System.Data.OleDb;

namespace OOP2_Midterms
{
    public partial class Form1 : Form
    {
        private readonly string connectionString =
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\dreeyanzz\Documents\dev\OOP2_Midterms\Database1.accdb;Persist Security Info=False;";

        public Form1()
        {
            InitializeComponent();
        }

        public void InsertRecord(string firstName, string lastName)
        {
            // The ? marks where the parameters will go
            string query = "INSERT INTO Employees (FirstName, LastName) VALUES (?, ?)";

            using OleDbConnection conn = new(connectionString);
            using OleDbCommand cmd = new(query, conn);
            // Order matters!
            // 1st parameter matches the 1st ? (FirstName)
            cmd.Parameters.AddWithValue("@p1", firstName);
            // 2nd parameter matches the 2nd ? (LastName)
            cmd.Parameters.AddWithValue("@p2", lastName);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public DataTable GetRecords()
        {
            DataTable dt = new();
            string query = "SELECT Id, FirstName, LastName FROM Employees";

            using (OleDbConnection conn = new(connectionString))
            using (OleDbCommand cmd = new(query, conn))
            using (OleDbDataAdapter adapter = new(cmd))
            {
                // The DataAdapter automatically opens and closes the connection
                adapter.Fill(dt);
            }

            // In your form, you would do: dataGridView1.DataSource = GetRecords();
            return dt;
        }

        public void UpdateRecord(int id, string newFirstName, string newLastName)
        {
            string query = "UPDATE Employees SET FirstName = ?, LastName = ? WHERE Id = ?";

            using (OleDbConnection conn = new(connectionString))
            using (OleDbCommand cmd = new(query, conn))
            {
                // 1. First ? is FirstName
                cmd.Parameters.AddWithValue("@p1", newFirstName);
                // 2. Second ? is LastName
                cmd.Parameters.AddWithValue("@p2", newLastName);
                // 3. Third ? is the Id in the WHERE clause
                cmd.Parameters.AddWithValue("@p3", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteRecord(int id)
        {
            string query = "DELETE FROM Employees WHERE Id = ?";

            using OleDbConnection conn = new(connectionString);
            using OleDbCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@p1", id);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
