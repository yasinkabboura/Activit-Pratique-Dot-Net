﻿// See https://aka.ms/new-console-template for more information
using Service;
Console.WriteLine("Hello, World!");
AccountService accS = new AccountServiceImpl();
accS.AddNewAccount(1,"MAD",12000);
accS.AddNewAccount(2,"MAD",1000);
accS.AddNewAccount(3,"USD",-2000);
accS.AddNewAccount(4,"MAD",-3400);

List<Account> listAccounts = accS.GetAllAccounts();
foreach (Account acc in listAccounts) {
            Console.WriteLine(acc);
        }
Console.WriteLine("*************************************************");
List<Account> DebitedAccounts = accS.GetDebitedAccounts();
foreach (Account acc in DebitedAccounts) {
            Console.WriteLine(acc);
        }
Console.WriteLine("*************************************************");
Console.WriteLine(accS.GetBalanceAVG());





