
namespace Gestão_de_Ocorrencias
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnAdicionar = new Syncfusion.WinForms.Controls.SfButton();
            this.btnModificar = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRemover = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButton1 = new Syncfusion.WinForms.Controls.SfButton();
            this.sfButton2 = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.AllowEditing = false;
            this.sfDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataGrid1.Location = new System.Drawing.Point(12, 46);
            this.sfDataGrid1.Name = "sfDataGrid1";
            this.sfDataGrid1.NavigationMode = Syncfusion.WinForms.DataGrid.Enums.NavigationMode.Row;
            this.sfDataGrid1.Size = new System.Drawing.Size(971, 568);
            this.sfDataGrid1.TabIndex = 0;
            this.sfDataGrid1.Text = "sfDataGrid1";
            this.sfDataGrid1.SelectionChanged += new Syncfusion.WinForms.DataGrid.Events.SelectionChangedEventHandler(this.sfDataGrid1_SelectionChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.AccessibleName = "Button";
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdicionar.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAdicionar.Location = new System.Drawing.Point(989, 395);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(144, 66);
            this.btnAdicionar.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = " Adicionar";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.AccessibleName = "Button";
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificar.ImageSize = new System.Drawing.Size(32, 32);
            this.btnModificar.Location = new System.Drawing.Point(989, 467);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(144, 66);
            this.btnModificar.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.AccessibleName = "Button";
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemover.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRemover.Location = new System.Drawing.Point(989, 539);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(144, 66);
            this.btnRemover.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnRemover.TabIndex = 3;
            this.btnRemover.Text = "Remover";
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // sfButton1
            // 
            this.sfButton1.AccessibleName = "Button";
            this.sfButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sfButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sfButton1.ImageSize = new System.Drawing.Size(32, 32);
            this.sfButton1.Location = new System.Drawing.Point(989, 46);
            this.sfButton1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.sfButton1.Name = "sfButton1";
            this.sfButton1.Size = new System.Drawing.Size(144, 66);
            this.sfButton1.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.sfButton1.TabIndex = 4;
            this.sfButton1.Text = "Exportar Excel";
            this.sfButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sfButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.sfButton1.Click += new System.EventHandler(this.sfButton1_Click);
            // 
            // sfButton2
            // 
            this.sfButton2.AccessibleName = "Button";
            this.sfButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sfButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.sfButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sfButton2.ImageSize = new System.Drawing.Size(32, 32);
            this.sfButton2.Location = new System.Drawing.Point(989, 324);
            this.sfButton2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.sfButton2.Name = "sfButton2";
            this.sfButton2.Size = new System.Drawing.Size(144, 66);
            this.sfButton2.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.sfButton2.TabIndex = 5;
            this.sfButton2.Text = "Tabelas Adicionais";
            this.sfButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sfButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.sfButton2.Click += new System.EventHandler(this.sfButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1141, 626);
            this.Controls.Add(this.sfButton2);
            this.Controls.Add(this.sfButton1);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.sfDataGrid1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Gestão de Ocorrências";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private Syncfusion.WinForms.Controls.SfButton btnAdicionar;
        private Syncfusion.WinForms.Controls.SfButton btnModificar;
        private Syncfusion.WinForms.Controls.SfButton btnRemover;
        private Syncfusion.WinForms.Controls.SfButton sfButton1;
        private Syncfusion.WinForms.Controls.SfButton sfButton2;
    }
}

