using CustomCollections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomCollectionsTestApp
{
    /// <summary>
    /// Test application for ObservableList.
    /// </summary>
    public partial class TestApp : Form
    {
        ObservableList<string> list = new ObservableList<string>();

        public TestApp()
        {
            InitializeComponent();
            list.BeforeChange += List_BeforeChange;
            list.Changed += List_Changed;
        }

        private void List_BeforeChange(object sender, CustomDatastructures.Core.RejectableEventArgs<string> e)
        {
            if (changeCheck.Checked)
            {
                if (invalidateAction())
                {
                    e.RejectOperation();
                }
            }
        }

        private bool invalidateAction()
        {
            string[] rejectString = rejectionFilterBox.Text.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            bool rejected = false;
            foreach (string rs in rejectString)
            {
                if (textBox1.Text.Contains(rs))
                {
                    rejected = true;
                }
            }
            return rejected;
        }

        private void List_Changed(object sender, CustomDatastructures.Core.ListChangedEventArgs<string> e)
        {
            PopulateList(list);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                list.Add(textBox1.Text);
            }
            catch (InvalidOperationException ex){ displayException(ex); }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                list.Remove(textBox1.Text);
            }
            catch (InvalidOperationException ex){ displayException(ex); }
        }

        private void containsBtn_Click(object sender, EventArgs e)
        {
            var c = list.Contains(textBox1.Text);
            string text;
            if (c)
            {
                text = "\nExists in the list.";
            }
            else
            {
                text = "\nDoes not exist in the list.";
            }
            label1.Text = textBox1.Text + text;
        }

        private void PopulateList(ObservableList<string> elements)
        {
            listBox1.Items.Clear();
            foreach (string element in elements)
            {
                listBox1.Items.Add(element);
            }
        }

        private void displayException(InvalidOperationException ex)
        {
            exceptionLabel.Text = ex.ToString().Split('\n')[0];
        }
    }
}
