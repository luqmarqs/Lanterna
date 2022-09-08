namespace Lanterna
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
            this.components = new System.ComponentModel.Container();
            this.btn_on_off = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_bateria = new System.Windows.Forms.Label();
            this.btn_bateria = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_on_off
            // 
            this.btn_on_off.Location = new System.Drawing.Point(49, 97);
            this.btn_on_off.Margin = new System.Windows.Forms.Padding(4);
            this.btn_on_off.Name = "btn_on_off";
            this.btn_on_off.Size = new System.Drawing.Size(107, 32);
            this.btn_on_off.TabIndex = 0;
            this.btn_on_off.Text = "Ligar";
            this.btn_on_off.UseVisualStyleBackColor = true;
            this.btn_on_off.Click += new System.EventHandler(this.btn_on_off_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(409, 108);
            this.lbl_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(87, 21);
            this.lbl_status.TabIndex = 1;
            this.lbl_status.Text = "Desligado";
            // 
            // lbl_bateria
            // 
            this.lbl_bateria.AutoSize = true;
            this.lbl_bateria.Location = new System.Drawing.Point(409, 216);
            this.lbl_bateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bateria.Name = "lbl_bateria";
            this.lbl_bateria.Size = new System.Drawing.Size(51, 21);
            this.lbl_bateria.TabIndex = 2;
            this.lbl_bateria.Text = "100%";
            // 
            // btn_bateria
            // 
            this.btn_bateria.Location = new System.Drawing.Point(49, 210);
            this.btn_bateria.Margin = new System.Windows.Forms.Padding(4);
            this.btn_bateria.Name = "btn_bateria";
            this.btn_bateria.Size = new System.Drawing.Size(107, 32);
            this.btn_bateria.TabIndex = 3;
            this.btn_bateria.Text = "Bateria";
            this.btn_bateria.UseVisualStyleBackColor = true;
            this.btn_bateria.Click += new System.EventHandler(this.btn_bateria_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 346);
            this.Controls.Add(this.btn_bateria);
            this.Controls.Add(this.lbl_bateria);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_on_off);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Lanterna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_on_off;
        private Label lbl_status;
        private Label lbl_bateria;
        private Button btn_bateria;
        private System.Windows.Forms.Timer timer1;
    }
}