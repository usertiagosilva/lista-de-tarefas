namespace ListaDeTarefas
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string tarefa = txtTarefa.Text.Trim();
            if (!string.IsNullOrEmpty(tarefa))
            {
                lstTarefas.Items.Add(tarefa);
                txtTarefa.Clear();
            }
            else
            {
                MessageBox.Show("A tarefa não pode estar vazia.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lstTarefas.SelectedIndex != -1)
            {
                string tarefaAtual = lstTarefas.SelectedItem.ToString();
                string novaTarefa = txtTarefa.Text.Trim();

                if (!string.IsNullOrEmpty(novaTarefa))
                {
                    lstTarefas.Items[lstTarefas.SelectedIndex] = novaTarefa;
                    txtTarefa.Clear();
                }
                else
                {
                    MessageBox.Show("A tarefa não pode estar vazia.");
                }
            }
            else
            {
                MessageBox.Show("Selecione uma tarefa para editar.");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lstTarefas.SelectedIndex != -1)
            {
                lstTarefas.Items.RemoveAt(lstTarefas.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Selecione uma tarefa para remover.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstTarefas.Items.Clear();
        }
    }
}
