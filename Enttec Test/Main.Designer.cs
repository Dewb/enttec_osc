namespace Enttec_Test
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnOff = new System.Windows.Forms.Button();
            this.btnAllOn = new System.Windows.Forms.Button();
            this.btnOpenEnttec = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.trackBar7 = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.trackBar8 = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOff
            // 
            this.btnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOff.Location = new System.Drawing.Point(424, 62);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(75, 26);
            this.btnOff.TabIndex = 0;
            this.btnOff.Text = "All Off";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnAllOn
            // 
            this.btnAllOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllOn.Location = new System.Drawing.Point(321, 62);
            this.btnAllOn.Name = "btnAllOn";
            this.btnAllOn.Size = new System.Drawing.Size(75, 26);
            this.btnAllOn.TabIndex = 1;
            this.btnAllOn.Text = "All On";
            this.btnAllOn.UseVisualStyleBackColor = true;
            this.btnAllOn.Click += new System.EventHandler(this.btnAllOn_Click);
            // 
            // btnOpenEnttec
            // 
            this.btnOpenEnttec.BackgroundImage = global::Enttec_Test.Properties.Resources.Enttec_Open_USB2;
            this.btnOpenEnttec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenEnttec.Location = new System.Drawing.Point(12, 425);
            this.btnOpenEnttec.Name = "btnOpenEnttec";
            this.btnOpenEnttec.Size = new System.Drawing.Size(116, 102);
            this.btnOpenEnttec.TabIndex = 91;
            this.btnOpenEnttec.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(134, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 102);
            this.label3.TabIndex = 92;
            this.label3.Text = "Note: You must load the Win D2XX drivers from the Enttec.com website, then restar" +
    "t PC.";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 93;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(158, 17);
            this.toolStripStatusLabel1.Text = "No Enttec USB Device Found";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 28);
            this.label4.TabIndex = 94;
            this.label4.Text = "Listening for /dmx OSC messages on port 7000";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(321, 108);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(365, 45);
            this.trackBar1.TabIndex = 95;
            this.trackBar1.TickFrequency = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(712, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 33);
            this.label1.TabIndex = 96;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(712, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 33);
            this.label2.TabIndex = 98;
            this.label2.Text = "0";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(321, 159);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(365, 45);
            this.trackBar2.TabIndex = 97;
            this.trackBar2.TickFrequency = 8;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(712, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 33);
            this.label5.TabIndex = 100;
            this.label5.Text = "0";
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(321, 210);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(365, 45);
            this.trackBar3.TabIndex = 99;
            this.trackBar3.TickFrequency = 8;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(712, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 33);
            this.label6.TabIndex = 102;
            this.label6.Text = "0";
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(321, 261);
            this.trackBar4.Maximum = 255;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(365, 45);
            this.trackBar4.TabIndex = 101;
            this.trackBar4.TickFrequency = 8;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(712, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 33);
            this.label7.TabIndex = 104;
            this.label7.Text = "0";
            // 
            // trackBar5
            // 
            this.trackBar5.Location = new System.Drawing.Point(321, 312);
            this.trackBar5.Maximum = 255;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(365, 45);
            this.trackBar5.TabIndex = 103;
            this.trackBar5.TickFrequency = 8;
            this.trackBar5.Scroll += new System.EventHandler(this.trackBar5_Scroll);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(712, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 33);
            this.label8.TabIndex = 106;
            this.label8.Text = "0";
            // 
            // trackBar6
            // 
            this.trackBar6.Location = new System.Drawing.Point(321, 363);
            this.trackBar6.Maximum = 255;
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(365, 45);
            this.trackBar6.TabIndex = 105;
            this.trackBar6.TickFrequency = 8;
            this.trackBar6.Scroll += new System.EventHandler(this.trackBar6_Scroll);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(712, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 33);
            this.label9.TabIndex = 108;
            this.label9.Text = "0";
            // 
            // trackBar7
            // 
            this.trackBar7.Location = new System.Drawing.Point(321, 414);
            this.trackBar7.Maximum = 255;
            this.trackBar7.Name = "trackBar7";
            this.trackBar7.Size = new System.Drawing.Size(365, 45);
            this.trackBar7.TabIndex = 107;
            this.trackBar7.TickFrequency = 8;
            this.trackBar7.Scroll += new System.EventHandler(this.trackBar7_Scroll);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(712, 465);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 33);
            this.label10.TabIndex = 110;
            this.label10.Text = "0";
            // 
            // trackBar8
            // 
            this.trackBar8.Location = new System.Drawing.Point(321, 465);
            this.trackBar8.Maximum = 255;
            this.trackBar8.Name = "trackBar8";
            this.trackBar8.Size = new System.Drawing.Size(365, 45);
            this.trackBar8.TabIndex = 109;
            this.trackBar8.TickFrequency = 8;
            this.trackBar8.Scroll += new System.EventHandler(this.trackBar8_Scroll);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(318, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(297, 28);
            this.label11.TabIndex = 111;
            this.label11.Text = "Manual controls";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.trackBar8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.trackBar7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trackBar6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.trackBar5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOpenEnttec);
            this.Controls.Add(this.btnAllOn);
            this.Controls.Add(this.btnOff);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Enttec DMX - OSC Bridge";
            this.Load += new System.EventHandler(this.Main_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnAllOn;
        private System.Windows.Forms.Button btnOpenEnttec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBar6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trackBar7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar trackBar8;
        private System.Windows.Forms.Label label11;
    }
}

