
namespace TasksApp
{
    partial class MainForm
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
            this.maxProdBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maxProdBtn
            // 
            this.maxProdBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxProdBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.maxProdBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxProdBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.maxProdBtn.Location = new System.Drawing.Point(23, 96);
            this.maxProdBtn.Name = "maxProdBtn";
            this.maxProdBtn.Size = new System.Drawing.Size(206, 174);
            this.maxProdBtn.TabIndex = 1;
            this.maxProdBtn.Text = "Maximum Product";
            this.maxProdBtn.UseVisualStyleBackColor = false;
            this.maxProdBtn.Click += new System.EventHandler(this.maxProdBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.maxProdBtn);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Tasks";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button maxProdBtn;
    }
}

