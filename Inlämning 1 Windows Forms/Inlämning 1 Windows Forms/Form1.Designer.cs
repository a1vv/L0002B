namespace Inlämning_1_Windows_Forms
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
            this.pris_text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.betalt_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.Valör = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Antal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pris_text
            // 
            this.pris_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.pris_text.Location = new System.Drawing.Point(74, 66);
            this.pris_text.Name = "pris_text";
            this.pris_text.Size = new System.Drawing.Size(100, 29);
            this.pris_text.TabIndex = 0;
            this.pris_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pris_text_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Location = new System.Drawing.Point(197, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "Beräkna";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(27, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pris";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(13, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Betalt";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // betalt_text
            // 
            this.betalt_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.betalt_text.Location = new System.Drawing.Point(74, 101);
            this.betalt_text.Name = "betalt_text";
            this.betalt_text.Size = new System.Drawing.Size(100, 29);
            this.betalt_text.TabIndex = 1;
            this.betalt_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.betalt_text_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.label3.Location = new System.Drawing.Point(141, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 44);
            this.label3.TabIndex = 6;
            this.label3.Text = "VÄXEL";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Valör,
            this.Antal});
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(13, 136);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(393, 253);
            this.listView.TabIndex = 7;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // Valör
            // 
            this.Valör.Text = "Valör";
            // 
            // Antal
            // 
            this.Antal.Text = "Antal";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button2.Location = new System.Drawing.Point(13, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(393, 43);
            this.button2.TabIndex = 8;
            this.button2.Text = "Avsluta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.betalt_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pris_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pris_text;
        private System.Windows.Forms.TextBox betalt_text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Valör;
        private System.Windows.Forms.ColumnHeader Antal;
        private System.Windows.Forms.Button button2;
    }
}

