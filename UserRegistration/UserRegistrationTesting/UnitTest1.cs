using UserRegistration;
namespace UserRegistrationTesting
{
    [TestClass]
    public class UnitTest1
    {/// <summary>
     /// firstname Uc10
     /// </summary>
        [TestMethod]
        public void CheckGiven_FirstName_Validation()
        {
            Validation Code = new Validation();
            string input = "Snehal";
            string output = Code.TestName(input);
            Assert.AreEqual("First/last name matches", output);
        }
        /// <summary>
        /// last name uc10
        /// </summary>
        [TestMethod]
        public void CheckGiven_LastName_Validation()
        {
            Validation Code = new Validation();
            string input = "Bansod";
            string output = Code.TestName(input);
            Assert.AreEqual("First/last name matches", output);
        }
        /// <summary>
        /// email uc10
        /// </summary>
        [TestMethod]
        public void CheckGiven_Email_Validation()
        {
            Validation Code = new Validation();
            string input = "abc@xyzhg.com";
            string output = Code.TestEmail(input);
            Assert.AreEqual("Email  matches", output);
        }
        /// <summary>
        /// Phone numbr Uc10
        /// </summary>
        [TestMethod]
        public void CheckGiven_Phone_Validation()
        {
            Validation Code = new Validation();
            string input = "915335335353";
            string output = Code.TestMobile(input);
            Assert.AreEqual("Mobile number  matches", output);
        }
        /// <summary>
        /// Password Uc10
        /// </summary>
        [TestMethod]
        public void CheckGiven_Password_Validation()
        {
            Validation Code = new Validation();
            string input = "snehalnaeD4.";
            string output = Code.TestPassword(input);
            Assert.AreEqual("Password  matches", output);
        }
    }
}