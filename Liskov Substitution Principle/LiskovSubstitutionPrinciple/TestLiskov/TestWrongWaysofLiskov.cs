using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiskovSubstitutionPrincipleWrong;
namespace TestLiskov
{
    [TestClass]
    public class TestWrongWaysofLiskov
    {
        [TestMethod]
        public void TestRechthoek5bij3()
        {

            Rectangle rectangle = new Rectangle { Height = 5, Width = 3 };
            int result = AreaCalculator.CalculateArea(rectangle);
            Assert.AreEqual(15, result);
        }
        [TestMethod]
        public void Testvierkant3bij3()
        {
            Square square = new Square { Height = 3 };
            int result = AreaCalculator.CalculateArea(square);
            Assert.AreEqual(9, result);
        }
        [TestMethod]
        public void TestofeenvierkantdoorkangaanalseenRechthoek()
        {
            Rectangle rectangle = new Square();
            rectangle.Height = 4;
            rectangle.Width = 6;
            var result = AreaCalculator.CalculateArea(rectangle);
            Assert.AreEqual(24, result);
            // nee is 36 omdat je in Square aabgeeft dat de Height en Width 
            // dezelfde is dus als je dan 6 * 6 doet om de area van een rechthoek te vinden klopt het niet en is het niet volgens Liskov
        }
    }
}
