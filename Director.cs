namespace jumper
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        private bool isPlaying = true;
        private Word word = new Word();
        private Player player = new Player();
        private TerminalService terminalService = new TerminalService();

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Gets the players guess.
        /// </summary>
        private void GetInputs()
        {
            string letter = terminalService.ReadText("\nGuess a letter [a-z]: ");
            player.SetLetter(letter);
        }

        /// <summary>
        /// Keeps watch on where the seeker is moving.
        /// </summary>
        private void DoUpdates()
        {
            List<int> letter_placement = word.compareGuess(player);
            if (letter_placement == null)
            {
                player.incrementWrong();
            }
            else
            {
                word.updateDashes(letter_placement, player.getLetter());
            }

            if (player.numWrongGuesses >= 5 || word.currentWord == word.dashedWord)
            {
                isPlaying = false;
            }

        }

        /// <summary>
        /// Provides a hint for the seeker to use.
        /// </summary>
        private void DoOutputs()
        {
            terminalService.WriteText(word.dashedWord);
            for (int i = player.numWrongGuesses; i <= 7; i++)
            {
                terminalService.WriteText(player.Picture[i]);
            }
        }
    }
}