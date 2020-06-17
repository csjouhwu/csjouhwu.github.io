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

namespace wk0501
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // 雙迴圈
for (int i=0; i<5; i++)
for (int y=0; y<500; y+=100)
{
Button B = new Button();
//B.Location = new Point(i*100, y);
B.RenderTransform = new TranslateTransform(-250+i*100, -250+y);
B.Width = 50;
B.Height = 50;
G.Children.Add(B);
//this.Controls.Add(B);
        }
    }
}
}
