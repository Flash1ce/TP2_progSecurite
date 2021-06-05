/******************************************************************************
 * Classe:  FenetreProduit
 * 
 * Auteur:  Antoine Bédard
 * 
 * But:     Gestion de la fenêtre produit. gère la création et la modiffication
 * d'un produit.
 * ***************************************************************************/
using System;
using System.Windows.Forms;
using Commerce;

namespace travail2
{
    public partial class FenetreProduit : Form
    {
        /// <summary>
        /// Constructeur de FenetreProduit.
        /// </summary>
        public FenetreProduit ()
        {
            InitializeComponent ();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            MaximizeBox = false;
            ShowInTaskbar = false;
            AcceptButton = btnOK;
            CancelButton = btnAnnuler;
            btnOK.DialogResult = DialogResult.OK;
            btnAnnuler.DialogResult = DialogResult.Cancel;
            txtCode.Enabled = false;
            optProcesseurs.Checked = true;
        }

        /// <summary>
        /// Attribu de type Produit.
        /// </summary>
        private Produit m_leProduit;

        /// <summary>
        /// Accesseur, écriture seulement. assigne le code fournis 
        /// en paramètre a txtCode.
        /// </summary>
        public int LeCode
        {
            set { this.txtCode.Text = value.ToString(); }
        }

        /// <summary>
        /// Accesseur en écriture et lecture de leProduit.
        /// Return leProduit de type Produit.
        /// Assigne le code, la description, le cout et la catégorie
        /// du produit.
        /// </summary>
        public Produit LeProduit
        {
            get { return m_leProduit; }
            set
            {
                m_leProduit = value;

                this.txtCode.Text = m_leProduit.Code;
                this.txtDescription.Text = m_leProduit.Description;
                this.txtCout.Text = m_leProduit.Cout.ToString();

                if (m_leProduit.Categorie == 0)
                {
                    optProcesseurs.Checked = true;
                }
                else if (m_leProduit.Categorie == (Categorie)1)
                {
                    optMemoires.Checked = true;
                }
                else if (m_leProduit.Categorie == (Categorie)2)
                {
                    optUnitesStockage.Checked = true;
                }
                else if (m_leProduit.Categorie == (Categorie)3)
                {
                    optCartesVideo.Checked = true;
                }
                else if (m_leProduit.Categorie == (Categorie)4)
                {
                    optBlocsAlimentation.Checked = true;
                }
                else if (m_leProduit.Categorie == (Categorie)5)
                {
                    optBoitiers.Checked = true;
                }
            }
        }

        /// <summary>
        /// Est appeller quand le bouton OK est clicker. 
        /// Gère les valeur et fait leur validation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, System.EventArgs e)
        {
            int iLaCategorie = 0;

            if (optProcesseurs.Checked)
            {
                iLaCategorie = 0;
            }
            else if (optMemoires.Checked)
            {
                iLaCategorie = 1;
            }
            else if (optUnitesStockage.Checked)
            {
                iLaCategorie = 2;
            }
            else if (optCartesVideo.Checked)
            {
                iLaCategorie = 3;
            }
            else if (optBlocsAlimentation.Checked)
            {
                iLaCategorie = 4;
            }
            else if (optBoitiers.Checked)
            {
                iLaCategorie = 5;
            }

            string strCode = this.txtCode.Text;
            string strDescription = this.txtDescription.Text;
            decimal dCout = Convert.ToDecimal(this.txtCout.Text);
            Categorie laCategorie = (Categorie)iLaCategorie;

            m_leProduit = new Produit(
                strCode, strDescription, laCategorie, dCout);

            LeProduit = m_leProduit;
        }
    }
}
