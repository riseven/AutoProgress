namespace AutoProgress
{
    partial class NuevaPlantilla
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
            this.dgNuevaPlantilla = new System.Windows.Forms.DataGridView();
            this.autoProgressDataSet = new AutoProgress.AutoProgressDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dgNuevaPlantilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoProgressDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(122, 14);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(121, 20);
            this.tbCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de la plantilla";
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(168, 363);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 3;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // dgNuevaPlantilla
            // 
            this.dgNuevaPlantilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNuevaPlantilla.Location = new System.Drawing.Point(12, 40);
            this.dgNuevaPlantilla.Name = "dgNuevaPlantilla";
            this.dgNuevaPlantilla.Size = new System.Drawing.Size(231, 317);
            this.dgNuevaPlantilla.TabIndex = 2;
            this.dgNuevaPlantilla.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgNuevaPlantilla_UserAddedRow);
            this.dgNuevaPlantilla.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNuevaPlantilla_CellValueChanged);
            // 
            // autoProgressDataSet
            // 
            this.autoProgressDataSet.DataSetName = "AutoProgressDataSet";
            this.autoProgressDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NuevaPlantilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 396);
            this.Controls.Add(this.dgNuevaPlantilla);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NuevaPlantilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Plantilla";
            this.Load += new System.EventHandler(this.NuevaPlantilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNuevaPlantilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoProgressDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.DataGridView dgNuevaPlantilla;
        private AutoProgressDataSet autoProgressDataSet;

    }
}