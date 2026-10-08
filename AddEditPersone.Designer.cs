namespace DVLD
{
    partial class AddEditPersone
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
            this.ctrlPersoneAdd1 = new DVLD.CtrlPersoneAdd();
            this.SuspendLayout();
            // 
            // ctrlPersoneAdd1
            // 
            this.ctrlPersoneAdd1.BackColor = System.Drawing.Color.White;
            this.ctrlPersoneAdd1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlPersoneAdd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPersoneAdd1.Location = new System.Drawing.Point(0, 0);
            this.ctrlPersoneAdd1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlPersoneAdd1.Name = "ctrlPersoneAdd1";
            this.ctrlPersoneAdd1.Size = new System.Drawing.Size(960, 531);
            this.ctrlPersoneAdd1.TabIndex = 0;
            this.ctrlPersoneAdd1.Load += new System.EventHandler(this.ctrlPersoneAdd1_Load);
            // 
            // AddEditPersone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 531);
            this.Controls.Add(this.ctrlPersoneAdd1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEditPersone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add / Edit Person Info";
            this.ResumeLayout(false);

        }

        #endregion

        private CtrlPersoneAdd ctrlPersoneAdd1;
    }
}