using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_Practice
    {
        static public DTO_Practice CreatePractice(DTO_LessonSection section)
        {
            DTO_Practice practice = new DTO_Practice();
            
            practice.Name = section.Name;

            if (section.Type == "Key")
            {
                practice.PracticeType = "Key";
            }
            else
            {
                practice.PracticeType = "Text";
            }

            practice.PracticeText = DAO_LessonSection.ReadPracticeDetailFromSection(section);

            return practice;
        }
    }
}
