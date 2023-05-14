namespace StrongPointHomeTask
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lenteleListView = new System.Windows.Forms.ListView();
            this.IdClmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PavadinimasClmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KiekisClmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KainaClmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchIndicatorLbl = new System.Windows.Forms.Label();
            this.helpChckBox = new System.Windows.Forms.CheckBox();
            this.searchHelpLbl = new System.Windows.Forms.Label();
            this.addHelpLbl = new System.Windows.Forms.Label();
            this.editHelpLbl = new System.Windows.Forms.Label();
            this.sortHelpLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lenteleListView
            // 
            this.lenteleListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdClmn,
            this.PavadinimasClmn,
            this.KiekisClmn,
            this.KainaClmn});
            this.lenteleListView.FullRowSelect = true;
            this.lenteleListView.HideSelection = false;
            this.lenteleListView.Location = new System.Drawing.Point(187, 104);
            this.lenteleListView.Name = "lenteleListView";
            this.lenteleListView.Size = new System.Drawing.Size(819, 400);
            this.lenteleListView.TabIndex = 0;
            this.lenteleListView.UseCompatibleStateImageBehavior = false;
            this.lenteleListView.View = System.Windows.Forms.View.Details;
            // 
            // IdClmn
            // 
            this.IdClmn.Text = "Id";
            this.IdClmn.Width = 51;
            // 
            // PavadinimasClmn
            // 
            this.PavadinimasClmn.Text = "Pavadinimas";
            this.PavadinimasClmn.Width = 126;
            // 
            // KiekisClmn
            // 
            this.KiekisClmn.Text = "Kiekis";
            this.KiekisClmn.Width = 98;
            // 
            // KainaClmn
            // 
            this.KainaClmn.Text = "Kaina";
            this.KainaClmn.Width = 73;
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Location = new System.Drawing.Point(309, 72);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(375, 26);
            this.searchTxtBox.TabIndex = 1;
            this.searchTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTxtBox_KeyDown);
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Location = new System.Drawing.Point(187, 78);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(116, 20);
            this.searchLbl.TabIndex = 2;
            this.searchLbl.Text = "Id/Pavadinimas";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(49, 104);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(132, 49);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Pridėti";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(49, 159);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(132, 49);
            this.removeBtn.TabIndex = 4;
            this.removeBtn.Text = "Ištrinti";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(49, 214);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(132, 49);
            this.editBtn.TabIndex = 5;
            this.editBtn.Text = "Redaguoti";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(49, 269);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(132, 49);
            this.sortBtn.TabIndex = 6;
            this.sortBtn.Text = "Rušiuoti (Pav.)";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(690, 70);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 31);
            this.searchBtn.TabIndex = 7;
            this.searchBtn.Text = "Ieškoti";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchIndicatorLbl
            // 
            this.searchIndicatorLbl.AutoSize = true;
            this.searchIndicatorLbl.ForeColor = System.Drawing.Color.Red;
            this.searchIndicatorLbl.Location = new System.Drawing.Point(187, 511);
            this.searchIndicatorLbl.Name = "searchIndicatorLbl";
            this.searchIndicatorLbl.Size = new System.Drawing.Size(135, 20);
            this.searchIndicatorLbl.TabIndex = 8;
            this.searchIndicatorLbl.Text = "Neteisinga įvestis!";
            this.searchIndicatorLbl.Visible = false;
            // 
            // helpChckBox
            // 
            this.helpChckBox.AutoSize = true;
            this.helpChckBox.Location = new System.Drawing.Point(913, 70);
            this.helpChckBox.Name = "helpChckBox";
            this.helpChckBox.Size = new System.Drawing.Size(93, 24);
            this.helpChckBox.TabIndex = 9;
            this.helpChckBox.Text = "Pagalba";
            this.helpChckBox.UseVisualStyleBackColor = true;
            this.helpChckBox.CheckedChanged += new System.EventHandler(this.helpChckBox_CheckedChanged);
            // 
            // searchHelpLbl
            // 
            this.searchHelpLbl.ForeColor = System.Drawing.Color.Fuchsia;
            this.searchHelpLbl.Location = new System.Drawing.Point(314, 2);
            this.searchHelpLbl.Name = "searchHelpLbl";
            this.searchHelpLbl.Size = new System.Drawing.Size(353, 67);
            this.searchHelpLbl.TabIndex = 10;
            this.searchHelpLbl.Text = "Įrašius tik skaičius paieška bus atitaikyta konkrečio ID radimui, įvedus ką nors " +
    "kito bus ieškoma pavadinimo kuris turi įvestus žodžius";
            this.searchHelpLbl.Visible = false;
            // 
            // addHelpLbl
            // 
            this.addHelpLbl.ForeColor = System.Drawing.Color.Fuchsia;
            this.addHelpLbl.Location = new System.Drawing.Point(-3, 338);
            this.addHelpLbl.Name = "addHelpLbl";
            this.addHelpLbl.Size = new System.Drawing.Size(184, 89);
            this.addHelpLbl.TabIndex = 11;
            this.addHelpLbl.Text = "Pridėti - Atsidarius naujam langui turėsite įvesti naujos eilutės duomenis.";
            this.addHelpLbl.Visible = false;
            // 
            // editHelpLbl
            // 
            this.editHelpLbl.ForeColor = System.Drawing.Color.Fuchsia;
            this.editHelpLbl.Location = new System.Drawing.Point(-3, 427);
            this.editHelpLbl.Name = "editHelpLbl";
            this.editHelpLbl.Size = new System.Drawing.Size(180, 100);
            this.editHelpLbl.TabIndex = 12;
            this.editHelpLbl.Text = "Redaguoti ir Ištrinti veiks tik tada kai pažymėsite viena ar kelias eilutes esanč" +
    "ias lentelėje";
            this.editHelpLbl.Visible = false;
            // 
            // sortHelpLbl
            // 
            this.sortHelpLbl.AutoSize = true;
            this.sortHelpLbl.ForeColor = System.Drawing.Color.Fuchsia;
            this.sortHelpLbl.Location = new System.Drawing.Point(1, 543);
            this.sortHelpLbl.Name = "sortHelpLbl";
            this.sortHelpLbl.Size = new System.Drawing.Size(712, 20);
            this.sortHelpLbl.TabIndex = 13;
            this.sortHelpLbl.Text = "Rušiuoti galite tik dvejais būdais: Pagal pavadinima (abėcelės tvarka), arba paga" +
    "l ID (didėjimo tvarka)";
            this.sortHelpLbl.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 575);
            this.Controls.Add(this.sortHelpLbl);
            this.Controls.Add(this.editHelpLbl);
            this.Controls.Add(this.addHelpLbl);
            this.Controls.Add(this.searchHelpLbl);
            this.Controls.Add(this.helpChckBox);
            this.Controls.Add(this.searchIndicatorLbl);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.searchLbl);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.lenteleListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Inventorius";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.EnabledChanged += new System.EventHandler(this.MainForm_EnabledChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lenteleListView;
        private System.Windows.Forms.ColumnHeader IdClmn;
        private System.Windows.Forms.ColumnHeader PavadinimasClmn;
        private System.Windows.Forms.ColumnHeader KiekisClmn;
        private System.Windows.Forms.ColumnHeader KainaClmn;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label searchIndicatorLbl;
        private System.Windows.Forms.CheckBox helpChckBox;
        private System.Windows.Forms.Label searchHelpLbl;
        private System.Windows.Forms.Label addHelpLbl;
        private System.Windows.Forms.Label editHelpLbl;
        private System.Windows.Forms.Label sortHelpLbl;
    }
}

