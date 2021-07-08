using System;
using System.IO;

namespace AbstractVSInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream = new FileStream("", FileMode.Create);
            MemoryStream memoryStream = new MemoryStream();
            Stream stream = fileStream;



            Personel worker = new Personel();
            worker.Address = new HomeAddress();
            worker.Address = new BussinessAddress() { X = 34, Y = 24 };
            
            
            Console.WriteLine(worker.Address);
        }
    }

    public abstract class MyStream
    {
        // FileStream
        // MemoryStream
        // NetworkStream

        // Data must be able to be read and written from a stream. However, these operations are done differently in each stream.
        public abstract void Write(byte[] data);
        public abstract byte[] Read();

        public void Copy(string from, string to)
        {
            Console.WriteLine("Copied");
        }
    }
    public class PageStream : MyStream
    {
        public override byte[] Read()
        {
            throw new NotImplementedException();
        }

        public override void Write(byte[] data)
        {
            throw new NotImplementedException();
        }
    }

    public class RAMStream : MyStream
    {
        public override byte[] Read()
        {
            throw new NotImplementedException();
        }

        public override void Write(byte[] data)
        {
            throw new NotImplementedException();
        }
    }
}
