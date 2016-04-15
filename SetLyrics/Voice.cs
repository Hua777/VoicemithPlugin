using HUtau;
using System.IO;
using System.Media;
using NAudio.Wave;

namespace SetLyrics
{
    class Voice
    {
        static private bool eggProcessing = false;
        static private DirectSoundOut eggOutput = new DirectSoundOut();
        static private System.Timers.Timer eggTimer = new System.Timers.Timer(10);
        static private WaveFileReader eggWFR = null;

        /// <summary>
        /// 發出講話聲
        /// </summary>
        /// <param name="_ppfix">Note 發音記號</param>
        static public void Talk(PPFixName _ppfix)
        {
            string _path = "wav/" + ((int)_ppfix).ToString() + ".wav";
            if (File.Exists(_path) && !eggProcessing)
            {
                SoundPlayer sp = new SoundPlayer(_path);
                sp.Play();
            }
        }

        /// <summary>
        /// 彩蛋
        /// </summary>
        static public void Egg()
        {
            string _path = "wav/egg.wav";
            if (File.Exists(_path) && !eggProcessing)
            {
                eggProcessing = true;
                eggTimer.Elapsed += EggTimer_Elapsed;
                eggWFR = new WaveFileReader(_path);
                eggOutput.Init(new WaveChannel32(eggWFR));
                eggOutput.Play();
                eggTimer.Start();
            }
        }

        private static void EggTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (eggWFR != null && eggWFR.Position >= eggWFR.Length)
            {
                eggProcessing = false;
                eggTimer.Stop();
            }
        }
    }
}
