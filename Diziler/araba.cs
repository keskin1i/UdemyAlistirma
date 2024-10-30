using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class araba
    {
        private string marka;
        public int hız { get; set; }
        public string Marka
        {
            get { return marka; }

            set {  marka = value; }
           
        }
        public araba(string marka)
        {
            this.marka = marka;
        }

      
    }
}
