using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotes2._0
{
    public partial class HacerAyudante : Form
    {
        private Ibd listener;
        public HacerAyudante(object sender, string nombre)
        {
            if (sender is Ibd)
            {
                listener = (Ibd)sender;
            }
            InitializeComponent();
        }
    }
}
