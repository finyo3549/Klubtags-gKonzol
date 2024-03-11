namespace KlubtagsagForm
{
    partial class NewForm
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
            NewForm_textBox_Interest = new TextBox();
            label6 = new Label();
            NewForm_textBox_FullName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            NewForm_numericUpDown_Rating = new NumericUpDown();
            NewForm_dateTimePicker_Entry = new DateTimePicker();
            textBox2 = new TextBox();
            label3 = new Label();
            button_save = new Button();
            button_cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)NewForm_numericUpDown_Rating).BeginInit();
            SuspendLayout();
            // 
            // NewForm_textBox_Interest
            // 
            NewForm_textBox_Interest.Location = new Point(328, 239);
            NewForm_textBox_Interest.Name = "NewForm_textBox_Interest";
            NewForm_textBox_Interest.Size = new Size(204, 23);
            NewForm_textBox_Interest.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(249, 242);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 21;
            label6.Text = "Interest";
            // 
            // NewForm_textBox_FullName
            // 
            NewForm_textBox_FullName.Location = new Point(328, 200);
            NewForm_textBox_FullName.Name = "NewForm_textBox_FullName";
            NewForm_textBox_FullName.Size = new Size(204, 23);
            NewForm_textBox_FullName.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(249, 203);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 19;
            label5.Text = "Full Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(247, 167);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 18;
            label4.Text = "Rating";
            // 
            // NewForm_numericUpDown_Rating
            // 
            NewForm_numericUpDown_Rating.Location = new Point(328, 165);
            NewForm_numericUpDown_Rating.Name = "NewForm_numericUpDown_Rating";
            NewForm_numericUpDown_Rating.Size = new Size(120, 23);
            NewForm_numericUpDown_Rating.TabIndex = 17;
            // 
            // NewForm_dateTimePicker_Entry
            // 
            NewForm_dateTimePicker_Entry.Location = new Point(328, 127);
            NewForm_dateTimePicker_Entry.Name = "NewForm_dateTimePicker_Entry";
            NewForm_dateTimePicker_Entry.Size = new Size(204, 23);
            NewForm_dateTimePicker_Entry.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(328, 127);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(0, 23);
            textBox2.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 133);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 14;
            label3.Text = "Entry";
            // 
            // button_save
            // 
            button_save.Location = new Point(328, 324);
            button_save.Name = "button_save";
            button_save.Size = new Size(75, 23);
            button_save.TabIndex = 23;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(457, 324);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(75, 23);
            button_cancel.TabIndex = 24;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // NewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(NewForm_textBox_Interest);
            Controls.Add(label6);
            Controls.Add(NewForm_textBox_FullName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(NewForm_numericUpDown_Rating);
            Controls.Add(NewForm_dateTimePicker_Entry);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Name = "NewForm";
            Text = "NewForm";
            ((System.ComponentModel.ISupportInitialize)NewForm_numericUpDown_Rating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NewForm_textBox_Interest;
        private Label label6;
        private TextBox NewForm_textBox_FullName;
        private Label label5;
        private Label label4;
        private NumericUpDown NewForm_numericUpDown_Rating;
        private DateTimePicker NewForm_dateTimePicker_Entry;
        private TextBox textBox2;
        private Label label3;
        private Button button_save;
        private Button button_cancel;
    }
}