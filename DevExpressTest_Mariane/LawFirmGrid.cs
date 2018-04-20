using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace DevExpressTest_Mariane
{
    public class LawFirmGrid
    {
        #region --- Properties and Backing Fields ---
        [DisplayName("Law Firm Name")]
        public string LawFirmName
        {
            get; set;
        }

        [Browsable(false)]
        [DisplayName("Address")]
        public string Address
        {
            get; set;
        }

        [Browsable(false)]
        [DisplayName("Phone")]
        public string Phone
        {
            get; set;
        }

        [Browsable(false)]
        [DisplayName("E-mail")]
        public string Email
        {
            get; set;
        }
        #endregion

        #region --- Ctors() ---
        public LawFirmGrid()
        {
        }

        public LawFirmGrid(string lawFirmName,
                           string address,
                           string phone,
                           string email)
        {
            this.LawFirmName = lawFirmName;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
        }

        #endregion

        public static List<LawFirmGrid> CreateList()
        {
            List<LawFirmGrid> lstFirm = new List<LawFirmGrid>();
            lstFirm.Add(new LawFirmGrid("DSA", "123 Elizabeth Street", "0416123120", "dsa@dsa.com.au"));
            lstFirm.Add(new LawFirmGrid("SA", "23 Flinders Street", "0413063120", "sa@sa.com.au"));
            lstFirm.Add(new LawFirmGrid("Waters & Smith", "55 Queen Street", "0414120333", "wa@wa.com.au"));
            return lstFirm;
        }

        public override string ToString()
        {
            return $"LawFirmName: {this.LawFirmName}";
        }
    }
}
