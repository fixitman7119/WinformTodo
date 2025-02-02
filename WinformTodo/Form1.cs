using System.Web;

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
            
            // MessageBox.Show(myTodo.ToString());


            if (Validators.IsEmptyText(txtTaskDiscription)) 
            {
                MessageBox.Show("Discription is empty. Please provide a discription.");
                return;
            }

            if (Validators.IsTextNull(txtDueDate))
            {
                MessageBox.Show("Discripton needs to be created.");
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
      
            Todo myTodo = new Todo(txtTaskDiscription.Text, DateTime.Parse(txtDueDate.Text));

           
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
            //.Where(t => t.IsDone == false)
            .OrderBy(t => t.DueDate)
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

        private void lbTasklist_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show($"Selected Index is: {lbTaskList.SelectedIndex}"};
            int selectedIndex = lbTaskList.SelectedIndex;
            string selectedItem = (string)lbTaskList.SelectedItem;

            if (selectedIndex == -1)
            {
                return;
            }

            if (selectedItem == null)
            {
                MessageBox.Show("No item slected at the index.");
                return;
            }

            // STRING FORMAT: # - 01-01-2025 -  description - status: comlete

            int id = Int32.Parse(selectedItem.Split(" - ")[0]);

            //find the item in the list with the matching id, toggle its complete status
            var todo = TaskList.Find(t => t.Id == id);

            if (todo != null)
            {
                todo.IsDone = !todo.IsDone;
                UpdateListBox();
            }


        }
    }
}
