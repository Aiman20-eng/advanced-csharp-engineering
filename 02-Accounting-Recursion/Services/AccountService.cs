using System.Linq;
using AccountingRecursionApp.Models;

namespace AccountingRecursionApp.Services
{
    public class AccountService
    {
         /// دالة عودية (Recursive) لحساب إجمالي رصيد أي حساب محاسبي
         public decimal CalculateTotalBalance(Account account)
        {
             if (account.SubAccounts == null || account.SubAccounts.Count == 0)
            {
                return account.BaseBalance;
            }

            decimal totalBalance = account.BaseBalance; // نضيف رصيد الحساب نفسه إن وُجد

            foreach (var subAcc in account.SubAccounts)
            {
                 totalBalance += CalculateTotalBalance(subAcc);
            }


            return totalBalance;
        }
    }
}