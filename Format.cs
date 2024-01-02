using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace SignatureMaker
{
    public class Format
    {
        public static bool IsStringHexadecimal(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                Int64 temp = 0;

                if (Int64.TryParse(str, NumberStyles.HexNumber, null, out temp))
                {
                    return (temp > 0);
                }
            }

            return false;
        }

        public static string CompareBytes(string originalArray, string compareArray)
        {
            originalArray = originalArray.Replace("?", "0").Replace(" ", "");
            compareArray = compareArray.Replace("?", "0").Replace(" ", "");
            char[] originalChars = originalArray.ToCharArray();
            char[] compareChars = compareArray.ToCharArray();
            string comparedBytes = "";

            for (Int32 i = 0; i < originalArray.Length; i++)
            {
                if (i < compareArray.Length)
                {
                    if (originalChars[i] == compareChars[i])
                    {
                        comparedBytes += originalChars[i];
                    }
                    else
                    {
                        comparedBytes += "?";
                    }
                }
            }

            if (originalArray.Length < compareArray.Length)
            {
                for (Int32 i = originalArray.Length; i < compareArray.Length; i++)
                {
                    comparedBytes += compareChars[i];
                }
            }
            else if (originalArray.Length > compareArray.Length)
            {
                for (Int32 i = compareArray.Length; i < originalArray.Length; i++)
                {
                    comparedBytes += originalArray[i].ToString();
                }
            }

            if ((comparedBytes.Length & 1) == 1)
            {
                comparedBytes = comparedBytes.Remove(comparedBytes.Length - 1);
            }

            return comparedBytes;
        }

        public static string CompareByteList(List<string> originalList, string compareArray)
        {
            foreach (string newArray in originalList)
            {
                compareArray = CompareBytes(compareArray, newArray);
            }

            return compareArray;
        }

        // Inserts a space between every two characets in a string.
        public static string FormatSpacing(string arrayOfBytes)
        {
            arrayOfBytes = arrayOfBytes.Replace(" ", "");
            char[] charArray = arrayOfBytes.ToCharArray();
            string formattedArray = "";

            Int32 index = 0;

            for (Int32 i = 0; i < charArray.Length; i++)
            {
                formattedArray += charArray[i].ToString();

                if (i == charArray.Length - 1)
                {
                    if ((i + 2) <= charArray.Length)
                    {
                        formattedArray = formattedArray.Insert((i + 2), " ");
                    }
                }
                else
                {
                    if (index == 1)
                    {
                        formattedArray += " ";
                        index = 0;
                    }
                    else
                    {
                        index++;
                    }
                }
            }

            return formattedArray;
        }

        // Creates a "hex valid" string for the given array of bytes, replacing questions with zeros.
        public static string CreateHex(string arrayOfBytes)
        {
            arrayOfBytes = FormatSpacing(arrayOfBytes);
            string[] arraySplit = arrayOfBytes.Split(' ');
            string createdHex = "";

            foreach (string str in arraySplit)
            {
                if (string.IsNullOrEmpty(str) || str.Contains("?"))
                {
                    createdHex += "00";
                }
                else
                {
                    createdHex += str;
                }
            }

            return FormatSpacing(createdHex);
        }

        // Creates a hex escaped version of "CreateHex".
        public static string CreateHexEscaped(string arrayOfBytes)
        {
            string createdHex = ("\\x" + CreateHex(arrayOfBytes));
            return createdHex.Replace(" ", "\\x");
        }

        public static string CreateByteArray(string arrayOfBytes)
        {
            arrayOfBytes = arrayOfBytes.Replace("?", "0");
            string createdArray = "0x";

            Int32 index = 0;

            for (Int32 i = 0; i < arrayOfBytes.Length; i++)
            {
                if (i != arrayOfBytes.Length)
                {
                    if (index == 0)
                    {
                        index = 1;
                        createdArray += arrayOfBytes[i].ToString();
                    }
                    else if (index == 1)
                    {
                        index = 0;
                        createdArray += arrayOfBytes[i].ToString();

                        if (i != (arrayOfBytes.Length - 1) && (i + 2) <= arrayOfBytes.Length)
                        {
                            createdArray += ", 0x";
                        }
                    }
                }
            }

            return createdArray;
        }

        // Creates a "half byte" mask with the given array of bytes, treats two characers as one.
        public static string CreateHalfMask(string arrayOfBytes)
        {
            arrayOfBytes = arrayOfBytes.Replace(" ", "");
            char[] charArray = arrayOfBytes.ToCharArray();
            string createdMask = "";

            for (Int32 i = 0; i < charArray.Length; i += 2)
            {
                if ((charArray[i] != '?') && ((i + 1) < charArray.Length)  && (charArray[(i + 1)] != '?'))
                {
                    createdMask += "x";
                }
                else if ((i + 1) < charArray.Length)
                {
                    createdMask += "?";
                }
            }

            return createdMask;
        }

        // Creates a "full byte" mask, creates a one to one mask of the given array of bytes.
        public static string CreateFullMask(string arrayOfBytes)
        {
            arrayOfBytes = arrayOfBytes.Replace(" ", "");
            string createdMask = "";

            foreach (char c in arrayOfBytes)
            {
                if (c == '?')
                {
                    createdMask += ((c == '?') ? "?" : "x");
                }
            }

            return createdMask;
        }
    }
}
