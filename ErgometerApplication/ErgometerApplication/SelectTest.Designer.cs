namespace ErgometerApplication
{
    partial class SelectTest
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
            this.listBox_Tests = new System.Windows.Forms.ListBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listBox_Tests
            // 
            this.listBox_Tests.FormattingEnabled = true;
            this.listBox_Tests.Location = new System.Drawing.Point(157, 12);
            this.listBox_Tests.Name = "listBox_Tests";
            this.listBox_Tests.Size = new System.Drawing.Size(302, 173);
            this.listBox_Tests.TabIndex = 0;
            this.listBox_Tests.SelectedIndexChanged += new System.EventHandler(this.listBox_Tests_SelectedIndexChanged);
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(7, 12);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(144, 28);
            this.button_Start.TabIndex = 1;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SelectTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 189);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.listBox_Tests);
            this.Name = "SelectTest";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Tests;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Timer timer1;
    }
}