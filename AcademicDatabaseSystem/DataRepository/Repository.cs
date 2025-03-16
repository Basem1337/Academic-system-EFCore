using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademicDatabaseSystem.Models;

namespace AcademicDatabaseSystem.DataRepository
{
    class Repository
    {
        public static List<Student> getStuds()
        {
            return new List<Student>()
            {
                new Student {St_ID = 1, St_FName = "Basem", St_LName = "Mohamed", St_Phone = "01016297668"},
                new Student {St_ID = 2, St_FName = "Amr", St_LName = "Hany", St_Phone = "01542197951"},
                new Student {St_ID = 3, St_FName = "Alaa", St_LName = "Eisa", St_Phone = "01111190922"},
                new Student {St_ID = 4, St_FName = "Hany", St_LName = "Abdou", St_Phone = "01004190041"},
                new Student {St_ID = 5, St_FName = "Omar", St_LName = "Al-Araby", St_Phone = "01204144070"},
                new Student {St_ID = 6, St_FName = "Mohamed", St_LName = "Hisham", St_Phone = "01100488122"},
                new Student {St_ID = 7, St_FName = "Mahmoud", St_LName = "Ahmed", St_Phone = "01010556101"},
                new Student {St_ID = 8, St_FName = "Karim", St_LName = "Helmy", St_Phone = "01550507768"},
                new Student {St_ID = 9, St_FName = "Basem", St_LName = "Atia", St_Phone = "01100557030"},
                new Student {St_ID = 10, St_FName = "Mohamed", St_LName = "Abdelwahab", St_Phone = "01004117122"},
            };
        }
        public static List<Instructor> getInsts()
        {
            return new List<Instructor>()
            {
                new Instructor {InsID = 1, InsFName = "Mohamed",InsLName = "Tharwat",Phone = "01016297668", Salary = 5000, Dept_ID = 1},
                new Instructor {InsID = 2, InsFName = "Mohamed",InsLName = "Hatem",Phone = "01004190041", Salary = 7500, Dept_ID = 1},
                new Instructor {InsID = 3, InsFName = "Mai",InsLName = "Moustafa",Phone = "01550507768", Salary = 4800, Dept_ID = 2},
                new Instructor {InsID = 4, InsFName = "Rami",InsLName = "Mohamed",Phone = "01010556101", Salary = 6000, Dept_ID = 1},
                new Instructor {InsID = 5, InsFName = "Hala",InsLName = "Nazmy",Phone = "01004117122", Salary = 8000, Dept_ID = 2},
                new Instructor {InsID = 6, InsFName = "Asmaa",InsLName = "Gomaa",Phone = "01100488122", Salary = 8000, Dept_ID = 3},
            };
        }
        public static List<Department> getDepts()
        {
            return new List<Department>()
            {
                new Department {Dept_ID = 1, Dept_Name = "SD", Dept_Location = "Ismailia Branch Building, 2nd Floor"},
                new Department {Dept_ID = 2, Dept_Name = "UI", Dept_Location = "Ismailia Branch Building, 2nd Floor"},
                new Department {Dept_ID = 3, Dept_Name = "MAD", Dept_Location = "Ismailia Branch Building, 2nd Floor"},
            };
        }
        public static List<Course> getCrs()
        {
            return new List<Course>()
            {
                new Course {CrsID = 1, CrsName = "HTML", CrsDuration = 2, InsID = 3, DeptID = 2},
                new Course {CrsID = 2, CrsName = "CSS", CrsDuration = 2, InsID = 3, DeptID = 2},
                new Course {CrsID = 3, CrsName = "C#", CrsDuration = 2, InsID = 1, DeptID = 1},
                new Course {CrsID = 4, CrsName = "OOP", CrsDuration = 2, InsID = 1, DeptID = 1},
                new Course {CrsID = 5, CrsName = "SQL", CrsDuration = 2, InsID = 4, DeptID = 1},
                new Course {CrsID = 6, CrsName = "OS", CrsDuration = 2, InsID = 2, DeptID = 1},
                new Course {CrsID = 7, CrsName = "Network", CrsDuration = 2, InsID = 2, DeptID = 2},
                new Course {CrsID = 8, CrsName = "JS", CrsDuration = 2, InsID = 3, DeptID = 2},
                new Course {CrsID = 9, CrsName = ".NET", CrsDuration = 2, InsID = 1, DeptID = 1},
                new Course {CrsID = 10, CrsName = "AngularJS", CrsDuration = 2, InsID = 5, DeptID = 3},
            };
        }
        public static List<CourseSession> getCrsSessions()
        {
            return new List<CourseSession>()
            {
                new CourseSession {CrsSID = 1, CrsID = 1,InsID = 3,Title = "Intro to HTML", Date = new DateTime(2020,5,4)},
                new CourseSession {CrsSID = 2, CrsID = 2,InsID = 3,Title = "Intro to CSS", Date = new DateTime(2023,11,11)},
                new CourseSession {CrsSID = 3, CrsID = 3,InsID = 1,Title = "Intro to C#", Date = new DateTime(2024,1,14)},
                new CourseSession {CrsSID = 4, CrsID = 4,InsID = 1,Title = "Intro to OOP", Date = new DateTime(2025,12,1)},
                new CourseSession {CrsSID = 5, CrsID = 5,InsID = 4,Title = "Intro to SQL", Date = new DateTime(2021,3,5)},
                new CourseSession {CrsSID = 6, CrsID = 10,InsID = 5,Title = "Intro to Angular", Date = new DateTime(2025,10,19)},
            };
        }
        public static List<CourseSessionAttendance> getCrsSessionAtts()
        {
            return new List<CourseSessionAttendance>()
            {
                new CourseSessionAttendance {CrsSAID = 1, StdID = 1,CrsSessionID = 1},
                new CourseSessionAttendance {CrsSAID = 2, StdID = 1,CrsSessionID = 2},
                new CourseSessionAttendance {CrsSAID = 3, StdID = 1,CrsSessionID = 3},
                new CourseSessionAttendance {CrsSAID = 4, StdID = 2,CrsSessionID = 5},
                new CourseSessionAttendance {CrsSAID = 5, StdID = 2,CrsSessionID = 4},
                new CourseSessionAttendance {CrsSAID = 6, StdID = 3,CrsSessionID = 1},
                new CourseSessionAttendance {CrsSAID = 7, StdID = 4,CrsSessionID = 2},
                new CourseSessionAttendance {CrsSAID = 8, StdID = 4,CrsSessionID = 6},
                new CourseSessionAttendance {CrsSAID = 9, StdID = 5,CrsSessionID = 6},
                new CourseSessionAttendance {CrsSAID = 10, StdID = 5,CrsSessionID = 3},
                new CourseSessionAttendance {CrsSAID = 11, StdID = 5,CrsSessionID = 2},
                new CourseSessionAttendance {CrsSAID = 12, StdID = 5,CrsSessionID = 1},
            };
        }
        public static List<StdCrs> getStdCrs()
        {
            return new List<StdCrs>()
            {
                new StdCrs {StdID = 1,CrsID = 1},
                new StdCrs {StdID = 1,CrsID = 2},
                new StdCrs {StdID = 1,CrsID = 3},
                new StdCrs {StdID = 2,CrsID = 5},
                new StdCrs {StdID = 2,CrsID = 4},
                new StdCrs {StdID = 3,CrsID = 1},
                new StdCrs {StdID = 4,CrsID = 10},
                new StdCrs {StdID = 4,CrsID = 6},
                new StdCrs {StdID = 5,CrsID = 6},
                new StdCrs {StdID = 5,CrsID = 7},
                new StdCrs {StdID = 5,CrsID = 2},
                new StdCrs {StdID = 5,CrsID = 1},
            };
        }
    }
}
