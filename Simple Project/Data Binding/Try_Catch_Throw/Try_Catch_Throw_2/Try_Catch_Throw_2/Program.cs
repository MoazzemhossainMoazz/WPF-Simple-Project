using System.Net.Http.Headers;

public class UserValidator
{
    public void ValidateAge(int age)
    {
        if(age < 18)
        {
            throw new Exception("You must have to be 18");
        }
    }
}

class Program
{
    static void Main()
    {
        UserValidator validinf = new UserValidator();
        
        try
        {
            validinf.ValidateAge(13);
            Console.WriteLine("Congratulations! you are allowed to apply for NID");
        }

        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}