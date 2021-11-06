using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animal_Management_System.Models;
using FontAwesome.Sharp;

namespace Animal_Management_System_Form
{
    public partial class Home : Form
    {
        public Employee CurrentEmployee;
        private IconButton currBtn;
        private Panel LeftBorderBtn;
        public Home()
        {
            InitializeComponent();
            LeftBorderBtn = new Panel();
            LeftBorderBtn.Size = new Size(10,60);
            pannelMenu.Controls.Add(LeftBorderBtn);

        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);

        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                currBtn = (IconButton)senderBtn;
                currBtn.BackColor = Color.FromArgb(37, 36, 81);
                currBtn.ForeColor = color;
                currBtn.TextAlign = ContentAlignment.MiddleCenter;
                currBtn.IconColor = color;
                currBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currBtn.ImageAlign = ContentAlignment.MiddleRight;
                //
                LeftBorderBtn.BackColor = color;
                LeftBorderBtn.Location = new Point(0, currBtn.Location.Y);
                LeftBorderBtn.Visible = true;
                LeftBorderBtn.BringToFront();
                //icon child
                iconChild.IconChar = currBtn.IconChar;
                iconChild.IconColor = color;

            }
        }

        private void DisableButton()
        {
            if(currBtn != null)
            {
            
                currBtn.BackColor = Color.FromArgb(31, 30,68);
                currBtn.ForeColor = Color.Gainsboro;
                currBtn.TextAlign = ContentAlignment.MiddleLeft;
                currBtn.IconColor = Color.Gainsboro;
                currBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            if (CurrentEmployee != null)
            {
                icfood.Visible = false;
                icArea.Visible = false;
            }
        }

  
        private void iconProfile_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            if (CurrentEmployee == null)
            {
                if (!panel.Controls.Contains(ProfileForm.Instance))
                {
                    panel.Controls.Add(ProfileForm.Instance);
                    ProfileForm.Instance.Dock = DockStyle.Fill;
                    ProfileForm.Instance.BringToFront();
                    lbchildForm.Text = "Profile";
                }
                else
                {
                    ProfileForm.Instance.BringToFront();
                }
            }
            else
            {
                EmployeeForm.Instance.CurrentEmployee = CurrentEmployee;
                if (!panel.Controls.Contains(EmployeeForm.Instance))
                {
                    panel.Controls.Add(EmployeeForm.Instance);
                    EmployeeForm.Instance.Dock = DockStyle.Fill;
                    EmployeeForm.Instance.BringToFront();
                    lbchildForm.Text = "Profile";
                }
                else
                {
                    EmployeeForm.Instance.BringToFront();
                }
            }
        }

        private void icAnimal_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            if (CurrentEmployee == null)
            {
                if (!panel.Controls.Contains(AnimalForm.Instance))
                {
                    panel.Controls.Add(AnimalForm.Instance);
                    AnimalForm.Instance.Dock = DockStyle.Fill;
                    AnimalForm.Instance.BringToFront();
                    lbchildForm.Text = "Animal Management";

                }
                else
                {
                    AnimalForm.Instance.BringToFront();
                }
            }
            else
            {
                AnimalForm.Instance.CurrentEmployee = CurrentEmployee;
                if (!panel.Controls.Contains(AnimalForm.Instance))
                {
                    panel.Controls.Add(AnimalForm.Instance);
                    AnimalForm.Instance.Dock = DockStyle.Fill;
                    AnimalForm.Instance.BringToFront();
                    lbchildForm.Text = "Animal Management";

                }
                else
                {
                    AnimalForm.Instance.BringToFront();
                }
            }
        }

        private void icfood_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);

            if (!panel.Controls.Contains(FoodForm.Instance))
            {
                panel.Controls.Add(FoodForm.Instance);
                FoodForm.Instance.Dock = DockStyle.Fill;
                FoodForm.Instance.BringToFront();
                lbchildForm.Text = "Food Management";
            }
            else
            {
                FoodForm.Instance.BringToFront();
            }
        }

        private void icArea_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            if (!panel.Controls.Contains(AreaForm.AreaForm.Instance))
            {
                panel.Controls.Add(AreaForm.AreaForm.Instance);
                AreaForm.AreaForm.Instance.Dock = DockStyle.Fill;
                AreaForm.AreaForm.Instance.BringToFront();
                lbchildForm.Text = "Area Management";

            }
            else
            {
                AreaForm.AreaForm.Instance.BringToFront();
            }
        }

        private void icHome_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            LeftBorderBtn.Visible = false;
            iconChild.IconChar = IconChar.Home; ;
            iconChild.IconColor =Color.MediumPurple ;
            lbchildForm.Text = "Home";
           
        }

        //dragform
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pannelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void icLogout_Click(object sender, EventArgs e)
        {
            //Log out
            Application.Restart();
        }
    }
}
