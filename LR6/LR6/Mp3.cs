using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    class Mp3
    {
        MediaPlayer mp3Player = new MediaPlayer();
        mp3Player.Source = MediaSource.CreateFromUri(new Uri(@"C:\Users\admin\source\repos\media\765465.mp3"));
        interface IPlayable
        {
            void Play()
            {
                mp3Player.Play();
            }
            void Pause()
            {
                mp3Player.Pause();
            }
            void Stop()
            {
                mp3Player.Stop();
            }
        }
    }
}
