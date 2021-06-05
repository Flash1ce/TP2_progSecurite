using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Commerce;

namespace travail2_tests
{
    [TestClass]
    public class TestsClasseStock
    {
        [TestMethod]
        public void TesterConstructeurAvecParametresValides ()
        {
            Succursale uneSuccursale = new Succursale ("1000, rue du Test",
                "4186561234");
            Produit unProduit = new Produit ("1001", "Core i9",
                Categorie.Processeurs, 675.25m);
            Stock unStock;

            unStock = new Stock (uneSuccursale, unProduit);
            Assert.AreEqual (uneSuccursale, unStock.Succursale);
            Assert.AreEqual (unProduit, unStock.Produit);
            Assert.AreEqual ((uint) 0, unStock.Quantite);
        }

        [TestMethod]
        public void TesterConstructeurAvecPremierParametreInvalide ()
        {
            Stock unStock = null;

            try
            {
                unStock = new Stock (null, new Produit ("1001", "Core i9",
                    Categorie.Processeurs, 675.25m));
                Assert.Fail ();
            }
            catch (ArgumentNullException ex)
            {
                Assert.IsNull (unStock);
                Assert.AreEqual ("La succursale est nulle.", ex.Message);
            }

            try
            {
                unStock = new Stock (null, null);
                Assert.Fail ();
            }
            catch (ArgumentNullException ex)
            {
                Assert.IsNull (unStock);
                Assert.AreEqual ("La succursale est nulle.", ex.Message);
            }
        }

        [TestMethod]
        public void TesterConstructeurAvecDeuxiemeParametreInvalide ()
        {
            Stock unStock = null;

            try
            {
                unStock = new Stock (new Succursale ("1000, rue du Test",
                    "4186561234"), null);
            }
            catch (ArgumentNullException ex)
            {
                Assert.IsNull (unStock);
                Assert.AreEqual ("Le produit est nul.", ex.Message);
            }
        }

        [TestMethod]
        public void TesterOperateurComparaironEgalite ()
        {
            Stock unStock;
            Stock unAutreStock;

            // Deux variables qui font référence au même stock.
            unStock = new Stock (new Succursale ("1000, rue du Test",
                "4186561234"), new Produit ("1001", "Core i9",
                Categorie.Processeurs, 675.25m));
            unAutreStock = unStock;
            Assert.IsTrue (unStock == unAutreStock);

            // Stock à gauche nul.
            unStock = null;
            Assert.IsFalse (unStock == unAutreStock);

            // Stock à droite nul.
            Assert.IsFalse (unAutreStock == unStock);

            // Deux variables qui font référence à nul.
            unAutreStock = null;
            Assert.IsTrue (unStock == unAutreStock);

            // Deux stocks contenant les mêmes informations.
            unStock = new Stock (new Succursale ("1000, rue du Test",
                "4186561234"), new Produit ("1001", "Core i9",
                Categorie.Processeurs, 675.25m));
            unAutreStock = new Stock (new Succursale ("1000, rue du Test",
                "4186561234"), new Produit ("1001", "Core i9",
                Categorie.Processeurs, 675.25m));
            Assert.IsTrue (unStock == unAutreStock);

            // Deux stocks avec des succursales différentes.
            unAutreStock = new Stock (new Succursale ("666, rue Unitaire",
                "4186561234"), new Produit ("1001", "Core i9",
                Categorie.Processeurs, 675.25m));
            Assert.IsFalse (unStock == unAutreStock);

            // Deux stocks avec des produits différents.
            unAutreStock = new Stock (new Succursale ("1001, rue du Test",
                "4186561234"), new Produit ("1002", "Core i9",
                Categorie.Processeurs, 675.25m));
            Assert.IsFalse (unStock == unAutreStock);

            // Deux stocks avec des informations différentes.
            unAutreStock = new Stock (new Succursale ("666, rue Unitaire",
                "4186561234"), new Produit ("1002", "Core i9",
                Categorie.Processeurs, 675.25m));
            Assert.IsFalse (unStock == unAutreStock);
        }

        [TestMethod]
        public void TesterOperateurComparaironDifference ()
        {
            Stock unStock;
            Stock unAutreStock;

            // Deux variables qui font référence au même stock.
            unStock = new Stock (new Succursale ("1000, rue du Test",
                "4186561234"), new Produit ("1001", "Core i9",
                Categorie.Processeurs, 675.25m));
            unAutreStock = unStock;
            Assert.IsFalse (unStock != unAutreStock);

            // Stock à gauche nul.
            unStock = null;
            Assert.IsTrue (unStock != unAutreStock);

            // Stock à droite nul.
            Assert.IsTrue (unAutreStock != unStock);

            // Deux variables qui font référence à nul.
            unAutreStock = null;
            Assert.IsFalse (unStock != unAutreStock);

            // Deux stocks contenant les mêmes informations.
            unStock = new Stock (new Succursale ("1000, rue du Test",
                "4186561234"), new Produit ("1001", "Core i9",
                Categorie.Processeurs, 675.25m));
            unAutreStock = new Stock (new Succursale ("1000, rue du Test",
                "4186561234"), new Produit ("1001", "Core i9",
                Categorie.Processeurs, 675.25m));
            Assert.IsFalse (unStock != unAutreStock);

            // Deux stocks avec des succursales différentes.
            unAutreStock = new Stock (new Succursale ("666, rue Unitaire",
                "4186561234"), new Produit ("1001", "Core i9",
                Categorie.Processeurs, 675.25m));
            Assert.IsTrue (unStock != unAutreStock);

            // Deux stocks avec des produits différents.
            unAutreStock = new Stock (new Succursale ("1001, rue du Test",
                "4186561234"), new Produit ("1002", "Core i9",
                Categorie.Processeurs, 675.25m));
            Assert.IsTrue (unStock != unAutreStock);

            // Deux stocks avec des informations différentes.
            unAutreStock = new Stock (new Succursale ("666, rue Unitaire",
                "4186561234"), new Produit ("1002", "Core i9",
                Categorie.Processeurs, 675.25m));
            Assert.IsTrue (unStock != unAutreStock);
        }

        [TestMethod]
        public void TesterMethodeEquals ()
        {
            Stock unStock;
            Stock unAutreStock;

            // Deux variables qui font référence au même stock.
            unStock = new Stock (new Succursale ("1000, rue du Test",
                "4186561234"), new Produit ("1001", "Core i9",
                Categorie.Processeurs, 675.25m));
            unAutreStock = unStock;
            Assert.IsTrue (unStock.Equals (unAutreStock));

            // Stock passé en paramètre nul.
            unAutreStock = null;
            Assert.IsFalse (unStock.Equals (unAutreStock));

            // Deux stocks contenant les mêmes informations.
            unAutreStock = new Stock (new Succursale ("1000, rue du Test",
                "4186561234"), new Produit ("1001", "Core i9",
                Categorie.Processeurs, 675.25m));
            Assert.IsTrue (unStock.Equals (unAutreStock));

            // Deux stocks avec des succursales différentes.
            unAutreStock = new Stock (new Succursale ("666, rue Unitaire",
                "4186561234"), new Produit ("1001", "Core i9",
                Categorie.Processeurs, 675.25m));
            Assert.IsFalse (unStock.Equals (unAutreStock));

            // Deux stocks avec des produits différents.
            unAutreStock = new Stock (new Succursale ("1001, rue du Test",
                "4186561234"), new Produit ("1002", "Core i9",
                Categorie.Processeurs, 675.25m));
            Assert.IsFalse (unStock.Equals (unAutreStock));

            // Deux stocks avec des informations différentes.
            unAutreStock = new Stock (new Succursale ("666, rue Unitaire",
                "4186561234"), new Produit ("1002", "Core i9",
                Categorie.Processeurs, 675.25m));
            Assert.IsFalse (unStock.Equals (unAutreStock));

            // Objet passé en paramètre n'étant pas un produit.
            Assert.IsFalse (unStock.Equals ("Succursale 1;Produit 1"));
        }
    }
}
