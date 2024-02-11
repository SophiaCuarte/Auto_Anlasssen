using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Motor
{
    public void Starten()
    {
        Console.WriteLine("Motor starten");
        Benzinpumpe benzinpumpe = new Benzinpumpe();
        Anlasser anlasser = new Anlasser();
        benzinpumpe.Pumpen();
        anlasser.Starten();
        Regeln();
    }

    public void Regeln()
    {
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine("Motor regeln");
        }
        Anlasser anlasser = new Anlasser();
        anlasser.Stoppen();
    }
}
