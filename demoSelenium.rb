require 'selenium-webdriver'
driver = Selenium::WebDriver.for :chrome
driver.get('http://www.5elementslearning.dev/demosite')
myAcclnk = driver.find_element(:link_text, 'My Account')
myAcclnk.click
driver.quit
