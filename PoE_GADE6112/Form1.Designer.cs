﻿
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
            this.Right = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.Up = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.Attack = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.enemyDropdown = new System.Windows.Forms.ComboBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.Save = new System.Windows.Forms.Button();
            this.lblHeroStat = new System.Windows.Forms.Label();
            this.Load = new System.Windows.Forms.Button();
            this.shopItemOne = new System.Windows.Forms.Button();
            this.shopItemTwo = new System.Windows.Forms.Button();
            this.shopItemThree = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(11, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(541, 527);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Right
            // 
            this.Right.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Right.Location = new System.Drawing.Point(959, 461);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(46, 37);
            this.Right.TabIndex = 1;
            this.Right.Text = ">";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Up_Click);
            // 
            // Left
            // 
            this.Left.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Left.Location = new System.Drawing.Point(798, 461);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(46, 37);
            this.Left.TabIndex = 2;
            this.Left.Text = "<";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.Down_Click);
            // 
            // Up
            // 
            this.Up.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Up.Location = new System.Drawing.Point(881, 407);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(46, 37);
            this.Up.TabIndex = 3;
            this.Up.Text = "^";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.Left_Click);
            // 
            // Down
            // 
            this.Down.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Down.Location = new System.Drawing.Point(881, 512);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(46, 37);
            this.Down.TabIndex = 4;
            this.Down.Text = "v";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.Right_Click);
            // 
            // Attack
            // 
            this.Attack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Attack.Location = new System.Drawing.Point(99, 204);
            this.Attack.Name = "Attack";
            this.Attack.Size = new System.Drawing.Size(137, 31);
            this.Attack.TabIndex = 5;
            this.Attack.Text = "Attack";
            this.Attack.UseVisualStyleBackColor = true;
            this.Attack.Click += new System.EventHandler(this.Attack_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox2.Location = new System.Drawing.Point(13, 241);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(305, 123);
            this.richTextBox2.TabIndex = 10;
            this.richTextBox2.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.enemyDropdown);
            this.panel2.Controls.Add(this.richTextBox3);
            this.panel2.Controls.Add(this.richTextBox2);
            this.panel2.Controls.Add(this.Attack);
            this.panel2.Location = new System.Drawing.Point(737, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 379);
            this.panel2.TabIndex = 11;
            // 
            // enemyDropdown
            // 
            this.enemyDropdown.FormattingEnabled = true;
            this.enemyDropdown.Location = new System.Drawing.Point(15, 12);
            this.enemyDropdown.Name = "enemyDropdown";
            this.enemyDropdown.Size = new System.Drawing.Size(303, 28);
            this.enemyDropdown.TabIndex = 23;
            this.enemyDropdown.SelectedIndexChanged += new System.EventHandler(this.enemyDropdown_SelectedIndexChanged);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox3.Location = new System.Drawing.Point(15, 67);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(303, 129);
            this.richTextBox3.TabIndex = 12;
            this.richTextBox3.Text = "";
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Save.Location = new System.Drawing.Point(208, 569);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(137, 31);
            this.Save.TabIndex = 16;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // lblHeroStat
            // 
            this.lblHeroStat.AutoSize = true;
            this.lblHeroStat.Location = new System.Drawing.Point(587, 22);
            this.lblHeroStat.Name = "lblHeroStat";
            this.lblHeroStat.Size = new System.Drawing.Size(76, 20);
            this.lblHeroStat.TabIndex = 18;
            this.lblHeroStat.Text = "Hero stats";
            // 
            // Load
            // 
            this.Load.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Load.Location = new System.Drawing.Point(208, 606);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(137, 31);
            this.Load.TabIndex = 19;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // shopItemOne
            // 
            this.shopItemOne.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shopItemOne.Location = new System.Drawing.Point(573, 246);
            this.shopItemOne.Name = "shopItemOne";
            this.shopItemOne.Size = new System.Drawing.Size(144, 31);
            this.shopItemOne.TabIndex = 20;
            this.shopItemOne.UseVisualStyleBackColor = true;
            this.shopItemOne.Click += new System.EventHandler(this.shopItemOne_Click);
            // 
            // shopItemTwo
            // 
            this.shopItemTwo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shopItemTwo.Location = new System.Drawing.Point(573, 359);
            this.shopItemTwo.Name = "shopItemTwo";
            this.shopItemTwo.Size = new System.Drawing.Size(144, 31);
            this.shopItemTwo.TabIndex = 21;
            this.shopItemTwo.UseVisualStyleBackColor = true;
            this.shopItemTwo.Click += new System.EventHandler(this.shopItemTwo_Click);
            // 
            // shopItemThree
            // 
            this.shopItemThree.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shopItemThree.Location = new System.Drawing.Point(573, 467);
            this.shopItemThree.Name = "shopItemThree";
            this.shopItemThree.Size = new System.Drawing.Size(144, 31);
            this.shopItemThree.TabIndex = 22;
            this.shopItemThree.UseVisualStyleBackColor = true;
            this.shopItemThree.Click += new System.EventHandler(this.shopItemThree_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 724);
            this.Controls.Add(this.shopItemThree);
            this.Controls.Add(this.shopItemTwo);
            this.Controls.Add(this.shopItemOne);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.lblHeroStat);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Left;
        private new System.Windows.Forms.Button Up;
        private new System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button Attack;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label lblHeroStat;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button shopItemOne;
        private System.Windows.Forms.Button shopItemTwo;
        private System.Windows.Forms.Button shopItemThree;
        private System.Windows.Forms.ComboBox enemyDropdown;
    }
}

