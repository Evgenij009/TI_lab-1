using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DataEncryption
    {
        private String _mainLine = null;
        private String _key = null;

        public DataEncryption (String line, String key)
        {
            this._mainLine = line;
            this._key = key;
        }

        public string encrypt_methodRailFence()
        {
            String source = RemoveChar_besidesEnglishAlphabet(_mainLine);
            int key = int.Parse(_key);
            Method_RailFence method_RailFence = new Method_RailFence(source, key);
            String resultLine = method_RailFence.encryptLine();

            return resultLine;
        }

        public string encrypt_methodColumn()
        {
            String source = RemoveChar_besidesEnglishAlphabet(_mainLine);
            Method_Column method_Column = new Method_Column(source, RemoveChar_besidesEnglishAlphabet(_key));
            String resultLine = method_Column.encrypt();

            return resultLine;
        }

        public string encrypt_methodVinegar()
        {
            String source = RemoveChar_besidesRussianAlphabet(_mainLine);
            Method_Vinegar method_Vinegar = new Method_Vinegar(source, _key);
            String resultLine = method_Vinegar.encryptLine();

            return resultLine;
        }

        public string decipher_methodRailFence()
        {
           String source = RemoveChar_besidesEnglishAlphabet(_mainLine);
            int key = int.Parse(_key);
            Method_RailFence method_RailFence = new Method_RailFence(source, key);
            String resultLine = method_RailFence.decipherLine();

            return resultLine;
        }

        public string decipher_methodColumn()
        {
            String source = RemoveChar_besidesEnglishAlphabet(_mainLine);
            Method_Column method_Column = new Method_Column(source, RemoveChar_besidesEnglishAlphabet(_key));
            String resultLine = method_Column.decipher();

            return resultLine;
        }

        public string decipher_methodVinegar()
        {
            String source = RemoveChar_besidesRussianAlphabet(_mainLine);
            Method_Vinegar method_Vinegar = new Method_Vinegar(source, RemoveChar_besidesRussianAlphabet(_key));
            String resultLine = method_Vinegar.decipher();

            return resultLine;
        }

        private string RemoveChar_besidesEnglishAlphabet(String line)
        {
            String resultLine = null;
            for (int i = 0; i < line.Length; ++i)
            {
                char symbol = line[i];
                if ((symbol >= 65 && symbol <= 90) || (symbol >= 97 && symbol <= 122))
                    resultLine += symbol;
            }
            return resultLine;
        }

        private string RemoveChar_besidesRussianAlphabet(String line)
        {
            String resultLine = null;
            for (int i = 0; i < line.Length; ++i)
            {
                char symbol = line[i];
                if ((symbol >= 1040 && symbol <= 1103) || symbol == 1105 || symbol == 1025)
                    resultLine += symbol;
            }
            return resultLine;
        }

    }
}
