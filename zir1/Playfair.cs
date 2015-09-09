using System;
using System.Collections.Generic;
using System.Linq;

namespace zir1
{
    public static class Playfair
    {
        private static readonly char[] initialCharset = new char[5 * 5];
        private static readonly char[,] playfairTable = new char[5, 5];

        public static void Initialize()
        {
            var c = 'a'; // a-i, k-z
            for (var i = 0; i < 5 * 5; i++)
            {
                if (c == 'j')
                    c = 'k';
                initialCharset[i] = c;
                c++;
            }
        }

        public static char[,] SetPlayfairTable(string key)
        {
            if (key == String.Empty)
                return null;
            key = key.ToLower().Replace('j', 'i').Replace(" ", "");
            var uniqueChars = new HashSet<char>();
            foreach (var c in key)
            {
                uniqueChars.Add(c);
            }
            foreach (var ch in initialCharset)
            {
                uniqueChars.Add(ch);
            }
            for (var i = 0; i < 5; i++)
            {
                for (var j = 0; j < 5; j++)
                {
                    playfairTable[i, j] = uniqueChars.ToArray()[5 * i + j];
                }
            }
            return playfairTable;
        }

        public static string Encrypt(string text, string key)
        {
            var result = new List<char>();
            text = text.ToLower().Replace('j', 'i').Replace(" ", "");
            var table = SetPlayfairTable(key);
            if (text.Length % 2 != 0)
                text = text + 'z';
            for (var p = 0; p < text.Length - 1; p += 2)
            {
                if (text[p] == text[p + 1])
                {
                    text = text.Insert(p + 1, "x");
                }
                var coords = new int[2, 2];
                var b = false;
                for (var c = 0; c < table.Length; c++)
                {
                    if (table[c / 5, c % 5] == text[p])
                    {
                        coords[0, 0] = c / 5;
                        coords[0, 1] = c % 5;
                        if (b)
                            break;
                        b = true;
                    }
                    if (table[c / 5, c % 5] == text[p + 1])
                    {
                        coords[1, 0] = c / 5;
                        coords[1, 1] = c % 5;
                        if (b)
                            break;
                        b = true;
                    }
                }
                if (coords[0, 0] == coords[1, 0])
                {
                    result.Add(coords[0, 1] < 5 - 1 ? table[coords[0, 0], coords[0, 1] + 1] : table[coords[0, 0], 0]);
                    result.Add(coords[1, 1] < 5 - 1 ? table[coords[1, 0], coords[1, 1] + 1] : table[coords[1, 0], 0]);
                }
                else if (coords[0, 1] == coords[1, 1])
                {
                    result.Add(coords[0, 0] < 5 - 1 ? table[coords[0, 0] + 1, coords[0, 1]] : table[0, coords[0, 1]]);
                    result.Add(coords[1, 0] < 5 - 1 ? table[coords[1, 0] + 1, coords[1, 1]] : table[0, coords[1, 1]]);
                }
                else
                {
                    result.Add(table[coords[0, 0], coords[1, 1]]);
                    result.Add(table[coords[1, 0], coords[0, 1]]);
                }
            }
            return String.Concat(result);
        }

        public static string Decrypt(string text, string key)
        {
            var result = new List<char>();
            text = text.ToLower().Replace('j', 'i').Replace(" ", "");
            var table = SetPlayfairTable(key);
            for (var p = 0; p < text.Length - 1; p += 2)
            {
                
                var coords = new int[2, 2];
                var b = false;
                for (var c = 0; c < table.Length; c++)
                {
                    if (table[c / 5, c % 5] == text[p])
                    {
                        coords[0, 0] = c / 5;
                        coords[0, 1] = c % 5;
                        if (b)
                            break;
                        b = true;
                    }
                    if (table[c / 5, c % 5] == text[p + 1])
                    {
                        coords[1, 0] = c / 5;
                        coords[1, 1] = c % 5;
                        if (b)
                            break;
                        b = true;
                    }
                }
                if (coords[0, 0] == coords[1, 0])
                {
                    result.Add(coords[0, 1] > 0 ? table[coords[0, 0], coords[0, 1] - 1] : table[coords[0, 0], 5 - 1]);
                    result.Add(coords[1, 1] > 0 ? table[coords[1, 0], coords[1, 1] - 1] : table[coords[1, 0], 5 - 1]);
                }
                else if (coords[0, 1] == coords[1, 1])
                {
                    result.Add(coords[0, 0] > 0 ? table[coords[0, 0] - 1, coords[0, 1]] : table[5 - 1, coords[0, 1]]);
                    result.Add(coords[1, 0] > 0 ? table[coords[1, 0] - 1, coords[1, 1]] : table[5 - 1, coords[1, 1]]);
                }
                else
                {
                    result.Add(table[coords[0, 0], coords[1, 1]]);
                    result.Add(table[coords[1, 0], coords[0, 1]]);
                }
            }
            return String.Concat(result);
        }
    }
}
