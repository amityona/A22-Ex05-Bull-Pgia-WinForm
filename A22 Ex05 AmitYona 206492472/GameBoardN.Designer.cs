
namespace A22_Ex05_G
{
    partial class GameBoardN
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
            this.btnBlack1 = new System.Windows.Forms.Button();
            this.btnBlack2 = new System.Windows.Forms.Button();
            this.btnBlack4 = new System.Windows.Forms.Button();
            this.btnBlack3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBlack1
            // 
            this.btnBlack1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBlack1.Enabled = false;
            this.btnBlack1.Location = new System.Drawing.Point(33, 28);
            this.btnBlack1.Name = "btnBlack1";
            this.btnBlack1.Size = new System.Drawing.Size(59, 54);
            this.btnBlack1.TabIndex = 0;
            this.btnBlack1.UseVisualStyleBackColor = false;
            // 
            // btnBlack2
            // 
            this.btnBlack2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBlack2.Enabled = false;
            this.btnBlack2.Location = new System.Drawing.Point(112, 28);
            this.btnBlack2.Name = "btnBlack2";
            this.btnBlack2.Size = new System.Drawing.Size(59, 54);
            this.btnBlack2.TabIndex = 1;
            this.btnBlack2.UseVisualStyleBackColor = false;
            // 
            // btnBlack4
            // 
            this.btnBlack4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBlack4.Enabled = false;
            this.btnBlack4.Location = new System.Drawing.Point(274, 28);
            this.btnBlack4.Name = "btnBlack4";
            this.btnBlack4.Size = new System.Drawing.Size(59, 54);
            this.btnBlack4.TabIndex = 2;
            this.btnBlack4.UseVisualStyleBackColor = false;
            // 
            // btnBlack3
            // 
            this.btnBlack3.AutoSize = true;
            this.btnBlack3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBlack3.Enabled = false;
            this.btnBlack3.Location = new System.Drawing.Point(192, 28);
            this.btnBlack3.Name = "btnBlack3";
            this.btnBlack3.Size = new System.Drawing.Size(59, 54);
            this.btnBlack3.TabIndex = 3;
            this.btnBlack3.UseVisualStyleBackColor = false;
            // 
            // GameBoardN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 564);
            this.Controls.Add(this.btnBlack3);
            this.Controls.Add(this.btnBlack4);
            this.Controls.Add(this.btnBlack2);
            this.Controls.Add(this.btnBlack1);
            this.Name = "GameBoardN";
            this.Text = "GameBoardN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBlack1;
        private System.Windows.Forms.Button btnBlack2;
        private System.Windows.Forms.Button btnBlack4;
        private System.Windows.Forms.Button btnBlack3;
    }
}