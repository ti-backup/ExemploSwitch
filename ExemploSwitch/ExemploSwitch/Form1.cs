using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploSwitch
{
    public partial class Form1 : Form
    {
        List<String> veiculos;

        public Form1()
        {
            InitializeComponent();
            veiculos = new List<String>();
        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
            veiculos.Add("Moto");
            veiculos.Add("Carro");
            veiculos.Add("Bicicleta");
            veiculos.Add("Navio");

            PreencheComboVeiculos();
        }

        private void PreencheComboVeiculos()
        {
            for (Byte i = 0; i < veiculos.Count; i++)
            {
                cmbVeiculos.Items.Add(veiculos.ElementAt(i));
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            String opcao = cmbVeiculos.Text;
            switch (opcao)
            {
                case "Moto":
                    MessageBox.Show("mooooooto!!!");
                    break;
                case "Carro":
                    MessageBox.Show("caaaaarro!!!");
                    break;
                case "Bicicleta":
                    MessageBox.Show("biiiiiike!!!");
                    break;
                case "Navio":
                    MessageBox.Show("naviiiiio!!!");
                    break;
                default:
                    MessageBox.Show("Selecione uma opção");
                    break;
            }
        }
    }
}
