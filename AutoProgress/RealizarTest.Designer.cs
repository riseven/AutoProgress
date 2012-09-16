namespace AutoProgress
{
    partial class RealizarTest
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
            this.lbPregunta = new System.Windows.Forms.Label();
            this.btA = new System.Windows.Forms.Button();
            this.btB = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.btD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPregunta
            // 
            this.lbPregunta.AutoSize = true;
            this.lbPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPregunta.Location = new System.Drawing.Point(12, 9);
            this.lbPregunta.Name = "lbPregunta";
            this.lbPregunta.Size = new System.Drawing.Size(156, 33);
            this.lbPregunta.TabIndex = 0;
            this.lbPregunta.Text = "Pregunta 1";
            // 
            // btA
            // 
            this.btA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btA.Location = new System.Drawing.Point(46, 50);
            this.btA.Name = "btA";
            this.btA.Size = new System.Drawing.Size(107, 48);
            this.btA.TabIndex = 1;
            this.btA.Text = "A";
            this.btA.UseVisualStyleBackColor = true;
            this.btA.Click += new System.EventHandler(this.btA_Click);
            // 
            // btB
            // 
            this.btB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btB.Location = new System.Drawing.Point(46, 104);
            this.btB.Name = "btB";
            this.btB.Size = new System.Drawing.Size(107, 48);
            this.btB.TabIndex = 2;
            this.btB.Text = "B";
            this.btB.UseVisualStyleBackColor = true;
            this.btB.Click += new System.EventHandler(this.btB_Click);
            // 
            // btC
            // 
            this.btC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btC.Location = new System.Drawing.Point(46, 158);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(107, 48);
            this.btC.TabIndex = 3;
            this.btC.Text = "C";
            this.btC.UseVisualStyleBackColor = true;
            this.btC.Click += new System.EventHandler(this.btC_Click);
            // 
            // btD
            // 
            this.btD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btD.Location = new System.Drawing.Point(46, 212);
            this.btD.Name = "btD";
            this.btD.Size = new System.Drawing.Size(107, 48);
            this.btD.TabIndex = 4;
            this.btD.Text = "D";
            this.btD.UseVisualStyleBackColor = true;
            this.btD.Click += new System.EventHandler(this.btD_Click);
            // 
            // RealizarTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 273);
            this.Controls.Add(this.btD);
            this.Controls.Add(this.btC);
            this.Controls.Add(this.btB);
            this.Controls.Add(this.btA);
            this.Controls.Add(this.lbPregunta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RealizarTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RealizarTest";
            this.Load += new System.EventHandler(this.RealizarTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPregunta;
        private System.Windows.Forms.Button btA;
        private System.Windows.Forms.Button btB;
        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.Button btD;
    }
}