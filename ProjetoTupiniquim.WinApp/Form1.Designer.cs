namespace ProjetoTupiniquim.WinApp
{
    partial class Form1
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
            btnExplorar = new Button();
            txtLocalizacao = new TextBox();
            txtComando = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelLocalizacaoFinal = new Label();
            SuspendLayout();
            // 
            // btnExplorar
            // 
            btnExplorar.Location = new Point(73, 99);
            btnExplorar.Name = "btnExplorar";
            btnExplorar.Size = new Size(132, 45);
            btnExplorar.TabIndex = 0;
            btnExplorar.Text = "Explorar";
            btnExplorar.UseVisualStyleBackColor = true;
            btnExplorar.Click += btnExplorar_Click;
            // 
            // txtLocalizacao
            // 
            txtLocalizacao.Location = new Point(79, 22);
            txtLocalizacao.Name = "txtLocalizacao";
            txtLocalizacao.Size = new Size(132, 23);
            txtLocalizacao.TabIndex = 1;
            // 
            // txtComando
            // 
            txtComando.Location = new Point(77, 60);
            txtComando.Name = "txtComando";
            txtComando.Size = new Size(134, 23);
            txtComando.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 25);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "Localição:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 4;
            label2.Text = "Comando:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 162);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 5;
            label3.Text = "Localização Final:";
            // 
            // labelLocalizacaoFinal
            // 
            labelLocalizacaoFinal.AutoSize = true;
            labelLocalizacaoFinal.Location = new Point(118, 162);
            labelLocalizacaoFinal.Name = "labelLocalizacaoFinal";
            labelLocalizacaoFinal.Size = new Size(87, 15);
            labelLocalizacaoFinal.TabIndex = 6;
            labelLocalizacaoFinal.Text = "[localiçãoFinal]";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 250);
            Controls.Add(labelLocalizacaoFinal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtComando);
            Controls.Add(txtLocalizacao);
            Controls.Add(btnExplorar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExplorar;
        private TextBox txtLocalizacao;
        private TextBox txtComando;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelLocalizacaoFinal;
    }
}