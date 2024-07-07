
namespace Światła
{
    partial class parterKuchnia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(parterKuchnia));
            this.btnPaskiLED_OFF = new System.Windows.Forms.Button();
            this.btnPaskiLED_ON = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLampaSufitOFF = new System.Windows.Forms.Button();
            this.btnLampaSufitON = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPaskiLED_OFF
            // 
            this.btnPaskiLED_OFF.BackColor = System.Drawing.Color.Red;
            this.btnPaskiLED_OFF.Location = new System.Drawing.Point(178, 134);
            this.btnPaskiLED_OFF.Name = "btnPaskiLED_OFF";
            this.btnPaskiLED_OFF.Size = new System.Drawing.Size(75, 50);
            this.btnPaskiLED_OFF.TabIndex = 43;
            this.btnPaskiLED_OFF.Text = "OFF";
            this.btnPaskiLED_OFF.UseVisualStyleBackColor = false;
            this.btnPaskiLED_OFF.Click += new System.EventHandler(this.btnPaskiLED_OFF_Click);
            // 
            // btnPaskiLED_ON
            // 
            this.btnPaskiLED_ON.BackColor = System.Drawing.Color.Lime;
            this.btnPaskiLED_ON.Location = new System.Drawing.Point(97, 134);
            this.btnPaskiLED_ON.Name = "btnPaskiLED_ON";
            this.btnPaskiLED_ON.Size = new System.Drawing.Size(75, 50);
            this.btnPaskiLED_ON.TabIndex = 42;
            this.btnPaskiLED_ON.Text = "ON";
            this.btnPaskiLED_ON.UseVisualStyleBackColor = false;
            this.btnPaskiLED_ON.Click += new System.EventHandler(this.btnPaskiLED_ON_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(140, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Paski LED";
            // 
            // btnLampaSufitOFF
            // 
            this.btnLampaSufitOFF.BackColor = System.Drawing.Color.Red;
            this.btnLampaSufitOFF.Location = new System.Drawing.Point(178, 46);
            this.btnLampaSufitOFF.Name = "btnLampaSufitOFF";
            this.btnLampaSufitOFF.Size = new System.Drawing.Size(75, 50);
            this.btnLampaSufitOFF.TabIndex = 40;
            this.btnLampaSufitOFF.Text = "OFF";
            this.btnLampaSufitOFF.UseVisualStyleBackColor = false;
            this.btnLampaSufitOFF.Click += new System.EventHandler(this.btnLampaSufitOFF_Click);
            // 
            // btnLampaSufitON
            // 
            this.btnLampaSufitON.BackColor = System.Drawing.Color.Lime;
            this.btnLampaSufitON.Location = new System.Drawing.Point(97, 46);
            this.btnLampaSufitON.Name = "btnLampaSufitON";
            this.btnLampaSufitON.Size = new System.Drawing.Size(75, 50);
            this.btnLampaSufitON.TabIndex = 39;
            this.btnLampaSufitON.Text = "ON";
            this.btnLampaSufitON.UseVisualStyleBackColor = false;
            this.btnLampaSufitON.Click += new System.EventHandler(this.btnLampaSufitON_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(137, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Lampa sufit";
            // 
            // parterKuchnia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(350, 213);
            this.Controls.Add(this.btnPaskiLED_OFF);
            this.Controls.Add(this.btnPaskiLED_ON);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLampaSufitOFF);
            this.Controls.Add(this.btnLampaSufitON);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "parterKuchnia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parter - Kuchnia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPaskiLED_OFF;
        private System.Windows.Forms.Button btnPaskiLED_ON;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLampaSufitOFF;
        private System.Windows.Forms.Button btnLampaSufitON;
        private System.Windows.Forms.Label label1;
    }
}