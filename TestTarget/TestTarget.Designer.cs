namespace TestTarget
{
    partial class TestTarget
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.execute_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.result_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // execute_button
            // 
            this.execute_button.Location = new System.Drawing.Point(24, 22);
            this.execute_button.Name = "execute_button";
            this.execute_button.Size = new System.Drawing.Size(97, 38);
            this.execute_button.TabIndex = 0;
            this.execute_button.Text = "Execute";
            this.execute_button.UseVisualStyleBackColor = true;
            this.execute_button.Click += new System.EventHandler(this.Execute_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status";
            // 
            // result_textBox
            // 
            this.result_textBox.Location = new System.Drawing.Point(12, 116);
            this.result_textBox.Name = "result_textBox";
            this.result_textBox.Size = new System.Drawing.Size(144, 25);
            this.result_textBox.TabIndex = 2;
            // 
            // TestTarget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 170);
            this.Controls.Add(this.result_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.execute_button);
            this.Name = "TestTarget";
            this.Text = "TestTarget";
            this.Load += new System.EventHandler(this.TestTarget_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button execute_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox result_textBox;
    }
}

