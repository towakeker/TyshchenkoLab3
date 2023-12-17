namespace Lab_3_task_2
{
    public class Server: Computer
    {
        public Server(string ipAddress, int power, string operatingSystem) : base(ipAddress, power, operatingSystem)
        {
            
        }
        public void ServeClient(IConnectable client)
        {
            ConnectTo(client);
            client.ReceiveData("Welcome!");
            DisconnectFrom(client);
        }
    }
    
}