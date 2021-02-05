using Microsoft.VisualStudio.TestTools.UnitTesting;
using MishellLogica;
using System;
using TechTalk.SpecFlow;

namespace MishellWeb.Features
{
    [Binding]
    public class ProfesionSteps
    {
        Logica logica = new Logica();
        [Given(@"que el nombre es ""(.*)""")]
        public void DadoQueElNombreEs(string nombre)
        {
            logica.Nombre = nombre;
        }
        
        [Given(@"su apellido es ""(.*)""")]
        public void DadoSuApellidoEs(string apellido)
        {
            logica.Apellido = apellido;
        }
        
        [Given(@"que la profesion es ""(.*)""")]
        public void DadoQueLaProfesionEs(string profesion)
        {
            logica.Profesion = profesion;
        }
        
        [Given(@"la seccion a la pertence es ""(.*)""")]
        public void DadoLaSeccionALaPertenceEs(string grupo)
        {
            logica.Grupo = grupo;
        }
        
        [When(@"los datos son")]
        public void CuandoLosDatosSon()
        {
            logica.Datos();
        }
        
        [When(@"sus datos de profesion son")]
        public void CuandoSusDatosDeProfesionSon()
        {
            logica.DatosProfesion();
        }
        
        [Then(@"el resultado debe sera ""(.*)""")]
        public void EntoncesElResultadoDebeSera(string esperado)
        {
            Assert.AreEqual(esperado, logica.Resultado); ;

        }

        [Then(@"el resultado es ""(.*)""")]
        public void EntoncesElResultadoEs(string esperado)
        {
            Assert.AreEqual(esperado, logica.Resultado); ;

        }
    }
}
