using System.Collections.Generic;
namespace Lab_3_task_2
{
    public class Network
    {
        private List<IConnectable> ConnectedDevices { get; } = new List<IConnectable>();

        public void AddDevice(IConnectable device)
        {
            ConnectedDevices.Add(device);
        }

        public void ConnectDevices(IConnectable device1, IConnectable device2)
        {
            device1.ConnectTo(device2);
            device2.ConnectTo(device1);
            AddConnectedDevices(device1, device2);
        }

        public void DisconnectDevices(IConnectable device1, IConnectable device2)
        {
            device1.DisconnectFrom(device2);
            device2.DisconnectFrom(device1);
            RemoveConnectedDevices(device1, device2);
        }

        private void AddConnectedDevices(IConnectable device1, IConnectable device2)
        {
            if (!ConnectedDevices.Contains(device1))
            {
                ConnectedDevices.Add(device1);
            }

            if (!ConnectedDevices.Contains(device2))
            {
                ConnectedDevices.Add(device2);
            }
        }

        private void RemoveConnectedDevices(IConnectable device1, IConnectable device2)
        {
            ConnectedDevices.Remove(device1);
            ConnectedDevices.Remove(device2);
        }
    }
}