using System;

namespace LiskovSubstitutionPrincible
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *Two objects that derive/inherit from a class must be able to replace each other and the parent object WITHOUT EXCEPTION.
             *you are breaking this principle if you write a special if or try catch on the object of each class that inherits from a class
             */

            DataWriter dataWriter = new DataWriter();
            // dataWriter.Write("test", new XMLDataSource());
            dataWriter.Write("test", new DBDataSource());
            dataWriter.Write("excell test", new ExcellDataSource());
        }

        public abstract class DataSource
        {
            public abstract string Read(string data);
        }
        public interface IDataWritable
        {
            void Write(string data);
        }

        public class XMLDataSource : DataSource
        {
            public override string Read(string data)
            {
                Console.WriteLine("Data read from XML");
                return string.Empty;
            }
        }
        public class DBDataSource : DataSource, IDataWritable
        {
            public override string Read(string data)
            {
                Console.WriteLine("Data read from DB");
                return string.Empty;
            }

            public void Write(string data)
            {
                Console.WriteLine("Data write from DB");
            }
        }
        public class ExcellDataSource : DataSource, IDataWritable
        {
            public override string Read(string data)
            {
                Console.WriteLine("Data read from Excell");
                return string.Empty;
            }

            public void Write(string data)
            {
                Console.WriteLine("Data write from Excell");
            }
        }
        public class DataWriter
        {
            public void Write(string data, IDataWritable dataSource)
            {
                dataSource.Write("data test");
            }
        }
    }
}
