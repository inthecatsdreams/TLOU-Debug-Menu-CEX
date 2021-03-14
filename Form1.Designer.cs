
namespace tlou_debug_tool
{
    partial class Form1
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
            this.connectAndAttach = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DebugM1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.debugM2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectAndAttach
            // 
            this.connectAndAttach.Location = new System.Drawing.Point(6, 19);
            this.connectAndAttach.Name = "connectAndAttach";
            this.connectAndAttach.Size = new System.Drawing.Size(188, 28);
            this.connectAndAttach.TabIndex = 0;
            this.connectAndAttach.Text = "Connect and Attach";
            this.connectAndAttach.UseVisualStyleBackColor = true;
            this.connectAndAttach.Click += new System.EventHandler(this.connectAndAttach_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.connectAndAttach);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status: waiting";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DebugM1);
            this.groupBox2.Location = new System.Drawing.Point(12, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 68);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TLOU v1.00";
            // 
            // DebugM1
            // 
            this.DebugM1.Location = new System.Drawing.Point(9, 20);
            this.DebugM1.Name = "DebugM1";
            this.DebugM1.Size = new System.Drawing.Size(185, 23);
            this.DebugM1.TabIndex = 0;
            this.DebugM1.Text = "Enable Debug Menu";
            this.DebugM1.UseVisualStyleBackColor = true;
            this.DebugM1.Click += new System.EventHandler(this.DebugM1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.debugM2);
            this.groupBox3.Location = new System.Drawing.Point(218, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 68);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TLOU v1.11";
            // 
            // debugM2
            // 
            this.debugM2.Location = new System.Drawing.Point(6, 20);
            this.debugM2.Name = "debugM2";
            this.debugM2.Size = new System.Drawing.Size(185, 23);
            this.debugM2.TabIndex = 1;
            this.debugM2.Text = "Enable Debug Menu";
            this.debugM2.UseVisualStyleBackColor = true;
            this.debugM2.Click += new System.EventHandler(this.DebugM2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 202);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TLOU Debug Menu for CEX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connectAndAttach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DebugM1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button debugM2;
    }
}

