using CaptureElements.Models.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaptureElements.Models.Google.Search
{
   public class AccountPanel : BaseElement
    {
        public string AccountName { get; set; }
        public string AccountEmail { get; set; }
        public Button ManageAccountBtn { get; set; }
        public Button LogoutBtn { get; set; }
        public Button AddNewAccoutBtn { get; set; }
        public List<Account> GoogleAccounts { get; set; }

    }
    public class Account : BaseElement
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public bool HasPopup { get; set; }
        public Button LoginBtn { get; set; }
        public Button Cancel { get; set; }
    }
   
}
