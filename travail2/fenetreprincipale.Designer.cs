namespace travail2
{
    partial class FenetrePrincipale
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent ()
        {
            this.lblSuccursales = new System.Windows.Forms.Label();
            this.lstSuccursales = new System.Windows.Forms.ListBox();
            this.lblProduits = new System.Windows.Forms.Label();
            this.lstProduits = new System.Windows.Forms.ListBox();
            this.btnAjouterSuccursale = new System.Windows.Forms.Button();
            this.btnModifierSuccursale = new System.Windows.Forms.Button();
            this.btnSupprimerSuccursale = new System.Windows.Forms.Button();
            this.btnAjouterProduit = new System.Windows.Forms.Button();
            this.btnModifierProduit = new System.Windows.Forms.Button();
            this.btnSupprimerProduit = new System.Windows.Forms.Button();
            this.btnGenererVentes = new System.Windows.Forms.Button();
            this.btnCommanderProduits = new System.Windows.Forms.Button();
            this.btnAPropos = new System.Windows.Forms.Button();
            this.btnBilan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSuccursales
            // 
            this.lblSuccursales.AutoSize = true;
            this.lblSuccursales.Location = new System.Drawing.Point(16, 11);
            this.lblSuccursales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuccursales.Name = "lblSuccursales";
            this.lblSuccursales.Size = new System.Drawing.Size(89, 17);
            this.lblSuccursales.TabIndex = 0;
            this.lblSuccursales.Text = "&Succursales:";
            // 
            // lstSuccursales
            // 
            this.lstSuccursales.FormattingEnabled = true;
            this.lstSuccursales.ItemHeight = 16;
            this.lstSuccursales.Location = new System.Drawing.Point(20, 31);
            this.lstSuccursales.Margin = new System.Windows.Forms.Padding(4);
            this.lstSuccursales.Name = "lstSuccursales";
            this.lstSuccursales.Size = new System.Drawing.Size(303, 356);
            this.lstSuccursales.TabIndex = 1;
            // 
            // lblProduits
            // 
            this.lblProduits.AutoSize = true;
            this.lblProduits.Location = new System.Drawing.Point(341, 11);
            this.lblProduits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduits.Name = "lblProduits";
            this.lblProduits.Size = new System.Drawing.Size(64, 17);
            this.lblProduits.TabIndex = 2;
            this.lblProduits.Text = "&Produits:";
            // 
            // lstProduits
            // 
            this.lstProduits.FormattingEnabled = true;
            this.lstProduits.ItemHeight = 16;
            this.lstProduits.Location = new System.Drawing.Point(345, 31);
            this.lstProduits.Margin = new System.Windows.Forms.Padding(4);
            this.lstProduits.Name = "lstProduits";
            this.lstProduits.Size = new System.Drawing.Size(303, 356);
            this.lstProduits.TabIndex = 3;
            // 
            // btnAjouterSuccursale
            // 
            this.btnAjouterSuccursale.Location = new System.Drawing.Point(672, 31);
            this.btnAjouterSuccursale.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterSuccursale.Name = "btnAjouterSuccursale";
            this.btnAjouterSuccursale.Size = new System.Drawing.Size(173, 28);
            this.btnAjouterSuccursale.TabIndex = 4;
            this.btnAjouterSuccursale.Text = "Ajouter s&uccursale";
            this.btnAjouterSuccursale.UseVisualStyleBackColor = true;
            this.btnAjouterSuccursale.Click += new System.EventHandler(this.btnAjouterSuccursale_Click);
            // 
            // btnModifierSuccursale
            // 
            this.btnModifierSuccursale.Location = new System.Drawing.Point(672, 66);
            this.btnModifierSuccursale.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifierSuccursale.Name = "btnModifierSuccursale";
            this.btnModifierSuccursale.Size = new System.Drawing.Size(173, 28);
            this.btnModifierSuccursale.TabIndex = 5;
            this.btnModifierSuccursale.Text = "Modifier su&ccursale";
            this.btnModifierSuccursale.UseVisualStyleBackColor = true;
            this.btnModifierSuccursale.Click += new System.EventHandler(this.btnModifierSuccursale_Click);
            // 
            // btnSupprimerSuccursale
            // 
            this.btnSupprimerSuccursale.Location = new System.Drawing.Point(672, 102);
            this.btnSupprimerSuccursale.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimerSuccursale.Name = "btnSupprimerSuccursale";
            this.btnSupprimerSuccursale.Size = new System.Drawing.Size(173, 28);
            this.btnSupprimerSuccursale.TabIndex = 6;
            this.btnSupprimerSuccursale.Text = "Supprimer succu&rsale";
            this.btnSupprimerSuccursale.UseVisualStyleBackColor = true;
            this.btnSupprimerSuccursale.Click += new System.EventHandler(this.btnSupprimerSuccursale_Click);
            // 
            // btnAjouterProduit
            // 
            this.btnAjouterProduit.Location = new System.Drawing.Point(672, 138);
            this.btnAjouterProduit.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterProduit.Name = "btnAjouterProduit";
            this.btnAjouterProduit.Size = new System.Drawing.Size(173, 28);
            this.btnAjouterProduit.TabIndex = 7;
            this.btnAjouterProduit.Text = "Ajouter pr&oduit";
            this.btnAjouterProduit.UseVisualStyleBackColor = true;
            this.btnAjouterProduit.Click += new System.EventHandler(this.btnAjouterProduit_Click);
            // 
            // btnModifierProduit
            // 
            this.btnModifierProduit.Location = new System.Drawing.Point(672, 174);
            this.btnModifierProduit.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifierProduit.Name = "btnModifierProduit";
            this.btnModifierProduit.Size = new System.Drawing.Size(173, 28);
            this.btnModifierProduit.TabIndex = 8;
            this.btnModifierProduit.Text = "Modifier pro&duit";
            this.btnModifierProduit.UseVisualStyleBackColor = true;
            this.btnModifierProduit.Click += new System.EventHandler(this.btnModifierProduit_Click);
            // 
            // btnSupprimerProduit
            // 
            this.btnSupprimerProduit.Location = new System.Drawing.Point(672, 209);
            this.btnSupprimerProduit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimerProduit.Name = "btnSupprimerProduit";
            this.btnSupprimerProduit.Size = new System.Drawing.Size(173, 28);
            this.btnSupprimerProduit.TabIndex = 9;
            this.btnSupprimerProduit.Text = "Supprimer produ&it";
            this.btnSupprimerProduit.UseVisualStyleBackColor = true;
            this.btnSupprimerProduit.Click += new System.EventHandler(this.btnSupprimerProduit_Click);
            // 
            // btnGenererVentes
            // 
            this.btnGenererVentes.Location = new System.Drawing.Point(672, 281);
            this.btnGenererVentes.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenererVentes.Name = "btnGenererVentes";
            this.btnGenererVentes.Size = new System.Drawing.Size(173, 28);
            this.btnGenererVentes.TabIndex = 11;
            this.btnGenererVentes.Text = "&Générer ventes";
            this.btnGenererVentes.UseVisualStyleBackColor = true;
            this.btnGenererVentes.Click += new System.EventHandler(this.btnGenererVentes_Click);
            // 
            // btnCommanderProduits
            // 
            this.btnCommanderProduits.Location = new System.Drawing.Point(672, 245);
            this.btnCommanderProduits.Margin = new System.Windows.Forms.Padding(4);
            this.btnCommanderProduits.Name = "btnCommanderProduits";
            this.btnCommanderProduits.Size = new System.Drawing.Size(173, 28);
            this.btnCommanderProduits.TabIndex = 10;
            this.btnCommanderProduits.Text = "Co&mmander produits";
            this.btnCommanderProduits.UseVisualStyleBackColor = true;
            this.btnCommanderProduits.Click += new System.EventHandler(this.btnCommanderProduits_Click);
            // 
            // btnAPropos
            // 
            this.btnAPropos.Location = new System.Drawing.Point(672, 352);
            this.btnAPropos.Margin = new System.Windows.Forms.Padding(4);
            this.btnAPropos.Name = "btnAPropos";
            this.btnAPropos.Size = new System.Drawing.Size(173, 28);
            this.btnAPropos.TabIndex = 13;
            this.btnAPropos.Text = "À propos d&e";
            this.btnAPropos.UseVisualStyleBackColor = true;
            this.btnAPropos.Click += new System.EventHandler(this.btnAPropos_Click);
            // 
            // btnBilan
            // 
            this.btnBilan.Location = new System.Drawing.Point(672, 316);
            this.btnBilan.Margin = new System.Windows.Forms.Padding(4);
            this.btnBilan.Name = "btnBilan";
            this.btnBilan.Size = new System.Drawing.Size(173, 28);
            this.btnBilan.TabIndex = 12;
            this.btnBilan.Text = "&Bilan";
            this.btnBilan.UseVisualStyleBackColor = true;
            this.btnBilan.Click += new System.EventHandler(this.btnBilan_Click);
            // 
            // FenetrePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 402);
            this.Controls.Add(this.btnBilan);
            this.Controls.Add(this.btnAPropos);
            this.Controls.Add(this.btnCommanderProduits);
            this.Controls.Add(this.btnGenererVentes);
            this.Controls.Add(this.btnSupprimerProduit);
            this.Controls.Add(this.btnModifierProduit);
            this.Controls.Add(this.btnAjouterProduit);
            this.Controls.Add(this.btnSupprimerSuccursale);
            this.Controls.Add(this.btnModifierSuccursale);
            this.Controls.Add(this.btnAjouterSuccursale);
            this.Controls.Add(this.lstProduits);
            this.Controls.Add(this.lblProduits);
            this.Controls.Add(this.lstSuccursales);
            this.Controls.Add(this.lblSuccursales);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FenetrePrincipale";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSuccursales;
        private System.Windows.Forms.ListBox lstSuccursales;
        private System.Windows.Forms.Label lblProduits;
        private System.Windows.Forms.ListBox lstProduits;
        private System.Windows.Forms.Button btnAjouterSuccursale;
        private System.Windows.Forms.Button btnModifierSuccursale;
        private System.Windows.Forms.Button btnSupprimerSuccursale;
        private System.Windows.Forms.Button btnAjouterProduit;
        private System.Windows.Forms.Button btnModifierProduit;
        private System.Windows.Forms.Button btnSupprimerProduit;
        private System.Windows.Forms.Button btnGenererVentes;
        private System.Windows.Forms.Button btnCommanderProduits;
        private System.Windows.Forms.Button btnAPropos;
        private System.Windows.Forms.Button btnBilan;
    }
}

