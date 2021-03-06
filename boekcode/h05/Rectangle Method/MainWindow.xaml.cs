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

namespace Rectangle_Method
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush(Colors.Black);
            
            // draw first logo at (10, 20)
            DrawRectangle(paperCanvas, brush, 10, 20, 20);
            DrawRectangle(paperCanvas, brush, 10, 20, 40);
            DrawRectangle(paperCanvas, brush, 10, 20, 60);

            //// draw second logo at (100, 100)
            //DrawRectangle(paperCanvas, brush, 100, 100, 20);
            //DrawRectangle(paperCanvas, brush, 100, 100, 40);
            //DrawRectangle(paperCanvas, brush, 100, 100, 60);
        }

        private void DrawRectangle(Canvas drawingArea,
                                   SolidColorBrush brushToUse,
                                   double xPos,
                                   double yPos,
                                   double size)
        {
            Rectangle rect = new Rectangle();
            rect.Width = size;
            rect.Height = size;
            rect.Margin = new Thickness(xPos, yPos, 0, 0);
            rect.Stroke = brushToUse;
            drawingArea.Children.Add(rect);
        }
    }
}
