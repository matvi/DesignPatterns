using System;
using System.Collections.Generic;
using System.Text;

namespace EventsDelegates
{
    public class MailService
    {
        //this class needs to be suscribed to the event

        //the method below has to have the same signature that the delegate
        public void OnVideodEncoded(object source, EventArgs e)
        {
            var videoArgs = e as VideoEventArgs;

            Console.WriteLine($"MailSErvice: sendig an email -> the video of {0} was succefully encoded ",videoArgs.Video.Name);
        }
    }
}
