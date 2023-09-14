using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    //כתבו את המחלקה על פי המחלקות הקודמות
    //שימו לב שעליכם להתייחס גם לתעופה
    class RobotFly : RobotSpy
    {
        public RobotFly(DateTime date, double battery) : base("Shemon", date, battery)
        { 
        }
        public override void MoveForward()
        {
            for (int i = 0; i < 5; i++)
                MoveLeg(i, 1);
        }
        public override void MoveBackward()
        {
            for (int i = 0; i < 5; i++)
                MoveLeg(i, -1);
        }
        public override void TurnLeft()
        {
            this.MoveLeg(0, -1);
            this.MoveLeg(1, -1);
            this.MoveLeg(2, -1);
            this.MoveLeg(3, 1);
            this.MoveLeg(4, 1);
            this.MoveLeg(5, 1);
        }
        public override void TurnRight()
        {
            this.MoveLeg(0, 1);
            this.MoveLeg(1, 1);
            this.MoveLeg(2, 1);
            this.MoveLeg(3, -1);
            this.MoveLeg(4, -1);
            this.MoveLeg(5, -1);
        }
        public void FlyUp()
        {
            for (int i = 0; i < 3; i++)
                Fly(i, 1);
        }
        public void FlyDown()
        {
            for (int i = 0; i < 3; i++)
                Fly(i, -1);
        }
        public void FlyLeft()
        {
            Fly(0,1);
            Fly(1, 1);
            Fly(2, -1);
            Fly(3, -1);
        }
        public void FlyRight()
        {
            Fly(0, -1);
            Fly(1, -1);
            Fly(2, 1);
            Fly(3, 1);
        }






        private void MoveLeg(int legId, int dir)
        {
            SetBatteryStatus(GetBatteryStatus() - dir*2);
        }
        private void Fly(int WingID, int dir)
        {
            SetBatteryStatus(GetBatteryStatus() - dir * 1.5);
        }
    }
}
