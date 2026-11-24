namespace LAB10
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
            textBoxAge = new TextBox();
            comboBoxEvent = new ComboBox();
            radioButtonOffline = new RadioButton();
            checkBoxAgreement = new CheckBox();
            btnSubmit = new Button();
            labelResult = new Label();
            textBoxName = new TextBox();
            radioButtonOnline = new RadioButton();
            buttonClean = new Button();
            SuspendLayout();
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(62, 84);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(125, 27);
            textBoxAge.TabIndex = 1;
            // 
            // comboBoxEvent
            // 
            comboBoxEvent.FormattingEnabled = true;
            comboBoxEvent.Location = new Point(62, 150);
            comboBoxEvent.Name = "comboBoxEvent";
            comboBoxEvent.Size = new Size(151, 28);
            comboBoxEvent.TabIndex = 2;
            // 
            // radioButtonOffline
            // 
            radioButtonOffline.AutoSize = true;
            radioButtonOffline.Location = new Point(62, 199);
            radioButtonOffline.Name = "radioButtonOffline";
            radioButtonOffline.Size = new Size(67, 24);
            radioButtonOffline.TabIndex = 3;
            radioButtonOffline.TabStop = true;
            radioButtonOffline.Text = "Очно";
            radioButtonOffline.UseVisualStyleBackColor = true;
            // 
            // checkBoxAgreement
            // 
            checkBoxAgreement.AutoSize = true;
            checkBoxAgreement.Location = new Point(62, 266);
            checkBoxAgreement.Name = "checkBoxAgreement";
            checkBoxAgreement.Size = new Size(259, 24);
            checkBoxAgreement.TabIndex = 4;
            checkBoxAgreement.Text = "Согласен получать уведомления";
            checkBoxAgreement.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(93, 319);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Отправка анкеты";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += button1_Click_1;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(396, 87);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(185, 20);
            labelResult.TabIndex = 6;
            labelResult.Text = "Отображение результата";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(62, 38);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 8;
            // 
            // radioButtonOnline
            // 
            radioButtonOnline.AutoSize = true;
            radioButtonOnline.Location = new Point(62, 229);
            radioButtonOnline.Name = "radioButtonOnline";
            radioButtonOnline.Size = new Size(84, 24);
            radioButtonOnline.TabIndex = 9;
            radioButtonOnline.TabStop = true;
            radioButtonOnline.Text = "Онлайн";
            radioButtonOnline.UseVisualStyleBackColor = true;
            // 
            // buttonClean
            // 
            buttonClean.Location = new Point(93, 354);
            buttonClean.Name = "buttonClean";
            buttonClean.Size = new Size(94, 29);
            buttonClean.TabIndex = 10;
            buttonClean.Text = "Сбросить";
            buttonClean.UseVisualStyleBackColor = true;
            buttonClean.Click += button1_Click_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 450);
            Controls.Add(buttonClean);
            Controls.Add(radioButtonOnline);
            Controls.Add(textBoxName);
            Controls.Add(labelResult);
            Controls.Add(btnSubmit);
            Controls.Add(checkBoxAgreement);
            Controls.Add(radioButtonOffline);
            Controls.Add(comboBoxEvent);
            Controls.Add(textBoxAge);
            Name = "Form1";
            Text = "Знакомство с Windows Forms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBoxAge;
        private ComboBox comboBoxEvent;
        private RadioButton radioButtonOffline;
        private CheckBox checkBoxAgreement;
        private Button btnSubmit;
        private Label labelResult;
        private TextBox textBoxName;
        private RadioButton radioButtonOnline;
        private Button buttonClean;
    }
}
