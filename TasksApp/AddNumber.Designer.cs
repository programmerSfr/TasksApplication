
namespace TasksApp
{
    partial class AddNumber
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
            this.backBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.numberToAddNm = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numberToAddNm)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backBtn.Location = new System.Drawing.Point(248, 196);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(120, 42);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submitBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.submitBtn.Location = new System.Drawing.Point(122, 196);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(120, 42);
            this.submitBtn.TabIndex = 1;
            this.submitBtn.Text = "SUBMIT";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // numberToAddNm
            // 
            this.numberToAddNm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numberToAddNm.Location = new System.Drawing.Point(169, 98);
            this.numberToAddNm.Name = "numberToAddNm";
            this.numberToAddNm.Size = new System.Drawing.Size(128, 27);
            this.numberToAddNm.TabIndex = 0;
            this.numberToAddNm.Enter += new System.EventHandler(this.numberToAddNm_Enter);
            this.numberToAddNm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberToAddNm_KeyPress);
            // 
            // AddNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 275);
            this.Controls.Add(this.numberToAddNm);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.backBtn);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNumber";
            this.Text = "Add Number";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddNumber_KeyPress_1);
            ((System.ComponentModel.ISupportInitialize)(this.numberToAddNm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.NumericUpDown numberToAddNm;
    }
}