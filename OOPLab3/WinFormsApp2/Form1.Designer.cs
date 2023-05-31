
namespace WinFormsApp2
{
    partial class Form1
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
            btnSortArray = new System.Windows.Forms.Button();
            btnXorArray = new System.Windows.Forms.Button();
            txtSortArray1 = new System.Windows.Forms.TextBox();
            txtSortArray2 = new System.Windows.Forms.TextBox();
            lstSortArray = new System.Windows.Forms.ListBox();
            txtXorArray = new System.Windows.Forms.TextBox();
            lstXorArray = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnSortArray
            // 
            btnSortArray.Location = new System.Drawing.Point(113, 289);
            btnSortArray.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSortArray.Name = "btnSortArray";
            btnSortArray.Size = new System.Drawing.Size(123, 40);
            btnSortArray.TabIndex = 0;
            btnSortArray.Text = "Sort";
            btnSortArray.UseVisualStyleBackColor = true;
            btnSortArray.Click += btnSortArray_Click;
            // 
            // btnXorArray
            // 
            btnXorArray.Location = new System.Drawing.Point(406, 289);
            btnXorArray.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnXorArray.Name = "btnXorArray";
            btnXorArray.Size = new System.Drawing.Size(123, 40);
            btnXorArray.TabIndex = 1;
            btnXorArray.Text = "Xor";
            btnXorArray.UseVisualStyleBackColor = true;
            btnXorArray.Click += btnXorArray_Click;
            // 
            // txtSortArray1
            // 
            txtSortArray1.Location = new System.Drawing.Point(133, 66);
            txtSortArray1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSortArray1.Name = "txtSortArray1";
            txtSortArray1.Size = new System.Drawing.Size(103, 27);
            txtSortArray1.TabIndex = 2;
            // 
            // txtSortArray2
            // 
            txtSortArray2.Location = new System.Drawing.Point(133, 138);
            txtSortArray2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSortArray2.Name = "txtSortArray2";
            txtSortArray2.Size = new System.Drawing.Size(103, 27);
            txtSortArray2.TabIndex = 3;
            // 
            // lstSortArray
            // 
            lstSortArray.FormattingEnabled = true;
            lstSortArray.ItemHeight = 20;
            lstSortArray.Location = new System.Drawing.Point(99, 361);
            lstSortArray.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lstSortArray.Name = "lstSortArray";
            lstSortArray.Size = new System.Drawing.Size(137, 124);
            lstSortArray.TabIndex = 4;
            // 
            // txtXorArray
            // 
            txtXorArray.Location = new System.Drawing.Point(426, 138);
            txtXorArray.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtXorArray.Name = "txtXorArray";
            txtXorArray.Size = new System.Drawing.Size(103, 27);
            txtXorArray.TabIndex = 5;
            // 
            // lstXorArray
            // 
            lstXorArray.FormattingEnabled = true;
            lstXorArray.ItemHeight = 20;
            lstXorArray.Location = new System.Drawing.Point(392, 361);
            lstXorArray.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lstXorArray.Name = "lstXorArray";
            lstXorArray.Size = new System.Drawing.Size(137, 124);
            lstXorArray.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 73);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(114, 20);
            label1.TabIndex = 7;
            label1.Text = "Введіть массив";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(13, 143);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(114, 20);
            label2.TabIndex = 8;
            label2.Text = "Введіть массив";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(289, 145);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(130, 20);
            label3.TabIndex = 9;
            label3.Text = "Введіть значення";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(586, 600);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstXorArray);
            Controls.Add(txtXorArray);
            Controls.Add(lstSortArray);
            Controls.Add(txtSortArray2);
            Controls.Add(txtSortArray1);
            Controls.Add(btnXorArray);
            Controls.Add(btnSortArray);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSortArray;
        private System.Windows.Forms.Button btnXorArray;
        private System.Windows.Forms.TextBox txtSortArray1;
        private System.Windows.Forms.TextBox txtSortArray2;
        private System.Windows.Forms.ListBox lstSortArray;
        private System.Windows.Forms.TextBox txtXorArray;
        private System.Windows.Forms.ListBox lstXorArray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

