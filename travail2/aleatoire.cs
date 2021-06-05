using System;

namespace Utilitaires
{
    /// <summary>
    /// Fournit une méthode statique pour générer des nombres aléatoires.
    /// </summary>
    public static class Aleatoire
    {
        // Attribut statique représentant le générateur de nombres alétoires.
        // Initialisé une seule fois au démarrage de l'application.
        private static Random g_rndGenerateur = new Random ();

        /// <summary>
        /// Permet d'obtenir un nombre entier aléatoire compris entre zéro et 
        /// la borne supérieure reçue.
        /// </summary>
        /// <param name="iBorneSuperieure">Borne supérieure désirée.</param>
        /// <returns>le nombre entier alétoire généré.</returns>
        public static int GenererNombre (int iBorneSuperieure)
        {
            return g_rndGenerateur.Next (iBorneSuperieure + 1);
        }
    }
}