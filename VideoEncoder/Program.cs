using System;
using System.Threading;

namespace VideoEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video {Title = "Terminator"};
            var encoder = new VideoEncoder();

            var emailService = new EmailService();
            var textService = new TextService();


            encoder.VideoEncoded += emailService.OnVideoEncoded;
            encoder.VideoEncoded += textService.OnVideoEncoded;

            encoder.Encode(video);
        }

        
    }

    public class VideoEncodedEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class TextService
    {
        public void Send(Video video)
        {
            Console.WriteLine($"Text has been sent for {video.Title}.");
        }

        public void OnVideoEncoded(object source, VideoEncodedEventArgs args)
        {
            Send(args.Video);
        }
    }
    public class EmailService
    {
        public void Send(Video video)
        {
            Console.WriteLine($"Email has been sent for {video.Title}");
        }
        
        public void OnVideoEncoded(object source, VideoEncodedEventArgs args)
        {
            Send(args.Video);
        }
    }
    public class Video
    {
        public string Title { get; set; }
    }

    public class VideoEncoder
    {
        //public delegate void VideoEncodedEventHandler(object source, VideoEncodedEventArgs args);

        //public event VideoEncodedEventHandler VideoEncoded;

        public EventHandler<VideoEncodedEventArgs> VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine($"Encoding {video.Title}...");

            Thread.Sleep(2000);

            VideoEncoded?.Invoke(this, new VideoEncodedEventArgs{ Video = video });
        }
    }
}
