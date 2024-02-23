using System.Text;

namespace PasswordGenerator
{
    internal class Generator
    {
        private const string UPPERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string LOWERS = "abcdefghijklmnopqrstuvwxyz";
        private const string NUMBERS = "0123456789";
        private const string SYMBOLS = "!@#$%&";

        public string Generate(int length)
        {
            if (length > 0)
            {
                var rnd = new Random();

                var randomLetters = new StringBuilder(length);

                string[] selector = { UPPERS, LOWERS, NUMBERS, SYMBOLS };

                for (int i = 0; i < length; i++)
                {
                    string chosen = selector[rnd.Next(selector.Length)];

                    randomLetters.Append(chosen[rnd.Next(chosen.Length)]);
                }

                string word = randomLetters.ToString();

                char[] letters = word.ToCharArray();

                Shuffle(ref letters);

                string password = new String(letters);

                return password;
            }
            else
            {
                return "Não é possível gerar uma senha com tamanho igual ou menor que 0!";
            }
        }

        private void Shuffle(ref char[] letters)
        {
            var rnd = new Random(DateTime.Now.Millisecond);

            for (int eachTime = 1; eachTime <= 5; eachTime++)
            {
                for (int eachLetter = 1; eachLetter <= letters.Length; eachLetter++)
                {
                    Swap(
                        ref letters[rnd.Next(0, letters.Length)],
                        ref letters[rnd.Next(0, letters.Length)]
                    );
                }
            }
        }

        private void Swap(ref char charOne, ref char charTwo)
        {
            char charTemp = charOne;
            charOne = charTwo;
            charTwo = charTemp;
        }
    }
}