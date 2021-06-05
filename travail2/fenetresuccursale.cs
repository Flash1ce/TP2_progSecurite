/******************************************************************************
 * Classe:  FenetreSuccursale
 * 
 * Auteur:  Antoine Bédard
 * 
 * But:     S'occupe de la gestion de la fenêtre succursale.
 * ***************************************************************************/
using System;
using System.Windows.Forms;
using Commerce;

namespace travail2
{
    public partial class FenetreSuccursale : Form
    {
        //  représentant la succursale à ajouter ou à modifier
        private Succursale m_laSuccursale;

        public FenetreSuccursale()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            MaximizeBox = false;
            ShowInTaskbar = false;
            AcceptButton = btnOK;
            CancelButton = btnAnnuler;
            btnOK.DialogResult = DialogResult.OK;
            btnAnnuler.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Constructeur LaSuccursale.
        /// Return m_laSuccursale.
        /// Prends en paramêtre une succursale (Adresse, Numéro de téléphone)
        /// </summary>
        public Succursale LaSuccursale
        {
            // Accesseur en lecture.
            get
            {
                return m_laSuccursale;
            }
            // Accesseur en écriture.
            set
            {
                m_laSuccursale = value;

                this.txtAdresse.Text = m_laSuccursale.Adresse;
                this.txtNumeroTelephone.Text = m_laSuccursale.Telephone;

                this.txtAdresse.Enabled = false;
            }
        }

        /// <summary>
        /// Est appeler quand le bouton OK est cliquer.
        /// Assigne le contenue de txtAdresse a la variable strAdresse et
        /// le contenue de txtNumeroTelephone a la variable strTelephone.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, System.EventArgs e)
        {
            string strAdresse = this.txtAdresse.Text;
            string strTelephone = this.txtNumeroTelephone.Text;


            Succursale uneSuccursale;
            uneSuccursale = new Succursale(strAdresse, strTelephone);

            LaSuccursale = uneSuccursale;
        }
    }
}
