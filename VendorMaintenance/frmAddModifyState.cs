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
    public partial class frmAddModifyState : Form
    {
        public frmAddModifyState()
        {
            InitializeComponent();
        }
        
        public bool addState;
        public State state;

        private void frmAddModifyState_Load(object sender, EventArgs e)
        {
            if (addState)
            {
                this.Text = "Add State";
            }
            else
            {
                this.Text = "Modify State";
                this.DisplayStateData();
            }
        }

        private void DisplayStateData()
        {
            txtStateCode.Text = state.StateCode;
            txtStateName.Text = state.StateName;
            txtFirstZip.Text = state.FirstZipCode.ToString();
            txtLastZip.Text = state.LastZipCode.ToString();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (addState)
                {
                    state = new State();
                    this.PutStateData(state);
                    DataContext.payables.States.InsertOnSubmit(state);
                    try
                    {
                        DataContext.payables.SubmitChanges();
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("State code " + Convert.ToString(state.StateCode) + " has been added to the States table");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else
                {
                    this.PutStateData(state);
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
        }

        private bool IsValidData()
        {
            if (Validator.IsPresent(txtStateCode) && Validator.IsPresent(txtStateName) && Validator.IsPresent(txtFirstZip) && Validator.IsPresent(txtLastZip))
                return true;
            else
                return false;
        
        }
        private void PutStateData(State state)
        {
            state.StateCode = txtStateCode.Text;
            state.StateName = txtStateName.Text;
            state.FirstZipCode = Int32.Parse(txtFirstZip.Text);
            state.LastZipCode = Int32.Parse(txtLastZip.Text);
        }
           
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
