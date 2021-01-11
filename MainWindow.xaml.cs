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
using System.Collections.ObjectModel;

namespace OOPFinalExam
{
    //https://github.com/S00199080/OOPFinalExam Link to GitHub Repository
    public partial class MainWindow : Window
    {
        //Initialise the observable collection
        ObservableCollection<Account> account = new ObservableCollection<Account>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {                      
            CurrentAccount a1 = new CurrentAccount(5, "Munnelly", "John");
            CurrentAccount a2 = new CurrentAccount(2, "Butler", "Robert");
            SavingsAccount a3 = new SavingsAccount(12, "Hagan", "Charlie");
            SavingsAccount a4 = new SavingsAccount(4, "Byrne", "Joseph");
            
            //adds to collection
            account.Add(a1);
            account.Add(a2);                         
            account.Add(a3);
            account.Add(a4);

            //Add to listbox
            lstbx.ItemsSource = account;

        }
    }
}
