using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace  OnlineJobShop.Class
{
    public class EducationInfo
    {
        private string degree;

        public string Degree
        {
            get { return degree; }
            set { degree = value; }
        }
        private string toYear;

        public string ToYear
        {
            get { return toYear; }
            set { toYear = value; }
        }
        private string fromYear;

        public string FromYear
        {
            get { return fromYear; }
            set { fromYear = value; }
        }
        private string subjectMajor;

        public string SubjectMajor
        {
            get { return subjectMajor; }
            set { subjectMajor = value; }
        }
        private string grade;

        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        private string institue;

        public string Institue
        {
            get { return institue; }
            set { institue = value; }
        }

    }
}