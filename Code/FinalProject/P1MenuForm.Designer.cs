namespace FinalProject
{
    partial class P1MenuForm
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
            this.CustomersButton = new System.Windows.Forms.Button();
            this.ProjectRequestsButton = new System.Windows.Forms.Button();
            this.AssembleTeamsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomersButton
            // 
            this.CustomersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersButton.Location = new System.Drawing.Point(12, 12);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(242, 48);
            this.CustomersButton.TabIndex = 0;
            this.CustomersButton.Text = "Customers";
            this.CustomersButton.UseVisualStyleBackColor = true;
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // ProjectRequestsButton
            // 
            this.ProjectRequestsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectRequestsButton.Location = new System.Drawing.Point(12, 66);
            this.ProjectRequestsButton.Name = "ProjectRequestsButton";
            this.ProjectRequestsButton.Size = new System.Drawing.Size(242, 48);
            this.ProjectRequestsButton.TabIndex = 1;
            this.ProjectRequestsButton.Text = "Project Requests";
            this.ProjectRequestsButton.UseVisualStyleBackColor = true;
            this.ProjectRequestsButton.Click += new System.EventHandler(this.ProjectRequestsButton_Click);
            // 
            // AssembleTeamsButton
            // 
            this.AssembleTeamsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssembleTeamsButton.Location = new System.Drawing.Point(12, 120);
            this.AssembleTeamsButton.Name = "AssembleTeamsButton";
            this.AssembleTeamsButton.Size = new System.Drawing.Size(242, 48);
            this.AssembleTeamsButton.TabIndex = 2;
            this.AssembleTeamsButton.Text = "Assemble Teams";
            this.AssembleTeamsButton.UseVisualStyleBackColor = true;
            this.AssembleTeamsButton.Click += new System.EventHandler(this.AssembleTeamsButton_Click);
            // 
            // P1MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 484);
            this.Controls.Add(this.AssembleTeamsButton);
            this.Controls.Add(this.ProjectRequestsButton);
            this.Controls.Add(this.CustomersButton);
            this.Name = "P1MenuForm";
            this.Text = "P1MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.Button ProjectRequestsButton;
        private System.Windows.Forms.Button AssembleTeamsButton;
    }
}