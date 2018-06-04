namespace CSharpSecurityInformationSystem
{
    partial class UserControlEmp
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
            this.dgvaccnts = new System.Windows.Forms.DataGridView();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvaccnts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee";
            // 
            // dgvaccnts
            // 
            this.dgvaccnts.AllowUserToAddRows = false;
            this.dgvaccnts.AllowUserToDeleteRows = false;
            this.dgvaccnts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvaccnts.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvaccnts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvaccnts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvaccnts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_id,
            this.user_name,
            this.user_pass,
            this.user_type,
            this.user_fname,
            this.user_lname,
            this.user_gender});
            this.dgvaccnts.Location = new System.Drawing.Point(23, 45);
            this.dgvaccnts.Name = "dgvaccnts";
            this.dgvaccnts.ReadOnly = true;
            this.dgvaccnts.Size = new System.Drawing.Size(817, 529);
            this.dgvaccnts.TabIndex = 2;
            // 
            // user_id
            // 
            this.user_id.HeaderText = "user_id";
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            this.user_id.Visible = false;
            // 
            // user_name
            // 
            this.user_name.HeaderText = "Username";
            this.user_name.Name = "user_name";
            this.user_name.ReadOnly = true;
            // 
            // user_pass
            // 
            this.user_pass.HeaderText = "Password";
            this.user_pass.Name = "user_pass";
            this.user_pass.ReadOnly = true;
            // 
            // user_type
            // 
            this.user_type.HeaderText = "Type";
            this.user_type.Name = "user_type";
            this.user_type.ReadOnly = true;
            // 
            // user_fname
            // 
            this.user_fname.HeaderText = "First Name";
            this.user_fname.Name = "user_fname";
            this.user_fname.ReadOnly = true;
            // 
            // user_lname
            // 
            this.user_lname.HeaderText = "Last Name";
            this.user_lname.Name = "user_lname";
            this.user_lname.ReadOnly = true;
            // 
            // user_gender
            // 
            this.user_gender.HeaderText = "Gender";
            this.user_gender.Name = "user_gender";
            this.user_gender.ReadOnly = true;
            // 
            // UserControlEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvaccnts);
            this.Controls.Add(this.label1);
            this.Name = "UserControlEmp";
            this.Size = new System.Drawing.Size(1129, 630);
            ((System.ComponentModel.ISupportInitialize)(this.dgvaccnts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvaccnts;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_gender;

    }
}
