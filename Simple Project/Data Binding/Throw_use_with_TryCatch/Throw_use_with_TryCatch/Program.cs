class validInf
{
    public void vlidMsg(int age)
    {
    if(age < 18)
        {
            //Console.Write("Validation wrong: ");
            throw new Exception("You are not allowed apply for NID");
        }
        //Console.Write("Validation right: ");
        //throw new Exception("Congratulations! ");
    }
}

class Program
{
    static void Main(string[] args)
    {
        validInf inf = new validInf();
        inf.vlidMsg(5);

        try
        {
            inf.vlidMsg(18);
            Console.WriteLine("You are allowed to apply for NID");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Validation failed: {ex.Message}");
        }

    }
}
