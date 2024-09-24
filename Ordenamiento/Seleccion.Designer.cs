namespace Ordenamiento
{
    partial class Seleccion
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
            this.button1 = new System.Windows.Forms.Button();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.lblI = new System.Windows.Forms.Label();
            this.lblMinIdx = new System.Windows.Forms.Label();
            this.lblJ = new System.Windows.Forms.Label();
            this.lblValueI = new System.Windows.Forms.Label();
            this.lblValueJ = new System.Windows.Forms.Label();
            this.lblValueMinIdx = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "SIGUIENTE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnNextIteration_Click);
            // 
            // lstNumbers
            // 
            this.lstNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.ItemHeight = 25;
            this.lstNumbers.Location = new System.Drawing.Point(12, 12);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(127, 154);
            this.lstNumbers.TabIndex = 1;
            // 
            // lblI
            // 
            this.lblI.AutoSize = true;
            this.lblI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblI.Location = new System.Drawing.Point(145, 38);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(27, 25);
            this.lblI.TabIndex = 2;
            this.lblI.Text = "...";
            // 
            // lblMinIdx
            // 
            this.lblMinIdx.AutoSize = true;
            this.lblMinIdx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinIdx.Location = new System.Drawing.Point(146, 129);
            this.lblMinIdx.Name = "lblMinIdx";
            this.lblMinIdx.Size = new System.Drawing.Size(27, 25);
            this.lblMinIdx.TabIndex = 3;
            this.lblMinIdx.Text = "...";
            // 
            // lblJ
            // 
            this.lblJ.AutoSize = true;
            this.lblJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJ.Location = new System.Drawing.Point(146, 87);
            this.lblJ.Name = "lblJ";
            this.lblJ.Size = new System.Drawing.Size(27, 25);
            this.lblJ.TabIndex = 4;
            this.lblJ.Text = "...";
            // 
            // lblValueI
            // 
            this.lblValueI.AutoSize = true;
            this.lblValueI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueI.Location = new System.Drawing.Point(257, 38);
            this.lblValueI.Name = "lblValueI";
            this.lblValueI.Size = new System.Drawing.Size(22, 25);
            this.lblValueI.TabIndex = 5;
            this.lblValueI.Text = "..";
            // 
            // lblValueJ
            // 
            this.lblValueJ.AutoSize = true;
            this.lblValueJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueJ.Location = new System.Drawing.Point(257, 87);
            this.lblValueJ.Name = "lblValueJ";
            this.lblValueJ.Size = new System.Drawing.Size(27, 25);
            this.lblValueJ.TabIndex = 6;
            this.lblValueJ.Text = "...";
            // 
            // lblValueMinIdx
            // 
            this.lblValueMinIdx.AutoSize = true;
            this.lblValueMinIdx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueMinIdx.Location = new System.Drawing.Point(257, 129);
            this.lblValueMinIdx.Name = "lblValueMinIdx";
            this.lblValueMinIdx.Size = new System.Drawing.Size(27, 25);
            this.lblValueMinIdx.TabIndex = 7;
            this.lblValueMinIdx.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 204);
            this.Controls.Add(this.lblValueMinIdx);
            this.Controls.Add(this.lblValueJ);
            this.Controls.Add(this.lblValueI);
            this.Controls.Add(this.lblJ);
            this.Controls.Add(this.lblMinIdx);
            this.Controls.Add(this.lblI);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.Label lblI;
        private System.Windows.Forms.Label lblMinIdx;
        private System.Windows.Forms.Label lblJ;
        private System.Windows.Forms.Label lblValueI;
        private System.Windows.Forms.Label lblValueJ;
        private System.Windows.Forms.Label lblValueMinIdx;
    }
}

