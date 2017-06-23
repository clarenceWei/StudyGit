using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace Nui.MallInfo.Utility
{
    public class MD5Cryptography
    {
        private static string _key = "soldiinfo";
        private static string _iv = "soldiinfo";

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="realMsg">需加密的明文</param>
        /// <param name="key">加密标准算法的机密密钥</param>
        /// <param name="iv">对称算法的初始化向量</param>
        /// <returns>加密后密码的16进制表示</returns>
        public static string MD5Encrypt(string realMsg)
        {
            if (string.IsNullOrEmpty(realMsg))
            {
                return null;
            }
            string key = _key;
            string iv = _iv;
            string sKey = key.PadLeft(8, '0');
            string sIV = iv.PadLeft(8, '0');
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = Encoding.Default.GetBytes(realMsg);
            des.Key = ASCIIEncoding.ASCII.GetBytes(sKey.Substring(0, 8));
            des.IV = ASCIIEncoding.ASCII.GetBytes(sIV.Substring(0, 8));
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            try
            {
                cs.FlushFinalBlock();
            }
            catch //(Exception err)
            {
                return realMsg;
            }
            StringBuilder ret = new StringBuilder();
            foreach (byte b in ms.ToArray())
            {
                ret.AppendFormat("{0:X2}", b);
            }
            ret.ToString();
            return ret.ToString();
        }

        /// <summary>
        /// MD5解密,对MD5Encrypt的加密内容进行解密
        /// </summary>
        /// <param name="encryptedMsg">已经加密的密码密文</param>
        /// <param name="key">加密标准算法的机密密钥</param>
        /// <param name="iv">对称算法的初始化向量</param>
        /// <returns></returns>
        public static string MD5Decrypt(string encryptedMsg)
        {
            string key = _key;
            string iv = _iv;
            string sKey = key.PadLeft(8, '0');
            string sVI = iv.PadLeft(8, '0');
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = new byte[encryptedMsg.Length / 2];
            for (int x = 0; x < encryptedMsg.Length / 2; x++)
            {
                int i = Convert.ToInt32(encryptedMsg.Substring(x * 2, 2), 16);
                inputByteArray[x] = (byte)i;
            }
            des.Key = ASCIIEncoding.ASCII.GetBytes(sKey.Substring(0, 8));
            des.IV = ASCIIEncoding.ASCII.GetBytes(sVI.Substring(0, 8));
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            try
            {
                cs.FlushFinalBlock();
            }
            catch//(Exception err)
            {
                return encryptedMsg;
            }
            StringBuilder ret = new StringBuilder();
            return System.Text.Encoding.Default.GetString(ms.ToArray());
        }
    }
}