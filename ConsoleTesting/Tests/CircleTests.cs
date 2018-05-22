using ConsoleTesting.Shapes;
using NUnit.Framework;

namespace ConsoleTesting.Tests
{
  [TestFixture]
  internal class CircleTests
  {
    [Test]
    public static void CirleDrawIsNotEmpty()
    {
      Circle circle = new Circle();
      Assert.That(circle.Draw, Is.Not.Empty);
    }
  }
}