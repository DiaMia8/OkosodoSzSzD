namespace OkosodoUI
{
    partial class AdminMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenuForm));
            this.mainMenuLabel = new System.Windows.Forms.Label();
            this.udvLabel = new System.Windows.Forms.Label();
            this.udvozloNevLabel = new System.Windows.Forms.Label();
            this.diakokLabel = new System.Windows.Forms.Label();
            this.diakListBox = new System.Windows.Forms.ListBox();
            this.diakBeleptetesButton = new System.Windows.Forms.Button();
            this.ujDiakgroupBox = new System.Windows.Forms.GroupBox();
            this.ujDiakKeresztNevTextBox = new System.Windows.Forms.TextBox();
            this.ukDiakKeresztNevlabel = new System.Windows.Forms.Label();
            this.ujDiakSzuletesiDatumdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ujDiakSzuletettLabel = new System.Windows.Forms.Label();
            this.ujDiakRegisztralasButton = new System.Windows.Forms.Button();
            this.ujDiakSzuloEmailTextBox = new System.Windows.Forms.TextBox();
            this.ujDiakBecenevTextBox = new System.Windows.Forms.TextBox();
            this.ujDiakSzuloEmailLabel = new System.Windows.Forms.Label();
            this.ujDiakBecenevLabel = new System.Windows.Forms.Label();
            this.ujDiakSzuloNeveTextBox = new System.Windows.Forms.TextBox();
            this.ujDiakVezetekNevTextBox = new System.Windows.Forms.TextBox();
            this.ujDiakSzuloNevLabel = new System.Windows.Forms.Label();
            this.ujDiakVezetekNevLabel = new System.Windows.Forms.Label();
            this.vagyLabel = new System.Windows.Forms.Label();
            this.adminIdLabel = new System.Windows.Forms.Label();
            this.ujDiakgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuLabel
            // 
            this.mainMenuLabel.AutoSize = true;
            this.mainMenuLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainMenuLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.mainMenuLabel.Location = new System.Drawing.Point(24, 22);
            this.mainMenuLabel.Name = "mainMenuLabel";
            this.mainMenuLabel.Size = new System.Drawing.Size(213, 65);
            this.mainMenuLabel.TabIndex = 1;
            this.mainMenuLabel.Text = "Okosodó";
            // 
            // udvLabel
            // 
            this.udvLabel.AutoSize = true;
            this.udvLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.udvLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.udvLabel.Location = new System.Drawing.Point(28, 98);
            this.udvLabel.Name = "udvLabel";
            this.udvLabel.Size = new System.Drawing.Size(153, 38);
            this.udvLabel.TabIndex = 7;
            this.udvLabel.Text = "Üdvözöllek";
            // 
            // udvozloNevLabel
            // 
            this.udvozloNevLabel.AutoSize = true;
            this.udvozloNevLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.udvozloNevLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.udvozloNevLabel.Location = new System.Drawing.Point(187, 98);
            this.udvozloNevLabel.Name = "udvozloNevLabel";
            this.udvozloNevLabel.Size = new System.Drawing.Size(99, 38);
            this.udvozloNevLabel.TabIndex = 8;
            this.udvozloNevLabel.Text = "<nev>";
            // 
            // diakokLabel
            // 
            this.diakokLabel.AutoSize = true;
            this.diakokLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.diakokLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.diakokLabel.Location = new System.Drawing.Point(38, 152);
            this.diakokLabel.Name = "diakokLabel";
            this.diakokLabel.Size = new System.Drawing.Size(108, 38);
            this.diakokLabel.TabIndex = 10;
            this.diakokLabel.Text = "Diákok:";
            // 
            // diakListBox
            // 
            this.diakListBox.BackColor = System.Drawing.Color.White;
            this.diakListBox.FormattingEnabled = true;
            this.diakListBox.ItemHeight = 16;
            this.diakListBox.Location = new System.Drawing.Point(35, 193);
            this.diakListBox.Name = "diakListBox";
            this.diakListBox.Size = new System.Drawing.Size(282, 260);
            this.diakListBox.TabIndex = 11;
            // 
            // diakBeleptetesButton
            // 
            this.diakBeleptetesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.diakBeleptetesButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.diakBeleptetesButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.diakBeleptetesButton.Location = new System.Drawing.Point(109, 474);
            this.diakBeleptetesButton.Name = "diakBeleptetesButton";
            this.diakBeleptetesButton.Size = new System.Drawing.Size(128, 64);
            this.diakBeleptetesButton.TabIndex = 12;
            this.diakBeleptetesButton.Text = "Indítás";
            this.diakBeleptetesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.diakBeleptetesButton.UseVisualStyleBackColor = true;
            // 
            // ujDiakgroupBox
            // 
            this.ujDiakgroupBox.Controls.Add(this.ujDiakKeresztNevTextBox);
            this.ujDiakgroupBox.Controls.Add(this.ukDiakKeresztNevlabel);
            this.ujDiakgroupBox.Controls.Add(this.ujDiakSzuletesiDatumdateTimePicker);
            this.ujDiakgroupBox.Controls.Add(this.ujDiakSzuletettLabel);
            this.ujDiakgroupBox.Controls.Add(this.ujDiakRegisztralasButton);
            this.ujDiakgroupBox.Controls.Add(this.ujDiakSzuloEmailTextBox);
            this.ujDiakgroupBox.Controls.Add(this.ujDiakBecenevTextBox);
            this.ujDiakgroupBox.Controls.Add(this.ujDiakSzuloEmailLabel);
            this.ujDiakgroupBox.Controls.Add(this.ujDiakBecenevLabel);
            this.ujDiakgroupBox.Controls.Add(this.ujDiakSzuloNeveTextBox);
            this.ujDiakgroupBox.Controls.Add(this.ujDiakVezetekNevTextBox);
            this.ujDiakgroupBox.Controls.Add(this.ujDiakSzuloNevLabel);
            this.ujDiakgroupBox.Controls.Add(this.ujDiakVezetekNevLabel);
            this.ujDiakgroupBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ujDiakgroupBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ujDiakgroupBox.Location = new System.Drawing.Point(503, 152);
            this.ujDiakgroupBox.Name = "ujDiakgroupBox";
            this.ujDiakgroupBox.Size = new System.Drawing.Size(502, 473);
            this.ujDiakgroupBox.TabIndex = 13;
            this.ujDiakgroupBox.TabStop = false;
            this.ujDiakgroupBox.Text = "Új diák hozzáadása";
            // 
            // ujDiakKeresztNevTextBox
            // 
            this.ujDiakKeresztNevTextBox.Location = new System.Drawing.Point(189, 106);
            this.ujDiakKeresztNevTextBox.Name = "ujDiakKeresztNevTextBox";
            this.ujDiakKeresztNevTextBox.Size = new System.Drawing.Size(270, 47);
            this.ujDiakKeresztNevTextBox.TabIndex = 18;
            // 
            // ukDiakKeresztNevlabel
            // 
            this.ukDiakKeresztNevlabel.AutoSize = true;
            this.ukDiakKeresztNevlabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.ukDiakKeresztNevlabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ukDiakKeresztNevlabel.Location = new System.Drawing.Point(16, 112);
            this.ukDiakKeresztNevlabel.Name = "ukDiakKeresztNevlabel";
            this.ukDiakKeresztNevlabel.Size = new System.Drawing.Size(162, 37);
            this.ukDiakKeresztNevlabel.TabIndex = 17;
            this.ukDiakKeresztNevlabel.Text = "Kereszt Név:";
            // 
            // ujDiakSzuletesiDatumdateTimePicker
            // 
            this.ujDiakSzuletesiDatumdateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ujDiakSzuletesiDatumdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ujDiakSzuletesiDatumdateTimePicker.Location = new System.Drawing.Point(189, 340);
            this.ujDiakSzuletesiDatumdateTimePicker.Name = "ujDiakSzuletesiDatumdateTimePicker";
            this.ujDiakSzuletesiDatumdateTimePicker.Size = new System.Drawing.Size(270, 34);
            this.ujDiakSzuletesiDatumdateTimePicker.TabIndex = 16;
            this.ujDiakSzuletesiDatumdateTimePicker.Value = new System.DateTime(2020, 3, 26, 10, 42, 44, 0);
            // 
            // ujDiakSzuletettLabel
            // 
            this.ujDiakSzuletettLabel.AutoSize = true;
            this.ujDiakSzuletettLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ujDiakSzuletettLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ujDiakSzuletettLabel.Location = new System.Drawing.Point(16, 340);
            this.ujDiakSzuletettLabel.Name = "ujDiakSzuletettLabel";
            this.ujDiakSzuletettLabel.Size = new System.Drawing.Size(130, 38);
            this.ujDiakSzuletettLabel.TabIndex = 15;
            this.ujDiakSzuletettLabel.Text = "Született:";
            // 
            // ujDiakRegisztralasButton
            // 
            this.ujDiakRegisztralasButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ujDiakRegisztralasButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ujDiakRegisztralasButton.FlatAppearance.BorderSize = 2;
            this.ujDiakRegisztralasButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.ujDiakRegisztralasButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.ujDiakRegisztralasButton.Location = new System.Drawing.Point(189, 390);
            this.ujDiakRegisztralasButton.Name = "ujDiakRegisztralasButton";
            this.ujDiakRegisztralasButton.Size = new System.Drawing.Size(128, 64);
            this.ujDiakRegisztralasButton.TabIndex = 11;
            this.ujDiakRegisztralasButton.Text = "OK";
            this.ujDiakRegisztralasButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ujDiakRegisztralasButton.UseVisualStyleBackColor = true;
            this.ujDiakRegisztralasButton.Click += new System.EventHandler(this.ujDiakRegisztralasButton_Click);
            // 
            // ujDiakSzuloEmailTextBox
            // 
            this.ujDiakSzuloEmailTextBox.Location = new System.Drawing.Point(189, 279);
            this.ujDiakSzuloEmailTextBox.Name = "ujDiakSzuloEmailTextBox";
            this.ujDiakSzuloEmailTextBox.Size = new System.Drawing.Size(270, 47);
            this.ujDiakSzuloEmailTextBox.TabIndex = 14;
            // 
            // ujDiakBecenevTextBox
            // 
            this.ujDiakBecenevTextBox.Location = new System.Drawing.Point(189, 159);
            this.ujDiakBecenevTextBox.Name = "ujDiakBecenevTextBox";
            this.ujDiakBecenevTextBox.Size = new System.Drawing.Size(270, 47);
            this.ujDiakBecenevTextBox.TabIndex = 12;
            // 
            // ujDiakSzuloEmailLabel
            // 
            this.ujDiakSzuloEmailLabel.AutoSize = true;
            this.ujDiakSzuloEmailLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ujDiakSzuloEmailLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ujDiakSzuloEmailLabel.Location = new System.Drawing.Point(16, 285);
            this.ujDiakSzuloEmailLabel.Name = "ujDiakSzuloEmailLabel";
            this.ujDiakSzuloEmailLabel.Size = new System.Drawing.Size(164, 38);
            this.ujDiakSzuloEmailLabel.TabIndex = 13;
            this.ujDiakSzuloEmailLabel.Text = "Szülő email:";
            // 
            // ujDiakBecenevLabel
            // 
            this.ujDiakBecenevLabel.AutoSize = true;
            this.ujDiakBecenevLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.ujDiakBecenevLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ujDiakBecenevLabel.Location = new System.Drawing.Point(16, 165);
            this.ujDiakBecenevLabel.Name = "ujDiakBecenevLabel";
            this.ujDiakBecenevLabel.Size = new System.Drawing.Size(120, 37);
            this.ujDiakBecenevLabel.TabIndex = 11;
            this.ujDiakBecenevLabel.Text = "Becenév:";
            // 
            // ujDiakSzuloNeveTextBox
            // 
            this.ujDiakSzuloNeveTextBox.Location = new System.Drawing.Point(189, 220);
            this.ujDiakSzuloNeveTextBox.Name = "ujDiakSzuloNeveTextBox";
            this.ujDiakSzuloNeveTextBox.Size = new System.Drawing.Size(270, 47);
            this.ujDiakSzuloNeveTextBox.TabIndex = 10;
            // 
            // ujDiakVezetekNevTextBox
            // 
            this.ujDiakVezetekNevTextBox.Location = new System.Drawing.Point(189, 51);
            this.ujDiakVezetekNevTextBox.Name = "ujDiakVezetekNevTextBox";
            this.ujDiakVezetekNevTextBox.Size = new System.Drawing.Size(270, 47);
            this.ujDiakVezetekNevTextBox.TabIndex = 8;
            // 
            // ujDiakSzuloNevLabel
            // 
            this.ujDiakSzuloNevLabel.AutoSize = true;
            this.ujDiakSzuloNevLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ujDiakSzuloNevLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ujDiakSzuloNevLabel.Location = new System.Drawing.Point(16, 226);
            this.ujDiakSzuloNevLabel.Name = "ujDiakSzuloNevLabel";
            this.ujDiakSzuloNevLabel.Size = new System.Drawing.Size(156, 38);
            this.ujDiakSzuloNevLabel.TabIndex = 9;
            this.ujDiakSzuloNevLabel.Text = "Szülő neve:";
            // 
            // ujDiakVezetekNevLabel
            // 
            this.ujDiakVezetekNevLabel.AutoSize = true;
            this.ujDiakVezetekNevLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.ujDiakVezetekNevLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ujDiakVezetekNevLabel.Location = new System.Drawing.Point(16, 57);
            this.ujDiakVezetekNevLabel.Name = "ujDiakVezetekNevLabel";
            this.ujDiakVezetekNevLabel.Size = new System.Drawing.Size(168, 37);
            this.ujDiakVezetekNevLabel.TabIndex = 7;
            this.ujDiakVezetekNevLabel.Text = "Vezeték Név:";
            // 
            // vagyLabel
            // 
            this.vagyLabel.AutoSize = true;
            this.vagyLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vagyLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.vagyLabel.Location = new System.Drawing.Point(372, 283);
            this.vagyLabel.Name = "vagyLabel";
            this.vagyLabel.Size = new System.Drawing.Size(74, 38);
            this.vagyLabel.TabIndex = 14;
            this.vagyLabel.Text = "vagy";
            // 
            // adminIdLabel
            // 
            this.adminIdLabel.AutoSize = true;
            this.adminIdLabel.Location = new System.Drawing.Point(928, 41);
            this.adminIdLabel.Name = "adminIdLabel";
            this.adminIdLabel.Size = new System.Drawing.Size(0, 17);
            this.adminIdLabel.TabIndex = 15;
            this.adminIdLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.adminIdLabel.Visible = false;
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1104, 721);
            this.Controls.Add(this.adminIdLabel);
            this.Controls.Add(this.vagyLabel);
            this.Controls.Add(this.ujDiakgroupBox);
            this.Controls.Add(this.diakBeleptetesButton);
            this.Controls.Add(this.diakListBox);
            this.Controls.Add(this.diakokLabel);
            this.Controls.Add(this.udvozloNevLabel);
            this.Controls.Add(this.udvLabel);
            this.Controls.Add(this.mainMenuLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "AdminMenuForm";
            this.Text = "Okosodó";
            this.ujDiakgroupBox.ResumeLayout(false);
            this.ujDiakgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainMenuLabel;
        private System.Windows.Forms.Label udvLabel;
        private System.Windows.Forms.Label udvozloNevLabel;
        private System.Windows.Forms.Label diakokLabel;
        private System.Windows.Forms.ListBox diakListBox;
        private System.Windows.Forms.Button diakBeleptetesButton;
        private System.Windows.Forms.GroupBox ujDiakgroupBox;
        private System.Windows.Forms.Button ujDiakRegisztralasButton;
        private System.Windows.Forms.TextBox ujDiakSzuloEmailTextBox;
        private System.Windows.Forms.TextBox ujDiakBecenevTextBox;
        private System.Windows.Forms.Label ujDiakSzuloEmailLabel;
        private System.Windows.Forms.Label ujDiakBecenevLabel;
        private System.Windows.Forms.TextBox ujDiakSzuloNeveTextBox;
        private System.Windows.Forms.TextBox ujDiakVezetekNevTextBox;
        private System.Windows.Forms.Label ujDiakSzuloNevLabel;
        private System.Windows.Forms.Label ujDiakVezetekNevLabel;
        private System.Windows.Forms.Label vagyLabel;
        private System.Windows.Forms.DateTimePicker ujDiakSzuletesiDatumdateTimePicker;
        private System.Windows.Forms.Label ujDiakSzuletettLabel;
        private System.Windows.Forms.TextBox ujDiakKeresztNevTextBox;
        private System.Windows.Forms.Label ukDiakKeresztNevlabel;
        private System.Windows.Forms.Label adminIdLabel;
    }
}