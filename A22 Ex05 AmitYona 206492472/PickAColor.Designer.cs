
namespace A22_Ex05_G
{
    partial class PickAColor
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
            this.pirpleColor = new System.Windows.Forms.Button();
            this.blueColor = new System.Windows.Forms.Button();
            this.yellowColor = new System.Windows.Forms.Button();
            this.brownColor = new System.Windows.Forms.Button();
            this.redColor = new System.Windows.Forms.Button();
            this.whiteColor = new System.Windows.Forms.Button();
            this.greenColor = new System.Windows.Forms.Button();
            this.loghtBlueColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pirpleColor
            // 
            this.pirpleColor.BackColor = System.Drawing.Color.Fuchsia;
            this.pirpleColor.Location = new System.Drawing.Point(12, 12);
            this.pirpleColor.Name = "pirpleColor";
            this.pirpleColor.Size = new System.Drawing.Size(46, 39);
            this.pirpleColor.TabIndex = 0;
            this.pirpleColor.UseVisualStyleBackColor = false;
            this.pirpleColor.Click += new System.EventHandler(this.GenericChooseColor_Click);
            // 
            // blueColor
            // 
            this.blueColor.BackColor = System.Drawing.Color.Blue;
            this.blueColor.Location = new System.Drawing.Point(12, 59);
            this.blueColor.Name = "blueColor";
            this.blueColor.Size = new System.Drawing.Size(46, 39);
            this.blueColor.TabIndex = 1;
            this.blueColor.UseVisualStyleBackColor = false;
            this.blueColor.Click += new System.EventHandler(this.GenericChooseColor_Click);
            // 
            // yellowColor
            // 
            this.yellowColor.BackColor = System.Drawing.Color.Yellow;
            this.yellowColor.Location = new System.Drawing.Point(64, 60);
            this.yellowColor.Name = "yellowColor";
            this.yellowColor.Size = new System.Drawing.Size(46, 39);
            this.yellowColor.TabIndex = 2;
            this.yellowColor.UseVisualStyleBackColor = false;
            this.yellowColor.Click += new System.EventHandler(this.GenericChooseColor_Click);
            // 
            // brownColor
            // 
            this.brownColor.BackColor = System.Drawing.Color.Sienna;
            this.brownColor.Location = new System.Drawing.Point(116, 60);
            this.brownColor.Name = "brownColor";
            this.brownColor.Size = new System.Drawing.Size(46, 39);
            this.brownColor.TabIndex = 3;
            this.brownColor.UseVisualStyleBackColor = false;
            this.brownColor.Click += new System.EventHandler(this.GenericChooseColor_Click);
            // 
            // redColor
            // 
            this.redColor.BackColor = System.Drawing.Color.Red;
            this.redColor.Location = new System.Drawing.Point(64, 15);
            this.redColor.Name = "redColor";
            this.redColor.Size = new System.Drawing.Size(46, 39);
            this.redColor.TabIndex = 4;
            this.redColor.UseVisualStyleBackColor = false;
            this.redColor.Click += new System.EventHandler(this.GenericChooseColor_Click);
            // 
            // whiteColor
            // 
            this.whiteColor.BackColor = System.Drawing.Color.White;
            this.whiteColor.Location = new System.Drawing.Point(168, 60);
            this.whiteColor.Name = "whiteColor";
            this.whiteColor.Size = new System.Drawing.Size(46, 39);
            this.whiteColor.TabIndex = 5;
            this.whiteColor.UseVisualStyleBackColor = false;
            this.whiteColor.Click += new System.EventHandler(this.GenericChooseColor_Click);
            // 
            // greenColor
            // 
            this.greenColor.BackColor = System.Drawing.Color.Lime;
            this.greenColor.Location = new System.Drawing.Point(116, 15);
            this.greenColor.Name = "greenColor";
            this.greenColor.Size = new System.Drawing.Size(46, 39);
            this.greenColor.TabIndex = 6;
            this.greenColor.UseVisualStyleBackColor = false;
            this.greenColor.Click += new System.EventHandler(this.GenericChooseColor_Click);
            // 
            // loghtBlueColor
            // 
            this.loghtBlueColor.BackColor = System.Drawing.Color.Aqua;
            this.loghtBlueColor.Location = new System.Drawing.Point(168, 15);
            this.loghtBlueColor.Name = "loghtBlueColor";
            this.loghtBlueColor.Size = new System.Drawing.Size(46, 39);
            this.loghtBlueColor.TabIndex = 7;
            this.loghtBlueColor.UseVisualStyleBackColor = false;
            this.loghtBlueColor.Click += new System.EventHandler(this.GenericChooseColor_Click);
            // 
            // PickAColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 110);
            this.Controls.Add(this.loghtBlueColor);
            this.Controls.Add(this.greenColor);
            this.Controls.Add(this.whiteColor);
            this.Controls.Add(this.redColor);
            this.Controls.Add(this.brownColor);
            this.Controls.Add(this.yellowColor);
            this.Controls.Add(this.blueColor);
            this.Controls.Add(this.pirpleColor);
            this.Name = "PickAColor";
            this.Text = "Pick A Color";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pirpleColor;
        private System.Windows.Forms.Button blueColor;
        private System.Windows.Forms.Button yellowColor;
        private System.Windows.Forms.Button brownColor;
        private System.Windows.Forms.Button redColor;
        private System.Windows.Forms.Button whiteColor;
        private System.Windows.Forms.Button greenColor;
        private System.Windows.Forms.Button loghtBlueColor;
    }
}