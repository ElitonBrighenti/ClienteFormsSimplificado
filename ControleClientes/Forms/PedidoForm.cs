using ControleClientes.Entidades;
using ControleClientes.Forms;
using ControleClientes.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;

namespace ControleClientes
{
    public partial class PedidoForm : Form
    {
        private readonly ClienteRepository _clienteRepository;
        private readonly ProdutoRepository _produtoRepository;  // Supondo que você tenha um ProdutoRepository
        private readonly PedidoRepository _pedidoRepository;

        private Pedido pedidoSelecionado;

        public PedidoForm()
        {
            InitializeComponent();
            _pedidoRepository = new PedidoRepository(new ApplicationDBContext());
            _clienteRepository = new ClienteRepository();
            _produtoRepository = new ProdutoRepository(new ApplicationDBContext());  // Instanciando o ProdutoRepository
            pedidoSelecionado = new Pedido();
            CarregarDados();
            LoadData();
            AdicionarGrafico();
        }
        private void AdicionarGrafico()
        {
            var plotModel = new PlotModel { Title = "Status dos Pedidos" };

            var pieSeries = new PieSeries
            {
                StrokeThickness = 1,
                //Fill = OxyColor.FromRgb(255, 255, 255),
                AngleSpan = 360,
                StartAngle = 0
            };

            // Adicionar dados ao gráfico de pizza
            pieSeries.Slices.Add(new PieSlice("Pendente", 5) { IsExploded = true });
            pieSeries.Slices.Add(new PieSlice("Concluído", 10));
            pieSeries.Slices.Add(new PieSlice("Cancelado", 3));

            plotModel.Series.Add(pieSeries);

            var plotView = new OxyPlot.WindowsForms.PlotView
            {
                Dock = DockStyle.Fill,
                Model = plotModel
            };

            this.Controls.Add(plotView); // Adiciona o gráfico ao formulário
        }

        private void CarregarDados()
        {
            cmbBoxCliente.DataSource = _clienteRepository.ReadAll();
            cmbBoxCliente.DisplayMember = "Nome";
            cmbBoxCliente.ValueMember = "Id";

            cmbBoxProduto.DataSource = _produtoRepository.ReadAll();
            cmbBoxProduto.DisplayMember = "Nome";
            cmbBoxProduto.ValueMember = "Id";

            cmbBoxStatus.DataSource = new List<string> { "Pendente", "Concluído", "Cancelado" };
        }

        // Método para limpar os campos de cadastro
        private void LimparCamposCadastro()
        {
            cmbBoxCliente.SelectedIndex = -1;
            cmbBoxProduto.SelectedIndex = -1;
            dateTimePickerDataPedido.Value = DateTime.Now;
            cmbBoxStatus.SelectedIndex = -1;
        }

        // Método para preencher os campos do pedido na tela de cadastro
        private void PreencherCamposCadastro()
        {
            cmbBoxCliente.SelectedValue = pedidoSelecionado.ClienteId;
            cmbBoxProduto.SelectedValue = pedidoSelecionado.ProdutoId;
            dateTimePickerDataPedido.Value = pedidoSelecionado.DataPedido;
            cmbBoxStatus.SelectedItem = pedidoSelecionado.Status;
        }
        private void btnNovoProd_Click(object sender, EventArgs e)
        {
            pedidoSelecionado = new Pedido(); // Limpar a seleção para um novo pedido
            LimparCamposCadastro();
            tabPedido.SelectTab(tabPedidoCadastro);
        }

        // Salva o pedido
        private void btnSalvarPedido_Click(object sender, EventArgs e)
        {
            // Verifica se todos os campos obrigatórios foram preenchidos
            if (cmbBoxCliente.SelectedItem == null || cmbBoxProduto.SelectedItem == null || cmbBoxStatus.SelectedItem == null)
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            // Preenche os dados do pedido
            pedidoSelecionado.ClienteId = (int)cmbBoxCliente.SelectedValue;
            pedidoSelecionado.ProdutoId = (int)cmbBoxProduto.SelectedValue;
            pedidoSelecionado.DataPedido = dateTimePickerDataPedido.Value.ToUniversalTime();  // Agora a data estará em UTC
            pedidoSelecionado.Status = cmbBoxStatus.SelectedItem.ToString();
            pedidoSelecionado.Quantidade = (int)numericUpDownQuantidade.Value; // Assume que você tem um campo para quantidade no formulário

            // Verifica se o pedido já existe (se o pedido foi carregado via 'Visualizar')
            if (pedidoSelecionado.Id > 0)  // Pedido já existe, portanto é um update
            {
                _pedidoRepository.Update(pedidoSelecionado);  // Chama o repositório para atualizar o pedido no banco
                MessageBox.Show("Pedido atualizado com sucesso!");
            }
            else
            {
                // Pedido não existe (novo pedido)
                _pedidoRepository.Create(pedidoSelecionado);  // Cria um novo pedido
                MessageBox.Show("Pedido salvo com sucesso!");
            }

            // Limpar os campos após salvar
            LimparCamposCadastro();
            tabPedido.SelectTab(tabPedidoConsulta);
        }



        // Método para atualizar o DataGridView de produtos
        private void AtualizarGridProdutos()
        {

        }

        // Cancela o pedido
        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            tabPedido.SelectTab(tabPedidoConsulta);
        }

        // Método de visualização de pedidos (aba de consulta)
        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (gridPedidos.SelectedRows.Count > 0)
            {
                // Pega o Id do pedido selecionado na grid
                int id = (int)gridPedidos.SelectedRows[0].Cells[0].Value;

                // Busca o pedido no repositório usando o Id
                pedidoSelecionado = _pedidoRepository.GetById(id);

                // Preenche os campos do formulário com os dados do pedido
                cmbBoxCliente.Text = pedidoSelecionado.Cliente.Nome;
                cmbBoxProduto.Text = pedidoSelecionado.Produto.Nome;
                dateTimePickerDataPedido.Value = pedidoSelecionado.DataPedido;  // A data pode ser no formato UTC
                cmbBoxStatus.Text = pedidoSelecionado.Status;
                numericUpDownQuantidade.Value = pedidoSelecionado.Quantidade;

                // Abre a aba de cadastro para edição
                tabPedido.SelectTab(tabPedidoCadastro);
            }
            else
            {
                MessageBox.Show("Selecione um pedido na lista.");
            }
        }

        private void PedidoForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            gridPedidos.Rows.Clear();
            foreach (var pedido in _pedidoRepository.ReadAll())
            {
                gridPedidos.Rows.Add(pedido.Id, pedido.ClienteId, pedido.DataPedido, pedido.Status);
            }
        }

        private void tabPedidoConsulta_Click(object sender, EventArgs e)
        {

        }
    }
}