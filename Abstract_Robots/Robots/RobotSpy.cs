using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
	public abstract class RobotSpy
	{
		private string model;
		private DateTime creationDate;
		private double batteryStatus;

		//1. עדכנו את הפעולה הבונה כך שתקבל פרמטרים בהתאם לתכונות
		public RobotSpy(string model, DateTime Date, double batterystatus)
		{
			this.model = model;
			creationDate = Date;
			this.batteryStatus = batterystatus;
		}
		public string GetModel() { return this.model; }
		public DateTime GetDate() { return this.creationDate; }
		public double GetBatteryStatus() { return this.batteryStatus; }

		//2. השלימו פעולות מאחזרות עבור התכונות הנוספות
		public void SetBatteryStatus(double num) { this.batteryStatus = num; }
		//3. הוסיפו פעולה המעדכנת את מצב הסוללה

		public abstract void MoveForward();
		public abstract void MoveBackward();
		public abstract void TurnLeft();
		public abstract void TurnRight();

		public void TakePicture()
		{
			if (batteryStatus > 6)
			{
				Console.WriteLine("pic taken and uploded and battery went down"); this.batteryStatus = batteryStatus - 5;
			}
			else {
				Console.WriteLine("battery is low cant do it ");
			} //4. הוסיפו התייחסות למצב סוללה
			
		}
        public void ChargeBattery() { batteryStatus = 100; } //5. עדכנו את מצב הסוללה ל-100
    } }
