namespace TienditaLapeque
{
    partial class Prestamos
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
            this.panelAdd = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSaveAdd = new System.Windows.Forms.Button();
            this.tbxCAbono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxCAdeudo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxCName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCodP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.txtAbonoEdit = new System.Windows.Forms.TextBox();
            this.lblCAdeudoEdit = new System.Windows.Forms.Label();
            this.lblCNameEdit = new System.Windows.Forms.Label();
            this.lblEstadoEdit = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSaveChang = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCodEdit = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAdd.SuspendLayout();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.lblEstado);
            this.panelAdd.Controls.Add(this.label6);
            this.panelAdd.Controls.Add(this.btnSaveAdd);
            this.panelAdd.Controls.Add(this.tbxCAbono);
            this.panelAdd.Controls.Add(this.label5);
            this.panelAdd.Controls.Add(this.tbxCAdeudo);
            this.panelAdd.Controls.Add(this.label4);
            this.panelAdd.Controls.Add(this.tbxCName);
            this.panelAdd.Controls.Add(this.label3);
            this.panelAdd.Controls.Add(this.lblCodP);
            this.panelAdd.Controls.Add(this.label2);
            this.panelAdd.Location = new System.Drawing.Point(9, 362);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(568, 158);
            this.panelAdd.TabIndex = 19;
            this.panelAdd.Visible = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(156, 110);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 16);
            this.lblEstado.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Estado del prestamo:";
            // 
            // btnSaveAdd
            // 
            this.btnSaveAdd.BackColor = System.Drawing.Color.LightCoral;
            this.btnSaveAdd.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAdd.Location = new System.Drawing.Point(436, 43);
            this.btnSaveAdd.Name = "btnSaveAdd";
            this.btnSaveAdd.Size = new System.Drawing.Size(109, 51);
            this.btnSaveAdd.TabIndex = 12;
            this.btnSaveAdd.Text = "Agregar Prestamo";
            this.btnSaveAdd.UseVisualStyleBackColor = false;
            this.btnSaveAdd.Click += new System.EventHandler(this.btnSaveAdd_Click);
            // 
            // tbxCAbono
            // 
            this.tbxCAbono.BackColor = System.Drawing.Color.SeaShell;
            this.tbxCAbono.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCAbono.Location = new System.Drawing.Point(156, 85);
            this.tbxCAbono.Name = "tbxCAbono";
            this.tbxCAbono.Size = new System.Drawing.Size(239, 24);
            this.tbxCAbono.TabIndex = 7;
            this.tbxCAbono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCAbono_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Monto de abono:";
            // 
            // tbxCAdeudo
            // 
            this.tbxCAdeudo.BackColor = System.Drawing.Color.SeaShell;
            this.tbxCAdeudo.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCAdeudo.Location = new System.Drawing.Point(156, 57);
            this.tbxCAdeudo.Name = "tbxCAdeudo";
            this.tbxCAdeudo.Size = new System.Drawing.Size(239, 24);
            this.tbxCAdeudo.TabIndex = 5;
            this.tbxCAdeudo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCAdeudo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Monto del adeudo:";
            // 
            // tbxCName
            // 
            this.tbxCName.BackColor = System.Drawing.Color.SeaShell;
            this.tbxCName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tbxCName.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCName.Location = new System.Drawing.Point(156, 30);
            this.tbxCName.Name = "tbxCName";
            this.tbxCName.Size = new System.Drawing.Size(239, 24);
            this.tbxCName.TabIndex = 3;
            this.tbxCName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de cliente:";
            // 
            // lblCodP
            // 
            this.lblCodP.AutoSize = true;
            this.lblCodP.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodP.Location = new System.Drawing.Point(156, 10);
            this.lblCodP.Name = "lblCodP";
            this.lblCodP.Size = new System.Drawing.Size(0, 17);
            this.lblCodP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "No. Prestamo:";
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.txtAbonoEdit);
            this.panelEdit.Controls.Add(this.lblCAdeudoEdit);
            this.panelEdit.Controls.Add(this.lblCNameEdit);
            this.panelEdit.Controls.Add(this.lblEstadoEdit);
            this.panelEdit.Controls.Add(this.label8);
            this.panelEdit.Controls.Add(this.btnSaveChang);
            this.panelEdit.Controls.Add(this.label9);
            this.panelEdit.Controls.Add(this.label10);
            this.panelEdit.Controls.Add(this.label11);
            this.panelEdit.Controls.Add(this.lblCodEdit);
            this.panelEdit.Controls.Add(this.label13);
            this.panelEdit.Location = new System.Drawing.Point(9, 352);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(568, 158);
            this.panelEdit.TabIndex = 20;
            this.panelEdit.Visible = false;
            // 
            // txtAbonoEdit
            // 
            this.txtAbonoEdit.BackColor = System.Drawing.Color.SeaShell;
            this.txtAbonoEdit.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbonoEdit.Location = new System.Drawing.Point(195, 82);
            this.txtAbonoEdit.Name = "txtAbonoEdit";
            this.txtAbonoEdit.Size = new System.Drawing.Size(155, 24);
            this.txtAbonoEdit.TabIndex = 21;
            this.txtAbonoEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAbonoEdit_KeyPress);
            // 
            // lblCAdeudoEdit
            // 
            this.lblCAdeudoEdit.AutoSize = true;
            this.lblCAdeudoEdit.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCAdeudoEdit.Location = new System.Drawing.Point(192, 60);
            this.lblCAdeudoEdit.Name = "lblCAdeudoEdit";
            this.lblCAdeudoEdit.Size = new System.Drawing.Size(135, 16);
            this.lblCAdeudoEdit.TabIndex = 16;
            this.lblCAdeudoEdit.Text = "Nombre de cliente:";
            // 
            // lblCNameEdit
            // 
            this.lblCNameEdit.AutoSize = true;
            this.lblCNameEdit.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNameEdit.Location = new System.Drawing.Point(195, 36);
            this.lblCNameEdit.Name = "lblCNameEdit";
            this.lblCNameEdit.Size = new System.Drawing.Size(135, 16);
            this.lblCNameEdit.TabIndex = 15;
            this.lblCNameEdit.Text = "Nombre de cliente:";
            // 
            // lblEstadoEdit
            // 
            this.lblEstadoEdit.AutoSize = true;
            this.lblEstadoEdit.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoEdit.Location = new System.Drawing.Point(195, 110);
            this.lblEstadoEdit.Name = "lblEstadoEdit";
            this.lblEstadoEdit.Size = new System.Drawing.Size(0, 16);
            this.lblEstadoEdit.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Estado del prestamo:";
            // 
            // btnSaveChang
            // 
            this.btnSaveChang.BackColor = System.Drawing.Color.LightCoral;
            this.btnSaveChang.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChang.Location = new System.Drawing.Point(412, 68);
            this.btnSaveChang.Name = "btnSaveChang";
            this.btnSaveChang.Size = new System.Drawing.Size(109, 51);
            this.btnSaveChang.TabIndex = 11;
            this.btnSaveChang.Text = "Guargar Cambios";
            this.btnSaveChang.UseVisualStyleBackColor = false;
            this.btnSaveChang.Click += new System.EventHandler(this.btnSaveChang_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(67, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Monto de abono:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(54, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Monto del adeudo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(54, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Nombre de cliente:";
            // 
            // lblCodEdit
            // 
            this.lblCodEdit.AutoSize = true;
            this.lblCodEdit.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodEdit.Location = new System.Drawing.Point(195, 10);
            this.lblCodEdit.Name = "lblCodEdit";
            this.lblCodEdit.Size = new System.Drawing.Size(0, 17);
            this.lblCodEdit.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(88, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "No. Prestamo:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightCoral;
            this.btnRefresh.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(480, 118);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(97, 30);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refrescar";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightCoral;
            this.btnSearch.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(480, 69);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 30);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.BackColor = System.Drawing.Color.SeaShell;
            this.tbxSearch.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(14, 69);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(458, 30);
            this.tbxSearch.TabIndex = 16;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(480, 308);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 43);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightCoral;
            this.btnEdit.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(480, 238);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(97, 43);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightCoral;
            this.btnAdd.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(480, 168);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 43);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Agregar prestamo\r\n";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.AllowUserToDeleteRows = false;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Location = new System.Drawing.Point(9, 118);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            this.dgvClient.Size = new System.Drawing.Size(463, 232);
            this.dgvClient.TabIndex = 12;
            this.dgvClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClient_CellClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 51);
            this.label1.TabIndex = 11;
            this.label1.Text = "PRESTAMOS\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(584, 523);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.label1);
            this.Name = "Prestamos";
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.Prestamos_Load);
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Button btnSaveAdd;
        private System.Windows.Forms.TextBox tbxCAbono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxCAdeudo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxCName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCodP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Label lblEstadoEdit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSaveChang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCodEdit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAbonoEdit;
        private System.Windows.Forms.Label lblCAdeudoEdit;
        private System.Windows.Forms.Label lblCNameEdit;
    }
}