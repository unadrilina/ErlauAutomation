
using TechTalk.SpecFlow;
using BoDi;
using Una_bakalaurs.Utils;

namespace Una_bakalaurs
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer _objectContainer;
        private Driver _driver;

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = new Driver();

            _driver.Navigate(Constants.HomeURL);
            _driver.MaximizeWindow();
            _driver.SetTimeout(Constants.Timeout);
            _objectContainer.RegisterInstanceAs<Driver>(_driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.CloseWebDriver();
        }
    }
}
