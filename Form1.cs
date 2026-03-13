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

        // ─────────────────────────────────────────────
        //  FORM LOAD — populate both grids on startup
        // ─────────────────────────────────────────────
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshCountries();
            RefreshInformations();
        }

        // ══════════════════════════════════════════════
        //  COUNTRIES — CRUD
        // ══════════════════════════════════════════════

        /// <summary>Loads all Countries records into the Countries DataGridView.</summary>
        private void RefreshCountries()
        {
            try
            {
                DataTable dt = new();
                string query = "SELECT ID, country, iso2, iso3 FROM Countries ORDER BY ID";
                using OleDbConnection conn = new(connectionString);
                using OleDbCommand cmd = new(query, conn);
                using OleDbDataAdapter adapter = new(cmd);
                adapter.Fill(dt);
                dgvCountries.DataSource = dt;
            }
            catch (Exception ex)
            {
                ShowError("Failed to load Countries: " + ex.Message);
            }
        }

        /// <summary>Inserts a new country row.</summary>
        public void InsertCountry(int id, string country, string iso2, string iso3)
        {
            string query = "INSERT INTO Countries (ID, country, iso2, iso3) VALUES (?, ?, ?, ?)";
            using OleDbConnection conn = new(connectionString);
            using OleDbCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@p1", id);
            cmd.Parameters.AddWithValue("@p2", country);
            cmd.Parameters.AddWithValue("@p3", iso2);
            cmd.Parameters.AddWithValue("@p4", iso3);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        /// <summary>Updates an existing country row by ID.</summary>
        public void UpdateCountry(int id, string newCountry, string newIso2, string newIso3)
        {
            string query = "UPDATE Countries SET country = ?, iso2 = ?, iso3 = ? WHERE ID = ?";
            using OleDbConnection conn = new(connectionString);
            using OleDbCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@p1", newCountry);
            cmd.Parameters.AddWithValue("@p2", newIso2);
            cmd.Parameters.AddWithValue("@p3", newIso3);
            cmd.Parameters.AddWithValue("@p4", id);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        /// <summary>Deletes a country row by ID.</summary>
        public void DeleteCountry(int id)
        {
            string query = "DELETE FROM Countries WHERE ID = ?";
            using OleDbConnection conn = new(connectionString);
            using OleDbCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@p1", id);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        // ══════════════════════════════════════════════
        //  INFORMATIONS — CRUD
        // ══════════════════════════════════════════════

        /// <summary>Loads all Informations records into the Informations DataGridView.</summary>
        private void RefreshInformations()
        {
            try
            {
                DataTable dt = new();
                string query = "SELECT ID, indicator, unit, source, cts_code, cts_name, cts_full_descriptor FROM Informations ORDER BY ID";
                using OleDbConnection conn = new(connectionString);
                using OleDbCommand cmd = new(query, conn);
                using OleDbDataAdapter adapter = new(cmd);
                adapter.Fill(dt);
                dgvInformations.DataSource = dt;
            }
            catch (Exception ex)
            {
                ShowError("Failed to load Informations: " + ex.Message);
            }
        }

        /// <summary>Inserts a new Informations row.</summary>
        public void InsertInformation(int id, string indicator, string unit, string source,
                                      string ctsCode, string ctsName, string ctsFullDescriptor)
        {
            string query = @"INSERT INTO Informations (ID, indicator, unit, source, cts_code, cts_name, cts_full_descriptor)
                             VALUES (?, ?, ?, ?, ?, ?, ?)";
            using OleDbConnection conn = new(connectionString);
            using OleDbCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@p1", id);
            cmd.Parameters.AddWithValue("@p2", indicator);
            cmd.Parameters.AddWithValue("@p3", unit);
            cmd.Parameters.AddWithValue("@p4", source);
            cmd.Parameters.AddWithValue("@p5", ctsCode);
            cmd.Parameters.AddWithValue("@p6", ctsName);
            cmd.Parameters.AddWithValue("@p7", ctsFullDescriptor);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        /// <summary>Updates an existing Informations row by ID.</summary>
        public void UpdateInformation(int id, string indicator, string unit, string source,
                                      string ctsCode, string ctsName, string ctsFullDescriptor)
        {
            string query = @"UPDATE Informations SET indicator = ?, unit = ?, source = ?,
                             cts_code = ?, cts_name = ?, cts_full_descriptor = ? WHERE ID = ?";
            using OleDbConnection conn = new(connectionString);
            using OleDbCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@p1", indicator);
            cmd.Parameters.AddWithValue("@p2", unit);
            cmd.Parameters.AddWithValue("@p3", source);
            cmd.Parameters.AddWithValue("@p4", ctsCode);
            cmd.Parameters.AddWithValue("@p5", ctsName);
            cmd.Parameters.AddWithValue("@p6", ctsFullDescriptor);
            cmd.Parameters.AddWithValue("@p7", id);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        /// <summary>Deletes an Informations row by ID.</summary>
        public void DeleteInformation(int id)
        {
            string query = "DELETE FROM Informations WHERE ID = ?";
            using OleDbConnection conn = new(connectionString);
            using OleDbCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@p1", id);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        // ══════════════════════════════════════════════
        //  STATISTICS — Read-only (year columns, linked)
        // ══════════════════════════════════════════════

        /// <summary>Loads Statistics joined with country name for the selected country ID.</summary>
        private void LoadStatisticsForCountry(int countryId)
        {
            try
            {
                DataTable dt = new();
                // Join Statistics with Countries to show the country name alongside the year data
                string query = @"SELECT s.ObjectId, c.country, s.F2018, s.F2019, s.F2020, s.F2021, s.F2022
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
                ShowError("Failed to load Statistics: " + ex.Message);
            }
        }

        // ══════════════════════════════════════════════
        //  BUTTON EVENT HANDLERS — Countries Tab
        // ══════════════════════════════════════════════

        private void btnCountryInsert_Click(object sender, EventArgs e)
        {
            if (!TryParseCountryId(txtCountryId.Text, out int id)) return;
            if (string.IsNullOrWhiteSpace(txtCountryName.Text))
            {
                ShowError("Country name cannot be empty.");
                return;
            }
            try
            {
                InsertCountry(id, txtCountryName.Text.Trim(),
                              txtIso2.Text.Trim(), txtIso3.Text.Trim());
                ShowSuccess("Country inserted successfully.");
                ClearCountryFields();
                RefreshCountries();
            }
            catch (Exception ex) { ShowError("Insert failed: " + ex.Message); }
        }

        private void btnCountryUpdate_Click(object sender, EventArgs e)
        {
            if (!TryParseCountryId(txtCountryId.Text, out int id)) return;
            try
            {
                UpdateCountry(id, txtCountryName.Text.Trim(),
                              txtIso2.Text.Trim(), txtIso3.Text.Trim());
                ShowSuccess("Country updated successfully.");
                ClearCountryFields();
                RefreshCountries();
            }
            catch (Exception ex) { ShowError("Update failed: " + ex.Message); }
        }

        private void btnCountryDelete_Click(object sender, EventArgs e)
        {
            if (!TryParseCountryId(txtCountryId.Text, out int id)) return;
            var confirm = MessageBox.Show(
                $"Delete country with ID {id}?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;
            try
            {
                DeleteCountry(id);
                ShowSuccess("Country deleted successfully.");
                ClearCountryFields();
                RefreshCountries();
            }
            catch (Exception ex) { ShowError("Delete failed: " + ex.Message); }
        }

        private void btnCountryRefresh_Click(object sender, EventArgs e) => RefreshCountries();

        /// <summary>Clicking a row in the Countries grid fills the input fields.</summary>
        private void dgvCountries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvCountries.Rows[e.RowIndex];
            txtCountryId.Text = row.Cells["ID"].Value?.ToString() ?? "";
            txtCountryName.Text = row.Cells["country"].Value?.ToString() ?? "";
            txtIso2.Text = row.Cells["iso2"].Value?.ToString() ?? "";
            txtIso3.Text = row.Cells["iso3"].Value?.ToString() ?? "";

            // Also load the statistics for this country
            if (int.TryParse(txtCountryId.Text, out int id))
                LoadStatisticsForCountry(id);
        }

        // ══════════════════════════════════════════════
        //  BUTTON EVENT HANDLERS — Informations Tab
        // ══════════════════════════════════════════════

        private void btnInfoInsert_Click(object sender, EventArgs e)
        {
            if (!TryParseInfoId(txtInfoId.Text, out int id)) return;
            try
            {
                InsertInformation(id,
                    txtIndicator.Text.Trim(), txtUnit.Text.Trim(),
                    txtSource.Text.Trim(), txtCtsCode.Text.Trim(),
                    txtCtsName.Text.Trim(), txtCtsFullDescriptor.Text.Trim());
                ShowSuccess("Information inserted successfully.");
                ClearInfoFields();
                RefreshInformations();
            }
            catch (Exception ex) { ShowError("Insert failed: " + ex.Message); }
        }

        private void btnInfoUpdate_Click(object sender, EventArgs e)
        {
            if (!TryParseInfoId(txtInfoId.Text, out int id)) return;
            try
            {
                UpdateInformation(id,
                    txtIndicator.Text.Trim(), txtUnit.Text.Trim(),
                    txtSource.Text.Trim(), txtCtsCode.Text.Trim(),
                    txtCtsName.Text.Trim(), txtCtsFullDescriptor.Text.Trim());
                ShowSuccess("Information updated successfully.");
                ClearInfoFields();
                RefreshInformations();
            }
            catch (Exception ex) { ShowError("Update failed: " + ex.Message); }
        }

        private void btnInfoDelete_Click(object sender, EventArgs e)
        {
            if (!TryParseInfoId(txtInfoId.Text, out int id)) return;
            var confirm = MessageBox.Show(
                $"Delete information record with ID {id}?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;
            try
            {
                DeleteInformation(id);
                ShowSuccess("Information deleted successfully.");
                ClearInfoFields();
                RefreshInformations();
            }
            catch (Exception ex) { ShowError("Delete failed: " + ex.Message); }
        }

        private void btnInfoRefresh_Click(object sender, EventArgs e) => RefreshInformations();

        /// <summary>Clicking a row in the Informations grid fills the input fields.</summary>
        private void dgvInformations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvInformations.Rows[e.RowIndex];
            txtInfoId.Text = row.Cells["ID"].Value?.ToString() ?? "";
            txtIndicator.Text = row.Cells["indicator"].Value?.ToString() ?? "";
            txtUnit.Text = row.Cells["unit"].Value?.ToString() ?? "";
            txtSource.Text = row.Cells["source"].Value?.ToString() ?? "";
            txtCtsCode.Text = row.Cells["cts_code"].Value?.ToString() ?? "";
            txtCtsName.Text = row.Cells["cts_name"].Value?.ToString() ?? "";
            txtCtsFullDescriptor.Text = row.Cells["cts_full_descriptor"].Value?.ToString() ?? "";
        }

        // ══════════════════════════════════════════════
        //  HELPERS
        // ══════════════════════════════════════════════

        private bool TryParseCountryId(string text, out int id)
        {
            if (int.TryParse(text, out id)) return true;
            ShowError("Please enter a valid numeric ID.");
            return false;
        }

        private bool TryParseInfoId(string text, out int id)
        {
            if (int.TryParse(text, out id)) return true;
            ShowError("Please enter a valid numeric ID.");
            return false;
        }

        private void ClearCountryFields()
        {
            txtCountryId.Clear();
            txtCountryName.Clear();
            txtIso2.Clear();
            txtIso3.Clear();
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

        private static void ShowSuccess(string message) =>
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private static void ShowError(string message) =>
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}