using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers; // servisin çalışma periyodunu belirleyeceğiz

namespace WindowsService
{
    public partial class Servisim : ServiceBase
    {
        public Timer t;
        public Servisim()
        {
            InitializeComponent();
            t = new Timer(30000); //30 saniye
            t.Elapsed += T_Elapsed;
        }

        private void T_Elapsed(object sender, ElapsedEventArgs e)
        {
            //burada SQL e bağlanıp kayıt oluşturacağız.
            DAL D = new DAL();
            D.OlayGunluguYeniKayit("Servis çalıştı", DateTime.Now);
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
            t.Start();
        }

        protected override void OnPause()
        {
            //servis pause edildiği zaman çalışacak olan metod
            t.Stop();
        }

        protected override void OnContinue()
        {
            //pause işleminden devam ettirildiği zaman çalışacak olan metod.
            t.Start();
        }

        protected override void OnStop()
        {
            //Servis durdurulduğu zaman çalışacak olan metod.
            t.Stop();
        }

        protected override void OnShutdown()
        {
            //servis shutdown edildiği zaman çalışacak olan metod.
            t.Stop();
        }
    }
}
