namespace Ping_Test
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_adressen = new System.Windows.Forms.ListBox();
            this.button_ping = new System.Windows.Forms.Button();
            this.label_pingOk = new System.Windows.Forms.Label();
            this.label_pingNichtOK = new System.Windows.Forms.Label();
            this.listBox_OK = new System.Windows.Forms.ListBox();
            this.listBox_NichtOK = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test-Adressen";
            // 
            // listBox_adressen
            // 
            this.listBox_adressen.FormattingEnabled = true;
            this.listBox_adressen.Location = new System.Drawing.Point(50, 68);
            this.listBox_adressen.Name = "listBox_adressen";
            this.listBox_adressen.Size = new System.Drawing.Size(160, 199);
            this.listBox_adressen.TabIndex = 1;
            // 
            // button_ping
            // 
            this.button_ping.Location = new System.Drawing.Point(262, 67);
            this.button_ping.Name = "button_ping";
            this.button_ping.Size = new System.Drawing.Size(313, 36);
            this.button_ping.TabIndex = 2;
            this.button_ping.Text = "Ping";
            this.button_ping.UseVisualStyleBackColor = true;
            this.button_ping.Click += new System.EventHandler(this.button_ping_Click);
            // 
            // label_pingOk
            // 
            this.label_pingOk.AutoSize = true;
            this.label_pingOk.Location = new System.Drawing.Point(265, 131);
            this.label_pingOk.Name = "label_pingOk";
            this.label_pingOk.Size = new System.Drawing.Size(46, 13);
            this.label_pingOk.TabIndex = 3;
            this.label_pingOk.Text = "Ping OK";
            // 
            // label_pingNichtOK
            // 
            this.label_pingNichtOK.AutoSize = true;
            this.label_pingNichtOK.Location = new System.Drawing.Point(422, 131);
            this.label_pingNichtOK.Name = "label_pingNichtOK";
            this.label_pingNichtOK.Size = new System.Drawing.Size(72, 13);
            this.label_pingNichtOK.TabIndex = 4;
            this.label_pingNichtOK.Text = "Ping nicht OK";
            // 
            // listBox_OK
            // 
            this.listBox_OK.FormattingEnabled = true;
            this.listBox_OK.Location = new System.Drawing.Point(268, 147);
            this.listBox_OK.Name = "listBox_OK";
            this.listBox_OK.Size = new System.Drawing.Size(135, 108);
            this.listBox_OK.TabIndex = 5;
            // 
            // listBox_NichtOK
            // 
            this.listBox_NichtOK.FormattingEnabled = true;
            this.listBox_NichtOK.Location = new System.Drawing.Point(425, 147);
            this.listBox_NichtOK.Name = "listBox_NichtOK";
            this.listBox_NichtOK.Size = new System.Drawing.Size(150, 108);
            this.listBox_NichtOK.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 324);
            this.Controls.Add(this.listBox_NichtOK);
            this.Controls.Add(this.listBox_OK);
            this.Controls.Add(this.label_pingNichtOK);
            this.Controls.Add(this.label_pingOk);
            this.Controls.Add(this.button_ping);
            this.Controls.Add(this.listBox_adressen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ping-Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_adressen;
        private System.Windows.Forms.Button button_ping;
        private System.Windows.Forms.Label label_pingOk;
        private System.Windows.Forms.Label label_pingNichtOK;
        private System.Windows.Forms.ListBox listBox_OK;
        private System.Windows.Forms.ListBox listBox_NichtOK;
    }
}

