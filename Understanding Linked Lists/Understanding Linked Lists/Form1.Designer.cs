namespace Understanding_Linked_Lists
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
            btnLinkList = new Button();
            btnLinkedListEx2 = new Button();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            btnDelete = new Button();
            textBox2 = new TextBox();
            BtnSortLinkList = new Button();
            SuspendLayout();
            // 
            // btnLinkList
            // 
            btnLinkList.Location = new Point(15, 15);
            btnLinkList.Margin = new Padding(6);
            btnLinkList.Name = "btnLinkList";
            btnLinkList.Size = new Size(241, 68);
            btnLinkList.TabIndex = 0;
            btnLinkList.Text = "Link List";
            btnLinkList.UseVisualStyleBackColor = true;
            btnLinkList.Click += btnLinkList_Click;
            // 
            // btnLinkedListEx2
            // 
            btnLinkedListEx2.Location = new Point(15, 334);
            btnLinkedListEx2.Margin = new Padding(6);
            btnLinkedListEx2.Name = "btnLinkedListEx2";
            btnLinkedListEx2.Size = new Size(241, 68);
            btnLinkedListEx2.TabIndex = 1;
            btnLinkedListEx2.Text = "Linked List Ex 2";
            btnLinkedListEx2.UseVisualStyleBackColor = true;
            btnLinkedListEx2.Click += btnLinkedListEx2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(324, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 35);
            textBox1.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 30;
            listBox1.Location = new Point(324, 69);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(219, 214);
            listBox1.TabIndex = 4;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(578, 12);
            btnDelete.Margin = new Padding(6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(241, 68);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete Node";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(578, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 35);
            textBox2.TabIndex = 6;
            // 
            // BtnSortLinkList
            // 
            BtnSortLinkList.Location = new Point(578, 148);
            BtnSortLinkList.Margin = new Padding(6);
            BtnSortLinkList.Name = "BtnSortLinkList";
            BtnSortLinkList.Size = new Size(241, 68);
            BtnSortLinkList.TabIndex = 7;
            BtnSortLinkList.Text = "Sort Link List";
            BtnSortLinkList.UseVisualStyleBackColor = true;
            BtnSortLinkList.Click += BtnSortLinkList_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 458);
            Controls.Add(BtnSortLinkList);
            Controls.Add(textBox2);
            Controls.Add(btnDelete);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(btnLinkedListEx2);
            Controls.Add(btnLinkList);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLinkList;
        private Button btnLinkedListEx2;
        private TextBox textBox1;
        private ListBox listBox1;
        private Button btnDoubleLink;
        private Button btnDelete;
        private TextBox textBox2;
        private Button BtnSortLinkList;
    }
}