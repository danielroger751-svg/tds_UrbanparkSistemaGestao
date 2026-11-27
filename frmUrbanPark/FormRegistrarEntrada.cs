using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmUrbanPark
{
    public partial class FrmRegistrarEntrada : Form
    {

        private string _numVaga;
        private int _idVaga;


        public FrmRegistrarEntrada()
        {
            InitializeComponent();
        }



        public FrmRegistrarEntrada(string numVaga, int idVaga) : this()
        {
            _numVaga = numVaga;
            _idVaga = idVaga;
        }

        private void FrmRegistrarEntrada_Load(object sender, EventArgs e)
        {

            txtVagaSelecionada.Text = _numVaga;

        }
    }
}
