using System.Xml.Schema;

namespace Pedido_Açaí_ORIGINAL
{
    public partial class Form1 : Form
    {
        double total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }



        private void checkBoxUva_CheckStateChanged(object sender, EventArgs e)
        {

        }



        private void listBoxPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton300ML_Click(object sender, EventArgs e)
        {

        }
        private void AtualizarPedido()
        {
            listBoxPedidos.Items.Clear();

            if (radioButton300ML.Checked)
                listBoxPedidos.Items.Add("Tamanho: 300 ML - R$ 12,00");
            else if (radioButton500ML.Checked)
                listBoxPedidos.Items.Add("Tamanho: 500 ML - R$ 16,00");
            else if (radioButton700ML.Checked)
                listBoxPedidos.Items.Add("Tamanho: 700 ML - R$ 18,00");
            else if (radioButton1L.Checked)
                listBoxPedidos.Items.Add("Tamanho: 1L - R$ 22,00");

            if (radioButtonComum.Checked)
                listBoxPedidos.Items.Add("Tipo: Comum");
            else if (radioButtonZero.Checked)
                listBoxPedidos.Items.Add("Tipo: Zero Açúcar");
            else if (radioButtonLaranja.Checked)
                listBoxPedidos.Items.Add("Tipo: Com Laranja");

            if (checkBoxLeiteCond.Checked)
                listBoxPedidos.Items.Add("Cobertura: Leite Condensado");
            if (checkBoxChoc.Checked)
                listBoxPedidos.Items.Add("Cobertura: Chocolate");
            if (checkBoxCobertMorango.Checked)
                listBoxPedidos.Items.Add("Cobertura: Morango");

            if (checkBoxLeiteEmPo.Checked)
                listBoxPedidos.Items.Add("Complemento: Leite em Pó (Ninho)");
            if (checkBoxGotasDeChocolate.Checked)
                listBoxPedidos.Items.Add("Complemento: Goias de chocolate");
            if (checkBoxChocoball.Checked)
                listBoxPedidos.Items.Add("Complemento: Chocoball");
            if (checkBoxConfete.Checked)
                listBoxPedidos.Items.Add("Complemento: Confete (MM's)");
            if (checkBoxOvomaltine.Checked)
                listBoxPedidos.Items.Add("Complemento: Ovomaltine");

            if (checkBoxMorango.Checked)
                listBoxPedidos.Items.Add("Fruta: Morango");
            if (checkBoxUva.Checked)
                listBoxPedidos.Items.Add("Fruta: Uva");
            if (checkBoxBanana.Checked)
                listBoxPedidos.Items.Add("Fruta: Banana");
            if (checkBoxManga.Checked)
                listBoxPedidos.Items.Add("Fruta: Manga");


            if (checkBoxDDL.Checked)
                listBoxPedidos.Items.Add("Adicional: Doce de Leite - R$ 1,00");
            if (checkBoxNTL.Checked)
                listBoxPedidos.Items.Add("Adicional: Nutella - R$ 2,00");
            if (checkBoxPCC.Checked)
                listBoxPedidos.Items.Add("Adicional: Paçoca - R$ 1,00");


            if (checkBoxLevar.Checked)
                listBoxPedidos.Items.Add("Situação: Para Levar");

            CalcularTotal();
        }
        private void CalcularTotal()
        {

            if (radioButton300ML.Checked == true)
            {
                total = total +12.00;

            }
            else if (radioButton500ML.Checked == true)
            {
                total = total + 16.00;
            }
            else if (radioButton700ML.Checked == true)
            {
                total = total + 18.00;
            }
            else if (radioButton1L.Checked == true)
            {
                total = total + 22.00;
            }
            if (checkBoxDDL.Checked == true)
            {
                total = total + 1.00;
            }
            if (checkBoxNTL.Checked == true)
            {
                total = total + 2.00;
            }
            if (checkBoxPCC.Checked == true)
            {
                total = total + 1.00;
            }
            textBoxTOTAL.Text = total.ToString("c2");
        }

        private void radioButton300ML_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarPedido();
        }

        private void radioButton500ML_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarPedido();
        }

        private void radioButton700ML_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarPedido();
        }

        private void radioButton1L_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarPedido();
        }

        private void radioButtonComum_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarPedido();
        }

        private void radioButtonZero_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarPedido();

        }

        private void radioButtonLaranja_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarPedido();

        }

        private void checkBoxLeiteEmPo_Click_1(object sender, EventArgs e)
        {
            AtualizarPedido();
        }

        private void checkBoxLeiteCond_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxChoc.Checked == true && checkBoxCobertMorango.Checked == true)
            {
                checkBoxLeiteCond.Checked = false;

            }
        }

        private void checkBoxChoc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLeiteCond.Checked == true && checkBoxCobertMorango.Checked == true)
            {
                checkBoxChoc.Checked = false;

            }
        }

        private void checkBoxCobertMorango_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxChoc.Checked == true && checkBoxLeiteCond.Checked == true)
            {
                checkBoxCobertMorango.Checked = false;

            }
        }

        private void checkBoxLeiteEmPo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGotasDeChocolate.Checked == true && checkBoxChocoball.Checked == true && checkBoxConfete.Checked == true && checkBoxOvomaltine.Checked == true)
            {
                checkBoxLeiteEmPo.Checked = false;

            }
        }

        private void checkBoxGotasDeChocolate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLeiteEmPo.Checked == true && checkBoxChocoball.Checked == true && checkBoxConfete.Checked == true && checkBoxOvomaltine.Checked == true)
            {
                checkBoxGotasDeChocolate.Checked = false;

            }
        }

        private void checkBoxChocoball_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGotasDeChocolate.Checked == true && checkBoxLeiteEmPo.Checked == true && checkBoxConfete.Checked == true && checkBoxOvomaltine.Checked == true)
            {
                checkBoxChocoball.Checked = false;

            }
        }

        private void checkBoxConfete_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGotasDeChocolate.Checked == true && checkBoxLeiteEmPo.Checked == true && checkBoxChocoball.Checked == true && checkBoxOvomaltine.Checked == true)
            {
                checkBoxConfete.Checked = false;

            }
        }

        private void checkBoxOvomaltine_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGotasDeChocolate.Checked == true && checkBoxLeiteEmPo.Checked == true && checkBoxConfete.Checked == true && checkBoxChocoball.Checked == true)
            {
                checkBoxOvomaltine.Checked = false;

            }
        }

        private void checkBoxUva_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMorango.Checked == true && checkBoxBanana.Checked == true && checkBoxManga.Checked == true)
            {
                checkBoxUva.Checked = false;

            }
        }

        private void checkBoxMorango_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUva.Checked == true && checkBoxBanana.Checked == true && checkBoxManga.Checked == true)
            {
                checkBoxMorango.Checked = false;

            }
        }

        private void checkBoxBanana_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMorango.Checked == true && checkBoxUva.Checked == true && checkBoxManga.Checked == true)
            {
                checkBoxBanana.Checked = false;

            }
        }

        private void checkBoxManga_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMorango.Checked == true && checkBoxBanana.Checked == true && checkBoxUva.Checked == true)
            {
                checkBoxManga.Checked = false;

            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string total2 = "";
            total2 = textBoxTOTAL.Text;
            if (total2 == "")
            {
                MessageBox.Show("selecione algo ");
            }
            else
            {
                MessageBox.Show("o total do seu pedido ficou " + total2);
            }
        }
    }
}