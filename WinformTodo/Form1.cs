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
            Todo myTodo = new Todo(txtTaskDiscription.Text, DateTime.Parse(ddb.Text));

            MessageBox.Show(myTodo.ToString());

        }


    }
}
