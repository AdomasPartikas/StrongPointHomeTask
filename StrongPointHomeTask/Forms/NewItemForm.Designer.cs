namespace StrongPointHomeTask.Forms
{
    partial class AddItemFrm
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.idLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.quantityTxtBox = new System.Windows.Forms.TextBox();
            this.priceLbl = new System.Windows.Forms.Label();
            this.priceTxtBox = new System.Windows.Forms.TextBox();
            this.nameIndicatorLbl = new System.Windows.Forms.Label();
            this.quantityIndicatorLbl = new System.Windows.Forms.Label();
            this.priceIndicatorLbl = new System.Windows.Forms.Label();
            this.indicationLbl = new System.Windows.Forms.Label();
            this.idHelpLbl = new System.Windows.Forms.Label();
            this.nameHelpLbl = new System.Windows.Forms.Label();
            this.quantityHelpLbl = new System.Windows.Forms.Label();
            this.priceHelp = new System.Windows.Forms.Label();
            this.helpChckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(91, 381);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(145, 58);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.Text = "Atšaukti";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(242, 381);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(145, 58);
            this.addItemBtn.TabIndex = 1;
            this.addItemBtn.Text = "Pridėti";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // idTxtBox
            // 
            this.idTxtBox.Enabled = false;
            this.idTxtBox.Location = new System.Drawing.Point(186, 62);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(178, 26);
            this.idTxtBox.TabIndex = 2;
            this.idTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(153, 68);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(27, 20);
            this.idLbl.TabIndex = 3;
            this.idLbl.Text = "Id:";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(78, 122);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(102, 20);
            this.nameLbl.TabIndex = 5;
            this.nameLbl.Text = "Pavadinimas:";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(186, 116);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(178, 26);
            this.nameTxtBox.TabIndex = 4;
            this.nameTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Location = new System.Drawing.Point(126, 181);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(54, 20);
            this.quantityLbl.TabIndex = 7;
            this.quantityLbl.Text = "Kiekis:";
            // 
            // quantityTxtBox
            // 
            this.quantityTxtBox.Location = new System.Drawing.Point(186, 175);
            this.quantityTxtBox.Name = "quantityTxtBox";
            this.quantityTxtBox.Size = new System.Drawing.Size(178, 26);
            this.quantityTxtBox.TabIndex = 6;
            this.quantityTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(126, 243);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(53, 20);
            this.priceLbl.TabIndex = 9;
            this.priceLbl.Text = "Kaina:";
            // 
            // priceTxtBox
            // 
            this.priceTxtBox.Location = new System.Drawing.Point(186, 237);
            this.priceTxtBox.Name = "priceTxtBox";
            this.priceTxtBox.Size = new System.Drawing.Size(178, 26);
            this.priceTxtBox.TabIndex = 8;
            this.priceTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nameIndicatorLbl
            // 
            this.nameIndicatorLbl.AutoSize = true;
            this.nameIndicatorLbl.ForeColor = System.Drawing.Color.Red;
            this.nameIndicatorLbl.Location = new System.Drawing.Point(370, 116);
            this.nameIndicatorLbl.Name = "nameIndicatorLbl";
            this.nameIndicatorLbl.Size = new System.Drawing.Size(15, 20);
            this.nameIndicatorLbl.TabIndex = 10;
            this.nameIndicatorLbl.Text = "*";
            this.nameIndicatorLbl.Visible = false;
            // 
            // quantityIndicatorLbl
            // 
            this.quantityIndicatorLbl.AutoSize = true;
            this.quantityIndicatorLbl.ForeColor = System.Drawing.Color.Red;
            this.quantityIndicatorLbl.Location = new System.Drawing.Point(370, 175);
            this.quantityIndicatorLbl.Name = "quantityIndicatorLbl";
            this.quantityIndicatorLbl.Size = new System.Drawing.Size(15, 20);
            this.quantityIndicatorLbl.TabIndex = 11;
            this.quantityIndicatorLbl.Text = "*";
            this.quantityIndicatorLbl.Visible = false;
            // 
            // priceIndicatorLbl
            // 
            this.priceIndicatorLbl.AutoSize = true;
            this.priceIndicatorLbl.ForeColor = System.Drawing.Color.Red;
            this.priceIndicatorLbl.Location = new System.Drawing.Point(370, 237);
            this.priceIndicatorLbl.Name = "priceIndicatorLbl";
            this.priceIndicatorLbl.Size = new System.Drawing.Size(15, 20);
            this.priceIndicatorLbl.TabIndex = 12;
            this.priceIndicatorLbl.Text = "*";
            this.priceIndicatorLbl.Visible = false;
            // 
            // indicationLbl
            // 
            this.indicationLbl.AutoSize = true;
            this.indicationLbl.ForeColor = System.Drawing.Color.Red;
            this.indicationLbl.Location = new System.Drawing.Point(116, 358);
            this.indicationLbl.Name = "indicationLbl";
            this.indicationLbl.Size = new System.Drawing.Size(257, 20);
            this.indicationLbl.TabIndex = 13;
            this.indicationLbl.Text = "Viena ar daugiau įvestis neteisinga!";
            this.indicationLbl.Visible = false;
            // 
            // idHelpLbl
            // 
            this.idHelpLbl.AutoSize = true;
            this.idHelpLbl.ForeColor = System.Drawing.Color.Fuchsia;
            this.idHelpLbl.Location = new System.Drawing.Point(182, 39);
            this.idHelpLbl.Name = "idHelpLbl";
            this.idHelpLbl.Size = new System.Drawing.Size(205, 20);
            this.idHelpLbl.TabIndex = 37;
            this.idHelpLbl.Text = "Id suteikiamas automatiškai";
            this.idHelpLbl.Visible = false;
            // 
            // nameHelpLbl
            // 
            this.nameHelpLbl.AutoSize = true;
            this.nameHelpLbl.ForeColor = System.Drawing.Color.Fuchsia;
            this.nameHelpLbl.Location = new System.Drawing.Point(182, 93);
            this.nameHelpLbl.Name = "nameHelpLbl";
            this.nameHelpLbl.Size = new System.Drawing.Size(161, 20);
            this.nameHelpLbl.TabIndex = 36;
            this.nameHelpLbl.Text = "Įvesties forma: Laisva";
            this.nameHelpLbl.Visible = false;
            // 
            // quantityHelpLbl
            // 
            this.quantityHelpLbl.AutoSize = true;
            this.quantityHelpLbl.ForeColor = System.Drawing.Color.Fuchsia;
            this.quantityHelpLbl.Location = new System.Drawing.Point(182, 152);
            this.quantityHelpLbl.Name = "quantityHelpLbl";
            this.quantityHelpLbl.Size = new System.Drawing.Size(125, 20);
            this.quantityHelpLbl.TabIndex = 35;
            this.quantityHelpLbl.Text = "Įvesties forma: 0";
            this.quantityHelpLbl.Visible = false;
            // 
            // priceHelp
            // 
            this.priceHelp.AutoSize = true;
            this.priceHelp.ForeColor = System.Drawing.Color.Fuchsia;
            this.priceHelp.Location = new System.Drawing.Point(182, 214);
            this.priceHelp.Name = "priceHelp";
            this.priceHelp.Size = new System.Drawing.Size(156, 20);
            this.priceHelp.TabIndex = 34;
            this.priceHelp.Text = "Įvesties forma: 00.00";
            this.priceHelp.Visible = false;
            // 
            // helpChckBox
            // 
            this.helpChckBox.AutoSize = true;
            this.helpChckBox.Location = new System.Drawing.Point(271, 269);
            this.helpChckBox.Name = "helpChckBox";
            this.helpChckBox.Size = new System.Drawing.Size(93, 24);
            this.helpChckBox.TabIndex = 33;
            this.helpChckBox.Text = "Pagalba";
            this.helpChckBox.UseVisualStyleBackColor = true;
            this.helpChckBox.CheckedChanged += new System.EventHandler(this.helpChckBox_CheckedChanged);
            // 
            // AddItemFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 451);
            this.Controls.Add(this.idHelpLbl);
            this.Controls.Add(this.nameHelpLbl);
            this.Controls.Add(this.quantityHelpLbl);
            this.Controls.Add(this.priceHelp);
            this.Controls.Add(this.helpChckBox);
            this.Controls.Add(this.indicationLbl);
            this.Controls.Add(this.priceIndicatorLbl);
            this.Controls.Add(this.quantityIndicatorLbl);
            this.Controls.Add(this.nameIndicatorLbl);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.priceTxtBox);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.quantityTxtBox);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.cancelBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddItemFrm";
            this.Text = "Pridėti";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddItemFrm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.TextBox quantityTxtBox;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.TextBox priceTxtBox;
        private System.Windows.Forms.Label nameIndicatorLbl;
        private System.Windows.Forms.Label quantityIndicatorLbl;
        private System.Windows.Forms.Label priceIndicatorLbl;
        private System.Windows.Forms.Label indicationLbl;
        private System.Windows.Forms.Label idHelpLbl;
        private System.Windows.Forms.Label nameHelpLbl;
        private System.Windows.Forms.Label quantityHelpLbl;
        private System.Windows.Forms.Label priceHelp;
        private System.Windows.Forms.CheckBox helpChckBox;
    }
}