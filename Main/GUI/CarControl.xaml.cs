﻿using System;
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
using Logic;

namespace Main
{
    /// <summary>
    /// Logika interakcji dla klasy CarControl.xaml
    /// </summary>
    public partial class CarControl : UserControl
    {
        public CarControl()
        {
            InitializeComponent();
            ComboBoxAerodynamics.Items.Add("whateverAero");
            ComboBoxEngine.Items.Add("whateverEngine");
            ComboBoxTyres.Items.Add("whateverTyre");
        }

        private void ButtonBuild_Click(object sender, RoutedEventArgs e)
        {
            int number = int.Parse((TextBoxNumber.Text));
            byte type = byte.Parse((TextBoxType.Text));
            string aerodynamics = ComboBoxAerodynamics.SelectedValue.ToString();
            string engine = ComboBoxEngine.SelectedValue.ToString();
            string tyres = ComboBoxTyres.SelectedValue.ToString();
            double brakes = double.Parse((TextBoxBrakes.Text));

            Car car = new Car { Number = number, Type = type, Aerodynamics = aerodynamics, Brakes = brakes, Engine = engine, Tyres = tyres };
            Car.cars.Add(car);
        }
    }
}
