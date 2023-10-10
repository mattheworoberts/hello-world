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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Hello_World
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        string strHello = "Hello";
        string strWorld = "World";

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Show_Hello_World_Click(object sender, RoutedEventArgs e)
        {
            txtHelloWorld.Text = $"{strHello} {strWorld}";
        }

        private void Clear_Text_Click(object sender, RoutedEventArgs e)
        {
            txtHelloWorld.Text = String.Empty;
        }
    }
}
