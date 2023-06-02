using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;
using FivePD.API;
using FivePD.API.Utils;

namespace onDutyExport
{
    public class Main : Plugin
    {
        internal Main() 
        {
            EventHandlers.Add("fivepd::dutyStatus", new Action<CallbackDelegate>((cb) => GetData(cb)));
        }

        private void GetData(CallbackDelegate cb)
        {
            bool dutyStatus = Utilities.IsPlayerOnDuty();
            cb.Invoke(dutyStatus);
        }
    }
}
