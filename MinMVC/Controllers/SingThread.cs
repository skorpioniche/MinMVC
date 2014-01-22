using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace MinMVC.Controllers
{
    public sealed class SingThread
    {
        private static readonly Object s_lock = new Object();
        private static Miner instance = null;

        private SingThread()
        {
        }

        public static Miner Instance
        {
            get
            {
                if (instance != null) return instance;
                Monitor.Enter(s_lock);
                var temp = new Miner();
                Interlocked.Exchange(ref instance, temp);
                Monitor.Exit(s_lock);
                return instance;
            }
        }
    }
}