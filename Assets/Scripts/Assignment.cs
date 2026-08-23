using UnityEngine;
public class Assignment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created 
    void Start()
    {
         As01_CheckNumberSign(); 
         As02_GetDayName(); 
         As03_ValidatePassword(); 
         As04_GetGrade(); 
         As05_IsLeapYear(); 
         As06_Calculate(); 
         As07_GetSeason(); 
         As08_PurchasingSystemExample(); 
         As09_RockPaperScissorsExample(); 
         As10_CalculateWeaponDamage(); 
         As11_DeterminePlayerRank(); 
    }
    public int as01Number;
    public void As01_CheckNumberSign()
    {
        if (as01Number > 0)
        {
            Debug.Log("Positive");
        }
        else if (as01Number < 0)
        {
            Debug.Log("Negative");
        }
        else
        {
            Debug.Log("Zero");
        }
    }

    public int as02Day;
    public void As02_GetDayName()
    {
        switch (as02Day)
        {
            case 1:
                Debug.Log("Monday");
                break;
            case 2:
                Debug.Log("Tuesday");
                break;
            case 3:
                Debug.Log("Wednesday");
                break;
            case 4:
                Debug.Log("Thursday");
                break;
            case 5:
                Debug.Log("Friday");
                break;
            case 6:
                Debug.Log("Saturday");
                break;
            case 7:
                Debug.Log("Sunday");
                break;
            default:
                Debug.Log("Invalid day");
                break;
        }
    }

    public string as03InputPassword;
    public string as03CorrectPassword;
    public void As03_ValidatePassword()
    {
        if (as03InputPassword == as03CorrectPassword)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }
    }

    public int as04Score;
    public void As04_GetGrade()
    {
        if (as04Score >= 80 && as04Score <= 100)
        {
            Debug.Log("A");
        }
        else if (as04Score >= 70)
        {
            Debug.Log("B");
        }
        else if (as04Score >= 60)
        {
            Debug.Log("C");
        }
        else if (as04Score >= 50)
        {
            Debug.Log("D");
        }
        else if (as04Score >= 0)
        {
            Debug.Log("F");
        }
        else
        {
            Debug.Log("Invalid score");
        }
    }

    public int as05Year;
    public void As05_IsLeapYear()
    {
        if ((as05Year % 400 == 0) ||
            (as05Year % 4 == 0 && as05Year % 100 != 0))
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }
    }

    public double as06Num1;
    public char as06Op;
    public double as06Num2;
    public void As06_Calculate()
    {
        double result;
        switch (as06Op)
        {
            case '+':
                result = as06Num1 + as06Num2;
                Debug.Log("Result: " + result);
                break;
            case '-':
                result = as06Num1 - as06Num2;
                Debug.Log("Result: " + result);
                break;
            case '*':
                result = as06Num1 * as06Num2;
                Debug.Log("Result: " + result);
                break;
            case '/':
                if (as06Num2 == 0)
                {
                    Debug.Log("Cannot divide by zero");
                }
                else
                {
                    result = as06Num1 / as06Num2;
                    Debug.Log("Result: " + result);
                }
                break;
            default:
                Debug.Log("Invalid operator");
                break;
        }
    }

    public int as07Month;
    public void As07_GetSeason()
    {
        switch (as07Month)
        {
            case 1:
            case 2:
            case 11:
            case 12:
                Debug.Log("Winter");
                break;
            case 3:
            case 4:
            case 5:
                Debug.Log("Summer");
                break;
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
                Debug.Log("Rainy");
                break;
            default:
                Debug.Log("Invalid month");
                break;
        }
    }

    public int as08Quantity;
    public int as08Price;
    public int as08Payment;
    public void As08_PurchasingSystemExample()
    {
        int totalPrice = as08Quantity * as08Price;
        Debug.Log("Total Price: " + totalPrice);
        if (as08Quantity <= 0 || as08Price < 0)
        {
            Debug.Log("Invalid purchase information");
        }
        else if (as08Payment >= totalPrice)
        {
            int change = as08Payment - totalPrice;
            Debug.Log("Payment successful");
            Debug.Log("Change: " + change);
        }
        else
        {
            int remaining = totalPrice - as08Payment;
            Debug.Log("Insufficient payment");
            Debug.Log("Remaining: " + remaining);
        }
    }

    public int as09UserChoice;
    public int as09ComputerChoice;
    public void As09_RockPaperScissorsExample()
    {
        if (as09UserChoice < 1 || as09UserChoice > 3 ||
            as09ComputerChoice < 1 || as09ComputerChoice > 3)
        {
            Debug.Log("Invalid choice");
            return;
        }
        string userChoiceName = GetRPSName(as09UserChoice);
        string computerChoiceName = GetRPSName(as09ComputerChoice);
        Debug.Log("You chose: " + userChoiceName);
        Debug.Log("Computer chose: " + computerChoiceName);
        if (as09UserChoice == as09ComputerChoice)
        {
            Debug.Log("Draw");
        }
        else if (
            (as09UserChoice == 1 && as09ComputerChoice == 3) ||
            (as09UserChoice == 2 && as09ComputerChoice == 1) ||
            (as09UserChoice == 3 && as09ComputerChoice == 2)
        )
        {
            Debug.Log("You Win");
        }
        else
        {
            Debug.Log("Computer Wins");
        }
    }
    private string GetRPSName(int choice)
    {
        switch (choice)
        {
            case 1:
                return "Rock";
            case 2:
                return "Paper";
            case 3:
                return "Scissors";
            default:
                return "Unknown";
        }
    }

    public string as10WeaponType;
    public int as10BaseDamage;
    public void As10_CalculateWeaponDamage()
    {
        float multiplier;
        switch (as10WeaponType.ToLower())
        {
            case "sword":
                multiplier = 1.5f;
                break;
            case "bow":
                multiplier = 1.2f;
                break;
            case "gun":
                multiplier = 2.0f;
                break;
            default:
                Debug.Log("Unknown weapon type");
                return;
        }
        float damage = as10BaseDamage * multiplier;
        Debug.Log("Weapon: " + as10WeaponType);
        Debug.Log("Damage: " + damage);
    }

    public int as11Score;
    public int as11CompletionTime;
    public void As11_DeterminePlayerRank()
    {
        string rank;
        if (as11Score >= 90)
        {
            rank = "S";
        }
        else if (as11Score >= 80)
        {
            rank = "A";
        }
        else if (as11Score >= 70)
        {
            rank = "B";
        }
        else if (as11Score >= 60)
        {
            rank = "C";
        }
        else
        {
            rank = "D";
        }
        Debug.Log("Rank: " + rank);
        Debug.Log("Score: " + as11Score);
        Debug.Log("Completion Time: " + as11CompletionTime + " seconds");
    }
}