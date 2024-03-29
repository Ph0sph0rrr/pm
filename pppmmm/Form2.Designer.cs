namespace pppmmm
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.obor = new System.Windows.Forms.TextBox();
            this.polom = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.namek = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клиент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Оборудование";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Опишите поломку";
            // 
            // obor
            // 
            this.obor.Location = new System.Drawing.Point(65, 111);
            this.obor.Name = "obor";
            this.obor.Size = new System.Drawing.Size(683, 20);
            this.obor.TabIndex = 4;
            // 
            // polom
            // 
            this.polom.Location = new System.Drawing.Point(65, 188);
            this.polom.Name = "polom";
            this.polom.Size = new System.Drawing.Size(683, 20);
            this.polom.TabIndex = 5;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(62, 317);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(186, 23);
            this.Create.TabIndex = 6;
            this.Create.Text = "Создать заявку";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ваше имя";
            // 
            // namek
            // 
            this.namek.Location = new System.Drawing.Point(62, 261);
            this.namek.Name = "namek";
            this.namek.Size = new System.Drawing.Size(683, 20);
            this.namek.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.namek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.polom);
            this.Controls.Add(this.obor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Клиент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox obor;
        private System.Windows.Forms.TextBox polom;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox namek;
    }
}