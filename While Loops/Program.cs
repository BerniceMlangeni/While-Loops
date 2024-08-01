namespace While_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
              string? UserInput = "";

              while(UserInput.ToLower() != "exit")
             {
                 Console.WriteLine("Type exit to quit");
                 UserInput= Console.ReadLine();
              }

             Console.WriteLine("Program terminated.");


        }
    }
}
