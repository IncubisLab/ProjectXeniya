namespace TwilioWinForms
{
    partial class ButtonChat
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
            this.labelCha = new System.Windows.Forms.Label();
            this.pictureChat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureChat)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCha
            // 
            this.labelCha.AutoSize = true;
            this.labelCha.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCha.Location = new System.Drawing.Point(95, 15);
            this.labelCha.Name = "labelCha";
            this.labelCha.Size = new System.Drawing.Size(41, 19);
            this.labelCha.TabIndex = 0;
            this.labelCha.Text = "Чат";
            this.labelCha.Click += new System.EventHandler(this.labelCha_Click);
            // 
            // pictureChat
            // 
            this.pictureChat.Image = global::TwilioWinForms.Properties.Resources.Balloon2;
            this.pictureChat.Location = new System.Drawing.Point(3, 3);
            this.pictureChat.Name = "pictureChat";
            this.pictureChat.Size = new System.Drawing.Size(45, 45);
            this.pictureChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureChat.TabIndex = 1;
            this.pictureChat.TabStop = false;
            this.pictureChat.Click += new System.EventHandler(this.pictureChat_Click);
            // 
            // ButtonChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureChat);
            this.Controls.Add(this.labelCha);
            this.Name = "ButtonChat";
            this.Size = new System.Drawing.Size(211, 52);
            this.Click += new System.EventHandler(this.ButtonChat_Click);
            this.MouseLeave += new System.EventHandler(this.ButtonChat_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureChat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCha;
        private System.Windows.Forms.PictureBox pictureChat;
    }
}
