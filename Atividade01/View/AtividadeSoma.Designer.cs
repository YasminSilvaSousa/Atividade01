namespace Atividade01.View
{
    partial class AtividadeSoma
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
            label1 = new Label();
            tbl_PrimeiroNumero = new Label();
            lbl_SegundoNumero = new Label();
            lbl_Mensagem = new Label();
            txb_PrimeiroNumero = new TextBox();
            txb_SegundoNumero = new TextBox();
            btn_Executar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 Hv BT", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(353, 18);
            label1.Name = "label1";
            label1.Size = new Size(108, 39);
            label1.TabIndex = 0;
            label1.Text = "Soma";
            // 
            // tbl_PrimeiroNumero
            // 
            tbl_PrimeiroNumero.AutoSize = true;
            tbl_PrimeiroNumero.Location = new Point(41, 108);
            tbl_PrimeiroNumero.Name = "tbl_PrimeiroNumero";
            tbl_PrimeiroNumero.Size = new Size(99, 15);
            tbl_PrimeiroNumero.TabIndex = 1;
            tbl_PrimeiroNumero.Text = "Primeiro Número";
            // 
            // lbl_SegundoNumero
            // 
            lbl_SegundoNumero.AutoSize = true;
            lbl_SegundoNumero.Location = new Point(41, 201);
            lbl_SegundoNumero.Name = "lbl_SegundoNumero";
            lbl_SegundoNumero.Size = new Size(101, 15);
            lbl_SegundoNumero.TabIndex = 2;
            lbl_SegundoNumero.Text = "Segundo Número";
            // 
            // lbl_Mensagem
            // 
            lbl_Mensagem.BackColor = Color.FromArgb(255, 192, 255);
            lbl_Mensagem.Location = new Point(277, 247);
            lbl_Mensagem.Name = "lbl_Mensagem";
            lbl_Mensagem.Size = new Size(250, 90);
            lbl_Mensagem.TabIndex = 3;
            // 
            // txb_PrimeiroNumero
            // 
            txb_PrimeiroNumero.Location = new Point(191, 105);
            txb_PrimeiroNumero.Name = "txb_PrimeiroNumero";
            txb_PrimeiroNumero.Size = new Size(162, 23);
            txb_PrimeiroNumero.TabIndex = 4;
            // 
            // txb_SegundoNumero
            // 
            txb_SegundoNumero.Location = new Point(191, 193);
            txb_SegundoNumero.Name = "txb_SegundoNumero";
            txb_SegundoNumero.Size = new Size(173, 23);
            txb_SegundoNumero.TabIndex = 5;
            // 
            // btn_Executar
            // 
            btn_Executar.BackColor = Color.FromArgb(192, 0, 192);
            btn_Executar.Location = new Point(353, 386);
            btn_Executar.Name = "btn_Executar";
            btn_Executar.Size = new Size(124, 23);
            btn_Executar.TabIndex = 6;
            btn_Executar.Text = "Executar";
            btn_Executar.UseVisualStyleBackColor = false;
            btn_Executar.Click += btn_Executar_Click;
            // 
            // AtividadeSoma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Executar);
            Controls.Add(txb_SegundoNumero);
            Controls.Add(txb_PrimeiroNumero);
            Controls.Add(lbl_Mensagem);
            Controls.Add(lbl_SegundoNumero);
            Controls.Add(tbl_PrimeiroNumero);
            Controls.Add(label1);
            Name = "AtividadeSoma";
            Text = "AtividadeSoma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label tbl_PrimeiroNumero;
        private Label lbl_SegundoNumero;
        private Label lbl_Mensagem;
        private TextBox txb_PrimeiroNumero;
        private TextBox txb_SegundoNumero;
        private Button btn_Executar;
    }
}