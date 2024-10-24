namespace HaromszogekKoordinataRendszerben
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelDraw = new System.Windows.Forms.Panel();
            this.txtAx = new System.Windows.Forms.TextBox();
            this.txtAy = new System.Windows.Forms.TextBox();
            this.txtBx = new System.Windows.Forms.TextBox();
            this.txtBy = new System.Windows.Forms.TextBox();
            this.txtCx = new System.Windows.Forms.TextBox();
            this.txtCy = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panelDraw
            // 
            this.panelDraw.Location = new System.Drawing.Point(216, 49);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(585, 527);
            this.panelDraw.TabIndex = 0;
            // 
            // txtAx
            // 
            this.txtAx.Location = new System.Drawing.Point(52, 49);
            this.txtAx.Name = "txtAx";
            this.txtAx.Size = new System.Drawing.Size(69, 23);
            this.txtAx.TabIndex = 1;
            // 
            // txtAy
            // 
            this.txtAy.Location = new System.Drawing.Point(127, 49);
            this.txtAy.Name = "txtAy";
            this.txtAy.Size = new System.Drawing.Size(69, 23);
            this.txtAy.TabIndex = 2;
            // 
            // txtBx
            // 
            this.txtBx.Location = new System.Drawing.Point(52, 93);
            this.txtBx.Name = "txtBx";
            this.txtBx.Size = new System.Drawing.Size(69, 23);
            this.txtBx.TabIndex = 3;
            // 
            // txtBy
            // 
            this.txtBy.Location = new System.Drawing.Point(127, 93);
            this.txtBy.Name = "txtBy";
            this.txtBy.Size = new System.Drawing.Size(69, 23);
            this.txtBy.TabIndex = 4;
            // 
            // txtCx
            // 
            this.txtCx.Location = new System.Drawing.Point(52, 142);
            this.txtCx.Name = "txtCx";
            this.txtCx.Size = new System.Drawing.Size(69, 23);
            this.txtCx.TabIndex = 5;
            // 
            // txtCy
            // 
            this.txtCy.Location = new System.Drawing.Point(127, 142);
            this.txtCy.Name = "txtCy";
            this.txtCy.Size = new System.Drawing.Size(69, 23);
            this.txtCy.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Frissít";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(13, 23);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "A";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(33, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(13, 23);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "B";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(33, 142);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(13, 23);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 635);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCy);
            this.Controls.Add(this.txtCx);
            this.Controls.Add(this.txtBy);
            this.Controls.Add(this.txtBx);
            this.Controls.Add(this.txtAy);
            this.Controls.Add(this.txtAx);
            this.Controls.Add(this.panelDraw);
            this.Name = "Form1";
            this.Text = "Háromszög Koordináta Rendszerben";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelDraw;
        private TextBox txtAx;
        private TextBox txtAy;
        private TextBox txtBx;
        private TextBox txtBy;
        private TextBox txtCx;
        private TextBox txtCy;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
