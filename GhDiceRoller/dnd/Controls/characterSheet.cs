﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnd.Controls
{
    public partial class characterSheet : UserControl
    {
        private dnd.Hero hero;
        public characterSheet(dnd.Hero hero)
        {
            InitializeComponent();
            this.hero = hero;
        }
    }
}
