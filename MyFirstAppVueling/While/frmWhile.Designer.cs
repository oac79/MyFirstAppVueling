
namespace MyFirstAppVueling.While
{
    partial class frmWhile
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
            this.textAge = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textStudentId = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(316, 276);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(169, 20);
            this.textAge.TabIndex = 14;
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(316, 214);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(169, 20);
            this.textSurname.TabIndex = 13;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(316, 153);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(169, 20);
            this.textName.TabIndex = 12;
            // 
            // textStudentId
            // 
            this.textStudentId.Location = new System.Drawing.Point(316, 97);
            this.textStudentId.Name = "textStudentId";
            this.textStudentId.Size = new System.Drawing.Size(169, 20);
            this.textStudentId.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(316, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textStudentId);
            this.Controls.Add(this.btnSave);
            this.Name = "frmWhile";
            this.Text = "frmWhile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textStudentId;
        private System.Windows.Forms.Button btnSave;
    }
}