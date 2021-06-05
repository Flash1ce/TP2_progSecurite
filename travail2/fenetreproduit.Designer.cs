namespace travail2
{
    partial class FenetreProduit
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
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblCout = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtCout = new System.Windows.Forms.TextBox();
            this.grpCategorie = new System.Windows.Forms.GroupBox();
            this.optBoitiers = new System.Windows.Forms.RadioButton();
            this.optBlocsAlimentation = new System.Windows.Forms.RadioButton();
            this.optCartesVideo = new System.Windows.Forms.RadioButton();
            this.optUnitesStockage = new System.Windows.Forms.RadioButton();
            this.optMemoires = new System.Windows.Forms.RadioButton();
            this.optProcesseurs = new System.Windows.Forms.RadioButton();
            this.grpCategorie.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(16, 11);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(45, 17);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "&Code:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(20, 31);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(132, 22);
            this.txtCode.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(16, 74);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 17);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "&Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(20, 94);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(385, 22);
            this.txtDescription.TabIndex = 3;
            // 
            // lblCout
            // 
            this.lblCout.AutoSize = true;
            this.lblCout.Location = new System.Drawing.Point(16, 139);
            this.lblCout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCout.Name = "lblCout";
            this.lblCout.Size = new System.Drawing.Size(41, 17);
            this.lblCout.TabIndex = 4;
            this.lblCout.Text = "Coû&t:";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(363, 254);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 28);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "A&nnuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(255, 254);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtCout
            // 
            this.txtCout.Location = new System.Drawing.Point(20, 159);
            this.txtCout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCout.Name = "txtCout";
            this.txtCout.Size = new System.Drawing.Size(132, 22);
            this.txtCout.TabIndex = 5;
            // 
            // grpCategorie
            // 
            this.grpCategorie.Controls.Add(this.optBoitiers);
            this.grpCategorie.Controls.Add(this.optBlocsAlimentation);
            this.grpCategorie.Controls.Add(this.optCartesVideo);
            this.grpCategorie.Controls.Add(this.optUnitesStockage);
            this.grpCategorie.Controls.Add(this.optMemoires);
            this.grpCategorie.Controls.Add(this.optProcesseurs);
            this.grpCategorie.Location = new System.Drawing.Point(432, 31);
            this.grpCategorie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCategorie.Name = "grpCategorie";
            this.grpCategorie.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCategorie.Size = new System.Drawing.Size(267, 203);
            this.grpCategorie.TabIndex = 6;
            this.grpCategorie.TabStop = false;
            this.grpCategorie.Text = "C&atégorie:";
            // 
            // optBoitiers
            // 
            this.optBoitiers.AutoSize = true;
            this.optBoitiers.Location = new System.Drawing.Point(8, 165);
            this.optBoitiers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optBoitiers.Name = "optBoitiers";
            this.optBoitiers.Size = new System.Drawing.Size(76, 21);
            this.optBoitiers.TabIndex = 5;
            this.optBoitiers.TabStop = true;
            this.optBoitiers.Text = "Bo&itiers";
            this.optBoitiers.UseVisualStyleBackColor = true;
            // 
            // optBlocsAlimentation
            // 
            this.optBlocsAlimentation.AutoSize = true;
            this.optBlocsAlimentation.Location = new System.Drawing.Point(8, 137);
            this.optBlocsAlimentation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optBlocsAlimentation.Name = "optBlocsAlimentation";
            this.optBlocsAlimentation.Size = new System.Drawing.Size(154, 21);
            this.optBlocsAlimentation.TabIndex = 4;
            this.optBlocsAlimentation.TabStop = true;
            this.optBlocsAlimentation.Text = "&Blocs d\'alimentation";
            this.optBlocsAlimentation.UseVisualStyleBackColor = true;
            // 
            // optCartesVideo
            // 
            this.optCartesVideo.AutoSize = true;
            this.optCartesVideo.Location = new System.Drawing.Point(8, 108);
            this.optCartesVideo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optCartesVideo.Name = "optCartesVideo";
            this.optCartesVideo.Size = new System.Drawing.Size(110, 21);
            this.optCartesVideo.TabIndex = 3;
            this.optCartesVideo.TabStop = true;
            this.optCartesVideo.Text = "Cartes &Vidéo";
            this.optCartesVideo.UseVisualStyleBackColor = true;
            // 
            // optUnitesStockage
            // 
            this.optUnitesStockage.AutoSize = true;
            this.optUnitesStockage.Location = new System.Drawing.Point(8, 80);
            this.optUnitesStockage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optUnitesStockage.Name = "optUnitesStockage";
            this.optUnitesStockage.Size = new System.Drawing.Size(150, 21);
            this.optUnitesStockage.TabIndex = 2;
            this.optUnitesStockage.TabStop = true;
            this.optUnitesStockage.Text = "&Unités de stockage";
            this.optUnitesStockage.UseVisualStyleBackColor = true;
            // 
            // optMemoires
            // 
            this.optMemoires.AutoSize = true;
            this.optMemoires.Location = new System.Drawing.Point(8, 52);
            this.optMemoires.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optMemoires.Name = "optMemoires";
            this.optMemoires.Size = new System.Drawing.Size(90, 21);
            this.optMemoires.TabIndex = 1;
            this.optMemoires.TabStop = true;
            this.optMemoires.Text = "&Mémoires";
            this.optMemoires.UseVisualStyleBackColor = true;
            // 
            // optProcesseurs
            // 
            this.optProcesseurs.AutoSize = true;
            this.optProcesseurs.Location = new System.Drawing.Point(8, 23);
            this.optProcesseurs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optProcesseurs.Name = "optProcesseurs";
            this.optProcesseurs.Size = new System.Drawing.Size(108, 21);
            this.optProcesseurs.TabIndex = 0;
            this.optProcesseurs.TabStop = true;
            this.optProcesseurs.Text = "&Processeurs";
            this.optProcesseurs.UseVisualStyleBackColor = true;
            // 
            // FenetreProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 298);
            this.Controls.Add(this.grpCategorie);
            this.Controls.Add(this.txtCout);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblCout);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FenetreProduit";
            this.Text = "fenetreproduit";
            this.grpCategorie.ResumeLayout(false);
            this.grpCategorie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblCout;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtCout;
        private System.Windows.Forms.GroupBox grpCategorie;
        private System.Windows.Forms.RadioButton optMemoires;
        private System.Windows.Forms.RadioButton optProcesseurs;
        private System.Windows.Forms.RadioButton optCartesVideo;
        private System.Windows.Forms.RadioButton optUnitesStockage;
        private System.Windows.Forms.RadioButton optBoitiers;
        private System.Windows.Forms.RadioButton optBlocsAlimentation;
    }
}