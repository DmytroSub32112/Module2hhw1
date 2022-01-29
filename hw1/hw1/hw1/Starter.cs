using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1
{
    public class Starter
    {
        private readonly Logger _logger = Logger.Instance;
        private readonly Random _randomMethod = new Random();

        public void Run()
        {
            var actions = new Actions();
            var result = new Result();
            var message = string.Empty;
            const int MaxRandomValue = 3;
            const int IterNum = 100;
            for (var i = 0; i < IterNum; i++)
            {
                switch (_randomMethod.Next(MaxRandomValue))
                {
                    case 0:
                        result = actions.FirstMethod();
                        break;
                    case 1:
                        result = actions.SecondMethod();
                        break;
                    case 2:
                        result = actions.ThirdMethod();
                        break;
                }

                if (!result.Status)
                {
                    message = $"Action failed by a reason: {result.Message}";
                    _logger.Print(Logger.LogType.Error, message);
                }
            }

            File.WriteAllText("log.txt", _logger.ReturnValuesToFile().ToString());
        }
    }
}
