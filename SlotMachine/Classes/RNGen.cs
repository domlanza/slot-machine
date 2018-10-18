﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine.Classes
{
    class RNGen
    {
        private int[] pictureNum = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        int result;
        Random gen;

        public RNGen()
        {
            gen = new Random();
        }

        public int pickRandomNumber()
        {
            return result = gen.Next(0, pictureNum.Length);        
        }
    }
}