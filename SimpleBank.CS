using System;

public class BankAccount
{
  private string name;
  private decimal balance;

  public BankAccount(string name, decimal initialBalance)
  {
    this.name = name;
    this.balance = initialBalance;
  }

  public void Deposit(decimal amount)
  {
    if (amount > 0)
    {
      balance += amount;
      Console.WriteLine("Deposit of {amount:C} successful. New balance: {balance:C}");
    }
    else
    {
      Console.WriteLine("Deposit amount must be positive.");
    }
  }

  public void Withdraw(decimal amount)
  {
    if (amount > 0 && amount <= balance)
    {
      balance -= amount;
      Console.WriteLine("Withdrawal of {amount:C} successful. New balance: {balance:C}");
    }
    else if (amount <= 0)
    {
      Console.WriteLine("Withdrawal amount must be positive.");
    }
    else
    {
      Console.WriteLine("Insufficient funds.");
    }
  }

  public void ShowBalance()
  {
    Console.WriteLine("Balance: {balance:C}");
  }
}
/
public class SimpleBank
{
  public static void Main(string[] args)
  {
    string name;
    decimal initialBalance, amount;
    int choice;

    Console.WriteLine("Welcome to Simple Bank!");

    Console.Write("Enter your name: ");
    name = Console.ReadLine();

    Console.Write("Enter initial balance: ");
    initialBalance = decimal.Parse(Console.ReadLine());

    BankAccount account = new BankAccount(name, initialBalance);

    do
    {
      Console.WriteLine("\nMenu:");
      Console.WriteLine("1. Deposit");
      Console.WriteLine("2. Withdraw");
      Console.WriteLine("3. Show Balance");
      Console.WriteLine("4. Exit");
      Console.Write("Enter your choice: ");
      choice = int.Parse(Console.ReadLine());

      switch (choice)
      {
        case 1:
          Console.Write("Enter amount to deposit: ");
          amount = decimal.Parse(Console.ReadLine());
          account.Deposit(amount);
          break;
        case 2:
          Console.Write("Enter amount to withdraw: ");
          amount = decimal.Parse(Console.ReadLine());
          account.Withdraw(amount);
          break;
        case 3:
          account.ShowBalance();
          break;
        case 4:
          Console.WriteLine("Thank you for using Simple Bank!");
          break;
        default:
          Console.WriteLine("Invalid choice.");
          break;
      }
    } while (choice != 4);
  }
}