namespace Tallpuslespill
{
    public class Numbers
    {
        private int _num;
        private bool _isInt;

        public Numbers(int num)
        {
            _num = num;
            _isInt = true;
        }

        public int ShowSpesificNumber()
        {
            return _num;
        }

        public bool IsInt()
        {
            return _isInt;
        }

        public bool ChangeBool()
        {
            _isInt = !_isInt;
            return _isInt;
        }


    }
}
