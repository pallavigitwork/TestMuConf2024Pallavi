from selenium import webdriver
from selenium.webdriver.common.by import By

driver = webdriver.Chrome()
driver.get("http://www.5elementslearning.dev/demosite")
myAcclnk = driver.find_element(by=By.LINK_TEXT, value="My Account")
myAcclnk.click
driver.quit()