// See https://aka.ms/new-console-template for more information

using Transaction;
using Services;
using Investment;
using System;
using Accounting;


FD myFD = new FD();
string result = myFD.WhoAmI();

Console.WriteLine(result);