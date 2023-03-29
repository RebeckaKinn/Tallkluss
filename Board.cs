namespace Tallpuslespill
{
    public class Board
    {
        private Numbers[] NumList { get; set; }
        private Words[] TxtList { get; set; }

        public Board()
        {
            NumList = new Numbers[9];
            NumList[0] = new Numbers(1);
            NumList[1] = new Numbers(2);
            NumList[2] = new Numbers(3);
            NumList[3] = new Numbers(4);
            NumList[4] = new Numbers(5);
            NumList[5] = new Numbers(6);
            NumList[6] = new Numbers(7);
            NumList[7] = new Numbers(8);
            NumList[8] = new Numbers(9);
            TxtList = new Words[9];
        }

        public void ShowBoard()
        {
            Console.WriteLine($"| {(NumList[3].IsInt() ? NumList[3].ShowSpesificNumber() : TxtList[3].ShowSpesificText())} | {(NumList[8].IsInt() ? NumList[8].ShowSpesificNumber() : TxtList[8].ShowSpesificText())} | {(NumList[6].IsInt() ? NumList[6].ShowSpesificNumber() : TxtList[6].ShowSpesificText())} |");
            Console.WriteLine($"-------------");
            Console.WriteLine($"| {(NumList[4].IsInt() ? NumList[4].ShowSpesificNumber() : TxtList[4].ShowSpesificText())} | {(NumList[1].IsInt() ? NumList[1].ShowSpesificNumber() : TxtList[1].ShowSpesificText())} | {(NumList[5].IsInt() ? NumList[5].ShowSpesificNumber() : TxtList[5].ShowSpesificText())} |");
            Console.WriteLine($"-------------");
            Console.WriteLine($"| {(NumList[0].IsInt() ? NumList[0].ShowSpesificNumber() : TxtList[0].ShowSpesificText())} | {(NumList[7].IsInt() ? NumList[7].ShowSpesificNumber() : TxtList[7].ShowSpesificText())} | {(NumList[2].IsInt() ? NumList[2].ShowSpesificNumber() : TxtList[2].ShowSpesificText())} |");
        }

        public void ChangenumberToText(string input, int index)
        {
            NumList[index].ChangeBool();
            TxtList[index] = new Words(input);
        }

        public bool IsGameOver(int index)
        {
            if (NumList.Length == index) return true;
            else return false;
        }

        public void GameOver()
        {
            Console.WriteLine("\nGame Over! Here is your sentence:\n");
            foreach (var word in TxtList)
            {
                Console.Write($" {word.ShowSpesificText()} ");
            }
            Console.WriteLine("\nDet ble fantastisk!");
            Thread.Sleep(3000);
        }
    }
}