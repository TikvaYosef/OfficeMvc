using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OfficeMvc.Models
{


    public class Employye
    {


        public string name;
        public string birthday;
        public string email;
        public int salery;

        public Employye(string name, string birthday, string email, int salery)
        {
            this.name = name;
            this.birthday = birthday;
            this.email = email;
            this.salery = salery;
        }
    }
}