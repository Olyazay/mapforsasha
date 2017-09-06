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
using HtmlAgilityPack;
using System.Collections.ObjectModel;

namespace Map
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //LoadSite();
            Tips t = new Tips();
        }

        private void LoadSite()
        {
            //HtmlWeb hw = new HtmlWeb();
            //var htmlDoc = hw.Load("http://10.49.150.159/plans/view/000000190/");
            //var nameNodes = htmlDoc.DocumentNode.SelectNodes("//div[@class='catalog-detail-item-layer']/table/tr/td/h2");
            //var idNodes = htmlDoc.DocumentNode.SelectNodes("//li[@class='switch-object-code']");
            //ObservableCollection<String> tr = new ObservableCollection<string>();
            //foreach (var N in nameNodes)
            //{
            //    tr.Add(N.ToString());
            //    string b = N.InnerText;
            }

    }
}
