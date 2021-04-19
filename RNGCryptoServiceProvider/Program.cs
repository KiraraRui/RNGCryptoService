using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RNGCryptoServiceProvider1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                stopwatch.Start();
                byte[] data = new byte[4];

                for (int i = 0; i < 10; i++)
                {
                    rng.GetBytes(data);

                    int value = BitConverter.ToInt32(data, 0);
                    Console.WriteLine("the value of RNGCryptoServiceProvider byte is " + value);
                    Console.WriteLine("the value of RNGCryptoServiceProvider base62 is" + Convert.ToBase64String(data));

                }
            }
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed.TotalMilliseconds);
            Console.WriteLine("----------------------------------------------------");

            var rand = new Random();
             {
                byte[] data = new byte[4];
                stopwatch.Start();
                var bytes = new byte[4];

                for (int i = 0; i < 10; i++)
                {
                    rand.NextBytes(bytes);


                    int value = BitConverter.ToInt32(bytes, 0);
                    Console.WriteLine("the value of Rand byte is " + value);
                    Console.WriteLine("the value of Rand base62 is " + Convert.ToBase64String(bytes));
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed.TotalMilliseconds);
            Console.ReadKey();


            Console.WriteLine("------------Press enter for Encryption---------------");


            Console.WriteLine("type a message to encrypt it.");
            string message = Console.ReadLine();

            Console.Write(Encrypter.Encrypt(message));
            





            Console.WriteLine("\n------------Press enter for decryption---------------");


            Console.WriteLine("type a message to decrypt it.");
            string demessage = Console.ReadLine();

            Console.Write(Encrypter.Dencrypt(demessage));



            Console.ReadKey();
        }
    }
}
