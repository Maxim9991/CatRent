﻿using Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfAppTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<UserVM> _users = new ObservableCollection<UserVM>();
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btnBegin_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Hello");

            _users.Add(new UserVM
            {
                Name = "Петро",
                Birthday = new DateTime(2000, 5, 15),
                Details = "Дружить із директром Іванкой",
                ImageUrl = "https://icdn.lenta.ru/images/2020/01/28/17/20200128170822958/square_320_9146846fb3b1bfae5672755bc1896214.jpg"
            }); 
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _users.Add(new UserVM()
            {
                Name = "John Doe",
                Birthday = new DateTime(2002, 7, 22),
                Details = "Матрос на борту",
                ImageUrl = "https://ichef.bbci.co.uk/news/800/cpsprodpb/14236/production/_104368428_gettyimages-543560762.jpg"
            });
            dgSimple.ItemsSource = _users;
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            if(dgSimple.SelectedItem !=null)
            {
                if(dgSimple.SelectedItem is UserVM)
                {
                    var userView = dgSimple.SelectedItem as UserVM;
                    userView.Birthday = new DateTime(2003, 1, 23);
                    userView.Details = "Пішов в гори!";
                    userView.ImageUrl = "https://i.pinimg.com/originals/ec/5a/a9/ec5aa93a38113ea5b346cb87b5c2c941.jpg";
                }
            }
        }
    }
}
