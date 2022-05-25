namespace jumper{
   public class Player
   {
      public string Letter;                           //holds the player's input
      public int numWrongGuesses = 0;                 //ticks upward if wrong. used to check if game is lost or not
      public List<string> Picture = new List<string>{ //visual rep of the player's progress(or rather, lack of)
         "  -----"," /     \\"," -------"," \\     /",
         "  \\   /", "    o", "   /|\\", "   / \\"};          

      public Player()                                 //empty constructor
      {
      
      }

   public void SetLetter(string a)                    //sets player input and stores into private Letter
      {
         this.Letter = a;                             //Letter is now what was passed into the function
      }

   void CompareGuess(){                               //compares what's in private Letter to the actual word to see if its a correct guess(never got used lol)

   }

   public char getLetter(){                           //returns Letter as a char instead of a string
      
      char Letter_c = Letter[0];                      //the conversion variable
      return Letter_c;                                //returns char
   }

   public int incrementWrong()                        //increments numWrongGuesses every time the player gets it wrong
   {
      numWrongGuesses += 1;                           //increments int numWrongGuesses up
      return numWrongGuesses;                         //also returns the value for usage
   }


   }
}