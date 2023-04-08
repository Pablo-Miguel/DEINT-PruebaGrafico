using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEINT_PruebaGrafico
{
    public partial class Form2 : Form
    {
        public String mensaje { get; set; }
        public Form2(String mensaje)
        {
            InitializeComponent();
            this.mensaje = mensaje;
            label1.Text = mensaje;
        }
        


    }
}
