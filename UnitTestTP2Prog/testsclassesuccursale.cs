using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Commerce;


namespace travail2_tests
{
    [TestClass]
    public class TestsClasseSuccursale
    {
        private static string [] g_strLesTelephones = new string [] { "", "4",
            "41", "418", "4186", "41865", "418656", "4186561", "41865612",
            "418656123", "41865612345", "418656123456", "4186561234567",
            "41865612345678", "418656123456789", "4186561234567890",
            "41865612345678901", "418656123456789012", "4186561234567890123",
            "41865612345678901234", "418656123456789012345"};

        [TestMethod]
        public void TesterConstructeurAvecParametresValides ()
        {
            Succursale uneSuccursale;

            uneSuccursale = new Succursale ("1000, rue du Test", "4186561234");
            Assert.AreEqual ("1000, rue du Test", uneSuccursale.Adresse);
            Assert.AreEqual ("4186561234", uneSuccursale.Telephone);
            uneSuccursale = new Succursale ("1000, rue du Test", "5146561234");
            Assert.AreEqual ("1000, rue du Test", uneSuccursale.Adresse);
            Assert.AreEqual ("5146561234", uneSuccursale.Telephone);
        }

        [TestMethod]
        public void TesterConstructeurAvecPremierParametreInvalide ()
        {
            Succursale uneSuccursale = null;

            // Cas 1: Avec le deuxième paramètre valide.
            try
            {
                uneSuccursale = new Succursale ("", "4186561234");
                Assert.Fail ();
            }
            catch (ArgumentException ex)
            {
                Assert.IsNull (uneSuccursale);
                Assert.AreEqual ("L'adresse est vide.", ex.Message);
            }

            // Cas 2: Avec le deuxième paramètre invalide.
            try
            {
                uneSuccursale = new Succursale ("", "");
            }
            catch (ArgumentException ex)
            {
                Assert.IsNull (uneSuccursale);
                Assert.AreEqual ("L'adresse est vide.", ex.Message);
            }
        }

        [TestMethod]
        public void TesterConstructeurAvecDeuxiemeParametreInvaldeCas1 ()
        {
            Succursale uneSuccursale = null;
            int i;

            // Sous-cas 1a: Longueur invalide (de 0 à 9 et de 11 à 20).
            for (i = 0; i < 19; i++)
            {
                try
                {
                    uneSuccursale = new Succursale ("1000, rue du Test",
                        g_strLesTelephones [i]);
                    Assert.Fail ();
                }
                catch (ArgumentException ex)
                {
                    Assert.IsNull (uneSuccursale);
                    Assert.AreEqual ("La longueur du numéro de téléphone est "
                        + "invalide.", ex.Message);
                }
            }

            // Sous-cas 1b: Longueur invalide avec code régional invalide.
            try
            {
                uneSuccursale = new Succursale ("1000, rue du Test",
                    "819656123");
                Assert.Fail ();
            }
            catch (ArgumentException ex)
            {
                Assert.IsNull (uneSuccursale);
                Assert.AreEqual ("La longueur du numéro de téléphone est "
                    + "invalide.", ex.Message);
            }

            // Sous-cas 1c: Longueur invalide avec caractères non-numériques.
            try
            {
                uneSuccursale = new Succursale ("1000, rue du Test",
                    "418656a23");
                Assert.Fail ();
            }
            catch (ArgumentException ex)
            {
                Assert.IsNull (uneSuccursale);
                Assert.AreEqual ("La longueur du numéro de téléphone est "
                    + "invalide.", ex.Message);
            }

            // Sous-cas 1d: Longueur invalide avec code régional invalide et
            // caractères non-numériques.
            try
            {
                uneSuccursale = new Succursale ("1000, rue du Test",
                    "819656a23");
                Assert.Fail ();
            }
            catch (ArgumentException ex)
            {
                Assert.IsNull (uneSuccursale);
                Assert.AreEqual ("La longueur du numéro de téléphone est "
                    + "invalide.", ex.Message);
            }
        }

        [TestMethod]
        public void TesterConstructeurAvecDeuxiemeParametreInvaldeCas2 ()
        {
            Succursale uneSuccursale = null;
            int i;
            char [] cLesChiffres;
            char cTempo;
            string strCode;

            // Sous-cas 2a: Code régional invalide (de 100 à 417, de 419 à 513,
            // de 515 à 999 ainsi que 41a, 4a8 et a18).
            for (i = 100; i <= 417; i++)
            {
                try
                {
                    uneSuccursale = new Succursale ("1000, rue du Test",
                        string.Format ("{0}6561234", i));
                    Assert.Fail ();
                }
                catch (ArgumentException ex)
                {
                    Assert.IsNull (uneSuccursale);
                    Assert.AreEqual ("Le code régional est invalide.",
                        ex.Message);
                }
            }
            for (i = 419; i <= 513; i++)
            {
                try
                {
                    uneSuccursale = new Succursale ("1000, rue du Test",
                        string.Format ("{0}6561234", i));
                    Assert.Fail ();
                }
                catch (ArgumentException ex)
                {
                    Assert.IsNull (uneSuccursale);
                    Assert.AreEqual ("Le code régional est invalide.",
                        ex.Message);
                }
            }
            for (i = 515; i <= 999; i++)
            {
                try
                {
                    uneSuccursale = new Succursale ("1000, rue du Test",
                        string.Format ("{0}6561234", i));
                    Assert.Fail ();
                }
                catch (ArgumentException ex)
                {
                    Assert.IsNull (uneSuccursale);
                    Assert.AreEqual ("Le code régional est invalide.",
                        ex.Message);
                }
            }
            cLesChiffres = new char [] { '4', '1', '8' };
            for (i = 0; i < 3; i++)
            {
                cTempo = cLesChiffres [i];
                cLesChiffres [i] = 'a';
                strCode = new string (cLesChiffres);
                cLesChiffres [i] = cTempo;
                try
                {
                    uneSuccursale = new Succursale ("1000, rue du Test",
                        string.Format ("{0}6561234", strCode));
                    Assert.Fail ();
                }
                catch (ArgumentException ex)
                {
                    Assert.IsNull (uneSuccursale);
                    Assert.AreEqual ("Le code régional est invalide.",
                        ex.Message);
                }
            }

            // Sous-cas 2b: Code régional invalide avec caractères
            // non-numériques.
            try
            {
                uneSuccursale = new Succursale ("1000, rue du Test",
                    "819656a234");
                Assert.Fail ();
            }
            catch (ArgumentException ex)
            {
                Assert.IsNull (uneSuccursale);
                Assert.AreEqual ("Le code régional est invalide.", ex.Message);
            }
        }

        [TestMethod]
        public void TesterConstructeurAvecDeuxiemeParametreInvaldeCas3 ()
        {
            Succursale uneSuccursale = null;
            char [] cLesChiffres = new char [] {'4', '1', '8', '6', '5', '6',
                '1', '2', '3', '4'};
            int i;
            int j;
            char cTempo;
            string strNumeroTest;

            // Cas 3: Caractères non-numériques.

            // Pour chaque caractère du numéro.
            for (i = 3; i < 10; i++)
            {
                // Pour chaque code de caractère de 0 à '0' - 1 (i.e. 47).
                for (j = 0; j < '0'; j++)
                {
                    cTempo = cLesChiffres [i];
                    cLesChiffres [i] = (char) j;
                    strNumeroTest = new string (cLesChiffres);
                    cLesChiffres [i] = cTempo;
                    try
                    {
                        uneSuccursale = new Succursale ("1000, rue du Test",
                            strNumeroTest);
                        Assert.Fail ();
                    }
                    catch (ArgumentException ex)
                    {
                        Assert.IsNull (uneSuccursale);
                        Assert.AreEqual ("Le numéro de téléphone contient au "
                            + "moins un caractère qui n'est pas un chiffre.",
                            ex.Message);
                    }
                }

                // Pour chaque code de caractère de '9' + 1 (i.e. 58) à
                // char.MaxValue (i.e. 65535).
                for (j = '9' + 1; j <= char.MaxValue; j++)
                {
                    cTempo = cLesChiffres [i];
                    cLesChiffres [i] = (char) j;
                    strNumeroTest = new string (cLesChiffres);
                    cLesChiffres [i] = cTempo;
                    try
                    {
                        uneSuccursale = new Succursale ("1000, rue du Test",
                            strNumeroTest);
                        Assert.Fail ();
                    }
                    catch (ArgumentException ex)
                    {
                        Assert.IsNull (uneSuccursale);
                        Assert.AreEqual ("Le numéro de téléphone contient au "
                            + "moins un caractère qui n'est pas un chiffre.",
                            ex.Message);
                    }
                }
            }
        }

        [TestMethod]
        public void TesterAccesseurSetTelephoneAvecParametreValide ()
        {
            Succursale uneSuccursale = new Succursale ("1000, rue du Test",
                "4186561234");

            uneSuccursale.Telephone = "4186880987";
            Assert.AreEqual ("1000, rue du Test", uneSuccursale.Adresse);
            Assert.AreEqual ("4186880987", uneSuccursale.Telephone);
            uneSuccursale.Telephone = "5146880987";
            Assert.AreEqual ("1000, rue du Test", uneSuccursale.Adresse);
            Assert.AreEqual ("5146880987", uneSuccursale.Telephone);
        }

        [TestMethod]
        public void TesterAccesseurSetTelephoneAvecParametreInvalideCas1 ()
        {
            string strNumeroValide = "4186561234";
            Succursale uneSuccursale = new Succursale ("1000, rue du Test",
                strNumeroValide);
            int i;

            // Sous-cas 1a: Longueur invalide (de 0 à 9 et de 11 à 20).
            for (i = 0; i < 19; i++)
            {
                try
                {
                    uneSuccursale.Telephone = g_strLesTelephones [i];
                    Assert.Fail ();
                }
                catch (ArgumentException ex)
                {
                    Assert.AreEqual (strNumeroValide, uneSuccursale.Telephone);
                    Assert.AreEqual ("La longueur du numéro de téléphone est "
                        + "invalide.", ex.Message);
                }
            }

            // Sous-cas 1b: Longueur invalide avec code régional invalide.
            try
            {
                uneSuccursale.Telephone = "819656123";
                Assert.Fail ();
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual (strNumeroValide, uneSuccursale.Telephone);
                Assert.AreEqual ("La longueur du numéro de téléphone est "
                    + "invalide.", ex.Message);
            }

            // Sous-cas 1c: Longueur invalide avec caractères non-numériques.
            try
            {
                uneSuccursale.Telephone = "418656a23";
                Assert.Fail ();
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual (strNumeroValide, uneSuccursale.Telephone);
                Assert.AreEqual ("La longueur du numéro de téléphone est "
                    + "invalide.", ex.Message);
            }

            // Sous-cas 1d: Longueur invalide avec code régional invalide et
            // caractères non-numériques.
            try
            {
                uneSuccursale.Telephone = "819656a23";
                Assert.Fail ();
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual (strNumeroValide, uneSuccursale.Telephone);
                Assert.AreEqual ("La longueur du numéro de téléphone est "
                    + "invalide.", ex.Message);
            }
        }

        [TestMethod]
        public void TesterAccesseurSetTelephoneAvecParametreInvalideCas2 ()
        {
            string strNumeroValide = "4186561234";
            Succursale uneSuccursale = new Succursale ("1000, rue du Test",
                strNumeroValide);
            int i;

            char [] cLesChiffres;
            char cTempo;
            string strCode;

            // Sous-cas 2a: Code régional invalide (de 100 à 417, de 419 à 513,
            // de 515 à 999 ainsi que 41a, 4a8 et a18).
            for (i = 100; i <= 417; i++)
            {
                try
                {
                    uneSuccursale.Telephone = string.Format ("{0}6561234", i);
                    Assert.Fail ();
                }
                catch (ArgumentException ex)
                {
                    Assert.AreEqual (strNumeroValide, uneSuccursale.Telephone);
                    Assert.AreEqual ("Le code régional est invalide.",
                        ex.Message);
                }
            }
            for (i = 419; i <= 513; i++)
            {
                try
                {
                    uneSuccursale.Telephone = string.Format ("{0}6561234", i);
                    Assert.Fail ();
                }
                catch (ArgumentException ex)
                {
                    Assert.AreEqual (strNumeroValide, uneSuccursale.Telephone);
                    Assert.AreEqual ("Le code régional est invalide.",
                        ex.Message);
                }
            }
            for (i = 515; i <= 999; i++)
            {
                try
                {
                    uneSuccursale.Telephone = string.Format ("{0}6561234", i);
                    Assert.Fail ();
                }
                catch (ArgumentException ex)
                {
                    Assert.AreEqual (strNumeroValide, uneSuccursale.Telephone);
                    Assert.AreEqual ("Le code régional est invalide.",
                        ex.Message);
                }
            }
            cLesChiffres = new char [] { '4', '1', '8' };
            for (i = 0; i < 3; i++)
            {
                cTempo = cLesChiffres [i];
                cLesChiffres [i] = 'a';
                strCode = new string (cLesChiffres);
                cLesChiffres [i] = cTempo;
                try
                {
                    uneSuccursale.Telephone = string.Format ("{0}6561234",
                        strCode);
                    Assert.Fail ();
                }
                catch (ArgumentException ex)
                {
                    Assert.AreEqual (strNumeroValide, uneSuccursale.Telephone);
                    Assert.AreEqual ("Le code régional est invalide.",
                        ex.Message);
                }
            }

            // Sous-cas 2b: Code régional invalide avec caractères
            // non-numériques.
            try
            {
                uneSuccursale.Telephone = "819656a234";
                Assert.Fail ();
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual (strNumeroValide, uneSuccursale.Telephone);
                Assert.AreEqual ("Le code régional est invalide.", ex.Message);
            }
        }

        [TestMethod]
        public void TesterAccesseurSetTelephoneAvecParametreInvalideCas3 ()
        {
            string strNumeroValide = "4186561234";
            Succursale uneSuccursale = new Succursale ("1000, rue du Test",
                strNumeroValide);
            char [] cLesChiffres = new char [] {'4', '1', '8', '6', '5', '6',
                '1', '2', '3', '4'};
            int i;
            int j;
            char cTempo;
            string strNumeroTest;

            // Cas 3: Caractères non-numériques.

            // Pour chaque caractère du numéro.
            for (i = 3; i < 10; i++)
            {
                // Pour chaque code de caractère de 0 à '0' - 1 (i.e. 47).
                for (j = 0; j < '0'; j++)
                {
                    cTempo = cLesChiffres [i];
                    cLesChiffres [i] = (char) j;
                    strNumeroTest = new string (cLesChiffres);
                    cLesChiffres [i] = cTempo;
                    try
                    {
                        uneSuccursale.Telephone = strNumeroTest;
                        Assert.Fail ();
                    }
                    catch (ArgumentException ex)
                    {
                        Assert.AreEqual (strNumeroValide,
                            uneSuccursale.Telephone);
                        Assert.AreEqual ("Le numéro de téléphone contient au "
                            + "moins un caractère qui n'est pas un chiffre.",
                            ex.Message);
                    }
                }

                // Pour chaque code de caractère de '9' + 1 (i.e. 58) à
                // char.MaxValue (i.e. 65535).
                for (j = '9' + 1; j <= char.MaxValue; j++)
                {
                    cTempo = cLesChiffres [i];
                    cLesChiffres [i] = (char) j;
                    strNumeroTest = new string (cLesChiffres);
                    cLesChiffres [i] = cTempo;
                    try
                    {
                        uneSuccursale.Telephone = strNumeroTest;
                        Assert.Fail ();
                    }
                    catch (ArgumentException ex)
                    {
                        Assert.AreEqual (strNumeroValide,
                            uneSuccursale.Telephone);
                        Assert.AreEqual ("Le numéro de téléphone contient au "
                            + "moins un caractère qui n'est pas un chiffre.",
                            ex.Message);
                    }
                }
            }
        }

        [TestMethod]
        public void TesterMethodeToString ()
        {
            string strAdresse = "1000, rue du Test";
            string strNumero = "4186561234";
            Succursale uneSuccursale = new Succursale (strAdresse, strNumero);

            Assert.AreEqual (string.Format ("{0} ({1}-{2}-{3})", strAdresse,
                strNumero.Substring (0, 3), strNumero.Substring (3, 3),
                strNumero.Substring (6, 4)), uneSuccursale.ToString ());
        }

        [TestMethod]
        public void TesterOperateurComparaironEgalite ()
        {
            Succursale uneSuccursale;
            Succursale uneAutreSuccursale;

            // Deux variables qui font référence à la même succursale.
            uneSuccursale = new Succursale ("1000, rue du Test",
                "4186561234");
            uneAutreSuccursale = uneSuccursale;
            Assert.IsTrue (uneSuccursale == uneAutreSuccursale);

            // Succursale à gauche nulle.
            uneSuccursale = null;
            Assert.IsFalse (uneSuccursale == uneAutreSuccursale);

            // Succursale à droite nulle.
            Assert.IsFalse (uneAutreSuccursale == uneSuccursale);

            // Deux variables qui font référence à nul.
            uneAutreSuccursale = null;
            Assert.IsTrue (uneSuccursale == uneAutreSuccursale);

            // Deux succursales contenant les mêmes informations.
            uneSuccursale = new Succursale ("1000, rue du Test", "4186561234");
            uneAutreSuccursale = new Succursale ("1000, rue du Test",
                "4186561234");
            Assert.IsTrue (uneSuccursale == uneAutreSuccursale);

            // Deux succursales avec des adresses différentes.
            uneAutreSuccursale = new Succursale ("666, rue Unitaire",
                "4186561234");
            Assert.IsFalse (uneSuccursale == uneAutreSuccursale);

            // Deux succursales avec des numéros de téléphone différents.
            uneAutreSuccursale = new Succursale ("1000, rue du Test",
                "5146561234");
            Assert.IsTrue (uneSuccursale == uneAutreSuccursale);

            // Deux succursales avec des informations différentes.
            uneAutreSuccursale = new Succursale ("666, rue Unitaire",
                "5146561234");
            Assert.IsFalse (uneSuccursale == uneAutreSuccursale);
        }

        [TestMethod]
        public void TesterOperateurComparaisonDifference ()
        {
            Succursale uneSuccursale;
            Succursale uneAutreSuccursale;

            // Deux variables qui font référence à la même succursale.
            uneSuccursale = new Succursale ("1000, rue du Test",
                "4186561234");
            uneAutreSuccursale = uneSuccursale;
            Assert.IsFalse (uneSuccursale != uneAutreSuccursale);

            // Succursale à gauche nulle.
            uneSuccursale = null;
            Assert.IsTrue (uneSuccursale != uneAutreSuccursale);

            // Succursale à droite nulle.
            Assert.IsTrue (uneAutreSuccursale != uneSuccursale);

            // Deux variables qui font référence à nul.
            uneAutreSuccursale = null;
            Assert.IsFalse (uneSuccursale != uneAutreSuccursale);

            // Deux succursales contenant les mêmes informations.
            uneSuccursale = new Succursale ("1000, rue du Test", "4186561234");
            uneAutreSuccursale = new Succursale ("1000, rue du Test",
                "4186561234");
            Assert.IsFalse (uneSuccursale != uneAutreSuccursale);

            // Deux succursales avec des adresses différentes.
            uneAutreSuccursale = new Succursale ("666, rue Unitaire",
                "4186561234");
            Assert.IsTrue (uneSuccursale != uneAutreSuccursale);

            // Deux succursales avec des numéros de téléphone différents.
            uneAutreSuccursale = new Succursale ("1000, rue du Test",
                "5146561234");
            Assert.IsFalse (uneSuccursale != uneAutreSuccursale);

            // Deux succursales avec des informations différentes.
            uneAutreSuccursale = new Succursale ("666, rue Unitaire",
                "5146561234");
            Assert.IsTrue (uneSuccursale != uneAutreSuccursale);
        }

        [TestMethod]
        public void TesterMethodeEquals ()
        {
            Succursale uneSuccursale;
            Succursale uneAutreSuccursale;

            // Deux variables qui font référence à la même succursale.
            uneSuccursale = new Succursale ("1000, rue du Test",
                "4186561234");
            uneAutreSuccursale = uneSuccursale;
            Assert.IsTrue (uneSuccursale.Equals (uneAutreSuccursale));

            // Succursale passée en paramètre nulle.
            uneAutreSuccursale = null;
            Assert.IsFalse (uneSuccursale.Equals (uneAutreSuccursale));

            // Deux succursales contenant les mêmes informations.
            uneAutreSuccursale = new Succursale ("1000, rue du Test",
                "4186561234");
            Assert.IsTrue (uneSuccursale.Equals (uneAutreSuccursale));

            // Deux succursales avec des adresses différentes.
            uneAutreSuccursale = new Succursale ("666, rue Unitaire",
                "4186561234");
            Assert.IsFalse (uneSuccursale.Equals (uneAutreSuccursale));

            // Deux succursales avec des numéros de téléphone différents.
            uneAutreSuccursale = new Succursale ("1000, rue du Test",
                "5146561234");
            Assert.IsTrue (uneSuccursale.Equals (uneAutreSuccursale));

            // Deux succursales avec des informations différentes.
            uneAutreSuccursale = new Succursale ("666, rue Unitaire",
                "5146561234");
            Assert.IsFalse (uneSuccursale.Equals (uneAutreSuccursale));

            // Objet passé en paramètre n'étant pas une succursale.
            Assert.IsFalse (uneSuccursale.Equals ("1000, rue du test"));
        }
    }
}