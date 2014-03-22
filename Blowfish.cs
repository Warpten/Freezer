using System;
using System.Text;
using System.Security.Cryptography;

namespace Blowfish
{
    class Blowfish
    {
        private uint[] _s0;
        private uint[] _s1;
        private uint[] _s2;
        private uint[] _s3;
        
        private byte[] _key;
        
        private byte[] IV = { 0h00, 0h01, 0h02, 0h03, 0h04, 0h05, 0h06, 0h07, 0h08, 0h09, 0h0a, 0h0b, 0h0c, 0h0d, 0h0e, 0h0f };
    }
}
