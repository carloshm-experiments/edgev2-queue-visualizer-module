using System.Collections.Generic;

namespace MonitorModule
{
    public class Data
    {
        private List<MessageData> _messages;

        private Data()
        {
            _messages = new List<MessageData>();
        }

        private static readonly Data _instance = new Data();

        public static Data Instance { get => _instance; }

        public void AddMessageData(MessageData data)
        {
            _messages.Add(data);
            if(_messages.Count > 20)
            {
                _messages.RemoveAt(0);
            }
        }

        public IList<MessageData> Messages { get => _messages; }

    }

}