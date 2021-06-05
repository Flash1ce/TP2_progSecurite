using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Commerce;

namespace travail2_tests
{
    [TestClass]
    public class TestsClasseProduit
    {
        [TestMethod]
        public void TesterConstructeurAvecParametresValides ()
        {
            Produit unProduit;

            unProduit = new Produit ("1001", "Core i9", Categorie.Processeurs,
                675.25m);
            Assert.AreEqual ("1001", unProduit.Code);
            Assert.AreEqual ("Core i9", unProduit.Description);
            Assert.AreEqual (Categorie.Processeurs, unProduit.Categorie);
            Assert.AreEqual (675.25m, unProduit.Cout);
        }

        [TestMethod]
        public void TesterConstructeurAvecPremierParametreInvalide ()
        {
            Produit unProduit = null;

            try
            {
                unProduit = new Produit ("", "Core i9", Categorie.Processeurs,
                    675.25m);
                Assert.Fail ();
            }
            catch (ArgumentException ex)
            {
                Assert.IsNull (unProduit);
                Assert.AreEqual ("Le code est vide.", ex.Message);
            }

            try
            {
                unProduit = new Produit ("", "", Categorie.Processeurs,
                    675.25m);
                Assert.Fail ();
            }
            catch (ArgumentException ex)
            {
                Assert.IsNull (unProduit);
                Assert.AreEqual ("Le code est vide.", ex.Message);
            }

            try
            {
                unProduit = new Produit ("", "Core i9", Categorie.Processeurs,
                    0);
                Assert.Fail ();
            }
            catch (ArgumentException ex)
            {
                Assert.IsNull (unProduit);
                Assert.AreEqual ("Le code est vide.", ex.Message);
            }

            try
            {
                unProduit = new Produit ("", "Core i9", Categorie.Processeurs,
                    -1);
                Assert.Fail ();
            }
            catch (ArgumentException ex)
            {
                Assert.IsNull (unProduit);
                Assert.AreEqual ("Le code est vide.", ex.Message);
            }
        }

        [TestMethod]
        public void TesterConstructeurAvecDeuxiemeParametreInvalide ()
        {
            Produit unProduit = null;

            try
            {
                unProduit = new Produit ("1001", "", Categorie.Processeurs,
                    675.25m);
                Assert.Fail ();
            }
            catch (ArgumentException ex)
            {
                Assert.IsNull (unProduit);
                Assert.AreEqual ("La description est vide.", ex.Message);
            }

            try
            {
                unProduit = new Produit ("1001", "", Categorie.Processeurs,
                    0);
                Assert.Fail ();
            }
            catch (ArgumentException ex)
            {
                Assert.IsNull (unProduit);
                Assert.AreEqual ("La description est vide.", ex.Message);
            }

            try
            {
                unProduit = new Produit ("1001", "", Categorie.Processeurs,
                    -1);
                Assert.Fail ();
            }
            catch (ArgumentException ex)
            {
                Assert.IsNull (unProduit);
                Assert.AreEqual ("La description est vide.", ex.Message);
            }
        }

        [TestMethod]
        public void TesterConstructeurAvecQuatriemeParametreInvalide ()
        {
            Produit unProduit = null;

            try
            {
                unProduit = new Produit ("1001", "Core i9",
                    Categorie.Processeurs, 0);
                Assert.Fail ();
            }
            catch (ArgumentException ex)
            {
                Assert.IsNull (unProduit);
                Assert.AreEqual ("Le coût n'est pas supérieur à zéro.",
                    ex.Message);
            }

            try
            {
                unProduit = new Produit ("1001", "Core i9",
                    Categorie.Processeurs, -1);
                Assert.Fail ();
            }
            catch (ArgumentException ex)
            {
                Assert.IsNull (unProduit);
                Assert.AreEqual ("Le coût n'est pas supérieur à zéro.",
                    ex.Message);
            }
        }

        [TestMethod]
        public void TesterAccesseurSetDescriptionAvecParametreValide ()
        {
            Produit unProduit = new Produit ("1001", "Core i9",
                Categorie.Processeurs, 675.25m);

            unProduit.Description = "Ryzen 3900x";
            Assert.AreEqual ("1001", unProduit.Code);
            Assert.AreEqual ("Ryzen 3900x", unProduit.Description);
            Assert.AreEqual (Categorie.Processeurs, unProduit.Categorie);
            Assert.AreEqual (675.25m, unProduit.Cout);
        }

        [TestMethod]
        public void TesterAccesseurSetDescriptionAvecParametreInvalide ()
        {
            Produit unProduit = new Produit ("1001", "Core i9",
                Categorie.Processeurs, 675.25m);

            try
            {
                unProduit.Description = "";
                Assert.Fail ();
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual ("Core i9", unProduit.Description);
                Assert.AreEqual ("La description est vide.", ex.Message);
            }
        }

        [TestMethod]
        public void TesterAccesseurSetCoutAvecParametreValide ()
        {
            Produit unProduit = new Produit ("1001", "Core i9",
                Categorie.Processeurs, 675.25m);

            unProduit.Cout = 547.50m;
            Assert.AreEqual ("1001", unProduit.Code);
            Assert.AreEqual ("Core i9", unProduit.Description);
            Assert.AreEqual (Categorie.Processeurs, unProduit.Categorie);
            Assert.AreEqual (547.50m, unProduit.Cout);
        }

        [TestMethod]
        public void TesterAccesseurSetCoutAvecParametreInvalide ()
        {
            Produit unProduit = new Produit ("1001", "Core i9",
                Categorie.Processeurs, 675.25m);

            try
            {
                unProduit.Cout = 0;
                Assert.Fail ();
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual (675.25m, unProduit.Cout);
                Assert.AreEqual ("Le coût n'est pas supérieur à zéro.",
                    ex.Message);
            }

            try
            {
                unProduit.Cout = -1;
                Assert.Fail ();
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual (675.25m, unProduit.Cout);
                Assert.AreEqual ("Le coût n'est pas supérieur à zéro.",
                    ex.Message);
            }
        }

        [TestMethod]
        public void TesterMethodeToString ()
        {
            string strCode = "1001";
            string strDescription = "Core i9";
            Produit unProduit = new Produit (strCode, strDescription,
                Categorie.Processeurs, 675.25m);

            Assert.AreEqual (string.Format ("{0} - {1}", strCode,
                strDescription), unProduit.ToString ());
        }
 
        [TestMethod]
        public void TesterOperateurComparaironEgalite ()
        {
            Produit unProduit;
            Produit unAutreProduit;

            // Deux variables qui font référence au même produit.
            unProduit = new Produit ("1001", "Core i9", Categorie.Processeurs,
                675.25m);
            unAutreProduit = unProduit;
            Assert.IsTrue (unProduit == unAutreProduit);

            // Produit à gauche nul.
            unProduit = null;
            Assert.IsFalse (unProduit == unAutreProduit);

            // Produit à droite nul.
            Assert.IsFalse (unAutreProduit == unProduit);

            // Deux variables qui font référence à nul.
            unAutreProduit = null;
            Assert.IsTrue (unProduit == unAutreProduit);

            // Deux produits contenant les mêmes informations.
            unProduit = new Produit ("1001", "Core i9", Categorie.Processeurs,
                675.25m);
            unAutreProduit = new Produit ("1001", "Core i9",
                Categorie.Processeurs, 675.25m);
            Assert.IsTrue (unProduit == unAutreProduit);

            // Deux produits avec des codes différents.
            unAutreProduit = new Produit ("1002", "Core i9",
                Categorie.Processeurs, 675.25m);
            Assert.IsFalse (unProduit == unAutreProduit);

            // Deux produits avec des descriptions différentes.
            unAutreProduit = new Produit ("1001", "Ryzen 3900x",
                Categorie.Processeurs, 675.25m);
            Assert.IsTrue (unProduit == unAutreProduit);

            // Deux produits avec des catégories différentes.
            unAutreProduit = new Produit ("1001", "Core i9",
                Categorie.Memoires, 675.25m);
            Assert.IsTrue (unProduit == unAutreProduit);

            // Deux produits avec des coûts différents.
            unAutreProduit = new Produit ("1001", "Core i9",
                Categorie.Processeurs, 547.50m);
            Assert.IsTrue (unProduit == unAutreProduit);

            // Deux produits avec des informations différentes.
            unAutreProduit = new Produit ("1002", "Ryzen 3900x",
                Categorie.Memoires, 547.50m);
            Assert.IsFalse (unProduit == unAutreProduit);
        }

        [TestMethod]
        public void TesterOperateurComparaironDifference ()
        {
            Produit unProduit;
            Produit unAutreProduit;

            // Deux variables qui font référence au même produit.
            unProduit = new Produit ("1001", "Core i9", Categorie.Processeurs,
                675.25m);
            unAutreProduit = unProduit;
            Assert.IsFalse (unProduit != unAutreProduit);

            // Produit à gauche nul.
            unProduit = null;
            Assert.IsTrue (unProduit != unAutreProduit);

            // Produit à droite nulle.
            Assert.IsTrue (unAutreProduit != unProduit);

            // Deux variables qui font référence à nul.
            unAutreProduit = null;
            Assert.IsFalse (unProduit != unAutreProduit);

            // Deux produits contenant les mêmes informations.
            unProduit = new Produit ("1001", "Core i9", Categorie.Processeurs,
                675.25m);
            unAutreProduit = new Produit ("1001", "Core i9",
                Categorie.Processeurs, 675.25m);
            Assert.IsFalse (unProduit != unAutreProduit);

            // Deux produits avec des codes différents.
            unAutreProduit = new Produit ("1002", "Core i9",
                Categorie.Processeurs, 675.25m);
            Assert.IsTrue (unProduit != unAutreProduit);

            // Deux produits avec des descriptions différentes.
            unAutreProduit = new Produit ("1001", "Ryzen 3900x",
                Categorie.Processeurs, 675.25m);
            Assert.IsFalse (unProduit != unAutreProduit);

            // Deux produits avec des catégories différentes.
            unAutreProduit = new Produit ("1001", "Core i9",
                Categorie.Memoires, 675.25m);
            Assert.IsFalse (unProduit != unAutreProduit);

            // Deux produits avec des coûts différents.
            unAutreProduit = new Produit ("1001", "Core i9",
                Categorie.Processeurs, 547.50m);
            Assert.IsFalse (unProduit != unAutreProduit);

            // Deux produits avec des informations différentes.
            unAutreProduit = new Produit ("1002", "Ryzen 3900x",
                Categorie.Memoires, 547.50m);
            Assert.IsTrue (unProduit != unAutreProduit);
        }

        [TestMethod]
        public void TesterMethodeEquals ()
        {
            Produit unProduit;
            Produit unAutreProduit;

            // Deux variables qui font référence au même produit.
            unProduit = new Produit ("1001", "Core i9", Categorie.Processeurs,
                675.25m);
            unAutreProduit = unProduit;
            Assert.IsTrue (unProduit.Equals (unAutreProduit));

            // Produit passé en paramètre nul.
            unAutreProduit = null;
            Assert.IsFalse (unProduit.Equals (unAutreProduit));

            // Deux produits contenant les mêmes informations.
            unAutreProduit = new Produit ("1001", "Core i9",
                Categorie.Processeurs, 675.25m);
            Assert.IsTrue (unProduit.Equals (unAutreProduit));

            // Deux produits avec des codes différents.
            unAutreProduit = new Produit ("1002", "Core i9",
                Categorie.Processeurs, 675.25m);
            Assert.IsFalse (unProduit.Equals (unAutreProduit));

            // Deux produits avec des descriptions différentes.
            unAutreProduit = new Produit ("1001", "Ryzen 3900x",
                Categorie.Processeurs, 675.25m);
            Assert.IsTrue (unProduit.Equals (unAutreProduit));

            // Deux produits avec des catégories différentes.
            unAutreProduit = new Produit ("1001", "Core i9",
                Categorie.Memoires, 675.25m);
            Assert.IsTrue (unProduit.Equals (unAutreProduit));

            // Deux produits avec des coûts différents.
            unAutreProduit = new Produit ("1001", "Core i9",
                Categorie.Processeurs, 547.50m);
            Assert.IsTrue (unProduit.Equals (unAutreProduit));

            // Deux produits avec des informations différentes.
            unAutreProduit = new Produit ("1002", "Ryzen 3900x",
                Categorie.Memoires, 547.50m);
            Assert.IsFalse (unProduit.Equals (unAutreProduit));

            // Objet passé en paramètre n'étant pas un produit.
            Assert.IsFalse (unProduit.Equals ("1001"));
        }

    }
}