
using AugustTest2022.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// open chrome browser
IWebDriver driver = new ChromeDriver();

// Login page object initialization and definition
LogInPage LoginPageObj = new LogInPage();
LoginPageObj.logInSteps(driver);

//Home page object initialization and definition
HomePage HomePageObj = new HomePage();
HomePageObj.GoToHomePage(driver);

//Time And Material 
TMPage TMPageObj = new TMPage();
TMPageObj.CreateTM(driver);

//Edit TM
TMPageObj.EditTM(driver);

//Delete TM
TMPageObj.DeleteTM(driver);