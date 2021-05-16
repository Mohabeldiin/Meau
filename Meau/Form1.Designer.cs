
namespace Meau
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
            this.Section_label = new System.Windows.Forms.Label();
            this.Food_Name_Label = new System.Windows.Forms.Label();
            this.description_label = new System.Windows.Forms.Label();
            this.Price_Label = new System.Windows.Forms.Label();
            this.Section_txt = new System.Windows.Forms.TextBox();
            this.Price_txt = new System.Windows.Forms.TextBox();
            this.description_txt = new System.Windows.Forms.TextBox();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.Save_btn = new System.Windows.Forms.Button();
            this.restore_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Section_label
            // 
            this.Section_label.AutoSize = true;
            this.Section_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Section_label.Location = new System.Drawing.Point(37, 38);
            this.Section_label.Name = "Section_label";
            this.Section_label.Size = new System.Drawing.Size(85, 25);
            this.Section_label.TabIndex = 0;
            this.Section_label.Text = "Section";
            this.Section_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Food_Name_Label
            // 
            this.Food_Name_Label.AutoSize = true;
            this.Food_Name_Label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Food_Name_Label.Location = new System.Drawing.Point(37, 99);
            this.Food_Name_Label.Name = "Food_Name_Label";
            this.Food_Name_Label.Size = new System.Drawing.Size(71, 25);
            this.Food_Name_Label.TabIndex = 1;
            this.Food_Name_Label.Text = "Name";
            this.Food_Name_Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.description_label.Location = new System.Drawing.Point(37, 159);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(126, 25);
            this.description_label.TabIndex = 2;
            this.description_label.Text = "Description";
            this.description_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // Price_Label
            // 
            this.Price_Label.AutoSize = true;
            this.Price_Label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Price_Label.Location = new System.Drawing.Point(37, 216);
            this.Price_Label.Name = "Price_Label";
            this.Price_Label.Size = new System.Drawing.Size(64, 25);
            this.Price_Label.TabIndex = 3;
            this.Price_Label.Text = "Price";
            this.Price_Label.Click += new System.EventHandler(this.label4_Click);
            // 
            // Section_txt
            // 
            this.Section_txt.Location = new System.Drawing.Point(209, 38);
            this.Section_txt.Multiline = true;
            this.Section_txt.Name = "Section_txt";
            this.Section_txt.Size = new System.Drawing.Size(248, 34);
            this.Section_txt.TabIndex = 4;
            // 
            // Price_txt
            // 
            this.Price_txt.Location = new System.Drawing.Point(209, 214);
            this.Price_txt.Multiline = true;
            this.Price_txt.Name = "Price_txt";
            this.Price_txt.Size = new System.Drawing.Size(248, 27);
            this.Price_txt.TabIndex = 5;
            this.Price_txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // description_txt
            // 
            this.description_txt.Location = new System.Drawing.Point(209, 157);
            this.description_txt.Multiline = true;
            this.description_txt.Name = "description_txt";
            this.description_txt.Size = new System.Drawing.Size(248, 27);
            this.description_txt.TabIndex = 6;
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(209, 99);
            this.Name_txt.Multiline = true;
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(248, 27);
            this.Name_txt.TabIndex = 7;
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(90, 308);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(94, 29);
            this.Save_btn.TabIndex = 8;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // restore_btn
            // 
            this.restore_btn.Location = new System.Drawing.Point(246, 308);
            this.restore_btn.Name = "restore_btn";
            this.restore_btn.Size = new System.Drawing.Size(94, 29);
            this.restore_btn.TabIndex = 9;
            this.restore_btn.Text = "Restore";
            this.restore_btn.UseVisualStyleBackColor = true;
            this.restore_btn.Click += new System.EventHandler(this.restore_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 423);
            this.Controls.Add(this.restore_btn);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.description_txt);
            this.Controls.Add(this.Price_txt);
            this.Controls.Add(this.Section_txt);
            this.Controls.Add(this.Price_Label);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.Food_Name_Label);
            this.Controls.Add(this.Section_label);
            this.Name = "Form1";
            this.Text = "Meau";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Section_label;
        private System.Windows.Forms.Label Food_Name_Label;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label Price_Label;
        private System.Windows.Forms.TextBox Section_txt;
        private System.Windows.Forms.TextBox Price_txt;
        private System.Windows.Forms.TextBox description_txt;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button restore_btn;
    }
}

