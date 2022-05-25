namespace jumper{
    public class Word{
        public List<char> Dashes = new List<char>{};           //contains the player's progress on guessing the word. if dashes == the correct word, game is won

        public List<string> wordSelection = new List<string> {"abandon","accompany","acknowledge","beginning","behavior","calculate",
                                            "candidate","development","efficiency","foundation","implication","knowledge","moderate",
                                            "nomination","performance","representative","shot","tournament","tournament","zone"};
        public string currentWord; //I think it can be private, feel free to change if needed
        public string dashedWord;                                   //dashedWord as a string version of Dashes(ended up not being used)

      public Word()
      {
            Random random = new Random();                           //this is basically chooseWord
            int index = random.Next(this.wordSelection.Count);      //starts the initialization off with chooseWord
            this.currentWord = this.wordSelection[index];
            char dash = '-';                                        //also creates Dashes immediately after the random word is selected
            for (int i = 0; i <= (this.getWordLength()-1); i++)     //dashes is the ----- version of the randomly chosen word
            {   
                Dashes.Add(dash);
            }
            dashedWord = new string(Dashes.ToArray());              //never got used but it creates dashedWord from Dashes
      }

        public void chooseWord() {
            Random random = new Random();
            int index = random.Next(this.wordSelection.Count);
            this.currentWord = this.wordSelection[index];
        }

        public List<int> compareGuess(Player player) {
            //returns a list of index(s) of where letter matches
            List<int> index = new List<int>();
            for(int i = 0;i<=(this.currentWord.Length-1);i++) {
                if(this.currentWord[i]==player.getLetter()) {
                    index.Add(i);
                }
            }
            return index;
        }

        public int getWordLength() {
            return this.currentWord.Length;
        }
        
        public void updateDashes(List<int> index, char letter)
        {
            for (int i = 0; i <= (index.Count-1); i++)
            {   
                Dashes[index[i]] = letter;
            }
        }

        public string convertC2S(List<char> Dashes)
        {
            string word = new string(Dashes.ToArray());
            return word;
        }
    }
}