namespace WinformTodo
{
    public partial class Form1 : Form
    {

        private List<Todo> TaskList { get; set; }
        public Form1()
        {
            InitializeComponent();
            TaskList = new List<Todo>();
        }
        private void SubmitForm(object sender, EventArgs e)
        {
            // where we handle the add event
            Todo myTodo = new Todo(txtTaskDiscription.Text, DateTime.Parse(txtDueDate.Text));
            // MessageBox.Show(myTodo.ToString());
            // check if the todo is valid
            // if it is not display an error
            // exit
            if (Validators.IsEmptyText (txtTaskDiscription)) // Discription must exist.  Due date must be formated as a valid date.
            {
                MessageBox.Show("Discription is empty. Please provide a discription.");
                return;
            }

            if (Validators.IsEmptyText(txtDueDate))
            {
                MessageBox.Show("Missing a due date.");
                return;
                
            }
            if (!Validators.IsValidDate(txtDueDate))
            {
                MessageBox.Show("Date is incorectly formated.  Please try again.");
                return;
            }

            if(Validators.IsTextNull (txtDueDate))
            {
                MessageBox.Show("Discripton needs to be created.");
                return;
            }

            // take that todo and insert it into my list
           
            TaskList.Add(myTodo);

            UpdateListBox();

            ClearForm();
        }

        public void UpdateListBox()
        {
            // clear the contents of the list box
            lbTaskList.Items.Clear();
            // transform the list
            var list = TaskList
            .Where(t => t.IsDone == false)
            .ToList();
            // read in the new contents

            for (int i = 0; i < list.Count; i++)
            {
                lbTaskList.Items.Add(list[i].ToString());
            }
               // do any clean up if required
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
                SubmitForm(sender, e);
            }
        }

        
    }
}
