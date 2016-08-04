namespace Apps9
{
    using System;

    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Play songs");
        }

        public void Record()
        {
            Console.WriteLine("Record something");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Pause() from IPlayable");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Stop() from IPlayable");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Pause() from IRecodable");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Stop() from IRecodable");
        }
    }
}
