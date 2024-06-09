using DataContextAnimal.Model;
using DataContextAnimal.MYContext;
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

namespace DataContextAnimal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyAnimalContext myAnimalContext = new MyAnimalContext();
        public MainWindow()
        {
            InitializeComponent();
            //Created();
        }
        public void Created()
        {
            using (MyAnimalContext myAnimalContext = new MyAnimalContext())
            {
                MyAnymal myAnymal = new MyAnymal { Type = "AnymalLeonForMeat" };
                Leon leon = new Leon { Name = "Carpaty", Year = 2023, MyAnymal = myAnymal, MyAnymalId=myAnymal.Id };
                myAnimalContext.Leons.Add(leon);
                myAnimalContext.Leons.Add(leon);
                myAnimalContext.SaveChanges();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            DG.ItemsSource = myAnimalContext.Leons.ToList();
        }
    }
}
