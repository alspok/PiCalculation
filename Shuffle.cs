using System;
using System.Collections.Generic;
using System.Text;

namespace PiCalculation
{
    static class ShufflePi
    {
        public static string ShuffleListPi()
        {
            List<string> shufflePiList = new List<string>();
            string shufflePiString = string.Empty;

            Random random = new Random();
            int randomIndex = 0;

            while (PiList.PiFirstFrameList.Count > 0)
            {
                randomIndex = random.Next(0, PiList.PiFirstFrameList.Count);
                shufflePiList.Add(PiList.PiFirstFrameList[randomIndex].PiFirstStr);
                PiList.PiFirstFrameList.RemoveAt(randomIndex);
                PiList.PiSecondFrameList.RemoveAt(randomIndex);
            }

            shufflePiString = string.Join("", shufflePiList);

            return shufflePiString;
        }
    }
}