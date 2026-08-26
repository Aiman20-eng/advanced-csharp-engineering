using System.Collections.Generic;

namespace AccountingRecursionApp.Models
{
    public class Account
    {
        public int AccountId { get; set; }
        public string AccountName { get; set; }

        // الرصيد الفعلي (يكون له قيمة فقط إذا كان حساب حركة/نهائي)
        public decimal BaseBalance { get; set; }

        public List<Account> SubAccounts { get; set; }

        public Account(int id, string name, decimal baseBalance = 0)
        {
            AccountId = id;
            AccountName = name;
            BaseBalance = baseBalance;
            SubAccounts = new List<Account>();
        }

        // دالة مساعدة لإضافة حسابات فرعية
        public void AddSubAccount(Account account)
        {
            SubAccounts.Add(account);
        }
    }
}