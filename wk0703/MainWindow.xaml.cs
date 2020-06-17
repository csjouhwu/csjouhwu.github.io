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

namespace wk0502
{
  using HelixToolkit.Wpf;
  using System.Windows.Media.Media3D;
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //<h:FileModelVisual3D Source="C:\Users\USER\Downloads\wk07\pikachu.obj">
            for (int x=0; x<5; x++)
            for (int y=0; y<5; y++)
            for (int z=0; z<5; z++)
            {
            //Teapot B = new Teapot();
            FileModelVisual3D B = new FileModelVisual3D();
            B.Source = @"C:\Users\User\Downloads\wk08\pikachu.obj";
            //B.Location = new Point(i*100, y);
            B.Transform = new TranslateTransform3D(x*4-10, y*4-10, z*4-10);
            G.Children.Add(B);
            //this.Controls.Add(B);
            }

        }
    }
}
