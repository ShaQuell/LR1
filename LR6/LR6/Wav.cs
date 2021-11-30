using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    class Wav
    {
        MediaPlayer wavPlayer = new MediaPlayer();
        wavPlayer.Source = MediaSource.CreateFromUri(new Uri(@"C:\Users\admin\source\repos\media\0487374356.wav"));
        interface IRecordable
        {
            void Play()
            {
                wavPlayer.Play();
            }
            void Pause()
            {
                wavPlayer.Pause();
            }
            void Stop()
            {
                wavPlayer.Stop();
            }
        }
    }
}
