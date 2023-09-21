using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public abstract class Worker
    {
        private string fullName;
        private string idNumber;
        private DateTime birthDate;
        private string password;


        public Worker(string name, string id, DateTime bDate, string pass)
        {
            fullName = name;
            idNumber = id;
            birthDate = bDate;
            password = pass;
        }
        public string FullName { get { return fullName; } set { this.fullName = value; } }
        public string GetfullName() { return fullName; }
        public string GetidNumber() { return idNumber; }
        public DateTime GetbirthDate() { return birthDate; }
        public string Getpassword() { return password; }
        public void SetfullName(string fullName) {this.fullName = fullName; }
        public void SetidNumber(string idNumber) {this.idNumber = idNumber; }
        
        public void Set(string password) {this.password = password; }


        public abstract double Salary();

        public override string ToString()
        {
            string str = "";
            if(birthDate.Equals(DateTime.Today))
                str=" - HappyBirthDay";
            return fullName + " ID." + idNumber + str;

        }
    }
}
