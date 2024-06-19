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
using System.Windows.Shapes;

namespace Student
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        BrushConverter bc = new BrushConverter();
        int IdPost;
        public Admin()
        {
            InitializeComponent();
        }
        public Admin(int idPost)
        {
            InitializeComponent();
            MainFrame.Content = new MainAdminFrame();
            IdPost = idPost;
        }

        private void ShowSpecial(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new SpecialFrame(MainFrame, IdPost);
        }

        private void ShowUsers(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new ShowUsersFrame();
        }
    }
}
