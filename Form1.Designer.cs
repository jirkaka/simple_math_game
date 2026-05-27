namespace Programko_prace
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_coward = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label_vyhry = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_lehka = new System.Windows.Forms.CheckBox();
            this.checkBox_normal = new System.Windows.Forms.CheckBox();
            this.checkBox_tezka = new System.Windows.Forms.CheckBox();
            this.checkBox_nemilosrdna = new System.Windows.Forms.CheckBox();
            this.button_start = new System.Windows.Forms.Button();
            this.button_confirm = new System.Windows.Forms.Button();
            this.textBox_cisla = new System.Windows.Forms.TextBox();
            this.textBox_soucet = new System.Windows.Forms.TextBox();
            this.label_typhry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(650, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "konec";
            // 
            // button_coward
            // 
            this.button_coward.Location = new System.Drawing.Point(94, 273);
            this.button_coward.Name = "button_coward";
            this.button_coward.Size = new System.Drawing.Size(129, 50);
            this.button_coward.TabIndex = 6;
            this.button_coward.Text = "vdát se";
            this.button_coward.UseVisualStyleBackColor = true;
            this.button_coward.Click += new System.EventHandler(this.button_coward_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "počet výher: ";
            // 
            // label_vyhry
            // 
            this.label_vyhry.AutoSize = true;
            this.label_vyhry.Location = new System.Drawing.Point(167, 340);
            this.label_vyhry.Name = "label_vyhry";
            this.label_vyhry.Size = new System.Drawing.Size(13, 13);
            this.label_vyhry.TabIndex = 8;
            this.label_vyhry.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(549, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "obtížnost";
            // 
            // checkBox_lehka
            // 
            this.checkBox_lehka.AutoSize = true;
            this.checkBox_lehka.Location = new System.Drawing.Point(554, 252);
            this.checkBox_lehka.Name = "checkBox_lehka";
            this.checkBox_lehka.Size = new System.Drawing.Size(52, 17);
            this.checkBox_lehka.TabIndex = 10;
            this.checkBox_lehka.Text = "lehká";
            this.checkBox_lehka.UseVisualStyleBackColor = true;
            this.checkBox_lehka.CheckedChanged += new System.EventHandler(this.checkBox_lehka_CheckedChanged);
            // 
            // checkBox_normal
            // 
            this.checkBox_normal.AutoSize = true;
            this.checkBox_normal.Location = new System.Drawing.Point(554, 283);
            this.checkBox_normal.Name = "checkBox_normal";
            this.checkBox_normal.Size = new System.Drawing.Size(67, 17);
            this.checkBox_normal.TabIndex = 11;
            this.checkBox_normal.Text = "normální";
            this.checkBox_normal.UseVisualStyleBackColor = true;
            this.checkBox_normal.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox_tezka
            // 
            this.checkBox_tezka.AutoSize = true;
            this.checkBox_tezka.Location = new System.Drawing.Point(554, 315);
            this.checkBox_tezka.Name = "checkBox_tezka";
            this.checkBox_tezka.Size = new System.Drawing.Size(52, 17);
            this.checkBox_tezka.TabIndex = 12;
            this.checkBox_tezka.Text = "těžká";
            this.checkBox_tezka.UseVisualStyleBackColor = true;
            this.checkBox_tezka.CheckedChanged += new System.EventHandler(this.checkBox_tezka_CheckedChanged);
            // 
            // checkBox_nemilosrdna
            // 
            this.checkBox_nemilosrdna.AutoSize = true;
            this.checkBox_nemilosrdna.Location = new System.Drawing.Point(554, 350);
            this.checkBox_nemilosrdna.Name = "checkBox_nemilosrdna";
            this.checkBox_nemilosrdna.Size = new System.Drawing.Size(82, 17);
            this.checkBox_nemilosrdna.TabIndex = 13;
            this.checkBox_nemilosrdna.Text = "nemilosrdná";
            this.checkBox_nemilosrdna.UseVisualStyleBackColor = true;
            this.checkBox_nemilosrdna.CheckedChanged += new System.EventHandler(this.checkBox_nemilosrdna_CheckedChanged);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(334, 254);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(100, 23);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_confirm
            // 
            this.button_confirm.Enabled = false;
            this.button_confirm.Location = new System.Drawing.Point(334, 341);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(100, 49);
            this.button_confirm.TabIndex = 14;
            this.button_confirm.Text = "confirm";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // textBox_cisla
            // 
            this.textBox_cisla.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_cisla.Enabled = false;
            this.textBox_cisla.Location = new System.Drawing.Point(334, 219);
            this.textBox_cisla.Name = "textBox_cisla";
            this.textBox_cisla.Size = new System.Drawing.Size(100, 20);
            this.textBox_cisla.TabIndex = 15;
            // 
            // textBox_soucet
            // 
            this.textBox_soucet.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_soucet.Enabled = false;
            this.textBox_soucet.Location = new System.Drawing.Point(334, 302);
            this.textBox_soucet.Name = "textBox_soucet";
            this.textBox_soucet.Size = new System.Drawing.Size(100, 20);
            this.textBox_soucet.TabIndex = 16;
            // 
            // label_typhry
            // 
            this.label_typhry.AutoSize = true;
            this.label_typhry.Location = new System.Drawing.Point(349, 406);
            this.label_typhry.Name = "label_typhry";
            this.label_typhry.Size = new System.Drawing.Size(0, 13);
            this.label_typhry.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_typhry);
            this.Controls.Add(this.textBox_soucet);
            this.Controls.Add(this.textBox_cisla);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.checkBox_nemilosrdna);
            this.Controls.Add(this.checkBox_tezka);
            this.Controls.Add(this.checkBox_normal);
            this.Controls.Add(this.checkBox_lehka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_vyhry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_coward);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "programko prace";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_coward;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_vyhry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_lehka;
        private System.Windows.Forms.CheckBox checkBox_normal;
        private System.Windows.Forms.CheckBox checkBox_tezka;
        private System.Windows.Forms.CheckBox checkBox_nemilosrdna;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.TextBox textBox_cisla;
        private System.Windows.Forms.TextBox textBox_soucet;
        private System.Windows.Forms.Label label_typhry;
    }
}

