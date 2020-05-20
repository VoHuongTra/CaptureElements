using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Google.Account
{
   public class PageDataAndPersonalization : BaseElement
    {
        public PageDataAndPersonalizationStates? PageDataAndPersonalizationState { get; set; }
        //Language Section
        public Button ChangeLanguageBtn { get; set; }
        public Button DefaultLanguageEditBtn { get; set; }
        public string DefaultLanguageName { get; set; }
        public LanguagesDropdown LanguagesDropdown { get; set; }
        public List<OtherLanguage> OtherLanguages { get; set; }
        public Button AddAnotherLanguageBtn { get; set; }
        // Back to Main Btn
        public Button BackToMainBtn { get; set; }
    }

    public class OtherLanguage
    {
        public string LanguageName { get; set; }
        public Button UpBtn { get; set; }
        public Button DeleteBtn { get; set; }
    }

    public class LanguagesDropdown : BaseElement
    {
        public TextBox SearchBoxTxt { get; set; }
        public List<Button> Languages { get; set; }
        public Button CancelBtn { get; set; }
        public Button SelectBtn { get; set; }
    }

    public enum PageDataAndPersonalizationStates
    {
        Identifier,
        MainDataAndPersonalization,
        LanguageChanging
    }
}
