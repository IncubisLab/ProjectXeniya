namespace TwilioWinForms
{
    partial class TwilioSmS
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
            this.textNumber = new System.Windows.Forms.TextBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.butSend = new System.Windows.Forms.Button();
            this.labelmessage = new System.Windows.Forms.Label();
            this.labelline = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelline2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textNumber
            // 
            this.textNumber.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textNumber.Location = new System.Drawing.Point(32, 101);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(400, 29);
            this.textNumber.TabIndex = 0;
            // 
            // textMessage
            // 
            this.textMessage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textMessage.Location = new System.Drawing.Point(32, 174);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(400, 160);
            this.textMessage.TabIndex = 1;
            // 
            // butSend
            // 
            this.butSend.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSend.Location = new System.Drawing.Point(158, 340);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(128, 31);
            this.butSend.TabIndex = 2;
            this.butSend.Text = "Отправить";
            this.butSend.UseVisualStyleBackColor = true;
            this.butSend.Click += new System.EventHandler(this.butSend_Click);
            // 
            // labelmessage
            // 
            this.labelmessage.AutoSize = true;
            this.labelmessage.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelmessage.Location = new System.Drawing.Point(96, 20);
            this.labelmessage.Name = "labelmessage";
            this.labelmessage.Size = new System.Drawing.Size(273, 24);
            this.labelmessage.TabIndex = 3;
            this.labelmessage.Text = "Написать сообщение врачу!";
            // 
            // labelline
            // 
            this.labelline.AutoSize = true;
            this.labelline.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelline.Location = new System.Drawing.Point(-4, 76);
            this.labelline.Name = "labelline";
            this.labelline.Size = new System.Drawing.Size(580, 22);
            this.labelline.TabIndex = 4;
            this.labelline.Text = "_________________________________________________________";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumber.Location = new System.Drawing.Point(3, 68);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(128, 19);
            this.labelNumber.TabIndex = 5;
            this.labelNumber.Text = "Номер телефона";
            // 
            // labelline2
            // 
            this.labelline2.AutoSize = true;
            this.labelline2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelline2.Location = new System.Drawing.Point(-4, 145);
            this.labelline2.Name = "labelline2";
            this.labelline2.Size = new System.Drawing.Size(580, 22);
            this.labelline2.TabIndex = 6;
            this.labelline2.Text = "_________________________________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Текст сообщения";
            // 
            // TwilioSmS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelline2);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelline);
            this.Controls.Add(this.labelmessage);
            this.Controls.Add(this.butSend);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.textNumber);
            this.Name = "TwilioSmS";
            this.Size = new System.Drawing.Size(484, 374);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Button butSend;
        private System.Windows.Forms.Label labelmessage;
        private System.Windows.Forms.Label labelline;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelline2;
        private System.Windows.Forms.Label label1;
    }
}
