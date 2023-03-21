using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService
{
    public partial class Servisim : ServiceBase
    {
        public Servisim()
        {
            InitializeComponent();
        }
        /*
         * Başlama
         * Pause
         * Continue
         * Stop
         * OnShutDown
         * 
         */


        protected override void OnStart(string[] args) //başlama
        {
            //servis çalıştığı zaman çalışacak olan kod bloğu
        }

        protected override void OnPause()
        {
            //servis pause edildiği zaman çalışacak olan metod
        }

        protected override void OnContinue()
        {
            //pause işleminden devam ettirildiği zaman çalışacak olan metod.
        }

        protected override void OnStop()
        {
            //Servis durdurulduğu zaman çalışacak olan metod.
        }

        protected override void OnShutdown()
        {
            //servis shutdown edildiği zaman çalışacak olan metod.
        }
    }
}
