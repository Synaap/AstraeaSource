﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astraea
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
            this.AceEditor.Navigate(string.Format("file:///{0}bin/ace/editor.html", AppDomain.CurrentDomain.BaseDirectory));
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
