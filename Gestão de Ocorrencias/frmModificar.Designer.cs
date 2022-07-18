
namespace Gestão_de_Ocorrencias
{
    partial class adcModificar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adcModificar));
            this.txtTurno = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label7 = new System.Windows.Forms.Label();
            this.cboOperador = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGravar = new Syncfusion.WinForms.Controls.SfButton();
            this.cboGravidade = new Syncfusion.WinForms.ListView.SfComboBox();
            this.txtTitulo = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtDescricao = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtmData = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hHora = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTurno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOperador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGravidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTurno
            // 
            this.txtTurno.BeforeTouchSize = new System.Drawing.Size(499, 235);
            this.txtTurno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurno.Location = new System.Drawing.Point(120, 156);
            this.txtTurno.Multiline = true;
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.Size = new System.Drawing.Size(499, 32);
            this.txtTurno.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 21);
            this.label7.TabIndex = 30;
            this.label7.Text = "Turno:";
            // 
            // cboOperador
            // 
            this.cboOperador.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboOperador.Location = new System.Drawing.Point(120, 194);
            this.cboOperador.Name = "cboOperador";
            this.cboOperador.Size = new System.Drawing.Size(232, 28);
            this.cboOperador.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboOperador.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 28;
            this.label6.Text = "Operador:";
            // 
            // btnGravar
            // 
            this.btnGravar.AccessibleName = "Button";
            this.btnGravar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnGravar.Location = new System.Drawing.Point(634, 440);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(149, 66);
            this.btnGravar.TabIndex = 27;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // cboGravidade
            // 
            this.cboGravidade.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            this.cboGravidade.Location = new System.Drawing.Point(120, 228);
            this.cboGravidade.Name = "cboGravidade";
            this.cboGravidade.Size = new System.Drawing.Size(232, 28);
            this.cboGravidade.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboGravidade.TabIndex = 26;
            // 
            // txtTitulo
            // 
            this.txtTitulo.BeforeTouchSize = new System.Drawing.Size(499, 235);
            this.txtTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(120, 118);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(499, 32);
            this.txtTitulo.TabIndex = 25;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BeforeTouchSize = new System.Drawing.Size(499, 235);
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(120, 271);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(499, 235);
            this.txtDescricao.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Gravidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Título:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Hora:";
            // 
            // dtmData
            // 
            this.dtmData.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtmData.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;
            this.dtmData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmData.Location = new System.Drawing.Point(120, 30);
            this.dtmData.Name = "dtmData";
            this.dtmData.Size = new System.Drawing.Size(232, 31);
            this.dtmData.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Data:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // hHora
            // 
            this.hHora.Cursor = System.Windows.Forms.Cursors.Default;
            this.hHora.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;
            this.hHora.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.LongTime;
            this.hHora.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hHora.Location = new System.Drawing.Point(120, 76);
            this.hHora.Name = "hHora";
            this.hHora.Size = new System.Drawing.Size(232, 31);
            this.hHora.TabIndex = 33;
            // 
            // adcModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 528);
            this.Controls.Add(this.hHora);
            this.Controls.Add(this.txtTurno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboOperador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.cboGravidade);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtmData);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "adcModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.adcModificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTurno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOperador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGravidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTurno;
        private System.Windows.Forms.Label label7;
        private Syncfusion.WinForms.ListView.SfComboBox cboOperador;
        private System.Windows.Forms.Label label6;
        private Syncfusion.WinForms.Controls.SfButton btnGravar;
        private Syncfusion.WinForms.ListView.SfComboBox cboGravidade;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTitulo;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDescricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtmData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Syncfusion.WinForms.Input.SfDateTimeEdit hHora;
    }
}