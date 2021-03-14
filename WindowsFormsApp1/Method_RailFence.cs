using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Method_RailFence
    {

        private String _line = null;
        private int _key;

        public Method_RailFence(String line, int key)
        {
            this._key = key;
            this._line = line;
        }

        public String decipherLine()
        {
            String result = decipher();
            return result;
        }

        private string decipher()
        {
            char[,] rail = new char[_key, (_line.Length)];
            for (int i = 0; i < _key; ++i)
                for (int j = 0; j < _line.Length; ++j)
                    rail[i, j] = '\n';

            bool dir_down = false;
            int row = 0, col = 0;
            for (int i = 0; i < _line.Length; ++i)
            {
                if (row == 0)
                    dir_down = true;
                if (row == _key - 1)
                    dir_down = false;

                rail[row, col++] = '*';

                if (dir_down)
                    row++;
                else
                    row--;
            }
            int index = 0;
            for (int i = 0; i < _key; ++i)
                for (int j = 0; j < _line.Length; ++j)
                    if (rail[i, j] == '*' && index < _line.Length)
                        rail[i, j] = _line[index++];

            String result = "";
            dir_down = false;
            row = 0;
            col = 0;
            for (int i = 0; i < _line.Length; ++i)
            {
                if (row == 0)
                    dir_down = true;
                if (row == _key - 1)
                    dir_down = false;
                if (rail[row, col] != '*')
                    result += rail[row, col++];
                if (dir_down)
                    row++;
                else
                    row--;
            }
                            
            return result;
        }

        public String encryptLine()
        {
            String result = cipher();
            return result;
        }

        private String cipher()
        {
            char[,] arrRails = new char[_key, _line.Length];
            for (int i = 0; i < _key; ++i)
                for (int j = 0; j < _line.Length; ++j)
                    arrRails[i, j] = '\n';

            bool dir_down = false;
            int row = 0, col = 0;

            for (int i = 0; i < _line.Length; ++i)
            {
                if (row == 0 || row == _key - 1)
                    dir_down = !dir_down;
                arrRails[row, col++] = _line[i];
                if (dir_down)
                    row++;
                else
                    row--;
            }

            String result = "";
            for (int i = 0; i < _key; ++i)
                for (int j = 0; j < _line.Length; ++j)
                    if (arrRails[i, j] != '\n')
                        result += arrRails[i, j];

            return result;
        }



    }
}
