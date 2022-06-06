
namespace Guia4EstructuraRepetidaEj13EM21018LG17010
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTablaDeNum = new System.Windows.Forms.DataGridView();
            this.ColumNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaDeNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label1.Location = new System.Drawing.Point(32, 27);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(338, 80);
            label1.TabIndex = 1;
            label1.Text = "Números de tres cifras tales que \r\nla suma de los cuadrados de sus dígitos\r\n es i" +
    "gual al cociente de la división entera \r\ndel número entre 3";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label1.UseMnemonic = false;
            // 
            // dgvTablaDeNum
            // 
            this.dgvTablaDeNum.AllowUserToAddRows = false;
            this.dgvTablaDeNum.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.dgvTablaDeNum.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTablaDeNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTablaDeNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaDeNum.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTablaDeNum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaDeNum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumNum});
            this.dgvTablaDeNum.Location = new System.Drawing.Point(71, 174);
            this.dgvTablaDeNum.Name = "dgvTablaDeNum";
            this.dgvTablaDeNum.ReadOnly = true;
            this.dgvTablaDeNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvTablaDeNum.Size = new System.Drawing.Size(243, 288);
            this.dgvTablaDeNum.TabIndex = 0;
            // 
            // ColumNum
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.ColumNum.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumNum.Frozen = true;
            this.ColumNum.HeaderText = "Numeros que complen la condición";
            this.ColumNum.MinimumWidth = 15;
            this.ColumNum.Name = "ColumNum";
            this.ColumNum.ReadOnly = true;
            this.ColumNum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumNum.Width = 200;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcular.Location = new System.Drawing.Point(143, 120);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(113, 33);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Autor: EM21018";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(398, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(label1);
            this.Controls.Add(this.dgvTablaDeNum);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaDeNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTablaDeNum;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumNum;
        private System.Windows.Forms.Label label2;
    }
}

