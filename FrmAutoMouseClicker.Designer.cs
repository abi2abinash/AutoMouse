namespace MouseClicker
{
    partial class FrmAutoMouseClicker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutoMouseClicker));
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.btnStartToCapture = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxSpecifyClickPoint = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBoxClickOptions = new System.Windows.Forms.GroupBox();
            this.cmbMouseAction = new System.Windows.Forms.ComboBox();
            this.cmbMouseButton = new System.Windows.Forms.ComboBox();
            this.lblMouseAction = new System.Windows.Forms.Label();
            this.lblMouseButton = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBoxClickInterval = new System.Windows.Forms.GroupBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.groupBoxStopOptions = new System.Windows.Forms.GroupBox();
            this.lbltimes = new System.Windows.Forms.Label();
            this.txtRepeatTimes = new System.Windows.Forms.TextBox();
            this.rbStoptillRepeat = new System.Windows.Forms.RadioButton();
            this.rBStoptillcommand = new System.Windows.Forms.RadioButton();
            this.lblMouseClicked = new System.Windows.Forms.Label();
            this.lblMouseClickedCount = new System.Windows.Forms.Label();
            this.groupBoxClickPoint = new System.Windows.Forms.GroupBox();
            this.rbClickOnFixedPont = new System.Windows.Forms.RadioButton();
            this.rbClickWhereMouse = new System.Windows.Forms.RadioButton();
            this.groupBoxSpecifyClickPoint.SuspendLayout();
            this.groupBoxClickOptions.SuspendLayout();
            this.groupBoxClickInterval.SuspendLayout();
            this.groupBoxStopOptions.SuspendLayout();
            this.groupBoxClickPoint.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(104, 21);
            this.txtX.Name = "txtX";
            this.txtX.ReadOnly = true;
            this.txtX.Size = new System.Drawing.Size(62, 21);
            this.txtX.TabIndex = 0;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(103, 57);
            this.txtY.Name = "txtY";
            this.txtY.ReadOnly = true;
            this.txtY.Size = new System.Drawing.Size(62, 21);
            this.txtY.TabIndex = 1;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.ForeColor = System.Drawing.Color.Blue;
            this.lblX.Location = new System.Drawing.Point(83, 24);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(18, 15);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "X:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.ForeColor = System.Drawing.Color.Blue;
            this.lblY.Location = new System.Drawing.Point(82, 60);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 15);
            this.lblY.TabIndex = 3;
            this.lblY.Text = "Y:";
            // 
            // btnStartToCapture
            // 
            this.btnStartToCapture.ForeColor = System.Drawing.Color.Blue;
            this.btnStartToCapture.Location = new System.Drawing.Point(8, 21);
            this.btnStartToCapture.Name = "btnStartToCapture";
            this.btnStartToCapture.Size = new System.Drawing.Size(72, 57);
            this.btnStartToCapture.TabIndex = 4;
            this.btnStartToCapture.Text = "Start to capture point";
            this.btnStartToCapture.UseVisualStyleBackColor = true;
            this.btnStartToCapture.Click += new System.EventHandler(this.btnStartToCapture_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // groupBoxSpecifyClickPoint
            // 
            this.groupBoxSpecifyClickPoint.Controls.Add(this.label1);
            this.groupBoxSpecifyClickPoint.Controls.Add(this.lblX);
            this.groupBoxSpecifyClickPoint.Controls.Add(this.btnStartToCapture);
            this.groupBoxSpecifyClickPoint.Controls.Add(this.txtX);
            this.groupBoxSpecifyClickPoint.Controls.Add(this.lblY);
            this.groupBoxSpecifyClickPoint.Controls.Add(this.txtY);
            this.groupBoxSpecifyClickPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSpecifyClickPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBoxSpecifyClickPoint.Location = new System.Drawing.Point(12, 61);
            this.groupBoxSpecifyClickPoint.Name = "groupBoxSpecifyClickPoint";
            this.groupBoxSpecifyClickPoint.Size = new System.Drawing.Size(172, 106);
            this.groupBoxSpecifyClickPoint.TabIndex = 5;
            this.groupBoxSpecifyClickPoint.TabStop = false;
            this.groupBoxSpecifyClickPoint.Text = "Specify Click Point";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(4, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Press any key to stop capture";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.ForeColor = System.Drawing.Color.Blue;
            this.lblSeconds.Location = new System.Drawing.Point(145, 20);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(49, 13);
            this.lblSeconds.TabIndex = 7;
            this.lblSeconds.Text = "Seconds";
            // 
            // txtSeconds
            // 
            this.txtSeconds.Location = new System.Drawing.Point(148, 36);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(46, 20);
            this.txtSeconds.TabIndex = 6;
            this.txtSeconds.Text = "5";
            // 
            // btnStop
            // 
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(176, 266);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(87, 47);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.ForeColor = System.Drawing.Color.Green;
            this.btnStart.Location = new System.Drawing.Point(36, 266);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(87, 47);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBoxClickOptions
            // 
            this.groupBoxClickOptions.Controls.Add(this.cmbMouseAction);
            this.groupBoxClickOptions.Controls.Add(this.cmbMouseButton);
            this.groupBoxClickOptions.Controls.Add(this.lblMouseAction);
            this.groupBoxClickOptions.Controls.Add(this.lblMouseButton);
            this.groupBoxClickOptions.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxClickOptions.Location = new System.Drawing.Point(211, 21);
            this.groupBoxClickOptions.Name = "groupBoxClickOptions";
            this.groupBoxClickOptions.Size = new System.Drawing.Size(206, 93);
            this.groupBoxClickOptions.TabIndex = 9;
            this.groupBoxClickOptions.TabStop = false;
            this.groupBoxClickOptions.Text = "Click Options";
            // 
            // cmbMouseAction
            // 
            this.cmbMouseAction.FormattingEnabled = true;
            this.cmbMouseAction.Items.AddRange(new object[] {
            "Single Click",
            "Double Click"});
            this.cmbMouseAction.Location = new System.Drawing.Point(85, 48);
            this.cmbMouseAction.Name = "cmbMouseAction";
            this.cmbMouseAction.Size = new System.Drawing.Size(109, 21);
            this.cmbMouseAction.TabIndex = 3;
            // 
            // cmbMouseButton
            // 
            this.cmbMouseButton.FormattingEnabled = true;
            this.cmbMouseButton.Items.AddRange(new object[] {
            "Left Button",
            "Right Button"});
            this.cmbMouseButton.Location = new System.Drawing.Point(85, 17);
            this.cmbMouseButton.Name = "cmbMouseButton";
            this.cmbMouseButton.Size = new System.Drawing.Size(109, 21);
            this.cmbMouseButton.TabIndex = 2;
            // 
            // lblMouseAction
            // 
            this.lblMouseAction.AutoSize = true;
            this.lblMouseAction.Location = new System.Drawing.Point(6, 51);
            this.lblMouseAction.Name = "lblMouseAction";
            this.lblMouseAction.Size = new System.Drawing.Size(72, 13);
            this.lblMouseAction.TabIndex = 1;
            this.lblMouseAction.Text = "Mouse Action";
            // 
            // lblMouseButton
            // 
            this.lblMouseButton.AutoSize = true;
            this.lblMouseButton.Location = new System.Drawing.Point(6, 20);
            this.lblMouseButton.Name = "lblMouseButton";
            this.lblMouseButton.Size = new System.Drawing.Size(73, 13);
            this.lblMouseButton.TabIndex = 0;
            this.lblMouseButton.Text = "Mouse Button";
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(307, 267);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 47);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBoxClickInterval
            // 
            this.groupBoxClickInterval.Controls.Add(this.txtHours);
            this.groupBoxClickInterval.Controls.Add(this.txtMinutes);
            this.groupBoxClickInterval.Controls.Add(this.lblMinutes);
            this.groupBoxClickInterval.Controls.Add(this.txtSeconds);
            this.groupBoxClickInterval.Controls.Add(this.lblSeconds);
            this.groupBoxClickInterval.Controls.Add(this.lblHours);
            this.groupBoxClickInterval.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxClickInterval.Location = new System.Drawing.Point(211, 115);
            this.groupBoxClickInterval.Name = "groupBoxClickInterval";
            this.groupBoxClickInterval.Size = new System.Drawing.Size(206, 79);
            this.groupBoxClickInterval.TabIndex = 10;
            this.groupBoxClickInterval.TabStop = false;
            this.groupBoxClickInterval.Text = "Click Interval";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(32, 38);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(46, 20);
            this.txtHours.TabIndex = 10;
            this.txtHours.Text = "0";
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(88, 38);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(46, 20);
            this.txtMinutes.TabIndex = 9;
            this.txtMinutes.Text = "0";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.ForeColor = System.Drawing.Color.Blue;
            this.lblMinutes.Location = new System.Drawing.Point(85, 20);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(44, 13);
            this.lblMinutes.TabIndex = 8;
            this.lblMinutes.Text = "Minutes";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(34, 20);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(35, 13);
            this.lblHours.TabIndex = 0;
            this.lblHours.Text = "Hours";
            // 
            // groupBoxStopOptions
            // 
            this.groupBoxStopOptions.Controls.Add(this.lbltimes);
            this.groupBoxStopOptions.Controls.Add(this.txtRepeatTimes);
            this.groupBoxStopOptions.Controls.Add(this.rbStoptillRepeat);
            this.groupBoxStopOptions.Controls.Add(this.rBStoptillcommand);
            this.groupBoxStopOptions.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxStopOptions.Location = new System.Drawing.Point(5, 196);
            this.groupBoxStopOptions.Name = "groupBoxStopOptions";
            this.groupBoxStopOptions.Size = new System.Drawing.Size(412, 51);
            this.groupBoxStopOptions.TabIndex = 11;
            this.groupBoxStopOptions.TabStop = false;
            this.groupBoxStopOptions.Text = "Stop Options";
            // 
            // lbltimes
            // 
            this.lbltimes.AutoSize = true;
            this.lbltimes.Location = new System.Drawing.Point(296, 20);
            this.lbltimes.Name = "lbltimes";
            this.lbltimes.Size = new System.Drawing.Size(31, 13);
            this.lbltimes.TabIndex = 3;
            this.lbltimes.Text = "times";
            // 
            // txtRepeatTimes
            // 
            this.txtRepeatTimes.Location = new System.Drawing.Point(255, 16);
            this.txtRepeatTimes.Name = "txtRepeatTimes";
            this.txtRepeatTimes.Size = new System.Drawing.Size(36, 20);
            this.txtRepeatTimes.TabIndex = 2;
            this.txtRepeatTimes.Text = "5";
            // 
            // rbStoptillRepeat
            // 
            this.rbStoptillRepeat.AutoSize = true;
            this.rbStoptillRepeat.Location = new System.Drawing.Point(159, 19);
            this.rbStoptillRepeat.Name = "rbStoptillRepeat";
            this.rbStoptillRepeat.Size = new System.Drawing.Size(97, 17);
            this.rbStoptillRepeat.TabIndex = 1;
            this.rbStoptillRepeat.TabStop = true;
            this.rbStoptillRepeat.Text = "Stop till Repeat";
            this.rbStoptillRepeat.UseVisualStyleBackColor = true;
            // 
            // rBStoptillcommand
            // 
            this.rBStoptillcommand.AutoSize = true;
            this.rBStoptillcommand.Location = new System.Drawing.Point(22, 20);
            this.rBStoptillcommand.Name = "rBStoptillcommand";
            this.rBStoptillcommand.Size = new System.Drawing.Size(126, 17);
            this.rBStoptillcommand.TabIndex = 0;
            this.rBStoptillcommand.TabStop = true;
            this.rBStoptillcommand.Text = "Stop till get command";
            this.rBStoptillcommand.UseVisualStyleBackColor = true;
            // 
            // lblMouseClicked
            // 
            this.lblMouseClicked.AutoSize = true;
            this.lblMouseClicked.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMouseClicked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMouseClicked.ForeColor = System.Drawing.Color.Yellow;
            this.lblMouseClicked.Location = new System.Drawing.Point(143, 2);
            this.lblMouseClicked.Name = "lblMouseClicked";
            this.lblMouseClicked.Size = new System.Drawing.Size(103, 16);
            this.lblMouseClicked.TabIndex = 12;
            this.lblMouseClicked.Text = "Mouse Clicked :";
            // 
            // lblMouseClickedCount
            // 
            this.lblMouseClickedCount.AutoSize = true;
            this.lblMouseClickedCount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMouseClickedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMouseClickedCount.ForeColor = System.Drawing.Color.Yellow;
            this.lblMouseClickedCount.Location = new System.Drawing.Point(248, 2);
            this.lblMouseClickedCount.Name = "lblMouseClickedCount";
            this.lblMouseClickedCount.Size = new System.Drawing.Size(13, 16);
            this.lblMouseClickedCount.TabIndex = 13;
            this.lblMouseClickedCount.Text = "*";
            // 
            // groupBoxClickPoint
            // 
            this.groupBoxClickPoint.Controls.Add(this.rbClickOnFixedPont);
            this.groupBoxClickPoint.Controls.Add(this.rbClickWhereMouse);
            this.groupBoxClickPoint.Controls.Add(this.groupBoxSpecifyClickPoint);
            this.groupBoxClickPoint.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxClickPoint.Location = new System.Drawing.Point(5, 19);
            this.groupBoxClickPoint.Name = "groupBoxClickPoint";
            this.groupBoxClickPoint.Size = new System.Drawing.Size(197, 175);
            this.groupBoxClickPoint.TabIndex = 14;
            this.groupBoxClickPoint.TabStop = false;
            this.groupBoxClickPoint.Text = "Click Point";
            // 
            // rbClickOnFixedPont
            // 
            this.rbClickOnFixedPont.AutoSize = true;
            this.rbClickOnFixedPont.Location = new System.Drawing.Point(12, 38);
            this.rbClickOnFixedPont.Name = "rbClickOnFixedPont";
            this.rbClickOnFixedPont.Size = new System.Drawing.Size(129, 17);
            this.rbClickOnFixedPont.TabIndex = 6;
            this.rbClickOnFixedPont.TabStop = true;
            this.rbClickOnFixedPont.Text = "Click On a Fixed Point";
            this.rbClickOnFixedPont.UseVisualStyleBackColor = true;
            this.rbClickOnFixedPont.Click += new System.EventHandler(this.rbClickOnFixedPont_Click);
            // 
            // rbClickWhereMouse
            // 
            this.rbClickWhereMouse.AutoSize = true;
            this.rbClickWhereMouse.Location = new System.Drawing.Point(12, 15);
            this.rbClickWhereMouse.Name = "rbClickWhereMouse";
            this.rbClickWhereMouse.Size = new System.Drawing.Size(142, 17);
            this.rbClickWhereMouse.TabIndex = 4;
            this.rbClickWhereMouse.TabStop = true;
            this.rbClickWhereMouse.Text = "Click where the mouse is";
            this.rbClickWhereMouse.UseVisualStyleBackColor = true;
            this.rbClickWhereMouse.Click += new System.EventHandler(this.rbClickWhereMouse_Click);
            // 
            // FrmAutoMouseClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(430, 331);
            this.Controls.Add(this.groupBoxClickPoint);
            this.Controls.Add(this.lblMouseClickedCount);
            this.Controls.Add(this.lblMouseClicked);
            this.Controls.Add(this.groupBoxStopOptions);
            this.Controls.Add(this.groupBoxClickInterval);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBoxClickOptions);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAutoMouseClicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mouse Auto Clicker-Tom";
            this.Load += new System.EventHandler(this.FrmMouseClicker_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmMouseClicker_KeyPress);
            this.groupBoxSpecifyClickPoint.ResumeLayout(false);
            this.groupBoxSpecifyClickPoint.PerformLayout();
            this.groupBoxClickOptions.ResumeLayout(false);
            this.groupBoxClickOptions.PerformLayout();
            this.groupBoxClickInterval.ResumeLayout(false);
            this.groupBoxClickInterval.PerformLayout();
            this.groupBoxStopOptions.ResumeLayout(false);
            this.groupBoxStopOptions.PerformLayout();
            this.groupBoxClickPoint.ResumeLayout(false);
            this.groupBoxClickPoint.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Button btnStartToCapture;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBoxSpecifyClickPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBoxClickOptions;
        private System.Windows.Forms.Label lblMouseButton;
        private System.Windows.Forms.ComboBox cmbMouseAction;
        private System.Windows.Forms.ComboBox cmbMouseButton;
        private System.Windows.Forms.Label lblMouseAction;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBoxClickInterval;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.GroupBox groupBoxStopOptions;
        private System.Windows.Forms.RadioButton rbStoptillRepeat;
        private System.Windows.Forms.RadioButton rBStoptillcommand;
        private System.Windows.Forms.TextBox txtRepeatTimes;
        private System.Windows.Forms.Label lbltimes;
        private System.Windows.Forms.Label lblMouseClicked;
        private System.Windows.Forms.Label lblMouseClickedCount;
        private System.Windows.Forms.GroupBox groupBoxClickPoint;
        private System.Windows.Forms.RadioButton rbClickOnFixedPont;
        private System.Windows.Forms.RadioButton rbClickWhereMouse;
    }
}

