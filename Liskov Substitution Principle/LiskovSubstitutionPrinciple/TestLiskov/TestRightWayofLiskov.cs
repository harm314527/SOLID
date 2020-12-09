using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiskovSubstitutionPrincipleRight;


namespace TestLiskov
{
    [TestClass]
    public class TestRightWayofLiskov
    {

        [TestMethod]
        public void TestRechthoek5bij3()
        {

            Rectangle rectangle = new Rectangle { Height = 5, Width = 3 };
            int result = rectangle.Area();
            Assert.AreEqual(15, result);
        }
        [TestMethod]
        public void Testvierkant3bij3()
        {
            Square square = new Square { Sidelength = 3 };
            int result = square.Area();
            Assert.AreEqual(9, result);
        }
        [TestMethod]
        public void TestofeenvierkantdoorkangaanalseenVorm()
        {
            Shape shape = new Square { Sidelength = 6};
         
            int result = shape.Area();
            Assert.AreEqual(36, result);
           //de Base klasse Schape kan nu doorgaan als een vierkant
        }
        [TestMethod]
        public void TestofeenRechthoekdoorkangaanalseenVorm()
        {
            Shape shape = new Rectangle { Height = 6, Width = 4 };

            int result = shape.Area();
            Assert.AreEqual(24, result);
            //de Base klasse Schape kan nu doorgaan als een Rechthoek
        }
    }
}
