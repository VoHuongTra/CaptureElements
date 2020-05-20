using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Google.Account
{
    public class Identifier : BaseElement
    {
        public IdentifierStates? IdentifierState { get; set; }
        // Chooser
        public List<Button> ExistEmails { get; set; }
        public Button UseAnotherAccountBtn { get; set; }
        public Button DeleteAccountBtn { get; set; }
        public TextBox EmailOrNumberTxt { get; set; }
        public TextBox PasswordTxt { get; set; }
        public Button RecoveryEmailBtn { get; set; }
        public TextBox EmailRecoveryTxt { get; set; }
        public Button ForgotEmailBtn { get; set; }
        public Button CreatNewAccountBtn { get; set; }
        public Button ChangeLanguageBtn { get; set; }
        public TextBox CapchaTxt { get; set; }
        public string WarningMessage { get; set; }
        public Button NextBtn { get; set; }
        public Button ProtectionConfirmBtn { get; set; }
        public Button ShowPasswordBtn { get; set; }
        // Verify Identity Section
        public Button CountryBtn { get; set; }
        public CountryDropdown CountryDropdown { get; set; }
        public TextBox PhoneNumberTxt { get; set; }
        public Button TextMessageBtn { get; set; }
        public Button VoiceMessageBtn { get; set; }
        public Button GetCodeBtn { get; set; }
        public TextBox VerificationCodeTxt { get; set; }
        public Button VerificationBtn { get; set; }
        public bool? LivingState { get; set; }
    }

    public class CountryDropdown : BaseElement
    {
        List<Button> Countries { get; set; }
    }

    public enum IdentifierStates
    {
        Chooser,
        Username,
        Password,
        VerifyIdentity,
        EmailRecovery,
        ProtectionConfirm,
        Died
    };
}
