
namespace Animal_Management_System_Form
{
    partial class FoodForm
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.lbFoodName = new System.Windows.Forms.Label();
            this.txtFoodID = new System.Windows.Forms.TextBox();
            this.lbFoodID = new System.Windows.Forms.Label();
            this.txtExpiredDate = new System.Windows.Forms.TextBox();
            this.lbExpiredDate = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(538, 162);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(423, 162);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(109, 23);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(308, 162);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(109, 23);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "&Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtFoodName
            // 
            this.txtFoodName.Enabled = false;
            this.txtFoodName.Location = new System.Drawing.Point(122, 80);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(525, 23);
            this.txtFoodName.TabIndex = 4;
            // 
            // lbFoodName
            // 
            this.lbFoodName.AutoSize = true;
            this.lbFoodName.Location = new System.Drawing.Point(18, 83);
            this.lbFoodName.Name = "lbFoodName";
            this.lbFoodName.Size = new System.Drawing.Size(69, 15);
            this.lbFoodName.TabIndex = 32;
            this.lbFoodName.Text = "Food Name";
            // 
            // txtFoodID
            // 
            this.txtFoodID.Enabled = false;
            this.txtFoodID.Location = new System.Drawing.Point(124, 120);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.Size = new System.Drawing.Size(525, 23);
            this.txtFoodID.TabIndex = 2;
            // 
            // lbFoodID
            // 
            this.lbFoodID.AutoSize = true;
            this.lbFoodID.Location = new System.Drawing.Point(18, 43);
            this.lbFoodID.Name = "lbFoodID";
            this.lbFoodID.Size = new System.Drawing.Size(48, 15);
            this.lbFoodID.TabIndex = 25;
            this.lbFoodID.Text = "Food ID";
            // 
            // txtExpiredDate
            // 
            this.txtExpiredDate.Enabled = false;
            this.txtExpiredDate.Location = new System.Drawing.Point(122, 40);
            this.txtExpiredDate.Name = "txtExpiredDate";
            this.txtExpiredDate.Size = new System.Drawing.Size(525, 23);
            this.txtExpiredDate.TabIndex = 1;
            // 
            // lbExpiredDate
            // 
            this.lbExpiredDate.AutoSize = true;
            this.lbExpiredDate.Location = new System.Drawing.Point(18, 123);
            this.lbExpiredDate.Name = "lbExpiredDate";
            this.lbExpiredDate.Size = new System.Drawing.Size(73, 15);
            this.lbExpiredDate.TabIndex = 29;
            this.lbExpiredDate.Text = "Expired Date";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(18, 191);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(631, 265);
            this.dataGridView2.TabIndex = 0;
            // 
            // FoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lbFoodName);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.lbExpiredDate);
            this.Controls.Add(this.txtFoodID);
            this.Controls.Add(this.txtExpiredDate);
            this.Controls.Add(this.lbFoodID);
            this.Controls.Add(this.dataGridView2);
            this.Name = "FoodForm";
            this.Size = new System.Drawing.Size(667, 463);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvFoodList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lbFoodName;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label lbExpiredDate;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.TextBox txtExpiredDate;
        private System.Windows.Forms.Label lbFoodID;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
