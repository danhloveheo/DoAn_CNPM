using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LessonSection
    {
        private string _name;
        private string _type;
        private string _detail;

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

        public string Type
        {
            get
            {
                return this._type;
            }

            set
            {
                this._type = value;
            }
        }

        public string Detail
        {
            get
            {
                return this._detail;
            }

            set
            {
                this._detail = value;
            }
        }
    }
}
