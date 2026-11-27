using backUrbanPark.Model.DTO;
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
            txtVagaSelecionada.Enabled = false;
        }

        private void btnBuscarPorPlaca_Click(object sender, EventArgs e)
        {

            DadosEntradaVeiculo? dadosVeiculo = new DadosEntradaVeiculo();

            dadosVeiculo = EntradaRepository.BuscarDadosPorPlaca(mskPlacaVeiculo.Text);
            if (dadosVeiculo == null)
            {
                MessageBox.Show("Veiculo não encontrado",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );
                txtNomeCliente.Clear();
                txtCorModelo.Clear();


                return;
            }

            btnRegistrarEntrada.Enabled = true;
            txtNomeCliente.Text = dadosVeiculo.NomeCliente;
            txtCorModelo.Text = $"{dadosVeiculo.Cor}/{dadosVeiculo.Modelo}";


            
        }
    }
}
