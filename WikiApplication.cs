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
        // 6.4 Create and initialise a global string array with the six categories as indicated in the Data Structure Matrix.
        #region Properties
        List<Information> Wiki = new List<Information>();
        string[] categoryArray = new string[] { "Array", "Abstract", "Graph", "Hash", "List", "Tree" };
        string defaultFileName = "definitions.dat";
        int ptr = 0;
        #endregion
        // 6.3 Create a button method to ADD a new item to the list.
        // Use a TextBox for the Name input, ComboBox for the Category,
        // Radio group for the Structure and Multiline TextBox for the Definition.
        #region ADD Button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // ClearStatusMessage();
            if (!string.IsNullOrWhiteSpace(textboxName.Text) &&
                !string.IsNullOrWhiteSpace(comboBoxCategory.Text) &&
                !radioBtnLinear.Checked &&
                !string.IsNullOrWhiteSpace(textboxDefinition.Text))
            {
                Information newInfo = new Information();
                newInfo.setName(textboxName.Text);
                newInfo.setCategory(comboBoxCategory.Text);
                newInfo.setStructure(radioBtnNonLinear.Text);
                newInfo.setDefinition(textboxDefinition.Text);
                Wiki.Add(newInfo);
                //clearTextbox();
                //displayInformation();
            }
            else if (!string.IsNullOrWhiteSpace(textboxName.Text) &&
                     !string.IsNullOrWhiteSpace(comboBoxCategory.Text) &&
                     !radioBtnNonLinear.Checked &&
                     !string.IsNullOrWhiteSpace(textboxDefinition.Text))
            {
                Information newInfo = new Information();
                newInfo.setName(textboxName.Text);
                newInfo.setCategory(comboBoxCategory.Text);
                newInfo.setStructure(radioBtnLinear.Text);
                newInfo.setDefinition(textboxDefinition.Text);
                Wiki.Add(newInfo);
            }
            else
            {
                MessageBox.Show("Error! Select Linear or Non-Linear structure.");
            }
        }
        #endregion
        #region ClearTextboxes Method
        private void ClearAllTextBoxes()
        {
            textboxName.Clear();
            textboxDefinition.Clear();
        }
        #endregion
        // 6.4 Create a custom method to populate the ComboBox when the Form Load method is called.
        #region Populate Combobox Method
        private void FillCategoryComboBox()
        {
            for (int i = 0; i < categoryArray.Length; i++)
            {
                categoryArray[i].ToString();
            }
            comboBoxCategory.Items.AddRange(categoryArray);
        }
        #endregion
        #region ListviewBox
        private void listViewBox_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (Information info in Wiki)
            {
                //ListViewItem item = new ListViewItem();
                //item.Text = info.Name;
                //item.SubItems.Add(info.Position);
                //item.SubItems.Add(info.Team);
                //lstvPerson.Items.Add(item);
            }
        }
        #endregion
        #region Form Load
        private void WikiApplication_Load(object sender, EventArgs e)
        {
            FillCategoryComboBox();
        }
        #endregion
    }
}
