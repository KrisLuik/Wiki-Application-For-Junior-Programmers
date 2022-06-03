using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wiki_Application_For_Junior_Programmers
{
   // 6.1 Create a separate class file to hold the four data items of the Data Structure
    class Information
    {
        // Auto-implemented properties.
        private string name;
        private string category;
        private string structure;
        private string definition;
        public Information() { }

        public Information(string newName, string newCategory, string newStructure, string newDefinition)
        {
            name = newName;
            category = newCategory;
            structure = newStructure;
            definition = newDefinition;
        }
        public void SetName(string newName)
        {
            name = newName;
        }
        public string GetName()
        {
            return name;
        }
        public void SetCategory(string newCategory)
        {
            category = newCategory;
        }
        public string GetCategory()
        {
            return category;
        }
        public void SetStructure(string newStructure)
        {
            structure = newStructure;
        }
        public string GetStructure()
        {
            return structure;
        }
        public void SetDefinition(string newDefinition)
        {
            definition = newDefinition;
        }
        public string GetDefinition()
        {
            return definition;
        }
        public ListViewItem DisplayDataStructures()
        {
            ListViewItem lvi = new ListViewItem(GetName());
            lvi.SubItems.Add(GetCategory());
            return lvi;
        }
       
    }

}
