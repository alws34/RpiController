using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiController.DeviceController
{
    public interface IDeviceController
    {
        void SetAllFieldsOK(bool isFieldOK);
    }
}
