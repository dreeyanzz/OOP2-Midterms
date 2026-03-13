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
            // ── Declare all controls ──
            tabControl1          = new TabControl();
            tabCountries         = new TabPage();
            tabInformations      = new TabPage();
            tabStatistics        = new TabPage();

            dgvCountries         = new DataGridView();
            dgvInformations      = new DataGridView();
            dgvStatistics        = new DataGridView();

            // Countries form controls
            lblCountryId         = new Label();
            txtCountryId         = new TextBox();
            lblCountryName       = new Label();
            txtCountryName       = new TextBox();
            lblIso2              = new Label();
            txtIso2              = new TextBox();
            lblIso3              = new Label();
            txtIso3              = new TextBox();
            btnCountryInsert     = new Button();
            btnCountryUpdate     = new Button();
            btnCountryDelete     = new Button();
            btnCountryRefresh    = new Button();

            // Informations form controls
            lblInfoId            = new Label();
            txtInfoId            = new TextBox();
            lblIndicator         = new Label();
            txtIndicator         = new TextBox();
            lblUnit              = new Label();
            txtUnit              = new TextBox();
            lblSource            = new Label();
            txtSource            = new TextBox();
            lblCtsCode           = new Label();
            txtCtsCode           = new TextBox();
            lblCtsName           = new Label();
            txtCtsName           = new TextBox();
            lblCtsFullDescriptor = new Label();
            txtCtsFullDescriptor = new TextBox();
            btnInfoInsert        = new Button();
            btnInfoUpdate        = new Button();
            btnInfoDelete        = new Button();
            btnInfoRefresh       = new Button();

            lblStatsHint         = new Label();

            // ── Tab Control ──
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 10F);
            tabControl1.Controls.Add(tabCountries);
            tabControl1.Controls.Add(tabInformations);
            tabControl1.Controls.Add(tabStatistics);

            // ════════════════════════════════════════════
            //  TAB 1: COUNTRIES
            // ════════════════════════════════════════════
            tabCountries.Text      = "Countries";
            tabCountries.BackColor = Color.WhiteSmoke;
            tabCountries.Padding   = new Padding(8);

            // Grid
            dgvCountries.Location                          = new Point(12, 12);
            dgvCountries.Size                              = new Size(860, 840);
            dgvCountries.Anchor                            = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom;
            dgvCountries.AutoSizeColumnsMode               = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCountries.SelectionMode                     = DataGridViewSelectionMode.FullRowSelect;
            dgvCountries.ReadOnly                          = true;
            dgvCountries.AllowUserToAddRows                = false;
            dgvCountries.RowHeadersVisible                 = false;
            dgvCountries.BackgroundColor                   = Color.White;
            dgvCountries.BorderStyle                       = BorderStyle.FixedSingle;
            dgvCountries.Font                              = new Font("Segoe UI", 9.5F);
            dgvCountries.ColumnHeadersDefaultCellStyle     = MakeHeaderStyle();
            dgvCountries.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 245, 255);
            dgvCountries.CellClick                        += dgvCountries_CellClick;

            // Form panel — Country fields
            int px = 890, fw = 510;

            MakeLabel(lblCountryId,   "ID",           px, 12,  fw);
            MakeText (txtCountryId,                   px, 34,  fw);
            MakeLabel(lblCountryName, "Country Name", px, 72,  fw);
            MakeText (txtCountryName,                 px, 94,  fw);
            MakeLabel(lblIso2,        "ISO2",         px, 132, fw);
            MakeText (txtIso2,                        px, 154, fw);
            MakeLabel(lblIso3,        "ISO3",         px, 192, fw);
            MakeText (txtIso3,                        px, 214, fw);

            MakeBtn(btnCountryInsert,  "Insert",  px,       260, 120, Color.FromArgb(39, 174, 96));
            MakeBtn(btnCountryUpdate,  "Update",  px + 130, 260, 120, Color.FromArgb(41, 128, 185));
            MakeBtn(btnCountryDelete,  "Delete",  px + 260, 260, 120, Color.FromArgb(192, 57, 43));
            MakeBtn(btnCountryRefresh, "Refresh", px + 390, 260, 110, Color.FromArgb(127, 140, 141));

            btnCountryInsert.Click  += btnCountryInsert_Click;
            btnCountryUpdate.Click  += btnCountryUpdate_Click;
            btnCountryDelete.Click  += btnCountryDelete_Click;
            btnCountryRefresh.Click += btnCountryRefresh_Click;

            tabCountries.Controls.Add(dgvCountries);
            tabCountries.Controls.Add(lblCountryId);
            tabCountries.Controls.Add(txtCountryId);
            tabCountries.Controls.Add(lblCountryName);
            tabCountries.Controls.Add(txtCountryName);
            tabCountries.Controls.Add(lblIso2);
            tabCountries.Controls.Add(txtIso2);
            tabCountries.Controls.Add(lblIso3);
            tabCountries.Controls.Add(txtIso3);
            tabCountries.Controls.Add(btnCountryInsert);
            tabCountries.Controls.Add(btnCountryUpdate);
            tabCountries.Controls.Add(btnCountryDelete);
            tabCountries.Controls.Add(btnCountryRefresh);

            // ════════════════════════════════════════════
            //  TAB 2: INFORMATIONS
            // ════════════════════════════════════════════
            tabInformations.Text      = "Informations";
            tabInformations.BackColor = Color.WhiteSmoke;
            tabInformations.Padding   = new Padding(8);

            dgvInformations.Location                          = new Point(12, 12);
            dgvInformations.Size                              = new Size(860, 840);
            dgvInformations.Anchor                            = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom;
            dgvInformations.AutoSizeColumnsMode               = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInformations.SelectionMode                     = DataGridViewSelectionMode.FullRowSelect;
            dgvInformations.ReadOnly                          = true;
            dgvInformations.AllowUserToAddRows                = false;
            dgvInformations.RowHeadersVisible                 = false;
            dgvInformations.BackgroundColor                   = Color.White;
            dgvInformations.BorderStyle                       = BorderStyle.FixedSingle;
            dgvInformations.Font                              = new Font("Segoe UI", 9.5F);
            dgvInformations.ColumnHeadersDefaultCellStyle     = MakeHeaderStyle();
            dgvInformations.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 245, 255);
            dgvInformations.CellClick                        += dgvInformations_CellClick;

            // Info fields
            MakeLabel(lblInfoId,            "ID",                   px, 12,  fw);
            MakeText (txtInfoId,                                     px, 34,  fw);
            MakeLabel(lblIndicator,         "Indicator",            px, 72,  fw);
            MakeMultiText(txtIndicator,                              px, 94,  fw, 55);
            MakeLabel(lblUnit,              "Unit",                  px, 162, fw);
            MakeText (txtUnit,                                       px, 184, fw);
            MakeLabel(lblSource,            "Source",               px, 222, fw);
            MakeMultiText(txtSource,                                 px, 244, fw, 55);
            MakeLabel(lblCtsCode,           "CTS Code",             px, 312, fw);
            MakeText (txtCtsCode,                                    px, 334, fw);
            MakeLabel(lblCtsName,           "CTS Name",             px, 372, fw);
            MakeText (txtCtsName,                                    px, 394, fw);
            MakeLabel(lblCtsFullDescriptor, "CTS Full Descriptor",  px, 432, fw);
            MakeMultiText(txtCtsFullDescriptor,                      px, 454, fw, 55);

            MakeBtn(btnInfoInsert,  "Insert",  px,       530, 120, Color.FromArgb(39, 174, 96));
            MakeBtn(btnInfoUpdate,  "Update",  px + 130, 530, 120, Color.FromArgb(41, 128, 185));
            MakeBtn(btnInfoDelete,  "Delete",  px + 260, 530, 120, Color.FromArgb(192, 57, 43));
            MakeBtn(btnInfoRefresh, "Refresh", px + 390, 530, 110, Color.FromArgb(127, 140, 141));

            btnInfoInsert.Click  += btnInfoInsert_Click;
            btnInfoUpdate.Click  += btnInfoUpdate_Click;
            btnInfoDelete.Click  += btnInfoDelete_Click;
            btnInfoRefresh.Click += btnInfoRefresh_Click;

            tabInformations.Controls.Add(dgvInformations);
            tabInformations.Controls.Add(lblInfoId);
            tabInformations.Controls.Add(txtInfoId);
            tabInformations.Controls.Add(lblIndicator);
            tabInformations.Controls.Add(txtIndicator);
            tabInformations.Controls.Add(lblUnit);
            tabInformations.Controls.Add(txtUnit);
            tabInformations.Controls.Add(lblSource);
            tabInformations.Controls.Add(txtSource);
            tabInformations.Controls.Add(lblCtsCode);
            tabInformations.Controls.Add(txtCtsCode);
            tabInformations.Controls.Add(lblCtsName);
            tabInformations.Controls.Add(txtCtsName);
            tabInformations.Controls.Add(lblCtsFullDescriptor);
            tabInformations.Controls.Add(txtCtsFullDescriptor);
            tabInformations.Controls.Add(btnInfoInsert);
            tabInformations.Controls.Add(btnInfoUpdate);
            tabInformations.Controls.Add(btnInfoDelete);
            tabInformations.Controls.Add(btnInfoRefresh);

            // ════════════════════════════════════════════
            //  TAB 3: STATISTICS (read-only)
            // ════════════════════════════════════════════
            tabStatistics.Text      = "Statistics";
            tabStatistics.BackColor = Color.WhiteSmoke;

            lblStatsHint.Text      = "Click any row in the Countries tab to view its temperature statistics here.";
            lblStatsHint.Font      = new Font("Segoe UI", 9.5F, FontStyle.Italic);
            lblStatsHint.ForeColor = Color.FromArgb(90, 90, 90);
            lblStatsHint.Location  = new Point(12, 12);
            lblStatsHint.Size      = new Size(900, 22);

            dgvStatistics.Location                          = new Point(12, 44);
            dgvStatistics.Size                              = new Size(1400, 820);
            dgvStatistics.Anchor                            = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvStatistics.AutoSizeColumnsMode               = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvStatistics.ReadOnly                          = true;
            dgvStatistics.AllowUserToAddRows                = false;
            dgvStatistics.RowHeadersVisible                 = false;
            dgvStatistics.BackgroundColor                   = Color.White;
            dgvStatistics.BorderStyle                       = BorderStyle.FixedSingle;
            dgvStatistics.Font                              = new Font("Segoe UI", 9.5F);
            dgvStatistics.ColumnHeadersDefaultCellStyle     = MakeHeaderStyle();
            dgvStatistics.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 245, 255);

            tabStatistics.Controls.Add(lblStatsHint);
            tabStatistics.Controls.Add(dgvStatistics);

            // ── Form ──
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode       = AutoScaleMode.Font;
            ClientSize          = new Size(1451, 920);
            Controls.Add(tabControl1);
            Name           = "Form1";
            StartPosition  = FormStartPosition.CenterScreen;
            Text           = "Climate Change Indicators";
        }

        // ── Layout helpers ────────────────────────────────────────

        private static DataGridViewCellStyle MakeHeaderStyle() => new()
        {
            BackColor = Color.FromArgb(41, 98, 178),
            ForeColor = Color.White,
            Font      = new Font("Segoe UI", 10F, FontStyle.Bold)
        };

        private static void MakeLabel(Label lbl, string text, int x, int y, int w)
        {
            lbl.Text      = text;
            lbl.Font      = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl.ForeColor = Color.FromArgb(50, 50, 50);
            lbl.Location  = new Point(x, y);
            lbl.Size      = new Size(w, 18);
        }

        private static void MakeText(TextBox txt, int x, int y, int w)
        {
            txt.Location    = new Point(x, y);
            txt.Size        = new Size(w, 28);
            txt.Font        = new Font("Segoe UI", 10F);
            txt.BorderStyle = BorderStyle.FixedSingle;
        }

        private static void MakeMultiText(TextBox txt, int x, int y, int w, int h)
        {
            txt.Location     = new Point(x, y);
            txt.Size         = new Size(w, h);
            txt.Font         = new Font("Segoe UI", 9.5F);
            txt.BorderStyle  = BorderStyle.FixedSingle;
            txt.Multiline    = true;
            txt.ScrollBars   = ScrollBars.Vertical;
        }

        private static void MakeBtn(Button btn, string text, int x, int y, int w, Color color)
        {
            btn.Text             = text;
            btn.Location         = new Point(x, y);
            btn.Size             = new Size(w, 38);
            btn.Font             = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.BackColor        = color;
            btn.ForeColor        = Color.White;
            btn.FlatStyle        = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor           = Cursors.Hand;
        }

        #endregion

        // ── Countries tab ──────────────────────────────────────────
        private TabControl  tabControl1;
        private TabPage     tabCountries;
        private DataGridView dgvCountries;
        private Label       lblCountryId, lblCountryName, lblIso2, lblIso3;
        private TextBox     txtCountryId, txtCountryName, txtIso2, txtIso3;
        private Button      btnCountryInsert, btnCountryUpdate, btnCountryDelete, btnCountryRefresh;

        // ── Informations tab ───────────────────────────────────────
        private TabPage     tabInformations;
        private DataGridView dgvInformations;
        private Label       lblInfoId, lblIndicator, lblUnit, lblSource;
        private Label       lblCtsCode, lblCtsName, lblCtsFullDescriptor;
        private TextBox     txtInfoId, txtIndicator, txtUnit, txtSource;
        private TextBox     txtCtsCode, txtCtsName, txtCtsFullDescriptor;
        private Button      btnInfoInsert, btnInfoUpdate, btnInfoDelete, btnInfoRefresh;

        // ── Statistics tab ─────────────────────────────────────────
        private TabPage      tabStatistics;
        private DataGridView dgvStatistics;
        private Label        lblStatsHint;
    }
}