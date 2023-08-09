using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._Stream
{
    
        class CustomBufferedStreamWriter : StreamWriter
        {
            private char[] customBuffer;

            public CustomBufferedStreamWriter(string path, int bufferSize) : base(path)
            {
                customBuffer = new char[bufferSize];
            }

         
        }
    
}
