using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ssc_lab3_tema
{
    internal class MACHandler
    {
        private HMAC myMAC;
        private HashAlgorithm myHASH;

        public MACHandler(string name)
        {
            if (name.CompareTo("SHA1") == 0){
                myMAC = new System.Security.Cryptography.HMACSHA1();
                myHASH = new SHA1CryptoServiceProvider();
            }
            if (name.CompareTo("MD5") == 0){
                myMAC = new System.Security.Cryptography.HMACMD5();
                myHASH = new MD5CryptoServiceProvider();
            }
            if (name.CompareTo("RIPEMD") == 0){
                myMAC = new System.Security.Cryptography.HMACRIPEMD160();
            }
            if (name.CompareTo("SHA256") == 0){
                myMAC = new System.Security.Cryptography.HMACSHA256();
                myHASH = new SHA256CryptoServiceProvider();
            }
            if (name.CompareTo("SHA384") == 0){
                myMAC = new System.Security.Cryptography.HMACSHA384();
                myHASH = new SHA384CryptoServiceProvider();
            }
            if (name.CompareTo("SHA512") == 0){
                myMAC = new System.Security.Cryptography.HMACSHA512();
                myHASH = new SHA512CryptoServiceProvider();
            }
        }

        public bool CheckAuthenticity(byte[] mes, byte[] mac, byte[] key)
        {
            myMAC.Key = key;

            if (CompareByteArrays(myMAC.ComputeHash(mes), mes, myMAC.HashSize / 8) == true)
                return true;
            else
                return false;
        }

        private bool CompareByteArrays(byte[] a, byte[] b, int len)
        {
            for (int i = 0; i < len; i++)
                if (a[i] != b[i])
                    return false;
            return true;
        }

        public byte[] ComputeMAC(byte[] mes, byte[] key)
        {
            myMAC.Key = key;
            return myMAC.ComputeHash(mes);
        }

        public byte[] ComputeHASH(byte[] mess, byte[] key)
        {
            return myHASH.ComputeHash(mess);
        }

        public int MACByteLength()
        {
            return myMAC.HashSize / 8;
        }
    }
}