using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_POM_model_skeleton.Pages.RegistrationPage
{
    public static class RegistrationPageAsserter
    {
        public static void AssesrtNoNameValidationMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.NoNameValidationMessage.Displayed);
        }

        public static void AssertHobbysRequieredValidationMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForHobbies.Displayed);
        }

        public static void AssertMinimumPhoneDigitsValidationMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForPhone.Displayed);
        }

        public static void AssertInvalidMailAddressValidationTest(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.InvalidMailValidationMessage.Displayed);
        }

        public static void AssertPassNotEnoughSymbolsValidationMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.PassNotEnoughSymbolsValidationMessage.Displayed);
        }

        public static void AssertPassDoNotMatchValidationMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.PassDoNotMatchValidationMessage.Displayed);
        }

        public static void AssertMailRequieredValidationMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForRequiredMail.Displayed);
        }

        public static void AssertPhoneRequieredValidationMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessagesForPhone.Displayed);
        }

        public static void AssertUsernameRequieredValidationMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForRequiredUsername.Displayed);
        }

        public static void AssertPasswordRequieredValidationMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForRequiredPassword.Displayed);
        }

        public static void AssertConfirmPasswordRequieredValidationMessage(this RegistrationPage page, string text)
        {
            Assert.IsTrue(page.ErrorMessageForRequiredConfirmPassword.Displayed);
        }
    }
}