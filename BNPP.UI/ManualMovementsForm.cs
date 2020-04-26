using BNPP.Domain.Interfaces.Services;
using BNPP.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BNPP.UI
{
    public partial class ManualMovementsForm : Form
    {
        private readonly IManualMovementsService _manualMovementsService;
        private readonly IProductCosifService _productCosifService;
        private readonly IProductService _productService;
        public ManualMovementsForm(IManualMovementsService manualMovementsService, IProductCosifService productCosifService, IProductService productService)
        {
            _manualMovementsService = manualMovementsService;
            _productCosifService = productCosifService;
            _productService = productService;
            InitializeComponent();
        }

        private void ManualMovements_Load(object sender, EventArgs e)
        {
            EnableOrDisableAll(false);
            LoadGrid();
            LoadProductComboBox();
            Limpar();
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            if (ValidarElementos())
            {
                IncluirElemento();
                btn_limpar_Click(sender, e);
                LoadGrid();
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            EnableOrDisableAll(true);
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar();
            EnableOrDisableAll(false);
        }


        private void EnableOrDisableAll(bool enable)
        {
            mtxt_ano.Enabled = enable;
            txt_descricao.Enabled = enable;
            mtxt_mes.Enabled = enable;
            txt_valor.Enabled = enable;

            cbx_produto.Enabled = enable;
            cbx_cosif.Enabled = enable;

            btn_incluir.Enabled = enable;
            btn_incluir.Enabled = enable;
        }

        private void Limpar()
        {
            cbx_produto.SelectedIndex = -1;
            cbx_cosif.SelectedIndex = -1;
            mtxt_ano.Clear();
            txt_descricao.Clear();
            mtxt_mes.Clear();
            txt_valor.Clear();
            cbx_cosif.Items.Clear();
        }

        private void LoadGrid()
        {
            List<ManualMovement> manualMovements = _manualMovementsService.GetAllManualMovements();

            var bindingList = new BindingList<ManualMovement>(manualMovements);
            var source = new BindingSource(bindingList, null);
            grid_movimentos.DataSource = source;

        }

        private void IncluirElemento()
        {
            Product product = (Product)cbx_produto.SelectedItem;
            ProductCosif productCosif = (ProductCosif)cbx_cosif.SelectedItem;

            int ano, mes;
            int.TryParse(mtxt_ano.Text, out ano);
            int.TryParse(mtxt_mes.Text, out mes);

            double valor;
            double.TryParse(txt_valor.Text.Replace(',','.'), out valor);


            _manualMovementsService.InsertManualMovement( new ManualMovement()
            {
                Cod_Produto = product.Cod_Produto,
                Cod_Usuario = "TESTE",
                Cod_Cosif = productCosif.Cod_Cosif,
                Dat_Ano = ano,
                Dat_Mes = mes,
                Des_Descricao = txt_descricao.Text,
                Val_Valor = valor
            });

            MessageBox.Show("Movimento Inserido com successo");
        }

        private bool ValidarElementos()
        {


            if(string.IsNullOrEmpty(mtxt_ano.Text))
            {
                MessageBox.Show("O ano é obrigatorio");
                return false;
            }

            if (string.IsNullOrEmpty(mtxt_mes.Text))
            {
                MessageBox.Show("O mes é obrigatorio");
                return false;
            }

            if (string.IsNullOrEmpty(txt_valor.Text))
            {
                MessageBox.Show("O valor é obrigatorio");
                return false;
            }

            int ano, mes;
            var isAnoNumeric = int.TryParse(mtxt_ano.Text, out ano);
            var isMesNumeric = int.TryParse(mtxt_mes.Text, out mes);

            var isValorDouble = double.TryParse(txt_valor.Text, out _);

            if (!isAnoNumeric)
            {
                MessageBox.Show("So é permitido numero no campo ano");
                return false;
            }

            if (!isMesNumeric)
            {
                MessageBox.Show("So é permitido numero no campo mes");
                return false;
            }

            if (!isValorDouble)
            {
                MessageBox.Show("So é permitido numeros no campo valor");
                return false;
            }

            if (ano < 1900)
            {
                MessageBox.Show("O ano selecionado não é valido");
                return false;
            }

            if (mes < 1 || mes > 12)
            {
                MessageBox.Show("O mes selecionado não é valido");
                return false;
            }

            if (string.IsNullOrEmpty(txt_valor.Text))
            {
                MessageBox.Show("O valor é obrigatorio");
                return false;
            }

            if (cbx_produto.SelectedIndex < 0)
            {
                MessageBox.Show("Deve selecionar um produto");
                return false;
            }

            if (cbx_cosif.SelectedIndex < 0)
            {
                MessageBox.Show("Deve selecionar um cosif");
                return false;
            }



            return true;
        }

        private void LoadProductComboBox()
        {
            List<Product> produtsList = _productService.GetAllProducts();
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = produtsList;

            cbx_produto.DataSource = bindingSource1.DataSource;

            cbx_produto.DisplayMember = "Des_Produto";
            cbx_produto.ValueMember = "Cod_Produto";
        }

        private void LoadProductCosifComboBox()
        {
            if (cbx_produto.SelectedIndex > -1)
            {
                Product product = (Product)cbx_produto.SelectedItem;

                List<ProductCosif> produtCosifList = _productCosifService.GetAllCosifByProduct(product.Cod_Produto);
                var bindingSource1 = new BindingSource();
                bindingSource1.DataSource = produtCosifList;

                cbx_cosif.DataSource = bindingSource1.DataSource;

                cbx_cosif.DisplayMember = "Cod_Classificacao";
                cbx_cosif.ValueMember = "Cod_Cosif";
            }
            else
            {
                cbx_cosif.DataSource = null;
                cbx_cosif.Items?.Clear();
            }
        }

        private void cbx_produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProductCosifComboBox();
        }
    }
}
