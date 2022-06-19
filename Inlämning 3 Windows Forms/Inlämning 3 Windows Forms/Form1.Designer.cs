namespace Inlämning_3_Windows_Forms
{
    partial class form1
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
            this.förnamn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.efternamn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.personnummer = new System.Windows.Forms.TextBox();
            this.okKnapp = new System.Windows.Forms.Button();
            this.avslutKnapp = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.läggTillPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avslutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(94, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Välkommen!";
            // 
            // förnamn
            // 
            this.förnamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.förnamn.Location = new System.Drawing.Point(126, 91);
            this.förnamn.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.förnamn.MinimumSize = new System.Drawing.Size(4, 30);
            this.förnamn.Name = "förnamn";
            this.förnamn.Size = new System.Drawing.Size(180, 23);
            this.förnamn.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(52, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Förnamn:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(43, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Efternamn:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // efternamn
            // 
            this.efternamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.efternamn.Location = new System.Drawing.Point(126, 126);
            this.efternamn.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.efternamn.MinimumSize = new System.Drawing.Size(4, 30);
            this.efternamn.Name = "efternamn";
            this.efternamn.Size = new System.Drawing.Size(180, 23);
            this.efternamn.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(13, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Personnummer:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // personnummer
            // 
            this.personnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.personnummer.Location = new System.Drawing.Point(126, 161);
            this.personnummer.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.personnummer.MinimumSize = new System.Drawing.Size(4, 30);
            this.personnummer.Name = "personnummer";
            this.personnummer.Size = new System.Drawing.Size(180, 23);
            this.personnummer.TabIndex = 6;
            this.personnummer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.personnummer_KeyPress);
            // 
            // okKnapp
            // 
            this.okKnapp.Location = new System.Drawing.Point(325, 162);
            this.okKnapp.Name = "okKnapp";
            this.okKnapp.Size = new System.Drawing.Size(77, 29);
            this.okKnapp.TabIndex = 8;
            this.okKnapp.Text = "Ok";
            this.okKnapp.UseVisualStyleBackColor = true;
            this.okKnapp.Click += new System.EventHandler(this.okKnapp_Click);
            // 
            // avslutKnapp
            // 
            this.avslutKnapp.Location = new System.Drawing.Point(16, 414);
            this.avslutKnapp.Name = "avslutKnapp";
            this.avslutKnapp.Size = new System.Drawing.Size(386, 29);
            this.avslutKnapp.TabIndex = 9;
            this.avslutKnapp.Text = "Avsluta";
            this.avslutKnapp.UseVisualStyleBackColor = true;
            this.avslutKnapp.Click += new System.EventHandler(this.avslutKnapp_Click);
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.SystemColors.Window;
            this.resultBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultBox.ForeColor = System.Drawing.Color.Chocolate;
            this.resultBox.Location = new System.Drawing.Point(16, 237);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(386, 157);
            this.resultBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Resultat:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(418, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.läggTillPersonToolStripMenuItem,
            this.avslutaToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // läggTillPersonToolStripMenuItem
            // 
            this.läggTillPersonToolStripMenuItem.Name = "läggTillPersonToolStripMenuItem";
            this.läggTillPersonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.läggTillPersonToolStripMenuItem.Text = "Lägg till person";
            this.läggTillPersonToolStripMenuItem.Click += new System.EventHandler(this.läggTillPersonToolStripMenuItem_Click);
            // 
            // avslutaToolStripMenuItem
            // 
            this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            this.avslutaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.avslutaToolStripMenuItem.Text = "Avsluta";
            this.avslutaToolStripMenuItem.Click += new System.EventHandler(this.avslutaToolStripMenuItem_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.avslutKnapp);
            this.Controls.Add(this.okKnapp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.personnummer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.efternamn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.förnamn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox förnamn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox efternamn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox personnummer;
        private System.Windows.Forms.Button okKnapp;
        private System.Windows.Forms.Button avslutKnapp;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem läggTillPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;
    }
}

