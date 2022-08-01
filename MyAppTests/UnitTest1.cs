namespace MyApp.Tests;

public class Test_MyApp
{

    public class Greet
    {
        [TestClass]
        public class WhenPassedAString
        {

            [TestMethod]
            public void ShouldIncludeTheStringInTheOutput()
            {
                var subject = new MyApp();
                var result = subject.Greet("Test");
                StringAssert.Contains(result, "Test");
            }
        }
    }
}