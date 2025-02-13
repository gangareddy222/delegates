﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    public class VideoEncoder
    {

        public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        public event VideoEncodedEventHandler VideoEncoded=delegate { };
        public void Encocde(Video video)
        {


            Console.WriteLine("Encoding Video");
            Thread.Sleep(3000);

            OnVideoEncoded();
        }
        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }

        }
    }
}
