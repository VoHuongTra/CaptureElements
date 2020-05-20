using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Google.Account
{
    public class PagePersonalInfo :BaseElement
    {
        public PagePersonalInfoStates? PagePersonalInfoState { get; set; }
        // Photo Section
        public Button ChangePhotoBtn { get; set; }
        public Button IframeBtn { get; set; }
        public Button TopLeftPoint { get; set; }
        public Button BottomRightPoint { get; set; }
        public Button SetProfilePhoto { get; set; }
        public string ChangePhotoErrorNotification { get; set; }
        // Name Section
        public Button ChangeNameBtn { get; set; }
        public string CurrentName { get; set; }
        public Button AddNameBtn { get; set; }
        public Button EditNameBtn { get; set; }
        public TextBox FirstNameTxt { get; set; }
        public TextBox LastNameTxt { get; set; }
        public Button ChangeNameDoneBtn { get; set; }
        public string ChangeNameErrorNotification { get; set; }
        // Birthday Section
        public Button ChangeBirthdayBtn { get; set; }
        public string CurrentBirthday { get; set; }
        public Button AddBirthdayBtn { get; set; }
        public Button EditBirthdayBtn { get; set; }
        public Button MonthBtn { get; set; }
        public MonthDropdown MonthDropdown { get; set; }
        public TextBox DayTxt { get; set; }
        public TextBox YearTxt { get; set; }
        public Button UpdateBirthdayBtn { get; set; }
        public string ChangeBirthdayErrorNotification { get; set; }
        // Gender Section 
        public Button ChangeGenderBtn { get; set; }
        public Genders? CurrentGender { get; set; }
        public Button FemaleBtn { get; set; }
        public Button MaleBtn { get; set; }
        public Button RathernotsayBtn { get; set; }
        public Button OnlyYouBtn { get; set; }
        public Button AnyoneBtn { get; set; }
        public string ChangeGenderErrorNotification { get; set; }
        // Password Section
        public Button ChangePasswordBtn { get; set; }
        public TextBox NewPasswordTxt { get; set; }
        public TextBox ConfirmNewPasswordTxt { get; set; }
        public Button ConfirmChangePasswordBtn { get; set; }
        public Button ShowPasswordAboveBtn { get; set; }
        public Button ShowPasswordUnderBtn { get; set; }
        public string ChangePasswordErrorNotification { get; set; }
        // Back to Main Button
        public Button BackToMainBtn { get; set; }
    }

    public class MonthDropdown
    {
        public List<Button> Months { get; set; }
    }
    public enum PagePersonalInfoStates
    {
        Identifier,
        MainPersonalInfo,
        PhotoChanging,
        NameChanging,
        BirthdayChanging,
        GenderChanging,
        PasswordChanging
    }
    public enum Genders
    {
        Female,
        Male,
        Rathernotsay
    }
}
