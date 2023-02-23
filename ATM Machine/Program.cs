using System;

class Program
{
    string? cardNumber, pinNumber, yesno, accountTransfer;
    int depositAmount, withdrawAmount, transferAmount, newBalance, activity;

    const string BOY_CARD_NO = "1234";
    const string BOY_PIN_NO = "Boy1234";
    const string GIRL_CARD_NO = "5678";
    const string GIRL_PIN_NO = "Girl5678";

    public static void Main(string[] args)
    {

        Program process = new Program();

        Console.WriteLine("\nWelcome To Nickolas Bank");

        process.startOver();

    }

    public void startOver()
    {

        Console.Write("\nPlease enter your card number: ");
        cardNumber = Console.ReadLine();

        string? cardOwner = cardNumber == BOY_CARD_NO ? "Boy" : cardNumber == GIRL_CARD_NO ? "Girl" : null;
        if (cardOwner is not null)
        {
            Console.Write($"\nThis card belongs to {cardOwner}\n\nPlease enter your pin number: ");
            pinNumber = Console.ReadLine();

            if (pinNumber == BOY_PIN_NO && cardNumber == BOY_CARD_NO || pinNumber == GIRL_PIN_NO && cardNumber == GIRL_CARD_NO)
            {
                selectActivity();
            }
            else
            {
                Console.WriteLine("\nWrong input. Please start over");
            }
        }
        else
        {
            Console.WriteLine("\nCard does not exist. Please try again");
        }
    }

    public void selectActivity()
    {

        Console.Write("\nPlease choose your activity\n\n1.\tDeposit\n2.\tWithdraw\n3.\tCheck\n4.\tTransfer\n5.\tHome\n\nMy activity is ..... ");
        activity = Convert.ToInt32(Console.ReadLine());

        switch (activity)
        {

            case 1:
                deposit();
                break;

            case 2:
                withraw();
                break;

            case 3:
                check();
                break;

            case 4:
                transfer();
                break;

            case 5:
                startOver();
                break;

            default:
                Console.WriteLine("\nYou entered the wrong input. Please try again");
                selectActivity();
                break;

        }

    }

    public void deposit()
    {

        Console.Write("\nHow much do you want to deposit? ");
        depositAmount = Convert.ToInt32(Console.ReadLine());

        newBalance = AddBalance(depositAmount, newBalance);
        Console.WriteLine($"\nYou have deposited RM {depositAmount} \n\n***********************************\n\nYour new balance is RM {newBalance} \n\n***********************************");

        IsContinue();
    }
    public void withraw()
    {
        Console.Write("\nHow much do you want to withdraw? ");
        withdrawAmount = Convert.ToInt32(Console.ReadLine());

        if (newBalance < withdrawAmount)
        {
            Console.WriteLine("\nBalance is not enough. Withdraw rejected");
        }
        else
        {
            newBalance = DeductBalance(newBalance, withdrawAmount);
            Console.WriteLine($"\nYou have withdrawed RM {withdrawAmount} \n\n***********************************\n\nYour new balance is RM {newBalance} \n\n***********************************");
        }

        IsContinue();

    }
    public void check()
    {

        Console.WriteLine($"\n\n***********************************\nYour current balance is RM {newBalance} \n\n***********************************");

        IsContinue();

    }
    public void transfer()
    {
        Console.Write("\n\nAccount number you want to transfer to: ");
        accountTransfer = Console.ReadLine();

        Console.Write("\nHow much do you want to transfer? ");
        transferAmount = Convert.ToInt32(Console.ReadLine());

        if (newBalance < transferAmount)
        {
            Console.WriteLine("\nBalance is not enough. Transfer rejected");
        }
        else
        {
            newBalance = DeductBalance(newBalance, transferAmount);

            Console.WriteLine($"\nYou have transferred RM {transferAmount} to {accountTransfer} \n\n***********************************\n\nYour new balance is RM {newBalance} \n\n***********************************");
        }

        IsContinue();

    }

    public void IsContinue()
    {
        Console.Write("\nDo you want to continue? YES or NO? [Y/n] ");
        yesno = Console.ReadLine();

        switch (yesno?.ToLower())
        {

            case "y":
            case "":
                selectActivity();
                break;

            case "n":
                Console.WriteLine("\n-----------------------------------\n\nThank you for choosing our services!\n\nPlease remove your card");
                break;

            default:
                Console.WriteLine("\nPlease start over");
                break;
        }
    }

    public int AddBalance(int operationAmount, int balance)
    {
        return operationAmount + balance;
    }

    public int DeductBalance(int balance, int operationAmount)
    {
        return balance - operationAmount;
    }
}
