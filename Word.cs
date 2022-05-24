namespace jumper{
    public class Word{
        public List<char> Dashes = new List<char>{};           //contains the player's progress on guessing the word. if dashes == the correct word, game is won

        public List<string> wordSelection = new List<string>{"abandon","accompany","acknowledge","beginning","behavior","calculate",
                                            "candidate","development","efficiency","foundation","implication","knowledge","moderate",
                                            "nomination","performance","representative","shot","tournament","tournament","zone"};
        public string currentWord; //I think it can be private, feel free to change if needed

        public void chooseWord() {
            Random random = new Random();
            int index = random.Next(this.wordSelection.Count);
            this.currentWord = this.wordSelection[index];
        }

        public List<int> compareGuess(Player player) {
            //returns a list of index(s) of where letter matches
            List<int> index = new List<int>();
            for(int i = 0;i<=this.currentWord.Length;i++) {
                if(this.currentWord[i]==player.getLetter()) {
                    index.Add(i);
                }
            }
            return index;
        }

        public int getWordLength() {
            return this.currentWord.Length;
        }
        
        private void MakeDashes()
        {
            char dash = '-';
            for (int i = 0; i <= this.getWordLength(); i++)
            {   
                Dashes.Add(dash);
            }
        }
        public void updateDashes(List<int> index, char letter)
        {
            for (int i = 0; i <= index.Count; i++)
            {   
                Dashes[i] = letter;
            }
        }

        public string convertC2S(List<char> Dashes)
        {
            string word = new string(Dashes.ToArray());
            return word;
        }
    }
}