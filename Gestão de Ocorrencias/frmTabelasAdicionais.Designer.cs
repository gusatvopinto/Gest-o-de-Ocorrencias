namespace Gestão_de_Ocorrencias
{
    partial class frmTabelasAdicionais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTabelasAdicionais));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAdicionar = new Syncfusion.WinForms.Controls.SfButton();
            this.btnModificar = new Syncfusion.WinForms.Controls.SfButton();
            this.btnRemover = new Syncfusion.WinForms.Controls.SfButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(25, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(694, 252);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(686, 223);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Turno";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(686, 223);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Operador";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(686, 223);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gravidade";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.AccessibleName = "Button";
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdicionar.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAdicionar.Location = new System.Drawing.Point(159, 342);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(144, 66);
            this.btnAdicionar.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnAdicionar.TabIndex = 2;
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
            this.btnModificar.Location = new System.Drawing.Point(309, 342);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(144, 66);
            this.btnModificar.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // btnRemover
            // 
            this.btnRemover.AccessibleName = "Button";
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemover.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRemover.Location = new System.Drawing.Point(453, 342);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(144, 66);
            this.btnRemover.Style.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "Remover";
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 292);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(358, 20);
            this.textBox1.TabIndex = 5;
            // 
            // frmTabelasAdicionais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 451);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmTabelasAdicionais";
            this.Text = "frmTabelasAdicionais";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Syncfusion.WinForms.Controls.SfButton btnAdicionar;
        private Syncfusion.WinForms.Controls.SfButton btnModificar;
        private Syncfusion.WinForms.Controls.SfButton btnRemover;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox1;
    }
}