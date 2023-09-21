using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for UcWorker.xaml
    /// </summary>
    public partial class UcWorker : UserControl
    {
        public UcWorker(Worker worker)
        {
            InitializeComponent();
            this.DataContext = worker;
            DateTime date = worker.GetbirthDate();
            if (date.Month == DateTime.Now.Month && date.Day == DateTime.Now.Day)
            {
                lbBday.Content += ": " + worker.GetbirthDate().ToShortDateString() + "🎂🎂🎂";

            }
            else
            {
                lbBday.Content += ": " + worker.GetbirthDate().ToShortDateString();
            }
            lbID.Content += ": " + worker.GetidNumber();
            
          
            if (worker is OperationalWorker)
            {
                lbRole.Content += ": Eved";
            }
            if (worker is OperationManager)
            {
                lbRole.Content += ":smaller eved";
            }
            if (worker is GeneralManager)
            {
                lbRole.Content += ": A white man in amercia in 1800";
            }
        }
    }
}
