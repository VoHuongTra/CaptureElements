using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Google.Account
{
    public class PageSercurity :BaseElement
    {
        public PageSecutiryStates? PageSecutiryState { get; set; }
        public Identifier Identifier { get; set; }
        // Recovery Phone
        public string CurrentPhone { get; set; }
        public Button RecoveryPhoneBtn { get; set; }
        public Button AddRecoveryPhoneBtn { get; set; }
        public Button EditRecoveryPhoneBtn { get; set; }
        public Button RemoveRecoveryPhoneBtn { get; set; }
        public AddPhoneNumberDropdown AddPhoneNumberDropdown { get; set; }
        //Recovery Mail
        public string currentRecoveryEmail { get; set; }
        public Button RecoveryEmailBtn { get; set; }
        public Button AddRecoveryMailBtn { get; set; }
        public Button EditRecoveryMailBtn { get; set; }
        public TextBox MailTxt { get; set; }
        // Common CancelBtn and DoneBtn for email and phone
        public Button CancelBtn { get; set; }
        public Button DoneBtn { get; set; }
        //SecurityQuestion
        public Button SecurityQuestionBtn { get; set; }
        //Back
        public Button BackBtn { get; set; }
    }

    public enum PageSecutiryStates
    {
        Identifier,
        MainSecurity,
        RecoveryPhone,
        RecoveryEmail,
    }

    public class AddPhoneNumberDropdown : BaseElement
    {
        public TextBox NumberTxt { get; set; }
        public string CurrentCountryCode { get; set; }
        public CountryCodeDropdown CountryCodeDropdown { get; set; }
        public string VerifiedNumber { get; set; }
        public TextBox CodeTxt { get; set; }
        public Button GetCodeBtn { get; set; }
        public Button VerifyBtn { get; set; }
        public Button CancelBtn { get; set; }
        public Button UpdateBtn { get; set; }
        public Button NextBtn { get; set; }
    }

    public class CountryCodeDropdown : BaseElement
    {
        public List<Button> CountryCodes { get; set; }
    }

}
