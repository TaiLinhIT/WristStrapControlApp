using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WristStrapControlApp.DAL.Entities
{
    public enum LineType
    {
        Main = 1,
        Sub = 2
    }

    public enum ESDStatus
    {
        OK = 1,
        NG = 2,
        NotConnected = 3
    }

    public enum AlarmStatus
    {
        OFF = 0,
        ON = 1
    }
}
