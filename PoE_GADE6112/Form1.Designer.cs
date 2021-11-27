
namespace PoE_GADE6112
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
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.Up = new System.Windows.Forms.Button();
      this.Down = new System.Windows.Forms.Button();
      this.Left = new System.Windows.Forms.Button();
      this.Right = new System.Windows.Forms.Button();
      this.Attack = new System.Windows.Forms.Button();
      this.richTextBox2 = new System.Windows.Forms.RichTextBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.richTextBox3 = new System.Windows.Forms.RichTextBox();
      this.Save = new System.Windows.Forms.Button();
      this.lblHeroStat = new System.Windows.Forms.Label();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // richTextBox1
      // 
      this.richTextBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.richTextBox1.Location = new System.Drawing.Point(10, 9);
      this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(474, 396);
      this.richTextBox1.TabIndex = 0;
      this.richTextBox1.Text = "";
      // 
      // Up
      // 
      this.Up.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.Up.Location = new System.Drawing.Point(770, 307);
      this.Up.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Up.Name = "Up";
      this.Up.Size = new System.Drawing.Size(40, 28);
      this.Up.TabIndex = 1;
      this.Up.Text = "^";
      this.Up.UseVisualStyleBackColor = true;
      this.Up.Click += new System.EventHandler(this.Up_Click);
      // 
      // Down
      // 
      this.Down.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.Down.Location = new System.Drawing.Point(770, 387);
      this.Down.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Down.Name = "Down";
      this.Down.Size = new System.Drawing.Size(40, 28);
      this.Down.TabIndex = 2;
      this.Down.Text = "v";
      this.Down.UseVisualStyleBackColor = true;
      this.Down.Click += new System.EventHandler(this.Down_Click);
      // 
      // Left
      // 
      this.Left.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.Left.Location = new System.Drawing.Point(690, 346);
      this.Left.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Left.Name = "Left";
      this.Left.Size = new System.Drawing.Size(40, 28);
      this.Left.TabIndex = 3;
      this.Left.Text = "<";
      this.Left.UseVisualStyleBackColor = true;
      this.Left.Click += new System.EventHandler(this.Left_Click);
      // 
      // Right
      // 
      this.Right.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.Right.Location = new System.Drawing.Point(843, 346);
      this.Right.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Right.Name = "Right";
      this.Right.Size = new System.Drawing.Size(40, 28);
      this.Right.TabIndex = 4;
      this.Right.Text = ">";
      this.Right.UseVisualStyleBackColor = true;
      this.Right.Click += new System.EventHandler(this.Right_Click);
      // 
      // Attack
      // 
      this.Attack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.Attack.Location = new System.Drawing.Point(87, 153);
      this.Attack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Attack.Name = "Attack";
      this.Attack.Size = new System.Drawing.Size(120, 23);
      this.Attack.TabIndex = 5;
      this.Attack.Text = "Attack";
      this.Attack.UseVisualStyleBackColor = true;
      this.Attack.Click += new System.EventHandler(this.Attack_Click);
      // 
      // richTextBox2
      // 
      this.richTextBox2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.richTextBox2.Location = new System.Drawing.Point(11, 181);
      this.richTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.richTextBox2.Name = "richTextBox2";
      this.richTextBox2.Size = new System.Drawing.Size(267, 93);
      this.richTextBox2.TabIndex = 10;
      this.richTextBox2.Text = "";
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.richTextBox3);
      this.panel2.Controls.Add(this.richTextBox2);
      this.panel2.Controls.Add(this.Attack);
      this.panel2.Location = new System.Drawing.Point(645, 8);
      this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(290, 284);
      this.panel2.TabIndex = 11;
      // 
      // richTextBox3
      // 
      this.richTextBox3.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.richTextBox3.Location = new System.Drawing.Point(13, 8);
      this.richTextBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.richTextBox3.Name = "richTextBox3";
      this.richTextBox3.Size = new System.Drawing.Size(266, 140);
      this.richTextBox3.TabIndex = 12;
      this.richTextBox3.Text = "";
      // 
      // Save
      // 
      this.Save.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.Save.Location = new System.Drawing.Point(182, 427);
      this.Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Save.Name = "Save";
      this.Save.Size = new System.Drawing.Size(120, 23);
      this.Save.TabIndex = 16;
      this.Save.Text = "Save";
      this.Save.UseVisualStyleBackColor = true;
      this.Save.Click += new System.EventHandler(this.Save_Click);
      // 
      // lblHeroStat
      // 
      this.lblHeroStat.AutoSize = true;
      this.lblHeroStat.Location = new System.Drawing.Point(550, 322);
      this.lblHeroStat.Name = "lblHeroStat";
      this.lblHeroStat.Size = new System.Drawing.Size(60, 15);
      this.lblHeroStat.TabIndex = 18;
      this.lblHeroStat.Text = "Hero stats";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(952, 543);
      this.Controls.Add(this.lblHeroStat);
      this.Controls.Add(this.Save);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.Right);
      this.Controls.Add(this.Left);
      this.Controls.Add(this.Down);
      this.Controls.Add(this.Up);
      this.Controls.Add(this.richTextBox1);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "Form1";
      this.Text = "Form1";
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Down;
        private new System.Windows.Forms.Button Left;
        private new System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Attack;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label lblHeroStat;
    }
}

