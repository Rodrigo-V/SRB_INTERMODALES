namespace SRB_Intermodal
{
    partial class Form2
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
            Telerik.WinControls.UI.CarouselEllipsePath carouselEllipsePath1 = new Telerik.WinControls.UI.CarouselEllipsePath();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.radCarousel1 = new Telerik.WinControls.UI.RadCarousel();
            this.radImageItem1 = new Telerik.WinControls.UI.RadImageItem();
            this.radImageItem2 = new Telerik.WinControls.UI.RadImageItem();
            this.radImageItem3 = new Telerik.WinControls.UI.RadImageItem();
            this.radImageItem4 = new Telerik.WinControls.UI.RadImageItem();
            this.radImageItem5 = new Telerik.WinControls.UI.RadImageItem();
            ((System.ComponentModel.ISupportInitialize)(this.radCarousel1)).BeginInit();
            this.SuspendLayout();
            // 
            // radCarousel1
            // 
            this.radCarousel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radCarousel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            carouselEllipsePath1.Center = new Telerik.WinControls.UI.Point3D(50D, 50D, 0D);
            carouselEllipsePath1.FinalAngle = -100D;
            carouselEllipsePath1.InitialAngle = -90D;
            carouselEllipsePath1.U = new Telerik.WinControls.UI.Point3D(-20D, -17D, -50D);
            carouselEllipsePath1.V = new Telerik.WinControls.UI.Point3D(30D, -25D, -60D);
            carouselEllipsePath1.ZScale = 500D;
            this.radCarousel1.CarouselPath = carouselEllipsePath1;
            this.radCarousel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radCarousel1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radImageItem1,
            this.radImageItem2,
            this.radImageItem3,
            this.radImageItem4,
            this.radImageItem5});
            this.radCarousel1.Location = new System.Drawing.Point(0, 0);
            this.radCarousel1.Name = "radCarousel1";
            this.radCarousel1.Size = new System.Drawing.Size(794, 475);
            this.radCarousel1.TabIndex = 0;
            this.radCarousel1.Text = "radCarousel1";
            // 
            // radImageItem1
            // 
            this.radImageItem1.AccessibleDescription = "radImageItem1";
            this.radImageItem1.AccessibleName = "radImageItem1";
            this.radImageItem1.BorderVisible = true;
            this.radImageItem1.Image = ((System.Drawing.Image)(resources.GetObject("radImageItem1.Image")));
            this.radImageItem1.Name = "radImageItem1";
            this.radImageItem1.Text = "radImageItem1";
            // 
            // radImageItem2
            // 
            this.radImageItem2.AccessibleDescription = "Nuevo registro";
            this.radImageItem2.AccessibleName = "Nuevo registro";
            this.radImageItem2.BorderVisible = true;
            this.radImageItem2.Image = ((System.Drawing.Image)(resources.GetObject("radImageItem2.Image")));
            this.radImageItem2.Name = "radImageItem2";
            this.radImageItem2.Text = "Nuevo registro";
            this.radImageItem2.Click += new System.EventHandler(this.radImageItem2_Click);
            // 
            // radImageItem3
            // 
            this.radImageItem3.AccessibleDescription = "radImageItem3";
            this.radImageItem3.AccessibleName = "radImageItem3";
            this.radImageItem3.BorderVisible = true;
            this.radImageItem3.Image = ((System.Drawing.Image)(resources.GetObject("radImageItem3.Image")));
            this.radImageItem3.Name = "radImageItem3";
            this.radImageItem3.Text = "radImageItem3";
            // 
            // radImageItem4
            // 
            this.radImageItem4.AccessibleDescription = "radImageItem4";
            this.radImageItem4.AccessibleName = "radImageItem4";
            this.radImageItem4.BorderVisible = true;
            this.radImageItem4.Image = ((System.Drawing.Image)(resources.GetObject("radImageItem4.Image")));
            this.radImageItem4.Name = "radImageItem4";
            this.radImageItem4.Text = "radImageItem4";
            // 
            // radImageItem5
            // 
            this.radImageItem5.AccessibleDescription = "radImageItem5";
            this.radImageItem5.AccessibleName = "radImageItem5";
            this.radImageItem5.BorderVisible = true;
            this.radImageItem5.Image = ((System.Drawing.Image)(resources.GetObject("radImageItem5.Image")));
            this.radImageItem5.Name = "radImageItem5";
            this.radImageItem5.Text = "radImageItem5";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(794, 475);
            this.Controls.Add(this.radCarousel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radCarousel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadCarousel radCarousel1;
        private Telerik.WinControls.UI.RadImageItem radImageItem1;
        private Telerik.WinControls.UI.RadImageItem radImageItem2;
        private Telerik.WinControls.UI.RadImageItem radImageItem3;
        private Telerik.WinControls.UI.RadImageItem radImageItem4;
        private Telerik.WinControls.UI.RadImageItem radImageItem5;
    }
}