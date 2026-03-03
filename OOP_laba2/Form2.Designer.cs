using System.ComponentModel;

namespace OOP_laba2;

partial class Form2
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        button_Back = new System.Windows.Forms.Button();
        button_Exit = new System.Windows.Forms.Button();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        textBox_Actions = new System.Windows.Forms.TextBox();
        numericUpDown_Obj = new System.Windows.Forms.NumericUpDown();
        button_CreateObj = new System.Windows.Forms.Button();
        button_DeleteObj = new System.Windows.Forms.Button();
        listView1 = new System.Windows.Forms.ListView();
        columnHeader1 = new System.Windows.Forms.ColumnHeader();
        columnHeader2 = new System.Windows.Forms.ColumnHeader();
        columnHeader3 = new System.Windows.Forms.ColumnHeader();
        columnHeader4 = new System.Windows.Forms.ColumnHeader();
        button_Measure = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown_Obj).BeginInit();
        SuspendLayout();
        // 
        // button_Back
        // 
        button_Back.Location = new System.Drawing.Point(43, 592);
        button_Back.Name = "button_Back";
        button_Back.Size = new System.Drawing.Size(115, 35);
        button_Back.TabIndex = 0;
        button_Back.Text = "Назад";
        button_Back.UseVisualStyleBackColor = true;
        button_Back.Click += button_Back_Click;
        // 
        // button_Exit
        // 
        button_Exit.Location = new System.Drawing.Point(820, 592);
        button_Exit.Name = "button_Exit";
        button_Exit.Size = new System.Drawing.Size(115, 35);
        button_Exit.TabIndex = 1;
        button_Exit.Text = "Выход";
        button_Exit.UseVisualStyleBackColor = true;
        button_Exit.Click += button_Exit_Click;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
        dataGridView1.Location = new System.Drawing.Point(12, 34);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new System.Drawing.Size(630, 192);
        dataGridView1.TabIndex = 2;
        dataGridView1.Text = "dataGridView1";
        // 
        // Column1
        // 
        Column1.HeaderText = "Индекс (номер аэропорта)";
        Column1.Name = "Column1";
        // 
        // Column2
        // 
        Column2.HeaderText = "Название";
        Column2.Name = "Column2";
        // 
        // Column3
        // 
        Column3.HeaderText = "Местоположение";
        Column3.Name = "Column3";
        // 
        // Column4
        // 
        Column4.HeaderText = "Полетов за день";
        Column4.Name = "Column4";
        // 
        // Column5
        // 
        Column5.HeaderText = "Билетов продано";
        Column5.Name = "Column5";
        // 
        // Column6
        // 
        Column6.HeaderText = "Баланс";
        Column6.Name = "Column6";
        // 
        // Column7
        // 
        Column7.HeaderText = "Рейтинг";
        Column7.Name = "Column7";
        // 
        // Column8
        // 
        Column8.HeaderText = "Количество работников";
        Column8.Name = "Column8";
        // 
        // textBox_Actions
        // 
        textBox_Actions.Location = new System.Drawing.Point(673, 34);
        textBox_Actions.Multiline = true;
        textBox_Actions.Name = "textBox_Actions";
        textBox_Actions.ReadOnly = true;
        textBox_Actions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        textBox_Actions.Size = new System.Drawing.Size(284, 191);
        textBox_Actions.TabIndex = 3;
        // 
        // numericUpDown_Obj
        // 
        numericUpDown_Obj.Location = new System.Drawing.Point(43, 253);
        numericUpDown_Obj.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
        numericUpDown_Obj.Minimum = new decimal(new int[] { 1000, 0, 0, -2147483648 });
        numericUpDown_Obj.Name = "numericUpDown_Obj";
        numericUpDown_Obj.Size = new System.Drawing.Size(249, 23);
        numericUpDown_Obj.TabIndex = 4;
        // 
        // button_CreateObj
        // 
        button_CreateObj.Location = new System.Drawing.Point(394, 253);
        button_CreateObj.Name = "button_CreateObj";
        button_CreateObj.Size = new System.Drawing.Size(173, 23);
        button_CreateObj.TabIndex = 5;
        button_CreateObj.Text = "Создать объект";
        button_CreateObj.UseVisualStyleBackColor = true;
        button_CreateObj.Click += button_CreateObj_Click;
        // 
        // button_DeleteObj
        // 
        button_DeleteObj.Location = new System.Drawing.Point(659, 253);
        button_DeleteObj.Name = "button_DeleteObj";
        button_DeleteObj.Size = new System.Drawing.Size(173, 23);
        button_DeleteObj.TabIndex = 6;
        button_DeleteObj.Text = "Удалить объект";
        button_DeleteObj.UseVisualStyleBackColor = true;
        button_DeleteObj.Click += button_DeleteObj_Click;
        // 
        // listView1
        // 
        listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
        listView1.Location = new System.Drawing.Point(12, 292);
        listView1.Name = "listView1";
        listView1.Size = new System.Drawing.Size(945, 220);
        listView1.TabIndex = 7;
        listView1.UseCompatibleStateImageBehavior = false;
        // 
        // columnHeader1
        // 
        columnHeader1.Name = "columnHeader1";
        columnHeader1.Text = "Коллекция";
        columnHeader1.Width = 236;
        // 
        // columnHeader2
        // 
        columnHeader2.Name = "columnHeader2";
        columnHeader2.Text = "Вставка";
        columnHeader2.Width = 236;
        // 
        // columnHeader3
        // 
        columnHeader3.Name = "columnHeader3";
        columnHeader3.Text = "Последовательная выборка";
        columnHeader3.Width = 236;
        // 
        // columnHeader4
        // 
        columnHeader4.Name = "columnHeader4";
        columnHeader4.Text = "Случайная выборка";
        columnHeader4.Width = 236;
        // 
        // button_Measure
        // 
        button_Measure.Location = new System.Drawing.Point(435, 534);
        button_Measure.Name = "button_Measure";
        button_Measure.Size = new System.Drawing.Size(132, 38);
        button_Measure.TabIndex = 8;
        button_Measure.Text = "Измерить";
        button_Measure.UseVisualStyleBackColor = true;
        button_Measure.Click += button3_Click;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label1.Location = new System.Drawing.Point(274, 6);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(159, 23);
        label1.TabIndex = 9;
        label1.Text = "Объекты";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        label2.Location = new System.Drawing.Point(765, 6);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(102, 25);
        label2.TabIndex = 10;
        label2.Text = "События";
        // 
        // Form2
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(969, 639);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(button_Measure);
        Controls.Add(listView1);
        Controls.Add(button_DeleteObj);
        Controls.Add(button_CreateObj);
        Controls.Add(numericUpDown_Obj);
        Controls.Add(textBox_Actions);
        Controls.Add(dataGridView1);
        Controls.Add(button_Exit);
        Controls.Add(button_Back);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        Location = new System.Drawing.Point(15, 15);
        MaximizeBox = false;
        Text = "OOP2";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown_Obj).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.ColumnHeader columnHeader4;

    private System.Windows.Forms.ColumnHeader columnHeader2;

    private System.Windows.Forms.ColumnHeader columnHeader1;

    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.Button button_Measure;

    private System.Windows.Forms.NumericUpDown numericUpDown_Obj;
    private System.Windows.Forms.Button button_CreateObj;
    private System.Windows.Forms.Button button_DeleteObj;

    private System.Windows.Forms.TextBox textBox_Actions;

    private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column8;

    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;

    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;

    private System.Windows.Forms.DataGridView dataGridView1;

    private System.Windows.Forms.Button button_Back;
    private System.Windows.Forms.Button button_Exit;

    #endregion
}