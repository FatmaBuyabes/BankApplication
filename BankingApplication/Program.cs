Console.WriteLine("Welcome to the Basic Banking Application");
Console.WriteLine("--------------------------------------");

Console.Write("Please enter your name: ");
string name = Console.ReadLine();

Console.Write("Enter your account number: ");
int accountNumber = int.Parse(Console.ReadLine());

Console.Write("Enter your initial deposit: ");
double initialBalance = double.Parse(Console.ReadLine());
double balance = initialBalance;

int choice;
do
{
    Console.WriteLine("\nMain Menu:");
    Console.WriteLine("1. Deposit");
    Console.WriteLine("2. Withdraw");
    Console.WriteLine("3. View Balance");
    Console.WriteLine("4. Exit");

    Console.Write("Please select an option: ");
    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Write("Enter deposit amount: ");
            double depositAmount = double.Parse(Console.ReadLine());
            balance += depositAmount;
            Console.WriteLine($"Deposited {depositAmount}. New balance: {balance}");
            break;
        case 2:
            Console.Write("Enter withdrawal amount: ");
            double withdrawalAmount = double.Parse(Console.ReadLine());
            if (withdrawalAmount <= balance)
            {
                balance -= withdrawalAmount;
                Console.WriteLine($"Withdrawn {withdrawalAmount}. New balance: {balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
            break;
        case 3:
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Your current balance is: {balance}");
            break;

           
        case 4:
            Console.WriteLine("Exiting...GoodBye");
            break;
        default:
            Console.WriteLine("Please try again.");
            break;
    }
} while (choice != 4);

 void Deposit(double amount)
{
    balance += amount;
}

 void Withdraw(double amount)
{
    if (amount <= balance)
    {
        balance -= amount;
    }
    else
    {
        Console.WriteLine("Insufficient funds.");
    }
}

 double GetBalance()
{
    return balance;
}

public class BankAccount
{
    private double balance;

    public BankAccount(double initialBalance)
    {
        balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }

    public double GetBalance()
    {
        return balance;
    }
}

