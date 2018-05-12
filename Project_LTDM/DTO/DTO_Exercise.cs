using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Exercise
    {
        
        private string _exerciseType; // Gồm Key, Word, Sentence, Paragraph

        private int _time=0;
        private string _title;
        private string _FileName;
        private List<string> _exerciseText = new List<string>();
        private int _timeleft=0;
        private int _position=0;
        private int _Star=0;
        private bool _isLesson = false; //Kiểm tra xem object đang xét có đc tạo từ file Courses.xml hay không

        public DTO_Exercise()
        {

        }
        
        public DTO_Exercise (string type, int time, string title, List<string> text, string fileName,int timeleft, int position, int star)
        {
            this._exerciseType = type;
            this._time = time;
            this._title = title;
            this._exerciseText = text;
            this._FileName = fileName;
            this._timeleft = timeleft;
            this._position = position;
            this._Star = star;
        }
        //public DTO_Exercise(string type, int time, string title, List<string> text)
        //{
        //    this._exerciseType = type;
        //    this._time = time;
        //    this._title = title;
        //    this._exerciseText = text;
        //    this._FileName = Guid.NewGuid().ToString() + ".txt";
        //}

        public string ExerciseType
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
        public int Timeleft
        {
            get
            {
                return this._timeleft;
            }
            set
            {
                this._timeleft = value;
            }
        }

        public int Position
        {
            get
            {
                return this._position;
            }
            set
            {
                this._position = value;
            }
        }

        public int Star
        {
            get
            {
                return this._Star;
            }
            set
            {
                this._Star = value;
            }

        }

        public string Title
        {
            get
            {
                return this._title;
            }
            set
            {
                this._title = value;
            }
        }

        public List<string> ExerciseText
        {
            get
            {
                return this._exerciseText;
            }
            set
            {
                this._exerciseText = value;
            }
        }

        public string FileName
        {
            get
            {
                return this._FileName;
            }
            set
            {
                this._FileName = value;
            }
        }

        public bool IsLesson
        {
            get
            {
                return this._isLesson;
            }
            set
            {
                this._isLesson = value;
            }
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
