namespace IECacheTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnDelete = new System.Windows.Forms.Button();
            this.checkBoxTIF = new System.Windows.Forms.CheckBox();
            this.checkBoxCookies = new System.Windows.Forms.CheckBox();
            this.checkBoxHistory = new System.Windows.Forms.CheckBox();
            this.checkBoxForm = new System.Windows.Forms.CheckBox();
            this.checkBoxPasswords = new System.Windows.Forms.CheckBox();
            this.checkBoxDeleteAll = new System.Windows.Forms.CheckBox();
            this.checkBoxAllnadSettings = new System.Windows.Forms.CheckBox();
            this.RTBResultText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(156, 187);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(161, 60);
            this.BtnDelete.TabIndex = 0;
            this.BtnDelete.Text = "Delete Now";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // checkBoxTIF
            // 
            this.checkBoxTIF.AutoSize = true;
            this.checkBoxTIF.Location = new System.Drawing.Point(12, 25);
            this.checkBoxTIF.Name = "checkBoxTIF";
            this.checkBoxTIF.Size = new System.Drawing.Size(139, 17);
            this.checkBoxTIF.TabIndex = 1;
            this.checkBoxTIF.Text = "Temporary Internet Files";
            this.checkBoxTIF.UseVisualStyleBackColor = true;
            // 
            // checkBoxCookies
            // 
            this.checkBoxCookies.AutoSize = true;
            this.checkBoxCookies.Location = new System.Drawing.Point(12, 48);
            this.checkBoxCookies.Name = "checkBoxCookies";
            this.checkBoxCookies.Size = new System.Drawing.Size(64, 17);
            this.checkBoxCookies.TabIndex = 2;
            this.checkBoxCookies.Text = "Cookies";
            this.checkBoxCookies.UseVisualStyleBackColor = true;
            // 
            // checkBoxHistory
            // 
            this.checkBoxHistory.AutoSize = true;
            this.checkBoxHistory.Location = new System.Drawing.Point(12, 71);
            this.checkBoxHistory.Name = "checkBoxHistory";
            this.checkBoxHistory.Size = new System.Drawing.Size(58, 17);
            this.checkBoxHistory.TabIndex = 3;
            this.checkBoxHistory.Text = "History";
            this.checkBoxHistory.UseVisualStyleBackColor = true;
            // 
            // checkBoxForm
            // 
            this.checkBoxForm.AutoSize = true;
            this.checkBoxForm.Location = new System.Drawing.Point(12, 94);
            this.checkBoxForm.Name = "checkBoxForm";
            this.checkBoxForm.Size = new System.Drawing.Size(78, 17);
            this.checkBoxForm.TabIndex = 4;
            this.checkBoxForm.Text = "Form(Data)";
            this.checkBoxForm.UseVisualStyleBackColor = true;
            // 
            // checkBoxPasswords
            // 
            this.checkBoxPasswords.AutoSize = true;
            this.checkBoxPasswords.Location = new System.Drawing.Point(12, 117);
            this.checkBoxPasswords.Name = "checkBoxPasswords";
            this.checkBoxPasswords.Size = new System.Drawing.Size(77, 17);
            this.checkBoxPasswords.TabIndex = 5;
            this.checkBoxPasswords.Text = "Passwords";
            this.checkBoxPasswords.UseVisualStyleBackColor = true;
            // 
            // checkBoxDeleteAll
            // 
            this.checkBoxDeleteAll.AutoSize = true;
            this.checkBoxDeleteAll.Location = new System.Drawing.Point(12, 140);
            this.checkBoxDeleteAll.Name = "checkBoxDeleteAll";
            this.checkBoxDeleteAll.Size = new System.Drawing.Size(74, 17);
            this.checkBoxDeleteAll.TabIndex = 6;
            this.checkBoxDeleteAll.Text = "Delete(All)";
            this.checkBoxDeleteAll.UseVisualStyleBackColor = true;
            // 
            // checkBoxAllnadSettings
            // 
            this.checkBoxAllnadSettings.AutoSize = true;
            this.checkBoxAllnadSettings.Location = new System.Drawing.Point(12, 163);
            this.checkBoxAllnadSettings.Name = "checkBoxAllnadSettings";
            this.checkBoxAllnadSettings.Size = new System.Drawing.Size(305, 17);
            this.checkBoxAllnadSettings.TabIndex = 7;
            this.checkBoxAllnadSettings.Text = "Delete All – Also delete files and settings stored by add-ons ";
            this.checkBoxAllnadSettings.UseVisualStyleBackColor = true;
            // 
            // RTBResultText
            // 
            this.RTBResultText.Location = new System.Drawing.Point(12, 253);
            this.RTBResultText.Name = "RTBResultText";
            this.RTBResultText.Size = new System.Drawing.Size(450, 96);
            this.RTBResultText.TabIndex = 8;
            this.RTBResultText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 370);
            this.Controls.Add(this.RTBResultText);
            this.Controls.Add(this.checkBoxAllnadSettings);
            this.Controls.Add(this.checkBoxDeleteAll);
            this.Controls.Add(this.checkBoxPasswords);
            this.Controls.Add(this.checkBoxForm);
            this.Controls.Add(this.checkBoxHistory);
            this.Controls.Add(this.checkBoxCookies);
            this.Controls.Add(this.checkBoxTIF);
            this.Controls.Add(this.BtnDelete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "IE Cache Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.CheckBox checkBoxTIF;
        private System.Windows.Forms.CheckBox checkBoxCookies;
        private System.Windows.Forms.CheckBox checkBoxHistory;
        private System.Windows.Forms.CheckBox checkBoxForm;
        private System.Windows.Forms.CheckBox checkBoxPasswords;
        private System.Windows.Forms.CheckBox checkBoxDeleteAll;
        private System.Windows.Forms.CheckBox checkBoxAllnadSettings;
        private System.Windows.Forms.RichTextBox RTBResultText;
    }
}

