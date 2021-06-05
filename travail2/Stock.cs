/******************************************************************************
 * Classe:  Stock
 * 
 * Auteur:  Antoine Bédard
 * 
 * But:     Gère la création et la modification des données d'un stock.
 * ***************************************************************************/
using System;

namespace Commerce
{
    public class Stock
    {
        /// <summary>
        /// Attribut type Succursale m_laSuccurale. La succursale.
        /// </summary>
        private Succursale m_laSuccursale;
        /// <summary>
        /// Attribut type Produit m_leProduit. Le produit.
        /// </summary>
        private Produit m_leProduit;
        /// <summary>
        /// Attribut type uint m_uiQuantite. Le nombre de produits.
        /// </summary>
        private uint m_uiQuantite;

        /// <summary>
        /// Constructeur d'un stock qui prend en paramètre une 
        /// succursale et un produit.
        /// </summary>
        /// <param name="laSuccursale">type Succursale, une succursale</param>
        /// <param name="leProduit">type Produit, un produit</param>
        public Stock(Succursale laSuccursale, Produit leProduit)
        {
            bool laSuccursaleEstValide = false;
            bool leProduitEstValide = false;

            if (laSuccursale != null)
            {
                laSuccursaleEstValide = true;
            }
            else
            {
                throw new ArgumentNullException(
                    "La succursale est nulle.", (Exception)null);
            }

            if (leProduit != null)
            {
                leProduitEstValide = true;
            }
            else
            {
                throw new ArgumentNullException(
                    "Le produit est nul.", (Exception)null);
            }

            if (laSuccursaleEstValide == true && leProduitEstValide == true)
            {
                m_laSuccursale = laSuccursale;
                m_leProduit = leProduit;
            }
        }

        /// <summary>
        /// Accesseur lecture seulement, Return la succursale de
        /// type Succursale.
        /// </summary>
        public Succursale Succursale
        {
            // Accesseur en lecture.
            get
            {
                return m_laSuccursale;
            }
        }

        /// <summary>
        /// Accesseur lecture seulement, Return le produit de type Produit.
        /// </summary>
        public Produit Produit
        {
            // Accesseur en lecture.
            get
            {
                return m_leProduit;
            }
        }

        /// <summary>
        /// Accesseur écriture et lecture, return la quantite de 
        /// produit en uint. et assigne la valeur passer en paramètre
        /// a m_uiQuantite.
        /// </summary>
        public uint Quantite
        {
            // Accesseur en lecture.
            get
            {
                return m_uiQuantite;
            }
            // Accesseur en écriture.
            set
            {
                m_uiQuantite = value;
            }
        }

        /// <summary>
        /// Vérifi si les deux stock passé en paramètre sont égale
        /// et return un bool.
        /// </summary>
        /// <param name="leStockAGauche">Type Stock, le premier
        /// stock a comparé.</param>
        /// <param name="leStockADroite">Type Stock, le deuxième
        /// stock a comparé.</param>
        /// <returns>Return true si ils sont == ou false si ils sont
        /// !=.</returns>
        public static bool operator ==(
            Stock leStockAGauche, Stock leStockADroite)
        {
            if (Object.ReferenceEquals(leStockAGauche, leStockADroite))
            {
                return true;
            }
            if ((Object)leStockAGauche == null
            || (Object)leStockADroite == null)
            {
                return false;
            }
            return (leStockAGauche.Succursale == leStockADroite.Succursale
                && leStockAGauche.Produit == leStockADroite.Produit);
        }

        /// <summary>
        /// Vérifi si les deux stock passé en paramètre sont différent.
        /// et return un bool.
        /// </summary>
        /// <param name="leStockAGauche">Type Stock, le premier
        /// stock a comparé.</param>
        /// <param name="leStockADroite">Type Stock, le deuxième
        /// stock a comparé.</param>
        /// <returns>Return true si ils sont != ou false si ils sont
        /// ==.</returns>
        public static bool operator !=(
            Stock leStockAGauche, Stock leStockADroite)
        {
            return !(leStockAGauche == leStockADroite);
        }

        /// <summary>
        /// Cette méthode retourne le résultat de l'opérateur == si 
        /// l'objet reçu en paramètre est effectivement un objet de type 
        /// Stock. Sinon, elle retourne faux.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Si obj en paramètre est un Stock return true sinon
        /// retrun false.</returns>
        public override bool Equals(object obj)
        {
            if (obj is Stock)
            {
                return (this == (Stock)obj);
            }
            return false;
        }

        /// <summary>
        /// retourne le résultat de la méthode GetHashCode de la 
        /// classe de base.
        /// </summary>
        /// <returns>Return méthode GetHashCode de base</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
