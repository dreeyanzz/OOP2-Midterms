namespace OOP2_Midterms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabCountries = new TabPage();
            tabInformations = new TabPage();
            tabStatistics = new TabPage();

            // ── Countries tab controls ──
            dgvCountries = new DataGridView();
            pnlCountryForm = new Panel();
            lblCountryTitle = new Label();
            lblCountryId = new Label();
            txtCountryId = new TextBox();
            lblCountryName = new Label();
            txtCountryName = new TextBox();
            lblIso2 = new Label();
            txtIso2 = new TextBox();
            lblIso3 = new Label();
            txtIso3 = new TextBox();
            btnCountryInsert = new Button();
            btnCountryUpdate = new Button();
            btnCountryDelete = new Button();
            btnCountryRefresh = new Button();

            // ── Informations tab controls ──
            dgvInformations = new DataGridView();
            pnlInfoForm = new Panel();
            lblInfoTitle = new Label();
            lblInfoId = new Label();
            txtInfoId = new TextBox();
            lblIndicator = new Label();
            txtIndicator = new TextBox();
            lblUnit = new Label();
            txtUnit = new TextBox();
            lblSource = new Label();
            txtSource = new TextBox();
            lblCtsCode = new Label();
            txtCtsCode = new TextBox();
            lblCtsName = new Label();
            txtCtsName = new TextBox();
            lblCtsFullDescriptor = new Label();
            txtCtsFullDescriptor = new TextBox();
            btnInfoInsert = new Button();
            btnInfoUpdate = new Button();
            btnInfoDelete = new Button();
            btnInfoRefresh = new Button();

            // ── Statistics tab controls ──
            dgvStatistics = new DataGridView();
            lblStatsHint = new Label();

            // ════════════════════════════════
            //  TAB CONTROL
            // ════════════════════════════════
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 10F);
            tabControl1.Controls.Add(tabCountries);
            tabControl1.Controls.Add(tabInformations);
            tabControl1.Controls.Add(tabStatistics);

            // ════════════════════════════════
            //  TAB: COUNTRIES
            // ════════════════════════════════
            tabCountries.Text = "🌍  Countries";
            tabCountries.Padding = new Padding(10);
            tabCountries.BackColor = Color.FromArgb(245, 248, 252);

            // Grid
            dgvCountries.Location = new Point(12, 12);
            dgvCountries.Size = new Size(900, 820);
            dgvCountries.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom;
            dgvCountries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCountries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCountries.ReadOnly = true;
            dgvCountries.AllowUserToAddRows = false;
            dgvCountries.BackgroundColor = Color.White;
            dgvCountries.BorderStyle = BorderStyle.None;
            dgvCountries.RowHeadersVisible = false;
            dgvCountries.Font = new Font("Segoe UI", 9.5F);
            dgvCountries.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 98, 178);
            dgvCountries.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCountries.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvCountries.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 242, 255);
            dgvCountries.CellClick += dgvCountries_CellClick;

            // Side panel
            pnlCountryForm.Location = new Point(930, 12);
            pnlCountryForm.Size = new Size(490, 820);
            pnlCountryForm.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
            pnlCountryForm.BackColor = Color.White;
            pnlCountryForm.Padding = new Padding(20);

            lblCountryTitle.Text = "Country Record";
            lblCountryTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCountryTitle.ForeColor = Color.FromArgb(41, 98, 178);
            lblCountryTitle.Location = new Point(20, 20);
            lblCountryTitle.Size = new Size(450, 30);

            SetupLabel(lblCountryId, "ID", 70);
            SetupTextBox(txtCountryId, 70);
            SetupLabel(lblCountryName, "Country Name", 130);
            SetupTextBox(txtCountryName, 130);
            SetupLabel(lblIso2, "ISO2 Code", 190);
            SetupTextBox(txtIso2, 190);
            SetupLabel(lblIso3, "ISO3 Code", 250);
            SetupTextBox(txtIso3, 250);

            SetupButton(btnCountryInsert, "➕  Insert", 340, Color.FromArgb(34, 139, 34));
            SetupButton(btnCountryUpdate, "✏️  Update", 395, Color.FromArgb(41, 98, 178));
            SetupButton(btnCountryDelete, "🗑️  Delete", 450, Color.FromArgb(192, 57, 43));
            SetupButton(btnCountryRefresh, "🔄  Refresh", 520, Color.FromArgb(100, 100, 100));

            btnCountryInsert.Click += btnCountryInsert_Click;
            btnCountryUpdate.Click += btnCountryUpdate_Click;
            btnCountryDelete.Click += btnCountryDelete_Click;
            btnCountryRefresh.Click += btnCountryRefresh_Click;

            pnlCountryForm.Controls.AddRange(new Control[] {
                lblCountryTitle,
                lblCountryId, txtCountryId,
                lblCountryName, txtCountryName,
                lblIso2, txtIso2,
                lblIso3, txtIso3,
                btnCountryInsert, btnCountryUpdate,
                btnCountryDelete, btnCountryRefresh
            });

            tabCountries.Controls.Add(dgvCountries);
            tabCountries.Controls.Add(pnlCountryForm);

            // ════════════════════════════════
            //  TAB: INFORMATIONS
            // ════════════════════════════════
            tabInformations.Text = "📋  Informations";
            tabInformations.Padding = new Padding(10);
            tabInformations.BackColor = Color.FromArgb(245, 248, 252);

            dgvInformations.Location = new Point(12, 12);
            dgvInformations.Size = new Size(900, 820);
            dgvInformations.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom;
            dgvInformations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInformations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInformations.ReadOnly = true;
            dgvInformations.AllowUserToAddRows = false;
            dgvInformations.BackgroundColor = Color.White;
            dgvInformations.BorderStyle = BorderStyle.None;
            dgvInformations.RowHeadersVisible = false;
            dgvInformations.Font = new Font("Segoe UI", 9.5F);
            dgvInformations.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 98, 178);
            dgvInformations.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvInformations.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvInformations.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 242, 255);
            dgvInformations.CellClick += dgvInformations_CellClick;

            pnlInfoForm.Location = new Point(930, 12);
            pnlInfoForm.Size = new Size(490, 820);
            pnlInfoForm.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
            pnlInfoForm.BackColor = Color.White;
            pnlInfoForm.Padding = new Padding(20);

            lblInfoTitle.Text = "Information Record";
            lblInfoTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblInfoTitle.ForeColor = Color.FromArgb(41, 98, 178);
            lblInfoTitle.Location = new Point(20, 20);
            lblInfoTitle.Size = new Size(450, 30);

            SetupLabel(lblInfoId, "ID", 70);
            SetupTextBox(txtInfoId, 70);
            SetupLabel(lblIndicator, "Indicator", 130);
            SetupMultilineTextBox(txtIndicator, 130, 60);
            SetupLabel(lblUnit, "Unit", 210);
            SetupTextBox(txtUnit, 210);
            SetupLabel(lblSource, "Source", 270);
            SetupMultilineTextBox(txtSource, 270, 60);
            SetupLabel(lblCtsCode, "CTS Code", 350);
            SetupTextBox(txtCtsCode, 350);
            SetupLabel(lblCtsName, "CTS Name", 410);
            SetupTextBox(txtCtsName, 410);
            SetupLabel(lblCtsFullDescriptor, "CTS Full Descriptor", 470);
            SetupMultilineTextBox(txtCtsFullDescriptor, 470, 60);

            SetupButton(btnInfoInsert, "➕  Insert", 560, Color.FromArgb(34, 139, 34));
            SetupButton(btnInfoUpdate, "✏️  Update", 615, Color.FromArgb(41, 98, 178));
            SetupButton(btnInfoDelete, "🗑️  Delete", 670, Color.FromArgb(192, 57, 43));
            SetupButton(btnInfoRefresh, "🔄  Refresh", 740, Color.FromArgb(100, 100, 100));

            btnInfoInsert.Click += btnInfoInsert_Click;
            btnInfoUpdate.Click += btnInfoUpdate_Click;
            btnInfoDelete.Click += btnInfoDelete_Click;
            btnInfoRefresh.Click += btnInfoRefresh_Click;

            pnlInfoForm.Controls.AddRange(new Control[] {
                lblInfoTitle,
                lblInfoId, txtInfoId,
                lblIndicator, txtIndicator,
                lblUnit, txtUnit,
                lblSource, txtSource,
                lblCtsCode, txtCtsCode,
                lblCtsName, txtCtsName,
                lblCtsFullDescriptor, txtCtsFullDescriptor,
                btnInfoInsert, btnInfoUpdate,
                btnInfoDelete, btnInfoRefresh
            });

            tabInformations.Controls.Add(dgvInformations);
            tabInformations.Controls.Add(pnlInfoForm);

            // ════════════════════════════════
            //  TAB: STATISTICS (read-only)
            // ════════════════════════════════
            tabStatistics.Text = "📊  Statistics";
            tabStatistics.Padding = new Padding(10);
            tabStatistics.BackColor = Color.FromArgb(245, 248, 252);

            lblStatsHint.Text = "💡 Click a row in the Countries tab to view its temperature statistics here.";
            lblStatsHint.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblStatsHint.ForeColor = Color.FromArgb(80, 80, 80);
            lblStatsHint.Location = new Point(12, 12);
            lblStatsHint.Size = new Size(900, 28);

            dgvStatistics.Location = new Point(12, 48);
            dgvStatistics.Size = new Size(1400, 800);
            dgvStatistics.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvStatistics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvStatistics.ReadOnly = true;
            dgvStatistics.AllowUserToAddRows = false;
            dgvStatistics.BackgroundColor = Color.White;
            dgvStatistics.BorderStyle = BorderStyle.None;
            dgvStatistics.RowHeadersVisible = false;
            dgvStatistics.Font = new Font("Segoe UI", 9.5F);
            dgvStatistics.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 98, 178);
            dgvStatistics.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvStatistics.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvStatistics.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 242, 255);

            tabStatistics.Controls.Add(lblStatsHint);
            tabStatistics.Controls.Add(dgvStatistics);

            // ════════════════════════════════
            //  FORM
            // ════════════════════════════════
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1451, 920);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Climate Change Indicators — OOP2 Midterm";
        }

        // ── Layout helpers ──────────────────────────────

        private static void SetupLabel(Label lbl, string text, int top)
        {
            lbl.Text = text;
            lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl.ForeColor = Color.FromArgb(60, 60, 60);
            lbl.Location = new Point(20, top);
            lbl.Size = new Size(450, 20);
        }

        private static void SetupTextBox(TextBox txt, int top)
        {
            txt.Location = new Point(20, top + 22);
            txt.Size = new Size(450, 26);
            txt.Font = new Font("Segoe UI", 10F);
            txt.BorderStyle = BorderStyle.FixedSingle;
        }

        private static void SetupMultilineTextBox(TextBox txt, int top, int height)
        {
            txt.Location = new Point(20, top + 22);
            txt.Size = new Size(450, height);
            txt.Font = new Font("Segoe UI", 9.5F);
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Multiline = true;
            txt.ScrollBars = ScrollBars.Vertical;
        }

        private static void SetupButton(Button btn, string text, int top, Color backColor)
        {
            btn.Text = text;
            btn.Location = new Point(20, top);
            btn.Size = new Size(200, 44);
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.BackColor = backColor;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
        }

        #endregion

        // ── Countries tab ──
        private TabControl tabControl1;
        private TabPage tabCountries;
        private DataGridView dgvCountries;
        private Panel pnlCountryForm;
        private Label lblCountryTitle, lblCountryId, lblCountryName, lblIso2, lblIso3;
        private TextBox txtCountryId, txtCountryName, txtIso2, txtIso3;
        private Button btnCountryInsert, btnCountryUpdate, btnCountryDelete, btnCountryRefresh;

        // ── Informations tab ──
        private TabPage tabInformations;
        private DataGridView dgvInformations;
        private Panel pnlInfoForm;
        private Label lblInfoTitle, lblInfoId, lblIndicator, lblUnit, lblSource;
        private Label lblCtsCode, lblCtsName, lblCtsFullDescriptor;
        private TextBox txtInfoId, txtIndicator, txtUnit, txtSource;
        private TextBox txtCtsCode, txtCtsName, txtCtsFullDescriptor;
        private Button btnInfoInsert, btnInfoUpdate, btnInfoDelete, btnInfoRefresh;

        // ── Statistics tab ──
        private TabPage tabStatistics;
        private DataGridView dgvStatistics;
        private Label lblStatsHint;
    }
}