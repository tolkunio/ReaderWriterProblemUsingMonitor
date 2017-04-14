namespace Cinematix01
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
            this.hallGrid = new System.Windows.Forms.Panel();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hallGrid
            // 
            this.hallGrid.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.hallGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hallGrid.Location = new System.Drawing.Point(12, 12);
            this.hallGrid.Name = "hallGrid";
            this.hallGrid.Size = new System.Drawing.Size(680, 409);
            this.hallGrid.TabIndex = 0;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(12, 427);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(187, 62);
            this.refreshBtn.TabIndex = 1;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 501);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.hallGrid);
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel hallGrid;
        private System.Windows.Forms.Button refreshBtn;
    }
}

