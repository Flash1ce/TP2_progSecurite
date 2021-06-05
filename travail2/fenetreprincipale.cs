/******************************************************************************
 * Classe:  FenetrePrincipale
 * 
 * Auteur:  Antoine Bédard
 * 
 * But:     S'occupe de la gestion de la fenêtre principale. Gère l'application
 * au complet.
 * ***************************************************************************/
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Commerce;
using Utilitaires;

namespace travail2
{
    public partial class FenetrePrincipale : Form
    {
        // Texte qui doit apparaitre dans la barre-titre de la fenêtre
        // principale et dans la barre-titre de chacune des boites de
        // message.
        public const string TITRE_APPLICATION = "Travail 2";

        // Nombre qui représente le code de produit dans la numérotation des
        // produits (PREMIER_CODE_PRODUIT, PREMIER_CODE_PRODUIT + 1,
        // PREMIER_CODE_PRODUIT + 2, PREMIER_CODE_PRODUIT + 3, etc.).
        private const int PREMIER_CODE_PRODUIT = 1001;

        // Nombre qui représente la quantité maximale qu'une succursale peut
        // avoir en inventaire.
        private const int MAX_QUANTITE_PRODUITS = 10;

        // Nombre qui sert à déterminer le pourcentage de profit (par rapport
        // au coût d'achat) que la compagnie fera lors de la vente d'un
        // produit.
        private const decimal MARGE_BENEFICIAIRE = 0.2m;

        /// <summary>
        /// Attribut type Inventaire, m_leInventaire. L'inventaire du commerce.
        /// </summary>
        private Inventaire m_leInventaire;
        /// <summary>
        /// Attribut type List en int, m_iLesCodes. La liste de touts 
        /// les produits.
        /// </summary>
        private List<int> m_iLesCodes;
        /// <summary>
        /// Attribut type decimal, m_mTotalVentes. Le montant total des ventes.
        /// </summary>
        private decimal m_mTotalVentes;
        /// <summary>
        /// Attribut type decimal, m_mTotalAchats. Le montant total des achats.
        /// </summary>
        private decimal m_mTotalAchats;

        /// <summary>
        /// Constructeur de la fenêtre principale.
        /// </summary>
        public FenetrePrincipale()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Text = TITRE_APPLICATION;
            lstSuccursales.Sorted = true;
            lstProduits.Sorted = true;

            // Initialiser les attributs qui doivent l'être ici.
            m_leInventaire = new Inventaire();
            m_iLesCodes = new List<int>();
        }

        /// <summary>
        /// Est appeller quand bouton Ajouter Succursale est clicker. appelle
        /// la fenêtre succursale pour crée une nouvelle succursale.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterSuccursale_Click(object sender, System.EventArgs e)
        {
            FenetreSuccursale frmAjouterSuccursale;
            frmAjouterSuccursale = new FenetreSuccursale();

            if (frmAjouterSuccursale.ShowDialog() == DialogResult.OK)
            {
                Succursale uneSuccursale = frmAjouterSuccursale.LaSuccursale;

                if (!this.lstSuccursales.Items.Contains(uneSuccursale))
                {
                    this.lstSuccursales.Items.Add(uneSuccursale);

                    int iNbProduit = this.lstProduits.Items.Count;

                    int i;
                    for (i = 0; i < iNbProduit; i++)
                    {
                        Produit unProduit = (Produit)lstProduits.Items[i];

                        Stock unStock = new Stock(uneSuccursale, unProduit);

                        m_leInventaire.Ajouter(unStock);
                    }

                    this.lstSuccursales.SelectedItem = uneSuccursale;
                }
                else
                {
                    MessageBox.Show(
                        "Une succursale existe déjà à cette adresse.",
                        FenetrePrincipale.TITRE_APPLICATION,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Est appeller quand bouton Modifier Succursale est clicker. appelle
        /// la fenêtre succursale pour modifier une succursale et lui passe les
        /// paramètres.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierSuccursale_Click(object sender, System.EventArgs e)
        {
            if ((Succursale)lstSuccursales.SelectedItem == null)
            {
                MessageBox.Show("Vous devez sélectionner une succursale pour pouvoir la modifier",
                    FenetrePrincipale.TITRE_APPLICATION,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FenetreSuccursale frmModifierSuccursale;
                frmModifierSuccursale = new FenetreSuccursale();

                Succursale uneSuccursale = frmModifierSuccursale.LaSuccursale;

                uneSuccursale = (Succursale)this.lstSuccursales.SelectedItem;

                frmModifierSuccursale.LaSuccursale = uneSuccursale;

                if (frmModifierSuccursale.ShowDialog() == DialogResult.OK)
                {
                    int index = this.lstSuccursales.Items.IndexOf(uneSuccursale);

                    int iNbSuccursales = this.lstSuccursales.Items.Count;
                    Succursale[] vectSuccursaleTempo = new Succursale[iNbSuccursales];
                    int i;
                    for (i = 0; i < iNbSuccursales; i++)
                    {
                        vectSuccursaleTempo[i] = (Succursale)lstSuccursales.Items[i];
                    }
                    vectSuccursaleTempo[index] = frmModifierSuccursale.LaSuccursale;
                    this.lstSuccursales.Items.Clear();
                    int j;
                    for (j = 0; j < vectSuccursaleTempo.Length; j++)
                    {
                        this.lstSuccursales.Items.Add(vectSuccursaleTempo[j]);
                    }
                }
            }
        }

        /// <summary>
        /// Est appeller quand bouton Supprimer Succursale est clicker. Vérifie
        /// si une succursale est sélectioner, si oui elle vends tout c'est 
        /// stocks et par la suite elle supprime la succursale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerSuccursale_Click(
            object sender, System.EventArgs e)
        {
            if ((Succursale)lstSuccursales.SelectedItem != null)
            {
                Succursale uneSuccursale = 
                    (Succursale)this.lstSuccursales.SelectedItem;

                int iNbStock = m_leInventaire.NbStocks;
                Stock unStock;

                int k = 0;
                while (k < iNbStock)
                {
                    unStock = m_leInventaire.GetStock(k);
                    if (unStock.Succursale == uneSuccursale)
                    {
                        Produit unProduit = unStock.Produit;
                        uint uiQuantite = unStock.Quantite;
                        decimal deCoutProduit = unProduit.Cout;
                        decimal dePrixAvecBenefic = 
                            deCoutProduit + 
                            (deCoutProduit * MARGE_BENEFICIAIRE);

                        m_mTotalVentes += (dePrixAvecBenefic * uiQuantite);

                        unStock.Quantite = 0;
                        m_leInventaire.Retirer(unStock);
                    }
                    k++;
                }

                int index = this.lstSuccursales.Items.IndexOf(uneSuccursale);

                int iNbSuccursales = this.lstSuccursales.Items.Count;
                Succursale[] vectSuccursaleTempo = 
                    new Succursale[iNbSuccursales - 1];
                int i;
                int l = 0;
                for (i = 0; i < iNbSuccursales; i++)
                {
                    if (i != index)
                    {
                        vectSuccursaleTempo[l] = 
                            (Succursale)lstSuccursales.Items[i];
                        l++;
                    }
                }
                this.lstSuccursales.Items.Clear();
                if (vectSuccursaleTempo.Length != 0)
                {
                    int j;
                    for (j = 0; j < vectSuccursaleTempo.Length; j++)
                    {
                        this.lstSuccursales.Items.Add(vectSuccursaleTempo[j]);
                    }
                }
            }
            else
            {
                MessageBox.Show(
                    "Vous devez sélectionner une succursale" +
                    " pour pouvoir la supprimer.",
                    FenetrePrincipale.TITRE_APPLICATION,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Est appeller quand bouton Ajouter Produit est clicker. appelle
        /// la fenêtre produit pour crée un nouveaux produit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterProduit_Click(object sender, System.EventArgs e)
        {
            FenetreProduit frmAjouterProduit;
            frmAjouterProduit = new FenetreProduit();

            // trouver le code.
            int iCode = PREMIER_CODE_PRODUIT;

            while (m_iLesCodes.Contains(iCode))
            {
                iCode++;
            }
            if (!m_iLesCodes.Contains(iCode))
            {
                m_iLesCodes.Add(iCode);
            }

            frmAjouterProduit.LeCode = iCode;


            if (frmAjouterProduit.ShowDialog() == DialogResult.OK)
            {
                Produit unProduit = frmAjouterProduit.LeProduit;

                this.lstProduits.Items.Add(unProduit);

                int iNbSuccursales = this.lstSuccursales.Items.Count;

                int i;
                for (i = 0; i < iNbSuccursales; i++)
                {
                    Succursale succursale = 
                        (Succursale)lstSuccursales.Items[i];

                    Stock unStock = new Stock(succursale, unProduit);

                    m_leInventaire.Ajouter(unStock);
                }

                this.lstProduits.Items.IndexOf(unProduit);
            }

        }

        /// <summary>
        /// Est appeller quand bouton Modifier Produit est clicker. appelle
        /// la fenêtre produit pour modifier un produit. et vérifie si il
        /// y a un produit de sélectionner.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierProduit_Click(object sender, System.EventArgs e)
        {
            if ((Produit)lstProduits.SelectedItem == null)
            {
                MessageBox.Show("Vous devez sélectionner un produit pour pouvoir le modifier.",
                    FenetrePrincipale.TITRE_APPLICATION,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FenetreProduit frmModifierProduit;
                frmModifierProduit = new FenetreProduit();

                Produit unProduit = frmModifierProduit.LeProduit;

                unProduit = (Produit)this.lstProduits.SelectedItem;

                frmModifierProduit.LeProduit = unProduit;

                if (frmModifierProduit.ShowDialog() == DialogResult.OK)
                {
                    int index = this.lstProduits.Items.IndexOf(unProduit);

                    int iNbProduit = this.lstProduits.Items.Count;
                    Produit[] vectProduitTempo = new Produit[iNbProduit];
                    int i;
                    for (i = 0; i < iNbProduit; i++)
                    {
                        vectProduitTempo[i] = (Produit)lstProduits.Items[i];
                    }
                    vectProduitTempo[index] = frmModifierProduit.LeProduit;
                    this.lstProduits.Items.Clear();
                    int j;
                    for (j = 0; j < vectProduitTempo.Length; j++)
                    {
                        this.lstProduits.Items.Add(vectProduitTempo[j]);
                    }
                }
            }

        }

        /// <summary>
        /// Est appeller quand bouton Supprimer Produit est clicker. Vérifie
        /// si il y a un produit de sélectionner, vents tous les produits,
        /// suprime le code du produit de la liste et supprime le produit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerProduit_Click(
            object sender, System.EventArgs e)
        {
            if ((Produit)lstProduits.SelectedItem != null)
            {
                Produit unProduit = (Produit)this.lstProduits.SelectedItem;

                int iNbStock = m_leInventaire.NbStocks;
                Stock unStock;

                int i = 0;
                while (i < iNbStock)
                {
                    unStock = m_leInventaire.GetStock(i);
                    if (unStock.Produit == unProduit)
                    {
                        uint uiQUantiteProduit = unStock.Quantite;
                        decimal deCoutProduit = unProduit.Cout;
                        decimal dePrixAvecBenefic =
                            deCoutProduit + 
                            (deCoutProduit * MARGE_BENEFICIAIRE);

                        m_mTotalVentes += 
                            (dePrixAvecBenefic * uiQUantiteProduit);

                        unStock.Quantite = 0;
                        m_leInventaire.Retirer(unStock);
                    }
                    i++;
                }

                int iCode = Convert.ToInt32(unProduit.Code);
                m_iLesCodes.Remove(iCode);

                int index = this.lstProduits.Items.IndexOf(unProduit);

                int iNbProduits = this.lstProduits.Items.Count;
                Produit[] vectProduitTempo = new Produit[iNbProduits - 1];
                int j;
                int l = 0;
                for (j = 0; j < iNbProduits; j++)
                {
                    if (j != index)
                    {
                        vectProduitTempo[l] = (Produit)lstProduits.Items[j];
                        l++;
                    }
                }
                this.lstProduits.Items.Clear();
                int k;
                for (k = 0; k < vectProduitTempo.Length; k++)
                {
                    this.lstProduits.Items.Add(vectProduitTempo[k]);
                }
            }
            else
            {
                MessageBox.Show(
                    "Vous devez sélectionner un produit pour pouvoir " +
                    "le supprimer.",
                    FenetrePrincipale.TITRE_APPLICATION,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Est appeller quand Commander Ajouter Produit est clicker. Commande
        /// le nombre de produit manquant pour chaque stock. Un maximum de 10,
        /// et ajoute le prix de la commande dans m_mTotalAchats.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCommanderProduits_Click(
            object sender, System.EventArgs e)
        {
            if (m_leInventaire.NbStocks != 0)
            {
                int iNbStuck = m_leInventaire.NbStocks;
                int i;
                for (i = 0; i < iNbStuck; i++)
                {
                    Stock unStock = m_leInventaire.GetStock(i);
                    uint uiQuantite = unStock.Quantite;
                    if (uiQuantite < 10)
                    {
                        uint uiNbProduiManquants = 
                            MAX_QUANTITE_PRODUITS - uiQuantite;
                        unStock.Quantite += uiNbProduiManquants;

                        Produit unProduit = unStock.Produit;
                        m_mTotalAchats += 
                            (unProduit.Cout * uiNbProduiManquants);
                    }
                }
            }
            else
            {
                MessageBox.Show(
                    "Il est impossible de commander des produits sans stocks.",
                    FenetrePrincipale.TITRE_APPLICATION,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Est appeller quand Generer Ventes est clicker. Vend un nombre de
        /// produits alléatoire entre 0 et le nombre de produits en stock. 
        /// Calcule le prix de vente et ajoute la valeur a m_mTotalVentes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenererVentes_Click(object sender, System.EventArgs e)
        {
            if (m_leInventaire.NbStocks != 0)
            {
                int i;
                for (i = 0; i < m_leInventaire.NbStocks; i++)
                {
                    Stock unStock = m_leInventaire.GetStock(i);

                    uint uiQuantite = unStock.Quantite;

                    int iNbProduitsVendues = 
                        Aleatoire.GenererNombre((int)uiQuantite);

                    unStock.Quantite -= (uint)iNbProduitsVendues;

                    Produit unProduit = unStock.Produit;
                    decimal deCout = unProduit.Cout;
                    decimal dePrixBenific = 
                        deCout + (deCout * MARGE_BENEFICIAIRE);
                    m_mTotalVentes += (iNbProduitsVendues * dePrixBenific);
                }
            }
            else
            {
                MessageBox.Show(
                    "Il est impossible de  générer des ventes sans stocks.",
                    FenetrePrincipale.TITRE_APPLICATION,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Affiche le bilan du commerce.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBilan_Click(object sender, System.EventArgs e)
        {
            decimal iRecette = m_mTotalVentes - m_mTotalAchats;

            string strBilan = string.Format(
                "Recettes: {0:C}\nAchats: {1:C}", iRecette, m_mTotalAchats);

            MessageBox.Show(strBilan, "Bilan",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Affiche les information de a propos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAPropos_Click(object sender, System.EventArgs e)
        {
            string strMessage = 
                TITRE_APPLICATION + " réaliser par Antoine Bédard (1939379)";

            MessageBox.Show(strMessage, "À propos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}