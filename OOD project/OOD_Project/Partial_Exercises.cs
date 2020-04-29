using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
   partial class tbl_Exercises
   {
        public string Image { get { return Name + ".png"; } }
   }

    partial class tbl_Workout
    {
        public string Name { get; set; }

        public string Variations { get
            {
                string result = "";
                if ((bool)TUT)
                    result += "T.U.T\n";
                if ((bool)Pause)
                    result += "Pause\n";
                if ((bool)C1_5xReps)
                    result += "1.5 Reps\n";
                return result;
            }
        }
    }
}
