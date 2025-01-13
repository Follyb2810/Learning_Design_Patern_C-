using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design.src.OOP_PRINCIPLE.Encapsulation
{
    public class BankAccount
    {
        private decimal _balance;
        public BankAccount(decimal balance){
            // _balance = balance;
            Deposit(balance);
        }
        public decimal GetBalance(){
            return _balance;
        }
        public void Deposit(decimal amount){
            if(amount <= 0){
                throw new ArgumentException("deeposit amount must the greater than zero");
            }
            _balance += amount;
        }
        public void Withdraw(decimal amount){
            if(_balance <= 0){
                throw new ArgumentException($"Account Balance {_balance} is less than zero");
            }
            if(amount > _balance){
                throw new InvalidOperationException($"Inssuffiecient balance because amount {amount} is greater than balance {_balance} ");
            }
            _balance -=amount;
        }
    }
}