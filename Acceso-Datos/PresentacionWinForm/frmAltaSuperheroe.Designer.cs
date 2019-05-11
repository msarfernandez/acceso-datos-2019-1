namespace PresentacionWinForm
{
    partial class frmAltaSuperheroe
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDebilidad = new System.Windows.Forms.Label();
            this.lblCapa = new System.Windows.Forms.Label();
            this.lblVuela = new System.Windows.Forms.Label();
            this.lblUniverso = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDebilidad = new System.Windows.Forms.TextBox();
            this.ckbCapa = new System.Windows.Forms.CheckBox();
            this.ckbVuela = new System.Windows.Forms.CheckBox();
            this.cboUniverso = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 44);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDebilidad
            // 
            this.lblDebilidad.AutoSize = true;
            this.lblDebilidad.Location = new System.Drawing.Point(31, 81);
            this.lblDebilidad.Name = "lblDebilidad";
            this.lblDebilidad.Size = new System.Drawing.Size(54, 13);
            this.lblDebilidad.TabIndex = 1;
            this.lblDebilidad.Text = "Debilidad:";
            // 
            // lblCapa
            // 
            this.lblCapa.AutoSize = true;
            this.lblCapa.Location = new System.Drawing.Point(31, 114);
            this.lblCapa.Name = "lblCapa";
            this.lblCapa.Size = new System.Drawing.Size(35, 13);
            this.lblCapa.TabIndex = 2;
            this.lblCapa.Text = "Capa:";
            // 
            // lblVuela
            // 
            this.lblVuela.AutoSize = true;
            this.lblVuela.Location = new System.Drawing.Point(31, 144);
            this.lblVuela.Name = "lblVuela";
            this.lblVuela.Size = new System.Drawing.Size(37, 13);
            this.lblVuela.TabIndex = 3;
            this.lblVuela.Text = "Vuela:";
            // 
            // lblUniverso
            // 
            this.lblUniverso.AutoSize = true;
            this.lblUniverso.Location = new System.Drawing.Point(31, 175);
            this.lblUniverso.Name = "lblUniverso";
            this.lblUniverso.Size = new System.Drawing.Size(52, 13);
            this.lblUniverso.TabIndex = 4;
            this.lblUniverso.Text = "Universo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(93, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtDebilidad
            // 
            this.txtDebilidad.Location = new System.Drawing.Point(93, 81);
            this.txtDebilidad.Name = "txtDebilidad";
            this.txtDebilidad.Size = new System.Drawing.Size(100, 20);
            this.txtDebilidad.TabIndex = 6;
            // 
            // ckbCapa
            // 
            this.ckbCapa.AutoSize = true;
            this.ckbCapa.Location = new System.Drawing.Point(93, 114);
            this.ckbCapa.Name = "ckbCapa";
            this.ckbCapa.Size = new System.Drawing.Size(15, 14);
            this.ckbCapa.TabIndex = 7;
            this.ckbCapa.UseVisualStyleBackColor = true;
            // 
            // ckbVuela
            // 
            this.ckbVuela.AutoSize = true;
            this.ckbVuela.Location = new System.Drawing.Point(93, 144);
            this.ckbVuela.Name = "ckbVuela";
            this.ckbVuela.Size = new System.Drawing.Size(15, 14);
            this.ckbVuela.TabIndex = 8;
            this.ckbVuela.UseVisualStyleBackColor = true;
            // 
            // cboUniverso
            // 
            this.cboUniverso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUniverso.FormattingEnabled = true;
            this.cboUniverso.Location = new System.Drawing.Point(93, 175);
            this.cboUniverso.Name = "cboUniverso";
            this.cboUniverso.Size = new System.Drawing.Size(121, 21);
            this.cboUniverso.TabIndex = 9;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(34, 234);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(169, 234);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAltaSuperheroe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 299);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cboUniverso);
            this.Controls.Add(this.ckbVuela);
            this.Controls.Add(this.ckbCapa);
            this.Controls.Add(this.txtDebilidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblUniverso);
            this.Controls.Add(this.lblVuela);
            this.Controls.Add(this.lblCapa);
            this.Controls.Add(this.lblDebilidad);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmAltaSuperheroe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Héroe";
            this.Load += new System.EventHandler(this.frmAltaSuperheroe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDebilidad;
        private System.Windows.Forms.Label lblCapa;
        private System.Windows.Forms.Label lblVuela;
        private System.Windows.Forms.Label lblUniverso;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDebilidad;
        private System.Windows.Forms.CheckBox ckbCapa;
        private System.Windows.Forms.CheckBox ckbVuela;
        private System.Windows.Forms.ComboBox cboUniverso;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}