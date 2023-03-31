namespace WA_Gacha_V2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonInput = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.buttonRefund = new System.Windows.Forms.Button();
            this.buttonShipped = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInput
            // 
            this.buttonInput.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonInput.Location = new System.Drawing.Point(770, 68);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(100, 39);
            this.buttonInput.TabIndex = 0;
            this.buttonInput.Text = "投幣";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(83, 68);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(648, 29);
            this.textBoxInput.TabIndex = 1;
            this.textBoxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxState
            // 
            this.textBoxState.Location = new System.Drawing.Point(79, 140);
            this.textBoxState.Multiline = true;
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(652, 189);
            this.textBoxState.TabIndex = 2;
            // 
            // buttonRefund
            // 
            this.buttonRefund.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonRefund.Location = new System.Drawing.Point(511, 360);
            this.buttonRefund.Name = "buttonRefund";
            this.buttonRefund.Size = new System.Drawing.Size(100, 39);
            this.buttonRefund.TabIndex = 3;
            this.buttonRefund.Text = "退幣";
            this.buttonRefund.UseVisualStyleBackColor = true;
            this.buttonRefund.Click += new System.EventHandler(this.buttonRefund_Click);
            // 
            // buttonShipped
            // 
            this.buttonShipped.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonShipped.Location = new System.Drawing.Point(631, 360);
            this.buttonShipped.Name = "buttonShipped";
            this.buttonShipped.Size = new System.Drawing.Size(100, 39);
            this.buttonShipped.TabIndex = 4;
            this.buttonShipped.Text = "出貨";
            this.buttonShipped.UseVisualStyleBackColor = true;
            this.buttonShipped.Click += new System.EventHandler(this.buttonShipped_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 439);
            this.Controls.Add(this.buttonShipped);
            this.Controls.Add(this.buttonRefund);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.Button buttonRefund;
        private System.Windows.Forms.Button buttonShipped;
    }
}

