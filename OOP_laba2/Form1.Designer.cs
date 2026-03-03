namespace OOP_laba2;

partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labInfoLabel = new System.Windows.Forms.Label();
            labInfoButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // labInfoLabel
            // 
            labInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            labInfoLabel.Location = new System.Drawing.Point(160, 10);
            labInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labInfoLabel.Name = "labInfoLabel";
            labInfoLabel.Size = new System.Drawing.Size(485, 348);
            labInfoLabel.TabIndex = 0;
            labInfoLabel.Text = ("Лабораторная работа №2. Выполнили студенты группы 24ВП1 Песков Роман и Шадчина Ел" + "ена");
            // 
            // labInfoButton
            // 
            labInfoButton.Location = new System.Drawing.Point(320, 375);
            labInfoButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            labInfoButton.Name = "labInfoButton";
            labInfoButton.Size = new System.Drawing.Size(148, 43);
            labInfoButton.TabIndex = 1;
            labInfoButton.Text = "Продолжить";
            labInfoButton.UseVisualStyleBackColor = true;
            labInfoButton.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(816, 468);
            Controls.Add(labInfoButton);
            Controls.Add(labInfoLabel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "OOP laba 2";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label labInfoLabel;
        private System.Windows.Forms.Button labInfoButton;
    }