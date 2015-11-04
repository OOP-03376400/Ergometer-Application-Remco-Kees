using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgometerApplication
{
    class Test
    {
        private int timeCounter;
        private int[] powerStack;
        private int powerCounter =0;
        private string name;



        public Test(int timeCounter,int[]powerStack,string name)
        {
            this.timeCounter = timeCounter;
            this.powerStack = powerStack;
            this.name = name;
            
        }

        public int update(int timeInSec)
        {
            
            if(timeCounter*powerCounter> timeInSec)
            {
                timeCounter++;
                if (powerStack.Length >= powerCounter)
                powerCounter++;
                return powerStack[powerCounter-1];
            }
            else
            {
                return -1;
            }
        }
    }
}
