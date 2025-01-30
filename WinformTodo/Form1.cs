namespace WinformTodo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void submitForm(object sender, EventArgs e)
        {

            // where we handle the add event
            Todo myTodo = new Todo(txtTaskDiscription.Text, DateTime.Parse(txtDueDate.Text));

            // MessageBox.Show(myTodo.ToString());

            // check if the todo is valid
            // if it is not display an error
            // exit

            // take that todo and insert it into my list
            lbTaskList.Items.Add(myTodo.ToString());


            ClearForm();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            MessageBox.Show("Form cleared");
        }

        private void ClearForm()
        {
            txtTaskDiscription.Clear();
            txtDueDate.Clear();

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) 
            {
               submitForm(sender, e);
            }
        }
    }
}
