
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.connectBtn = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.deviceId = new System.Windows.Forms.Label();
            this.deviceIdBox = new System.Windows.Forms.TextBox();
            this.deviceIdSetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(12, 12);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(282, 50);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(12, 87);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(58, 12);
            this.message.TabIndex = 1;
            this.message.Text = "message";
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(76, 84);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(133, 21);
            this.messageBox.TabIndex = 3;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(219, 82);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 4;
            this.sendBtn.Text = "send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // deviceId
            // 
            this.deviceId.AutoSize = true;
            this.deviceId.Location = new System.Drawing.Point(14, 116);
            this.deviceId.Name = "deviceId";
            this.deviceId.Size = new System.Drawing.Size(52, 12);
            this.deviceId.TabIndex = 5;
            this.deviceId.Text = "deviceId";
            // 
            // deviceIdBox
            // 
            this.deviceIdBox.Location = new System.Drawing.Point(76, 112);
            this.deviceIdBox.Name = "deviceIdBox";
            this.deviceIdBox.Size = new System.Drawing.Size(133, 21);
            this.deviceIdBox.TabIndex = 6;
            // 
            // deviceIdSetBtn
            // 
            this.deviceIdSetBtn.Location = new System.Drawing.Point(219, 110);
            this.deviceIdSetBtn.Name = "deviceIdSetBtn";
            this.deviceIdSetBtn.Size = new System.Drawing.Size(75, 23);
            this.deviceIdSetBtn.TabIndex = 7;
            this.deviceIdSetBtn.Text = "set";
            this.deviceIdSetBtn.UseVisualStyleBackColor = true;
            this.deviceIdSetBtn.Click += new System.EventHandler(this.deviceIdSetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 159);
            this.Controls.Add(this.deviceIdSetBtn);
            this.Controls.Add(this.deviceIdBox);
            this.Controls.Add(this.deviceId);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.message);
            this.Controls.Add(this.connectBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label deviceId;
        private System.Windows.Forms.TextBox deviceIdBox;
        private System.Windows.Forms.Button deviceIdSetBtn;
    }
}

