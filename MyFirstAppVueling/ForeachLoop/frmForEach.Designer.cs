
namespace MyFirstAppVueling.EntityStudent
{
    partial class frmForEach
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
            this.btnSave = new System.Windows.Forms.Button();
            this.textStudentId = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(314, 301);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textStudentId
            // 
            this.textStudentId.Location = new System.Drawing.Point(314, 64);
            this.textStudentId.Name = "textStudentId";
            this.textStudentId.Size = new System.Drawing.Size(169, 20);
            this.textStudentId.TabIndex = 1;
            this.textStudentId.TextChanged += new System.EventHandler(this.textStudentId_TextChanged);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(314, 124);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(169, 20);
            this.textName.TabIndex = 2;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(314, 185);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(169, 20);
            this.textSurname.TabIndex = 3;
            this.textSurname.TextChanged += new System.EventHandler(this.textSurname_TextChanged);
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(314, 247);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(169, 20);
            this.textAge.TabIndex = 4;
            this.textAge.TextChanged += new System.EventHandler(this.textAge_TextChanged);
            // 
            // frmForEach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textStudentId);
            this.Controls.Add(this.btnSave);
            this.Name = "frmForEach";
            this.RightToLeftLayout = true;
            this.Text = "frmForEach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textStudentId;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textAge;
    }
}