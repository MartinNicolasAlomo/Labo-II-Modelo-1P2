namespace Vista
{
    partial class frmPrincipal
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
            btn_Vender = new Button();
            btn_VerInforme = new Button();
            btn_Salir = new Button();
            lbx_Stock = new ListBox();
            rtb_Informe = new RichTextBox();
            SuspendLayout();
            // 
            // btn_Vender
            // 
            btn_Vender.Location = new Point(12, 292);
            btn_Vender.Name = "btn_Vender";
            btn_Vender.Size = new Size(350, 35);
            btn_Vender.TabIndex = 2;
            btn_Vender.Text = "Vender";
            btn_Vender.UseVisualStyleBackColor = true;
            btn_Vender.Click += btn_Vender_Click;
            // 
            // btn_VerInforme
            // 
            btn_VerInforme.Location = new Point(12, 333);
            btn_VerInforme.Name = "btn_VerInforme";
            btn_VerInforme.Size = new Size(350, 35);
            btn_VerInforme.TabIndex = 3;
            btn_VerInforme.Text = "Ver Informe";
            btn_VerInforme.UseVisualStyleBackColor = true;
            btn_VerInforme.Click += btn_VerInforme_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.Location = new Point(12, 374);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(350, 35);
            btn_Salir.TabIndex = 4;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // lbx_Stock
            // 
            lbx_Stock.FormattingEnabled = true;
            lbx_Stock.ItemHeight = 15;
            lbx_Stock.Location = new Point(12, 12);
            lbx_Stock.Name = "lbx_Stock";
            lbx_Stock.Size = new Size(350, 274);
            lbx_Stock.TabIndex = 5;
            // 
            // rtb_Informe
            // 
            rtb_Informe.Location = new Point(368, 12);
            rtb_Informe.Name = "rtb_Informe";
            rtb_Informe.Size = new Size(368, 397);
            rtb_Informe.TabIndex = 6;
            rtb_Informe.Text = "";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 430);
            Controls.Add(rtb_Informe);
            Controls.Add(lbx_Stock);
            Controls.Add(btn_Salir);
            Controls.Add(btn_VerInforme);
            Controls.Add(btn_Vender);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            FormClosing += frmPrincipal_FormClosing;
            Load += frmPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Vender;
        private Button btn_VerInforme;
        private Button btn_Salir;
        private ListBox lbx_Stock;
        private RichTextBox rtb_Informe;
    }
}