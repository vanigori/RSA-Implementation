using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    public class CipherClass
    {
        public Object cipher { get; set; }
        public int[] key { get; set; }
        public byte[] byteKey { get; set; }
        public int seed { get; set; }

        public CipherClass(string cipher,  int[] key)
        {
            this.cipher = cipher;
            this.key = key;
        }

        public CipherClass(byte[] cipher, byte[] key)
        {
            this.cipher = cipher;
            this.byteKey = key;
        }
    }
}
