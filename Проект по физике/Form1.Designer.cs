namespace Проект_по_физике
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.RenderTimer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Binding2_Label = new System.Windows.Forms.Label();
            this.Binding1_Label = new System.Windows.Forms.Label();
            this.Lentil2_Label = new System.Windows.Forms.Label();
            this.Lentil1_Label = new System.Windows.Forms.Label();
            this.IncBinding2_Button = new System.Windows.Forms.Button();
            this.DecBinding2_Button = new System.Windows.Forms.Button();
            this.IncBinding1_Button = new System.Windows.Forms.Button();
            this.DecBinding1_Button = new System.Windows.Forms.Button();
            this.IncLentil2_Button = new System.Windows.Forms.Button();
            this.DecLentil2_Button = new System.Windows.Forms.Button();
            this.IncLentil1_Button = new System.Windows.Forms.Button();
            this.DecLentil1_Button = new System.Windows.Forms.Button();
            this.BottomMount_radioButton = new System.Windows.Forms.RadioButton();
            this.TopMount_radioButton = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AngleValue_Label = new System.Windows.Forms.Label();
            this.ChangeAngle_TrackBar = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.графикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графикΘtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаПоПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОРазработчикахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeAngle_TrackBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnT
            // 
            this.AnT.AccumBits = ((byte)(0));
            this.AnT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnT.AutoCheckErrors = false;
            this.AnT.AutoFinish = false;
            this.AnT.AutoMakeCurrent = true;
            this.AnT.AutoSwapBuffers = true;
            this.AnT.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AnT.ColorBits = ((byte)(32));
            this.AnT.DepthBits = ((byte)(16));
            this.AnT.Location = new System.Drawing.Point(12, 30);
            this.AnT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(1061, 753);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 170);
            this.label7.TabIndex = 35;
            this.label7.Text = "Оборотный маятник\r\nРазработчики:\r\nЧервонецкий Д. Н. ПМИ-31\r\nМилякина Е. О. ПМИ-31" +
    "\r\nСоловьёв Б. С. ПМИ-31\r\nМахнёва Е. А. ПМИ-31\r\n\r\nРуководитель:\r\nБаранов А. В.\r\nb" +
    "aranovav@ngs.ru";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackgroundImage = global::Проект_по_физике.Properties.Resources.X9qxn1viHXo;
            this.pictureBox1.Location = new System.Drawing.Point(7, 195);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 146);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Угол:   0°";
            // 
            // Binding2_Label
            // 
            this.Binding2_Label.AutoSize = true;
            this.Binding2_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Binding2_Label.Location = new System.Drawing.Point(4, 121);
            this.Binding2_Label.Name = "Binding2_Label";
            this.Binding2_Label.Size = new System.Drawing.Size(126, 15);
            this.Binding2_Label.TabIndex = 30;
            this.Binding2_Label.Text = "Дальнее крепление:";
            // 
            // Binding1_Label
            // 
            this.Binding1_Label.AutoSize = true;
            this.Binding1_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Binding1_Label.Location = new System.Drawing.Point(3, 94);
            this.Binding1_Label.Name = "Binding1_Label";
            this.Binding1_Label.Size = new System.Drawing.Size(127, 15);
            this.Binding1_Label.TabIndex = 29;
            this.Binding1_Label.Text = "Ближнее крепление:";
            // 
            // Lentil2_Label
            // 
            this.Lentil2_Label.AutoSize = true;
            this.Lentil2_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lentil2_Label.Location = new System.Drawing.Point(4, 66);
            this.Lentil2_Label.Name = "Lentil2_Label";
            this.Lentil2_Label.Size = new System.Drawing.Size(87, 15);
            this.Lentil2_Label.TabIndex = 28;
            this.Lentil2_Label.Text = "Дальний груз:";
            // 
            // Lentil1_Label
            // 
            this.Lentil1_Label.AutoSize = true;
            this.Lentil1_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lentil1_Label.Location = new System.Drawing.Point(3, 39);
            this.Lentil1_Label.Name = "Lentil1_Label";
            this.Lentil1_Label.Size = new System.Drawing.Size(88, 15);
            this.Lentil1_Label.TabIndex = 27;
            this.Lentil1_Label.Text = "Ближний груз:";
            // 
            // IncBinding2_Button
            // 
            this.IncBinding2_Button.Location = new System.Drawing.Point(221, 117);
            this.IncBinding2_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IncBinding2_Button.Name = "IncBinding2_Button";
            this.IncBinding2_Button.Size = new System.Drawing.Size(29, 23);
            this.IncBinding2_Button.TabIndex = 26;
            this.IncBinding2_Button.Text = "+";
            this.IncBinding2_Button.UseVisualStyleBackColor = true;
            this.IncBinding2_Button.Click += new System.EventHandler(this.IncBinding2_Button_Click);
            // 
            // DecBinding2_Button
            // 
            this.DecBinding2_Button.Location = new System.Drawing.Point(147, 117);
            this.DecBinding2_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DecBinding2_Button.Name = "DecBinding2_Button";
            this.DecBinding2_Button.Size = new System.Drawing.Size(29, 23);
            this.DecBinding2_Button.TabIndex = 25;
            this.DecBinding2_Button.Text = "-";
            this.DecBinding2_Button.UseVisualStyleBackColor = true;
            this.DecBinding2_Button.Click += new System.EventHandler(this.DecBinding2_Button_Click);
            // 
            // IncBinding1_Button
            // 
            this.IncBinding1_Button.Location = new System.Drawing.Point(221, 90);
            this.IncBinding1_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IncBinding1_Button.Name = "IncBinding1_Button";
            this.IncBinding1_Button.Size = new System.Drawing.Size(29, 23);
            this.IncBinding1_Button.TabIndex = 24;
            this.IncBinding1_Button.Text = "+";
            this.IncBinding1_Button.UseVisualStyleBackColor = true;
            this.IncBinding1_Button.Click += new System.EventHandler(this.IncBinding1_Button_Click);
            // 
            // DecBinding1_Button
            // 
            this.DecBinding1_Button.Location = new System.Drawing.Point(147, 90);
            this.DecBinding1_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DecBinding1_Button.Name = "DecBinding1_Button";
            this.DecBinding1_Button.Size = new System.Drawing.Size(29, 23);
            this.DecBinding1_Button.TabIndex = 23;
            this.DecBinding1_Button.Text = "-";
            this.DecBinding1_Button.UseVisualStyleBackColor = true;
            this.DecBinding1_Button.Click += new System.EventHandler(this.DecBinding1_Button_Click);
            // 
            // IncLentil2_Button
            // 
            this.IncLentil2_Button.Location = new System.Drawing.Point(221, 63);
            this.IncLentil2_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IncLentil2_Button.Name = "IncLentil2_Button";
            this.IncLentil2_Button.Size = new System.Drawing.Size(29, 23);
            this.IncLentil2_Button.TabIndex = 22;
            this.IncLentil2_Button.Text = "+";
            this.IncLentil2_Button.UseVisualStyleBackColor = true;
            this.IncLentil2_Button.Click += new System.EventHandler(this.IncLentil2_Button_Click);
            // 
            // DecLentil2_Button
            // 
            this.DecLentil2_Button.Location = new System.Drawing.Point(147, 63);
            this.DecLentil2_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DecLentil2_Button.Name = "DecLentil2_Button";
            this.DecLentil2_Button.Size = new System.Drawing.Size(29, 23);
            this.DecLentil2_Button.TabIndex = 21;
            this.DecLentil2_Button.Text = "-";
            this.DecLentil2_Button.UseVisualStyleBackColor = true;
            this.DecLentil2_Button.Click += new System.EventHandler(this.DecLentil2_Button_Click);
            // 
            // IncLentil1_Button
            // 
            this.IncLentil1_Button.Location = new System.Drawing.Point(221, 36);
            this.IncLentil1_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IncLentil1_Button.Name = "IncLentil1_Button";
            this.IncLentil1_Button.Size = new System.Drawing.Size(29, 23);
            this.IncLentil1_Button.TabIndex = 20;
            this.IncLentil1_Button.Text = "+";
            this.IncLentil1_Button.UseVisualStyleBackColor = true;
            this.IncLentil1_Button.Click += new System.EventHandler(this.IncLentil1_Button_Click);
            // 
            // DecLentil1_Button
            // 
            this.DecLentil1_Button.Location = new System.Drawing.Point(147, 36);
            this.DecLentil1_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DecLentil1_Button.Name = "DecLentil1_Button";
            this.DecLentil1_Button.Size = new System.Drawing.Size(29, 23);
            this.DecLentil1_Button.TabIndex = 19;
            this.DecLentil1_Button.Text = "-";
            this.DecLentil1_Button.UseVisualStyleBackColor = true;
            this.DecLentil1_Button.Click += new System.EventHandler(this.DecLentil1_Button_Click);
            // 
            // BottomMount_radioButton
            // 
            this.BottomMount_radioButton.AutoSize = true;
            this.BottomMount_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BottomMount_radioButton.Location = new System.Drawing.Point(4, 294);
            this.BottomMount_radioButton.Margin = new System.Windows.Forms.Padding(4);
            this.BottomMount_radioButton.Name = "BottomMount_radioButton";
            this.BottomMount_radioButton.Size = new System.Drawing.Size(198, 19);
            this.BottomMount_radioButton.TabIndex = 17;
            this.BottomMount_radioButton.TabStop = true;
            this.BottomMount_radioButton.Text = "Использовать 2-е крепление";
            this.BottomMount_radioButton.UseVisualStyleBackColor = true;
            this.BottomMount_radioButton.CheckedChanged += new System.EventHandler(this.BottomMount_radioButton_CheckedChanged);
            // 
            // TopMount_radioButton
            // 
            this.TopMount_radioButton.AutoSize = true;
            this.TopMount_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopMount_radioButton.Location = new System.Drawing.Point(4, 265);
            this.TopMount_radioButton.Margin = new System.Windows.Forms.Padding(4);
            this.TopMount_radioButton.Name = "TopMount_radioButton";
            this.TopMount_radioButton.Size = new System.Drawing.Size(198, 19);
            this.TopMount_radioButton.TabIndex = 12;
            this.TopMount_radioButton.TabStop = true;
            this.TopMount_radioButton.Text = "Использовать 1-е крепление";
            this.TopMount_radioButton.UseVisualStyleBackColor = true;
            this.TopMount_radioButton.CheckedChanged += new System.EventHandler(this.TopMount_radioButton_CheckedChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(4, 193);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(211, 28);
            this.button5.TabIndex = 16;
            this.button5.Text = "Пауза";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(4, 229);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(211, 28);
            this.button4.TabIndex = 15;
            this.button4.Text = "Закончить эксперимент";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 327);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Время:  0:0:0 с\r\n";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 158);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 28);
            this.button3.TabIndex = 13;
            this.button3.Text = "Начать эксперимент";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(176, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(176, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(175, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(175, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "2";
            // 
            // AngleValue_Label
            // 
            this.AngleValue_Label.AutoSize = true;
            this.AngleValue_Label.Location = new System.Drawing.Point(4, 5);
            this.AngleValue_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AngleValue_Label.Name = "AngleValue_Label";
            this.AngleValue_Label.Size = new System.Drawing.Size(22, 17);
            this.AngleValue_Label.TabIndex = 8;
            this.AngleValue_Label.Text = "0°";
            // 
            // ChangeAngle_TrackBar
            // 
            this.ChangeAngle_TrackBar.BackColor = System.Drawing.SystemColors.Window;
            this.ChangeAngle_TrackBar.Location = new System.Drawing.Point(24, 5);
            this.ChangeAngle_TrackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangeAngle_TrackBar.Maximum = 180;
            this.ChangeAngle_TrackBar.Minimum = -180;
            this.ChangeAngle_TrackBar.Name = "ChangeAngle_TrackBar";
            this.ChangeAngle_TrackBar.Size = new System.Drawing.Size(229, 56);
            this.ChangeAngle_TrackBar.TabIndex = 3;
            this.ChangeAngle_TrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ChangeAngle_TrackBar.Scroll += new System.EventHandler(this.ChangeAngle_TrackBar_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.графикиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1361, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // графикиToolStripMenuItem
            // 
            this.графикиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.графикToolStripMenuItem,
            this.графикΘtToolStripMenuItem,
            this.выходToolStripMenuItem1});
            this.графикиToolStripMenuItem.Name = "графикиToolStripMenuItem";
            this.графикиToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.графикиToolStripMenuItem.Text = "Проект";
            // 
            // графикToolStripMenuItem
            // 
            this.графикToolStripMenuItem.Name = "графикToolStripMenuItem";
            this.графикToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.графикToolStripMenuItem.Text = "График Θ(t)";
            this.графикToolStripMenuItem.Click += new System.EventHandler(this.графикToolStripMenuItem_Click);
            // 
            // графикΘtToolStripMenuItem
            // 
            this.графикΘtToolStripMenuItem.Name = "графикΘtToolStripMenuItem";
            this.графикΘtToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.графикΘtToolStripMenuItem.Text = "График Θ\'(t)";
            this.графикΘtToolStripMenuItem.Click += new System.EventHandler(this.графикΘtToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(161, 24);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem1_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаПоПрограммеToolStripMenuItem,
            this.информацияОРазработчикахToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // справкаПоПрограммеToolStripMenuItem
            // 
            this.справкаПоПрограммеToolStripMenuItem.Name = "справкаПоПрограммеToolStripMenuItem";
            this.справкаПоПрограммеToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            this.справкаПоПрограммеToolStripMenuItem.Text = "Справка по программе";
            this.справкаПоПрограммеToolStripMenuItem.Click += new System.EventHandler(this.справкаПоПрограммеToolStripMenuItem_Click);
            // 
            // информацияОРазработчикахToolStripMenuItem
            // 
            this.информацияОРазработчикахToolStripMenuItem.Name = "информацияОРазработчикахToolStripMenuItem";
            this.информацияОРазработчикахToolStripMenuItem.Size = new System.Drawing.Size(292, 24);
            this.информацияОРазработчикахToolStripMenuItem.Text = "Информация о разработчиках";
            this.информацияОРазработчикахToolStripMenuItem.Click += new System.EventHandler(this.информацияОРазработчикахToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 34);
            this.label8.TabIndex = 36;
            this.label8.Text = "Новосибирск\r\n       2015";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.AngleValue_Label);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Lentil2_Label);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.Lentil1_Label);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.IncBinding2_Button);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.DecBinding2_Button);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.IncBinding1_Button);
            this.panel1.Controls.Add(this.TopMount_radioButton);
            this.panel1.Controls.Add(this.DecBinding1_Button);
            this.panel1.Controls.Add(this.BottomMount_radioButton);
            this.panel1.Controls.Add(this.IncLentil2_Button);
            this.panel1.Controls.Add(this.DecLentil1_Button);
            this.panel1.Controls.Add(this.DecLentil2_Button);
            this.panel1.Controls.Add(this.IncLentil1_Button);
            this.panel1.Controls.Add(this.Binding1_Label);
            this.panel1.Controls.Add(this.Binding2_Label);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ChangeAngle_TrackBar);
            this.panel1.Location = new System.Drawing.Point(1079, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 373);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(1079, 395);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 388);
            this.panel2.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1361, 793);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AnT);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Виртуальная лаборатория \"Оборотный маятник\"";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeAngle_TrackBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.Timer RenderTimer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Binding2_Label;
        private System.Windows.Forms.Label Binding1_Label;
        private System.Windows.Forms.Label Lentil2_Label;
        private System.Windows.Forms.Label Lentil1_Label;
        private System.Windows.Forms.Button IncBinding2_Button;
        private System.Windows.Forms.Button DecBinding2_Button;
        private System.Windows.Forms.Button IncBinding1_Button;
        private System.Windows.Forms.Button DecBinding1_Button;
        private System.Windows.Forms.Button IncLentil2_Button;
        private System.Windows.Forms.Button DecLentil2_Button;
        private System.Windows.Forms.Button IncLentil1_Button;
        private System.Windows.Forms.Button DecLentil1_Button;
        private System.Windows.Forms.RadioButton BottomMount_radioButton;
        private System.Windows.Forms.RadioButton TopMount_radioButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AngleValue_Label;
        private System.Windows.Forms.TrackBar ChangeAngle_TrackBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem графикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графикΘtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаПоПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОРазработчикахToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

