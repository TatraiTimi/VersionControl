namespace aqefte_week06
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.button_Car = new System.Windows.Forms.Button();
            this.buttonBall = new System.Windows.Forms.Button();
            this.lable_Next = new System.Windows.Forms.Label();
            this.buttonColor = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.Controls.Add(this.buttonColor);
            this.mainPanel.Controls.Add(this.lable_Next);
            this.mainPanel.Controls.Add(this.buttonBall);
            this.mainPanel.Controls.Add(this.button_Car);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(776, 426);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // button_Car
            // 
            this.button_Car.Location = new System.Drawing.Point(29, 27);
            this.button_Car.Name = "button_Car";
            this.button_Car.Size = new System.Drawing.Size(75, 23);
            this.button_Car.TabIndex = 0;
            this.button_Car.Text = "Car";
            this.button_Car.UseVisualStyleBackColor = true;
            this.button_Car.Click += new System.EventHandler(this.button_Car_Click);
            // 
            // buttonBall
            // 
            this.buttonBall.Location = new System.Drawing.Point(147, 27);
            this.buttonBall.Name = "buttonBall";
            this.buttonBall.Size = new System.Drawing.Size(75, 23);
            this.buttonBall.TabIndex = 1;
            this.buttonBall.Text = "Ball";
            this.buttonBall.UseVisualStyleBackColor = true;
            this.buttonBall.Click += new System.EventHandler(this.buttonBall_Click);
            // 
            // lable_Next
            // 
            this.lable_Next.AutoSize = true;
            this.lable_Next.Location = new System.Drawing.Point(344, 34);
            this.lable_Next.Name = "lable_Next";
            this.lable_Next.Size = new System.Drawing.Size(86, 16);
            this.lable_Next.TabIndex = 2;
            this.lable_Next.Text = "Coming next :";
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonColor.Location = new System.Drawing.Point(250, 27);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(75, 23);
            this.buttonColor.TabIndex = 3;
            this.buttonColor.Text = "Color";
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Label lable_Next;
        private System.Windows.Forms.Button buttonBall;
        private System.Windows.Forms.Button button_Car;
        private System.Windows.Forms.Button buttonColor;
    }
}

