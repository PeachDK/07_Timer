using System;
namespace _07_Timer
{
    internal class Timer
    {  
    
        public int Seconds;   
        public override string ToString()
        {
            TimeSpan time = TimeSpan.FromSeconds(Seconds);
            string str = time.ToString(@"hh\:mm\:ss");
            return str;
        }

        internal string Padded(int v)
        {
            TimeSpan time = TimeSpan.FromSeconds(v);
            string str = time.ToString(@"ss");
            return str;
        }
    }
}