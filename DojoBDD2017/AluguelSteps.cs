using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using OpenQA.Selenium.Interactions;

namespace DojoBDD2017
{
    [Binding]
    public class AluguelSteps
    {
        public IWebDriver webdriver; 

        [BeforeScenario]
        public void Initialize()
        {
            webdriver = new ChromeDriver();
        }

        [AfterScenario]
        public void CleanUp()
        {
            webdriver.Close();
            webdriver.Dispose();
        }

        [Given(@"que esteja na página inicial")]
        public void DadoQueEstejaNaPaginaInicial()
        {

            webdriver.Navigate().GoToUrl("http://webportal.nowonline.com.br");
                       
        }
     
        [Given(@"Fechado o Walkthrough")]
        public void DadoFechadoOWalkthrough()
        {
            WebDriverWait wait = new WebDriverWait(webdriver, new TimeSpan(0, 0, 5));
            var closeModalButton = wait.Until<IWebElement>(ExpectedConditions.ElementIsVisible(By.ClassName("btn-close-modal")));
            closeModalButton.Click();

        }
        
        [Given(@"Login efetuado")]
        public void DadoLoginEfetuado()
        {
            WebDriverWait wait = new WebDriverWait(webdriver, new TimeSpan(0, 0, 5));
            
            string currentHandle = webdriver.CurrentWindowHandle;
            ReadOnlyCollection<string> originalHandles = webdriver.WindowHandles;

            var buttonLogin = wait.Until<IWebElement>(ExpectedConditions.ElementIsVisible(By.ClassName("btn-login")));            

            PopupWindowFinder finder = new PopupWindowFinder(webdriver);
            string popupWindowHandle = finder.Click(buttonLogin);
           
         
            webdriver.SwitchTo().Window(popupWindowHandle);

            var inputPassword = wait.Until<IWebElement>(ExpectedConditions.ElementIsVisible(By.Name("passwordHint")));
            inputPassword.Click();

            var password = webdriver.FindElement(By.Id("password"));
            password.SendKeys("nowmulti1");


            var inputUserName = wait.Until<IWebElement>(ExpectedConditions.ElementIsVisible(By.Name("username")));
            inputUserName.SendKeys("nowmultiscreen1");
            
            webdriver.FindElement(By.Name("_submit")).Click();

            webdriver.SwitchTo().Window(currentHandle);                                  
        }
        
        [Given(@"Filme pesquisado")]
        public void DadoFilmePesquisado()
        {
            Thread.Sleep(3000);
            IWebElement poster = webdriver.FindElement(By.ClassName("carousel-item"));
            Actions mouseover = new Actions(webdriver);
            mouseover.MoveToElement(poster).Perform();
            Thread.Sleep(5000);
            IWebElement detalhes = webdriver.FindElement(By.XPath("//*[@href='/filme/meus-15-anos-pre-lancamento/92200']"));
            Thread.Sleep(3000);
        }
        
        [Given(@"Filme selecionado")]
        public void DadoFilmeSelecionado()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Clicado no botão alugar da modal")]
        public void QuandoClicadoNoBotaoAlugarDaModal()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Pin inserido corretamente")]
        public void QuandoPinInseridoCorretamente()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Clicar no botão de confirmação")]
        public void QuandoClicarNoBotaoDeConfirmacao()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Pin inserido incorretamente")]
        public void QuandoPinInseridoIncorretamente()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Usuário é encaminhado à tela de reprodução\.")]
        public void EntaoUsuarioEEncaminhadoATelaDeReproducao_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Exibe mensagem de PIN inválido ""(.*)""")]
        public void EntaoExibeMensagemDePINInvalido(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
