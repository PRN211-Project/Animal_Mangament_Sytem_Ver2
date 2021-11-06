using Animal_Management_System.Models;
using Animal_Management_System.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animal_Management_System_Form
{
    public partial class AreaDetailForm: Form
    {
        public bool isInsert { get; set; }
        public Area areaInfo { get; set; }
        public IAreaRepository areaRepository { get; set; }

        public AreaDetailForm()
        {
            InitializeComponent();
        }

        private void frmAreaDetail_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            txtAreaId.ReadOnly = true;
            txtAreaId.Enabled = false;
            if (isInsert == false)
            {
                txtAreaId.Text = areaInfo.AreaId.ToString();
                txtAreaSquare.Text = areaInfo.Square.ToString();
                txtAreaName.Text = areaInfo.Name;
            } else
            {
                txtAreaId.Text = "Auto-ID-Render";
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEmptyInput(txtAreaSquare.Text.Trim(), txtAreaName.Text.Trim(), txtAreaId.Text.Trim()))
                {
                    MessageBox.Show("Empty Input", "Update Area Detail", MessageBoxButtons.OK);
                }
                else
                {

                    if (isInsert == true)
                    {
                        var area = new Area
                        {
                            //AreaId = Convert.ToInt32(txtAreaId.Text.Trim()),
                            Square = Convert.ToDouble(txtAreaSquare.Text.Trim()),
                            Name = txtAreaName.Text.Trim(),
                        };
                        areaRepository.AddNewArea(area);
                        MessageBox.Show("Add New Area Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        var area = new Area
                        {
                            AreaId = Convert.ToInt32(txtAreaId.Text.Trim()),
                            Square = Convert.ToDouble(txtAreaSquare.Text.Trim()),
                            Name = txtAreaName.Text.Trim(),
                        };
                        
                        DialogResult updateConfirm = MessageBox.Show("Are you sure to Update", "Warning", MessageBoxButtons.OKCancel);
                        if (updateConfirm == DialogResult.OK)
                        {
                            areaRepository.UpdateArea(area);
                        }
                        MessageBox.Show("Update Area Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Error", MessageBoxButtons.OK);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
            => Close();

        private bool isEmptyInput(params string[] textbox)
        {
            foreach (string text in textbox)
            {
                if (text.Trim().Equals("")) return true;
            }
            return false;
        }
    }
}
