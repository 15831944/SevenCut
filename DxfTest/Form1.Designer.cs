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
            this.listBoxLwPolylines = new System.Windows.Forms.ListBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.listBoxLwVertices = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenDxf
            // 
            this.buttonOpenDxf.Location = new System.Drawing.Point(8, 8);
            this.buttonOpenDxf.Name = "buttonOpenDxf";
            this.buttonOpenDxf.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenDxf.TabIndex = 0;
            this.buttonOpenDxf.Text = "Open Dxf";
            this.buttonOpenDxf.UseVisualStyleBackColor = true;
            this.buttonOpenDxf.Click += new System.EventHandler(this.buttonOpenDxf_Click);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxMain.Location = new System.Drawing.Point(296, 8);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(776, 744);
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
            this.labelStats.Location = new System.Drawing.Point(8, 40);
            this.labelStats.Name = "labelStats";
            this.labelStats.Size = new System.Drawing.Size(31, 13);
            this.labelStats.TabIndex = 2;
            this.labelStats.Text = "Stats";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(88, 16);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(34, 13);
            this.labelCost.TabIndex = 3;
            this.labelCost.Text = "Cost: ";
            // 
            // trackBarAmount
            // 
            this.trackBarAmount.Location = new System.Drawing.Point(8, 64);
            this.trackBarAmount.Name = "trackBarAmount";
            this.trackBarAmount.Size = new System.Drawing.Size(280, 45);
            this.trackBarAmount.TabIndex = 4;
            this.trackBarAmount.Scroll += new System.EventHandler(this.trackBarAmount_Scroll);
            // 
            // listBoxLwPolylines
            // 
            this.listBoxLwPolylines.FormattingEnabled = true;
            this.listBoxLwPolylines.Location = new System.Drawing.Point(16, 120);
            this.listBoxLwPolylines.Name = "listBoxLwPolylines";
            this.listBoxLwPolylines.Size = new System.Drawing.Size(264, 69);
            this.listBoxLwPolylines.TabIndex = 5;
            this.listBoxLwPolylines.SelectedIndexChanged += new System.EventHandler(this.listBoxLwPolylines_SelectedIndexChanged);
            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(16, 272);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(264, 456);
            this.labelInfo.TabIndex = 6;
            this.labelInfo.Text = "labelInfo";
            // 
            // listBoxLwVertices
            // 
            this.listBoxLwVertices.FormattingEnabled = true;
            this.listBoxLwVertices.Location = new System.Drawing.Point(16, 192);
            this.listBoxLwVertices.Name = "listBoxLwVertices";
            this.listBoxLwVertices.Size = new System.Drawing.Size(264, 69);
            this.listBoxLwVertices.TabIndex = 7;
            this.listBoxLwVertices.SelectedIndexChanged += new System.EventHandler(this.listBoxLwVertices_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 762);
            this.Controls.Add(this.listBoxLwVertices);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.listBoxLwPolylines);
            this.Controls.Add(this.trackBarAmount);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelStats);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.buttonOpenDxf);
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
        private System.Windows.Forms.ListBox listBoxLwPolylines;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ListBox listBoxLwVertices;
    }
}

