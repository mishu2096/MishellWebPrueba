﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace MishellWeb.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        IWebDriver driver = new FirefoxDriver();

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("http://localhost:60016");
        }

        [Given("el nombre es (.*)")]
        public void DadoQueElNombreEs(string nombre)
        {
            driver.FindElement(By.Name("nombre")).SendKeys(nombre.ToString());
        }

        [Given("el apellido es (.*)")]
        public void DadoElApellidoEs(string apellido)
        {
            driver.FindElement(By.Name("apellido")).SendKeys(apellido.ToString());
        }

        [When("los datos son ")]
        public void CuandoLosDatosSon()
        {
            driver.FindElement(By.Name("datos")).Click();
        }

        [Then("el resultado debe ser  (.*)")]
        public void ThenTheResultShouldBe(string esperado)
        {
            var respuesta = driver.FindElement(By.Name("respuesta")).Text;
            Assert.AreEqual(esperado, respuesta);
        }

    }
}
