package demoProject;
import org.openqa.selenium.*;
import org.openqa.selenium.chrome.*;
public class demoSelenium {

	public static void main(String[] args) {
		WebDriver driver = new ChromeDriver();
		driver.get("http://www.5elementslearning.dev/demosite");
		driver.findElement(By.linkText("My Account")).click();
		driver.quit();
	}

}
