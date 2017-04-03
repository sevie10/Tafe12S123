using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VendorMaintenance
{
    public partial class frmAddModifyTerm : Form
    {
        public frmAddModifyTerm()
        {
            InitializeComponent();
        }
        public bool addTerm;
        public Term term;

        //if not adding a Term display the Term data to screen
        private void frmAddModifyTerm_Load(object sender, EventArgs e)
        {
            if (addTerm != true)
            {
                this.DisplayTermData();
            }
        }

        private void DisplayTermData()
        {
            termTextBox.Text = term.TermsID.ToString();
            descTextBox.Text = term.Description;
            dueTextBox.Text = term.DueDays.ToString();
        }
//Check whether the user want to add or modify function, the corresponding add/modify
        //action to the database is carried out
        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (addTerm)
            {
                term = new Term();
                this.PutTermData(term);
                DataContext.payables.Terms.InsertOnSubmit(term);

                try
                {
                    DataContext.payables.SubmitChanges();
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Term " + Convert.ToString(term.TermsID) +
                        " has been added to the Terms table");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            else
            {
                this.PutTermData(term);
                try
                {
                    DataContext.payables.SubmitChanges();
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }
//assign Term properties through this method
        private void PutTermData(Term term)
        {
            term.TermsID = Convert.ToInt32(termTextBox.Text);
            term.Description = descTextBox.Text;
            term.DueDays = Convert.ToInt16(dueTextBox.Text);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
