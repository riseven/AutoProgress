namespace AutoProgress
{
    partial class AutoProgressForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoProgressForm));
            this.btIntroducirPlantilla = new System.Windows.Forms.Button();
            this.btNuevoTest = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btPreguntas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btIntroducirPlantilla
            // 
            this.btIntroducirPlantilla.Location = new System.Drawing.Point(12, 12);
            this.btIntroducirPlantilla.Name = "btIntroducirPlantilla";
            this.btIntroducirPlantilla.Size = new System.Drawing.Size(96, 96);
            this.btIntroducirPlantilla.TabIndex = 0;
            this.btIntroducirPlantilla.Text = "Nueva Plantilla";
            this.btIntroducirPlantilla.UseVisualStyleBackColor = true;
            this.btIntroducirPlantilla.Click += new System.EventHandler(this.btIntroducirPlantilla_Click);
            // 
            // btNuevoTest
            // 
            this.btNuevoTest.Location = new System.Drawing.Point(114, 12);
            this.btNuevoTest.Name = "btNuevoTest";
            this.btNuevoTest.Size = new System.Drawing.Size(96, 96);
            this.btNuevoTest.TabIndex = 1;
            this.btNuevoTest.Text = "Nuevo Test";
            this.btNuevoTest.UseVisualStyleBackColor = true;
            this.btNuevoTest.Click += new System.EventHandler(this.btNuevoTest_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 96);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tests";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btPreguntas
            // 
            this.btPreguntas.Location = new System.Drawing.Point(113, 113);
            this.btPreguntas.Name = "btPreguntas";
            this.btPreguntas.Size = new System.Drawing.Size(96, 96);
            this.btPreguntas.TabIndex = 3;
            this.btPreguntas.Text = "Preguntas";
            this.btPreguntas.UseVisualStyleBackColor = true;
            this.btPreguntas.Click += new System.EventHandler(this.btPreguntas_Click);
            // 
            // AutoProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 221);
            this.Controls.Add(this.btPreguntas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btNuevoTest);
            this.Controls.Add(this.btIntroducirPlantilla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutoProgressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoProgress";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btIntroducirPlantilla;
        private System.Windows.Forms.Button btNuevoTest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btPreguntas;
    }
}

