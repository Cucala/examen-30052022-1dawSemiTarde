namespace SalmeronRubio_AntonioNicolas_Numero24
{
    partial class Form3
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
            this.lblPregunta = new System.Windows.Forms.Label();
            this.btnNiIdea = new System.Windows.Forms.Button();
            this.btnSeguro = new System.Windows.Forms.Button();
            this.comboBoxRespuestas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la opción correcta de la pregunta";
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(175, 105);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(118, 29);
            this.lblPregunta.TabIndex = 1;
            this.lblPregunta.Text = "Pregunta";
            // 
            // btnNiIdea
            // 
            this.btnNiIdea.Location = new System.Drawing.Point(180, 320);
            this.btnNiIdea.Name = "btnNiIdea";
            this.btnNiIdea.Size = new System.Drawing.Size(177, 53);
            this.btnNiIdea.TabIndex = 2;
            this.btnNiIdea.Text = "Ni idea";
            this.btnNiIdea.UseVisualStyleBackColor = true;
            this.btnNiIdea.Click += new System.EventHandler(this.btnNiIdea_Click);
            // 
            // btnSeguro
            // 
            this.btnSeguro.Location = new System.Drawing.Point(465, 320);
            this.btnSeguro.Name = "btnSeguro";
            this.btnSeguro.Size = new System.Drawing.Size(177, 53);
            this.btnSeguro.TabIndex = 3;
            this.btnSeguro.Text = "¡Estoy seguro!";
            this.btnSeguro.UseVisualStyleBackColor = true;
            this.btnSeguro.Click += new System.EventHandler(this.btnSeguro_Click);
            // 
            // comboBoxRespuestas
            // 
            this.comboBoxRespuestas.FormattingEnabled = true;
            this.comboBoxRespuestas.Location = new System.Drawing.Point(180, 191);
            this.comboBoxRespuestas.Name = "comboBoxRespuestas";
            this.comboBoxRespuestas.Size = new System.Drawing.Size(462, 24);
            this.comboBoxRespuestas.TabIndex = 4;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.comboBoxRespuestas);
            this.Controls.Add(this.btnSeguro);
            this.Controls.Add(this.btnNiIdea);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Hola soy Mister Question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Button btnNiIdea;
        private System.Windows.Forms.Button btnSeguro;
        private System.Windows.Forms.ComboBox comboBoxRespuestas;
    }
}