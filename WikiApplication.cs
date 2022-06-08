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
        // 6.4 Create and initialise a global string array with the six categories as indicated
        // in the Data Structure Matrix. Create a custom method to populate the ComboBox when the Form Load method is called.
        #region Properties
        List<Information> wiki = new List<Information>();
        static string[] categoryArray = new string[] { "Array", "Abstract", "Graph", "Hash", "List", "Tree" };
        //string defaultFileName = "definitions.bin";
        #endregion
        // 6.3 Create a button method to ADD a new item to the list. Use a TextBox for the Name input,
        // ComboBox for the Category, Radio group for the Structure and Multiline TextBox for the Definition.
        #region Add Button
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ClearStatusMessage();
            if (!string.IsNullOrWhiteSpace(textboxName.Text) && (ValidName(textboxName.Text)
                && !string.IsNullOrWhiteSpace(textboxDefinition.Text)))
            {
                Information newInfo = new Information();
                newInfo.SetName(textboxName.Text);
                newInfo.SetCategory(comboBoxCategory.Text);
                newInfo.SetStructure(RadioButtonType());
                newInfo.SetDefinition(textboxDefinition.Text);
                wiki.Add(newInfo);
                wiki.Sort();
                Display();
                ClearAllTextBoxes();
                toolStripStatusLabel.Text = "Definition added.";
            }
            else
            {
                toolStripStatusLabel.Text = "Error! Ensure name, category, structure, and definiton fields are filled.";
            }
        }
        #endregion
        // 6.7 Create a button method that will delete the currently selected record in the ListView.
        // Ensure the user has the option to backout of this action by using a dialog box.
        //  Display an updated version of the sorted list at the end of this process.
        #region Delete Button
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ClearStatusMessage();
            try
            {
                int currentItem = listViewItems.SelectedIndices[0];
                if (currentItem >= 0)
                {
                    DialogResult delRecord = MessageBox.Show("Do you wish to delete this definition?",
                     "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (delRecord == DialogResult.Yes)
                    {
                        wiki.RemoveAt(currentItem);
                        wiki.Sort();
                        ClearAllTextBoxes();
                        Display();
                        toolStripStatusLabel.Text = "Item deleted.";
                    }
                    else
                    {
                        MessageBox.Show("Item NOT Deleted", "Delete Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                toolStripStatusLabel.Text = "Error: Not a valid action.";
            }
        }
        #endregion
        // 6.8 Create a button method that will save the edited record of the currently selected item in the ListView.
        // All the changes in the input controls will be written back to the list.
        // Display an updated version of the sorted list at the end of this process.
        #region Edit Button
        private void BtnEdit_Click(object sender, EventArgs e)
        { 
            try
            {
                ClearStatusMessage();
                int currentItem = listViewItems.SelectedIndices[0];
                if (currentItem >= 0)
                {
                    var result = MessageBox.Show("Proceed with update?", "Edit Record",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        wiki[currentItem].SetName(textboxName.Text);
                        wiki[currentItem].SetCategory(comboBoxCategory.Text);
                        wiki[currentItem].SetStructure(RadioButtonType());
                        wiki[currentItem].SetDefinition(textboxDefinition.Text);
                        wiki.Sort();
                        Display();
                        ClearAllTextBoxes();
                        toolStripStatusLabel.Text = "Selected item updated.";
                    }
                    else
                    {
                        MessageBox.Show("Data Item NOT changed", "Edit Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        toolStripStatusLabel.Text = "Data item not changed.";
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                toolStripStatusLabel.Text = "Error: Please select an item from the list.";
            }
        }
        #endregion
        // 6.10 Create a button method that will use the built-in binary search to find a Data Structure name.
        // If the record is found the associated details will populate the appropriate input controls and highlight
        // the name  in the ListView. At the end of the search process the search input TextBox must be cleared. 
        #region Search Button
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            ClearStatusMessage();
            try
            {
                wiki.Sort();
                Information info = new Information();
                info.SetName(textboxSearch.Text);
                int result = wiki.BinarySearch(info);
                //  trace.listeners(new textwritertracelistener(console.out))
                if (result >= 0)
                {
                    listViewItems.SelectedItems.Clear();
                    listViewItems.Items[result].Selected = true;
                    listViewItems.Focus();
                    textboxName.Text = wiki[result].GetName();
                    comboBoxCategory.Text = wiki[result].GetCategory();
                    HighlightRadioButton(result);
                    textboxDefinition.Text = wiki[result].GetDefinition();
                    toolStripStatusLabel.Text = "Found at index: " + result + ".";
                }
                else
                {
                    toolStripStatusLabel.Text = "Not found.";
                    textboxSearch.Clear();
                    textboxSearch.Focus();
                    ClearAllTextBoxes();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                toolStripStatusLabel.Text = "";
                textboxSearch.Focus();
            }
        } 
        #endregion
        // 6.6 Create two methods to highlight and return the values from the Radio button GroupBox.
        // The first method must return a string value from the selected radio button (Linear or Non-Linear).
        // The second method must send an integer index which will highlight an appropriate radio button.
        // The input for the Structure must be two radio buttons inside a GroupBox.
        #region Radio Button
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
        // 6.14 Create two buttons for the manual open and save option; this must use a dialog box to select
        // a file or rename a saved file. All Wiki data is stored/retrieved using a binary file format.
        #region Open and Save Button
        private void BtnOpen_Click(object sender, EventArgs e)
        {
            ClearStatusMessage();
            OpenFileDialog openFd = new OpenFileDialog();
            openFd.InitialDirectory = @"c:\bin\";
            openFd.Filter = "BIN files(*.bin)|*.bin|All files(*.*)|*.*";
            openFd.Title = "Select a BIN File";

            if (openFd.ShowDialog() == DialogResult.OK)
            {
                wiki.Clear();
                listViewItems.Items.Clear();
                using (var stream = File.Open(openFd.FileName, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        try
                        {
                            wiki.Clear();
                            while (stream.Position < stream.Length)
                            {
                                Information readInformation = new Information();
                                readInformation.SetName(reader.ReadString());
                                readInformation.SetCategory(reader.ReadString());
                                readInformation.SetStructure(reader.ReadString());
                                readInformation.SetDefinition(reader.ReadString());
                                wiki.Add(readInformation);
                            }
                            reader.Close();
                        }
                        catch (Exception fe)
                        {
                            MessageBox.Show("Cannot read data from file." + fe);
                        }
                    }
                }
                wiki.Sort();
                Display();
                toolStripStatusLabel.Text = "File loaded.";
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Save();
            toolStripStatusLabel.Text = "Data items saved.";
        }
        private void Save()
        {
            ClearStatusMessage();
            SaveFileDialog saveFd = new SaveFileDialog();
            saveFd.InitialDirectory = @"c:\bin\";
            saveFd.Filter = "BIN files (*.bin)|*.bin|All files (*.*)|*.*";
            saveFd.Title = "Save a BIN File";

            if (saveFd.ShowDialog() == DialogResult.OK)
            {
                BinaryWriter bw;
                try
                {
                    bw = new BinaryWriter(new FileStream(saveFd.FileName, FileMode.Create));
                    foreach (var info in wiki)
                    {
                        bw.Write(info.GetName());
                        bw.Write(info.GetCategory());
                        bw.Write(info.GetStructure());
                        bw.Write(info.GetDefinition());
                    }
                    bw.Close();
                }
                catch (Exception fe)
                {
                    MessageBox.Show(fe.Message + "\n Cannot append to file.");
                    return;
                }
            }
        }
        #endregion
        // 6.11 Create a ListView event so a user can select a Data Structure Name from the list
        // of Names and the associated information will be displayed in the related text boxes combo box and radio button.
        #region Listview Methods
        private void ClearListView()
        {
            listViewItems.Clear();
        }
        private void ListViewBox_MouseClick(object sender, MouseEventArgs e)
        {
            ClearStatusMessage();
            int currentItem = listViewItems.SelectedIndices[0];
            textboxName.Text = wiki[currentItem].GetName();
            comboBoxCategory.Text = wiki[currentItem].GetCategory();
            HighlightRadioButton(currentItem);
            textboxDefinition.Text = wiki[currentItem].GetDefinition();
        }
        #endregion
        // The main list of Data Structures must be a ListView which
        // displays the Name and Category (You are not permitted to use a ListBox).
        #region Display Data
        private void Display()
        {
            listViewItems.Items.Clear();
            listViewItems.Sort();
            foreach (var information in wiki)
            {
                listViewItems.Items.Add(information.DisplayDataStructures());
            }
            toolStripStatusLabel.Text = "Data items displayed.";
        }
        #endregion
        // 6.12 Create a custom method that will clear and reset the Textboxes, ComboBox and Radio button.
        #region ClearTextboxes Method
        // Maybe method name can be resetTextboxes
        private void ClearAllTextBoxes()
        {
            textboxName.Clear();
            textboxName.Focus();
            comboBoxCategory.SelectedIndex = -1;
            radioBtnLinear.Checked = false;
            radioBtnNonLinear.Checked = false;
            textboxDefinition.Clear();
        }
        #endregion
        // The input for Category must be a ComboBox with six choices, (refer Data Structure Matrix at end of document).
        #region Populate Combobox Method
        private void FillCategoryComboBox()
        {
            comboBoxCategory.Items.AddRange(categoryArray);
        }
        #endregion
        // 6.13 Create a double click event on the Name TextBox to clear the Textboxes, ComboBox and Radio button.
        #region Double-Click Delete Method
        private void TextboxName_DoubleClick(object sender, EventArgs e)
        {
            ClearStatusMessage();
            if (!string.IsNullOrWhiteSpace(textboxName.Text))
            {
                ClearAllTextBoxes();
            }
            else
            {
                toolStripStatusLabel.Text = "Search box is empty!";
            }
        }
        #endregion

        #region Form Load
        private void WikiApplication_Load(object sender, EventArgs e)
        {
            FillCategoryComboBox();
        }
        #endregion
        // 6.15 The Wiki application will save data when the form closes. 
        #region Form Closing
        private void WikiApplication_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult saveRecord = MessageBox.Show("Do you wish to save this file?",
                "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (saveRecord == DialogResult.Yes)
            {
                Save();
            }
            else
            {
                MessageBox.Show("File NOT saved", "Save File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        // 6.5 Create a custom ValidName method which will take a parameter string value from the Textbox Name and returns
        // a Boolean after checking for duplicates. Use the built in List<T> method “Exists” to answer this requirement.
        #region Check Duplicates
        private bool ValidName(string checkThisName)
        {
            // Trace.Listeners.Add(myTraceListener);
            if (wiki.Exists(dup => dup.GetName() == checkThisName))
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
        private void ClearStatusMessage()
        {
            toolStripStatusLabel.Text = "";
        }

        private void WikiApplication_Click(object sender, EventArgs e)
        {
            ClearStatusMessage();
            textboxName.Focus();
        }

      // Needs input handling. 
      
    }
}

