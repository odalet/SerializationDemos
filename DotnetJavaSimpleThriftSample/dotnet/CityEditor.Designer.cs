namespace ThriftSample
{
    partial class CityEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ccBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.isEnabledBox = new System.Windows.Forms.CheckBox();
            this.displayOrderBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.displayOrderBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Country Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // ccBox
            // 
            this.ccBox.Location = new System.Drawing.Point(82, 55);
            this.ccBox.Name = "ccBox";
            this.ccBox.Size = new System.Drawing.Size(71, 20);
            this.ccBox.TabIndex = 4;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(82, 29);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(120, 20);
            this.nameBox.TabIndex = 2;
            // 
            // isEnabledBox
            // 
            this.isEnabledBox.AutoSize = true;
            this.isEnabledBox.Location = new System.Drawing.Point(82, 81);
            this.isEnabledBox.Name = "isEnabledBox";
            this.isEnabledBox.Size = new System.Drawing.Size(71, 17);
            this.isEnabledBox.TabIndex = 5;
            this.isEnabledBox.Text = "Enabled?";
            this.isEnabledBox.UseVisualStyleBackColor = true;
            // 
            // displayOrderBox
            // 
            this.displayOrderBox.Location = new System.Drawing.Point(82, 104);
            this.displayOrderBox.Name = "displayOrderBox";
            this.displayOrderBox.Size = new System.Drawing.Size(120, 20);
            this.displayOrderBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Display Order:";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(82, 3);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(120, 20);
            this.idBox.TabIndex = 0;
            // 
            // CityEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.displayOrderBox);
            this.Controls.Add(this.isEnabledBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ccBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "CityEditor";
            this.Size = new System.Drawing.Size(211, 130);
            ((System.ComponentModel.ISupportInitialize)(this.displayOrderBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ccBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.CheckBox isEnabledBox;
        private System.Windows.Forms.NumericUpDown displayOrderBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown idBox;
    }
}
