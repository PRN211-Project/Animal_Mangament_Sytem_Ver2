
namespace Animal_Management_System_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.pannelMenu = new System.Windows.Forms.Panel();
            this.icArea = new FontAwesome.Sharp.IconButton();
            this.icfood = new FontAwesome.Sharp.IconButton();
            this.icAnimal = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.icHome = new FontAwesome.Sharp.IconButton();
            this.iconProfile = new FontAwesome.Sharp.IconButton();
            this.pannelLogo = new System.Windows.Forms.Panel();
            this.pannelTop = new System.Windows.Forms.Panel();
            this.lbchildForm = new System.Windows.Forms.Label();
            this.iconChild = new FontAwesome.Sharp.IconPictureBox();
            this.pannelshadow = new System.Windows.Forms.Panel();
            this.pannelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pannelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconChild)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(220, 106);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1098, 582);
            this.panel.TabIndex = 0;
            // 
            // pannelMenu
            // 
            this.pannelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pannelMenu.Controls.Add(this.icArea);
            this.pannelMenu.Controls.Add(this.icfood);
            this.pannelMenu.Controls.Add(this.icAnimal);
            this.pannelMenu.Controls.Add(this.panel2);
            this.pannelMenu.Controls.Add(this.iconProfile);
            this.pannelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pannelMenu.Location = new System.Drawing.Point(0, 0);
            this.pannelMenu.Name = "pannelMenu";
            this.pannelMenu.Size = new System.Drawing.Size(220, 688);
            this.pannelMenu.TabIndex = 3;
            // 
            // icArea
            // 
            this.icArea.FlatAppearance.BorderSize = 0;
            this.icArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icArea.ForeColor = System.Drawing.Color.Gainsboro;
            this.icArea.IconChar = FontAwesome.Sharp.IconChar.Pagelines;
            this.icArea.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.icArea.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icArea.IconSize = 32;
            this.icArea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icArea.Location = new System.Drawing.Point(3, 329);
            this.icArea.Name = "icArea";
            this.icArea.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.icArea.Size = new System.Drawing.Size(214, 60);
            this.icArea.TabIndex = 9;
            this.icArea.Text = "Area Management";
            this.icArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icArea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icArea.UseVisualStyleBackColor = true;
            this.icArea.Click += new System.EventHandler(this.icArea_Click);
            // 
            // icfood
            // 
            this.icfood.FlatAppearance.BorderSize = 0;
            this.icfood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icfood.ForeColor = System.Drawing.Color.Gainsboro;
            this.icfood.IconChar = FontAwesome.Sharp.IconChar.Bone;
            this.icfood.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.icfood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icfood.IconSize = 32;
            this.icfood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icfood.Location = new System.Drawing.Point(3, 247);
            this.icfood.Name = "icfood";
            this.icfood.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.icfood.Size = new System.Drawing.Size(217, 60);
            this.icfood.TabIndex = 8;
            this.icfood.Text = "Food Management";
            this.icfood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icfood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icfood.UseVisualStyleBackColor = true;
            this.icfood.Click += new System.EventHandler(this.icfood_Click);
            // 
            // icAnimal
            // 
            this.icAnimal.FlatAppearance.BorderSize = 0;
            this.icAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icAnimal.ForeColor = System.Drawing.Color.Gainsboro;
            this.icAnimal.IconChar = FontAwesome.Sharp.IconChar.Dog;
            this.icAnimal.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.icAnimal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icAnimal.IconSize = 32;
            this.icAnimal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icAnimal.Location = new System.Drawing.Point(3, 176);
            this.icAnimal.Name = "icAnimal";
            this.icAnimal.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.icAnimal.Size = new System.Drawing.Size(217, 60);
            this.icAnimal.TabIndex = 7;
            this.icAnimal.Text = "Animal Management";
            this.icAnimal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icAnimal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icAnimal.UseVisualStyleBackColor = true;
            this.icAnimal.Click += new System.EventHandler(this.icAnimal_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.icHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 96);
            this.panel2.TabIndex = 6;
            // 
            // icHome
            // 
            this.icHome.FlatAppearance.BorderSize = 0;
            this.icHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.icHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.icHome.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.icHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icHome.IconSize = 32;
            this.icHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icHome.Location = new System.Drawing.Point(3, 14);
            this.icHome.Name = "icHome";
            this.icHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.icHome.Size = new System.Drawing.Size(214, 79);
            this.icHome.TabIndex = 10;
            this.icHome.Text = "Home";
            this.icHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icHome.UseVisualStyleBackColor = true;
            this.icHome.Click += new System.EventHandler(this.icHome_Click);
            // 
            // iconProfile
            // 
            this.iconProfile.FlatAppearance.BorderSize = 0;
            this.iconProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconProfile.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconProfile.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconProfile.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconProfile.IconSize = 32;
            this.iconProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconProfile.Location = new System.Drawing.Point(3, 102);
            this.iconProfile.Name = "iconProfile";
            this.iconProfile.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconProfile.Size = new System.Drawing.Size(220, 60);
            this.iconProfile.TabIndex = 5;
            this.iconProfile.Text = "Profile";
            this.iconProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconProfile.UseVisualStyleBackColor = true;
            this.iconProfile.Click += new System.EventHandler(this.iconProfile_Click);
            // 
            // pannelLogo
            // 
            this.pannelLogo.Location = new System.Drawing.Point(0, 30);
            this.pannelLogo.Name = "pannelLogo";
            this.pannelLogo.Size = new System.Drawing.Size(220, 157);
            this.pannelLogo.TabIndex = 0;
            // 
            // pannelTop
            // 
            this.pannelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pannelTop.Controls.Add(this.lbchildForm);
            this.pannelTop.Controls.Add(this.iconChild);
            this.pannelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pannelTop.Location = new System.Drawing.Point(220, 0);
            this.pannelTop.Name = "pannelTop";
            this.pannelTop.Size = new System.Drawing.Size(1098, 96);
            this.pannelTop.TabIndex = 4;
            this.pannelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pannelTop_MouseDown);
            // 
            // lbchildForm
            // 
            this.lbchildForm.AutoSize = true;
            this.lbchildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbchildForm.Location = new System.Drawing.Point(64, 43);
            this.lbchildForm.Name = "lbchildForm";
            this.lbchildForm.Size = new System.Drawing.Size(50, 20);
            this.lbchildForm.TabIndex = 6;
            this.lbchildForm.Text = "Home";
            // 
            // iconChild
            // 
            this.iconChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconChild.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconChild.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconChild.IconColor = System.Drawing.Color.MediumPurple;
            this.iconChild.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconChild.IconSize = 40;
            this.iconChild.Location = new System.Drawing.Point(18, 30);
            this.iconChild.Name = "iconChild";
            this.iconChild.Size = new System.Drawing.Size(40, 40);
            this.iconChild.TabIndex = 5;
            this.iconChild.TabStop = false;
            // 
            // pannelshadow
            // 
            this.pannelshadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pannelshadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pannelshadow.Location = new System.Drawing.Point(220, 96);
            this.pannelshadow.Name = "pannelshadow";
            this.pannelshadow.Size = new System.Drawing.Size(1098, 10);
            this.pannelshadow.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 688);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pannelshadow);
            this.Controls.Add(this.pannelTop);
            this.Controls.Add(this.pannelMenu);
            this.Controls.Add(this.pannelLogo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pannelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pannelTop.ResumeLayout(false);
            this.pannelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconChild)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel pannelMenu;
        private System.Windows.Forms.Panel pannelLogo;
        private FontAwesome.Sharp.IconButton icArea;
        private FontAwesome.Sharp.IconButton icfood;
        private FontAwesome.Sharp.IconButton icAnimal;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconProfile;
        private FontAwesome.Sharp.IconButton icHome;
        private System.Windows.Forms.Panel pannelTop;
        private System.Windows.Forms.Label lbchildForm;
        private FontAwesome.Sharp.IconPictureBox iconChild;
        private System.Windows.Forms.Panel pannelshadow;
    }
}

