namespace ArturoHerrera24
{
    partial class Jugar
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboPreguntas = new System.Windows.Forms.ComboBox();
            this.lblPreguntas = new System.Windows.Forms.Label();
            this.btnNoSe = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escoga la respuesta correcta para cada pregunta";
            // 
            // comboPreguntas
            // 
            this.comboPreguntas.FormattingEnabled = true;
            this.comboPreguntas.Location = new System.Drawing.Point(212, 206);
            this.comboPreguntas.Name = "comboPreguntas";
            this.comboPreguntas.Size = new System.Drawing.Size(308, 28);
            this.comboPreguntas.TabIndex = 1;
            // 
            // lblPreguntas
            // 
            this.lblPreguntas.AutoSize = true;
            this.lblPreguntas.Location = new System.Drawing.Point(215, 124);
            this.lblPreguntas.Name = "lblPreguntas";
            this.lblPreguntas.Size = new System.Drawing.Size(13, 20);
            this.lblPreguntas.TabIndex = 2;
            this.lblPreguntas.Text = "l";
            // 
            // btnNoSe
            // 
            this.btnNoSe.Location = new System.Drawing.Point(203, 338);
            this.btnNoSe.Name = "btnNoSe";
            this.btnNoSe.Size = new System.Drawing.Size(114, 53);
            this.btnNoSe.TabIndex = 3;
            this.btnNoSe.Text = "Ni Idea";
            this.btnNoSe.UseVisualStyleBackColor = true;
            this.btnNoSe.Click += new System.EventHandler(this.btnNoSe_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(369, 338);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(112, 53);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Estoy seguro";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // Jugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnNoSe);
            this.Controls.Add(this.lblPreguntas);
            this.Controls.Add(this.comboPreguntas);
            this.Controls.Add(this.label1);
            this.Name = "Jugar";
            this.Text = "Jugar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox comboPreguntas;
        private Label lblPreguntas;
        private Button btnNoSe;
        private Button btnConfirmar;
    }
}