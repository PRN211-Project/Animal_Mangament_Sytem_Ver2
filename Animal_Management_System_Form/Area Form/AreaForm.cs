using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animal_Management_System.Models;
using Animal_Management_System.Repository;
using Animal_Management_System.Repository.Implementation;

namespace Animal_Management_System_Form.AreaForm
{
    public partial class AreaForm : UserControl
    {
        public IAreaRepository implAreaRepository { get; set; }
        BindingSource source;

        private IAreaRepository areaRepository;

        //Singleton
        private static AreaForm _instance;

        public static AreaForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AreaForm();
                }

                return _instance;
            }
        }

        private AreaForm()
        {
            InitializeComponent();
            implAreaRepository = new ImplAreaRepository();
        }


        /*private void AreaForm_Leave(object sender, EventArgs e)
        {
            DialogResult confirmExit = MessageBox.Show("Are You Sure to Exit???", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirmExit == DialogResult.OK)
            {
                this.Close();
            }
        }*/

        private void AreaForm_Load(object sender, EventArgs e)
        {
            LoadAreaList(implAreaRepository.GetAllAreas());
        }

        private void LoadAreaList(IEnumerable<Area> areas)
        {
            //var areas = implAreaRepository.GetAllAreas();
            try
            {
                source = new BindingSource();
                source.DataSource = areas;

                txtAreaId.DataBindings.Clear();
                txtAreaName.DataBindings.Clear();
                txtAreaSquare.DataBindings.Clear();


                txtAreaId.DataBindings.Add("Text", source, "AreaId");
                txtAreaName.DataBindings.Add("Text", source, "Name");
                txtAreaSquare.DataBindings.Add("Text", source, "Square");


                dgvAreaList.DataSource = null;
                dgvAreaList.DataSource = source;
                if (areas.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }

                this.dgvAreaList.Columns[1].Width = 147;
                this.dgvAreaList.Columns[2].Width = 147;
                this.dgvAreaList.Columns[0].Width = 65;
                this.dgvAreaList.Columns[3].Visible = false;
                this.dgvAreaList.Columns[4].Visible = false;
                foreach (DataGridViewColumn col in this.dgvAreaList.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                dgvAreaList.AllowUserToAddRows = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Error", MessageBoxButtons.OK);
            }
        }
        private void ClearText()
        {
            txtAreaId.Text = string.Empty;
            txtAreaName.Text = string.Empty;
            txtAreaSquare.Text = string.Empty;
        }

        private bool isEmptyInput(params string[] textbox)
        {
            foreach (string text in textbox)
            {
                if (text.Trim().Equals("")) return true;
            }
            return false;
        }

        private void dgvAreaList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AreaDetailForm frmAreaDetails = new AreaDetailForm
            {
                Text = "Update Area",
                isInsert = false,
                areaInfo = GetAreaObject(),
                areaRepository = this.implAreaRepository
            };
            if (frmAreaDetails.ShowDialog() == DialogResult.OK)
            {
                LoadAreaList(implAreaRepository.GetAllAreas());
                source.Position = source.Count - 1;
            }
        }
        private Area GetAreaObject()
        {
            Area area = null;
            try
            {
                area = new Area
                {
                    AreaId = Convert.ToInt32(txtAreaId.Text.Trim()),
                    Name = txtAreaName.Text.Trim(),
                    Square = Convert.ToDouble(txtAreaSquare.Text.Trim())
                };

                return area;
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong Data Type of Square", "Date Input error", MessageBoxButtons.OK);
            }

            return null;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult confirmExit = MessageBox.Show("Are You Sure to Exit???", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirmExit == DialogResult.OK)
            {
                // another form show up
                /*this.Close();*/
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AreaDetailForm frmAreaDetails = new AreaDetailForm
            {
                Text = "Add New Area",
                isInsert = true,
                areaRepository = this.implAreaRepository
            };
            if (frmAreaDetails.ShowDialog() == DialogResult.OK)
            {
                LoadAreaList(implAreaRepository.GetAllAreas());
                source.Position = source.Count - 1;
                MessageBox.Show("List is Load", "Notification", MessageBoxButtons.OK);
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var area = GetAreaObject();
                DialogResult deleteConfirm = MessageBox.Show("Are you sure to delete", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (deleteConfirm == DialogResult.OK)
                {
                    implAreaRepository.DeleteArea(area);
                }
                LoadAreaList(implAreaRepository.GetAllAreas());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Area", MessageBoxButtons.OK);
            }
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            LoadAreaList(implAreaRepository.GetAllAreas().OrderByDescending(area => area.Square));
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadAreaList(implAreaRepository.GetAllAreas());
        }

        /*private void btnSearch_Click(object sender, EventArgs e)
        {
            if (isEmptyInput(txtSearchID.Text, txtSearchName.Text))
            {
                MessageBox.Show("Empty Input", "Search By ID and Name", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    IEnumerable<Area> listResSearch = implAreaRepository.SearchByIDAndName(txtSearchName.Text, int.Parse(txtSearchID.Text));
                    LoadAreaList(listResSearch);
                    if (listResSearch.Count() == 0) MessageBox.Show("Empty Result", "Search By ID and Name", MessageBoxButtons.OK);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error for data type of ID", "Search By ID and Name", MessageBoxButtons.OK);
                }
            }
        }*/

        /*private void btnFilter_Click(object sender, EventArgs e)
        {
            if (isEmptyInput(txtFilterCity.Text, txtFilterCountry.Text) == false)
            {
                IEnumerable<Area> list = implAreaRepository.SearchByCityAndCountry(txtFilterCity.Text, txtFilterCountry.Text);
                LoadAreaList(list);
                //if (list.Count() == 0) MessageBox.Show("Empty Result", "Filter By City And Country", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Empty Input", "Filter By City And Country", MessageBoxButtons.OK);
            }
        }*/

        private void dgvAreaList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvAreaList.Columns[e.ColumnIndex].Index == 3)
            {
                if (e.Value != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                    e.FormattingApplied = true;
                }
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AreaDetailForm frmAreaDetails = new AreaDetailForm
            {
                Text = "Update Area",
                isInsert = false,
                areaInfo = GetAreaObject(),
                areaRepository = this.implAreaRepository
            };
            if (frmAreaDetails.ShowDialog() == DialogResult.OK)
            {
                LoadAreaList(implAreaRepository.GetAllAreas());
                source.Position = source.Count - 1;
            }
        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            var index = dgvAreaList.CurrentCell.RowIndex;
            int areaId = Convert.ToInt32(dgvAreaList.Rows[index].Cells[0].Value.ToString());
            ViewList viewList = new ViewList();
            viewList.isViewAnimal = true;
            viewList.areaID = areaId;
            viewList.ShowDialog();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            var index = dgvAreaList.CurrentCell.RowIndex;
            int areaId = Convert.ToInt32(dgvAreaList.Rows[index].Cells[0].Value.ToString());
            ViewList viewList = new ViewList();
            viewList.isViewAnimal = false;
            viewList.areaID = areaId;
            viewList.ShowDialog();
        }
    }
}