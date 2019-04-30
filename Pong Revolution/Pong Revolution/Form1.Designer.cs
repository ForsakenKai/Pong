namespace Pong_Revolution
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.j2 = new System.Windows.Forms.Label();
            this.j1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ball = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // j2
            // 
            this.j2.AutoSize = true;
            this.j2.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.j2.ForeColor = System.Drawing.Color.Red;
            this.j2.Location = new System.Drawing.Point(714, 105);
            this.j2.Name = "j2";
            this.j2.Size = new System.Drawing.Size(74, 142);
            this.j2.TabIndex = 0;
            this.j2.Text = "|";
            this.j2.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // j1
            // 
            this.j1.AutoSize = true;
            this.j1.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.j1.ForeColor = System.Drawing.Color.Blue;
            this.j1.Location = new System.Drawing.Point(33, 105);
            this.j1.Name = "j1";
            this.j1.Size = new System.Drawing.Size(74, 142);
            this.j1.TabIndex = 1;
            this.j1.Text = "|";
            this.j1.Click += new System.EventHandler(this.j1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ball
            // 
            this.ball.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ball.BackgroundImage")));
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ball.Location = new System.Drawing.Point(375, 160);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(64, 56);
            this.ball.TabIndex = 2;
            this.ball.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.j1);
            this.Controls.Add(this.j2);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label j2;
        private System.Windows.Forms.Label j1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel ball;
    }
}

