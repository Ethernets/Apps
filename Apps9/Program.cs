namespace Apps9
{
    using System;

   public class Program
    {
      public static void Main(string[] args)
        {
            Player player = new Player();

            player.Play();

            player.Record();

            (player as IRecodable).Stop();

            (player as IPlayable).Stop();

            Console.ReadKey();
        }
    }
}
