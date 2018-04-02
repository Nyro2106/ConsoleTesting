using ConsoleTesting.Shapes;
using NUnit.Framework;

namespace ConsoleTesting.Tests
{
  [TestFixture]
  internal class CircleTests
  {
    [Test, Description("Is this a real test, is this just fantasy.")]
    public static void CirleDrawIsNotEmpty()
    {
      Circle circle = new Circle();
      Assert.That(circle.Draw, Is.Not.Empty);
    }
  }
}