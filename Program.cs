namespace Tallpuslespill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var board = new Board();
            var game = new Gameplay();
            game.GamePlay(board);
        }
    }
}