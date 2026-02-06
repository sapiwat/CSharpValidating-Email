namespace starter;

class Program
{
    public static void Main(string[] args)
    {
        // MARK: Setup
        Console.WriteLine("Enter the email address you'd like to validate:");
        var input = Console.ReadLine();

        // MARK: Result
        if (!string.IsNullOrWhiteSpace(input))
            ValidateEmail(input);
        else
            Console.WriteLine("No email entered - please provide a valid email.");

        Console.ReadKey();
    }

    // MARK: Write your solution here
    public static void ValidateEmail(string email)
    {
        //check first char
        if (!char.IsLetter(email[0]))
        {
            Console.WriteLine("Emails cannot start with symbol or number");
            return;
        }
        //check if there is "@" symbol
        if (email.IndexOf('@') == -1) //can use email.Contains('@')
        {
            Console.WriteLine("Emails must contain \"@\"");
            return;
        }

        //check if it ends with ".com"
        if (email.ToLower().LastIndexOf(".com") != email.Length - 4)
        //4 is the lenghth of ".com"
        //can also use substring method to cut the last 4 characters to see if it is ".com"
        {
            Console.WriteLine("Emails must end with .com");
            return;
        }

        Console.WriteLine("Email is valid");
    }
}
