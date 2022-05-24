public class Player
{
   private string Letter;           //holds the player's input
   private int numWrongGuesses;     //ticks upward if wrong. used to check if game is lost or not
   private string Dashes;           //contains the player's progress on guessing the word. if dashes == the correct word, game is won
   private string Picture;          //visual rep of the player's progress(or rather, lack of)

   public Player()
   {
      
   }

void SetLetter(string a){           //sets player input and stores into private Letter variable
Letter = a;
}

void CompareGuess(){                //compares what's in private Letter to the actual word to see if its a correct guess

}
}