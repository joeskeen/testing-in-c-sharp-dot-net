namespace MyApp.Tests;

public class Test_PizzaShop
{
    public abstract class PizzaShopTests
    {
        public PizzaShop? _subject;
        public Pizza? _result;

        [TestInitialize]
        public void ConstructPizzaShop()
        {
            _subject = new PizzaShop();
        }
    }

    public class GetPizza
    {
        public class Classic
        {
            [TestClass]
            public class WhenYouOrderPepperoni : PizzaShopTests
            {
                [TestInitialize]
                public void OrderPepperoni()
                {
                    _result = _subject!.GetPizza("Classic Pepperoni");
                }

                [TestMethod]
                public void ShouldNotBeNull()
                {
                    Assert.AreNotEqual(null, _result);
                }

                [TestMethod]
                public void ShouldHavePepperoni()
                {
                    CollectionAssert.Contains(_result!.Toppings, "pepperoni");
                }

                [TestMethod]
                public void ShouldHaveCheese()
                {
                    CollectionAssert.Contains(_result!.Toppings, "cheese");
                }

            }
        
            [TestClass]
            public class WhenYouOrderAnInvalidClassic : PizzaShopTests
            {
                private Action? _action;

                [TestInitialize]
                public void OrderTony()
                {
                    _action = () => 
                    {
                        _subject!.GetPizza("Tony's Special");
                    };
                }

                [TestMethod]
                public void ShouldThrowError()
                {
                    Assert.ThrowsException<ArgumentException>(_action);
                }
            }
        
        }

        [TestClass]
        public class Custom : PizzaShopTests
        {

        }
    }
}