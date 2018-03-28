using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Lesson
    {
        private int _courseId;
        private string _name;
        private List<DTO_LessonSection> _sections;

        public int CourseId
        {
            get
            {
                return this._courseId;
            }

            set
            {
                this._courseId = value;
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

        public List<DTO_LessonSection> Sections
        {
            get
            {
                return this._sections;
            }

            set
            {
                this._sections = value;
            }
        }
    }
}
