namespace TienditaLapeque
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.radAdmin = new System.Windows.Forms.RadioButton();
            this.radEmpleado = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.tbxConfPass = new System.Windows.Forms.TextBox();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxMaterno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxPaterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChangPass = new System.Windows.Forms.Button();
            this.lblCodP = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.panelContra = new System.Windows.Forms.Panel();
            this.lblMaterno = new System.Windows.Forms.Label();
            this.lblPaterno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbxPassEditConf = new System.Windows.Forms.TextBox();
            this.tbxPassEdit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panelAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.panelContra.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "GESTIÓN DE USUARIOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(536, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 51);
            this.btnClose.TabIndex = 18;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.radAdmin);
            this.panelAdd.Controls.Add(this.radEmpleado);
            this.panelAdd.Controls.Add(this.label7);
            this.panelAdd.Controls.Add(this.btnCrear);
            this.panelAdd.Controls.Add(this.tbxConfPass);
            this.panelAdd.Controls.Add(this.tbxPass);
            this.panelAdd.Controls.Add(this.label2);
            this.panelAdd.Controls.Add(this.label6);
            this.panelAdd.Controls.Add(this.tbxMaterno);
            this.panelAdd.Controls.Add(this.label5);
            this.panelAdd.Controls.Add(this.tbxPaterno);
            this.panelAdd.Controls.Add(this.label4);
            this.panelAdd.Controls.Add(this.tbxName);
            this.panelAdd.Controls.Add(this.label3);
            this.panelAdd.Location = new System.Drawing.Point(16, 310);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(526, 200);
            this.panelAdd.TabIndex = 26;
            this.panelAdd.Visible = false;
            // 
            // radAdmin
            // 
            this.radAdmin.AutoSize = true;
            this.radAdmin.Location = new System.Drawing.Point(284, 100);
            this.radAdmin.Name = "radAdmin";
            this.radAdmin.Size = new System.Drawing.Size(88, 17);
            this.radAdmin.TabIndex = 31;
            this.radAdmin.TabStop = true;
            this.radAdmin.Text = "Administrador";
            this.radAdmin.UseVisualStyleBackColor = true;
            // 
            // radEmpleado
            // 
            this.radEmpleado.AutoSize = true;
            this.radEmpleado.Location = new System.Drawing.Point(189, 100);
            this.radEmpleado.Name = "radEmpleado";
            this.radEmpleado.Size = new System.Drawing.Size(72, 17);
            this.radEmpleado.TabIndex = 30;
            this.radEmpleado.TabStop = true;
            this.radEmpleado.Text = "Empleado";
            this.radEmpleado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Rango de empleado:";
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.LightCoral;
            this.btnCrear.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(414, 88);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(102, 43);
            this.btnCrear.TabIndex = 28;
            this.btnCrear.Text = "Crear Usuario";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // tbxConfPass
            // 
            this.tbxConfPass.BackColor = System.Drawing.Color.SeaShell;
            this.tbxConfPass.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxConfPass.Location = new System.Drawing.Point(169, 157);
            this.tbxConfPass.Name = "tbxConfPass";
            this.tbxConfPass.PasswordChar = '*';
            this.tbxConfPass.Size = new System.Drawing.Size(239, 24);
            this.tbxConfPass.TabIndex = 16;
            this.tbxConfPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxConfPass_KeyPress);
            // 
            // tbxPass
            // 
            this.tbxPass.BackColor = System.Drawing.Color.SeaShell;
            this.tbxPass.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPass.Location = new System.Drawing.Point(169, 127);
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.PasswordChar = '*';
            this.tbxPass.Size = new System.Drawing.Size(239, 24);
            this.tbxPass.TabIndex = 15;
            this.tbxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPass_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Confirmar Contraseña:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Contraseña:";
            // 
            // tbxMaterno
            // 
            this.tbxMaterno.BackColor = System.Drawing.Color.SeaShell;
            this.tbxMaterno.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaterno.Location = new System.Drawing.Point(169, 69);
            this.tbxMaterno.Name = "tbxMaterno";
            this.tbxMaterno.Size = new System.Drawing.Size(239, 24);
            this.tbxMaterno.TabIndex = 7;
            this.tbxMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMaterno_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Apellido Materno:";
            // 
            // tbxPaterno
            // 
            this.tbxPaterno.BackColor = System.Drawing.Color.SeaShell;
            this.tbxPaterno.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPaterno.Location = new System.Drawing.Point(169, 39);
            this.tbxPaterno.Name = "tbxPaterno";
            this.tbxPaterno.Size = new System.Drawing.Size(239, 24);
            this.tbxPaterno.TabIndex = 5;
            this.tbxPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPaterno_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellido Paterno:";
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.Color.SeaShell;
            this.tbxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tbxName.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(169, 9);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(239, 24);
            this.tbxName.TabIndex = 3;
            this.tbxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // btnChangPass
            // 
            this.btnChangPass.BackColor = System.Drawing.Color.LightCoral;
            this.btnChangPass.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangPass.Location = new System.Drawing.Point(432, 53);
            this.btnChangPass.Name = "btnChangPass";
            this.btnChangPass.Size = new System.Drawing.Size(109, 51);
            this.btnChangPass.TabIndex = 11;
            this.btnChangPass.Text = "Cambiar Contraseña";
            this.btnChangPass.UseVisualStyleBackColor = false;
            this.btnChangPass.Click += new System.EventHandler(this.btnChangPass_Click);
            // 
            // lblCodP
            // 
            this.lblCodP.AutoSize = true;
            this.lblCodP.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodP.Location = new System.Drawing.Point(181, 8);
            this.lblCodP.Name = "lblCodP";
            this.lblCodP.Size = new System.Drawing.Size(0, 17);
            this.lblCodP.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightCoral;
            this.btnRefresh.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(475, 99);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(102, 30);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "Refrescar";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightCoral;
            this.btnSearch.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(475, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 30);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.BackColor = System.Drawing.Color.SeaShell;
            this.tbxSearch.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(12, 64);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(457, 30);
            this.tbxSearch.TabIndex = 23;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            this.tbxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSearch_KeyPress);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(475, 260);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 43);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightCoral;
            this.btnEdit.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(475, 202);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 43);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Reestablecer contraseña";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightCoral;
            this.btnAdd.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(475, 144);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 43);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Nuevo usuario";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(9, 100);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.Size = new System.Drawing.Size(460, 204);
            this.dgvUsers.TabIndex = 19;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // panelContra
            // 
            this.panelContra.Controls.Add(this.lblMaterno);
            this.panelContra.Controls.Add(this.lblPaterno);
            this.panelContra.Controls.Add(this.lblNombre);
            this.panelContra.Controls.Add(this.label19);
            this.panelContra.Controls.Add(this.tbxPassEditConf);
            this.panelContra.Controls.Add(this.tbxPassEdit);
            this.panelContra.Controls.Add(this.btnChangPass);
            this.panelContra.Controls.Add(this.label13);
            this.panelContra.Controls.Add(this.label14);
            this.panelContra.Controls.Add(this.label15);
            this.panelContra.Controls.Add(this.label16);
            this.panelContra.Controls.Add(this.label17);
            this.panelContra.Controls.Add(this.label18);
            this.panelContra.Controls.Add(this.lblCodP);
            this.panelContra.Location = new System.Drawing.Point(1, 318);
            this.panelContra.Name = "panelContra";
            this.panelContra.Size = new System.Drawing.Size(576, 149);
            this.panelContra.TabIndex = 27;
            this.panelContra.Visible = false;
            // 
            // lblMaterno
            // 
            this.lblMaterno.AutoSize = true;
            this.lblMaterno.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterno.Location = new System.Drawing.Point(178, 68);
            this.lblMaterno.Name = "lblMaterno";
            this.lblMaterno.Size = new System.Drawing.Size(0, 16);
            this.lblMaterno.TabIndex = 20;
            // 
            // lblPaterno
            // 
            this.lblPaterno.AutoSize = true;
            this.lblPaterno.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaterno.Location = new System.Drawing.Point(178, 48);
            this.lblPaterno.Name = "lblPaterno";
            this.lblPaterno.Size = new System.Drawing.Size(0, 16);
            this.lblPaterno.TabIndex = 19;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(178, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 16);
            this.lblNombre.TabIndex = 18;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(144, 8);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(28, 16);
            this.label19.TabIndex = 17;
            this.label19.Text = "Id:";
            // 
            // tbxPassEditConf
            // 
            this.tbxPassEditConf.BackColor = System.Drawing.Color.SeaShell;
            this.tbxPassEditConf.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassEditConf.Location = new System.Drawing.Point(181, 113);
            this.tbxPassEditConf.Name = "tbxPassEditConf";
            this.tbxPassEditConf.PasswordChar = '*';
            this.tbxPassEditConf.Size = new System.Drawing.Size(239, 24);
            this.tbxPassEditConf.TabIndex = 16;
            this.tbxPassEditConf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPassEditConf_KeyPress);
            // 
            // tbxPassEdit
            // 
            this.tbxPassEdit.BackColor = System.Drawing.Color.SeaShell;
            this.tbxPassEdit.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassEdit.Location = new System.Drawing.Point(181, 85);
            this.tbxPassEdit.Name = "tbxPassEdit";
            this.tbxPassEdit.PasswordChar = '*';
            this.tbxPassEdit.Size = new System.Drawing.Size(239, 24);
            this.tbxPassEdit.TabIndex = 15;
            this.tbxPassEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPassEdit_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(170, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "Confirmar Contraseña:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(82, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "Contraseña:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(46, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 16);
            this.label15.TabIndex = 6;
            this.label15.Text = "Apellido Materno:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(46, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 16);
            this.label16.TabIndex = 4;
            this.label16.Text = "Apellido Paterno:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(107, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 16);
            this.label17.TabIndex = 2;
            this.label17.Text = "Nombre:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(500, 150);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 17);
            this.label18.TabIndex = 1;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(584, 518);
            this.Controls.Add(this.panelContra);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.panelContra.ResumeLayout(false);
            this.panelContra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Button btnChangPass;
        private System.Windows.Forms.TextBox tbxMaterno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxPaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCodP;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TextBox tbxConfPass;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelContra;
        private System.Windows.Forms.TextBox tbxPassEditConf;
        private System.Windows.Forms.TextBox tbxPassEdit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblMaterno;
        private System.Windows.Forms.Label lblPaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.RadioButton radAdmin;
        private System.Windows.Forms.RadioButton radEmpleado;
        private System.Windows.Forms.Label label7;
    }
}