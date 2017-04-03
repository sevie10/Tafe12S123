using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Linq;

namespace VendorMaintenance
{
    public partial class frmTerm : Form
    {
        public frmTerm()
        {
            InitializeComponent();
        }

        Term selectedTerm;
        //Get Term from table
        private void getTermButton_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(termTextBox) &&
                Validator.IsInt32(termTextBox))
            {
                try
                {
                    selectedTerm =
                        (from term in DataContext.payables.Terms
                         where term.TermsID == Convert.ToInt32(termTextBox.Text)
                         select term).Single();
                    this.DisplayTerm();
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("No term found with this ID. " +
                        "Please try again.", "Terms Not Found");
                    termTextBox.Text ="";
                    termTextBox.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void DisplayTerm()
        {
            descTextBox.Text = selectedTerm.Description;
            dueDaysTextBox.Text = selectedTerm.DueDays.ToString();
            modifyButton.Enabled = true;
            deleteButton.Enabled = true;
        }

        private void ClearControls()
        {
            termTextBox.Text = "";
            descTextBox.Text = "";
            dueDaysTextBox.Text = "";
            modifyButton.Enabled = false;
            deleteButton.Enabled = false;
        }

        //Codes for the add button which is to display the frmAddModifyTerm.cs form
        private void addButton_Click(object sender, EventArgs e)
        {
            //Generate a new form instance
            frmAddModifyTerm addModifyTermForm = new frmAddModifyTerm();
           
            //assign the addTerm global boolean to be true
            addModifyTermForm.addTerm = true;

            DialogResult result = addModifyTermForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedTerm = addModifyTermForm.term;
                termTextBox.Text = selectedTerm.TermsID.ToString();
                this.DisplayTerm();
            }
        }
        //Codes for the modify button which is to display the frmAddModifyTerm.cs form
        private void modifyButton_Click(object sender, EventArgs e)
        {
            //Generate a new form instance
            frmAddModifyTerm addModifyTermForm = new frmAddModifyTerm();
            addModifyTermForm.addTerm = false;
            addModifyTermForm.term = selectedTerm;
            DialogResult result = addModifyTermForm.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Retry)
            {
                selectedTerm = addModifyTermForm.term;
                this.DisplayTerm();
            }
            else if (result == DialogResult.Abort)
            {
                termTextBox.Text = "";
                this.ClearControls();
            }
        }
        //merit component: delete data
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show("Delete " + selectedTerm.TermsID + "?",
                "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    DataContext.payables.Terms.DeleteOnSubmit(selectedTerm);
                    DataContext.payables.SubmitChanges();
                    termTextBox.Text = "";
                    this.ClearControls();
                }
                catch (ChangeConflictException)
                {
                    DataContext.GetCurrentValues();
                    MessageBox.Show("Another user has updated that term.",
                        "Database Error");
                    this.DisplayTerm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }
        //exit program
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //clear data on screen
        private void clearButton_Click(object sender, EventArgs e)
        {
            termTextBox.Text = "";
            descTextBox.Text = "";
            dueDaysTextBox.Text = "";
        }
    }
}
