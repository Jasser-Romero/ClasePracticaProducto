
namespace AppProducto.Formularios
{
    partial class FrmGestionProducto
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
            this.btnFind = new System.Windows.Forms.Button();
            this.rtbProductView = new System.Windows.Forms.RichTextBox();
            this.txtFinder = new System.Windows.Forms.TextBox();
            this.cmbMeasureUnit = new System.Windows.Forms.ComboBox();
            this.cmbFinderType = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(500, 12);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(91, 19);
            this.btnFind.TabIndex = 11;
            this.btnFind.Text = "Buscar";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // rtbProductView
            // 
            this.rtbProductView.Location = new System.Drawing.Point(11, 35);
            this.rtbProductView.Margin = new System.Windows.Forms.Padding(2);
            this.rtbProductView.Name = "rtbProductView";
            this.rtbProductView.ReadOnly = true;
            this.rtbProductView.Size = new System.Drawing.Size(583, 284);
            this.rtbProductView.TabIndex = 10;
            this.rtbProductView.Text = "";
            // 
            // txtFinder
            // 
            this.txtFinder.Location = new System.Drawing.Point(178, 11);
            this.txtFinder.Margin = new System.Windows.Forms.Padding(2);
            this.txtFinder.Name = "txtFinder";
            this.txtFinder.Size = new System.Drawing.Size(318, 20);
            this.txtFinder.TabIndex = 9;
            this.txtFinder.Visible = false;
            // 
            // cmbMeasureUnit
            // 
            this.cmbMeasureUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMeasureUnit.FormattingEnabled = true;
            this.cmbMeasureUnit.Location = new System.Drawing.Point(178, 11);
            this.cmbMeasureUnit.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMeasureUnit.Name = "cmbMeasureUnit";
            this.cmbMeasureUnit.Size = new System.Drawing.Size(143, 21);
            this.cmbMeasureUnit.TabIndex = 8;
            this.cmbMeasureUnit.Visible = false;
            // 
            // cmbFinderType
            // 
            this.cmbFinderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFinderType.FormattingEnabled = true;
            this.cmbFinderType.Items.AddRange(new object[] {
            "Id",
            "Rango Precio",
            "Fecha vencimiento",
            "Unidad Medida"});
            this.cmbFinderType.Location = new System.Drawing.Point(11, 11);
            this.cmbFinderType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFinderType.Name = "cmbFinderType";
            this.cmbFinderType.Size = new System.Drawing.Size(164, 21);
            this.cmbFinderType.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdate);
            this.flowLayoutPanel1.Controls.Add(this.btnNew);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 323);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(582, 34);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(505, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 24);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(426, 2);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 24);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(347, 2);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 24);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click_1);
            // 
            // FrmGestionProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 379);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.rtbProductView);
            this.Controls.Add(this.txtFinder);
            this.Controls.Add(this.cmbMeasureUnit);
            this.Controls.Add(this.cmbFinderType);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FrmGestionProducto";
            this.Text = "FrmGestionProducto";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.RichTextBox rtbProductView;
        private System.Windows.Forms.TextBox txtFinder;
        private System.Windows.Forms.ComboBox cmbMeasureUnit;
        private System.Windows.Forms.ComboBox cmbFinderType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
    }
}