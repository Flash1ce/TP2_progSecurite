namespace travail2
{
    partial class FenetreSuccursale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.lblAdresse = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lblNumeroTelephone = new System.Windows.Forms.Label();
            this.txtNumeroTelephone = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(12, 11);
            this.lblAdresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(64, 17);
            this.lblAdresse.TabIndex = 0;
            this.lblAdresse.Text = "&Adresse:";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(16, 31);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(444, 22);
            this.txtAdresse.TabIndex = 1;
            // 
            // lblNumeroTelephone
            // 
            this.lblNumeroTelephone.AutoSize = true;
            this.lblNumeroTelephone.Location = new System.Drawing.Point(12, 71);
            this.lblNumeroTelephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroTelephone.Name = "lblNumeroTelephone";
            this.lblNumeroTelephone.Size = new System.Drawing.Size(149, 17);
            this.lblNumeroTelephone.TabIndex = 2;
            this.lblNumeroTelephone.Text = "&Numéro de téléphone:";
            // 
            // txtNumeroTelephone
            // 
            this.txtNumeroTelephone.Location = new System.Drawing.Point(16, 91);
            this.txtNumeroTelephone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroTelephone.Name = "txtNumeroTelephone";
            this.txtNumeroTelephone.Size = new System.Drawing.Size(237, 22);
            this.txtNumeroTelephone.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(136, 135);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(244, 135);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 28);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "A&nnuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // FenetreSuccursale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 177);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNumeroTelephone);
            this.Controls.Add(this.lblNumeroTelephone);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.lblAdresse);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FenetreSuccursale";
            this.Text = "fenetressuccurale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label lblNumeroTelephone;
        private System.Windows.Forms.TextBox txtNumeroTelephone;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
    }
}