
namespace Światła
{
    partial class parterWC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(parterWC));
            this.btnUbikacjaOFF = new System.Windows.Forms.Button();
            this.btnUbikacjaON = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnŁazienkaLustroOFF = new System.Windows.Forms.Button();
            this.btnŁazienkaLustroON = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUbikacjaOFF
            // 
            this.btnUbikacjaOFF.BackColor = System.Drawing.Color.Red;
            this.btnUbikacjaOFF.Location = new System.Drawing.Point(178, 134);
            this.btnUbikacjaOFF.Name = "btnUbikacjaOFF";
            this.btnUbikacjaOFF.Size = new System.Drawing.Size(75, 50);
            this.btnUbikacjaOFF.TabIndex = 49;
            this.btnUbikacjaOFF.Text = "OFF";
            this.btnUbikacjaOFF.UseVisualStyleBackColor = false;
            this.btnUbikacjaOFF.Click += new System.EventHandler(this.btnUbikacjaOFF_Click);
            // 
            // btnUbikacjaON
            // 
            this.btnUbikacjaON.BackColor = System.Drawing.Color.Lime;
            this.btnUbikacjaON.Location = new System.Drawing.Point(97, 134);
            this.btnUbikacjaON.Name = "btnUbikacjaON";
            this.btnUbikacjaON.Size = new System.Drawing.Size(75, 50);
            this.btnUbikacjaON.TabIndex = 48;
            this.btnUbikacjaON.Text = "ON";
            this.btnUbikacjaON.UseVisualStyleBackColor = false;
            this.btnUbikacjaON.Click += new System.EventHandler(this.btnUbikacjaON_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(144, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Ubikacja";
            // 
            // btnŁazienkaLustroOFF
            // 
            this.btnŁazienkaLustroOFF.BackColor = System.Drawing.Color.Red;
            this.btnŁazienkaLustroOFF.Location = new System.Drawing.Point(178, 46);
            this.btnŁazienkaLustroOFF.Name = "btnŁazienkaLustroOFF";
            this.btnŁazienkaLustroOFF.Size = new System.Drawing.Size(75, 50);
            this.btnŁazienkaLustroOFF.TabIndex = 46;
            this.btnŁazienkaLustroOFF.Text = "OFF";
            this.btnŁazienkaLustroOFF.UseVisualStyleBackColor = false;
            this.btnŁazienkaLustroOFF.Click += new System.EventHandler(this.btnŁazienkaLustroOFF_Click);
            // 
            // btnŁazienkaLustroON
            // 
            this.btnŁazienkaLustroON.BackColor = System.Drawing.Color.Lime;
            this.btnŁazienkaLustroON.Location = new System.Drawing.Point(97, 46);
            this.btnŁazienkaLustroON.Name = "btnŁazienkaLustroON";
            this.btnŁazienkaLustroON.Size = new System.Drawing.Size(75, 50);
            this.btnŁazienkaLustroON.TabIndex = 45;
            this.btnŁazienkaLustroON.Text = "ON";
            this.btnŁazienkaLustroON.UseVisualStyleBackColor = false;
            this.btnŁazienkaLustroON.Click += new System.EventHandler(this.btnŁazienkaLustroON_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(126, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Łazienka lustro";
            // 
            // parterWC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(350, 213);
            this.Controls.Add(this.btnUbikacjaOFF);
            this.Controls.Add(this.btnUbikacjaON);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnŁazienkaLustroOFF);
            this.Controls.Add(this.btnŁazienkaLustroON);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "parterWC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parter - WC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUbikacjaOFF;
        private System.Windows.Forms.Button btnUbikacjaON;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnŁazienkaLustroOFF;
        private System.Windows.Forms.Button btnŁazienkaLustroON;
        private System.Windows.Forms.Label label1;
    }
}