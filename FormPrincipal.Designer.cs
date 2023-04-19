namespace Porta_serial
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            lblPortals = new Label();
            btnLimpar = new Button();
            btnOpen = new Button();
            tbox_data = new TextBox();
            cmbPorts = new ComboBox();
            btnListarPortas = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            groupBox1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblPortals);
            groupBox1.Controls.Add(btnLimpar);
            groupBox1.Controls.Add(btnOpen);
            groupBox1.Controls.Add(tbox_data);
            groupBox1.Controls.Add(cmbPorts);
            groupBox1.Controls.Add(btnListarPortas);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(508, 457);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seleção e acionamento";
            // 
            // lblPortals
            // 
            lblPortals.AutoSize = true;
            lblPortals.Location = new Point(11, 29);
            lblPortals.Name = "lblPortals";
            lblPortals.Size = new Size(40, 15);
            lblPortals.TabIndex = 5;
            lblPortals.Text = "Portas";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(391, 424);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(104, 23);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar dados";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(11, 424);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(104, 23);
            btnOpen.TabIndex = 3;
            btnOpen.Text = "Conectar";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // tbox_data
            // 
            tbox_data.Location = new Point(11, 76);
            tbox_data.Multiline = true;
            tbox_data.Name = "tbox_data";
            tbox_data.ScrollBars = ScrollBars.Vertical;
            tbox_data.Size = new Size(484, 340);
            tbox_data.TabIndex = 2;
            // 
            // cmbPorts
            // 
            cmbPorts.FormattingEnabled = true;
            cmbPorts.Location = new Point(11, 47);
            cmbPorts.Name = "cmbPorts";
            cmbPorts.Size = new Size(121, 23);
            cmbPorts.TabIndex = 1;
            // 
            // btnListarPortas
            // 
            btnListarPortas.Location = new Point(138, 47);
            btnListarPortas.Name = "btnListarPortas";
            btnListarPortas.Size = new Size(104, 23);
            btnListarPortas.TabIndex = 0;
            btnListarPortas.Text = "Listar portas";
            btnListarPortas.UseVisualStyleBackColor = true;
            btnListarPortas.Click += btnListarPortas_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 477);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(531, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.ForeColor = Color.Red;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(82, 17);
            toolStripStatusLabel1.Text = "Desconectado";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 499);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comunicação serial";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblPortals;
        private Button btnLimpar;
        private Button btnOpen;
        private TextBox tbox_data;
        private ComboBox cmbPorts;
        private Button btnListarPortas;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}