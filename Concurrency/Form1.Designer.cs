namespace Concurrency
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            beginBtn = new Button();
            loadingGIF = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)loadingGIF).BeginInit();
            SuspendLayout();
            // 
            // beginBtn
            // 
            beginBtn.Location = new Point(328, 219);
            beginBtn.Name = "beginBtn";
            beginBtn.Size = new Size(75, 23);
            beginBtn.TabIndex = 0;
            beginBtn.Text = "Begin";
            beginBtn.UseVisualStyleBackColor = true;
            beginBtn.Click += beginBtn_Click;
            // 
            // loadingGIF
            // 
            loadingGIF.Image = Properties.Resources.loading;
            loadingGIF.Location = new Point(163, 21);
            loadingGIF.Name = "loadingGIF";
            loadingGIF.Size = new Size(389, 175);
            loadingGIF.SizeMode = PictureBoxSizeMode.CenterImage;
            loadingGIF.TabIndex = 1;
            loadingGIF.TabStop = false;
            loadingGIF.Visible = false;
            loadingGIF.Paint += pictureBox1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loadingGIF);
            Controls.Add(beginBtn);
            Name = "Form1";
            Text = "0";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)loadingGIF).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button beginBtn;
        private PictureBox loadingGIF;
    }
}