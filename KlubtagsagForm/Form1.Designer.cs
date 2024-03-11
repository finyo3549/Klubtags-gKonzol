namespace KlubtagsagForm
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
            label1 = new Label();
            listBox_tagok = new ListBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            dateTimePicker_Entry = new DateTimePicker();
            numericUpDown_Rating = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            textBox_FullName = new TextBox();
            label6 = new Label();
            textBox_Interest = new TextBox();
            numericUpDown_ID = new NumericUpDown();
            button_New = new Button();
            button_update = new Button();
            button_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Rating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_ID).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 9);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Members";
            // 
            // listBox_tagok
            // 
            listBox_tagok.FormattingEnabled = true;
            listBox_tagok.ItemHeight = 15;
            listBox_tagok.Location = new Point(12, 37);
            listBox_tagok.Name = "listBox_tagok";
            listBox_tagok.Size = new Size(282, 364);
            listBox_tagok.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(363, 54);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 2;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(365, 95);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 4;
            label3.Text = "Entry";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(444, 89);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(0, 23);
            textBox2.TabIndex = 5;
            // 
            // dateTimePicker_Entry
            // 
            dateTimePicker_Entry.Location = new Point(444, 89);
            dateTimePicker_Entry.Name = "dateTimePicker_Entry";
            dateTimePicker_Entry.Size = new Size(204, 23);
            dateTimePicker_Entry.TabIndex = 6;
            // 
            // numericUpDown_Rating
            // 
            numericUpDown_Rating.Location = new Point(444, 127);
            numericUpDown_Rating.Name = "numericUpDown_Rating";
            numericUpDown_Rating.Size = new Size(120, 23);
            numericUpDown_Rating.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(363, 129);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 8;
            label4.Text = "Rating";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(365, 165);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 10;
            label5.Text = "Full Name";
            // 
            // textBox_FullName
            // 
            textBox_FullName.Location = new Point(444, 162);
            textBox_FullName.Name = "textBox_FullName";
            textBox_FullName.Size = new Size(204, 23);
            textBox_FullName.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(365, 204);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 12;
            label6.Text = "Interest";
            // 
            // textBox_Interest
            // 
            textBox_Interest.Location = new Point(444, 201);
            textBox_Interest.Name = "textBox_Interest";
            textBox_Interest.Size = new Size(204, 23);
            textBox_Interest.TabIndex = 13;
            // 
            // numericUpDown_ID
            // 
            numericUpDown_ID.Location = new Point(444, 52);
            numericUpDown_ID.Name = "numericUpDown_ID";
            numericUpDown_ID.ReadOnly = true;
            numericUpDown_ID.Size = new Size(120, 23);
            numericUpDown_ID.TabIndex = 14;
            // 
            // button_New
            // 
            button_New.Location = new Point(351, 365);
            button_New.Name = "button_New";
            button_New.Size = new Size(75, 23);
            button_New.TabIndex = 15;
            button_New.Text = "New";
            button_New.UseVisualStyleBackColor = true;
            button_New.Click += button_New_Click;
            // 
            // button_update
            // 
            button_update.Location = new Point(460, 365);
            button_update.Name = "button_update";
            button_update.Size = new Size(75, 23);
            button_update.TabIndex = 16;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(562, 365);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(75, 23);
            button_delete.TabIndex = 17;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_delete);
            Controls.Add(button_update);
            Controls.Add(button_New);
            Controls.Add(numericUpDown_ID);
            Controls.Add(textBox_Interest);
            Controls.Add(label6);
            Controls.Add(textBox_FullName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(numericUpDown_Rating);
            Controls.Add(dateTimePicker_Entry);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox_tagok);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Rating).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_ID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox_tagok;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker_Entry;
        private NumericUpDown numericUpDown_Rating;
        private Label label4;
        private Label label5;
        private TextBox textBox_FullName;
        private Label label6;
        private TextBox textBox_Interest;
        private NumericUpDown numericUpDown_ID;
        private Button button_New;
        private Button button_update;
        private Button button_delete;
    }
}
