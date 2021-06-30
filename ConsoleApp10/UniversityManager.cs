using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class UniversityManager
    {
        public TeacherModel[] SwapFromTeacherToStudent(TeacherModel[] teachers, List<StudentModel> students)
        {
            int studentsCount = students.Count / teachers.Length;
            int lastTeacherStCount = students.Count % teachers.Length + studentsCount;
            int filledTeacherCount = teachers.Length - 1;
            for (int i = 0; i < filledTeacherCount; i++)
            {
                teachers[i]._students = new StudentModel[studentsCount];
                for (int j = 0; j < studentsCount; j++)
                {
                    teachers[i]._students[j] = students[studentsCount * i + j];
                }
            }

            teachers[filledTeacherCount]._students = new StudentModel[lastTeacherStCount];

            for (int i = 0; i < lastTeacherStCount; i++)
            {
                teachers[filledTeacherCount]._students[i] = students[studentsCount * filledTeacherCount + i];
            }
            return teachers;
        }
        public List<StudentModel> SwapFromStudentToTeacher(TeacherModel[] teachers, List<StudentModel> students)
        {


            for (int i = 0; i < students.Count; i++)
            {
                Guid curStudentId = students[i]._id;
                for (int j = 0; j < teachers.Length; j++)
                {
                    for (int k = 0; k < teachers[j]._students.Length; k++)
                    {
                        if (curStudentId == teachers[j]._students[k]._id)
                        {
                            students[i]._teacher = teachers[j];
                        }

                    }
                }
            }

            return students;
        }
    }
}
