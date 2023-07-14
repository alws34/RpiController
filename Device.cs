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
        public string Password { get; set; }
        public string DeviceId { get; set; }
        public string DeviceIP { get; set; }
        public string Description { get; set; }
        public string DeviceLocation { get; set; }
        public string Port { get; set; }
        public byte[] EncryptionKey { get; set; }
        public byte[] Salt { get; set; }
        public Device()
        {
            DeviceId = Utils.GetUniqueID();
            EncryptionKey = Utils.GenerateKey();
            Salt = Utils.GenerateSalt();
        }

        public Device(string deviceHostName, string userName, string deviceId, string deviceIP, string description, string deviceLocation, string port, byte[] encryptionKey, byte[] salt)
        {
            DeviceHostName = deviceHostName;
            UserName = userName;
            DeviceId = deviceId;
            DeviceIP = deviceIP;
            Description = description;
            DeviceLocation = deviceLocation;
            Port = port;
            EncryptionKey = encryptionKey;
            Salt = salt;
        }
    }
}
