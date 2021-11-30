using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    class Mkv
    {
        MediaPlayer mkvPlayer = new MediaPlayer();
        mkvPlayer.Source = MediaSource.CreateFromUri(new Uri(@"C:\Users\admin\source\repos\media\152983.mkv"));
        interface IMedia
        {
            void Play() 
            {
                mkvPlayer.Play();
            }
            void Pause() 
            {
                mkvPlayer.Pause();
            }
            void Stop() 
            {
                mkvPlayer.Stop();
            }
        }
    }
}
