using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SuperSimpleNetworkChat_windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<ChatMessage> chatMessages = new List<ChatMessage>
            {
                new PeerChatMessage {Name = "peer 1", Message = "message1"},
                new PeerChatMessage {Name = "peer 2", Message = "message2"},
                new SelfChatMessage {Message = "message3", MessageReadPeers = { "A", "B", "C"}},
                new PeerChatMessage {Name = "peer 3", Message = "message4"},
            };

            ChatBox.ItemsSource = chatMessages;
        }
    }

    public class MockChatMessages
    {
        public ObservableCollection<ChatMessage> Items { get; set; }

        public MockChatMessages()
        {
            Items = new ObservableCollection<ChatMessage>()
            {
                new PeerChatMessage {Name = "*peer 1", Message = "*message1"},
                new PeerChatMessage {Name = "*peer 2", Message = "*message2"},
                new SelfChatMessage {Message = "*message3", MessageReadPeers = { "*a", "*b", "*c"}},
                new PeerChatMessage {Name = "*peer 3", Message = "*message4"},
            };
        }
    }
}
