using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;
using SlotMachineLib;

namespace bernardi.davide._4i.WPFSlotMachine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int indiceCartaCorrente = 0;
        private DispatcherTimer timer;
        public MainWindow()
        {
            InizializzaTimer();

            SlotMachine s = new SlotMachine("Davi"); 
        }
           private void InizializzaTimer()
            {
                timer = new DispatcherTimer();
                timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick; ;
            }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
    }

