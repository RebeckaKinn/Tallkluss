namespace Tallpuslespill
{
    internal class Words
    {
        private string _txt;

        public Words(string txt)
        {
            _txt = txt;
        }

        public string ShowSpesificText()
        {
            return _txt;
        }
    }
}
