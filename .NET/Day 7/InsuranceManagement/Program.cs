// See https://aka.ms/new-console-template for more information
using InsuranceManagement;
Console.WriteLine("Hello, World!");

HealthInsurance hInsr = new HealthInsurance(22,800000);

Console.WriteLine($"Pay to Insurance Company: {hInsr.CalculateRenewalPremium(22,800000)}");


