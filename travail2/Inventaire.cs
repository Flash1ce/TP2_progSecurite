/******************************************************************************
 * Classe:  Inventaire
 * 
 * Auteur:  Antoine Bédard
 * 
 * But:     Création d'un inventaire, ajouter et retirer un stock, récupérer
 * le nombre de stock et la possibilité de récupérer un stock a un indice.
 * ***************************************************************************/
using System;
using System.Collections.Generic;

namespace Commerce
{
    public class Inventaire
    {
        /// <summary>
        /// Attribue list de type Stock
        /// </summary>
        private List<Stock> m_lesStocks;

        /// <summary>
        /// Permet d'initialiser l'attribut m_lesStocks en l'associant à
        /// une nouvelle liste d'objets de type Stock.
        /// </summary>
        public Inventaire()
        {
            m_lesStocks = new List<Stock>();
        }

        /// <summary>
        /// Cet accesseur qui est en lecture seulement permet d'obtenir le 
        /// nombre de stocks qui se trouvent dans l'inventaire.
        /// </summary>
        public int NbStocks
        {
            // Accesseur en lecture.
            get
            {
                return m_lesStocks.Count;
            }
        }

        /// <summary>
        /// Cette méthode retourne le stock qui se trouve à l'indice reçu en 
        /// paramètre dans m_lesStocks si cet indice est valide. S'il ne 
        /// l'est pas, la méthode lance une exception de
        /// type IndexOutOfRangeException
        /// </summary>
        /// <param name="iIndice">Int indice du stock voulus.</param>
        /// <returns>le stock a lindice fournis en paramètre 
        /// de m_lesStocks.</returns>
        public Stock GetStock(int iIndice)
        {
            if (iIndice >= 0 && iIndice < m_lesStocks.Count)
            {
                return m_lesStocks[iIndice];
            }
            else
            {
                throw new IndexOutOfRangeException(
                    "L'indice est en dehors de la plage.");
            }
        }

        /// <summary>
        /// Vérifie si le stock fournis en paramètre est déja contenus, si
        /// oui elle return false, si non elle return true et ajoute le stock
        /// a m_lesStocks.
        /// </summary>
        /// <param name="leStock">type Stock, le stock a ajouter</param>
        /// <returns>Bool true si Stock est ajouter, false si stock 
        /// n'est pas ajouter.</returns>
        public bool Ajouter(Stock leStock)
        {
            if (m_lesStocks.Contains(leStock) || leStock == null)
            {
                return false;
            }
            else
            {
                // Ajoue de l'élément.
                m_lesStocks.Add(leStock);

                return true;
            }
        }

        /// <summary>
        /// Vérifie si le stock fournis en paramètre est présent, si oui
        /// elle return true et Retire le stock fournis de m_lesStocks, sinon
        /// elle return false.
        /// </summary>
        /// <param name="leStock">Type stock, le stock a supprimer.</param>
        /// <returns>bool true si stock a été supprimer, return false 
        /// sinon.</returns>
        public bool Retirer(Stock leStock)
        {
            if (m_lesStocks.Contains(leStock))
            {
                m_lesStocks.Remove(leStock);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
