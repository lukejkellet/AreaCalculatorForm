namespace WinFormsApp1
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
            inputArea = new TextBox();
            shapeSelect = new ComboBox();
            inputLength = new TextBox();
            inputWidth = new TextBox();
            inputHeight = new TextBox();
            btnSubmit = new Button();
            outputAnswer = new TextBox();
            SuspendLayout();
            // 
            // inputArea
            // 
            inputArea.Location = new Point(12, 102);
            inputArea.Name = "inputArea";
            inputArea.Size = new Size(100, 23);
            inputArea.TabIndex = 3;
            inputArea.Text = "Area";
            inputArea.Visible = false;
            inputArea.TextChanged += textBox1_TextChanged;
            // 
            // shapeSelect
            // 
            shapeSelect.FormattingEnabled = true;
            shapeSelect.Items.AddRange(new object[] { "Square", "Triangle", "Circle" });
            shapeSelect.Location = new Point(125, 45);
            shapeSelect.Name = "shapeSelect";
            shapeSelect.Size = new Size(121, 23);
            shapeSelect.TabIndex = 4;
            shapeSelect.Text = "Select Shape...";
            shapeSelect.SelectedIndexChanged += shapeSelect_SelectedIndexChanged;
            // 
            // inputLength
            // 
            inputLength.Location = new Point(12, 102);
            inputLength.Name = "inputLength";
            inputLength.PlaceholderText = "Length";
            inputLength.Size = new Size(100, 23);
            inputLength.TabIndex = 5;
            inputLength.Visible = false;
            // 
            // inputWidth
            // 
            inputWidth.Location = new Point(137, 102);
            inputWidth.Name = "inputWidth";
            inputWidth.PlaceholderText = "Width";
            inputWidth.Size = new Size(100, 23);
            inputWidth.TabIndex = 6;
            inputWidth.Visible = false;
            // 
            // inputHeight
            // 
            inputHeight.Location = new Point(265, 102);
            inputHeight.Name = "inputHeight";
            inputHeight.PlaceholderText = "Height";
            inputHeight.Size = new Size(100, 23);
            inputHeight.TabIndex = 7;
            inputHeight.Visible = false;
            inputHeight.TextChanged += textBox1_TextChanged_1;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(148, 147);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += button1_Click;
            // 
            // outputAnswer
            // 
            outputAnswer.Location = new Point(99, 189);
            outputAnswer.Name = "outputAnswer";
            outputAnswer.ReadOnly = true;
            outputAnswer.Size = new Size(177, 23);
            outputAnswer.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 252);
            Controls.Add(outputAnswer);
            Controls.Add(btnSubmit);
            Controls.Add(inputHeight);
            Controls.Add(inputWidth);
            Controls.Add(inputLength);
            Controls.Add(shapeSelect);
            Controls.Add(inputArea);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox inputArea;
        private ComboBox shapeSelect;
        private TextBox inputLength;
        private TextBox inputWidth;
        private TextBox inputHeight;
        private Button btnSubmit;
        private TextBox outputAnswer;
    }
}