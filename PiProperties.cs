using System;
using System.Collections.Generic;
using System.Text;

namespace PiCalculation
{
    class PiFirstFrame
    {
        public string PiFirstStr { get; set; } = string.Empty;
        public int PiFirstInt { get; set; } = 0;
        
    }

    class PiSecondFrame
    {
        public string PiSecondStr { get; set; } = string.Empty;
        public int PiSecondInt { get; set; } = 0;
        
    }

    static class PiList
    {
        public static List<PiFirstFrame> PiFirstFrameList { get; set; } = new List<PiFirstFrame>();
        public static List<PiSecondFrame> PiSecondFrameList { get; set; } = new List<PiSecondFrame>();
    }
    
    class DoubleDigit
    {
        public List<string> DoubleDigitInit { get; set; } = new List<string>();

        private string[] digit = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        public List<string> DoubleDigitCalc()
        {
            foreach (var item1 in digit)
            {
                foreach(var item2 in digit)
                {
                    DoubleDigitInit.Add(item1 + item2);
                }
            }

            return DoubleDigitInit;
        }
    }
}
