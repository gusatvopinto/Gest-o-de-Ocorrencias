namespace Gestão_de_Ocorrencias
{
    partial class TabelasAdicionais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabelasAdicionais));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAdicionar = new Syncfusion.WinForms.Controls.SfButton();
            this.btnModificar = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRemover = new Syncfusion.WinForms.Controls.SfButton();
            this.dataGridView1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.dataGridView2 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.dataGridView3 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(581, 401);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(573, 372);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Turno";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(573, 372);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Operador";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(573, 372);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gravidade";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.AccessibleName = "Button";
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdicionar.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAdicionar.Location = new System.Drawing.Point(590, 199);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(140, 66);
            this.btnAdicionar.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = " Adicionar";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.AccessibleName = "Button";
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificar.ImageSize = new System.Drawing.Size(32, 32);
            this.btnModificar.Location = new System.Drawing.Point(590, 271);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(140, 66);
            this.btnModificar.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnModificar.TabIndex = 5;
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
            this.btnRemover.Location = new System.Drawing.Point(590, 343);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(140, 66);
            this.btnRemover.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnRemover.TabIndex = 6;
            this.btnRemover.Text = "Remover";
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleName = "Table";
            this.dataGridView1.AllowEditing = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.NavigationMode = Syncfusion.WinForms.DataGrid.Enums.NavigationMode.Row;
            this.dataGridView1.Size = new System.Drawing.Size(564, 363);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.Text = "sfDataGrid1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AccessibleName = "Table";
            this.dataGridView2.AllowEditing = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.NavigationMode = Syncfusion.WinForms.DataGrid.Enums.NavigationMode.Row;
            this.dataGridView2.Size = new System.Drawing.Size(564, 363);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.Text = "sfDataGrid1";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AccessibleName = "Table";
            this.dataGridView3.AllowEditing = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.Location = new System.Drawing.Point(5, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.NavigationMode = Syncfusion.WinForms.DataGrid.Enums.NavigationMode.Row;
            this.dataGridView3.Size = new System.Drawing.Size(564, 363);
            this.dataGridView3.TabIndex = 9;
            this.dataGridView3.Text = "sfDataGrid1";
            // 
            // TabelasAdicionais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 415);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.tabControl1);
            this.Name = "TabelasAdicionais";
            this.Text = "frmTabelasAdicionais";
            this.Load += new System.EventHandler(this.frmTabelasAdicionais_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private Syncfusion.WinForms.Controls.SfButton btnAdicionar;
        private Syncfusion.WinForms.Controls.SfButton btnModificar;
        private Syncfusion.WinForms.Controls.SfButton btnRemover;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dataGridView1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dataGridView2;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dataGridView3;
    }
}