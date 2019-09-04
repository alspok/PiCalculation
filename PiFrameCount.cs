using System;
using System.Collections.Generic;
using System.Text;

namespace PiCalculation
{
    class PiCount
    {
        public void PiFrameCount()
        {
            DoubleDigit doubleDigit = new DoubleDigit();
            var diList = doubleDigit.DoubleDigitCalc();

            int piFirstCountSum = 0;
            int piSecondCountSum = 0;
            double piDiffSum = 0;

            foreach (var item in diList)
            {
                var piFirstCount = PiList.PiFirstFrameList.FindAll(pi => pi.PiFirstStr == item);
                piFirstCountSum += piFirstCount.Count;


                var piSecundCount = PiList.PiSecondFrameList.FindAll(pi => pi.PiSecondStr == item);
                piSecondCountSum += piSecundCount.Count;


                var piFrameListLength = PiList.PiFirstFrameList.Count;

                var frameDiff = Math.Abs(piFirstCount.Count - piSecundCount.Count);
                var piDiff = Math.Round(((double)frameDiff / (double)piFrameListLength), 4);
                piDiffSum += piDiff;

                Console.Write($"{item}\t{piFirstCount.Count}\t{piSecundCount.Count}\t{frameDiff}\t");
                Console.WriteLine(piDiff);
            }

            Console.WriteLine("\nSum:\t" + piFirstCountSum  + "\t" + piSecondCountSum + "\t\t" + piDiffSum);
        }

        public void PiSecondFrameCount()
        {

        }

    }
}
