using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace UniversalApp
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        String Text = "hello windows";
        String Hgy = "软件作者：何广宇";
       
        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            if (a.IsChecked == true)
                answer.Text = Text;
            else if (b.IsChecked == true)
                answer.Text = "123";
            else if (c.IsChecked == true)
                answer.Text = "456";
            else if (d.IsChecked == true)
                answer.Text = "789";
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage1));
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            example.Text = Hgy;
            
        }

        private void answer_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {
            
        }

        
    }
}
