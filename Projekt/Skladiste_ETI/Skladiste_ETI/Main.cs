﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skladiste_ETI
{
    public partial class Main : Form
    {
        public Main()
        {
            
            InitializeComponent();
            this.label1.Text = UserInformation.CurrentLoggedInUser;
        }

      
    }
}
