using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeInserts.Models
{
    public class Grade 
    {
        private int id;
        private int grade;
        public int GetGrade()
        {
            return grade;
        }
    }



    public class Students
    {
        private string name;
        private int tz;
        private int year;
        NodeClass.Node<Grade> grades;

        public string GetName()
        { return name; }
        public int GetYear() 
        { return year; }
        public int GetTz()
        { return tz; }
        public NodeClass.Node<Grade> GetList() 
        { return grades; }
        public double Average()
        {
            int total = 0;
            int num = 0;
            while (this.grades != null)
            {
                num++;
                total += grades.GetValue().GetGrade();
                grades = grades.GetNext();
            }
            return (double) num/total;  
        }
    }
}
