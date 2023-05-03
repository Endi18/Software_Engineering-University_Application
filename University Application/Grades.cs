﻿using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace University_Application
{
    public class Grades
    {
        private String connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Database_University.mdb"

  
        private int gradeId;
        private int courseId;
        private int studentid;
        private int score;

        public int Grade { get => gradeId; set => gradeId = value; }
        public int Course { get => courseId; set => courseId = value; }
        public int Student { get => studentid; set => studentid = value; }
        public int Score { get => score; set => score = value; }


        public Grades(int gradeId, int subjectId, int studentId, int score)
        {
            Grade = gradeId;
            Course = subjectId;
            Student = studentId;
            Score = score;
        }


        public Grades() { }

        public List<Grades> readGrades()
        {
            List<Grades> list = new List<Grades> ();
            OleDbConnection con = new OleDbConnection(connection);
            if (con.State != System.Data.ConnectionState.Open) {
                con.Open();
            }

            String sql = "SELECT * FROM Grades";

            OleDbCommand cmd = new OleDbCommand(sql, con);
            OleDbDataReader reader = cmd.ExecuteReader();


            if (reader.HasRows)
            {
                Grades grade = new Grades(Convert.ToInt32(reader["Grade_Id"]), Convert.ToInt32(reader["Course_ID"]), Convert.ToInt32(reader["Student_ID"]), Convert.ToInt32(reader["Grade_Score"]));
                list.Add(grade);
            }
            reader.Close();
            return list;
        }

        public override string ToString()
        {
            return this.Student + ", " + this.Grade;
        }
    }
}