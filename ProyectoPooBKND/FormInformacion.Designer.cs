namespace ProyectoPooBKND
{
    partial class FormInformacion
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
            this.panelnfo = new System.Windows.Forms.Panel();
            this.bttnIngenierias = new System.Windows.Forms.Button();
            this.bttnHumanidades = new System.Windows.Forms.Button();
            this.bttnSalud = new System.Windows.Forms.Button();
            this.cbbHumanidades = new System.Windows.Forms.ComboBox();
            this.cbbIngenierias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbSalud = new System.Windows.Forms.ComboBox();
            this.panelnfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelnfo
            // 
            this.panelnfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelnfo.Controls.Add(this.bttnIngenierias);
            this.panelnfo.Controls.Add(this.bttnHumanidades);
            this.panelnfo.Controls.Add(this.bttnSalud);
            this.panelnfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelnfo.Location = new System.Drawing.Point(0, 0);
            this.panelnfo.Margin = new System.Windows.Forms.Padding(2);
            this.panelnfo.Name = "panelnfo";
            this.panelnfo.Size = new System.Drawing.Size(114, 739);
            this.panelnfo.TabIndex = 0;
            // 
            // bttnIngenierias
            // 
            this.bttnIngenierias.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnIngenierias.FlatAppearance.BorderSize = 0;
            this.bttnIngenierias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnIngenierias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.bttnIngenierias.Location = new System.Drawing.Point(0, 252);
            this.bttnIngenierias.Margin = new System.Windows.Forms.Padding(2);
            this.bttnIngenierias.Name = "bttnIngenierias";
            this.bttnIngenierias.Size = new System.Drawing.Size(114, 117);
            this.bttnIngenierias.TabIndex = 2;
            this.bttnIngenierias.Text = "Ciencias e Ingenierías";
            this.bttnIngenierias.UseVisualStyleBackColor = true;
            this.bttnIngenierias.Click += new System.EventHandler(this.bttnIngenierias_Click);
            // 
            // bttnHumanidades
            // 
            this.bttnHumanidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnHumanidades.FlatAppearance.BorderSize = 0;
            this.bttnHumanidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnHumanidades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.bttnHumanidades.Location = new System.Drawing.Point(0, 128);
            this.bttnHumanidades.Margin = new System.Windows.Forms.Padding(2);
            this.bttnHumanidades.Name = "bttnHumanidades";
            this.bttnHumanidades.Size = new System.Drawing.Size(114, 124);
            this.bttnHumanidades.TabIndex = 1;
            this.bttnHumanidades.Text = "Ciencias Sociales y Humanidades";
            this.bttnHumanidades.UseVisualStyleBackColor = true;
            this.bttnHumanidades.Click += new System.EventHandler(this.bttnHumanidades_Click);
            // 
            // bttnSalud
            // 
            this.bttnSalud.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnSalud.FlatAppearance.BorderSize = 0;
            this.bttnSalud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSalud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.bttnSalud.Location = new System.Drawing.Point(0, 0);
            this.bttnSalud.Margin = new System.Windows.Forms.Padding(2);
            this.bttnSalud.Name = "bttnSalud";
            this.bttnSalud.Size = new System.Drawing.Size(114, 128);
            this.bttnSalud.TabIndex = 0;
            this.bttnSalud.Text = "Ciencias de la salud ";
            this.bttnSalud.UseVisualStyleBackColor = true;
            this.bttnSalud.Click += new System.EventHandler(this.bttnSalud_Click);
            // 
            // cbbHumanidades
            // 
            this.cbbHumanidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.cbbHumanidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbHumanidades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.cbbHumanidades.FormattingEnabled = true;
            this.cbbHumanidades.Items.AddRange(new object[] {
            "ADMINISTRACIÓN",
            "ARQUEOLOGÍA",
            "CIENCIAS DE LA COMUNICACIÓN",
            "CIENCIAS DE LA EDUCACIÓN EN CIENCIAS BIOLÓGICAS Y QUÍMICA",
            "CIENCIAS DE LA EDUCACIÓN EN EDUCACIÓN ARTÍSTICA",
            "CIENCIAS DE LA EDUCACIÓN EN EDUCACIÓN FÍSICA",
            "CIENCIAS DE LA EDUCACIÓN EN EDUCACIÓN INICIAL",
            "CIENCIAS DE LA EDUCACIÓN EN EDUCACIÓN PRIMARIA",
            "CIENCIAS DE LA EDUCACIÓN EN FILOSOFÍA, PSICOLOGÍA Y CIENCIAS SOCIALES",
            "CIENCIAS DE LA EDUCACIÓN EN HISTORIA Y GEOGRAFÍA",
            "CIENCIAS DE LA EDUCACIÓN EN LENGUA Y LITERATURA",
            "CIENCIAS DE LA EDUCACIÓN EN MATEMÁTICA E INFORMÁTICA",
            "CONTABILIDAD",
            "DERECHO",
            "ECONOMÍA",
            "NEGOCIOS INTERNACIONALES",
            "TURISMO"});
            this.cbbHumanidades.Location = new System.Drawing.Point(116, 181);
            this.cbbHumanidades.Margin = new System.Windows.Forms.Padding(2);
            this.cbbHumanidades.Name = "cbbHumanidades";
            this.cbbHumanidades.Size = new System.Drawing.Size(404, 21);
            this.cbbHumanidades.TabIndex = 2;
            this.cbbHumanidades.SelectedIndexChanged += new System.EventHandler(this.cbbHumanidades_SelectedIndexChanged);
            // 
            // cbbIngenierias
            // 
            this.cbbIngenierias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.cbbIngenierias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbIngenierias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.cbbIngenierias.FormattingEnabled = true;
            this.cbbIngenierias.Items.AddRange(new object[] {
            "AGRONOMÍA",
            "ARQUITECTURA",
            "ESTADÍSTICA",
            "FÍSICA",
            "INGENIERÍA AMBIENTAL Y SANITARIA",
            "INGENIERÍA CIVIL",
            "INGENIERÍA DE ALIMENTOS",
            "INGENIERÍA DE MINAS",
            "INGENIERÍA DE SISTEMAS",
            "INGENIERÍA ELECTRÓNICA",
            "INGENIERÍA METALÚRGICA",
            "INGENIERÍA MECÁNICA ELÉCTRICA",
            "INGENIERÍA PESQUERA",
            "INGENIERÍA QUÍMICA",
            "MATEMÁTICA E INFROMÁTICA"});
            this.cbbIngenierias.Location = new System.Drawing.Point(116, 301);
            this.cbbIngenierias.Margin = new System.Windows.Forms.Padding(2);
            this.cbbIngenierias.Name = "cbbIngenierias";
            this.cbbIngenierias.Size = new System.Drawing.Size(404, 21);
            this.cbbIngenierias.TabIndex = 3;
            this.cbbIngenierias.Visible = false;
            this.cbbIngenierias.SelectedIndexChanged += new System.EventHandler(this.cbbIngenierias_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(141, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 691);
            this.label1.TabIndex = 4;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbbSalud
            // 
            this.cbbSalud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.cbbSalud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbSalud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.cbbSalud.Items.AddRange(new object[] {
            "BIOLOGÍA",
            "ENFERMERÍA",
            "FARMACIA Y BIOQUÍMICA",
            "MEDICINA VETERINARIA Y ZOOTECNIA",
            "OBSTETRICIA",
            "ODONTOLOGÍA",
            "PSICOLOGÍA"});
            this.cbbSalud.Location = new System.Drawing.Point(116, 56);
            this.cbbSalud.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSalud.Name = "cbbSalud";
            this.cbbSalud.Size = new System.Drawing.Size(404, 21);
            this.cbbSalud.TabIndex = 1;
            this.cbbSalud.Visible = false;
            this.cbbSalud.SelectedIndexChanged += new System.EventHandler(this.cbbSalud_SelectedIndexChanged);
            // 
            // FormInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(744, 739);
            this.Controls.Add(this.panelnfo);
            this.Controls.Add(this.cbbIngenierias);
            this.Controls.Add(this.cbbHumanidades);
            this.Controls.Add(this.cbbSalud);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormInformacion";
            this.Text = "FormInformacion";
            this.Load += new System.EventHandler(this.FormInformacion_Load);
            this.panelnfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelnfo;
        private System.Windows.Forms.Button bttnIngenierias;
        private System.Windows.Forms.Button bttnHumanidades;
        private System.Windows.Forms.Button bttnSalud;
        private System.Windows.Forms.ComboBox cbbHumanidades;
        private System.Windows.Forms.ComboBox cbbIngenierias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbSalud;
    }
}