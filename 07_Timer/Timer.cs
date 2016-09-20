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
    }
}