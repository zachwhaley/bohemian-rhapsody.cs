using System;

namespace queen
{
    class Program
    {
        static void Main(string[] args)
        {
            try { new BohemianRhapsody(); }
            catch (EndSongException) { }
        }
    }
}