using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Reto3
{
    public class Maquinaria : NotificationObject
    {
        private int hora;

        public int Hora
        {
            get
            {
                return hora;
            }
            set
            {
                hora = value;
                OnPropertyChanged();
            }
        }

        private int minuto;

        public int Minuto
        {
            get
            {
                return minuto;
            }
            set
            {
                minuto = value;
                OnPropertyChanged();
            }
        }

        private int segundo;

        public int Segundo
        {
            get
            {
                return segundo;
            }
            set
            {
                segundo = value;
                OnPropertyChanged();
            }
        }

        public Maquinaria()
        {
            Timer aTimer = new Timer();
            aTimer.Elapsed += Time_Elapsed;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private void Time_Elapsed(object sender, ElapsedEventArgs e)
        {
            Hora = e.SignalTime.Hour;
            Minuto = e.SignalTime.Minute;
            Segundo = e.SignalTime.Second;
        }

    }
}