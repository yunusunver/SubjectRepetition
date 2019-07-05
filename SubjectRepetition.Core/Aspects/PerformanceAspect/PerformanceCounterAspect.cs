using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects;

namespace SubjectRepetition.Core.Aspects.PerformanceAspect
{
    [Serializable]
    public class PerformanceCounterAspect:OnMethodBoundaryAspect
    {
        [NonSerialized]
        private Stopwatch _stopwatch;

        private int _interval;

        public PerformanceCounterAspect(int interval=1)
        {
            _interval = interval;
        }

        public override void RuntimeInitialize(MethodBase method)
        {
            _stopwatch = Activator.CreateInstance<Stopwatch>();
            base.RuntimeInitialize(method);
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            _stopwatch.Start();
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            _stopwatch.Stop();

            if (_stopwatch.Elapsed.TotalSeconds>_interval)
            {
                Debug.WriteLine("Performance {0}.{1} ->> {2}",args.Method.DeclaringType.FullName,args.Method.Name,_stopwatch.Elapsed.TotalSeconds);
            }
            _stopwatch.Reset();
            base.OnExit(args);
        }
    }
}
