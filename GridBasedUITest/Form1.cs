﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;

namespace GridBasedUITest
{
    public partial class Form1 : RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a ExcelDataSource
            excelDataSource1.Fill();
        }
    }
}
