﻿using ChainOfResponsibility;

ATM atm = new ATM();
Console.WriteLine("Requested Amount 4600");
atm.Withdraw(4600);
Console.WriteLine("\nRequested Amount 1900");
atm.Withdraw(1900);
Console.WriteLine("\nRequested Amount 600");
atm.Withdraw(600);
