namespace CUPON
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
            LBLIGMONTO = new Label();
            LBLIGCUPON = new Label();
            LBLIGPAGO = new Label();
            LBLDESCUENTO = new Label();
            LBLTTAPAGAR = new Label();
            TXTMONTO = new TextBox();
            TXTCUPON = new TextBox();
            TXTPAGO = new TextBox();
            TXTDESC = new TextBox();
            TXTTAL = new TextBox();
            BTNCOMPRA = new Button();
            SuspendLayout();
            // 
            // LBLIGMONTO
            // 
            LBLIGMONTO.AutoSize = true;
            LBLIGMONTO.Location = new Point(73, 34);
            LBLIGMONTO.Name = "LBLIGMONTO";
            LBLIGMONTO.Size = new Size(121, 20);
            LBLIGMONTO.TabIndex = 0;
            LBLIGMONTO.Text = "Ingresa el Monto";
            // 
            // LBLIGCUPON
            // 
            LBLIGCUPON.AutoSize = true;
            LBLIGCUPON.Location = new Point(74, 124);
            LBLIGCUPON.Name = "LBLIGCUPON";
            LBLIGCUPON.Size = new Size(120, 20);
            LBLIGCUPON.TabIndex = 1;
            LBLIGCUPON.Text = "Ingresa el Cupon";
            // 
            // LBLIGPAGO
            // 
            LBLIGPAGO.AutoSize = true;
            LBLIGPAGO.Location = new Point(74, 212);
            LBLIGPAGO.Name = "LBLIGPAGO";
            LBLIGPAGO.Size = new Size(42, 20);
            LBLIGPAGO.TabIndex = 2;
            LBLIGPAGO.Text = "Pago";
            // 
            // LBLDESCUENTO
            // 
            LBLDESCUENTO.AutoSize = true;
            LBLDESCUENTO.Location = new Point(73, 294);
            LBLDESCUENTO.Name = "LBLDESCUENTO";
            LBLDESCUENTO.Size = new Size(141, 20);
            LBLDESCUENTO.TabIndex = 3;
            LBLDESCUENTO.Text = "Tu Descuento es de:";
            // 
            // LBLTTAPAGAR
            // 
            LBLTTAPAGAR.AutoSize = true;
            LBLTTAPAGAR.Location = new Point(74, 377);
            LBLTTAPAGAR.Name = "LBLTTAPAGAR";
            LBLTTAPAGAR.Size = new Size(132, 20);
            LBLTTAPAGAR.TabIndex = 4;
            LBLTTAPAGAR.Text = "El Total a Pagar es:";
            // 
            // TXTMONTO
            // 
            TXTMONTO.Location = new Point(81, 73);
            TXTMONTO.Name = "TXTMONTO";
            TXTMONTO.Size = new Size(125, 27);
            TXTMONTO.TabIndex = 5;
            // 
            // TXTCUPON
            // 
            TXTCUPON.Location = new Point(81, 170);
            TXTCUPON.Name = "TXTCUPON";
            TXTCUPON.Size = new Size(125, 27);
            TXTCUPON.TabIndex = 6;
            // 
            // TXTPAGO
            // 
            TXTPAGO.Location = new Point(81, 252);
            TXTPAGO.Name = "TXTPAGO";
            TXTPAGO.Size = new Size(125, 27);
            TXTPAGO.TabIndex = 7;
            // 
            // TXTDESC
            // 
            TXTDESC.Location = new Point(81, 326);
            TXTDESC.Name = "TXTDESC";
            TXTDESC.Size = new Size(125, 27);
            TXTDESC.TabIndex = 8;
            // 
            // TXTTAL
            // 
            TXTTAL.Location = new Point(81, 420);
            TXTTAL.Name = "TXTTAL";
            TXTTAL.Size = new Size(125, 27);
            TXTTAL.TabIndex = 9;
            // 
            // BTNCOMPRA
            // 
            BTNCOMPRA.Location = new Point(64, 520);
            BTNCOMPRA.Name = "BTNCOMPRA";
            BTNCOMPRA.Size = new Size(94, 29);
            BTNCOMPRA.TabIndex = 10;
            BTNCOMPRA.Text = "Comprar";
            BTNCOMPRA.UseVisualStyleBackColor = true;
            BTNCOMPRA.Click += BTNCOMPRA_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 758);
            Controls.Add(BTNCOMPRA);
            Controls.Add(TXTTAL);
            Controls.Add(TXTDESC);
            Controls.Add(TXTPAGO);
            Controls.Add(TXTCUPON);
            Controls.Add(TXTMONTO);
            Controls.Add(LBLTTAPAGAR);
            Controls.Add(LBLDESCUENTO);
            Controls.Add(LBLIGPAGO);
            Controls.Add(LBLIGCUPON);
            Controls.Add(LBLIGMONTO);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBLIGMONTO;
        private Label LBLIGCUPON;
        private Label LBLIGPAGO;
        private Label LBLDESCUENTO;
        private Label LBLTTAPAGAR;
        private TextBox TXTMONTO;
        private TextBox TXTCUPON;
        private TextBox TXTPAGO;
        private TextBox TXTDESC;
        private TextBox TXTTAL;
        private Button BTNCOMPRA;
    }
}
