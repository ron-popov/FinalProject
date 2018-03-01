namespace FinalProject
{
    partial class MainMenuForm
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
            this.FirstProcessButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstProcessButton
            // 
            this.FirstProcessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstProcessButton.Location = new System.Drawing.Point(12, 12);
            this.FirstProcessButton.Name = "FirstProcessButton";
            this.FirstProcessButton.Size = new System.Drawing.Size(378, 52);
            this.FirstProcessButton.TabIndex = 0;
            this.FirstProcessButton.Text = "P1 : Add New Project";
            this.FirstProcessButton.UseVisualStyleBackColor = true;
            this.FirstProcessButton.Click += new System.EventHandler(this.FirstProcessButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 468);
            this.Controls.Add(this.FirstProcessButton);
            this.Name = "MainMenuForm";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FirstProcessButton;
    }
}