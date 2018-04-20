using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace DevExpressTest_Mariane
{
    public class ClaimGrid
    {
        #region --- Properties and Backing Fields ---
        [DisplayName("Plaintiffao")]
        public string Plaintiff
        {
            get; set;
        }

        [Browsable(false)]
        [DisplayName("Value")]
        public double ClaimValue
        {
            get; set;
        }

        [Browsable(false)]
        [DisplayName("Law Firm Name")]
        public string LawFirm
        {
            get; set;
        }

        [Browsable(false)]
        [DisplayName("Number")]
        public string ClaimNumber
        {
            get; set;
        }

        [Browsable(false)]
        [DisplayName("Court Name")]
        public string CourtName
        {
            get; private set;
        }
        #endregion

        #region --- Ctors() ---
        public ClaimGrid()
        {
        }

        public ClaimGrid(string plaintiff,
                     double claimValue,
                     string lawFirm)
        {
            this.Plaintiff = plaintiff;
            this.ClaimValue = claimValue;
            this.LawFirm = lawFirm;
        }

        public ClaimGrid(string plaintiff,
                     double claimValue,
                     string lawFirm,
                     string claimNumber,
                     string courtName)
        {
            this.Plaintiff = plaintiff;
            this.ClaimValue = claimValue;
            this.LawFirm = lawFirm;
            this.ClaimNumber = claimNumber;
            this.CourtName = courtName;
        }
        #endregion

        public static List<ClaimGrid> CreateList()
        {
            List<ClaimGrid> list = new List<ClaimGrid>();
            list.Add(new ClaimGrid("John Doe", 10.20, "DSA"));
            list.Add(new ClaimGrid("Jane Doe", 20.30, "SA"));
            list.Add(new ClaimGrid("Jane Doe", 20.30, "SA"));
            return list;
        }
        public override string ToString()
        {
            return $"Plaintiff: {this.Plaintiff}";
        }
    }
}
