namespace DxfTest
{
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenDxf = new System.Windows.Forms.Button();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.labelStats = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.trackBarAmount = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenDxf
            // 
            this.buttonOpenDxf.Location = new System.Drawing.Point(9, 9);
            this.buttonOpenDxf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonOpenDxf.Name = "buttonOpenDxf";
            this.buttonOpenDxf.Size = new System.Drawing.Size(88, 27);
            this.buttonOpenDxf.TabIndex = 0;
            this.buttonOpenDxf.Text = "Open Dxf";
            this.buttonOpenDxf.UseVisualStyleBackColor = true;
            this.buttonOpenDxf.Click += new System.EventHandler(this.buttonOpenDxf_Click);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxMain.Location = new System.Drawing.Point(345, 9);
            this.pictureBoxMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(905, 858);
            this.pictureBoxMain.TabIndex = 1;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxMain_Paint);
            this.pictureBoxMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseDown);
            this.pictureBoxMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseMove);
            this.pictureBoxMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseUp);
            this.pictureBoxMain.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pictureBoxMain_PreviewKeyDown);
            // 
            // labelStats
            // 
            this.labelStats.AutoSize = true;
            this.labelStats.Location = new System.Drawing.Point(9, 46);
            this.labelStats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStats.Name = "labelStats";
            this.labelStats.Size = new System.Drawing.Size(32, 15);
            this.labelStats.TabIndex = 2;
            this.labelStats.Text = "Stats";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(103, 18);
            this.labelCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(37, 15);
            this.labelCost.TabIndex = 3;
            this.labelCost.Text = "Cost: ";
            // 
            // trackBarAmount
            // 
            this.trackBarAmount.Location = new System.Drawing.Point(40, 128);
            this.trackBarAmount.Name = "trackBarAmount";
            this.trackBarAmount.Size = new System.Drawing.Size(272, 45);
            this.trackBarAmount.TabIndex = 4;
            this.trackBarAmount.Scroll += new System.EventHandler(this.trackBarAmount_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 879);
            this.Controls.Add(this.trackBarAmount);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelStats);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.buttonOpenDxf);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenDxf;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Label labelStats;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.TrackBar trackBarAmount;
    }
}

