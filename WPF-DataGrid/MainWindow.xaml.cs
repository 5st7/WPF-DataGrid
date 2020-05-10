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
using static WPF_DataGrid.Human;

namespace WPF_DataGrid
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Person> data = new ObservableCollection<Person>();
        public MainWindow()
        {
            InitializeComponent();

            //dataGridとコレクションdataを結び付ける
            dataGrid.ItemsSource = data;

            //適当にデータを作る
            Person person = new Person
            {
                Name = "田中　太郎",
                Gender = GenderEnum.Men,
                Age = 20
            };
            //dataにpersonを追加
            data.Add(person);
        }
        //ボタンから追加する方法
        private void OnClickick(object sender, RoutedEventArgs e)
        {
            //空行を追加する方法
            Person person = new Person
            {
                Name = null,
                Gender = null,
                Age = null
            };
            //dataにpersonを追加
            data.Add(person);
        }
    }
}
