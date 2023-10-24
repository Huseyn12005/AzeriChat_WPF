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

namespace AzeriChat_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Message message = new Message();
        List<Message> messages = new List<Message>();
        public MainWindow()
        {
            InitializeComponent();

            messages = new()
            {
                new Message {Message_ = "Salam",Date="12:00"},
                new Message {Message_ = "Aleykum Salam",Date="12:03"},
                new Message {Message_ = "Necesen?",Date="12:05"},
                new Message {Message_ = "Sukur qaqa sen necesen",Date="12:06"},
                new Message {Message_ = "Yaxshiyam brat var ol",Date="12:08"},
                new Message {Message_ = "Sabah gelessen oyuna??",Date="12:09"},
                new Message {Message_ = "Salam",Date="12:00"},
            };
            DataContext = this;
        }
    }
}
