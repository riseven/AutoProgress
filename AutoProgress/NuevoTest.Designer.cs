namespace AutoProgress
{
    partial class NuevoTest
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
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.autoProgressDataSet = new AutoProgress.AutoProgressDataSet();
            this.cbPlantilla = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNumPreguntas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.autoProgressDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(122, 14);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(100, 20);
            this.tbCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código del test";
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(147, 93);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 6;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // autoProgressDataSet
            // 
            this.autoProgressDataSet.DataSetName = "AutoProgressDataSet";
            this.autoProgressDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbPlantilla
            // 
            this.cbPlantilla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlantilla.FormattingEnabled = true;
            this.cbPlantilla.Location = new System.Drawing.Point(122, 40);
            this.cbPlantilla.Name = "cbPlantilla";
            this.cbPlantilla.Size = new System.Drawing.Size(100, 21);
            this.cbPlantilla.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Plantilla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Número de preguntas";
            // 
            // tbNumPreguntas
            // 
            this.tbNumPreguntas.Location = new System.Drawing.Point(122, 67);
            this.tbNumPreguntas.Name = "tbNumPreguntas";
            this.tbNumPreguntas.Size = new System.Drawing.Size(100, 20);
            this.tbNumPreguntas.TabIndex = 5;
            // 
            // NuevoTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 125);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNumPreguntas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPlantilla);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NuevoTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Test";
            this.Load += new System.EventHandler(this.NuevoTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoProgressDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAceptar;
        private AutoProgressDataSet autoProgressDataSet;
        private System.Windows.Forms.ComboBox cbPlantilla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNumPreguntas;

    }
}