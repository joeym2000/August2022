
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// open chrome browser
IWebDriver driver = new ChromeDriver();

// launch turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

// identify username and enter valid username
IWebElement userNameTextBox = driver.FindElement(By.Id("UserName"));
userNameTextBox.SendKeys("Hari");

// identify passsword and enter valid password
IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
passwordTextBox.SendKeys("123123");

//identify log in button and click on it
IWebElement logInButton = driver.FindElement(By.XPath("//*[@id=\'loginForm\']/form/div[3]/input[1]"));
logInButton.Click();
driver.Manage().Window.Maximize();

// check if logged in 
IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\'logoutForm\']/ul/li/a"));

if (hellohari.Text == "Hello hari!")
{
    Console.WriteLine("logged in successfully");
}
else
{
    Console.WriteLine("log in failed");
}

//click and administration text
IWebElement administrationButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationButton.Click();

// Click on time and material text
IWebElement timeAndMaterialText = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
timeAndMaterialText.Click();
