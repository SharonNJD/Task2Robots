using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class OperationManager : Worker
    {
        private double Hourlywage;
        private int Hours;
        private int tasksCompleted;
       


        public OperationManager(string name, string id, DateTime bDate, string pass,double Hourlywage, int Hours, int Taskscompleted)
            : base(name, id, bDate, pass)
        {
            this.Hours = Hours;
            this.tasksCompleted = Taskscompleted;
            this.Hourlywage = Hourlywage;
           
            
        }

        public override double Salary()
        {
            double i = tasksCompleted;
            i = 100 + 3 * i;
            i = i / 100;
            return Hours * (Hourlywage*i);
        }

    }
}
