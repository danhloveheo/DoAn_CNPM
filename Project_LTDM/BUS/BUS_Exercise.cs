using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class BUS_Exercise
    {
        public static int SaveExercise(int type, int finger, string name, string time, string[] lines)
        {
            DTO_Exercise exercise = new DTO_Exercise();
            exercise.ExerciseType = type;
            exercise.Finger = finger;
            exercise.Name = name;
            exercise.Time = int.Parse(time);
            exercise.Lines = lines;

            DAO_Exercise.InsertExercise(exercise);
            return 0;
        }
    }
}
