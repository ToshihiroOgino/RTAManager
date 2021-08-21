
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
			this.enableComboBox = new System.Windows.Forms.ComboBox();
			this.disableComboBox = new System.Windows.Forms.ComboBox();
			this.AddTagBtn = new System.Windows.Forms.Button();
			this.newTagTextBox = new System.Windows.Forms.TextBox();
			this.newTagLabel = new System.Windows.Forms.Label();
			this.enableBtn = new System.Windows.Forms.Button();
			this.disableBtn = new System.Windows.Forms.Button();
			this.hourBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.minutsBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.secondBox = new System.Windows.Forms.TextBox();
			this.explainLabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// AddBtn
			// 
			this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.AddBtn.Location = new System.Drawing.Point(366, 377);
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
			this.commentRichTextBox.Size = new System.Drawing.Size(482, 141);
			this.commentRichTextBox.TabIndex = 6;
			this.commentRichTextBox.Text = "";
			// 
			// NameTextBox
			// 
			this.NameTextBox.Location = new System.Drawing.Point(122, 12);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(394, 29);
			this.NameTextBox.TabIndex = 7;
			this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
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
			this.AddTagBtn.Location = new System.Drawing.Point(362, 168);
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
			this.newTagTextBox.Location = new System.Drawing.Point(205, 172);
			this.newTagTextBox.Name = "newTagTextBox";
			this.newTagTextBox.Size = new System.Drawing.Size(149, 29);
			this.newTagTextBox.TabIndex = 12;
			this.newTagTextBox.TextChanged += new System.EventHandler(this.newTagTextBox_TextChanged);
			// 
			// newTagLabel
			// 
			this.newTagLabel.AutoSize = true;
			this.newTagLabel.Location = new System.Drawing.Point(109, 175);
			this.newTagLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.newTagLabel.Name = "newTagLabel";
			this.newTagLabel.Size = new System.Drawing.Size(89, 22);
			this.newTagLabel.TabIndex = 13;
			this.newTagLabel.Text = "New Tag";
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
			// hourBox
			// 
			this.hourBox.Location = new System.Drawing.Point(122, 47);
			this.hourBox.Name = "hourBox";
			this.hourBox.Size = new System.Drawing.Size(39, 29);
			this.hourBox.TabIndex = 18;
			this.hourBox.TextChanged += new System.EventHandler(this.hourBox_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(164, 50);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 22);
			this.label1.TabIndex = 19;
			this.label1.Text = "時間";
			// 
			// minutsBox
			// 
			this.minutsBox.Location = new System.Drawing.Point(225, 47);
			this.minutsBox.Name = "minutsBox";
			this.minutsBox.Size = new System.Drawing.Size(39, 29);
			this.minutsBox.TabIndex = 20;
			this.minutsBox.TextChanged += new System.EventHandler(this.minutsBox_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(271, 50);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 22);
			this.label2.TabIndex = 21;
			this.label2.Text = "分";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(356, 50);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 22);
			this.label3.TabIndex = 23;
			this.label3.Text = "秒";
			// 
			// secondBox
			// 
			this.secondBox.Location = new System.Drawing.Point(310, 47);
			this.secondBox.Name = "secondBox";
			this.secondBox.Size = new System.Drawing.Size(39, 29);
			this.secondBox.TabIndex = 22;
			this.secondBox.TextChanged += new System.EventHandler(this.secondBox_TextChanged);
			// 
			// explainLabel
			// 
			this.explainLabel.AutoSize = true;
			this.explainLabel.Font = new System.Drawing.Font("MS UI Gothic", 11F);
			this.explainLabel.Location = new System.Drawing.Point(202, 145);
			this.explainLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.explainLabel.Name = "explainLabel";
			this.explainLabel.Size = new System.Drawing.Size(227, 15);
			this.explainLabel.TabIndex = 24;
			this.explainLabel.Text = "追加したいタグを左に移動してください";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(153, 85);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 22);
			this.label4.TabIndex = 25;
			this.label4.Text = "追加済み";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(394, 85);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(98, 22);
			this.label5.TabIndex = 26;
			this.label5.Text = "追加可能";
			// 
			// InputForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(528, 450);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.explainLabel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.secondBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.minutsBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.hourBox);
			this.Controls.Add(this.disableBtn);
			this.Controls.Add(this.enableBtn);
			this.Controls.Add(this.newTagLabel);
			this.Controls.Add(this.newTagTextBox);
			this.Controls.Add(this.AddTagBtn);
			this.Controls.Add(this.disableComboBox);
			this.Controls.Add(this.enableComboBox);
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
		private System.Windows.Forms.ComboBox enableComboBox;
		private System.Windows.Forms.ComboBox disableComboBox;
		private System.Windows.Forms.Button AddTagBtn;
		private System.Windows.Forms.TextBox newTagTextBox;
		private System.Windows.Forms.Label newTagLabel;
		private System.Windows.Forms.Button enableBtn;
		private System.Windows.Forms.Button disableBtn;
		private System.Windows.Forms.TextBox hourBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox minutsBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox secondBox;
		private System.Windows.Forms.Label explainLabel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}