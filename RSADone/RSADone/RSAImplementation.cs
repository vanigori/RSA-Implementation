using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RSADone
{
    class RSAImplementation
    {
        //Public component
        private BigInteger e;
        //Private component
        private BigInteger d;
        //Prime numbers
        private BigInteger p, q;
        //Multiplication of p, q -> Used as modulus for pri/pub keys -> Length is key length
        private BigInteger n;
        //Carmichael's totient function
        private BigInteger ctf;
        // Tmep varialbe, unneeded here tbh
        private byte[] randomNumbers;


        public int getKeyLength()
        {
            return n.ToString().Length;
        }

        // Multiplicative Inverse function
        private BigInteger mul_inv(BigInteger a, BigInteger b)
        {
            BigInteger b0 = b, t, q;
            BigInteger x0 = BigInteger.Zero, x1 = BigInteger.One;
            if(BigInteger.Compare(b, BigInteger.One) == 0)
                return BigInteger.One;
            while(BigInteger.Compare(a, BigInteger.One) == 1)
            {
                q = BigInteger.Divide(a, b);
                t = b;
                b = BigInteger.Remainder(a, b);
                a = t;
                t = x0;
                x0 = BigInteger.Subtract(x1, BigInteger.Multiply(q, x0));
                x1 = t;
            }
            if (BigInteger.Compare(x1, BigInteger.Zero) == -1)
                x1 = BigInteger.Add(x1, b0);
            return x1;
        }

        // Least Common multiple
        private BigInteger LCM(BigInteger a, BigInteger b)
        {
            return BigInteger.Divide(BigInteger.Multiply(a, b), BigInteger.GreatestCommonDivisor(a, b));
        }

        private bool IsProbablePrime(BigInteger source, int certainty)
        {
            if(BigInteger.Compare(source, BigInteger.Add(BigInteger.One, BigInteger.One)) == 0 || BigInteger.Compare(source, BigInteger.Add(BigInteger.Add(BigInteger.One, BigInteger.One), BigInteger.One)) == 0)
                return true;
            if(BigInteger.Compare(source, BigInteger.Add(BigInteger.One, BigInteger.One)) == -1 || BigInteger.Remainder(source, BigInteger.Add(BigInteger.One, BigInteger.One)) == 0)
                return false;

            BigInteger d = BigInteger.Subtract(source, BigInteger.One);
            int s = 0;

            while(BigInteger.Compare(BigInteger.Remainder(d, BigInteger.Add(BigInteger.One, BigInteger.One)), BigInteger.Zero) == 0)
            {
                d = BigInteger.Divide(d, BigInteger.Add(BigInteger.One, BigInteger.One));
                s += 1;
            }

            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            byte[] bytes = new byte[source.ToByteArray().Length];
            BigInteger a;

            for(int i = 0; i < certainty; i++)
            {
                do
                {
                    rng.GetBytes(bytes);
                    a = new BigInteger(bytes);
                }
                while(BigInteger.Compare(a, BigInteger.Add(BigInteger.One, BigInteger.One)) == -1 || BigInteger.Compare(a, BigInteger.Subtract(source, BigInteger.Add(BigInteger.One, BigInteger.One))) >= 0 );

                BigInteger x = BigInteger.ModPow(a, d, source);
                if(BigInteger.Compare(x, BigInteger.One) == 0 || BigInteger.Compare(x, BigInteger.Subtract(source, BigInteger.One)) == 0)
                    continue;

                for(int r = 1; r < s; r++)
                {
                    x = BigInteger.ModPow(x, BigInteger.Add(BigInteger.One, BigInteger.One), source);
                    if(BigInteger.Compare(x, BigInteger.One) == 0)
                        return false;
                    if(BigInteger.Compare(x, BigInteger.Subtract(source, BigInteger.One)) == 0)
                        break;
                }

                if(BigInteger.Compare(x, BigInteger.Subtract(source, BigInteger.One)) != 0)
                    return false;
            }
            return true;
        }

        // https://en.wikipedia.org/wiki/RSA_(cryptosystem)#Key_generation
        public void generateKeys()
        {
            Console.WriteLine("\nStep 1.1");
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            do
            {
                randomNumbers = new byte[64];
                rng.GetBytes(randomNumbers);
                p = new BigInteger(randomNumbers);
                p = BigInteger.Abs(p);
            } while (!IsProbablePrime(p, 10));
            Console.WriteLine("p: " + p.ToString());

            Console.WriteLine("\nStep 1.2");
            do
            {
                randomNumbers = new byte[64];
                rng.GetBytes(randomNumbers);
                q = new BigInteger(randomNumbers);
                q = BigInteger.Abs(q);
            } while (!IsProbablePrime(p, 10));
            Console.WriteLine("q: " + q.ToString());
            rng.Dispose();
            randomNumbers = new byte[1];

            Console.WriteLine("\nStep 2");
            n = BigInteger.Multiply(p, q);
            Console.WriteLine("n: " + n.ToString());

            Console.WriteLine("\nStep 3");
            ctf = LCM(BigInteger.Add(p, BigInteger.MinusOne), BigInteger.Add(q, BigInteger.MinusOne));
            Console.WriteLine("ctf: " + ctf.ToString());

            // Possible mistake here, review with internet
            Console.WriteLine("\nStep 4");
            rng = new RNGCryptoServiceProvider();
            do
            {
                byte[] tempBytes = ctf.ToByteArray();
                rng.GetBytes(tempBytes);
                e = new BigInteger(tempBytes);
                e = BigInteger.Abs(e);
            } while (!(BigInteger.Compare(BigInteger.GreatestCommonDivisor(e, ctf), BigInteger.One) == 0));
            Console.WriteLine("e: " + e.ToString());
            rng.Dispose();

            Console.WriteLine("\nStep 5");
            d = mul_inv(e, ctf);
            Console.WriteLine("d: " + d.ToString());
        }

        public BigInteger getPubKey()
        {
            return e;
        }

        public BigInteger getPrivKey()
        {
            return d;
        }

        public BigInteger encrypt(string toEncrypt)
        {
            BigInteger m = new BigInteger(Encoding.UTF8.GetBytes(toEncrypt));
            return BigInteger.ModPow(m, e, n);
        }

        public string decrypt(BigInteger toDecrypt)
        {
            BigInteger c = toDecrypt;
            return Encoding.UTF8.GetString(BigInteger.ModPow(c, d, n).ToByteArray());
        }

        static void Main(string[] args)
        {
            RSAImplementation rsa = new RSAImplementation();
            rsa.generateKeys();
            Console.WriteLine("Key size: " + rsa.getKeyLength());
            Console.WriteLine("Private key:\n" + rsa.getPrivKey() + "\nPublic key:\n" + rsa.getPubKey());
            Console.WriteLine("Enter text to encrypt:");
            string input = Console.ReadLine();
            Console.WriteLine("Encrypted: " + rsa.encrypt(input).ToString() + "\n\nDecrypted: " + rsa.decrypt(rsa.encrypt(input)));
            Console.ReadKey();
        }
    }
}
