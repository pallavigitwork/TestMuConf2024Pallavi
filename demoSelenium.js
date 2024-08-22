const {By, Builder, Browser} = require('selenium-webdriver');
const assert = require("assert");

(async function firstTest() {
  let driver;
    driver = await new Builder().forBrowser(Browser.CHROME).build();
    await driver.get('http://www.5elementslearning.dev/demosite');
    let myAcclnk = await driver.findElement(By.linkText('My Account'));
    myAcclnk.click
    await driver.quit();
}())