using System;

class ClassesDemo
{
    /*
  Make a value-added tax method for a café business. The method should
take a string value indicating one of three product options and a decimal
value representing the price of the product. The method should return the
value added tax (VAT) calculated.
The café on occasions sells music entertainment. The VAT is 6 percent.
The café sells food. The VAT is 12 percent.
The café sells alcohol. The VAT is 25 percent. 

*/
    public static decimal CalculateVAT(string productType, decimal price)
    {
        decimal vatRate;

        // Determine VAT rate based on the product type
        switch (productType.ToLower())
        {
            case "music":
                vatRate = 0.06m; // 6% VAT for music entertainment
                break;
            case "food":
                vatRate = 0.12m; // 12% VAT for food
                break;
            case "alcohol":
                vatRate = 0.25m; // 25% VAT for alcohol
                break;
            default:
                throw new ArgumentException("Invalid product type. Use 'music', 'food', or 'alcohol'.");
        }

        // Calculate VAT
        return price * vatRate;
    }

    /*
 2.
Make a method calculating the price when signing up for a gym
membership. The method should take an int value indicating the age of
the signee and a bool value indicating a wish for premium membership.
Persons below the age of 19 and above the age of 64 pay 2200 for their
membership. All else pay 3100. The premium membership is a straight 300
amount on top of what the signee already will pay. The method should
return the full amount payable for the signee. 
*/
    public static int CalculateMembershipPrice(int age, bool isPremium)
    {
        int basePrice;

        // Determine the base price based on age
        if (age < 19 || age > 64)
        {
            basePrice = 2200; // Discounted price for persons under 19 or over 64
        }
        else
        {
            basePrice = 3100; // Standard price
        }

        // Add premium membership cost if applicable
        if (isPremium)
        {
            basePrice += 300; // Additional cost for premium membership
        }

        return basePrice;
    }

    /*
  3.
Use a switch statement to make a calculator method that takes a string
value indicating the mathematical operation and two double values as
parameters. The method returns the result of the operation, which should
at least include adding, subtracting, multiplying and dividing. 

*/
    public static double Calculator(string calculateMethod, double value1, double value2)
    {
        double result;

        // Determine the result of calculation
        switch (calculateMethod.ToLower())
        {
            case "adding":
                result = value1 + value2;
                break;
            case "subtracting":
                result = value1 - value2;
                break;
            case "multiplying":
                result = value1 * value2;
                break;
            case "dividing":
                result = value1 / value2;
                break;
            default:
                throw new ArgumentException("Invalid calculate method. Use 'adding', 'subtracting', 'multiplying' or 'dividing'.");
        }
        return result;
    }

    /*
     4.
Make a menu options method that takes one of the following options as a
string value parameter:
- help, add, delete, edit, find, list
The method should not return any value, but for the option chosen, print
out a unique and appropriate message using Console.WriteLine().
    */
    public static void MenuOptions(string option)
    {

        // Determine the result of calculation
        switch (option.ToLower())
        {
            case "help":
                Console.WriteLine("Help is on your way!");
                break;
            case "add":
                Console.WriteLine("Add one coffe in your order");
                break;
            case "delete":
                Console.WriteLine("You can delete your option");
                break;
            case "edit":
                Console.WriteLine("You can edit your order");
                break;
            case "find":
                Console.WriteLine("You can find more options");
                break;
            case "list":
                 Console.WriteLine("This is your list");
                break;
            default:
                throw new ArgumentException("Invalid calculate method. Use 'help', 'add', 'delete' 'edit' 'find' or 'list'.");
        }
    }


    static void Main(string[] args)
    {
        // Calculate VAT
        Console.WriteLine("Calculating VAT:");
        Console.WriteLine("VAT for music (price 100): " + CalculateVAT("music", 100));
        Console.WriteLine("VAT for food (price 100): " + CalculateVAT("food", 100));
        Console.WriteLine("VAT for alcohol (price 100): " + CalculateVAT("alcohol", 100));

        Console.WriteLine("");
        Console.WriteLine("********************************************");
        Console.WriteLine("");

        // Gym membership
        Console.WriteLine("Calculating Gym membership:");
        Console.WriteLine("Price for age 18 (non-premium): " + CalculateMembershipPrice(18, false)); // 2200
        Console.WriteLine("Price for age 30 (premium): " + CalculateMembershipPrice(30, true)); // 3400
        Console.WriteLine("Price for age 65 (premium): " + CalculateMembershipPrice(65, true)); // 2500
        Console.WriteLine("Price for age 65 (premium): " + CalculateMembershipPrice(17, true)); // 2500

        Console.WriteLine("");
        Console.WriteLine("*******************************************");
        Console.WriteLine("");

        // Calculator Method
        Console.WriteLine("Calculator Method:");
        Console.WriteLine("Adding two numbers: " + Calculator("adding", 10, 12));
        Console.WriteLine("Subtracting two numbers: " + Calculator("subtracting", 10, 12));
        Console.WriteLine("Multiplying two numbers: " + Calculator("multiplying", 10, 12));
        Console.WriteLine("Dividing two numbers: " + Calculator("dividing", 10, 12));

        Console.WriteLine("");
        Console.WriteLine("*******************************************");
        Console.WriteLine("");

        // Menu Options
        Console.WriteLine("Menu Options:");
        MenuOptions("help");
        MenuOptions("add");
        MenuOptions("delete");
        MenuOptions("edit");
        MenuOptions("find");
        MenuOptions("list");
    }
}
