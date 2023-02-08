using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DecryptPDF();
        }
        public static void DecryptPDF()
        {

            string password = "drpepperissuperior";
            string fileName = "C:/Users/jbfai/Downloads/PO-encrypted.pdf";
            // Again, we need to convert (derive) our key from the string password.
            // We'll use a SHA256 hash again for this
            byte[] key = SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(password));

            // Let's read our bytes into a memory stream. If we were decrypting a file, we would probably use a Filestream
            // using MemoryStream memStream = new MemoryStream(cipherbytes);
            using FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            // Create our instance of the AES algorithm and set its properties
            using Aes aes = Aes.Create();
            aes.Mode = CipherMode.CBC; // Match the encryption mode with the encrypt method
            aes.Padding = PaddingMode.PKCS7; // Again, match the padding type with the encrypt method

            // In this case, we need to get the IV that was prepended to our encrypted data
            byte[] iv = new byte[aes.IV.Length]; // create an array of the proper length (default IV length is what we want)
            fs.Read(iv, 0, iv.Length); // read the IV from the beginning of our memory stream and populate our iv byte[]

            // We'll create a new cryptostream, this time with a Decryptor and in read mode
            using CryptoStream cryptStream = new CryptoStream(fs, aes.CreateDecryptor(key, iv), CryptoStreamMode.Read);

            // We're going to read the decrypted information from the cryptostream using a streamreader
            // StreamReader streamReader = new StreamReader(cryptStream);
            BinaryReader reader = new BinaryReader(cryptStream);


            byte[] allBytes = ReadAllBytes(reader);
            // string decryptedText = streamReader.ReadToEnd(); // Read all the way to the end and output as a string
            File.WriteAllBytes("C:/Users/jbfai/Downloads/PO-decrypted.pdf", allBytes);
            // return decryptedText;
        }
        public static byte[] ReadAllBytes(BinaryReader reader)
        {
            const int bufferSize = 4096;
            using (var ms = new MemoryStream())
            {
                byte[] buffer = new byte[bufferSize];
                int count;
                while ((count = reader.Read(buffer, 0, buffer.Length)) != 0)
                    ms.Write(buffer, 0, count);
                return ms.ToArray();
            }
        }
    }
}
