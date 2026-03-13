using System.Data;
using System.Data.OleDb;

namespace OOP2_Midterms
{
    public partial class Form1 : Form
    {
        private readonly string connectionString =
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\L63X09W20\Documents\dev\OOP2-Midterms\Database1.accdb;Persist Security Info=False;";

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshCountries();
            RefreshInformations();
        }

        // ══════════════════════════════════════════════
        //  COUNTRIES
        // ══════════════════════════════════════════════

        private void RefreshCountries()
        {
            try
            {
                DataTable dt = new();
                using OleDbConnection conn = new(connectionString);
                using OleDbCommand cmd = new(
                    "SELECT ID, country, iso2, iso3 FROM Countries ORDER BY ID",
                    conn
                );
                using OleDbDataAdapter adapter = new(cmd);
                adapter.Fill(dt);
                dgvCountries.DataSource = dt;
            }
            catch (Exception ex)
            {
                Error("Failed to load Countries: " + ex.Message);
            }
        }

        private void btnCountryInsert_Click(object sender, EventArgs e)
        {
            if (!ValidateCountryInputs(out int id))
                return;
            try
            {
                using OleDbConnection conn = new(connectionString);
                using OleDbCommand cmd = new(
                    "INSERT INTO Countries (ID, country, iso2, iso3) VALUES (?, ?, ?, ?)",
                    conn
                );
                cmd.Parameters.AddWithValue("@p1", id);
                cmd.Parameters.AddWithValue("@p2", txtCountryName.Text.Trim());
                cmd.Parameters.AddWithValue("@p3", txtIso2.Text.Trim());
                cmd.Parameters.AddWithValue("@p4", txtIso3.Text.Trim());
                conn.Open();
                cmd.ExecuteNonQuery();
                Success("Country inserted.");
                ClearCountryFields();
                RefreshCountries();
            }
            catch (Exception ex)
            {
                Error("Insert failed: " + ex.Message);
            }
        }

        private void btnCountryUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateCountryInputs(out int id))
                return;
            try
            {
                using OleDbConnection conn = new(connectionString);
                using OleDbCommand cmd = new(
                    "UPDATE Countries SET country = ?, iso2 = ?, iso3 = ? WHERE ID = ?",
                    conn
                );
                cmd.Parameters.AddWithValue("@p1", txtCountryName.Text.Trim());
                cmd.Parameters.AddWithValue("@p2", txtIso2.Text.Trim());
                cmd.Parameters.AddWithValue("@p3", txtIso3.Text.Trim());
                cmd.Parameters.AddWithValue("@p4", id);
                conn.Open();
                cmd.ExecuteNonQuery();
                Success("Country updated.");
                ClearCountryFields();
                RefreshCountries();
            }
            catch (Exception ex)
            {
                Error("Update failed: " + ex.Message);
            }
        }

        private void btnCountryDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCountryId.Text.Trim(), out int id))
            {
                Error("Select a row first.");
                return;
            }
            if (
                MessageBox.Show(
                    $"Delete country ID {id}?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                ) != DialogResult.Yes
            )
                return;
            try
            {
                using OleDbConnection conn = new(connectionString);
                using OleDbCommand cmd = new("DELETE FROM Countries WHERE ID = ?", conn);
                cmd.Parameters.AddWithValue("@p1", id);
                conn.Open();
                cmd.ExecuteNonQuery();
                Success("Country deleted.");
                ClearCountryFields();
                RefreshCountries();
            }
            catch (Exception ex)
            {
                Error("Delete failed: " + ex.Message);
            }
        }

        private void btnCountryRefresh_Click(object sender, EventArgs e) => RefreshCountries();

        private void dgvCountries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var row = dgvCountries.Rows[e.RowIndex];
            txtCountryId.Text = row.Cells["ID"].Value?.ToString() ?? "";
            txtCountryName.Text = row.Cells["country"].Value?.ToString() ?? "";
            txtIso2.Text = row.Cells["iso2"].Value?.ToString() ?? "";
            txtIso3.Text = row.Cells["iso3"].Value?.ToString() ?? "";
            if (int.TryParse(txtCountryId.Text, out int id))
                LoadStatistics(id);
        }

        private bool ValidateCountryInputs(out int id)
        {
            id = 0;
            if (!int.TryParse(txtCountryId.Text.Trim(), out id))
            {
                Error("ID must be a valid number.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCountryName.Text))
            {
                Error("Country name cannot be empty.");
                return false;
            }
            return true;
        }

        private void ClearCountryFields()
        {
            txtCountryId.Clear();
            txtCountryName.Clear();
            txtIso2.Clear();
            txtIso3.Clear();
        }

        // ══════════════════════════════════════════════
        //  INFORMATIONS
        // ══════════════════════════════════════════════

        private void RefreshInformations()
        {
            try
            {
                DataTable dt = new();
                using OleDbConnection conn = new(connectionString);
                using OleDbCommand cmd = new(
                    "SELECT ID, indicator, unit, source, cts_code, cts_name, cts_full_descriptor FROM Informations ORDER BY ID",
                    conn
                );
                using OleDbDataAdapter adapter = new(cmd);
                adapter.Fill(dt);
                dgvInformations.DataSource = dt;
            }
            catch (Exception ex)
            {
                Error("Failed to load Informations: " + ex.Message);
            }
        }

        private void btnInfoInsert_Click(object sender, EventArgs e)
        {
            if (!ValidateInfoInputs(out int id))
                return;
            try
            {
                using OleDbConnection conn = new(connectionString);
                using OleDbCommand cmd = new(
                    "INSERT INTO Informations (ID, indicator, unit, source, cts_code, cts_name, cts_full_descriptor) VALUES (?, ?, ?, ?, ?, ?, ?)",
                    conn
                );
                cmd.Parameters.AddWithValue("@p1", id);
                cmd.Parameters.AddWithValue("@p2", txtIndicator.Text.Trim());
                cmd.Parameters.AddWithValue("@p3", txtUnit.Text.Trim());
                cmd.Parameters.AddWithValue("@p4", txtSource.Text.Trim());
                cmd.Parameters.AddWithValue("@p5", txtCtsCode.Text.Trim());
                cmd.Parameters.AddWithValue("@p6", txtCtsName.Text.Trim());
                cmd.Parameters.AddWithValue("@p7", txtCtsFullDescriptor.Text.Trim());
                conn.Open();
                cmd.ExecuteNonQuery();
                Success("Information inserted.");
                ClearInfoFields();
                RefreshInformations();
            }
            catch (Exception ex)
            {
                Error("Insert failed: " + ex.Message);
            }
        }

        private void btnInfoUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInfoInputs(out int id))
                return;
            try
            {
                using OleDbConnection conn = new(connectionString);
                using OleDbCommand cmd = new(
                    "UPDATE Informations SET indicator = ?, unit = ?, source = ?, cts_code = ?, cts_name = ?, cts_full_descriptor = ? WHERE ID = ?",
                    conn
                );
                cmd.Parameters.AddWithValue("@p1", txtIndicator.Text.Trim());
                cmd.Parameters.AddWithValue("@p2", txtUnit.Text.Trim());
                cmd.Parameters.AddWithValue("@p3", txtSource.Text.Trim());
                cmd.Parameters.AddWithValue("@p4", txtCtsCode.Text.Trim());
                cmd.Parameters.AddWithValue("@p5", txtCtsName.Text.Trim());
                cmd.Parameters.AddWithValue("@p6", txtCtsFullDescriptor.Text.Trim());
                cmd.Parameters.AddWithValue("@p7", id);
                conn.Open();
                cmd.ExecuteNonQuery();
                Success("Information updated.");
                ClearInfoFields();
                RefreshInformations();
            }
            catch (Exception ex)
            {
                Error("Update failed: " + ex.Message);
            }
        }

        private void btnInfoDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtInfoId.Text.Trim(), out int id))
            {
                Error("Select a row first.");
                return;
            }
            if (
                MessageBox.Show(
                    $"Delete information ID {id}?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                ) != DialogResult.Yes
            )
                return;
            try
            {
                using OleDbConnection conn = new(connectionString);
                using OleDbCommand cmd = new("DELETE FROM Informations WHERE ID = ?", conn);
                cmd.Parameters.AddWithValue("@p1", id);
                conn.Open();
                cmd.ExecuteNonQuery();
                Success("Information deleted.");
                ClearInfoFields();
                RefreshInformations();
            }
            catch (Exception ex)
            {
                Error("Delete failed: " + ex.Message);
            }
        }

        private void btnInfoRefresh_Click(object sender, EventArgs e) => RefreshInformations();

        private void dgvInformations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var row = dgvInformations.Rows[e.RowIndex];
            txtInfoId.Text = row.Cells["ID"].Value?.ToString() ?? "";
            txtIndicator.Text = row.Cells["indicator"].Value?.ToString() ?? "";
            txtUnit.Text = row.Cells["unit"].Value?.ToString() ?? "";
            txtSource.Text = row.Cells["source"].Value?.ToString() ?? "";
            txtCtsCode.Text = row.Cells["cts_code"].Value?.ToString() ?? "";
            txtCtsName.Text = row.Cells["cts_name"].Value?.ToString() ?? "";
            txtCtsFullDescriptor.Text = row.Cells["cts_full_descriptor"].Value?.ToString() ?? "";
        }

        private bool ValidateInfoInputs(out int id)
        {
            id = 0;
            if (!int.TryParse(txtInfoId.Text.Trim(), out id))
            {
                Error("ID must be a valid number.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtIndicator.Text))
            {
                Error("Indicator cannot be empty.");
                return false;
            }
            return true;
        }

        private void ClearInfoFields()
        {
            txtInfoId.Clear();
            txtIndicator.Clear();
            txtUnit.Clear();
            txtSource.Clear();
            txtCtsCode.Clear();
            txtCtsName.Clear();
            txtCtsFullDescriptor.Clear();
        }

        // ══════════════════════════════════════════════
        //  STATISTICS — read-only, loads on country click
        // ══════════════════════════════════════════════

        private void LoadStatistics(int countryId)
        {
            try
            {
                DataTable dt = new();
                string query =
                    @"SELECT s.ObjectId, c.country, s.F2018, s.F2019, s.F2020, s.F2021, s.F2022
                                 FROM Statistics AS s
                                 INNER JOIN Countries AS c ON s.ObjectId = c.ID
                                 WHERE s.ObjectId = ?";
                using OleDbConnection conn = new(connectionString);
                using OleDbCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@p1", countryId);
                using OleDbDataAdapter adapter = new(cmd);
                adapter.Fill(dt);
                dgvStatistics.DataSource = dt;
            }
            catch (Exception ex)
            {
                Error("Failed to load Statistics: " + ex.Message);
            }
        }

        // ══════════════════════════════════════════════
        //  HELPERS
        // ══════════════════════════════════════════════

        private static void Success(string msg) =>
            MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private static void Error(string msg) =>
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
