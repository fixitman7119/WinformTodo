namespace WinformTodo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            // where we handle the add event
            Todo myTodo = new Todo(txtTaskDiscription.Text, DateTime.Parse(txtDueDate.Text));

            MessageBox.Show(myTodo.ToString());

        }

        private void txtTaskDiscription_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ddb_Click(object sender, EventArgs e)
        {

        }
    }
}
