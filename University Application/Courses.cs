﻿using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Application
{
    public class Courses
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Database_University.mdb";

        private int id;
        private string courseName;
        private int credits;
        private int hours;

        public int Id { get => id; set => id = value; }
        public string CourseName { get => courseName; set => courseName = value; }
        public int Credits { get => credits; set => credits = value; }
        public int Hours { get => hours; set => hours = value; }

        public Courses()
        {

        }
        public Courses(int id, string courseName, int credits, int hours)
        {
            this.Id = id;
            this.CourseName = courseName;
            this.Credits = credits;
            this.Hours = hours;
        }

        public Courses(string courseName, int credits, int hours)
        {
            this.CourseName = courseName;
            this.Credits = credits;
            this.Hours = hours;
        }

        public List<Courses> readCourses()
        {
            List<Courses> coursesList = new List<Courses>();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                OleDbCommand coursesTable = new OleDbCommand("SELECT * FROM Courses", connection);
                using (OleDbDataReader readerCoursesTable = coursesTable.ExecuteReader())
                {
                    while (readerCoursesTable.Read())
                    {
                        Courses course = new Courses(Convert.ToInt32(readerCoursesTable["Course_ID"]),
                            readerCoursesTable["Course_Name"].ToString(), Convert.ToInt32(readerCoursesTable["Credits"]),
                            Convert.ToInt32(readerCoursesTable["Hours"]));

                        coursesList.Add(course);
                    }
                }
            }
            return coursesList;
        }

        public override string ToString()
        {
            return this.Id + "," + this.CourseName + "," + this.Credits + "," + this.Hours;
        }
    }
}