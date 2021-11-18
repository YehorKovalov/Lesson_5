using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class Starter
    {
        public void Run()
        {
            LogType logType;
            Result actionResult = new Result();
            for (int i = 0; i < 100; i++)
            {
                logType = (LogType)new Random().Next(1, 4);
                switch (logType)
                {
                    case LogType.Error:
                        actionResult = Actions.BrokenMethod();
                        break;
                    case LogType.Warning:
                        actionResult = Actions.WarnedMethod();
                        break;
                    case LogType.Info:
                        actionResult = Actions.SucceedMethod();
                        break;
                }

                if (actionResult.Status == false)
                {
                    Logger.Instance.Log(LogType.Error, "Action failed by a reason: " + actionResult.ErrorMessage);
                }
            }

            File.WriteAllText("log.txt", Logger.Instance.Reports.ToString());
        }
    }
}
