namespace MonitorModule
{
    public class MessageData
    {
        private string _moduleId;
        private string _messageReceived;

        public string ModuleId { get => _moduleId; set => _moduleId = value; }
        public string MessageReceived { get => _messageReceived; set => _messageReceived = value; }
    }
}