namespace MyApp.Tests;

public class Test_MyApp
{

    public class Greet
    {
        [TestClass]
        public class WhenPassedAString
        {
            private MyApp? _subject;
            private string? _result;

            [TestInitialize()]
            public void TestInitialize()
            {
                _subject = new MyApp();
                _result = _subject.Greet("Test");
            }

            [TestMethod]
            public void ShouldIncludeTheStringInTheOutput()
            {
                StringAssert.Contains(_result, "Test");
            }
        }
    }
}