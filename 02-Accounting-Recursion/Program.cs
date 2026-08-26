using System;
using AccountingRecursionApp.Models;
using AccountingRecursionApp.Services;

namespace AccountingRecursionApp
{
	class Program
	{
		static void Main(string[] args)
		{
			// --- بناء دليل الحسابات (Chart of Accounts) ---

			// المستوى الأول: الحساب الرئيسي
			Account assets = new Account(1, "الأصول");

			// المستوى الثاني: حسابات متفرعة من الأصول
			Account currentAssets = new Account(11, "الأصول المتداولة");
			Account fixedAssets = new Account(12, "الأصول الثابتة");
			assets.AddSubAccount(currentAssets);
			assets.AddSubAccount(fixedAssets);

			// المستوى الثالث: حسابات متفرعة من الأصول المتداولة
			Account banks = new Account(111, "البنوك");
			Account cash = new Account(112, "الصناديق", 5000m); // حساب نهائي برصيد
			currentAssets.AddSubAccount(banks);
			currentAssets.AddSubAccount(cash);

			// المستوى الرابع: حسابات متفرعة من البنوك
			Account bankA = new Account(1111, "بنك الراجحي", 15000m); // حساب نهائي
			Account bankB = new Account(1112, "البنك الأهلي", 10000m); // حساب نهائي
			banks.AddSubAccount(bankA);
			banks.AddSubAccount(bankB);

			// حسابات متفرعة من الأصول الثابتة
			Account cars = new Account(121, "السيارات", 50000m); // حساب نهائي
			fixedAssets.AddSubAccount(cars);


			// --- تنفيذ الـ Recursion ---
			AccountService service = new AccountService();

			Console.WriteLine("=== نظام استعلام أرصدة الحسابات (Recursion) ===\n");

			Console.WriteLine($"رصيد {bankA.AccountName}: {service.CalculateTotalBalance(bankA)}"); // 15000
			Console.WriteLine($"رصيد {banks.AccountName}: {service.CalculateTotalBalance(banks)}"); // 25000 (15000 + 10000)
			Console.WriteLine($"رصيد {currentAssets.AccountName}: {service.CalculateTotalBalance(currentAssets)}"); // 30000 (25000 + 5000)
			Console.WriteLine($"\nإجمالي {assets.AccountName} في الشركة: {service.CalculateTotalBalance(assets)}"); // 80000 (30000 + 50000)

			Console.ReadLine();
		}
	}
}