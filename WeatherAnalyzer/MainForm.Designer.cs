namespace WeatherAnalyzer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTempMin = new System.Windows.Forms.TextBox();
            this.textBoxTempMax = new System.Windows.Forms.TextBox();
            this.textBoxTempAvg = new System.Windows.Forms.TextBox();
            this.textBoxTempLast = new System.Windows.Forms.TextBox();
            this.textBoxPresMin = new System.Windows.Forms.TextBox();
            this.textBoxPresMax = new System.Windows.Forms.TextBox();
            this.textBoxPresAvg = new System.Windows.Forms.TextBox();
            this.textBoxPresLast = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxAirLast = new System.Windows.Forms.TextBox();
            this.textBoxAirAvg = new System.Windows.Forms.TextBox();
            this.textBoxAirMax = new System.Windows.Forms.TextBox();
            this.textBoxAirMin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxHumLast = new System.Windows.Forms.TextBox();
            this.textBoxHumAvg = new System.Windows.Forms.TextBox();
            this.textBoxHumMax = new System.Windows.Forms.TextBox();
            this.textBoxHumMin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonStreamStart = new System.Windows.Forms.Button();
            this.buttonStreemStop = new System.Windows.Forms.Button();
            this.labelStreemStatus = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Температура";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(128, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Тиск";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(239, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(322, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(405, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Avg";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(482, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Last";
            // 
            // textBoxTempMin
            // 
            this.textBoxTempMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTempMin.Location = new System.Drawing.Point(229, 199);
            this.textBoxTempMin.Name = "textBoxTempMin";
            this.textBoxTempMin.ReadOnly = true;
            this.textBoxTempMin.Size = new System.Drawing.Size(65, 27);
            this.textBoxTempMin.TabIndex = 9;
            // 
            // textBoxTempMax
            // 
            this.textBoxTempMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTempMax.Location = new System.Drawing.Point(312, 200);
            this.textBoxTempMax.Name = "textBoxTempMax";
            this.textBoxTempMax.ReadOnly = true;
            this.textBoxTempMax.Size = new System.Drawing.Size(65, 27);
            this.textBoxTempMax.TabIndex = 10;
            // 
            // textBoxTempAvg
            // 
            this.textBoxTempAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTempAvg.Location = new System.Drawing.Point(395, 200);
            this.textBoxTempAvg.Name = "textBoxTempAvg";
            this.textBoxTempAvg.ReadOnly = true;
            this.textBoxTempAvg.Size = new System.Drawing.Size(65, 27);
            this.textBoxTempAvg.TabIndex = 11;
            // 
            // textBoxTempLast
            // 
            this.textBoxTempLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTempLast.Location = new System.Drawing.Point(479, 200);
            this.textBoxTempLast.Name = "textBoxTempLast";
            this.textBoxTempLast.ReadOnly = true;
            this.textBoxTempLast.Size = new System.Drawing.Size(65, 27);
            this.textBoxTempLast.TabIndex = 12;
            // 
            // textBoxPresMin
            // 
            this.textBoxPresMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPresMin.Location = new System.Drawing.Point(229, 253);
            this.textBoxPresMin.Name = "textBoxPresMin";
            this.textBoxPresMin.ReadOnly = true;
            this.textBoxPresMin.Size = new System.Drawing.Size(65, 27);
            this.textBoxPresMin.TabIndex = 13;
            // 
            // textBoxPresMax
            // 
            this.textBoxPresMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPresMax.Location = new System.Drawing.Point(312, 253);
            this.textBoxPresMax.Name = "textBoxPresMax";
            this.textBoxPresMax.ReadOnly = true;
            this.textBoxPresMax.Size = new System.Drawing.Size(65, 27);
            this.textBoxPresMax.TabIndex = 14;
            // 
            // textBoxPresAvg
            // 
            this.textBoxPresAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPresAvg.Location = new System.Drawing.Point(395, 253);
            this.textBoxPresAvg.Name = "textBoxPresAvg";
            this.textBoxPresAvg.ReadOnly = true;
            this.textBoxPresAvg.Size = new System.Drawing.Size(65, 27);
            this.textBoxPresAvg.TabIndex = 15;
            // 
            // textBoxPresLast
            // 
            this.textBoxPresLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPresLast.Location = new System.Drawing.Point(479, 253);
            this.textBoxPresLast.Name = "textBoxPresLast";
            this.textBoxPresLast.ReadOnly = true;
            this.textBoxPresLast.Size = new System.Drawing.Size(65, 27);
            this.textBoxPresLast.TabIndex = 16;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // textBoxAirLast
            // 
            this.textBoxAirLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAirLast.Location = new System.Drawing.Point(478, 304);
            this.textBoxAirLast.Name = "textBoxAirLast";
            this.textBoxAirLast.ReadOnly = true;
            this.textBoxAirLast.Size = new System.Drawing.Size(65, 27);
            this.textBoxAirLast.TabIndex = 21;
            // 
            // textBoxAirAvg
            // 
            this.textBoxAirAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAirAvg.Location = new System.Drawing.Point(394, 304);
            this.textBoxAirAvg.Name = "textBoxAirAvg";
            this.textBoxAirAvg.ReadOnly = true;
            this.textBoxAirAvg.Size = new System.Drawing.Size(65, 27);
            this.textBoxAirAvg.TabIndex = 20;
            // 
            // textBoxAirMax
            // 
            this.textBoxAirMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAirMax.Location = new System.Drawing.Point(311, 304);
            this.textBoxAirMax.Name = "textBoxAirMax";
            this.textBoxAirMax.ReadOnly = true;
            this.textBoxAirMax.Size = new System.Drawing.Size(65, 27);
            this.textBoxAirMax.TabIndex = 19;
            // 
            // textBoxAirMin
            // 
            this.textBoxAirMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAirMin.Location = new System.Drawing.Point(228, 304);
            this.textBoxAirMin.Name = "textBoxAirMin";
            this.textBoxAirMin.ReadOnly = true;
            this.textBoxAirMin.Size = new System.Drawing.Size(65, 27);
            this.textBoxAirMin.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(11, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "Загазованість";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxHumLast
            // 
            this.textBoxHumLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHumLast.Location = new System.Drawing.Point(478, 354);
            this.textBoxHumLast.Name = "textBoxHumLast";
            this.textBoxHumLast.ReadOnly = true;
            this.textBoxHumLast.Size = new System.Drawing.Size(65, 27);
            this.textBoxHumLast.TabIndex = 26;
            // 
            // textBoxHumAvg
            // 
            this.textBoxHumAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHumAvg.Location = new System.Drawing.Point(394, 354);
            this.textBoxHumAvg.Name = "textBoxHumAvg";
            this.textBoxHumAvg.ReadOnly = true;
            this.textBoxHumAvg.Size = new System.Drawing.Size(65, 27);
            this.textBoxHumAvg.TabIndex = 25;
            // 
            // textBoxHumMax
            // 
            this.textBoxHumMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHumMax.Location = new System.Drawing.Point(311, 354);
            this.textBoxHumMax.Name = "textBoxHumMax";
            this.textBoxHumMax.ReadOnly = true;
            this.textBoxHumMax.Size = new System.Drawing.Size(65, 27);
            this.textBoxHumMax.TabIndex = 24;
            // 
            // textBoxHumMin
            // 
            this.textBoxHumMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHumMin.Location = new System.Drawing.Point(228, 354);
            this.textBoxHumMin.Name = "textBoxHumMin";
            this.textBoxHumMin.ReadOnly = true;
            this.textBoxHumMin.Size = new System.Drawing.Size(65, 27);
            this.textBoxHumMin.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(65, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 29);
            this.label8.TabIndex = 22;
            this.label8.Text = "Вологість";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonStreamStart
            // 
            this.buttonStreamStart.Location = new System.Drawing.Point(16, 46);
            this.buttonStreamStart.Name = "buttonStreamStart";
            this.buttonStreamStart.Size = new System.Drawing.Size(115, 29);
            this.buttonStreamStart.TabIndex = 27;
            this.buttonStreamStart.Text = "Активувати";
            this.buttonStreamStart.UseVisualStyleBackColor = true;
            this.buttonStreamStart.Click += new System.EventHandler(this.buttonStreamStart_Click);
            // 
            // buttonStreemStop
            // 
            this.buttonStreemStop.Location = new System.Drawing.Point(133, 46);
            this.buttonStreemStop.Name = "buttonStreemStop";
            this.buttonStreemStop.Size = new System.Drawing.Size(115, 29);
            this.buttonStreemStop.TabIndex = 28;
            this.buttonStreemStop.Text = "Призупинити";
            this.buttonStreemStop.UseVisualStyleBackColor = true;
            this.buttonStreemStop.Click += new System.EventHandler(this.buttonStreemStop_Click);
            // 
            // labelStreemStatus
            // 
            this.labelStreemStatus.AutoSize = true;
            this.labelStreemStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStreemStatus.ForeColor = System.Drawing.Color.Red;
            this.labelStreemStatus.Location = new System.Drawing.Point(106, 9);
            this.labelStreemStatus.Name = "labelStreemStatus";
            this.labelStreemStatus.Size = new System.Drawing.Size(127, 25);
            this.labelStreemStatus.TabIndex = 30;
            this.labelStreemStatus.Text = "Не активний";
            this.labelStreemStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(22, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 25);
            this.label9.TabIndex = 31;
            this.label9.Text = "Статус:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "WeatherAnalyzer";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(411, 12);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(133, 33);
            this.buttonShow.TabIndex = 32;
            this.buttonShow.Text = "Фоновий режим";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 419);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelStreemStatus);
            this.Controls.Add(this.buttonStreemStop);
            this.Controls.Add(this.buttonStreamStart);
            this.Controls.Add(this.textBoxHumLast);
            this.Controls.Add(this.textBoxHumAvg);
            this.Controls.Add(this.textBoxHumMax);
            this.Controls.Add(this.textBoxHumMin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxAirLast);
            this.Controls.Add(this.textBoxAirAvg);
            this.Controls.Add(this.textBoxAirMax);
            this.Controls.Add(this.textBoxAirMin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPresLast);
            this.Controls.Add(this.textBoxPresAvg);
            this.Controls.Add(this.textBoxPresMax);
            this.Controls.Add(this.textBoxPresMin);
            this.Controls.Add(this.textBoxTempLast);
            this.Controls.Add(this.textBoxTempAvg);
            this.Controls.Add(this.textBoxTempMax);
            this.Controls.Add(this.textBoxTempMin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeatherAnalyzer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTempMin;
        private System.Windows.Forms.TextBox textBoxTempMax;
        private System.Windows.Forms.TextBox textBoxTempAvg;
        private System.Windows.Forms.TextBox textBoxTempLast;
        private System.Windows.Forms.TextBox textBoxPresMin;
        private System.Windows.Forms.TextBox textBoxPresMax;
        private System.Windows.Forms.TextBox textBoxPresAvg;
        private System.Windows.Forms.TextBox textBoxPresLast;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxAirLast;
        private System.Windows.Forms.TextBox textBoxAirAvg;
        private System.Windows.Forms.TextBox textBoxAirMax;
        private System.Windows.Forms.TextBox textBoxAirMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxHumLast;
        private System.Windows.Forms.TextBox textBoxHumAvg;
        private System.Windows.Forms.TextBox textBoxHumMax;
        private System.Windows.Forms.TextBox textBoxHumMin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonStreamStart;
        private System.Windows.Forms.Button buttonStreemStop;
        private System.Windows.Forms.Label labelStreemStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button buttonShow;
    }
}

