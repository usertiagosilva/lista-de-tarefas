namespace ListaDeTarefas
{
    partial class form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTarefa = new TextBox();
            btnAdicionar = new Button();
            lstTarefas = new ListBox();
            btnEditar = new Button();
            btnRemover = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // txtTarefa
            // 
            txtTarefa.Location = new Point(120, 329);
            txtTarefa.Name = "txtTarefa";
            txtTarefa.Size = new Size(459, 27);
            txtTarefa.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(130, 390);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(94, 29);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // lstTarefas
            // 
            lstTarefas.FormattingEnabled = true;
            lstTarefas.Location = new Point(120, 12);
            lstTarefas.Name = "lstTarefas";
            lstTarefas.Size = new Size(459, 164);
            lstTarefas.TabIndex = 2;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(244, 390);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(358, 390);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(94, 29);
            btnRemover.TabIndex = 4;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(478, 390);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 29);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 467);
            Controls.Add(btnLimpar);
            Controls.Add(btnRemover);
            Controls.Add(btnEditar);
            Controls.Add(lstTarefas);
            Controls.Add(btnAdicionar);
            Controls.Add(txtTarefa);
            Name = "form1";
            Text = "Todo list";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTarefa;
        private Button btnAdicionar;
        private ListBox lstTarefas;
        private Button btnEditar;
        private Button btnRemover;
        private Button btnLimpar;
    }
}
