namespace CaesarCipher
{
    partial class MainWindow
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
            inputArea = new RichTextBox();
            encodeBtn = new Button();
            outputArea = new RichTextBox();
            encodeV2Btn = new Button();
            SuspendLayout();
            // 
            // inputArea
            // 
            inputArea.Location = new Point(12, 12);
            inputArea.Name = "inputArea";
            inputArea.Size = new Size(474, 124);
            inputArea.TabIndex = 0;
            inputArea.Text = "";
            // 
            // encodeBtn
            // 
            encodeBtn.Location = new Point(12, 142);
            encodeBtn.Name = "encodeBtn";
            encodeBtn.Size = new Size(246, 34);
            encodeBtn.TabIndex = 1;
            encodeBtn.Text = "Encode text";
            encodeBtn.UseVisualStyleBackColor = true;
            encodeBtn.Click += encodeBtn_Click;
            // 
            // outputArea
            // 
            outputArea.Location = new Point(12, 182);
            outputArea.Name = "outputArea";
            outputArea.ReadOnly = true;
            outputArea.Size = new Size(474, 124);
            outputArea.TabIndex = 2;
            outputArea.Text = "";
            // 
            // encodeV2Btn
            // 
            encodeV2Btn.Location = new Point(264, 142);
            encodeV2Btn.Name = "encodeV2Btn";
            encodeV2Btn.Size = new Size(222, 34);
            encodeV2Btn.TabIndex = 3;
            encodeV2Btn.Text = "Encode text V2";
            encodeV2Btn.UseVisualStyleBackColor = true;
            encodeV2Btn.Click += encodeV2Btn_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 330);
            Controls.Add(encodeV2Btn);
            Controls.Add(outputArea);
            Controls.Add(encodeBtn);
            Controls.Add(inputArea);
            Name = "MainWindow";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox inputArea;
        private Button encodeBtn;
        private RichTextBox outputArea;
        private Button encodeV2Btn;
    }
}