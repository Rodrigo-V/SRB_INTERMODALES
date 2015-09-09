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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radTextBoxControl1 = new Telerik.WinControls.UI.RadTextBoxControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.habilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dehabilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // radTextBoxControl1
            // 
            this.radTextBoxControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.radTextBoxControl1.Location = new System.Drawing.Point(30, 94);
            this.radTextBoxControl1.Name = "radTextBoxControl1";
            this.radTextBoxControl1.Size = new System.Drawing.Size(78, 20);
            this.radTextBoxControl1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.habilitarToolStripMenuItem,
            this.dehabilitarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.ShowItemToolTips = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 48);
            this.contextMenuStrip1.Text = "Iniciar";
            // 
            // habilitarToolStripMenuItem
            // 
            this.habilitarToolStripMenuItem.Name = "habilitarToolStripMenuItem";
            this.habilitarToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.habilitarToolStripMenuItem.Text = "Habilitar";
            // 
            // dehabilitarToolStripMenuItem
            // 
            this.dehabilitarToolStripMenuItem.Name = "dehabilitarToolStripMenuItem";
            this.dehabilitarToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.dehabilitarToolStripMenuItem.Text = "Deshabilitar";
            // 
            // radButton1
            // 
            this.radButton1.BackColor = System.Drawing.Color.LightSlateGray;
            this.radButton1.Location = new System.Drawing.Point(30, 120);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(78, 54);
            this.radButton1.TabIndex = 1;
            this.radButton1.Text = "radButton1";
            this.radButton1.ThemeName = "Windows8";
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(30, 180);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.toggleSwitch1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitch1.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.toggleSwitch1.Properties.Appearance.Options.UseBackColor = true;
            this.toggleSwitch1.Properties.Appearance.Options.UseFont = true;
            this.toggleSwitch1.Properties.Appearance.Options.UseForeColor = true;
            this.toggleSwitch1.Properties.OffText = "Off";
            this.toggleSwitch1.Properties.OnText = "On";
            this.toggleSwitch1.Size = new System.Drawing.Size(78, 21);
            this.toggleSwitch1.TabIndex = 2;
            this.toggleSwitch1.Toggled += new System.EventHandler(this.toggleSwitch1_Toggled);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(30, 210);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(679, 200);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.ForeColor = System.Drawing.Color.White;
            this.radLabel1.Location = new System.Drawing.Point(776, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(83, 24);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "hora actual";
            this.radLabel1.Click += new System.EventHandler(this.radLabel1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(862, 420);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radTextBoxControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBoxControl radTextBoxControl1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem habilitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dehabilitarToolStripMenuItem;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}

