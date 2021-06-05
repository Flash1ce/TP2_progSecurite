/******************************************************************************
 * Classe:  Produit
 * 
 * Auteur:  Antoine Bédard
 * 
 * But:     Gère la création et la modification des données d'un produit.
 * ***************************************************************************/
using System;

namespace Commerce
{
    /// <summary>
    /// enumération de type Categorie, Les catégories des produit soit
    /// Processeurs, Memoires, UnitesStockage, CartesVideo, BlocsAlimentation,
    /// Boitiers.
    /// </summary>
    public enum Categorie
    {
        Processeurs,
        Memoires,
        UnitesStockage,
        CartesVideo,
        BlocsAlimentation,
        Boitiers
    }

    public class Produit
    {
        /// <summary>
        /// Attribut string m_strCode. Le code du produit.
        /// </summary>
        private string m_strCode;
        /// <summary>
        /// Attribut string m_strDescription. La description du produit.
        /// </summary>
        private string m_strDescription;
        /// <summary>
        /// Attribut Categorie m_laCategorie. La catégorie du produit.
        /// </summary>
        private Categorie m_laCategorie;
        /// <summary>
        /// Attribut decimal m_mCout. Le cout du produit.
        /// </summary>
        private decimal m_mCout;

        /// <summary>
        /// Constructeur d'un produit.
        /// </summary>
        /// <param name="strCode">string du code du produit</param>
        /// <param name="strDescription">string de la description du produit.
        /// </param>
        /// <param name="laCategorie">Categorie de la catégorie du produit.
        /// </param>
        /// <param name="mCout">decimal du coup du produit.</param>
        public Produit(
            string strCode, 
            string strDescription, 
            Categorie laCategorie, 
            decimal mCout)
        {
            // Code
            if (strCode != null && strCode != "")
            {
                m_strCode = strCode;
            }
            else
            {
                throw new ArgumentException("Le code est vide.");
            }

            // Description
            Description = strDescription;

            // Categorie
            Categorie = laCategorie;

            // Cout
            Cout = mCout;
        }

        /// <summary>
        /// Accesseur lecture Code. Return un string du code.
        /// </summary>
        public string Code
        {
            // Accesseur en lecture.
            get
            {
                return m_strCode;
            }
        }

        /// <summary>
        /// Accesseur écriture et lecture de la description. prand en 
        /// paramètre et return un string de la description du produit.
        /// </summary>
        public string Description
        {
            // Accesseur en lecture.
            get
            {
                return m_strDescription;
            }
            // Accesseur en écriture.
            set
            {
                if (value != null && value != "")
                {
                    m_strDescription = value;
                }
                else
                {
                    throw new ArgumentException("La description est vide.");
                }
            }
        }

        /// <summary>
        /// Accesseur lecture et écriture. Prend en paramètre et return la 
        /// catégorie de type Categorie.
        /// </summary>
        public Categorie Categorie
        {
            // Accesseur en lecture.
            get
            {
                return m_laCategorie;
            }
            // Accesseur en écriture.
            set
            {
                m_laCategorie = value;
            }
        }

        /// <summary>
        /// Accesseur écriture et lecture. Prends en paramètre et return le 
        /// cout de type decimal.
        /// </summary>
        public decimal Cout
        {
            // Accesseur en lecture.
            get
            {
                return m_mCout;
            }
            // Accesseur en écriture.
            set
            {
                if (value > 0)
                {
                    m_mCout = value;
                }
                else
                {
                    throw new ArgumentException(
                        "Le coût n'est pas supérieur à zéro.");
                }
            }
        }

        /// <summary>
        /// ToString, formate le code et la description (xxx - xxxxxxx).
        /// </summary>
        /// <returns>Return string formater.</returns>
        public override string ToString()
        {
            return string.Format("{0} - {1}",
                m_strCode, m_strDescription);
        }

        /// <summary>
        /// Vérifi si les deux produit passé en paramètre sont égale
        /// et return un bool.
        /// </summary>
        /// <param name="leProduitAGauche">Type Produit, le premier
        /// produit a comparé.</param>
        /// <param name="leProduitADroite">Type Produit, le deuxième
        /// produit a comparé.</param>
        /// <returns>Return true si ils sont == ou false si ils sont
        /// !=.</returns>
        public static bool operator ==(
            Produit leProduitAGauche, Produit leProduitADroite)
        {
            if (Object.ReferenceEquals(leProduitAGauche, leProduitADroite))
            {
                return true;
            }
            if ((Object)leProduitAGauche == null
            || (Object)leProduitADroite == null)
            {
                return false;
            }
            return (leProduitAGauche.Code == leProduitADroite.Code);
        }

        /// <summary>
        /// Vérifi si les deux produit passé en paramètre sont différent
        /// et return un bool.
        /// </summary>
        /// <param name="leProduitAGauche">Type Produit, le premier
        /// produit a comparé.</param>
        /// <param name="leProduitADroite">Type Produit, le deuxième
        /// produit a comparé.</param>
        /// <returns>Return true si ils sont != ou false si ils sont
        /// ==.</returns>
        public static bool operator !=(
            Produit leProduitAGauche, Produit leProduitADroite)
        {
            return !(leProduitAGauche == leProduitADroite);
        }

        /// <summary>
        /// Cette méthode retourne le résultat de l'opérateur == si 
        /// l'objet reçu en paramètre est effectivement un objet de type 
        /// Produit. Sinon, elle retourne faux.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Si obj en paramètre est un Produit return true sinon
        /// retrun false.</returns>
        public override bool Equals(object obj)
        {
            if (obj is Produit)
            {
                return (this == (Produit)obj);
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
