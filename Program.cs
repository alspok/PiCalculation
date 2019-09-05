using System;
using System.Diagnostics;
using System.IO;

namespace PiCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //string fileName = @"C:\Users\alvydas\Documents\Constants\Pi_10mln.txt";
            //string fileName = @"C:\Users\alvydas\Documents\Constants\E_2mln.txt";
            string fileName = @"C:\Users\alvydas\Documents\Constants\2sqrt_10mln.txt";

            int stringLength = 100000;
            int shuffleNumber = 10;

            string pi = File.ReadAllText(fileName);
            pi = pi.Substring(2).Replace("\r\n", "").Replace(" ", "").Substring(0, stringLength);

            Console.WriteLine(fileName);
            Console.WriteLine(pi.Substring(0, 100) + "......\n");
            Console.WriteLine("Seq length " + pi.Length + "\n");

            PiFrame piFrameInit = new PiFrame(pi);
            piFrameInit.PiFrameList();

            PiCount piFrameCount = new PiCount();
            piFrameCount.PiFrameCount();

            for (int i = 0; i < shuffleNumber; i++)
            {
                var sufflePi = ShufflePi.ShuffleListPi();

                Console.WriteLine($"\nShuffle Pi {i + 1}\n");

                PiFrame piShuffleFrameInit = new PiFrame(sufflePi);
                piShuffleFrameInit.PiFrameList();

                PiCount shufflePipiFrameCount = new PiCount();
                shufflePipiFrameCount.PiFrameCount();
            }

            stopwatch.Stop();
            Console.WriteLine("Time taken: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);

            Console.ReadLine(); ;
        }
    }
}
