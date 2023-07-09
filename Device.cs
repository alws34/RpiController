using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiController
{
    public class Device
    {
        public string DeviceHostName { get; set; }
        public string UserName { get; set; }
        public string DeviceId { get; set; }
        public string DeviceIP { get; set; }
        public string Description { get; set; }
        public string DeviceLocation { get; set; }
        public string Port { get; set; }
        public byte[] Password { get; set; }
        public byte[] EncryptionKey { get; set; }

        public Device()
        {
            EncryptionKey = Utils.GenerateEncryptionKey();
            DeviceId = Utils.GetUniqueID();
        }

        public Device(string deviceHostName, string userName, string deviceId, string deviceIP, string description, string deviceLocation, string port, string password, string encryptionKey)
        {
            DeviceHostName = deviceHostName;
            UserName = userName;
            DeviceId = deviceId;
            DeviceIP = deviceIP;
            Description = description;
            DeviceLocation = deviceLocation;
            Port = port;
            Password = Encoding.ASCII.GetBytes(password);
            EncryptionKey = Encoding.ASCII.GetBytes(encryptionKey);
        }
    }
}
