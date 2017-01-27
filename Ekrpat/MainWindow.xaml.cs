using Ekrpat.Styles;
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

namespace Ekrpat
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : CardWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertToDvorak(object sender, RoutedEventArgs e)
        {
            new TextRange(tbDvorak.Document.ContentStart, tbDvorak.Document.ContentEnd).Text = Converter.ConvertToDvorak(new TextRange(tbQwertz.Document.ContentStart, tbQwertz.Document.ContentEnd).Text);
        }

        private void ConvertToQwertz(object sender, RoutedEventArgs e)
        {
            new TextRange(tbQwertz.Document.ContentStart, tbQwertz.Document.ContentEnd).Text = Converter.ConvertToQwertz(new TextRange(tbDvorak.Document.ContentStart, tbDvorak.Document.ContentEnd).Text);
        }
    }
}
