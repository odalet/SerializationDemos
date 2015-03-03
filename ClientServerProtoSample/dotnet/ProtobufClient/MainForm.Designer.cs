namespace ProtobufClient
{
    partial class MainForm
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
            this.invokeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.logbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // invokeButton
            // 
            this.invokeButton.Location = new System.Drawing.Point(12, 12);
            this.invokeButton.Name = "invokeButton";
            this.invokeButton.Size = new System.Drawing.Size(75, 23);
            this.invokeButton.TabIndex = 0;
            this.invokeButton.Text = "Invoke";
            this.invokeButton.UseVisualStyleBackColor = true;
            this.invokeButton.Click += new System.EventHandler(this.invokeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(93, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // logbox
            // 
            this.logbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logbox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logbox.Location = new System.Drawing.Point(12, 41);
            this.logbox.Multiline = true;
            this.logbox.Name = "logbox";
            this.logbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logbox.Size = new System.Drawing.Size(745, 426);
            this.logbox.TabIndex = 1;
            this.logbox.WordWrap = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 479);
            this.Controls.Add(this.logbox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.invokeButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Protobuf Test Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button invokeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox logbox;
    }
}

