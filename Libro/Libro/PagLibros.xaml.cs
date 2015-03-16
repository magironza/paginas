using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Libro.Models;

namespace Libro
{
    public partial class PagLibros : PhoneApplicationPage
    {
        public PagLibros()
        {
            InitializeComponent();
        }
    

     

        private void gotopage(object sender, SelectionChangedEventArgs e)
        {
            var x = lista.SelectedIndex;
            if (x == 0) {
                NavigationService.Navigate(new Uri("/MainPage.xaml?dato1=0", UriKind.Relative));
            
            }
            if (x == 1)
            {
                NavigationService.Navigate(new Uri("/MainPage.xaml?dato1=1",UriKind.Relative));

            }
            if (x == 2)
            {
                NavigationService.Navigate(new Uri("/MainPage.xaml?dato1=2", UriKind.Relative));

            }
            }
        }





}