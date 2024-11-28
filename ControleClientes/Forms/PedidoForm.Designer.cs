namespace ControleClientes
{
    partial class PedidoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSalvarPedido = new Button();
            pnlAcaoPedido = new Panel();
            btnExcluirPedido = new Button();
            btnCancelarPedido = new Button();
            tabPedidoConsulta = new TabPage();
            gridPedidos = new DataGridView();
            GridProdId = new DataGridViewTextBoxColumn();
            GridProdDesc = new DataGridViewTextBoxColumn();
            GridProdNome = new DataGridViewTextBoxColumn();
            GridProdPreco = new DataGridViewTextBoxColumn();
            pnlAcao = new Panel();
            btnVisualizar = new Button();
            btnNovoProd = new Button();
            pnlPesquisa = new Panel();
            btnPesquisar = new Button();
            txtPesquisa = new TextBox();
            tabPedidoCadastro = new TabPage();
            numericUpDownQuantidade = new NumericUpDown();
            cmbBoxProduto = new ComboBox();
            QtdeItemLbl = new Label();
            ProdItemLbl = new Label();
            btnAddItem = new Button();
            DataPedLbl = new Label();
            NomeCliePedLbl = new Label();
            cmbBoxStatus = new ComboBox();
            StatusPedLbl = new Label();
            dateTimePickerDataPedido = new DateTimePicker();
            cmbBoxCliente = new ComboBox();
            panel1 = new Panel();
            gridProdutosPedido = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            tabPedido = new TabControl();
            pnlAcaoPedido.SuspendLayout();
            tabPedidoConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPedidos).BeginInit();
            pnlAcao.SuspendLayout();
            pnlPesquisa.SuspendLayout();
            tabPedidoCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridProdutosPedido).BeginInit();
            tabPedido.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvarPedido
            // 
            btnSalvarPedido.Location = new Point(745, 2);
            btnSalvarPedido.Margin = new Padding(3, 4, 3, 4);
            btnSalvarPedido.Name = "btnSalvarPedido";
            btnSalvarPedido.Size = new Size(86, 31);
            btnSalvarPedido.TabIndex = 0;
            btnSalvarPedido.Text = "Salvar";
            btnSalvarPedido.UseVisualStyleBackColor = true;
            btnSalvarPedido.Click += btnSalvarPedido_Click;
            // 
            // pnlAcaoPedido
            // 
            pnlAcaoPedido.Controls.Add(btnExcluirPedido);
            pnlAcaoPedido.Controls.Add(btnCancelarPedido);
            pnlAcaoPedido.Controls.Add(btnSalvarPedido);
            pnlAcaoPedido.Dock = DockStyle.Bottom;
            pnlAcaoPedido.Location = new Point(3, 485);
            pnlAcaoPedido.Margin = new Padding(3, 4, 3, 4);
            pnlAcaoPedido.Name = "pnlAcaoPedido";
            pnlAcaoPedido.Size = new Size(928, 37);
            pnlAcaoPedido.TabIndex = 5;
            // 
            // btnExcluirPedido
            // 
            btnExcluirPedido.Location = new Point(6, 4);
            btnExcluirPedido.Margin = new Padding(3, 4, 3, 4);
            btnExcluirPedido.Name = "btnExcluirPedido";
            btnExcluirPedido.Size = new Size(86, 31);
            btnExcluirPedido.TabIndex = 2;
            btnExcluirPedido.Text = "Excluir";
            btnExcluirPedido.UseVisualStyleBackColor = true;
            // 
            // btnCancelarPedido
            // 
            btnCancelarPedido.Location = new Point(837, 3);
            btnCancelarPedido.Margin = new Padding(3, 4, 3, 4);
            btnCancelarPedido.Name = "btnCancelarPedido";
            btnCancelarPedido.Size = new Size(86, 31);
            btnCancelarPedido.TabIndex = 1;
            btnCancelarPedido.Text = "Cancelar";
            btnCancelarPedido.UseVisualStyleBackColor = true;
            btnCancelarPedido.Click += btnCancelarPedido_Click;
            // 
            // tabPedidoConsulta
            // 
            tabPedidoConsulta.Controls.Add(gridPedidos);
            tabPedidoConsulta.Controls.Add(pnlAcao);
            tabPedidoConsulta.Controls.Add(pnlPesquisa);
            tabPedidoConsulta.Location = new Point(4, 29);
            tabPedidoConsulta.Margin = new Padding(3, 4, 3, 4);
            tabPedidoConsulta.Name = "tabPedidoConsulta";
            tabPedidoConsulta.Padding = new Padding(3, 4, 3, 4);
            tabPedidoConsulta.Size = new Size(934, 526);
            tabPedidoConsulta.TabIndex = 0;
            tabPedidoConsulta.Text = "Consulta";
            tabPedidoConsulta.UseVisualStyleBackColor = true;
            tabPedidoConsulta.Click += tabPedidoConsulta_Click;
            // 
            // gridPedidos
            // 
            gridPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPedidos.Columns.AddRange(new DataGridViewColumn[] { GridProdId, GridProdDesc, GridProdNome, GridProdPreco });
            gridPedidos.Location = new Point(3, 45);
            gridPedidos.Margin = new Padding(3, 4, 3, 4);
            gridPedidos.Name = "gridPedidos";
            gridPedidos.RowHeadersWidth = 20;
            gridPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridPedidos.Size = new Size(928, 210);
            gridPedidos.TabIndex = 7;
            // 
            // GridProdId
            // 
            GridProdId.HeaderText = "ID";
            GridProdId.MinimumWidth = 6;
            GridProdId.Name = "GridProdId";
            // 
            // GridProdDesc
            // 
            GridProdDesc.HeaderText = "Cliente";
            GridProdDesc.MinimumWidth = 6;
            GridProdDesc.Name = "GridProdDesc";
            // 
            // GridProdNome
            // 
            GridProdNome.HeaderText = "Data Pedido";
            GridProdNome.MinimumWidth = 6;
            GridProdNome.Name = "GridProdNome";
            // 
            // GridProdPreco
            // 
            GridProdPreco.HeaderText = "Status";
            GridProdPreco.MinimumWidth = 6;
            GridProdPreco.Name = "GridProdPreco";
            // 
            // pnlAcao
            // 
            pnlAcao.Controls.Add(btnVisualizar);
            pnlAcao.Controls.Add(btnNovoProd);
            pnlAcao.Dock = DockStyle.Bottom;
            pnlAcao.Location = new Point(3, 481);
            pnlAcao.Margin = new Padding(3, 4, 3, 4);
            pnlAcao.Name = "pnlAcao";
            pnlAcao.Size = new Size(928, 41);
            pnlAcao.TabIndex = 6;
            // 
            // btnVisualizar
            // 
            btnVisualizar.Location = new Point(745, 5);
            btnVisualizar.Margin = new Padding(3, 4, 3, 4);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(86, 31);
            btnVisualizar.TabIndex = 0;
            btnVisualizar.Text = "Visualizar";
            btnVisualizar.UseVisualStyleBackColor = true;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // btnNovoProd
            // 
            btnNovoProd.Location = new Point(837, 6);
            btnNovoProd.Margin = new Padding(3, 4, 3, 4);
            btnNovoProd.Name = "btnNovoProd";
            btnNovoProd.Size = new Size(86, 31);
            btnNovoProd.TabIndex = 1;
            btnNovoProd.Text = "Novo";
            btnNovoProd.UseVisualStyleBackColor = true;
            btnNovoProd.Click += btnNovoProd_Click;
            // 
            // pnlPesquisa
            // 
            pnlPesquisa.Controls.Add(btnPesquisar);
            pnlPesquisa.Controls.Add(txtPesquisa);
            pnlPesquisa.Dock = DockStyle.Top;
            pnlPesquisa.Location = new Point(3, 4);
            pnlPesquisa.Margin = new Padding(3, 4, 3, 4);
            pnlPesquisa.Name = "pnlPesquisa";
            pnlPesquisa.Size = new Size(928, 41);
            pnlPesquisa.TabIndex = 5;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(753, 4);
            btnPesquisar.Margin = new Padding(3, 4, 3, 4);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(129, 31);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(5, 6);
            txtPesquisa.Margin = new Padding(3, 4, 3, 4);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "Pesquisar por nome";
            txtPesquisa.Size = new Size(746, 27);
            txtPesquisa.TabIndex = 2;
            // 
            // tabPedidoCadastro
            // 
            tabPedidoCadastro.Controls.Add(numericUpDownQuantidade);
            tabPedidoCadastro.Controls.Add(cmbBoxProduto);
            tabPedidoCadastro.Controls.Add(QtdeItemLbl);
            tabPedidoCadastro.Controls.Add(ProdItemLbl);
            tabPedidoCadastro.Controls.Add(btnAddItem);
            tabPedidoCadastro.Controls.Add(DataPedLbl);
            tabPedidoCadastro.Controls.Add(NomeCliePedLbl);
            tabPedidoCadastro.Controls.Add(cmbBoxStatus);
            tabPedidoCadastro.Controls.Add(StatusPedLbl);
            tabPedidoCadastro.Controls.Add(dateTimePickerDataPedido);
            tabPedidoCadastro.Controls.Add(cmbBoxCliente);
            tabPedidoCadastro.Controls.Add(panel1);
            tabPedidoCadastro.Controls.Add(pnlAcaoPedido);
            tabPedidoCadastro.Location = new Point(4, 29);
            tabPedidoCadastro.Margin = new Padding(3, 4, 3, 4);
            tabPedidoCadastro.Name = "tabPedidoCadastro";
            tabPedidoCadastro.Padding = new Padding(3, 4, 3, 4);
            tabPedidoCadastro.Size = new Size(934, 526);
            tabPedidoCadastro.TabIndex = 1;
            tabPedidoCadastro.Text = "Cadastro";
            tabPedidoCadastro.UseVisualStyleBackColor = true;
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.Location = new Point(292, 153);
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(92, 27);
            numericUpDownQuantidade.TabIndex = 24;
            // 
            // cmbBoxProduto
            // 
            cmbBoxProduto.FormattingEnabled = true;
            cmbBoxProduto.Location = new Point(23, 152);
            cmbBoxProduto.Name = "cmbBoxProduto";
            cmbBoxProduto.Size = new Size(231, 28);
            cmbBoxProduto.TabIndex = 23;
            // 
            // QtdeItemLbl
            // 
            QtdeItemLbl.AutoSize = true;
            QtdeItemLbl.Location = new Point(292, 119);
            QtdeItemLbl.Name = "QtdeItemLbl";
            QtdeItemLbl.Size = new Size(87, 20);
            QtdeItemLbl.TabIndex = 22;
            QtdeItemLbl.Text = "Quantidade";
            // 
            // ProdItemLbl
            // 
            ProdItemLbl.AutoSize = true;
            ProdItemLbl.Location = new Point(23, 119);
            ProdItemLbl.Name = "ProdItemLbl";
            ProdItemLbl.Size = new Size(129, 20);
            ProdItemLbl.TabIndex = 21;
            ProdItemLbl.Text = "Nome do Produto";
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(411, 150);
            btnAddItem.Margin = new Padding(3, 4, 3, 4);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(128, 31);
            btnAddItem.TabIndex = 1;
            btnAddItem.Text = "Adicionar Item";
            btnAddItem.UseVisualStyleBackColor = true;
            // 
            // DataPedLbl
            // 
            DataPedLbl.AutoSize = true;
            DataPedLbl.Location = new Point(248, 21);
            DataPedLbl.Name = "DataPedLbl";
            DataPedLbl.Size = new Size(91, 20);
            DataPedLbl.TabIndex = 19;
            DataPedLbl.Text = "Data Pedido";
            // 
            // NomeCliePedLbl
            // 
            NomeCliePedLbl.AutoSize = true;
            NomeCliePedLbl.Location = new Point(23, 21);
            NomeCliePedLbl.Name = "NomeCliePedLbl";
            NomeCliePedLbl.Size = new Size(100, 20);
            NomeCliePedLbl.TabIndex = 18;
            NomeCliePedLbl.Text = "Nome Cliente";
            // 
            // cmbBoxStatus
            // 
            cmbBoxStatus.FormattingEnabled = true;
            cmbBoxStatus.Location = new Point(720, 53);
            cmbBoxStatus.Name = "cmbBoxStatus";
            cmbBoxStatus.Size = new Size(184, 28);
            cmbBoxStatus.TabIndex = 17;
            // 
            // StatusPedLbl
            // 
            StatusPedLbl.AutoSize = true;
            StatusPedLbl.Location = new Point(720, 21);
            StatusPedLbl.Name = "StatusPedLbl";
            StatusPedLbl.Size = new Size(99, 20);
            StatusPedLbl.TabIndex = 16;
            StatusPedLbl.Text = "Status Pedido";
            // 
            // dateTimePickerDataPedido
            // 
            dateTimePickerDataPedido.Location = new Point(248, 54);
            dateTimePickerDataPedido.Name = "dateTimePickerDataPedido";
            dateTimePickerDataPedido.Size = new Size(250, 27);
            dateTimePickerDataPedido.TabIndex = 15;
            // 
            // cmbBoxCliente
            // 
            cmbBoxCliente.FormattingEnabled = true;
            cmbBoxCliente.Location = new Point(23, 53);
            cmbBoxCliente.Name = "cmbBoxCliente";
            cmbBoxCliente.Size = new Size(184, 28);
            cmbBoxCliente.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.Controls.Add(gridProdutosPedido);
            panel1.Location = new Point(0, 199);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 283);
            panel1.TabIndex = 13;
            // 
            // gridProdutosPedido
            // 
            gridProdutosPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridProdutosPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProdutosPedido.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            gridProdutosPedido.Dock = DockStyle.Fill;
            gridProdutosPedido.Location = new Point(0, 0);
            gridProdutosPedido.Margin = new Padding(3, 4, 3, 4);
            gridProdutosPedido.Name = "gridProdutosPedido";
            gridProdutosPedido.RowHeadersWidth = 20;
            gridProdutosPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridProdutosPedido.Size = new Size(934, 283);
            gridProdutosPedido.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Produto";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Quantidade";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Preco Unitário";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Total";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // tabPedido
            // 
            tabPedido.Controls.Add(tabPedidoConsulta);
            tabPedido.Controls.Add(tabPedidoCadastro);
            tabPedido.Dock = DockStyle.Fill;
            tabPedido.Location = new Point(0, 0);
            tabPedido.Margin = new Padding(3, 4, 3, 4);
            tabPedido.Name = "tabPedido";
            tabPedido.SelectedIndex = 0;
            tabPedido.Size = new Size(942, 559);
            tabPedido.TabIndex = 3;
            // 
            // PedidoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 559);
            Controls.Add(tabPedido);
            Name = "PedidoForm";
            Text = "PedidoForm";
            Load += PedidoForm_Load;
            pnlAcaoPedido.ResumeLayout(false);
            tabPedidoConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridPedidos).EndInit();
            pnlAcao.ResumeLayout(false);
            pnlPesquisa.ResumeLayout(false);
            pnlPesquisa.PerformLayout();
            tabPedidoCadastro.ResumeLayout(false);
            tabPedidoCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridProdutosPedido).EndInit();
            tabPedido.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label DescProdLbl;
        private TextBox textBoxNomeProd;
        private Label NameProdLbl;
        private Button btnSalvarPedido;
        private Panel pnlAcaoPedido;
        private Button btnCancelarPedido;
        private TextBox textBoxDescProd;
        private TabPage tabProdutoConsulta;
        private DataGridView gridPedidos;
        private Panel pnlAcao;
        private Button btnVisualizar;
        private Button btnNovoProd;
        private Panel pnlPesquisa;
        private Button btnPesquisar;
        private TextBox txtPesquisa;
        private TabPage tabPedidoCadastro;
        private DataGridView gridProdutosPedido;
        private TabControl tabPedido;
        private Panel panel1;
        private Button btnAddItem;
        private ComboBox cmbBoxCliente;
        private Button btnExcluirPedido;
        private ComboBox cmbBoxStatus;
        private Label StatusPedLbl;
        private DateTimePicker dateTimePickerDataPedido;
        private Label DataPedLbl;
        private Label NomeCliePedLbl;
        private TabPage tabPedidoConsulta;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn GridProdId;
        private DataGridViewTextBoxColumn GridProdDesc;
        private DataGridViewTextBoxColumn GridProdNome;
        private DataGridViewTextBoxColumn GridProdPreco;
        private NumericUpDown numericUpDownQuantidade;
        private ComboBox cmbBoxProduto;
        private Label QtdeItemLbl;
        private Label ProdItemLbl;
    }
}