from selenium import webdriver
from selenium.webdriver.common.keys import Keys
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
import unittest
import time

PATH = "C:\Program Files (x86)\chromedriver.exe"

def search_test_func(data,driver):
    search = driver.find_element_by_id("searchData")

    search.send_keys(data)
    search.send_keys(Keys.RETURN)

    try:
        main = WebDriverWait(driver,10).until(
            EC.presence_of_all_elements_located((By.CLASS_NAME,"products"))
        )
    except:
        driver.quit()



def sign_in(user,passw,driver):
    search = driver.find_element_by_id("username")

    search.send_keys(user)

    search = driver.find_element_by_id("password")
    search.send_keys(passw)
    search.send_keys(Keys.RETURN)


def user_edit(driver):
    text = driver.find_element_by_name("username")
    text.send_keys(Keys.LEFT_CONTROL + "a")
    text.send_keys(Keys.BACKSPACE)

    text.send_keys("data")

    text = driver.find_element_by_name("name")
    text.send_keys(Keys.LEFT_CONTROL + "a")
    text.send_keys(Keys.BACKSPACE)

    text.send_keys("can")

    text = driver.find_element_by_name("surname")
    text.send_keys(Keys.LEFT_CONTROL + "a")
    text.send_keys(Keys.BACKSPACE)

    text.send_keys("akkaya")

    text = driver.find_element_by_name("email")
    text.send_keys(Keys.LEFT_CONTROL + "a")
    text.send_keys(Keys.BACKSPACE)

    text.send_keys("akkaya.azizcan98@gmail.com")

    text = driver.find_element_by_name("phoneNumber")
    text.send_keys(Keys.LEFT_CONTROL + "a")
    text.send_keys(Keys.BACKSPACE)

    text.send_keys("12315468")

    text = driver.find_element_by_name("address")
    text.send_keys(Keys.LEFT_CONTROL + "a")
    text.send_keys(Keys.BACKSPACE)

    text.send_keys("sancaktepe")

    text = driver.find_element_by_id("newPassword")
    text.send_keys(Keys.LEFT_CONTROL + "a")
    text.send_keys(Keys.BACKSPACE)

    text.send_keys("123")

    text = driver.find_element_by_id("newPassword2")
    text.send_keys(Keys.LEFT_CONTROL + "a")
    text.send_keys(Keys.BACKSPACE)

    text.send_keys("123")

    text = driver.find_element_by_id("oldPassword")
    text.send_keys(Keys.LEFT_CONTROL + "a")
    text.send_keys(Keys.BACKSPACE)

    text.send_keys("123")

    driver.find_element_by_id("submit").click()


class Bookie(unittest.TestCase):
    def setUp(self):
        self.driver = webdriver.Chrome(PATH)
        self.driver.get("https://localhost:44361")

    def test_title(self):
        return "Bookie" and self.driver.title

    def test_search_1(self):
        search_test_func("",self.driver)
    
    def test_search_2(self):
        search_test_func("Olasılıksız",self.driver)

    def test_search_3(self):
        search_test_func("Metro",self.driver)

    def test_search_4(self):
        search_test_func("Düşerken",self.driver)

    def test_search_5(self):
        search_test_func("Sherlock Holmes",self.driver)

    def test_user_1(self):
        self.driver.find_element_by_link_text("Sign In").click()
        sign_in("Muratyldz","123",self.driver)
    
    def test_user_2(self):
        self.driver.find_element_by_link_text("Sign In").click()
        sign_in("BerkPgz","456",self.driver)

    def test_user_3(self):
        self.driver.find_element_by_link_text("Sign In").click()
        sign_in("abdcelik","789",self.driver)

    def test_user_nav(self):
        self.driver.find_element_by_link_text("Sign In").click()
        time.sleep(3)

        sign_in("Muratyldz","123",self.driver)
        time.sleep(1)

        self.driver.find_element_by_link_text("Profile").click()
        time.sleep(1)
        
        self.driver.find_element_by_link_text("My sales").click()
        time.sleep(1)

        self.driver.find_element_by_link_text("My orders").click()
        time.sleep(1)

        self.driver.find_element_by_link_text("My solds").click()
        time.sleep(1)
        
        self.driver.find_element_by_link_text("Sign out").click()
        

    def test_user_edit(self):
        self.driver.find_element_by_link_text("Sign In").click()
        time.sleep(1)

        sign_in("Muratyldz","123",self.driver)
        time.sleep(2)
        
        self.driver.find_element_by_link_text("Profile").click()
        user_edit(self.driver)

    def tearDown(self):
        self.driver.close()


if __name__ == "__main__":
	unittest.main()