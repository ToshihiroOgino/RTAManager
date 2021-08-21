namespace RTAManager
{
    partial class Sender
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
            this.name = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.comBox = new System.Windows.Forms.TextBox();
            this.second = new System.Windows.Forms.Label();
            this.oneSecBox = new System.Windows.Forms.ComboBox();
            this.tenSecBox = new System.Windows.Forms.ComboBox();
            this.minute = new System.Windows.Forms.Label();
            this.oneMinBox = new System.Windows.Forms.ComboBox();
            this.tenMinBox = new System.Windows.Forms.ComboBox();
            this.hour = new System.Windows.Forms.Label();
            this.tagsBox = new System.Windows.Forms.CheckedListBox();
            this.hourBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(14, 38);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(29, 12);
            this.name.TabIndex = 28;
            this.name.Text = "名前";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(16, 53);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(228, 19);
            this.nameBox.TabIndex = 27;
            // 
            // comBox
            // 
            this.comBox.Location = new System.Drawing.Point(572, 73);
            this.comBox.Multiline = true;
            this.comBox.Name = "comBox";
            this.comBox.Size = new System.Drawing.Size(215, 270);
            this.comBox.TabIndex = 26;
            // 
            // second
            // 
            this.second.AutoSize = true;
            this.second.Location = new System.Drawing.Point(384, 123);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(17, 12);
            this.second.TabIndex = 25;
            this.second.Text = "秒";
            // 
            // oneSecBox
            // 
            this.oneSecBox.FormattingEnabled = true;
            this.oneSecBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.oneSecBox.Location = new System.Drawing.Point(320, 115);
            this.oneSecBox.Name = "oneSecBox";
            this.oneSecBox.Size = new System.Drawing.Size(58, 20);
            this.oneSecBox.TabIndex = 24;
            // 
            // tenSecBox
            // 
            this.tenSecBox.FormattingEnabled = true;
            this.tenSecBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.tenSecBox.Location = new System.Drawing.Point(262, 115);
            this.tenSecBox.Name = "tenSecBox";
            this.tenSecBox.Size = new System.Drawing.Size(52, 20);
            this.tenSecBox.TabIndex = 23;
            // 
            // minute
            // 
            this.minute.AutoSize = true;
            this.minute.Location = new System.Drawing.Point(227, 123);
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(17, 12);
            this.minute.TabIndex = 22;
            this.minute.Text = "分";
            // 
            // oneMinBox
            // 
            this.oneMinBox.FormattingEnabled = true;
            this.oneMinBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.oneMinBox.Location = new System.Drawing.Point(163, 115);
            this.oneMinBox.Name = "oneMinBox";
            this.oneMinBox.Size = new System.Drawing.Size(58, 20);
            this.oneMinBox.TabIndex = 21;
            // 
            // tenMinBox
            // 
            this.tenMinBox.FormattingEnabled = true;
            this.tenMinBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.tenMinBox.Location = new System.Drawing.Point(105, 115);
            this.tenMinBox.Name = "tenMinBox";
            this.tenMinBox.Size = new System.Drawing.Size(52, 20);
            this.tenMinBox.TabIndex = 20;
            // 
            // hour
            // 
            this.hour.AutoSize = true;
            this.hour.Location = new System.Drawing.Point(60, 123);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(29, 12);
            this.hour.TabIndex = 19;
            this.hour.Text = "時間";
            // 
            // tagsBox
            // 
            this.tagsBox.FormattingEnabled = true;
            this.tagsBox.Location = new System.Drawing.Point(407, 73);
            this.tagsBox.Name = "tagsBox";
            this.tagsBox.Size = new System.Drawing.Size(120, 270);
            this.tagsBox.TabIndex = 18;
            // 
            // hourBox
            // 
            this.hourBox.Location = new System.Drawing.Point(16, 116);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(38, 19);
            this.hourBox.TabIndex = 17;
            this.hourBox.Text = "0";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(669, 380);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(118, 33);
            this.sendButton.TabIndex = 16;
            this.sendButton.Text = "SEND";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // Sender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.comBox);
            this.Controls.Add(this.second);
            this.Controls.Add(this.oneSecBox);
            this.Controls.Add(this.tenSecBox);
            this.Controls.Add(this.minute);
            this.Controls.Add(this.oneMinBox);
            this.Controls.Add(this.tenMinBox);
            this.Controls.Add(this.hour);
            this.Controls.Add(this.tagsBox);
            this.Controls.Add(this.hourBox);
            this.Controls.Add(this.sendButton);
            this.Name = "Sender";
            this.Text = "Sender";
            this.Load += new System.EventHandler(this.Sender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox comBox;
        private System.Windows.Forms.Label second;
        private System.Windows.Forms.ComboBox oneSecBox;
        private System.Windows.Forms.ComboBox tenSecBox;
        private System.Windows.Forms.Label minute;
        private System.Windows.Forms.ComboBox oneMinBox;
        private System.Windows.Forms.ComboBox tenMinBox;
        private System.Windows.Forms.Label hour;
        private System.Windows.Forms.CheckedListBox tagsBox;
        private System.Windows.Forms.TextBox hourBox;
        private System.Windows.Forms.Button sendButton;
    }
}