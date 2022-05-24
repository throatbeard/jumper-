namespace Jumper{
    class Word{
        public List<string> wordSelection = new List<string>{"abandon","accompany","acknowledge","beginning","behavior","calculate",
                                            "candidate","development","efficiency","foundation","implication","knowledge","moderate",
                                            "nomination","performance","representative","shot","tournament","tournament","zone"};
        private string currentWord; //I think it can be private, feel free to change if needed

        public void chooseWord() {
            Random random = new Random();
            int index = random.Next(this.wordSelection.Count);
            this.currentWord = this.wordSelection[index];
        }

        public List<int> compareGuess(char guess) {
            //returns a list of index(s) of where letter matches
            List<int> index = new List<int>();
            for(int i = 0;i<=this.currentWord.Length;i++) {
                if(this.currentWord[i]==guess) {
                    index.Add(i);
                }
            }
            return index;
        }

        public int getWordLength() {
            return this.currentWord.Length;
        }
    }
}