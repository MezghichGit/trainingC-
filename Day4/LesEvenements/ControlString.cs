using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesEvenements
{
    // The event publisher class
    class ControlString
    {
        public delegate void dg_LongueurInvalide(); //Declared Delegate     
        public event dg_LongueurInvalide ev_LongueurInvalide; //Declared Events


        public delegate void dg_LongueurInvalide2(); //Declared Delegate     
        public event dg_LongueurInvalide2 ev_LongueurInvalide2; //Declared Events


        public void CheckString(string str)
        {

            if ((str.Length > 8) && (ev_LongueurInvalide != null))
            {
                ev_LongueurInvalide(); //Raised Event
            }
        }
    }
}
