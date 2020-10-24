﻿using System.Text;

namespace ssc_lab3_tema
{
    internal class ConversionHandler
    {
        public byte[] StringToByteArray(string s)
        {
            return CharArrayToByteArray(s.ToCharArray());
        }

        private byte[] CharArrayToByteArray(char[] array)
        {
            return Encoding.ASCII.GetBytes(array, 0, array.Length);
        }

        public string ByteArrayToString(byte[] array)
        {
            return Encoding.ASCII.GetString(array);
        }

        public string ByteArrayToHexString(byte[] array)
        {

            string s = "";

            for (int i = 0; i < array.Length; i++)
            {
                s = s + NibbleToHexString((byte)((array[i] >> 4) & 0x0F))
                    + NibbleToHexString((byte)(array[i] & 0x0F));
            }

            return s;
        }

        public byte[] HexStringToByteArray(string s)
        {

            byte[] array = new byte[s.Length / 2];
            char[] chararray = s.ToCharArray();

            for (int i = 0; i < s.Length / 2; i++)
            {
                array[i] = (byte)(((HexCharToNibble(chararray[2 * i]) << 4)
                    & 0x0F) | ((HexCharToNibble(chararray[2 * i + 1]) & 0x0F)));
            }

            return array;
        }

        public int HexCharToNibble(char c)
        {

            byte value = (byte)c;

            if (value < 65)
            {
                value = (byte)(value - 48);
            }
            else
            {
                value = (byte)(value - 55);
            }

            return value;
        }

        public string NibbleToHexString(byte nib)
        {

            string s = "";

            if (nib < 10)
            {
                s = nib.ToString();
            }
            else
            {
                s = ((char)(nib + 55)).ToString();
            }

            return s;
        }
    }
}