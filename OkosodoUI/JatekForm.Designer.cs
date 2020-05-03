namespace OkosodoUI
{
    partial class JatekForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JatekForm));
            this.jatekCimLabel = new System.Windows.Forms.Label();
            this.feladatPictureBox = new System.Windows.Forms.PictureBox();
            this.helpButton = new System.Windows.Forms.Button();
            this.megoldasLabel = new System.Windows.Forms.Label();
            this.ValaszLabel = new System.Windows.Forms.Label();
            this.valaszTextBox = new System.Windows.Forms.TextBox();
            this.valaszButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.feladatPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // jatekCimLabel
            // 
            this.jatekCimLabel.AutoSize = true;
            this.jatekCimLabel.BackColor = System.Drawing.Color.White;
            this.jatekCimLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jatekCimLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.jatekCimLabel.Location = new System.Drawing.Point(25, 27);
            this.jatekCimLabel.Name = "jatekCimLabel";
            this.jatekCimLabel.Size = new System.Drawing.Size(213, 65);
            this.jatekCimLabel.TabIndex = 2;
            this.jatekCimLabel.Text = "Okosodó";
            // 
            // feladatPictureBox
            // 
            this.feladatPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.feladatPictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.feladatPictureBox.Location = new System.Drawing.Point(36, 107);
            this.feladatPictureBox.Name = "feladatPictureBox";
            this.feladatPictureBox.Size = new System.Drawing.Size(800, 600);
            this.feladatPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.feladatPictureBox.TabIndex = 3;
            this.feladatPictureBox.TabStop = false;
            // 
            // helpButton
            // 
            this.helpButton.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.helpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.helpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.helpButton.Font = new System.Drawing.Font("Segoe UI Light", 28.2F);
            this.helpButton.Location = new System.Drawing.Point(890, 576);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(164, 131);
            this.helpButton.TabIndex = 17;
            this.helpButton.Text = "Segítség";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // megoldasLabel
            // 
            this.megoldasLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F);
            this.megoldasLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.megoldasLabel.Location = new System.Drawing.Point(890, 455);
            this.megoldasLabel.Name = "megoldasLabel";
            this.megoldasLabel.Size = new System.Drawing.Size(164, 56);
            this.megoldasLabel.TabIndex = 18;
            this.megoldasLabel.Text = "?";
            this.megoldasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ValaszLabel
            // 
            this.ValaszLabel.AutoSize = true;
            this.ValaszLabel.BackColor = System.Drawing.Color.White;
            this.ValaszLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ValaszLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ValaszLabel.Location = new System.Drawing.Point(887, 95);
            this.ValaszLabel.Name = "ValaszLabel";
            this.ValaszLabel.Size = new System.Drawing.Size(167, 65);
            this.ValaszLabel.TabIndex = 20;
            this.ValaszLabel.Text = "Válasz:";
            // 
            // valaszTextBox
            // 
            this.valaszTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valaszTextBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.valaszTextBox.Location = new System.Drawing.Point(898, 176);
            this.valaszTextBox.Multiline = true;
            this.valaszTextBox.Name = "valaszTextBox";
            this.valaszTextBox.Size = new System.Drawing.Size(139, 62);
            this.valaszTextBox.TabIndex = 21;
            this.valaszTextBox.Text = "ide";
            // 
            // valaszButton
            // 
            this.valaszButton.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.valaszButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.valaszButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.valaszButton.Font = new System.Drawing.Font("Segoe UI Light", 28.2F);
            this.valaszButton.Location = new System.Drawing.Point(890, 269);
            this.valaszButton.Name = "valaszButton";
            this.valaszButton.Size = new System.Drawing.Size(164, 131);
            this.valaszButton.TabIndex = 22;
            this.valaszButton.Text = "OK";
            this.valaszButton.UseVisualStyleBackColor = true;
            this.valaszButton.Click += new System.EventHandler(this.valaszButton_Click);
            // 
            // JatekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1130, 770);
            this.Controls.Add(this.valaszButton);
            this.Controls.Add(this.valaszTextBox);
            this.Controls.Add(this.ValaszLabel);
            this.Controls.Add(this.megoldasLabel);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.feladatPictureBox);
            this.Controls.Add(this.jatekCimLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "JatekForm";
            this.Text = "Okosodó";
            ((System.ComponentModel.ISupportInitialize)(this.feladatPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label jatekCimLabel;
        private System.Windows.Forms.PictureBox feladatPictureBox;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label megoldasLabel;
        private System.Windows.Forms.Label ValaszLabel;
        private System.Windows.Forms.TextBox valaszTextBox;
        private System.Windows.Forms.Button valaszButton;
    }
}