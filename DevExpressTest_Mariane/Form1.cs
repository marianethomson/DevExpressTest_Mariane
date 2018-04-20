using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevExpressTest_Mariane
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            this.InitializeComponent();
            this.PostInitializeComponent();
        }

        private List<ClaimGrid> list;
        private List<LawFirmGrid> lstFirm;

        private void PostInitializeComponent()
        {
            this.list = ClaimGrid.CreateList();
            this.claimsGridControl.DataSource = this.list;
            this.lstFirm = LawFirmGrid.CreateList();
            this.lawFirmGridControl.DataSource = this.lstFirm;
        }

        private void claimGridView_FocusedRowChanged(object sender,
                                                     FocusedRowChangedEventArgs e)
        {
            if(e.FocusedRowHandle < 0)
            {
                return;
            }
            int dsRowIndex = this.claimsGridView.GetDataSourceRowIndex(e.FocusedRowHandle);
            // List<Claim> list = this.claimsGridControl.DataSource as List<Claim>;
            // object o = this.claimsGridControl.DataSource;
            ClaimGrid claimGrid = this.list[dsRowIndex];
            ClaimProps claimProps = new ClaimProps(claimGrid);
            this.claimPropertyGridControl.SelectedObject = claimProps;

            //claimProps.LawFirm;
            // this.lawFirmGridView.FocusedRowHandle = 2;
            //this.lawFirmGridControl.[0];
            //int rhFound = this.lawFirmGridView.LocateByDisplayText(0,
            //                                                       column,
            //                                                       claimProps.LawFirm);
            //// focusing the cell 
            //if(rhFound != GridControl.InvalidRowHandle)
            //{
            //    this.lawFirmGridView.FocusedRowHandle = rhFound;
            //    this.lawFirmGridView.FocusedColumn = column;
            //}
        }

        private void lawFirmGridView_FocusedRowChanged(object sender,
                                                       FocusedRowChangedEventArgs e)
        {
            if(e.FocusedRowHandle < 0)
            {
                return;
            }
            int dsFirmRowIndex = this.lawFirmGridView.GetDataSourceRowIndex(e.FocusedRowHandle);
            LawFirmGrid lawFirmGrid = this.lstFirm[dsFirmRowIndex];
            LawFirmProps lawFirmProps = new LawFirmProps(lawFirmGrid);
            this.lawFirmPropertyGridControl.SelectedObject = lawFirmProps;
        }
    }
}
