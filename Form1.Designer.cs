namespace Echo_Messenger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUserInput = new TextBox();
            btrUpload = new Button();
            lstTextInput = new ListBox();
            lblProgramName = new Label();
            lblTextCount = new Label();
            SuspendLayout();
            // 
            // txtUserInput
            // 
            txtUserInput.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtUserInput.Location = new Point(87, 506);
            txtUserInput.Name = "txtUserInput";
            txtUserInput.Size = new Size(600, 43);
            txtUserInput.TabIndex = 0;
            txtUserInput.KeyDown += txtUserInput_KeyDown;
            // 
            // btrUpload
            // 
            btrUpload.BackColor = Color.FromArgb(128, 255, 128);
            btrUpload.Font = new Font("맑은 고딕", 48F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btrUpload.Location = new Point(762, 480);
            btrUpload.Name = "btrUpload";
            btrUpload.Size = new Size(246, 91);
            btrUpload.TabIndex = 1;
            btrUpload.Text = "전송";
            btrUpload.UseVisualStyleBackColor = false;
            btrUpload.Click += btrupload_Click;
            // 
            // lstTextInput
            // 
            lstTextInput.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lstTextInput.FormattingEnabled = true;
            lstTextInput.Location = new Point(77, 95);
            lstTextInput.Name = "lstTextInput";
            lstTextInput.Size = new Size(931, 337);
            lstTextInput.TabIndex = 2;
            // 
            // lblProgramName
            // 
            lblProgramName.AutoSize = true;
            lblProgramName.Font = new Font("맑은 고딕", 36F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblProgramName.ForeColor = SystemColors.Highlight;
            lblProgramName.Location = new Point(68, 18);
            lblProgramName.Name = "lblProgramName";
            lblProgramName.Size = new Size(388, 65);
            lblProgramName.TabIndex = 3;
            lblProgramName.Text = "Echo Messenger";
            // 
            // lblTextCount
            // 
            lblTextCount.AutoSize = true;
            lblTextCount.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblTextCount.Location = new Point(33, 577);
            lblTextCount.Name = "lblTextCount";
            lblTextCount.Size = new Size(156, 30);
            lblTextCount.TabIndex = 4;
            lblTextCount.Text = "현재 대화 : 0개";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1098, 628);
            Controls.Add(lblTextCount);
            Controls.Add(lblProgramName);
            Controls.Add(lstTextInput);
            Controls.Add(btrUpload);
            Controls.Add(txtUserInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserInput;
        private Button btrUpload;
        private ListBox lstTextInput;
        private Label lblProgramName;
        private Label lblTextCount;
    }
}
