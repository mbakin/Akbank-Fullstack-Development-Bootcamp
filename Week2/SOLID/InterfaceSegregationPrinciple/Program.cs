using System;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *Each function should have an interface for its own purpose.
             *You have to implement an interface, but if a method of this interface is meaningless to you, that method should not depend on that interface.
             */
        }
    }

    public interface IMessage
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Body { get; set; }
        
        
       
       
    }
    public interface IVideoMessage : IMessage
    {
        public int Duration { get; set; }
    }
    public interface IImageMessage : IMessage
    {
        public string ImageFormat { get; set; }
        void SaveImage();
    }
    public interface IAudioMessage: IMessage
    {
        public byte[] SoundStream { get; set; }
    }
    public class VideoMessage : IVideoMessage
    {
        public string From { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string To { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Duration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class AudioMessage : IAudioMessage
    {
        public byte[] SoundStream { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string From { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string To { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Duration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
