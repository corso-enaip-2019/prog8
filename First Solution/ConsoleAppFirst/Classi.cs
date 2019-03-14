using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFirst
{
    class Switch
    {
        void Click()
        {
            LightBulb philipsHue400w = new LightBulb(400, 1200);
            //int c = philipsHue400w.Consumption;
            //philipsHue400w.Consumption = 400;

            if (philipsHue400w.TurnedOn)
            {
                philipsHue400w.TurnOff();
            }
            else
            {
                philipsHue400w.TurnOn();
            }

            LightBulb ikeaBulb = new LightBulb(15, 600);

            
            LightBulb b = philipsHue400w;
            philipsHue400w = null; // philisHue400 diventa null
            b.TurnOff(); //b rimane attivo e quindi cambierà a false
        }
    }

    class LightBulb  //rappresenta la struttura di un oggetto: come è fatto e cosa fa
    {
        //caratteristiche
        int _consumption; // '_' indica la globalità della variabile
        int _lumen;       // variabili globali che quindi funzioneranno in ogni metodo contenuto nella classe LightBulb
        
        //stato
        bool _turnedOn;

        //costruttore
        //public LightBulb() //private(default) o public
        //{                  //rappresenta il metodo che viene chiamato nel momenti in cui voglio chiamare una classe
        //}
        public LightBulb (int consumption, int lumen)
        {
            _consumption = consumption;
            //_lumen = lumen;
            Lumen = lumen;

            _turnedOn = false;
        }

        //property
        public bool TurnedOn
        {
            get
            {
                return _turnedOn; //espongo solo il valore senza renderlo modificabile
            }
        }

        public int Consumption //property
        {
            get
            {
                return _consumption; //prende il valore
            }
            set
            {
                _consumption = value; //setta il valore
            }
        }

        public int Lumen { get; } // nessun valore set = read only 'set;' pubblico || 'private set' privato nella classe
        //public int Lumen
        //{
        //    get
        //    {
        //        return _lumen;
        //    }
        //    set
        //    {
        //        _lumen = value;
        //    }
        //}

        //int GetConsumption()
        //{
        //    return _consumption;
        //}
        //void SetConsumption(int value)
        //{
        //    _consumption = value;
        //}

        public void TurnOn()
        {
            _turnedOn = true;
        }

        public void TurnOff()
        {
            _turnedOn = false;
        }
    }
}
