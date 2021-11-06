namespace Animal_Management_System_Form.AreaForm
{
    partial class AreaForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAreaList = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAreaSquare = new System.Windows.Forms.TextBox();
            this.txtAreaName = new System.Windows.Forms.TextBox();
            this.txtAreaId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnimal = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreaList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(343, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Area Form";
            // 
            // dgvAreaList
            // 
            this.dgvAreaList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAreaList.Location = new System.Drawing.Point(29, 231);
            this.dgvAreaList.Name = "dgvAreaList";
            this.dgvAreaList.RowTemplate.Height = 25;
            this.dgvAreaList.Size = new System.Drawing.Size(757, 255);
            this.dgvAreaList.TabIndex = 2;
            this.dgvAreaList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAreaList_CellDoubleClick);
            this.dgvAreaList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAreaList_CellFormatting);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoad.Location = new System.Drawing.Point(38, 57);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(80, 30);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(200, 57);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(355, 57);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 30);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(514, 57);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOrder.Location = new System.Drawing.Point(674, 57);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(80, 30);
            this.btnOrder.TabIndex = 7;
            this.btnOrder.Text = "Order By Square";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAreaSquare);
            this.groupBox1.Controls.Add(this.txtAreaName);
            this.groupBox1.Controls.Add(this.txtAreaId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(29, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 84);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Infor";
            // 
            // txtAreaSquare
            // 
            this.txtAreaSquare.Enabled = false;
            this.txtAreaSquare.Location = new System.Drawing.Point(585, 50);
            this.txtAreaSquare.Name = "txtAreaSquare";
            this.txtAreaSquare.ReadOnly = true;
            this.txtAreaSquare.Size = new System.Drawing.Size(130, 23);
            this.txtAreaSquare.TabIndex = 5;
            // 
            // txtAreaName
            // 
            this.txtAreaName.Enabled = false;
            this.txtAreaName.Location = new System.Drawing.Point(290, 50);
            this.txtAreaName.Name = "txtAreaName";
            this.txtAreaName.ReadOnly = true;
            this.txtAreaName.Size = new System.Drawing.Size(133, 23);
            this.txtAreaName.TabIndex = 4;
            // 
            // txtAreaId
            // 
            this.txtAreaId.Enabled = false;
            this.txtAreaId.Location = new System.Drawing.Point(37, 50);
            this.txtAreaId.Name = "txtAreaId";
            this.txtAreaId.ReadOnly = true;
            this.txtAreaId.Size = new System.Drawing.Size(100, 23);
            this.txtAreaId.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(615, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Area Square";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Area Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Area ID";
            // 
            // btnAnimal
            // 
            this.btnAnimal.Location = new System.Drawing.Point(200, 93);
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Size = new System.Drawing.Size(89, 48);
            this.btnAnimal.TabIndex = 10;
            this.btnAnimal.Text = "View Animals In Area";
            this.btnAnimal.UseVisualStyleBackColor = true;
            this.btnAnimal.Click += new System.EventHandler(this.btnAnimal_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(351, 99);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(95, 42);
            this.btnEmployee.TabIndex = 11;
            this.btnEmployee.Text = "View Employee In Area";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // AreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnAnimal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvAreaList);
            this.Controls.Add(this.label1);
            this.Name = "AreaForm";
            this.Size = new System.Drawing.Size(800, 499);
            this.Load += new System.EventHandler(this.AreaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreaList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAreaList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAreaSquare;
        private System.Windows.Forms.TextBox txtAreaName;
        private System.Windows.Forms.TextBox txtAreaId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnimal;
        private System.Windows.Forms.Button btnEmployee;
    }
}