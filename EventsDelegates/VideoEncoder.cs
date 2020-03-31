using System;
using System.Collections.Generic;
using System.Text;

namespace EventsDelegates
{
    public class VideoEncoder
    {
        //1.- Definde a delegate
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs videoEvent);
        //2 Define an evente based on that delegate
        //public event VideoEncodedEventHandler VideoEncoded;
        


        //Event handler step 1 and 2 in one line using EventHandler
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public VideoEncoder()
        {
            
        }
        public void Encode(Video video)
        {
            Console.WriteLine("Endogin Video");

            //3.- Raise the event.
            //notify all the susbcribers
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs { Video = video });
            }
        }
    }
}
