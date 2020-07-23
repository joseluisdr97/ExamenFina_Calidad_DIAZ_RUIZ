using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace Final_DiazRuiz_Calidad_Test.PruebasSelenium
{
    [TestFixture]
    class Selenium
    {
        [Test]
        public void VerificarQueCreoCuenta()
        {
            IWebDriver navegador = new FirefoxDriver();

            navegador.Url = "http://localhost:51266/Cuenta/Index";

            navegador.FindElement(By.CssSelector("#btnCrear")).Click();
            navegador.FindElement(By.CssSelector("#txt1")).SendKeys("Luis");

            IWebElement element1 = navegador.FindElement(By.Id("txt2"));
            SelectElement selectElement1 = new SelectElement(element1);
            selectElement1.SelectByValue("Debito");

            navegador.FindElement(By.CssSelector("#txt3")).SendKeys("1300");

            navegador.FindElement(By.CssSelector("#btnGuardar")).Click();
            var buscarId = navegador.FindElement(By.CssSelector("#EstoyIndexCuenta"));

            Assert.IsNotNull(buscarId);
            navegador.Close();
        }
        [Test]
        public void VerificarQueNoCreoCuenta()
        {
            IWebDriver navegador = new FirefoxDriver();

            navegador.Url = "http://localhost:51266/Cuenta/Index";

            navegador.FindElement(By.CssSelector("#btnCrear")).Click();
            //navegador.FindElement(By.CssSelector("#txt1")).SendKeys("Jose");

            IWebElement element1 = navegador.FindElement(By.Id("txt2"));
            SelectElement selectElement1 = new SelectElement(element1);
            selectElement1.SelectByValue("Debito");

            navegador.FindElement(By.CssSelector("#txt3")).SendKeys("300");

            navegador.FindElement(By.CssSelector("#btnGuardar")).Click();
            var buscarId = navegador.FindElement(By.CssSelector("#EstoyCrearCuenta"));

            Assert.IsNotNull(buscarId);
            navegador.Close();
        }
    }
}
