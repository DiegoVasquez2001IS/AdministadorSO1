namespace Admin_Tareas
{
    partial class Tareas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lista_Procesos = new System.Windows.Forms.DataGridView();
            this.idProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemoriaRAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnDetener = new System.Windows.Forms.ToolStripButton();
            this.BtnNuevoProceso = new System.Windows.Forms.ToolStripButton();
            this.BtnActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.TxtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblRAM = new System.Windows.Forms.ToolStripLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lista_Procesos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 80);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Admin_Tareas.Properties.Resources.Task_list;
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador de Tareas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Lista_Procesos);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 381);
            this.panel2.TabIndex = 1;
            // 
            // Lista_Procesos
            // 
            this.Lista_Procesos.AllowUserToAddRows = false;
            this.Lista_Procesos.AllowUserToDeleteRows = false;
            this.Lista_Procesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lista_Procesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProceso,
            this.nombreProceso,
            this.MemoriaRAM});
            this.Lista_Procesos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lista_Procesos.Location = new System.Drawing.Point(0, 25);
            this.Lista_Procesos.Name = "Lista_Procesos";
            this.Lista_Procesos.ReadOnly = true;
            this.Lista_Procesos.Size = new System.Drawing.Size(684, 356);
            this.Lista_Procesos.TabIndex = 3;
            this.Lista_Procesos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Lista_Procesos_CellClick);
            // 
            // idProceso
            // 
            this.idProceso.HeaderText = "Id Proceso";
            this.idProceso.Name = "idProceso";
            this.idProceso.ReadOnly = true;
            this.idProceso.Width = 228;
            // 
            // nombreProceso
            // 
            this.nombreProceso.HeaderText = "Nombre Proceso";
            this.nombreProceso.Name = "nombreProceso";
            this.nombreProceso.ReadOnly = true;
            this.nombreProceso.Width = 228;
            // 
            // MemoriaRAM
            // 
            this.MemoriaRAM.HeaderText = "Memoria (MB)";
            this.MemoriaRAM.Name = "MemoriaRAM";
            this.MemoriaRAM.ReadOnly = true;
            this.MemoriaRAM.Width = 175;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnDetener,
            this.BtnNuevoProceso,
            this.BtnActualizar,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.TxtBuscar,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.lblRAM});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(684, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnDetener
            // 
            this.BtnDetener.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDetener.Image = global::Admin_Tareas.Properties.Resources.Stop;
            this.BtnDetener.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDetener.Name = "BtnDetener";
            this.BtnDetener.Size = new System.Drawing.Size(23, 22);
            this.BtnDetener.Text = "Detener Proceso";
            this.BtnDetener.Click += new System.EventHandler(this.BtnDetener_Click);
            // 
            // BtnNuevoProceso
            // 
            this.BtnNuevoProceso.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnNuevoProceso.Image = global::Admin_Tareas.Properties.Resources._new;
            this.BtnNuevoProceso.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNuevoProceso.Name = "BtnNuevoProceso";
            this.BtnNuevoProceso.Size = new System.Drawing.Size(23, 22);
            this.BtnNuevoProceso.Text = "Nuevo Proceso";
            this.BtnNuevoProceso.Click += new System.EventHandler(this.BtnNuevoProceso_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnActualizar.Image = global::Admin_Tareas.Properties.Resources.reload;
            this.BtnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(23, 22);
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.ToolTipText = "Actualiza los procesos para mostrar los últimos en ejecución";
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(90, 22);
            this.toolStripLabel3.Text = "Buscar Proceso:";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(150, 25);
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(34, 22);
            this.toolStripLabel1.Text = "Ram:";
            // 
            // lblRAM
            // 
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(55, 22);
            this.lblRAM.Text = "00.00 MB";
            // 
            // Tareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Tareas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de Tareas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lista_Procesos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnDetener;
        private System.Windows.Forms.ToolStripButton BtnNuevoProceso;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox TxtBuscar;
        private System.Windows.Forms.DataGridView Lista_Procesos;
        private System.Windows.Forms.ToolStripButton BtnActualizar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lblRAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemoriaRAM;

    }
}