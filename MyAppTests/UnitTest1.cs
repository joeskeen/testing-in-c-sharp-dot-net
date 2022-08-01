namespace MyApp.Tests;

[TestClass]
public class Test_MyApp
{
    public abstract class MyAppTest 
    {
        protected MyApp? _subject;

        [TestInitialize]
        public void SuiteInitialize() 
        {
            _subject = new MyApp();
        }
    }

    public class Greet
    {
        [TestClass]
        public class WhenPassedAString : MyAppTest
        {
            private string? _result;

            [TestInitialize]
            public void TestInitialize() 
            {
                // Act
                _result = _subject!.Greet("Test");
            }

            [TestMethod]
            public void ShouldIncludeTheStringInTheOutput()
            {
                // Assert
                StringAssert.Contains(_result, "Hello");
            }
        }
    }
}