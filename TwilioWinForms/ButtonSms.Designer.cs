namespace TwilioWinForms
{
    partial class ButtonSms
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelsms = new System.Windows.Forms.Label();
            this.pictureSMS = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSMS)).BeginInit();
            this.SuspendLayout();
            // 
            // labelsms
            // 
            this.labelsms.AutoSize = true;
            this.labelsms.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelsms.Location = new System.Drawing.Point(61, 15);
            this.labelsms.Name = "labelsms";
            this.labelsms.Size = new System.Drawing.Size(144, 22);
            this.labelsms.TabIndex = 1;
            this.labelsms.Text = "Написать SMS";
            this.labelsms.Click += new System.EventHandler(this.labelsms_Click);
            // 
            // pictureSMS
            // 
            this.pictureSMS.Image = global::TwilioWinForms.Properties.Resources.Message;
            this.pictureSMS.Location = new System.Drawing.Point(3, 3);
            this.pictureSMS.Name = "pictureSMS";
            this.pictureSMS.Size = new System.Drawing.Size(51, 46);
            this.pictureSMS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSMS.TabIndex = 0;
            this.pictureSMS.TabStop = false;
            this.pictureSMS.Click += new System.EventHandler(this.pictureSMS_Click);
            // 
            // ButtonSms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelsms);
            this.Controls.Add(this.pictureSMS);
            this.Name = "ButtonSms";
            this.Size = new System.Drawing.Size(211, 52);
            this.Click += new System.EventHandler(this.ButtonSms_Click);
            this.MouseLeave += new System.EventHandler(this.ButtonSms_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSMS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureSMS;
        private System.Windows.Forms.Label labelsms;
    }
}
