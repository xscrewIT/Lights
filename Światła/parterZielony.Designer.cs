
namespace Światła
{
    partial class parterZielony
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(parterZielony));
            this.btnLampaSufit2OFF = new System.Windows.Forms.Button();
            this.btnLampaSufit2ON = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLampaSufit1OFF = new System.Windows.Forms.Button();
            this.btnLampaSufit1ON = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLampaSufit2OFF
            // 
            this.btnLampaSufit2OFF.BackColor = System.Drawing.Color.Red;
            this.btnLampaSufit2OFF.Location = new System.Drawing.Point(178, 134);
            this.btnLampaSufit2OFF.Name = "btnLampaSufit2OFF";
            this.btnLampaSufit2OFF.Size = new System.Drawing.Size(75, 50);
            this.btnLampaSufit2OFF.TabIndex = 61;
            this.btnLampaSufit2OFF.Text = "OFF";
            this.btnLampaSufit2OFF.UseVisualStyleBackColor = false;
            this.btnLampaSufit2OFF.Click += new System.EventHandler(this.btnLampaSufit2OFF_Click);
            // 
            // btnLampaSufit2ON
            // 
            this.btnLampaSufit2ON.BackColor = System.Drawing.Color.Lime;
            this.btnLampaSufit2ON.Location = new System.Drawing.Point(97, 134);
            this.btnLampaSufit2ON.Name = "btnLampaSufit2ON";
            this.btnLampaSufit2ON.Size = new System.Drawing.Size(75, 50);
            this.btnLampaSufit2ON.TabIndex = 60;
            this.btnLampaSufit2ON.Text = "ON";
            this.btnLampaSufit2ON.UseVisualStyleBackColor = false;
            this.btnLampaSufit2ON.Click += new System.EventHandler(this.btnLampaSufit2ON_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(132, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 59;
            this.label2.Text = "Lampa sufit 2";
            // 
            // btnLampaSufit1OFF
            // 
            this.btnLampaSufit1OFF.BackColor = System.Drawing.Color.Red;
            this.btnLampaSufit1OFF.Location = new System.Drawing.Point(178, 46);
            this.btnLampaSufit1OFF.Name = "btnLampaSufit1OFF";
            this.btnLampaSufit1OFF.Size = new System.Drawing.Size(75, 50);
            this.btnLampaSufit1OFF.TabIndex = 58;
            this.btnLampaSufit1OFF.Text = "OFF";
            this.btnLampaSufit1OFF.UseVisualStyleBackColor = false;
            this.btnLampaSufit1OFF.Click += new System.EventHandler(this.btnLampaSufit1OFF_Click);
            // 
            // btnLampaSufit1ON
            // 
            this.btnLampaSufit1ON.BackColor = System.Drawing.Color.Lime;
            this.btnLampaSufit1ON.Location = new System.Drawing.Point(97, 46);
            this.btnLampaSufit1ON.Name = "btnLampaSufit1ON";
            this.btnLampaSufit1ON.Size = new System.Drawing.Size(75, 50);
            this.btnLampaSufit1ON.TabIndex = 57;
            this.btnLampaSufit1ON.Text = "ON";
            this.btnLampaSufit1ON.UseVisualStyleBackColor = false;
            this.btnLampaSufit1ON.Click += new System.EventHandler(this.btnLampaSufit1ON_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(132, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "Lampa sufit 1";
            // 
            // parterZielony
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(350, 213);
            this.Controls.Add(this.btnLampaSufit2OFF);
            this.Controls.Add(this.btnLampaSufit2ON);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLampaSufit1OFF);
            this.Controls.Add(this.btnLampaSufit1ON);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "parterZielony";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parter - Zielony pokój";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLampaSufit2OFF;
        private System.Windows.Forms.Button btnLampaSufit2ON;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLampaSufit1OFF;
        private System.Windows.Forms.Button btnLampaSufit1ON;
        private System.Windows.Forms.Label label1;
    }
}