using System;
using System.ComponentModel;
using System.Linq;

namespace DevExpressTest_Mariane
{
    public class LawFirmProps
    {
        private LawFirmGrid o;

        #region --- Properties and Backing Fields ---
        [DisplayName("Law Firm Name")]
        public string LawFirmName
        {
            get { return o.LawFirmName; }
            set { o.LawFirmName = value;  }
        }

        [DisplayName("Address")]
        public string Address
        {
            get { return o.Address; }
            set { o.Address = value; }
        }

        [DisplayName("Phone")]
        public string Phone
        {
            get { return o.Phone; }
            set { o.Phone = value; } 
        }

        [DisplayName("E-mail")]
        public string Email
        {
            get { return o.Email; }
            set { o.Email = value; }
        }
        #endregion

        #region --- Ctors() ---
        public LawFirmProps(LawFirmGrid o)
        {
            this.o = o;
        }
        #endregion
    }
}
