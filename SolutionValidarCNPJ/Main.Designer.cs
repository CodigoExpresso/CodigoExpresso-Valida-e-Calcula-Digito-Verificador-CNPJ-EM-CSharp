namespace SolutionValidarCNPJ
{
    partial class Main
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
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.btValidaCNPJ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informar um CNPJ com o dígito verificador";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(77, 95);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(206, 20);
            this.txtCNPJ.TabIndex = 3;
            // 
            // btValidaCNPJ
            // 
            this.btValidaCNPJ.Location = new System.Drawing.Point(173, 139);
            this.btValidaCNPJ.Name = "btValidaCNPJ";
            this.btValidaCNPJ.Size = new System.Drawing.Size(110, 23);
            this.btValidaCNPJ.TabIndex = 5;
            this.btValidaCNPJ.Text = "Verifica CNPJ";
            this.btValidaCNPJ.UseVisualStyleBackColor = true;
            this.btValidaCNPJ.Click += new System.EventHandler(this.btValidaCNPJ_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 261);
            this.Controls.Add(this.btValidaCNPJ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCNPJ);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verifica se p CNPJ é válido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Button btValidaCNPJ;
    }
}

