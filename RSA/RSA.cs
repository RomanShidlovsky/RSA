using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA
{
    public static class RSA
    {
        static ushort Power(int a, int n, int p)
        {
            // Initialize result
            ushort res = 1;

            // Update 'a' if 'a' >= p
            a = a % p;
            uint k = (uint)a;
            while (n > 0)
            {
                // If n is odd, multiply 'a' with result
                if ((n & 1) == 1)
                    res = (ushort)((res * k) % p);

                // n must be even now
                n = n >> 1; // n = n/2
                k =(uint)(k * k % p);
            }

            return (ushort)(res % p);
        }

        public static int GcdExtended(int a, int b, ref int x, ref int y)
        {
            // Base Case
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }

            // To store results of
            // recursive call
            int x1 = 1, y1 = 1;
            int gcd = GcdExtended(b % a, a, ref x1, ref y1);

            // Update x and y using
            // results of recursive call
            x = y1 - (b / a) * x1;
            y = x1;

            return gcd;
        }

        public static bool IsPrime(int n, int k)
        {
            // Corner cases
            if (n <= 1 || n == 4) return false;
            if (n <= 3) return true;

            // Try k times
            while (k > 0)
            {
                // Pick a random number in [2..n-2]    
                // Above corner cases make sure that n > 4
                Random rand = new Random();
                int a = 2 + (int)(rand.Next() % (n - 4));

                // Fermat's little theorem
                if (Power(a, n - 1, n) != 1)
                    return false;

                k--;
            }

            return true;
        }

        public static (int, int, int) GenerateKey(int p, int q, int d)
        {
            try
            {
                int n = checked(p * q);
                int f = checked((p - 1) * (q - 1));


                int x1 = 1;
                int y1 = 1;
                GcdExtended(d, f     , ref x1, ref y1);
                int e = x1;

                if (e < 0)
                    e += f;

                return (e, n, d);
            }
            catch (Exception e)
            {
               // Console.WriteLine(e.Message);
                return (0, 0, 0);
            }
        }

        public static ushort[] Encrypt(byte[] plaintext, int e, int n)
        {
            ushort[] ciphertext = new ushort[plaintext.Length];
            int i = 0;
            foreach (byte x in plaintext)
            {
                ciphertext[i] = Power(x, e, n);
                i++;
            }
            return ciphertext;
        }

        public static byte[] Decrypt(ushort[] ciphertext, int d, int n)
        {
            byte[] plaintext = new byte[ciphertext.Length];
            int i = 0;
            foreach (ushort y in ciphertext)
            {
                plaintext[i] = Convert.ToByte(Power(y, d, n));
                i++;
            }
            return plaintext;
        }





    }
}
