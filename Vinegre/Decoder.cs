using System;
using System.Linq;

namespace Vinegre
{
    public class Decoder
    {
        string alphabet = "AĄBCĆDEĘFGHIJKLŁMNŃOÓPQRSŚTUVWXYZŹŻ";
        public string Algorythm(string input, string key, bool decode)
        {
            string output = String.Empty;

            input = InputUnification(input);
            key = InputUnification(key);

            if (input.Length > key.Length)
                key = MakeTheSameLenght(key, input.Length);
            else if (input.Length < key.Length)
                input = MakeTheSameLenght(input, key.Length);

            switch (decode)
            {
                case true:
                    for (int i = 0; i < input.Length; i++)
                        output += alphabet[(alphabet.IndexOf(input[i]) + alphabet.IndexOf(key[i])) % alphabet.Length];
                    break;
                case false:
                    for (int i = 0; i < input.Length; i++)
                        output += alphabet[(alphabet.IndexOf(input[i]) - alphabet.IndexOf(key[i]) + alphabet.Length) % alphabet.Length];
                    break;
                default:
                    break;
            }
            return output;
        }

        private string MakeTheSameLenght(string input, int length)
        {
            string output = String.Empty;
            for (int i = 0; i < length; i++)
                output += input[i % (input.Length)];
            return output;
        }

        public string InputUnification(string input)
        {
            string temporary = String.Empty;
            input = input.ToUpper();
            foreach (char c in input)
            {
                if (alphabet.Contains(c))
                    temporary += c;
            }
            return temporary;
        }
    }
}
