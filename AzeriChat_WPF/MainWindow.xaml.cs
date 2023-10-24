using System.Collections.Generic;
using System.Windows;

namespace AzeriChat_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
     
        public List<Message> messages {  get; set; }
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
                new Message {Message_ = "Hee)",Date="12:00"},
            };
            DataContext = this;
        }
    }
}
