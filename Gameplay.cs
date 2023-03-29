namespace Tallpuslespill
{
    public class Gameplay
    {
        private int index = 0;

        public void GamePlay(Board board)
        {
            Console.Clear();
            if (board.IsGameOver(index))
            {
                board.GameOver();
                return;
            }
            Console.WriteLine("PUZZLE\nWrite a word to replace\nthe numbers in order.");
            board.ShowBoard();
            InputCheck(board);
        }

        public void InputCheck(Board board)
        {
            var input = Console.ReadLine();
            board.ChangenumberToText(input, index);
            index++;
            GamePlay(board);
        }




    }
}
