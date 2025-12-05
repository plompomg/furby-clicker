namespace clicker
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
            clicker_text = new TextBox();
            clicker = new Button();
            shop = new Button();
            SuspendLayout();
            // 
            // clicker_text
            // 
            clicker_text.Location = new Point(12, 12);
            clicker_text.Name = "clicker_text";
            clicker_text.Size = new Size(100, 23);
            clicker_text.TabIndex = 0;
            clicker_text.TextChanged += textBox1_TextChanged;
            // 
            // clicker
            // 
            clicker.Image = Properties.Resources.starter__1_;
            clicker.Location = new Point(331, 324);
            clicker.Name = "clicker";
            clicker.Size = new Size(103, 105);
            clicker.TabIndex = 1;
            clicker.UseVisualStyleBackColor = true;
            clicker.Click += clicker_Click_1;
            // 
            // shop
            // 
            shop.Location = new Point(12, 415);
            shop.Name = "shop";
            shop.Size = new Size(75, 23);
            shop.TabIndex = 2;
            shop.Text = "shop";
            shop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(shop);
            Controls.Add(clicker);
            Controls.Add(clicker_text);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox clicker_text;
        private Button clicker;
        private Button shop;
    }
}
