using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class TeacherManager
    {
        public TeacherModel[] GetTeachers(int count)
        {
            TeacherModel[] teachers = new TeacherModel[count];
            Random rnd = new Random();
            for (int i = 0; i < teachers.Length; i++)
            {

                teachers[i] = new TeacherModel(rnd.Next(25, 80), $"tch-{i + 1}", DateTime.Now.Date, Guid.NewGuid());
            }
            return teachers;
        }
    }
}
