
namespace Animal_Management_System_Form.Animal_Form
{
    partial class AnimalDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnimalID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DTImportedDate = new System.Windows.Forms.DateTimePicker();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorString = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelName = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.labelWeght = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorString)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(414, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(414, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Area";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(395, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Imported Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(105, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(125, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(112, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Name";
            // 
            // txtAnimalID
            // 
            this.txtAnimalID.Location = new System.Drawing.Point(195, 125);
            this.txtAnimalID.Name = "txtAnimalID";
            this.txtAnimalID.Size = new System.Drawing.Size(157, 27);
            this.txtAnimalID.TabIndex = 26;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(195, 181);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 27);
            this.txtName.TabIndex = 25;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(195, 239);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(157, 27);
            this.txtAge.TabIndex = 24;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(195, 298);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(157, 27);
            this.txtWeight.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(86, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Animal ID";
            // 
            // DTImportedDate
            // 
            this.DTImportedDate.Location = new System.Drawing.Point(520, 121);
            this.DTImportedDate.Name = "DTImportedDate";
            this.DTImportedDate.Size = new System.Drawing.Size(242, 27);
            this.DTImportedDate.TabIndex = 33;
            // 
            // cboArea
            // 
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Location = new System.Drawing.Point(520, 201);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(242, 28);
            this.cboArea.TabIndex = 34;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(520, 265);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(242, 28);
            this.cboType.TabIndex = 35;
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(370, 366);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorString
            // 
            this.errorString.ContainerControl = this;
            // 
            // errorNumber
            // 
            this.errorNumber.ContainerControl = this;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(195, 211);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 20);
            this.labelName.TabIndex = 37;
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(195, 269);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(0, 20);
            this.lbAge.TabIndex = 38;
            // 
            // labelWeght
            // 
            this.labelWeght.AutoSize = true;
            this.labelWeght.Location = new System.Drawing.Point(195, 337);
            this.labelWeght.Name = "labelWeght";
            this.labelWeght.Size = new System.Drawing.Size(0, 20);
            this.labelWeght.TabIndex = 39;
            // 
            // AnimalDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelWeght);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.cboArea);
            this.Controls.Add(this.DTImportedDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAnimalID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label1);
            this.Name = "AnimalDetails";
            this.Text = "AnimalDetails";
            this.Load += new System.EventHandler(this.AnimalDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorString)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnimalID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTImportedDate;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorString;
        private System.Windows.Forms.ErrorProvider errorNumber;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelWeght;
        private System.Windows.Forms.Label lbAge;
    }
}