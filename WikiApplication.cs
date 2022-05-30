using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Name: Kristiin Tribbeck
// ID: 30045325
// Program demonstrates how a collection of information can be stored using a Windows Form Application. 
// This application utilises List<T> of a class object. 
namespace Wiki_Application_For_Junior_Programmers
{
    public partial class WikiApplication : Form
    {
        public WikiApplication()
        {
            InitializeComponent();
        }
       // 6.2 Create a global List<T> of type Information called Wiki.
        List<Information> Wiki = new List<Information>();
        // 6.3 Create a button method to ADD a new item to the list.
        //Use a TextBox for the Name input, ComboBox for the Category,
        //Radio group for the Structure and Multiline TextBox for the Definition.
        #region ADD Button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // ClearStatusMessage();
            if (!string.IsNullOrWhiteSpace(textboxName.Text))
            {
                Information newInfo = new Information();
                newInfo.setName(textboxName.Text);
                //newInfo.setPhone(textBoxPhone.Text);
                //newInfo.setPosition(textBoxPosition.Text);
                //AceEmp.Add(newInfo);
                //clearTextbox();
                //displayEmployees();
            }
        }
        #endregion
    }
}
