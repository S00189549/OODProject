using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_project
{
    public enum ExerciseType { Chest, Back , Bicep , Tricep ,Shoulders, Quads ,Hamstrings , Glutes , Calves , Forearms }

    public class Exercise  
    {
        public string exerciseName { get; set; }

        public string notes { get; set; }

        public string description { get; set; }

    }
}
