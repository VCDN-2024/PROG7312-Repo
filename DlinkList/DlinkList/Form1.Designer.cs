namespace DlinkList
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
            btnAdd = new Button();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            BtnNext = new Button();
            BtnPrevious = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(45, 59);
            btnAdd.Margin = new Padding(6, 7, 6, 7);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(161, 57);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(369, 54);
            textBox1.Margin = new Padding(6, 7, 6, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 44);
            textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 37;
            listBox1.Location = new Point(45, 148);
            listBox1.Margin = new Padding(6, 7, 6, 7);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(964, 596);
            listBox1.TabIndex = 2;
            // 
            // BtnNext
            // 
            BtnNext.Location = new Point(45, 849);
            BtnNext.Margin = new Padding(6, 7, 6, 7);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new Size(161, 57);
            BtnNext.TabIndex = 3;
            BtnNext.Text = "Next";
            BtnNext.UseVisualStyleBackColor = true;
            BtnNext.Click += BtnNext_Click;
            // 
            // BtnPrevious
            // 
            BtnPrevious.Location = new Point(324, 849);
            BtnPrevious.Margin = new Padding(6, 7, 6, 7);
            BtnPrevious.Name = "BtnPrevious";
            BtnPrevious.Size = new Size(161, 57);
            BtnPrevious.TabIndex = 4;
            BtnPrevious.Text = "Previous";
            BtnPrevious.UseVisualStyleBackColor = true;
            BtnPrevious.Click += BtnPrevious_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(765, 857);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 38);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1072, 942);
            Controls.Add(label1);
            Controls.Add(BtnPrevious);
            Controls.Add(BtnNext);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(btnAdd);
            Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox textBox1;
        private ListBox listBox1;
        private Button BtnNext;
        private Button BtnPrevious;
        private Label label1;
    }
}