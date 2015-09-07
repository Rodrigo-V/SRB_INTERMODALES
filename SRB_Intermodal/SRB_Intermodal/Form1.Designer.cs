namespace SRB_Intermodal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.radTextBoxControl1 = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // radTextBoxControl1
            // 
            this.radTextBoxControl1.Location = new System.Drawing.Point(44, 41);
            this.radTextBoxControl1.Name = "radTextBoxControl1";
            this.radTextBoxControl1.Size = new System.Drawing.Size(55, 20);
            this.radTextBoxControl1.TabIndex = 0;
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(34, 67);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(76, 54);
            this.radButton1.TabIndex = 1;
            this.radButton1.Text = "radButton1";
            this.radButton1.ThemeName = "Office2013Light";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 325);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radTextBoxControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBoxControl radTextBoxControl1;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}

