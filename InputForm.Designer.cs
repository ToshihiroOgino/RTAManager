
namespace RTAManager
{
	partial class InputForm
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
			this.AddBtn = new System.Windows.Forms.Button();
			this.nameLabel = new System.Windows.Forms.Label();
			this.recordLabel = new System.Windows.Forms.Label();
			this.tagLabel = new System.Windows.Forms.Label();
			this.commentLabel = new System.Windows.Forms.Label();
			this.commentRichTextBox = new System.Windows.Forms.RichTextBox();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.RecordTextBox = new System.Windows.Forms.TextBox();
			this.enableComboBox = new System.Windows.Forms.ComboBox();
			this.disableComboBox = new System.Windows.Forms.ComboBox();
			this.AddTagBtn = new System.Windows.Forms.Button();
			this.newTagTextBox = new System.Windows.Forms.TextBox();
			this.newTagLabel = new System.Windows.Forms.Label();
			this.enableLabel = new System.Windows.Forms.Label();
			this.disableLabel = new System.Windows.Forms.Label();
			this.enableBtn = new System.Windows.Forms.Button();
			this.disableBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// AddBtn
			// 
			this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.AddBtn.Location = new System.Drawing.Point(372, 365);
			this.AddBtn.Margin = new System.Windows.Forms.Padding(5);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(148, 59);
			this.AddBtn.TabIndex = 0;
			this.AddBtn.Text = "Add Record";
			this.AddBtn.UseVisualStyleBackColor = true;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(54, 15);
			this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(61, 22);
			this.nameLabel.TabIndex = 1;
			this.nameLabel.Text = "Name";
			// 
			// recordLabel
			// 
			this.recordLabel.AutoSize = true;
			this.recordLabel.Location = new System.Drawing.Point(39, 50);
			this.recordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.recordLabel.Name = "recordLabel";
			this.recordLabel.Size = new System.Drawing.Size(76, 22);
			this.recordLabel.TabIndex = 2;
			this.recordLabel.Text = "Record";
			// 
			// tagLabel
			// 
			this.tagLabel.AutoSize = true;
			this.tagLabel.Location = new System.Drawing.Point(72, 110);
			this.tagLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.tagLabel.Name = "tagLabel";
			this.tagLabel.Size = new System.Drawing.Size(43, 22);
			this.tagLabel.TabIndex = 4;
			this.tagLabel.Text = "Tag";
			// 
			// commentLabel
			// 
			this.commentLabel.AutoSize = true;
			this.commentLabel.Location = new System.Drawing.Point(9, 194);
			this.commentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.commentLabel.Name = "commentLabel";
			this.commentLabel.Size = new System.Drawing.Size(98, 22);
			this.commentLabel.TabIndex = 5;
			this.commentLabel.Text = "Comment";
			// 
			// commentRichTextBox
			// 
			this.commentRichTextBox.Location = new System.Drawing.Point(34, 219);
			this.commentRichTextBox.Name = "commentRichTextBox";
			this.commentRichTextBox.Size = new System.Drawing.Size(478, 141);
			this.commentRichTextBox.TabIndex = 6;
			this.commentRichTextBox.Text = "";
			// 
			// NameTextBox
			// 
			this.NameTextBox.Location = new System.Drawing.Point(122, 12);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(394, 29);
			this.NameTextBox.TabIndex = 7;
			// 
			// RecordTextBox
			// 
			this.RecordTextBox.Location = new System.Drawing.Point(122, 47);
			this.RecordTextBox.Name = "RecordTextBox";
			this.RecordTextBox.Size = new System.Drawing.Size(394, 29);
			this.RecordTextBox.TabIndex = 8;
			// 
			// enableComboBox
			// 
			this.enableComboBox.FormattingEnabled = true;
			this.enableComboBox.Location = new System.Drawing.Point(122, 110);
			this.enableComboBox.Name = "enableComboBox";
			this.enableComboBox.Size = new System.Drawing.Size(154, 29);
			this.enableComboBox.TabIndex = 9;
			// 
			// disableComboBox
			// 
			this.disableComboBox.FormattingEnabled = true;
			this.disableComboBox.Location = new System.Drawing.Point(362, 110);
			this.disableComboBox.Name = "disableComboBox";
			this.disableComboBox.Size = new System.Drawing.Size(154, 29);
			this.disableComboBox.TabIndex = 10;
			// 
			// AddTagBtn
			// 
			this.AddTagBtn.Location = new System.Drawing.Point(362, 154);
			this.AddTagBtn.Margin = new System.Windows.Forms.Padding(5);
			this.AddTagBtn.Name = "AddTagBtn";
			this.AddTagBtn.Size = new System.Drawing.Size(140, 34);
			this.AddTagBtn.TabIndex = 11;
			this.AddTagBtn.Text = "Add New Tag";
			this.AddTagBtn.UseVisualStyleBackColor = true;
			this.AddTagBtn.Click += new System.EventHandler(this.AddTagBtn_Click);
			// 
			// newTagTextBox
			// 
			this.newTagTextBox.Location = new System.Drawing.Point(205, 158);
			this.newTagTextBox.Name = "newTagTextBox";
			this.newTagTextBox.Size = new System.Drawing.Size(149, 29);
			this.newTagTextBox.TabIndex = 12;
			// 
			// newTagLabel
			// 
			this.newTagLabel.AutoSize = true;
			this.newTagLabel.Location = new System.Drawing.Point(109, 161);
			this.newTagLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.newTagLabel.Name = "newTagLabel";
			this.newTagLabel.Size = new System.Drawing.Size(89, 22);
			this.newTagLabel.TabIndex = 13;
			this.newTagLabel.Text = "New Tag";
			// 
			// enableLabel
			// 
			this.enableLabel.AutoSize = true;
			this.enableLabel.Location = new System.Drawing.Point(164, 85);
			this.enableLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.enableLabel.Name = "enableLabel";
			this.enableLabel.Size = new System.Drawing.Size(70, 22);
			this.enableLabel.TabIndex = 14;
			this.enableLabel.Text = "Enable";
			// 
			// disableLabel
			// 
			this.disableLabel.AutoSize = true;
			this.disableLabel.Location = new System.Drawing.Point(398, 85);
			this.disableLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.disableLabel.Name = "disableLabel";
			this.disableLabel.Size = new System.Drawing.Size(76, 22);
			this.disableLabel.TabIndex = 15;
			this.disableLabel.Text = "Disable";
			// 
			// enableBtn
			// 
			this.enableBtn.Location = new System.Drawing.Point(284, 110);
			this.enableBtn.Margin = new System.Windows.Forms.Padding(5);
			this.enableBtn.Name = "enableBtn";
			this.enableBtn.Size = new System.Drawing.Size(30, 30);
			this.enableBtn.TabIndex = 16;
			this.enableBtn.Text = "←";
			this.enableBtn.UseVisualStyleBackColor = true;
			this.enableBtn.Click += new System.EventHandler(this.enableBtn_Click);
			// 
			// disableBtn
			// 
			this.disableBtn.Location = new System.Drawing.Point(324, 110);
			this.disableBtn.Margin = new System.Windows.Forms.Padding(5);
			this.disableBtn.Name = "disableBtn";
			this.disableBtn.Size = new System.Drawing.Size(30, 30);
			this.disableBtn.TabIndex = 17;
			this.disableBtn.Text = "→";
			this.disableBtn.UseVisualStyleBackColor = true;
			this.disableBtn.Click += new System.EventHandler(this.disableBtn_Click);
			// 
			// InputForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 438);
			this.Controls.Add(this.disableBtn);
			this.Controls.Add(this.enableBtn);
			this.Controls.Add(this.disableLabel);
			this.Controls.Add(this.enableLabel);
			this.Controls.Add(this.newTagLabel);
			this.Controls.Add(this.newTagTextBox);
			this.Controls.Add(this.AddTagBtn);
			this.Controls.Add(this.disableComboBox);
			this.Controls.Add(this.enableComboBox);
			this.Controls.Add(this.RecordTextBox);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.commentRichTextBox);
			this.Controls.Add(this.commentLabel);
			this.Controls.Add(this.tagLabel);
			this.Controls.Add(this.recordLabel);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.AddBtn);
			this.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "InputForm";
			this.Text = "InputForm";
			this.Load += new System.EventHandler(this.InputForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button AddBtn;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label recordLabel;
		private System.Windows.Forms.Label tagLabel;
		private System.Windows.Forms.Label commentLabel;
		private System.Windows.Forms.RichTextBox commentRichTextBox;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.TextBox RecordTextBox;
		private System.Windows.Forms.ComboBox enableComboBox;
		private System.Windows.Forms.ComboBox disableComboBox;
		private System.Windows.Forms.Button AddTagBtn;
		private System.Windows.Forms.TextBox newTagTextBox;
		private System.Windows.Forms.Label newTagLabel;
		private System.Windows.Forms.Label enableLabel;
		private System.Windows.Forms.Label disableLabel;
		private System.Windows.Forms.Button enableBtn;
		private System.Windows.Forms.Button disableBtn;
	}
}