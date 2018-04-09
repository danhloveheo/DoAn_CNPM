using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Practice
    {
        private string _practiceType; // 1 là Finger Exercise, 2 là Text Exervise;

        //TODO : Thêm trường time vào file
        private int _time = 0;
        private string _name;
        private List<string> _practiceText = new List<string>();

        public string PracticeType
        {
            get
            {
                return this._practiceType;
            }
            set
            {
                this._practiceType = value;
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

        public List<string> PracticeText
        {
            get
            {
                return this._practiceText;
            }
            set
            {
                this._practiceText = value;
            }
        }
    }
}
