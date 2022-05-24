namespace jumper{
   public class Player
   {
      public string Letter;           //holds the player's input
      public int numWrongGuesses = 0;     //ticks upward if wrong. used to check if game is lost or not
      public List<string> Picture = new List<string>{"  ----"," /     \\","  ----"," \\    /","  \\   /", "   o", "  /|\\", "   /\\"};          //visual rep of the player's progress(or rather, lack of)

      public Player()
      {
      
      }

   public void SetLetter(string a)           //sets player input and stores into private Letter
      {
         this.Letter = a;
      }

   void CompareGuess(){                //compares what's in private Letter to the actual word to see if its a correct guess

   }

   public char getLetter(){
      
      char Letter_c = Letter[0];
      return Letter_c;
   }

   public int incrementWrong()
   {
      numWrongGuesses += 1;
      return numWrongGuesses;
   }


   }
}