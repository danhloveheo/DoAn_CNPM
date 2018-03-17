using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Exercise
    {
        private int _exerciseType; // 1 là Finger Exercise, 2 là Text Exervise;
        private int _finger; // 0 là TP, 1 là Thumb, 2 là Index, 3 là Middle, 4 là Ring, 5 là Pinky
        private int _time;
        private string _name;
        private string[] _lines;

        public int ExerciseType
        {
            get
            {
                return this._exerciseType;
            }
            set
            {
                this._exerciseType = value;
            }
        }

        public int Finger
        {
            get
            {
                return this._finger;
            }
            set
            {
                this._finger = value;
            }
        }

        public int Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        public string[] Lines
        {
            get
            {
                return this._lines;
            }
            set
            {
                this._lines = value;
            }
        }
    }
}
