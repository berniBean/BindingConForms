
namespace DirectorioFrameWork
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
            this.lsTfnos = new System.Windows.Forms.ListBox();
            this.ctTfnosSelec = new System.Windows.Forms.TextBox();
            this.ctNombre = new System.Windows.Forms.TextBox();
            this.ctTfno = new System.Windows.Forms.TextBox();
            this.btAñadir = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsTfnos
            // 
            this.lsTfnos.FormattingEnabled = true;
            this.lsTfnos.Location = new System.Drawing.Point(44, 36);
            this.lsTfnos.Name = "lsTfnos";
            this.lsTfnos.Size = new System.Drawing.Size(272, 134);
            this.lsTfnos.TabIndex = 0;
            // 
            // ctTfnosSelec
            // 
            this.ctTfnosSelec.Location = new System.Drawing.Point(44, 191);
            this.ctTfnosSelec.Name = "ctTfnosSelec";
            this.ctTfnosSelec.ReadOnly = true;
            this.ctTfnosSelec.Size = new System.Drawing.Size(272, 20);
            this.ctTfnosSelec.TabIndex = 1;
            // 
            // ctNombre
            // 
            this.ctNombre.Location = new System.Drawing.Point(383, 36);
            this.ctNombre.Name = "ctNombre";
            this.ctNombre.Size = new System.Drawing.Size(272, 20);
            this.ctNombre.TabIndex = 2;
            // 
            // ctTfno
            // 
            this.ctTfno.Location = new System.Drawing.Point(383, 82);
            this.ctTfno.Name = "ctTfno";
            this.ctTfno.Size = new System.Drawing.Size(272, 20);
            this.ctTfno.TabIndex = 3;
            // 
            // btAñadir
            // 
            this.btAñadir.Location = new System.Drawing.Point(383, 124);
            this.btAñadir.Name = "btAñadir";
            this.btAñadir.Size = new System.Drawing.Size(272, 23);
            this.btAñadir.TabIndex = 4;
            this.btAñadir.Text = "Añadir";
            this.btAñadir.UseVisualStyleBackColor = true;
            this.btAñadir.Click += new System.EventHandler(this.btAñadir_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(383, 153);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(272, 23);
            this.btBorrar.TabIndex = 5;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(383, 188);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(272, 23);
            this.btModificar.TabIndex = 6;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 245);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btAñadir);
            this.Controls.Add(this.ctTfno);
            this.Controls.Add(this.ctNombre);
            this.Controls.Add(this.ctTfnosSelec);
            this.Controls.Add(this.lsTfnos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsTfnos;
        private System.Windows.Forms.TextBox ctTfnosSelec;
        private System.Windows.Forms.TextBox ctNombre;
        private System.Windows.Forms.TextBox ctTfno;
        private System.Windows.Forms.Button btAñadir;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btModificar;
    }
}

