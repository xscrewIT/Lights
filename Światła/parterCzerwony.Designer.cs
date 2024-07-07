
namespace Światła
{
    partial class parterCzerwony
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(parterCzerwony));
            this.btnLampaSufit3OFF = new System.Windows.Forms.Button();
            this.btnLampaSufit3ON = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLampaSufit2OFF = new System.Windows.Forms.Button();
            this.btnLampaSufit2ON = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLampaSufit3OFF
            // 
            this.btnLampaSufit3OFF.BackColor = System.Drawing.Color.Red;
            this.btnLampaSufit3OFF.Location = new System.Drawing.Point(178, 134);
            this.btnLampaSufit3OFF.Name = "btnLampaSufit3OFF";
            this.btnLampaSufit3OFF.Size = new System.Drawing.Size(75, 50);
            this.btnLampaSufit3OFF.TabIndex = 55;
            this.btnLampaSufit3OFF.Text = "OFF";
            this.btnLampaSufit3OFF.UseVisualStyleBackColor = false;
            this.btnLampaSufit3OFF.Click += new System.EventHandler(this.btnLampaSufit3OFF_Click);
            // 
            // btnLampaSufit3ON
            // 
            this.btnLampaSufit3ON.BackColor = System.Drawing.Color.Lime;
            this.btnLampaSufit3ON.Location = new System.Drawing.Point(97, 134);
            this.btnLampaSufit3ON.Name = "btnLampaSufit3ON";
            this.btnLampaSufit3ON.Size = new System.Drawing.Size(75, 50);
            this.btnLampaSufit3ON.TabIndex = 54;
            this.btnLampaSufit3ON.Text = "ON";
            this.btnLampaSufit3ON.UseVisualStyleBackColor = false;
            this.btnLampaSufit3ON.Click += new System.EventHandler(this.btnLampaSufit3ON_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(132, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 53;
            this.label2.Text = "Lampa sufit 3";
            // 
            // btnLampaSufit2OFF
            // 
            this.btnLampaSufit2OFF.BackColor = System.Drawing.Color.Red;
            this.btnLampaSufit2OFF.Location = new System.Drawing.Point(178, 46);
            this.btnLampaSufit2OFF.Name = "btnLampaSufit2OFF";
            this.btnLampaSufit2OFF.Size = new System.Drawing.Size(75, 50);
            this.btnLampaSufit2OFF.TabIndex = 52;
            this.btnLampaSufit2OFF.Text = "OFF";
            this.btnLampaSufit2OFF.UseVisualStyleBackColor = false;
            this.btnLampaSufit2OFF.Click += new System.EventHandler(this.btnLampaSufit2OFF_Click);
            // 
            // btnLampaSufit2ON
            // 
            this.btnLampaSufit2ON.BackColor = System.Drawing.Color.Lime;
            this.btnLampaSufit2ON.Location = new System.Drawing.Point(97, 46);
            this.btnLampaSufit2ON.Name = "btnLampaSufit2ON";
            this.btnLampaSufit2ON.Size = new System.Drawing.Size(75, 50);
            this.btnLampaSufit2ON.TabIndex = 51;
            this.btnLampaSufit2ON.Text = "ON";
            this.btnLampaSufit2ON.UseVisualStyleBackColor = false;
            this.btnLampaSufit2ON.Click += new System.EventHandler(this.btnLampaSufit2ON_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(132, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Lampa sufit 2";
            // 
            // parterCzerwony
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(350, 213);
            this.Controls.Add(this.btnLampaSufit3OFF);
            this.Controls.Add(this.btnLampaSufit3ON);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLampaSufit2OFF);
            this.Controls.Add(this.btnLampaSufit2ON);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "parterCzerwony";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parter - Czerwony pokój";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLampaSufit3OFF;
        private System.Windows.Forms.Button btnLampaSufit3ON;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLampaSufit2OFF;
        private System.Windows.Forms.Button btnLampaSufit2ON;
        private System.Windows.Forms.Label label1;
    }
}