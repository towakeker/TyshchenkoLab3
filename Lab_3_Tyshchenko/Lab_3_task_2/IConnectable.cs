namespace Lab_3_task_2
{
    public interface IConnectable
    {
        void ConnectTo(IConnectable device);
        void DisconnectFrom(IConnectable device);
        void SendData(string data);
        void ReceiveData(string data);
        void ServeClient(Client client);
    }
}