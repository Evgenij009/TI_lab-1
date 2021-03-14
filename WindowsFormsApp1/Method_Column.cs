using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Method_Column
    {
        private readonly String _line = null;
        private readonly String _key = null;
        private readonly String _englishAlphabet =  "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        

        public Method_Column(String line, String key)
        {
            this._line = line;
            this._key = key;
        }

        public String encrypt()
        {
            String answer = doingEncrypt();
            return answer;
        }
        
        
        private String doingEncrypt()
        {
            String result = "";
            int column = _key.Length;
            int row = _line.Length / column;
            if ((_line.Length % column) != 0)
                row++;
            int indexLine = 0;
            char[,] matrix = new char[row, column];
            for (int i = 0; i < row; ++i)
                for (int j = 0; j < column; ++j)
                    if (indexLine < _line.Length)
                    {
                        matrix[i, j] = _line[indexLine];
                        ++indexLine;
                    }
                    else
                    {
                        matrix[i, j] = '*';
                    }

            int[] arrayPosition = new int[_key.Length];
            int number = 0;
  
            for (int i = 0; i < _englishAlphabet.Length; ++i)
                for (int j = 0; j < _key.Length; j++)
                    if (_key[j] == _englishAlphabet[i])
                    {
                        arrayPosition[j] = number;
                        number++;
                    }

            for (number = 0; number < arrayPosition.Length; ++number)
            {
                int i = -1;
                do
                {
                    ++i;
                    if (arrayPosition[i] == number)
                    {
                        for (int j = 0; j < row; ++j)
                        {
                            if (matrix[j, i] != '*')
                                result += matrix[j, i];
                        }
                    }
                    
                } while (arrayPosition[i] != number);
            }

             return result;
        }
        

        /*
        private static int[] GetShiftIndexes(string key)
        {
            int keyLength = key.Length;
            int[] indexes = new int[keyLength];
            List<KeyValuePair<int, char>> sortedKey = new List<KeyValuePair<int, char>>();
            int i;

            for (i = 0; i < keyLength; ++i)
                sortedKey.Add(new KeyValuePair<int, char>(i, key[i]));

            sortedKey.Sort(
                delegate (KeyValuePair<int, char> pair1, KeyValuePair<int, char> pair2) {
                    return pair1.Value.CompareTo(pair2.Value);
                }
            );

            for (i = 0; i < keyLength; ++i)
                indexes[sortedKey[i].Key] = i;

            return indexes;
        }

        public static string doingEncipher(string input, string key, char padChar)
        {
            input = (input.Length % key.Length == 0) ? input : input.PadRight(input.Length - (input.Length % key.Length) + key.Length, padChar);
            StringBuilder output = new StringBuilder();
            int totalChars = input.Length;
            int totalColumns = key.Length;
            int totalRows = (int)Math.Ceiling((double)totalChars / totalColumns);
            char[,] rowChars = new char[totalRows, totalColumns];
            char[,] colChars = new char[totalColumns, totalRows];
            char[,] sortedColChars = new char[totalColumns, totalRows];
            int currentRow, currentColumn, i, j;
            int[] shiftIndexes = GetShiftIndexes(key);

            for (i = 0; i < totalChars; ++i)
            {
                currentRow = i / totalColumns;
                currentColumn = i % totalColumns;
                rowChars[currentRow, currentColumn] = input[i];
            }

            for (i = 0; i < totalRows; ++i)
                for (j = 0; j < totalColumns; ++j)
                    colChars[j, i] = rowChars[i, j];

            for (i = 0; i < totalColumns; ++i)
                for (j = 0; j < totalRows; ++j)
                    sortedColChars[shiftIndexes[i], j] = colChars[i, j];

            for (i = 0; i < totalChars; ++i)
            {
                currentRow = i / totalRows;
                currentColumn = i % totalRows;
                output.Append(sortedColChars[currentRow, currentColumn]);
            }

            return output.ToString();
        }

        public static string doingDecipher(string input, string key)
        {
            StringBuilder output = new StringBuilder();
            int totalChars = input.Length;
            int totalColumns = (int)Math.Ceiling((double)totalChars / key.Length);
            int totalRows = key.Length;
            char[,] rowChars = new char[totalRows, totalColumns];
            char[,] colChars = new char[totalColumns, totalRows];
            char[,] unsortedColChars = new char[totalColumns, totalRows];
            int currentRow, currentColumn, i, j;
            int[] shiftIndexes = GetShiftIndexes(key);

            for (i = 0; i < totalChars; ++i)
            {
                currentRow = i / totalColumns;
                currentColumn = i % totalColumns;
                rowChars[currentRow, currentColumn] = input[i];
            }

            for (i = 0; i < totalRows; ++i)
                for (j = 0; j < totalColumns; ++j)
                    colChars[j, i] = rowChars[i, j];

            for (i = 0; i < totalColumns; ++i)
                for (j = 0; j < totalRows; ++j)
                    unsortedColChars[i, j] = colChars[i, shiftIndexes[j]];

            for (i = 0; i < totalChars; ++i)
            {
                currentRow = i / totalRows;
                currentColumn = i % totalRows;
                output.Append(unsortedColChars[currentRow, currentColumn]);
            }

            return output.ToString();
        }
        */


        public String decipher()
        {

            return doingDecipher();
        }

        private string doingDecipher()
        {
            String result = "";
            int column = _key.Length;
            int row = _line.Length / column;
            int balance = _line.Length % column;
            if (balance != 0)
                row++;
            else
                balance = 99999999;
                

            int[] arrayPosition = new int[_key.Length];
            int number = 0;
            for (int i = 0; i < _englishAlphabet.Length; ++i)
                for (int j = 0; j < _key.Length; j++)
                    if (_key[j] == _englishAlphabet[i])
                    {
                        arrayPosition[j] = number;
                        number++;
                    }

            char[,] matrix = new char[row, column];
            int count = 0;
            for (number = 0; number < arrayPosition.Length; ++number)
            {
                int i = -1;
                do
                {
                    ++i;
                    if (arrayPosition[i] == number)
                    {
                        int index = row * number - count;
                        for (int j = 0; j < row; ++j)
                        {
                            if (!((j == row - 1) && (i  >= balance)) && ((index + j) < _line.Length))
                                matrix[j, i] = _line[index + j];
                            else
                            {
                                matrix[j, i] = '*';
                                ++count;
                            }
                        }
                    }

                } while (arrayPosition[i] != number);
            }

            for (int i = 0; i < row; ++i)
                for (int j = 0; j < column; ++j)
                    if (matrix[i, j] != '*')
                        result += matrix[i, j];

            return result;
        }




    }
}
