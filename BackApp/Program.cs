namespace BackApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }


        void MatchTheCase(char letter) {
            char theCharToMatch = 'P';
            bool isMatchCase = letter switch
            {
                var c when c == theCharToMatch => true,
                _ => false,
            };
        }
    }
}