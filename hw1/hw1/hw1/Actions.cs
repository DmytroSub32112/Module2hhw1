using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1
{
    public class Actions
    {
        private readonly Logger _logger = Logger.Instance;
        public Result FirstMethod()
        {
            var res = new Result { Status = true };
            var message = $"Start method: {nameof(FirstMethod)}";
            _logger.Print(Logger.LogType.Info, message);
            return res;
        }

        public Result SecondMethod()
        {
            var res = new Result { Status = true };
            var message = $"Skipped logic in method: {nameof(SecondMethod)}";
            _logger.Print(Logger.LogType.Warning, message);
            return res;
        }

        public Result ThirdMethod()
        {
            var message = "I broke a logic";
            var res = new Result { Status = false, Message = message };
            return res;
        }
    }
}
