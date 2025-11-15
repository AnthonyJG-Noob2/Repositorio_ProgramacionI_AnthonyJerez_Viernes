using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactesClassLib
{
    internal class Contactes
    {
        public int AId {get; set;}
        public string AName {get; set;}
        public string AEmail { get; set; }
        public string APhone { get; set; }
        public string AAddress { get; set; }

        public Contactes(int BId,string BName, string BEmail, string BPhone, string BAddress) {

            this.AId = BId;
            this.AName = BName;
            this.AEmail = BEmail;
            this.APhone = BPhone;
            this.AAddress = BAddress;
        }
    }

}
