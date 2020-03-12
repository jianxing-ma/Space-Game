using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Game
{
    class Fight
    {
        public List<double> stat;
        // stat = {0: age, 1: money, 2: health, 3: amunition, 4: level, 5: experience, 
        //         6: item 1, 7: item 2, 8: item 3, 9: item 4, 10: item 5}
        public Fight(List<double> stat)
        {
            this.stat = stat;
        }

        public List<string> Enemy = new List<string>() { "1", "2" };




    }
}
