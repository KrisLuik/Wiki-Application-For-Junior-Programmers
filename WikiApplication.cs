using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            // if (!string.IsNullOrWhiteSpace(textboxName.Text) && (ValidName(textboxName.Text)))

            Information newInfo = new Information();
            newInfo.SetName(textboxName.Text);
            newInfo.SetCategory(comboBoxCategory.Text);
            newInfo.SetStructure(RadioButtonType());
            newInfo.SetDefinition(textboxDefinition.Text);
            Wiki.Add(newInfo);
            ptr++;
            Wiki.Sort();
            Display();
        }
        #endregion
        private void Display()
        {
            listViewItems.Sort();
            foreach (var information in Wiki)
            {
                listViewItems.Items.Add(information.DisplayDataStructures());
            }
        }
        #region ClearTextboxes Method
        private void ClearAllTextBoxes()
        {
            textboxName.Clear();
            textboxName.Focus();
            textboxDefinition.Clear();
        }
        #endregion
        // 6.4 Create a custom method to populate the ComboBox when the Form Load method is called.
        #region Populate Combobox Method
        private void FillCategoryComboBox()
        {
            //string[] dataString = File.ReadAllLines(@"categories.txt");
            //for (int x = 0; x <dataString.Length;x++)
            //{
            //    comboBoxCategory.Items.Add(dataString[x]);

            //}
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
            int currentItem = listViewItems.SelectedIndices[0];
            textboxName.Text = Wiki[currentItem].ToString();


        }
        #endregion
        #region Form Load
        private void WikiApplication_Load(object sender, EventArgs e)
        {
            FillCategoryComboBox();
        }
        #endregion
        // 6.6 Create two methods to highlight and return the values from the Radio button GroupBox.
        // The first method must return a string value from the selected radio button(Linear or Non-Linear).
        // The second method must send an integer index which will highlight an appropriate radio button.
        #region Radio button
        private string RadioButtonType()
        {
            string value = "";
            if (radioBtnLinear.Checked)
            {
                value = radioBtnLinear.Text;
                return "Linear";
            }
            else
            {
                radioBtnNonLinear.Checked = true;
                value = radioBtnNonLinear.Text;
                return "Non-Linear";
            }
        }
        private void HighlightRadioButton(int button)
        {
            if (button == 0)
            {
                radioBtnLinear.Checked = true;
            }
            else
            {
                radioBtnNonLinear.Checked = true;
            }
        }
        #endregion

        //6.5 Create a custom ValidName method which will take a parameter string value from the Textbox Name
        //and returns a Boolean after checking for duplicates.Use the built in List<T> method “Exists” to answer this requirement.
        #region Check duplicates
        private bool ValidName(string checkThisName)
        {
            // Trace.Listeners.Add(myTraceListener);
            if (Wiki.Exists(dup => dup.GetName() == checkThisName))
            {
                // Trace.WriteLine("Valid Name == false");
                return false;
            }
            else
            {
                // Trace.WriteLine("Valid Name == true");
                return true;
            }
        }
        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //ClearStatusMessage();
            int currentRecord = listViewItems.SelectedIndices[0];
            if (currentRecord >= 0)
            {
                DialogResult delRecord = MessageBox.Show("Do you wish to delete this definition?",
                 "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (delRecord == DialogResult.Yes)
                {
                    Wiki.RemoveAt(currentRecord);
                    Display();
                    ClearAllTextBoxes();
                }
                else
                {
                    MessageBox.Show("Item NOT Deleted", "Delete Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
