/******************************************************************************
 * Classe:  Succursale
 * 
 * Auteur:  Antoine Bédard
 * 
 * But:     Gère la création et la modification des données d'une succursale.
 * ***************************************************************************/
using System;

namespace Commerce
{
    public class Succursale
    {
        /// <summary>
        /// Attribut string m_strAdresse. Adresse de la succursale.
        /// </summary>
        private string m_strAdresse;
        /// <summary>
        /// Attribut string m_strTelephone. Num. de Téléphone de la succursale.
        /// </summary>
        private string m_strTelephone;

        /// <summary>
        /// Constructeur de succursale. Vérifie si les paramètre sont
        /// valide.
        /// </summary>
        /// <param name="strAdresse">Adresse de la succursale.</param>
        /// <param name="strTelephone">Numéro de téléphone de la succursale.
        /// </param>
        public Succursale(string strAdresse, string strTelephone)
        {
            // Vérification de l'adresse
            if (strAdresse != null && strAdresse != "")
            {
                m_strAdresse = strAdresse;
            }
            else
            {
                throw new ArgumentException("L'adresse est vide.");
            }

            // Vérification du telephone
            Telephone = strTelephone;
        }

        /// <summary>
        /// Accesseur lecture Adresse, return un string de l'adresse.
        /// </summary>
        public string Adresse
        {
            // Accesseur en lecture.
            get
            {
                return m_strAdresse;
            }
        }

        /// <summary>
        /// Accesseur lecture et écriture Telephone, 
        /// return un string du téléphone. Vérifie si le téléphone est valide.
        /// </summary>
        public string Telephone
        {
            // Accesseur en lecture.
            get
            {
                return m_strTelephone;
            }
            // Accesseur en écriture.
            set
            {
                // La longeur du numéro doi être de 10.
                bool bLongeurTelValide = false;

                // Taille du num. de téléphone.
                int iTaille = value.Length;

                if (iTaille == 10)
                {
                    bLongeurTelValide = true;
                }
                else
                {
                    throw new ArgumentException(
                        "La longueur du numéro de téléphone est invalide.");
                }

                // code régional valide ou pas.
                bool bCodeRegionalValide = false;

                // Le code régional en string.
                string codeRegional = value.Substring(0, 3);

                // Vérification du code régional. doit être = a 418 ou 514.
                if (codeRegional != "418" && codeRegional != "514")
                {
                    throw new ArgumentException(
                        "Le code régional est invalide.");
                }
                else
                {
                    bCodeRegionalValide = true;
                }

                // vérifier si il y a seulement des chiffres.
                string strNombre = value.Substring(3, 7);
                bool bTelContenirChiffre = true;

                int i;
                for (i = 0; i < 7; i++)
                {
                    char chiffre = strNombre[i];
                    if (chiffre > '9' || chiffre < '0')
                    {
                        bTelContenirChiffre = false;
                    }
                }
                if (bTelContenirChiffre == false)
                {
                    throw new ArgumentException("Le numéro de téléphone" +
                        " contient au moins un caractère qui n'est pas un " +
                        "chiffre.");
                }

                if (bLongeurTelValide == true &&
                    bCodeRegionalValide == true &&
                    bTelContenirChiffre == true)
                {
                    m_strTelephone = value;
                }
            }
        }

        /// <summary>
        /// ToString, formate le téléphone et l'adresse (xxxx (xxx-xxx-xxxx)).
        /// </summary>
        /// <returns>Return string formater.</returns>
        public override string ToString()
        {
            return string.Format("{0} ({1}-{2}-{3})",
                m_strAdresse,
                m_strTelephone.Substring(0, 3),
                m_strTelephone.Substring(3, 3),
                m_strTelephone.Substring(6, 4));
        }

        /// <summary>
        /// Vérifi si les deux succursales passé en paramètre sont égale
        /// et return un bool.
        /// </summary>
        /// <param name="laSuccursaleAGauche">Type Succursale, la première
        /// succursale a comparé.</param>
        /// <param name="laSuccursaleADroite">Type Succursale, la deuxième
        /// succursale a comparé.</param>
        /// <returns>Return true si elle sont == ou false si elle sont
        /// !=.</returns>
        public static bool operator ==(
            Succursale laSuccursaleAGauche, Succursale laSuccursaleADroite)
        {
            if (Object.ReferenceEquals(
                laSuccursaleAGauche, laSuccursaleADroite))
            {
                return true;
            }
            if ((Object)laSuccursaleAGauche == null
            || (Object)laSuccursaleADroite == null)
            {
                return false;
            }
            return (
                laSuccursaleAGauche.Adresse == laSuccursaleADroite.Adresse);
        }

        /// <summary>
        /// Vérifi si les deux succursales passé en paramètre sont différente
        /// et return un bool.
        /// </summary>
        /// <param name="laSuccursaleAGauche">Type Succursale, la première
        /// succursale a comparé.</param>
        /// <param name="laSuccursaleADroite">Type Succursale, la deuxième
        /// succursale a comparé.</param>
        /// <returns>Return true si elle sont != ou false si elle sont
        /// ==.</returns>
        public static bool operator !=(
            Succursale laSuccursaleAGauche, Succursale laSuccursaleADroite)
        {
            return !(laSuccursaleAGauche == laSuccursaleADroite);
        }

        /// <summary>
        /// Cette méthode retourne le résultat de l'opérateur == si 
        /// l'objet reçu en paramètre est effectivement un objet de type 
        /// Succursale. Sinon, elle retourne faux.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>si obj en paramètre est une succursale return true sinon
        /// retrun false.</returns>
        public override bool Equals(object obj)
        {
            if (obj is Succursale)
            {
                return (this == (Succursale)obj);
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
