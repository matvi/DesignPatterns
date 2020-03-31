using System;

namespace EventsDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video()
            {
                Name = "Nemo"
            };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber

            //we subscribe the mailService to the event
            //register the handler to the event. The handler is the ONVideoEncoder in the mailService class
            videoEncoder.VideoEncoded += mailService.OnVideodEncoded;

            videoEncoder.Encode(video);

            

        }
    }
}
