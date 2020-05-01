namespace OkosodoUI
{
    partial class DiakMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiakMenuForm));
            this.diakUdvozloNevLabel = new System.Windows.Forms.Label();
            this.sziaLabel = new System.Windows.Forms.Label();
            this.diakMainLabel = new System.Windows.Forms.Label();
            this.introLabel = new System.Windows.Forms.Label();
            this.introLink = new System.Windows.Forms.LinkLabel();
            this.mitJatszolLabel = new System.Windows.Forms.Label();
            this.matekButton = new System.Windows.Forms.Button();
            this.betuButton = new System.Windows.Forms.Button();
            this.rabdomFeladatButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // diakUdvozloNevLabel
            // 
            this.diakUdvozloNevLabel.AutoSize = true;
            this.diakUdvozloNevLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.diakUdvozloNevLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.diakUdvozloNevLabel.Location = new System.Drawing.Point(87, 96);
            this.diakUdvozloNevLabel.Name = "diakUdvozloNevLabel";
            this.diakUdvozloNevLabel.Size = new System.Drawing.Size(99, 38);
            this.diakUdvozloNevLabel.TabIndex = 12;
            this.diakUdvozloNevLabel.Text = "<nev>";
            // 
            // sziaLabel
            // 
            this.sziaLabel.AutoSize = true;
            this.sziaLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sziaLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.sziaLabel.Location = new System.Drawing.Point(16, 96);
            this.sziaLabel.Name = "sziaLabel";
            this.sziaLabel.Size = new System.Drawing.Size(65, 38);
            this.sziaLabel.TabIndex = 11;
            this.sziaLabel.Text = "Szia";
            // 
            // diakMainLabel
            // 
            this.diakMainLabel.AutoSize = true;
            this.diakMainLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.diakMainLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.diakMainLabel.Location = new System.Drawing.Point(12, 20);
            this.diakMainLabel.Name = "diakMainLabel";
            this.diakMainLabel.Size = new System.Drawing.Size(213, 65);
            this.diakMainLabel.TabIndex = 10;
            this.diakMainLabel.Text = "Okosodó";
            // 
            // introLabel
            // 
            this.introLabel.AutoSize = true;
            this.introLabel.Font = new System.Drawing.Font("Segoe UI", 14.2F);
            this.introLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.introLabel.Location = new System.Drawing.Point(12, 156);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(519, 32);
            this.introLabel.TabIndex = 13;
            this.introLabel.Text = "Ha nem tudod hogy kell játszani kattints ide ->";
            // 
            // introLink
            // 
            this.introLink.AutoSize = true;
            this.introLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.introLink.Location = new System.Drawing.Point(537, 163);
            this.introLink.Name = "introLink";
            this.introLink.Size = new System.Drawing.Size(50, 25);
            this.introLink.TabIndex = 14;
            this.introLink.TabStop = true;
            this.introLink.Text = "Intro";
            // 
            // mitJatszolLabel
            // 
            this.mitJatszolLabel.AutoSize = true;
            this.mitJatszolLabel.Font = new System.Drawing.Font("Segoe UI", 14.2F);
            this.mitJatszolLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.mitJatszolLabel.Location = new System.Drawing.Point(16, 204);
            this.mitJatszolLabel.Name = "mitJatszolLabel";
            this.mitJatszolLabel.Size = new System.Drawing.Size(222, 32);
            this.mitJatszolLabel.TabIndex = 15;
            this.mitJatszolLabel.Text = "Mit gyakorolsz ma?";
            // 
            // matekButton
            // 
            this.matekButton.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.matekButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.matekButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.matekButton.Location = new System.Drawing.Point(74, 265);
            this.matekButton.Name = "matekButton";
            this.matekButton.Size = new System.Drawing.Size(164, 131);
            this.matekButton.TabIndex = 16;
            this.matekButton.Text = "Matematika";
            this.matekButton.UseVisualStyleBackColor = true;
            this.matekButton.Click += new System.EventHandler(this.matekButton_Click);
            // 
            // betuButton
            // 
            this.betuButton.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.betuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.betuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.betuButton.Location = new System.Drawing.Point(342, 265);
            this.betuButton.Name = "betuButton";
            this.betuButton.Size = new System.Drawing.Size(164, 131);
            this.betuButton.TabIndex = 18;
            this.betuButton.Text = "Betűk";
            this.betuButton.UseVisualStyleBackColor = true;
            this.betuButton.Click += new System.EventHandler(this.abcButton_Click);
            // 
            // rabdomFeladatButton
            // 
            this.rabdomFeladatButton.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.rabdomFeladatButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.rabdomFeladatButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.rabdomFeladatButton.Location = new System.Drawing.Point(602, 265);
            this.rabdomFeladatButton.Name = "rabdomFeladatButton";
            this.rabdomFeladatButton.Size = new System.Drawing.Size(164, 131);
            this.rabdomFeladatButton.TabIndex = 19;
            this.rabdomFeladatButton.Text = "Random";
            this.rabdomFeladatButton.UseVisualStyleBackColor = true;
            this.rabdomFeladatButton.Click += new System.EventHandler(this.randomFeladatButton_Click);
            // 
            // DiakMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 599);
            this.Controls.Add(this.rabdomFeladatButton);
            this.Controls.Add(this.betuButton);
            this.Controls.Add(this.matekButton);
            this.Controls.Add(this.mitJatszolLabel);
            this.Controls.Add(this.introLink);
            this.Controls.Add(this.introLabel);
            this.Controls.Add(this.diakUdvozloNevLabel);
            this.Controls.Add(this.sziaLabel);
            this.Controls.Add(this.diakMainLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "DiakMenuForm";
            this.Text = "Okosodó";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label diakUdvozloNevLabel;
        private System.Windows.Forms.Label sziaLabel;
        private System.Windows.Forms.Label diakMainLabel;
        private System.Windows.Forms.Label introLabel;
        private System.Windows.Forms.LinkLabel introLink;
        private System.Windows.Forms.Label mitJatszolLabel;
        private System.Windows.Forms.Button matekButton;
        private System.Windows.Forms.Button betuButton;
        private System.Windows.Forms.Button rabdomFeladatButton;
    }
}