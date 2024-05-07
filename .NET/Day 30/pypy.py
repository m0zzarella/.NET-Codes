'''
p = input("Enter principal amount:  ");
r = input("Enter interest rate: ");
t = input("Enter duration in years: ");

simple_interest = float(p)*float(r)*float(t)/100;

print("Simple Interest: " + str(simple_interest));
'''

import pandas as pd

myDataset = {'cars: ["BMW", "Audi", "Honda", "Mercedes" ]',
             }

myVar = pd.DataFrame(myDataset)
print(myVar);
