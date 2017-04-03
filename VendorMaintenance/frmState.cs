using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VendorMaintenance
{
    public partial class frmState : Form
    {
        public frmState()
        {
            InitializeComponent();
        }

        State selectedState;

        private void btnGetState_Click(object sender, EventArgs e)
        {
            try
            {
                selectedState = (from state in DataContext.payables.States where state.StateCode == txtStateCode.Text select state).Single();
                this.DisplayStateCode();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No State found with this Code " +
                    "Please try again.", "this state Not Found");
                this.ClearControls();
                txtStateCode.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void DisplayStateCode()
        {
            txtStateCode.Text = selectedState.StateCode;
            txtStateName.Text = selectedState.StateName;
            txtFirstZip.Text = selectedState.FirstZipCode.ToString();
            txtLastZip.Text = selectedState.LastZipCode.ToString();
            btnModifyState.Enabled = true;
            btnDeleteState.Enabled = true;          
        }

        private void ClearControls()
        {
            txtStateCode.Text = "";
            txtStateName.Text = "";
            txtFirstZip.Text = "";
            txtLastZip.Text = "";
            btnModifyState.Enabled = false;
            btnDeleteState.Enabled = false;
        }

        private void btnAddState_Click(object sender, EventArgs e)
        {
            frmAddModifyState addModifyStateForm = new frmAddModifyState();
            addModifyStateForm.addState = true;
            DialogResult result = addModifyStateForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedState = addModifyStateForm.state;
                txtStateCode.Text = selectedState.StateCode.ToString();
                this.DisplayState();
            }
        }

        private void btnModifyState_Click(object sender, EventArgs e)
        {
            frmAddModifyState addModifyStateForm = new frmAddModifyState();
            addModifyStateForm.addState = false;
            addModifyStateForm.state = selectedState;
            DialogResult result = addModifyStateForm.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Retry)
            {
                selectedState = addModifyStateForm.state;
                this.DisplayState();
            }
            else if (result == DialogResult.Abort)
            {
                txtStateCode.Text = "";
                this.ClearControls();
            }
        }

        private void DisplayState()
        {
            txtStateCode.Text = selectedState.StateCode;
            txtStateName.Text = selectedState.StateName;
            txtFirstZip.Text = selectedState.FirstZipCode.ToString();
            txtLastZip.Text = selectedState.LastZipCode.ToString();           
            btnModifyState.Enabled = true;
            btnDeleteState.Enabled = true;
        }

        private void btnDeleteState_Click(object sender, EventArgs e)
        {
            {
                DialogResult result =
                    MessageBox.Show("Delete " + selectedState.StateName + "?",
                    "Confirm Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DataContext.payables.States.DeleteOnSubmit(selectedState);
                        DataContext.payables.SubmitChanges();
                        txtStateCode.Text = "";
                        this.ClearControls();
                    }
                    catch (ChangeConflictException)
                    {
                        DataContext.GetCurrentValues();
                        MessageBox.Show("Another user has updated that state.",
                            "Database Error");
                        this.DisplayState();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
