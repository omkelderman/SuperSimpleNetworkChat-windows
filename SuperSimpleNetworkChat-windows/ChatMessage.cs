using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSimpleNetworkChat_windows
{
    public abstract class ChatMessage
    {
        public string Message { set; get; }

    }

    public class SelfChatMessage : ChatMessage
    {
        public List<string> MessageReadPeers { get; } = new List<string>();

        public int MessageReadCount => MessageReadPeers.Count;
        public string MessageReadPeersList => string.Join("\n", MessageReadPeers);
    }

    public class PeerChatMessage : ChatMessage
    {
        public string Name { set; get; }

    }
}
