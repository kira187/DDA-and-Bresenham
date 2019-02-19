using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDAvsBresenham
{
    class Linea
    {
        private float PuntoI;
        private float PuntoF;

        
        public void SetPuntoI(float PuntoI)
        {
            this.PuntoI = PuntoI;
        }

        public void SetPuntof(float PuntoF)
        {
            this.PuntoF = PuntoF;
        }
        

        public float GetPuntoI()
        {
            return PuntoI;
        }

        public float GetPuntoF()
        {
            return PuntoF;
        }
    }

    
}
