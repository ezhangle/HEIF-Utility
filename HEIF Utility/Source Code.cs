﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HEIF_Utility
{
    public partial class sc : Form
    {
        public sc(string str)
        {
            InitializeComponent();
            richTextBox1.Text = str;
        }
    }
}
