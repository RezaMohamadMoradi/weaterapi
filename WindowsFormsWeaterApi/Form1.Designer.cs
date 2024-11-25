namespace WindowsFormsWeaterApi
{
    partial class Form1
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
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnGetWeather = new System.Windows.Forms.Button();
            this.lblWeatherInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(218, 57);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(188, 22);
            this.txtCity.TabIndex = 0;
            this.txtCity.Text = "نام شهر : Tehran...";
            this.txtCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGetWeather
            // 
            this.btnGetWeather.Location = new System.Drawing.Point(218, 119);
            this.btnGetWeather.Name = "btnGetWeather";
            this.btnGetWeather.Size = new System.Drawing.Size(185, 23);
            this.btnGetWeather.TabIndex = 1;
            this.btnGetWeather.Text = "برای نمایش دما کلیک کنید";
            this.btnGetWeather.UseVisualStyleBackColor = true;
            this.btnGetWeather.Click += new System.EventHandler(this.btnGetWeather_Click_1);
            // 
            // lblWeatherInfo
            // 
            this.lblWeatherInfo.AutoSize = true;
            this.lblWeatherInfo.Location = new System.Drawing.Point(215, 167);
            this.lblWeatherInfo.Name = "lblWeatherInfo";
            this.lblWeatherInfo.Size = new System.Drawing.Size(44, 16);
            this.lblWeatherInfo.TabIndex = 2;
            this.lblWeatherInfo.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 438);
            this.Controls.Add(this.lblWeatherInfo);
            this.Controls.Add(this.btnGetWeather);
            this.Controls.Add(this.txtCity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnGetWeather;
        private System.Windows.Forms.Label lblWeatherInfo;
    }
}

