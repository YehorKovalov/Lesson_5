using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public static class Actions
    {
        public static Result SucceedMethod()
        {
            Logger.Instance.Log(LogType.Info, "Start method: " + MethodBase.GetCurrentMethod().Name);
            return new Result { Status = true };
        }

        public static Result WarnedMethod()
        {
            Logger.Instance.Log(LogType.Warning, "Skipped logic in method: " + MethodBase.GetCurrentMethod().Name);
            return new Result { Status = true };
        }

        public static Result BrokenMethod()
        {
            return new Result { ErrorMessage = "I broke a logic", Status = false };
        }
    }
}
