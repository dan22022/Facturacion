using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Timbrado33
{
    class Scheduler
    {
        System.Timers.Timer oTimer = null;
        private readonly double interval = 30000; //5 Minutos 300 segundos = 300000
        public void Start()
        {
            oTimer = new System.Timers.Timer(interval)
            {
                AutoReset = true,
                Enabled = true
            };
            oTimer.Start();
            oTimer.Elapsed += new System.Timers.ElapsedEventHandler(OTimer_Elapsed);

        }

        private void OTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

            if (1 == 1)
            {
                Form1 cc = new Form1();
                cc.Principal();
                Thread.Sleep(10000);

            }

        }
    }
}
