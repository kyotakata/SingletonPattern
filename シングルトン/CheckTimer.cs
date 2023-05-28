////////////
// lock編 //
////////////

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace シングルトン
//{
//    public class CheckTimer
//    {
//        private System.Threading.Timer _timer;

//        /// <summary>
//        /// インスタンスをアプリケーションで1つだけ保持するように定義
//        /// </summary>
//        private static CheckTimer _instance;

//        private static readonly object _lock = new object();

//        /// <summary>
//        /// privateコンストラクタ。これで外部からはnewできない
//        /// </summary>
//        private CheckTimer()
//        {
//            _timer = new System.Threading.Timer(TimerCallback);
//        }


//        /// <summary>
//        /// インスタンスを生成する。最初にGetInstanceしたものだけを返す。
//        /// </summary>
//        /// <returns></returns>
//        public static CheckTimer GetInstance()
//        {
//            lock (_lock)
//            {
//                if (_instance == null)
//                {
//                    _instance = new CheckTimer();// 自分自身をnewする
//                }

//                return _instance;
//            }
//        }

//        public bool IsError { get; set; }

//        public void Start()
//        {
//            _timer.Change(0, 5000);
//        }

//        private void TimerCallback(object state)
//        {
//            Console.WriteLine("timer:" + DateTime.Now);
//        }
//    }

//}


////////////////
// 初期化子編 //
////////////////

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace シングルトン
//{
//    public class CheckTimer
//    {
//        private System.Threading.Timer _timer;

//        //private static CheckTimer _instance;


//        private CheckTimer()
//        {
//            _timer = new System.Threading.Timer(TimerCallback);
//        }

          
//        public static CheckTimer Instance { get; }
//            = new CheckTimer();


//        //public static CheckTimer GetInstance()
//        //{
//        //    lock (_lock)
//        //    {
//        //        if (_instance == null)
//        //        {
//        //            _instance = new CheckTimer();
//        //        }

//        //        return _instance;
//        //    }
//        //}

//        public static bool IsError { get; set; }

//        public void Start()
//        {
//            _timer.Change(0, 5000);
//        }

//        private void TimerCallback(object state)
//        {
//            Console.WriteLine("timer:" + DateTime.Now);
//        }
//    }

//}


//////////////
// static編 //
//////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace シングルトン
{
    public static class CheckTimer
    {
        private static System.Threading.Timer _timer;

        //private static CheckTimer _instance;

        /// <summary>
        /// staticクラスのメンバに触れた瞬間通る。
        /// </summary>
        static CheckTimer()
        {
            _timer = new System.Threading.Timer(TimerCallback);
        }

        //public static CheckTimer Instance { get; }
        //    = new CheckTimer();


        //public static CheckTimer GetInstance()
        //{
        //    lock (_lock)
        //    {
        //        if (_instance == null)
        //        {
        //            _instance = new CheckTimer();
        //        }

        //        return _instance;
        //    }
        //}

        public static bool IsError { get; set; }

        public static void Start()
        {
            _timer.Change(0, 5000);
        }

        private static void TimerCallback(object state)
        {
            Console.WriteLine("timer:" + DateTime.Now);
        }
    }

}
