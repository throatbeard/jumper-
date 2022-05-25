namespace jumper                                    //name of the program
{
    class Program                                   //the main class, the program class
    {
        static void Main(string[] args)             //main
        {
            Director director = new Director();     //the class that does it all, the director class
            director.StartGame();                   //startgame is the funcitont hat runs other functions
        }
    }
}