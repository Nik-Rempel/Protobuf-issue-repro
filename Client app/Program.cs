using System;
using System.IO;

namespace Client_app
{
    class Program
    {
        static void Main(string[] args)
        {
            var stream = new MemoryStream();
            Library.ProtoBufTest.Serialize(stream);
        }
    }
}