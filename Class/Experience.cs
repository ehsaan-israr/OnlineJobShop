using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace  OnlineJobShop.Class
{
    public class Experience
    {
        string yearOfExperience;

        public string YearOfExperience
        {
            get { return yearOfExperience; }
            set { yearOfExperience = value; }
        }
        string post;

        public string Post
        {
            get { return post; }
            set { post = value; }
        }
        string technicalDetails;

        public string TechnicalDetails
        {
            get { return technicalDetails; }
            set { technicalDetails = value; }
        }
        string company;

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

    }
}