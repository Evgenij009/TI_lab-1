using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Method_Vinegar
    {
        private String _line = null;
        private String _key = null;
        private readonly char[] russianAlphabet = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё',
                                                    'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 
                                                    'Н', 'О', 'П', 'Р', 'С', 'Т', 'У',
                                                    'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 
                                                    'Ы', 'Ь', 'Э', 'Ю', 'Я' };

        public Method_Vinegar(String line, String key)
        {
            this._line = line;
            this._key = key;
        }

        public String encryptLine()
        {
            String line = doingEncrypt();
            return line;
        }

        private string doingEncrypt()
        {
            String result = "";
            int indexKey = 0;
            for (int i = 0; i < _line.Length; ++i)
            {
                if (indexKey < _key.Length)
                    indexKey = 0;
                int numberLetter = (getNuberLetter(_key[indexKey]) + getNuberLetter(_line[i])) % 33;
                char buff = russianAlphabet[numberLetter];
                result += buff;
                ++indexKey;
            }

            return result;
        }

        private int getNuberLetter(char symbol)
        {
            int answer = 0;
            symbol = char.ToUpper(symbol);
            for (int i = 0; i < russianAlphabet.Length; ++i)
                if (russianAlphabet[i] == symbol)
                {
                    answer = i;
                    break;
                }
            
            return answer;
        }

        public String decipher()
        {
            String answer = doingDecipher();
            return answer;
        }

        private String doingDecipher()
        {
            String result = "";
            int indexKey = 0;
            for (int i = 0; i < _line.Length; ++i)
            {
                if (indexKey < _key.Length)
                    indexKey = 0;
                int numberLetter = (getNuberLetter(_line[i]) - getNuberLetter(_key[indexKey]) + 33) % 33;
                char buff = russianAlphabet[numberLetter];
                result += buff;
                ++indexKey;
            }

            return result;
        }
    }
}
