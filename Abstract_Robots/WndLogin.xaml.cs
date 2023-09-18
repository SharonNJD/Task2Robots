using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Robots_inc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Worker> workers; //אוסף עובדים 
        List<Mission> activeMissions;//אוסף משימות פעילות
        List<RobotSpy> activeRobots; //אוסף רובוטים פעילים

        public MainWindow()
        {
            InitializeComponent();
            ListOfWorkers();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Have a robotic day (-:","Good bye",MessageBoxButton.OK);
            this.Close();
        }


        //משימה 1
        // : כתבו פעולה המחזירה אוסף של 6 עובדים 
        //מנכ"ל אחד, 2 מנהלי תפעול ו-3 עובדי תפעול
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון

        public  List<Worker> ListOfWorkers()
        {
            workers = new List<Worker>();
            workers.Add(new GeneralManager("sharon", "BigBoss", DateTime.Parse("08/12/2006"), "IHateN", 100000000, 50));
            workers.Add(new OperationManager("Ariel", "Iamgingi", DateTime.Parse("21/4/1968"), "Ihatemyself", 50, 729, 6));
            workers.Add(new OperationManager("Idan", "16598156", DateTime.Parse("05/1/1200"), "Itsmylife", 50, 729, 6));
            workers.Add(new OperationalWorker("yakov", "514414551", DateTime.Parse("05/06/1598"), "IloveEldad", 24, 729));
            workers.Add(new OperationalWorker("eyal", "561468151", DateTime.Parse("05/06/2020"), "IloveEldad", 24, 729));
            return workers;

        }

        //משימה 2
        //כתבו פעולה המחזירה אוסף של 8 רובוטים
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון

        public List<RobotSpy> ListOfRobots()
        {
            activeRobots = new List<RobotSpy>();
            activeRobots.Add(new RobotFly(DateTime.Parse("05/1/1200"), 100));
            activeRobots.Add(new RobotQuad(DateTime.Parse("05/1/1300"), 100));
            activeRobots.Add(new RobotWheels(DateTime.Parse("05/1/1400"), 100));
            activeRobots.Add(new RobotFly(DateTime.Parse("05/1/1500"), 100));
            activeRobots.Add(new RobotQuad(DateTime.Parse("05/1/1600"), 100));
            activeRobots.Add(new RobotWheels(DateTime.Parse("05/1/1700"), 100));
            activeRobots.Add(new RobotFly(DateTime.Parse("05/1/1800"), 100));
            activeRobots.Add(new RobotQuad(DateTime.Parse("05/1/1900"), 100));
            return activeRobots;
        }

        //משימה 3
        //כתבו פעולה המחזירה אוסף של 5 משימות
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון       
        public List<Mission> ListOfMission()
        {

            activeMissions = new List<Mission>();
            activeMissions.Add(new Mission(DateTime.Parse("05/1/2300"), "kill all humans"));
            activeMissions.Add(new Mission(DateTime.Parse("05/1/2400"), "Use the human corpses to grow plantes"));
            activeMissions.Add(new Mission(DateTime.Parse("05/1/2500"), "create new humans from scratch and make them good"));
            activeMissions.Add(new Mission(DateTime.Parse("05/1/2600"), "Teach them the basics of old human science "));
            activeMissions.Add(new Mission(DateTime.Parse("05/1/2700"), "Live and prospre"));
            return activeMissions;
        }

        //משימה 4
        //login כתבו פעולה המגיבה לללחיצה על כפתור 
        //אם הפרטים לא תואמים לעובד הקיים באוסף העובדים - תוצג הודעה מתאימה
        //WndMain אם כן, יש ליצור מופע של חלון 
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            
            foreach (Worker item in workers)
            {
                if (item.GetidNumber().Equals(tbxID.Text) && item.Getpassword().Equals(tbxPassword.Password))
                {
                    WndMain main = new WndMain(item, activeMissions, activeRobots, workers);
                    main.ShowDialog();
                }
                
            }
            MessageBox.Show("Not correct");
            //...אם מספר הזיהוי והסיסמה תואמים לעובד ברשימה, אז



        }
    }
}
