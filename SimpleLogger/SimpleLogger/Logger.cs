using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleLogger.Targets;

namespace SimpleLogger
{
    class Logger : ILogger
    {
        readonly List<ILogTarget> _targets = new List<ILogTarget>();

        public void LogInfo(string message)
        {
            Log($"INFO - {DateTime.Now.ToString()} - {message}");
        }

        public void LogError(string message, Exception e)
        {
            Log($"ERROR - {DateTime.Now.ToString()} - {message} ({e.Message})");
        }

        private void Log(string message)
        {
            foreach (ILogTarget target in _targets)
            {
                target.WriteLog(message);
            }
        }

        public void AddTarget(ILogTarget target)
        {
            _targets.Add(target);
        }

        public void RemoveTarget(ILogTarget target)
        {
            if (_targets.Contains(target))
            {
                _targets.Remove(target);
            }
        }

        
    }
}
