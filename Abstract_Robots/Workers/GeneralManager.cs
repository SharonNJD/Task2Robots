using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class GeneralManager : Worker
    {
        private double monthlysalary;
        private int NumOfRobots;

        public GeneralManager(string name, string id, DateTime bDate, string pass, double monthlysalary,int NumOfRobots)
            :base (name,id,bDate,pass)
        {
            this.monthlysalary = monthlysalary;
            this.NumOfRobots = NumOfRobots;
        }

        public override double Salary()
        {
            if (NumOfRobots > 30 )
            {
                return monthlysalary * 1.15;
            }
            return monthlysalary;
        }

    }
}
