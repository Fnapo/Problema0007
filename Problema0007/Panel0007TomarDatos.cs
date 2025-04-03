using PE0003;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema0007
{
    public partial class Panel0007TomarDatos : Panel0003TomarDatos
    {
        public decimal ValorCombo { get; protected set; }

        public Panel0007TomarDatos()
        {
            InitializeComponent();
            ValorComboCambia();
        }

        private void ControlNumericoLugar_ValueChanged(object sender, EventArgs e)
        {
            ValorComboCambia();
        }

        protected virtual void ValorComboCambia()
        {
            ValorCombo = controlNumericoLugar.Value;
        }
    }
}
