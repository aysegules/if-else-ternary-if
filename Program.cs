internal class Program
{
    public static void Main(string[] args)
    {
        int time= DateTime.Now.Hour;

        if(time>=6 && time<11)
        {
            Console.WriteLine("Good morning!");
        }
        else if(time>=11 && time<16)
        {
            Console.WriteLine("Good afternoon!");
        }
        else if(time>=16 && time<19)
        {
            Console.WriteLine("Good evening!");
        }
        else
        {
            Console.WriteLine("Good night!");
        }

        //the ternary conditional operator
        string result= time>=6 && time<=11 ? "Good morning!" : time>=11 && time<16 ? "Good afternoon!" : time>=16 && time<19 ? "Good evening!" : "Good night!";

        Console.WriteLine(result);

    }
}