using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityLesson
{
    class Lesson3_TimeComp
    {

        int FrogJump(int x,int y,int d)
        {
            if (y - x % d == 0)
                return (y - x) / d;
            return (y - x) / d + 1;

        }
        
    }
}
