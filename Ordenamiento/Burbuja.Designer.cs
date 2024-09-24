namespace Ordenamiento
{
    partial class Burbuja
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
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.lblValueJ = new System.Windows.Forms.Label();
            this.lblValueI = new System.Windows.Forms.Label();
            this.lblIndexJ = new System.Windows.Forms.Label();
            this.lblIndexI = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblValueJ1 = new System.Windows.Forms.Label();
            this.lblIndexJ1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstNumbers
            // 
            this.lstNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.ItemHeight = 25;
            this.lstNumbers.Location = new System.Drawing.Point(27, 27);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(127, 154);
            this.lstNumbers.TabIndex = 2;
            // 
            // lblValueJ
            // 
            this.lblValueJ.AutoSize = true;
            this.lblValueJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueJ.Location = new System.Drawing.Point(279, 112);
            this.lblValueJ.Name = "lblValueJ";
            this.lblValueJ.Size = new System.Drawing.Size(27, 25);
            this.lblValueJ.TabIndex = 10;
            this.lblValueJ.Text = "...";
            // 
            // lblValueI
            // 
            this.lblValueI.AutoSize = true;
            this.lblValueI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueI.Location = new System.Drawing.Point(284, 63);
            this.lblValueI.Name = "lblValueI";
            this.lblValueI.Size = new System.Drawing.Size(22, 25);
            this.lblValueI.TabIndex = 9;
            this.lblValueI.Text = "..";
            // 
            // lblIndexJ
            // 
            this.lblIndexJ.AutoSize = true;
            this.lblIndexJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndexJ.Location = new System.Drawing.Point(160, 112);
            this.lblIndexJ.Name = "lblIndexJ";
            this.lblIndexJ.Size = new System.Drawing.Size(27, 25);
            this.lblIndexJ.TabIndex = 8;
            this.lblIndexJ.Text = "...";
            // 
            // lblIndexI
            // 
            this.lblIndexI.AutoSize = true;
            this.lblIndexI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndexI.Location = new System.Drawing.Point(160, 63);
            this.lblIndexI.Name = "lblIndexI";
            this.lblIndexI.Size = new System.Drawing.Size(27, 25);
            this.lblIndexI.TabIndex = 7;
            this.lblIndexI.Text = "...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 22);
            this.button1.TabIndex = 11;
            this.button1.Text = "SIGUIENTE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnNextIteration_Click);
            // 
            // lblValueJ1
            // 
            this.lblValueJ1.AutoSize = true;
            this.lblValueJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueJ1.Location = new System.Drawing.Point(279, 156);
            this.lblValueJ1.Name = "lblValueJ1";
            this.lblValueJ1.Size = new System.Drawing.Size(27, 25);
            this.lblValueJ1.TabIndex = 13;
            this.lblValueJ1.Text = "...";
            // 
            // lblIndexJ1
            // 
            this.lblIndexJ1.AutoSize = true;
            this.lblIndexJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndexJ1.Location = new System.Drawing.Point(168, 156);
            this.lblIndexJ1.Name = "lblIndexJ1";
            this.lblIndexJ1.Size = new System.Drawing.Size(27, 25);
            this.lblIndexJ1.TabIndex = 12;
            this.lblIndexJ1.Text = "...";
            // 
            // Burbuja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 246);
            this.Controls.Add(this.lblValueJ1);
            this.Controls.Add(this.lblIndexJ1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblValueJ);
            this.Controls.Add(this.lblValueI);
            this.Controls.Add(this.lblIndexJ);
            this.Controls.Add(this.lblIndexI);
            this.Controls.Add(this.lstNumbers);
            this.Name = "Burbuja";
            this.Text = "Burbuja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.Label lblValueJ;
        private System.Windows.Forms.Label lblValueI;
        private System.Windows.Forms.Label lblIndexJ;
        private System.Windows.Forms.Label lblIndexI;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblValueJ1;
        private System.Windows.Forms.Label lblIndexJ1;
    }
}