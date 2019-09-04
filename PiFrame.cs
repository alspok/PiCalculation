using System;
using System.Collections.Generic;
using System.Linq;

namespace PiCalculation
{
    class PiFrame
    {
        public string pi;

        public PiFrame(string pi)
        {
            this.pi = pi;
        }

        public void PiFrameList()
        {
            string subPi;

            while(this.pi.Length > 2)
            {
                PiFirstFrame piFirst = new PiFirstFrame();

                subPi = this.pi.Substring(0, 2);
                piFirst.PiFirstStr = subPi;

                piFirst.PiFirstInt = Convert.ToInt32(subPi);
                PiList.PiFirstFrameList.Add(piFirst);

                PiSecondFrame piSecond = new PiSecondFrame();

                subPi = this.pi.Substring(1, 2);
                piSecond.PiSecondStr = subPi;

                piSecond.PiSecondInt = Convert.ToInt32(subPi);
                PiList.PiSecondFrameList.Add(piSecond);

                this.pi = this.pi.Substring(2);
            }
        }
    }
}
