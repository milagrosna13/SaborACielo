using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaborAcielo
{
    public partial class FlistaUsuarios : Form
    {
        public FlistaUsuarios()
        {
            InitializeComponent();
        }

        private void CBapeUs_CheckedChanged(object sender, EventArgs e)
        {
            if( CBapeUs.Checked )
            {
                Tape_us.ReadOnly = false;
            } else
            {
                Tape_us.ReadOnly= true;
            }
        }

        private void CBnomUs_CheckedChanged(object sender, EventArgs e)
        {
            if(CBnomUs.Checked )
            {
                Tnom_us.ReadOnly = false;
            }
            else
            {
                Tnom_us.ReadOnly= true;
            }
        }

        private void CBdniUS_CheckedChanged(object sender, EventArgs e)
        {
            if(CBdniUS.Checked )
            {
                Tdni_us.ReadOnly = false;
            }else
            {
                Tdni_us.ReadOnly = true;
            }

        }
    }
}
