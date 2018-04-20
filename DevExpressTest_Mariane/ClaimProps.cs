using System;
using System.ComponentModel;
using System.Linq;

namespace DevExpressTest_Mariane
{
    public class ClaimProps
    {
        #region --- Properties and Backing Fields ---
        [DisplayName("Plaintiffinho")]

        public string Plaintiff
        {
            get; set;
        }

        [DisplayName("Value")]
        public double ClaimValue
        {
            get; set;
        }

        [DisplayName("Law Firm Name")]
        public string LawFirm
        {
            get; set;
        }

        [DisplayName("Number")]
        public string ClaimNumber
        {
            get; set;
        }

        [DisplayName("Court Name")]
        public string CourtName
        {
            get; private set;
        }
        #endregion

        #region --- Ctors() ---
        public ClaimProps(ClaimGrid o)
        {
            this.Plaintiff = o.Plaintiff;
            this.ClaimValue = o.ClaimValue;
            this.LawFirm = o.LawFirm;
            this.ClaimNumber = o.ClaimNumber;
            this.CourtName = o.CourtName;
        }
        #endregion

    }
}
