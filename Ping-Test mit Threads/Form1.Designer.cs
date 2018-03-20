namespace Ping_Test_mit_Threads
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_NichtOK = new System.Windows.Forms.ListBox();
            this.listBox_OK = new System.Windows.Forms.ListBox();
            this.label_pingNichtOK = new System.Windows.Forms.Label();
            this.label_pingOk = new System.Windows.Forms.Label();
            this.button_ping = new System.Windows.Forms.Button();
            this.listBox_adressen = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_NichtOK
            // 
            this.listBox_NichtOK.FormattingEnabled = true;
            this.listBox_NichtOK.Location = new System.Drawing.Point(489, 124);
            this.listBox_NichtOK.Name = "listBox_NichtOK";
            this.listBox_NichtOK.Size = new System.Drawing.Size(150, 108);
            this.listBox_NichtOK.TabIndex = 13;
            // 
            // listBox_OK
            // 
            this.listBox_OK.FormattingEnabled = true;
            this.listBox_OK.Location = new System.Drawing.Point(332, 124);
            this.listBox_OK.Name = "listBox_OK";
            this.listBox_OK.Size = new System.Drawing.Size(135, 108);
            this.listBox_OK.TabIndex = 12;
            // 
            // label_pingNichtOK
            // 
            this.label_pingNichtOK.AutoSize = true;
            this.label_pingNichtOK.Location = new System.Drawing.Point(486, 108);
            this.label_pingNichtOK.Name = "label_pingNichtOK";
            this.label_pingNichtOK.Size = new System.Drawing.Size(72, 13);
            this.label_pingNichtOK.TabIndex = 11;
            this.label_pingNichtOK.Text = "Ping nicht OK";
            // 
            // label_pingOk
            // 
            this.label_pingOk.AutoSize = true;
            this.label_pingOk.Location = new System.Drawing.Point(329, 108);
            this.label_pingOk.Name = "label_pingOk";
            this.label_pingOk.Size = new System.Drawing.Size(46, 13);
            this.label_pingOk.TabIndex = 10;
            this.label_pingOk.Text = "Ping OK";
            // 
            // button_ping
            // 
            this.button_ping.Location = new System.Drawing.Point(326, 44);
            this.button_ping.Name = "button_ping";
            this.button_ping.Size = new System.Drawing.Size(313, 36);
            this.button_ping.TabIndex = 9;
            this.button_ping.Text = "Ping";
            this.button_ping.UseVisualStyleBackColor = true;
            this.button_ping.Click += new System.EventHandler(this.button_ping_Click);
            // 
            // listBox_adressen
            // 
            this.listBox_adressen.FormattingEnabled = true;
            this.listBox_adressen.Location = new System.Drawing.Point(114, 45);
            this.listBox_adressen.Name = "listBox_adressen";
            this.listBox_adressen.Size = new System.Drawing.Size(160, 199);
            this.listBox_adressen.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Test-Adressen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 285);
            this.Controls.Add(this.listBox_NichtOK);
            this.Controls.Add(this.listBox_OK);
            this.Controls.Add(this.label_pingNichtOK);
            this.Controls.Add(this.label_pingOk);
            this.Controls.Add(this.button_ping);
            this.Controls.Add(this.listBox_adressen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_NichtOK;
        private System.Windows.Forms.ListBox listBox_OK;
        private System.Windows.Forms.Label label_pingNichtOK;
        private System.Windows.Forms.Label label_pingOk;
        private System.Windows.Forms.Button button_ping;
        private System.Windows.Forms.ListBox listBox_adressen;
        private System.Windows.Forms.Label label1;
    }
}

