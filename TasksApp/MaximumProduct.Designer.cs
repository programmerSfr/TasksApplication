
namespace TasksApp
{
    partial class MaximumProduct
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
            this.arrLbl = new System.Windows.Forms.Label();
            this.numbersLB = new System.Windows.Forms.ListBox();
            this.multipleOfLbl = new System.Windows.Forms.Label();
            this.multipleOfNm = new System.Windows.Forms.NumericUpDown();
            this.backBtn = new System.Windows.Forms.Button();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.multipleOfNm)).BeginInit();
            this.SuspendLayout();
            // 
            // arrLbl
            // 
            this.arrLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.arrLbl.AutoSize = true;
            this.arrLbl.Location = new System.Drawing.Point(105, 106);
            this.arrLbl.Name = "arrLbl";
            this.arrLbl.Size = new System.Drawing.Size(119, 20);
            this.arrLbl.TabIndex = 0;
            this.arrLbl.Text = "Array of integers";
            // 
            // numbersLB
            // 
            this.numbersLB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numbersLB.FormattingEnabled = true;
            this.numbersLB.ItemHeight = 20;
            this.numbersLB.Location = new System.Drawing.Point(105, 144);
            this.numbersLB.Name = "numbersLB";
            this.numbersLB.Size = new System.Drawing.Size(548, 184);
            this.numbersLB.TabIndex = 2;
            // 
            // multipleOfLbl
            // 
            this.multipleOfLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.multipleOfLbl.AutoSize = true;
            this.multipleOfLbl.Location = new System.Drawing.Point(105, 387);
            this.multipleOfLbl.Name = "multipleOfLbl";
            this.multipleOfLbl.Size = new System.Drawing.Size(182, 20);
            this.multipleOfLbl.TabIndex = 3;
            this.multipleOfLbl.Text = "Number to be multiple of:";
            // 
            // multipleOfNm
            // 
            this.multipleOfNm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.multipleOfNm.Location = new System.Drawing.Point(105, 424);
            this.multipleOfNm.Name = "multipleOfNm";
            this.multipleOfNm.Size = new System.Drawing.Size(150, 27);
            this.multipleOfNm.TabIndex = 3;
            this.multipleOfNm.Enter += new System.EventHandler(this.multipleOfNm_Enter);
            // 
            // backBtn
            // 
            this.backBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backBtn.Location = new System.Drawing.Point(393, 528);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(129, 49);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.calculateBtn.Location = new System.Drawing.Point(242, 528);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(129, 49);
            this.calculateBtn.TabIndex = 4;
            this.calculateBtn.Text = "CALCULATE";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addBtn.Location = new System.Drawing.Point(557, 96);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(40, 40);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.removeBtn.Location = new System.Drawing.Point(613, 96);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(40, 40);
            this.removeBtn.TabIndex = 1;
            this.removeBtn.Text = "-";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // MaximumProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.multipleOfNm);
            this.Controls.Add(this.multipleOfLbl);
            this.Controls.Add(this.numbersLB);
            this.Controls.Add(this.arrLbl);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaximumProduct";
            this.Text = "Maximum Product";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaximumProduct_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.multipleOfNm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label arrLbl;
        private System.Windows.Forms.ListBox numbersLB;
        private System.Windows.Forms.Label multipleOfLbl;
        private System.Windows.Forms.NumericUpDown multipleOfNm;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
    }
}