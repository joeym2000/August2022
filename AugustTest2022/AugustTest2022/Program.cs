
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// open chrome browser
IWebDriver driver = new ChromeDriver();

// launch turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
driver.Manage().Window.Maximize();

// identify username and enter valid username
IWebElement userNameTextBox = driver.FindElement(By.Id("UserName"));
userNameTextBox.SendKeys("Hari");

// identify passsword and enter valid password
IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
passwordTextBox.SendKeys("123123");

//identify log in button and click on it
IWebElement logInButton = driver.FindElement(By.XPath("//*[@id=\'loginForm\']/form/div[3]/input[1]"));
logInButton.Click();

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

//Create new time and material
IWebElement administrationButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationButton.Click();
Thread.Sleep(2000);

// Click on time and material text
IWebElement timeAndMaterialText = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
timeAndMaterialText.Click();

//click on create new
IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\'container\']/p/a"));
createNewButton.Click();

//Click on the drop down button and select time 
IWebElement dropDownButton = driver.FindElement(By.XPath("//*[@id=\'TimeMaterialEditForm\']/div/div[1]/div/span[1]/span/span[2]"));
dropDownButton.Click();
Thread.Sleep(1000);
IWebElement timeText = driver.FindElement(By.XPath("//*[@id=\'TypeCode_listbox\']/li[2]"));
timeText.Click();

//input code
IWebElement newCode = driver.FindElement(By.Id("Code"));
newCode.SendKeys("Marcos");
Thread.Sleep(2000);

//input description
IWebElement newDescription = driver.FindElement(By.Id("Description"));
newDescription.SendKeys("Magnanakaw");

//input price
IWebElement newPricePerUnit = driver.FindElement(By.XPath("//*[@id=\'TimeMaterialEditForm\']/div/div[4]/div/span[1]/span/input[1]"));
newPricePerUnit.SendKeys("203");

//Save time and material
IWebElement saveTimeAndMaterial = driver.FindElement(By.Id("SaveButton"));
saveTimeAndMaterial.Click();
Thread.Sleep(1000);

//check if record is created successfully
IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[4]/a[4]"));
lastPageButton.Click();
IWebElement newCodeName = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[3]/table/tbody/tr[last()]/td[1]"));;

if (newCodeName.Text == "Marcos")
{
    Console.WriteLine("Record Successfully Created");
}
else
{
    Console.WriteLine("Can't Find Record");
}
