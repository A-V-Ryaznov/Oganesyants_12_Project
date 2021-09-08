namespace Scrambler
{
    partial class AttachmentScrambler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttachmentScrambler));
            this.textKey = new System.Windows.Forms.TextBox();
            this.buttonScrambler = new System.Windows.Forms.Button();
            this.textSourse = new System.Windows.Forms.TextBox();
            this.labelSourse = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelKey = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRandomGenerator = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textResult = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьВсёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьПолеВводаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьПолеВыводаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonCopyKey = new System.Windows.Forms.Button();
            this.buttonCopyResult = new System.Windows.Forms.Button();
            this.buttonClearSourse = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textKey
            // 
            this.textKey.Location = new System.Drawing.Point(14, 58);
            this.textKey.Name = "textKey";
            this.textKey.Size = new System.Drawing.Size(309, 20);
            this.textKey.TabIndex = 0;
            // 
            // buttonScrambler
            // 
            this.buttonScrambler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonScrambler.Location = new System.Drawing.Point(329, 223);
            this.buttonScrambler.Name = "buttonScrambler";
            this.buttonScrambler.Size = new System.Drawing.Size(202, 46);
            this.buttonScrambler.TabIndex = 1;
            this.buttonScrambler.Text = "Зашифровать/Расшифровать";
            this.buttonScrambler.UseVisualStyleBackColor = true;
            this.buttonScrambler.Click += new System.EventHandler(this.buttonScrambler_Click);
            // 
            // textSourse
            // 
            this.textSourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textSourse.Location = new System.Drawing.Point(13, 118);
            this.textSourse.Multiline = true;
            this.textSourse.Name = "textSourse";
            this.textSourse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textSourse.Size = new System.Drawing.Size(310, 274);
            this.textSourse.TabIndex = 2;
            // 
            // labelSourse
            // 
            this.labelSourse.AutoSize = true;
            this.labelSourse.Location = new System.Drawing.Point(10, 94);
            this.labelSourse.Name = "labelSourse";
            this.labelSourse.Size = new System.Drawing.Size(62, 13);
            this.labelSourse.TabIndex = 4;
            this.labelSourse.Text = "Ваш текст:";
            // 
            // labelResult
            // 
            this.labelResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(534, 94);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(62, 13);
            this.labelResult.TabIndex = 5;
            this.labelResult.Text = "Результат:";
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(12, 34);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(36, 13);
            this.labelKey.TabIndex = 6;
            this.labelKey.Text = "Ключ:";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(248, 89);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 7;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(772, 89);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRandomGenerator
            // 
            this.buttonRandomGenerator.Location = new System.Drawing.Point(165, 27);
            this.buttonRandomGenerator.Name = "buttonRandomGenerator";
            this.buttonRandomGenerator.Size = new System.Drawing.Size(76, 23);
            this.buttonRandomGenerator.TabIndex = 9;
            this.buttonRandomGenerator.Text = "Создать";
            this.buttonRandomGenerator.UseVisualStyleBackColor = true;
            this.buttonRandomGenerator.Click += new System.EventHandler(this.buttonRandomGenerator_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textResult
            // 
            this.textResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textResult.Location = new System.Drawing.Point(537, 118);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textResult.Size = new System.Drawing.Size(310, 274);
            this.textResult.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьВсёToolStripMenuItem,
            this.очиститьПолеВводаToolStripMenuItem,
            this.очиститьПолеВыводаToolStripMenuItem});
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            // 
            // очиститьВсёToolStripMenuItem
            // 
            this.очиститьВсёToolStripMenuItem.Name = "очиститьВсёToolStripMenuItem";
            this.очиститьВсёToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.очиститьВсёToolStripMenuItem.Text = "Очистить всё";
            this.очиститьВсёToolStripMenuItem.Click += new System.EventHandler(this.очиститьВсёToolStripMenuItem_Click);
            // 
            // очиститьПолеВводаToolStripMenuItem
            // 
            this.очиститьПолеВводаToolStripMenuItem.Name = "очиститьПолеВводаToolStripMenuItem";
            this.очиститьПолеВводаToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.очиститьПолеВводаToolStripMenuItem.Text = "Очистить поле ввода";
            this.очиститьПолеВводаToolStripMenuItem.Click += new System.EventHandler(this.очиститьПолеВводаToolStripMenuItem_Click);
            // 
            // очиститьПолеВыводаToolStripMenuItem
            // 
            this.очиститьПолеВыводаToolStripMenuItem.Name = "очиститьПолеВыводаToolStripMenuItem";
            this.очиститьПолеВыводаToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.очиститьПолеВыводаToolStripMenuItem.Text = "Очистить поле вывода";
            this.очиститьПолеВыводаToolStripMenuItem.Click += new System.EventHandler(this.очиститьПолеВыводаToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // buttonCopyKey
            // 
            this.buttonCopyKey.Location = new System.Drawing.Point(247, 27);
            this.buttonCopyKey.Name = "buttonCopyKey";
            this.buttonCopyKey.Size = new System.Drawing.Size(76, 23);
            this.buttonCopyKey.TabIndex = 11;
            this.buttonCopyKey.Text = "Копировать";
            this.buttonCopyKey.UseVisualStyleBackColor = true;
            this.buttonCopyKey.Click += new System.EventHandler(this.buttonCopyKey_Click);
            // 
            // buttonCopyResult
            // 
            this.buttonCopyResult.Location = new System.Drawing.Point(690, 89);
            this.buttonCopyResult.Name = "buttonCopyResult";
            this.buttonCopyResult.Size = new System.Drawing.Size(76, 23);
            this.buttonCopyResult.TabIndex = 12;
            this.buttonCopyResult.Text = "Копировать";
            this.buttonCopyResult.UseVisualStyleBackColor = true;
            this.buttonCopyResult.Click += new System.EventHandler(this.buttonCopyResult_Click);
            // 
            // buttonClearSourse
            // 
            this.buttonClearSourse.Location = new System.Drawing.Point(165, 89);
            this.buttonClearSourse.Name = "buttonClearSourse";
            this.buttonClearSourse.Size = new System.Drawing.Size(75, 23);
            this.buttonClearSourse.TabIndex = 13;
            this.buttonClearSourse.Text = "Очистить";
            this.buttonClearSourse.UseVisualStyleBackColor = true;
            this.buttonClearSourse.Click += new System.EventHandler(this.buttonClearSourse_Click);
            // 
            // AttachmentScrambler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 404);
            this.Controls.Add(this.buttonClearSourse);
            this.Controls.Add(this.buttonCopyResult);
            this.Controls.Add(this.buttonCopyKey);
            this.Controls.Add(this.buttonRandomGenerator);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelSourse);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.textSourse);
            this.Controls.Add(this.buttonScrambler);
            this.Controls.Add(this.textKey);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "AttachmentScrambler";
            this.Text = "Шифратор";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textKey;
        private System.Windows.Forms.Button buttonScrambler;
        private System.Windows.Forms.TextBox textSourse;
        private System.Windows.Forms.Label labelSourse;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRandomGenerator;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьВсёToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьПолеВводаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьПолеВыводаToolStripMenuItem;
        private System.Windows.Forms.Button buttonCopyKey;
        private System.Windows.Forms.Button buttonCopyResult;
        private System.Windows.Forms.Button buttonClearSourse;
    }
}

