using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine.Classes
{
    class LookupTable
    {
        Dictionary<int, int> slotValues = new Dictionary<int, int>()
        {
            // Three Ts
            {111, 200 },
            {222, 100 },
            {333, 60 },
            // Any Three Ts
            {123, 30 },
            {132, 30 },
            {213, 30 },
            {231, 30 },
            {321, 30 },
            {312, 30 },
            {112, 30 },
            {113, 30 },
            {221, 30 },
            {223, 30 },
            {331, 30 },
            {332, 30 },
            // Owls
            {555, 50 },
            {666, 75 },
            // Any Owls
            {777, 10 },
            // Any 2 with Red T
            {888, 5 },
            // Any 1 with 1 Red T
            {999, 2 }
        };
    }
}
