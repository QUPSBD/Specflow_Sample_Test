using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specflow_demo_bikroy.Utils
{
    public class Locators
    {
        public static String url = "https://bikroy.com/";
        public static int timeDelay = 2000;
        //Locators for login
        public static String signInXpath = "//*[@id='app-wrapper']/div[2]/div[2]/div/nav/div/ul[2]/li[2]/div/a";
        public static String continueWithEmailXpath = "/html/body/div[3]/div/div/div/div[2]/div[2]/div/div[3]/button";
        public static String emailId = "input_email";
        public static String passwordId = "input_password";
        public static String loginXpath = "/html/body/div[3]/div/div/div/div[2]/div[2]/div/form/div[2]/div/button";

        //login credential
        public static String email = "ashiq10@gmail.com";
        public static String password = "123456789As@";

        //homepage
        public static String homepageClass = "/html/body/nav/div/div/a";

        //MyAccount
        public static String myaccountJobsXpath = "/html/body/nav/div/ul[3]/li[3]/a";
        public static By accountTxt = By.XPath("/html/body/div[2]/div/div/div/div/div[1]/h4");
        public static String myAccountXpath = "//*[@id='app-wrapper']/div[2]/div[2]/div/nav/div/ul[2]/li[2]/div/a";
        public static String accountXpath = "/html/body/div[2]/div/div/div/div/div[1]/h4";
        public static String accountText = "Account";
        public static String myMembershipXpath = "/html/body/div[2]/div/div/div/div/div[1]/nav/ul/li[2]/a";
        public static By myMembershipValidateXpath = By.XPath("//*[@id='my-content']/h2");
        public static String myMembershipText = "My Membership";
        public static String favoritesXpath = "/html/body/div[2]/div/div/div/div/div[1]/nav/ul/li[3]/a";
        public static By favoritesvalidateXpath = By.XPath("//*[@id='my-content']/h2");
        public static String favoritesText = "Favorites";
        public static String settingXpath = "/html/body/div[2]/div/div/div/div/div[1]/nav/ul/li[4]/a";
        public static By settingValidateXpath = By.XPath("//h2[contains(text(),'Settings')]");
        public static String settingText = "Settings";
        public static String jobsvalidateXpath = "/html/body/div[2]/div/div/div/div/div[1]/nav/ul/div/h4";
        public static String jobsText = "Jobs";
        public static String myProfileXpath = "/html/body/div[2]/div/div/div/div/div[1]/nav/ul/li[5]/a";
        public static By myProfileValidateXPath = By.XPath("//*[@id='my-content']/div[1]/div[1]/h1");
        public static String myProfileText = "My Profile";
        public static String profileDatabaseXpath = "/html/body/div[2]/div/div/div/div/div[1]/nav/ul/li[6]/a";
        public static By profileDatabaseValidateXpath = By.XPath("//*[@id='app-container']/div/div/div/div[1]/div/div[1]/h2");
        public static String profileDatabaseText = "Profile database";
        public static String myAccountXPath = "/html/body/div[1]/div/div[1]/li[1]/a[2]";

        //chat
        public static String chatClass = "title--1NHWk gtm-chat-click";

        //SignUp paths
        public static String registerClass = "btn--1gFez tertiary--5kHib small--1MQ15";
        public static String nameId = "input_name";
        public static String confirmPasswordId = "input_password-confirm";
        public static String signUpClass = "btn--1gFez secondary--Os-e9 background--2lR9B small--1MQ15 gtm-email-signup";

        //signUp crediantial
        public static String name = "Ashiq";
        public static String newEmail = "ashiq2811@gmail.com";

        //Post a Add
        public static String postYourAddXpath = "//*[@id='app-wrapper']/div[2]/div[2]/div/nav/div/ul[2]/li[3]/a";
        public static String lookForSomethingToBuyXpath = "//*[@id='app-wrapper']/div[1]/div[3]/div[2]/div[2]/div[3]/ul/li[2]/button";
        public static By laptopXpath = By.XPath("/html/body/div[4]/div/div/div/div[2]/div/div[2]/div/ul/li[2]/button");
        public static By electronicsXpath = By.XPath("/html/body/div[4]/div/div/div/div[2]/div/div/div/ul/li[3]/button");
        public static By rajshahiXpath = By.XPath("/html/body/div[4]/div/div/div/div[2]/div/div/div/div[1]/div/ul/li[6]/button");
        public static By uposohorXpath = By.XPath("/html/body/div[4]/div/div/div/div[2]/div/div[2]/div/div[2]/ul/li[3]/button");
        public static By titleId = By.Id("input_title");
        public static String titleText = "acer";
        public static By descripTionXpath = By.XPath("//*[@id='app-wrapper']/div[1]/div[3]/div[5]/form/div[1]/div[2]/div/div[1]/textarea");
        public static String descriptionText = "This is a brand new laptop with 8 gb ram";
        public static By phoneNumberClass = By.XPath("//*[@id='input_3']");
        public static String phoneNumber = "01789456521";
        public static By addNumberClass = By.XPath("//button[contains(text(),'Add')]");
        public static By checkBoxAccept = By.Id("checkbox_id_0");
        public static By acceptId = By.Id("checkbox_id_1");

        public static By sellItemXpath = By.XPath("//*[@id='app-wrapper']/div[1]/div[3]/div[2]/div[2]/div[1]/ul/li[1]/button");
        public static By postAJob = By.XPath("//*[@id='app-wrapper']/div[1]/div[3]/div[2]/div[2]/div[2]/ul/li[1]/button");
        public static By usedXpath = By.XPath("//*[@id='app-wrapper']/div[1]/div[3]/div[5]/form/div[1]/div[1]/div/div[2]/div");
        public static By brandXpath = By.XPath("//*[@id='app-wrapper']/div[1]/div[3]/div[5]/form/div[1]/div[2]/div/div[1]/button");
        public static By modelId = By.Id("input_model");
        public static By priceId = By.Id("input_price");
        public static By negotiableId = By.Id("negotiable");

        //Search
        public static String searchBoxClass = "search-input--PtfH8";
        public static String searchBtnClass = "btn--1gFez default--T8kE3 small--1MQ15 search-button--1_VmY gtm-home-search-click";
        public static String searchText = "Mobile";
        public static String searchPageClass = "heading--2eONR undefined ad-list-header--3g7Pb block--3v-Ow";
        public static String searchAssertText = "Mobile in Bangladesh";

        //Categories
        public static String categoriesClass = "link--1t8hM gtm-home-category-link-click";
        public static String categoriesValidateClass = "ellipsis--AX_lz";
        public static String mobile = "Mobiles";
        public static String electronics = "Electronics";
        public static String homeAndLiving = "Home & Living";
        public static String Vehicles = "Vehicles";
        public static String Property = "Property";
        public static String PetsAndAnimals = "Pets & Animals";
        public static String FashionAndBeauty = "Fashion & Beauty";
        public static String HobbiesSportsKids = "Hobbies, Sports & Kids";
        public static String BusinessIndustry = "Business & Industry";
        public static String Education = "Education";
        public static String Essentials = "Essentials";
        public static String Services = "Services";
        public static String OverseasJobs = "Overseas Jobs";
    }
}
