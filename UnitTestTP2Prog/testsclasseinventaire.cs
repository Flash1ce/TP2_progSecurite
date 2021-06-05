using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Commerce;
using Utilitaires;

namespace travail2_tests
{
    [TestClass]
    public class TestsClasseInventaire
    {
        [TestMethod]
        public void TesterConstructeur ()
        {
            Inventaire unInventaire;

            unInventaire = new Inventaire ();
            Assert.AreEqual (0, unInventaire.NbStocks);
        }

        [TestMethod]
        public void TesterMethodeGetStock ()
        {
            Stock [] lesStocks = CreerStocks ();
            Inventaire unInventaire = new Inventaire ();
            int i;
            Stock unStock = null;

            for (i = 0; i < lesStocks.Length; i++)
            {
                unInventaire.Ajouter (lesStocks [i]);
            }

            // Cas 1: Indices valides.
            for (i = 0; i < lesStocks.Length; i++)
            {
                Assert.AreEqual (lesStocks [i], unInventaire.GetStock (i));
            }

            // Cas 2a: Indice invalide (négatif).
            try
            {
                unStock = unInventaire.GetStock (-1);
                Assert.Fail ();
            }
            catch (IndexOutOfRangeException ex)
            {
                Assert.IsNull (unStock);
                Assert.AreEqual ("L'indice est en dehors de la plage.",
                    ex.Message);
            }

            // Cas 2b: Indice invalide (égal au nombre d'éléments).
            try
            {
                unStock = unInventaire.GetStock (unInventaire.NbStocks);
                Assert.Fail ();
            }
            catch (IndexOutOfRangeException ex)
            {
                Assert.IsNull (unStock);
                Assert.AreEqual ("L'indice est en dehors de la plage.",
                    ex.Message);
            }
        }

        [TestMethod]
        public void TesterMethodeAjouter ()
        {
            Stock [] lesStocks = CreerStocks ();
            Inventaire unInventaire = new Inventaire ();
            int i;

            // Cas 1: Ajouts avec réussite.
            // Boucle des succursales.
            for (i = 0; i < lesStocks.Length; i++)
            {
                Assert.IsTrue (unInventaire.Ajouter (lesStocks [i]));
            }
            Assert.AreEqual (lesStocks.Length, unInventaire.NbStocks);
            for (i = 0; i < lesStocks.Length; i++)
            {
                Assert.AreEqual (lesStocks [i], unInventaire.GetStock (i));
            }

            // Cas 2: Ajouts avec échec.
            for (i = 0; i < lesStocks.Length; i++)
            {
                Assert.IsFalse (unInventaire.Ajouter (lesStocks [i]));
            }
            Assert.AreEqual (lesStocks.Length, unInventaire.NbStocks);

            // Cas 3: Ajout d'un stock nul.
            Assert.IsFalse (unInventaire.Ajouter (null));
        }

        [TestMethod]
        public void TesterMethodeRetirer ()
        {
            Stock [] lesStocks = CreerStocks ();
            Inventaire unInventaire = new Inventaire ();
            int i;

            for (i = 0; i < lesStocks.Length; i++)
            {
                unInventaire.Ajouter (lesStocks [i]);
            }

            // Cas 1: Retraits avec réussite.
            for (i = 0; i < lesStocks.Length; i++)
            {
                Assert.IsTrue (unInventaire.Retirer (lesStocks [i]));
            }
            Assert.AreEqual (0, unInventaire.NbStocks);

            // Cas 2: Retrait avec échecs.
            for (i = 0; i < lesStocks.Length; i++)
            {
                Assert.IsFalse (unInventaire.Retirer (lesStocks [i]));
            }
            Assert.AreEqual (0, unInventaire.NbStocks);            
        }

        // Méthode utilitaire pour créer un vecteur de 100 stocks et le
        // retourner.
        private Stock [] CreerStocks ()
        {
            Stock [] lesStocks = new Stock [100];
            int i;
            int j;
            Succursale uneSuccursale;
            Produit unProduit;

            // Boucle des succursales.
            for (i = 0; i < 10; i++)
            {
                // Boucle des produits.
                for (j = 0; j < 10; j++)
                {
                    uneSuccursale = new Succursale
                        (string.Format ("{0}, rue du Test", i + 1000),
                        string.Format ("418656123{0}", i));
                    unProduit = new Produit (string.Format ("{0}", j + 1001),
                        string.Format ("Produit {0}", j + 1),
                        (Categorie) Aleatoire.GenererNombre (5),
                        (10000 + Aleatoire.GenererNombre (99999)) / 100);
                    lesStocks [i * 10 + j] = new Stock (uneSuccursale,
                        unProduit);
                }
            }
            return lesStocks;
        }
    }
}
