using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace シングルトン
{
    internal static class Program
    {
        //private static CheckTimer _timer = new CheckTimer();
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //CheckTimer.GetInstance().Start();
            //CheckTimer.Instance.Start();
            CheckTimer.Start();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
