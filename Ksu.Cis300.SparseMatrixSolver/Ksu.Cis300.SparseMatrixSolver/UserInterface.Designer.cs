namespace Ksu.Cis300.SparseMatrixSolver
{
    partial class uxMatrixMultiplier
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
            this.uxMatrixA = new System.Windows.Forms.Button();
            this.uxMatrixB = new System.Windows.Forms.Button();
            this.uxOutput = new System.Windows.Forms.Button();
            this.uxCompute = new System.Windows.Forms.Button();
            this.uxDisplayA = new System.Windows.Forms.TextBox();
            this.uxDisplayB = new System.Windows.Forms.TextBox();
            this.uxDisplayOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxMatrixA
            // 
            this.uxMatrixA.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uxMatrixA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMatrixA.Location = new System.Drawing.Point(29, 26);
            this.uxMatrixA.Name = "uxMatrixA";
            this.uxMatrixA.Size = new System.Drawing.Size(113, 36);
            this.uxMatrixA.TabIndex = 0;
            this.uxMatrixA.Text = "Matrix A";
            this.uxMatrixA.UseVisualStyleBackColor = true;
            this.uxMatrixA.Click += new System.EventHandler(this.uxMatrixA_Click);
            // 
            // uxMatrixB
            // 
            this.uxMatrixB.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uxMatrixB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMatrixB.Location = new System.Drawing.Point(29, 85);
            this.uxMatrixB.Name = "uxMatrixB";
            this.uxMatrixB.Size = new System.Drawing.Size(113, 36);
            this.uxMatrixB.TabIndex = 1;
            this.uxMatrixB.Text = "Matrix B";
            this.uxMatrixB.UseVisualStyleBackColor = true;
            this.uxMatrixB.Click += new System.EventHandler(this.uxMatrixB_Click);
            // 
            // uxOutput
            // 
            this.uxOutput.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOutput.Location = new System.Drawing.Point(29, 143);
            this.uxOutput.Name = "uxOutput";
            this.uxOutput.Size = new System.Drawing.Size(113, 35);
            this.uxOutput.TabIndex = 2;
            this.uxOutput.Text = "Output";
            this.uxOutput.UseVisualStyleBackColor = true;
            this.uxOutput.Click += new System.EventHandler(this.uxOutput_Click);
            // 
            // uxCompute
            // 
            this.uxCompute.Enabled = false;
            this.uxCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCompute.Location = new System.Drawing.Point(29, 204);
            this.uxCompute.Name = "uxCompute";
            this.uxCompute.Size = new System.Drawing.Size(525, 35);
            this.uxCompute.TabIndex = 3;
            this.uxCompute.Text = "Compute Matrix Product";
            this.uxCompute.UseVisualStyleBackColor = true;
            this.uxCompute.Click += new System.EventHandler(this.uxCompute_Click);
            // 
            // uxDisplayA
            // 
            this.uxDisplayA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDisplayA.Location = new System.Drawing.Point(178, 31);
            this.uxDisplayA.Name = "uxDisplayA";
            this.uxDisplayA.ReadOnly = true;
            this.uxDisplayA.Size = new System.Drawing.Size(376, 30);
            this.uxDisplayA.TabIndex = 4;
            // 
            // uxDisplayB
            // 
            this.uxDisplayB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDisplayB.Location = new System.Drawing.Point(178, 90);
            this.uxDisplayB.Name = "uxDisplayB";
            this.uxDisplayB.ReadOnly = true;
            this.uxDisplayB.Size = new System.Drawing.Size(376, 30);
            this.uxDisplayB.TabIndex = 5;
            // 
            // uxDisplayOutput
            // 
            this.uxDisplayOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDisplayOutput.Location = new System.Drawing.Point(178, 147);
            this.uxDisplayOutput.Name = "uxDisplayOutput";
            this.uxDisplayOutput.ReadOnly = true;
            this.uxDisplayOutput.Size = new System.Drawing.Size(376, 30);
            this.uxDisplayOutput.TabIndex = 6;
            // 
            // uxMatrixMultiplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 261);
            this.Controls.Add(this.uxDisplayOutput);
            this.Controls.Add(this.uxDisplayB);
            this.Controls.Add(this.uxDisplayA);
            this.Controls.Add(this.uxCompute);
            this.Controls.Add(this.uxOutput);
            this.Controls.Add(this.uxMatrixB);
            this.Controls.Add(this.uxMatrixA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "uxMatrixMultiplier";
            this.Text = "Matrix Multiplier";
            this.Load += new System.EventHandler(this.uxMatrixMultiplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxMatrixA;
        private System.Windows.Forms.Button uxMatrixB;
        private System.Windows.Forms.Button uxOutput;
        private System.Windows.Forms.Button uxCompute;
        private System.Windows.Forms.TextBox uxDisplayA;
        private System.Windows.Forms.TextBox uxDisplayB;
        private System.Windows.Forms.TextBox uxDisplayOutput;
    }
}

