using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace puzzCode
{
    public static class Program
    {
        public static UI mainUi ;
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainUi = new UI();

            if (args.Length > 0)
                mainUi.srcPath = args[0];

            Application.Run(mainUi);
        }
    }
}
