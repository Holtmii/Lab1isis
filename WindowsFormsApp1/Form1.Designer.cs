namespace WindowsFormsApp1
{
    partial class Child
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.работаСПрограммойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьТекстовыйФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаВВидеТаблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьСтатистикуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button7 = new System.Windows.Forms.Button();
            this.Hint = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСПрограммойToolStripMenuItem,
            this.редактированиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работаСПрограммойToolStripMenuItem
            // 
            this.работаСПрограммойToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьТекстовыйФайлToolStripMenuItem,
            this.статистикаВВидеТаблицыToolStripMenuItem,
            this.сохранитьСтатистикуToolStripMenuItem});
            this.работаСПрограммойToolStripMenuItem.Name = "работаСПрограммойToolStripMenuItem";
            this.работаСПрограммойToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.работаСПрограммойToolStripMenuItem.Text = "Работа с программой";
            this.работаСПрограммойToolStripMenuItem.ToolTipText = "дублирование функций основных кнопок";
            // 
            // загрузитьТекстовыйФайлToolStripMenuItem
            // 
            this.загрузитьТекстовыйФайлToolStripMenuItem.Name = "загрузитьТекстовыйФайлToolStripMenuItem";
            this.загрузитьТекстовыйФайлToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.загрузитьТекстовыйФайлToolStripMenuItem.Text = "Загрузить текстовый файл";
            this.загрузитьТекстовыйФайлToolStripMenuItem.Click += new System.EventHandler(this.загрузитьТекстовыйФайлToolStripMenuItem_Click);
            // 
            // статистикаВВидеТаблицыToolStripMenuItem
            // 
            this.статистикаВВидеТаблицыToolStripMenuItem.Name = "статистикаВВидеТаблицыToolStripMenuItem";
            this.статистикаВВидеТаблицыToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.статистикаВВидеТаблицыToolStripMenuItem.Text = "Статистика в виде таблицы";
            this.статистикаВВидеТаблицыToolStripMenuItem.Click += new System.EventHandler(this.статистикаВВидеТаблицыToolStripMenuItem_Click);
            // 
            // сохранитьСтатистикуToolStripMenuItem
            // 
            this.сохранитьСтатистикуToolStripMenuItem.Name = "сохранитьСтатистикуToolStripMenuItem";
            this.сохранитьСтатистикуToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.сохранитьСтатистикуToolStripMenuItem.Text = "Очистить поля";
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копированиеToolStripMenuItem,
            this.вставкаToolStripMenuItem,
            this.вырезатьToolStripMenuItem1});
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.редактированиеToolStripMenuItem.Text = "Редактирование";
            // 
            // копированиеToolStripMenuItem
            // 
            this.копированиеToolStripMenuItem.Name = "копированиеToolStripMenuItem";
            this.копированиеToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.копированиеToolStripMenuItem.Text = "Копировать";
            this.копированиеToolStripMenuItem.Click += new System.EventHandler(this.копированиеToolStripMenuItem_Click);
            // 
            // вставкаToolStripMenuItem
            // 
            this.вставкаToolStripMenuItem.Name = "вставкаToolStripMenuItem";
            this.вставкаToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.вставкаToolStripMenuItem.Text = "Вставить";
            this.вставкаToolStripMenuItem.Click += new System.EventHandler(this.вставкаToolStripMenuItem_Click);
            // 
            // вырезатьToolStripMenuItem1
            // 
            this.вырезатьToolStripMenuItem1.Name = "вырезатьToolStripMenuItem1";
            this.вырезатьToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.вырезатьToolStripMenuItem1.Text = "Вырезать";
            this.вырезатьToolStripMenuItem1.Click += new System.EventHandler(this.вырезатьToolStripMenuItem1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(32, 52);
            this.richTextBox1.MaximumSize = new System.Drawing.Size(500, 500);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(335, 427);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.Hint.SetToolTip(this.richTextBox1, "загруженный текст");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(109, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(504, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Статистика";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(453, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(293, 315);
            this.dataGridView1.TabIndex = 4;
            this.Hint.SetToolTip(this.dataGridView1, "статистика (в виде таблицы)");
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Длинна";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Количество";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Частота";
            this.Column3.Name = "Column3";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(140, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Загрузить";
            this.Hint.SetToolTip(this.button1, "загрузка текстового файла (txt)");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(507, 373);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(206, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Статистика (таблица)";
            this.Hint.SetToolTip(this.button4, "создание статистики по частоте появления в текте слов разной длинны (в виде табли" +
        "цы)");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button7
            // 
            this.button7.AllowDrop = true;
            this.button7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Location = new System.Drawing.Point(507, 418);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(206, 38);
            this.button7.TabIndex = 13;
            this.button7.Text = "Очистить поля";
            this.Hint.SetToolTip(this.button7, "очистка формы и всех полей");
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Hint
            // 
            this.Hint.ShowAlways = true;
            // 
            // button2
            // 
            this.button2.AllowDrop = true;
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(507, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 38);
            this.button2.TabIndex = 16;
            this.button2.Text = "Сохранить XML";
            this.Hint.SetToolTip(this.button2, "очистка формы и всех полей");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 571);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 18;
            // 
            // Child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 630);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Child";
            this.Text = "Программа";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Child_FormClosing);
            this.Load += new System.EventHandler(this.Child_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работаСПрограммойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьТекстовыйФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаВВидеТаблицыToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ToolStripMenuItem сохранитьСтатистикуToolStripMenuItem;
        private System.Windows.Forms.ToolTip Hint;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

