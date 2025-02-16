﻿namespace AtmServices;

public class atm
{
    public int balance;
    public atm(int InitialBalance){
        this.balance = InitialBalance;
    }
    public bool withdraw(int amount){
        if(amount < balance){
            this.balance -= amount;
            return true;
        }
        return false;
    }
    public bool deposit(int amount){
        if(amount < 0){
            return false;
        }
        balance += amount;
        return true;
    }
    public int GetBalance(){
        return balance;
    }
}
