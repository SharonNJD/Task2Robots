using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Robots_inc
{
    public class RobotWheels : RobotSpy
    {
        //1. עדכנו את הפעולה הבונה כך שתתאים לפעולת במחלקת העל
        public RobotWheels(DateTime date,double battery) : base("Spyke",date,battery) { } 

        public override void MoveForward()
        {
            this.TurnWheels(1, 1);
        }
        public override void TurnRight()
        {
            this.TurnWheels(-1, 0);
        }
        public override void TurnLeft()
        {
            this.TurnWheels(0, -1);
        }
        public override void MoveBackward()
        {
            this.TurnWheels(-1, -1);
        }
        //השלימו את הפעולות החסרות מתוך המצגת או על הבנתכם

        private void TurnWheels(int rightDir, int leftDir)
        {
            int num = Math.Abs(rightDir) + Math.Abs(leftDir);
            if (GetBatteryStatus()> num * 4.5)
            {
                SetBatteryStatus(GetBatteryStatus() - num * 4.5);
            }
            else
            {
                Console.WriteLine("cant do system closing");
               
            }
            
        }

        public void WaveHands()
        {
            if (GetBatteryStatus() > 2.5)
            {
                SetBatteryStatus(GetBatteryStatus() - 2);
            }
            else
            {
                Console.WriteLine("cant do that no energy");
            }
           
        }

    }
}
