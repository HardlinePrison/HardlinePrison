namespace WinFormShapes
{
    partial class Version2
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
            components = new System.ComponentModel.Container();
            canvasBox = new PictureBox();
            makeSquareButton = new Button();
            makeCircleButton = new Button();
            makeTriangularButton = new Button();
            movingTimer = new System.Windows.Forms.Timer(components);
            fillerBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)canvasBox).BeginInit();
            SuspendLayout();
            // 
            // canvasBox
            // 
            canvasBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            canvasBox.BackColor = SystemColors.ControlText;
            canvasBox.Location = new Point(0, 0);
            canvasBox.Name = "canvasBox";
            canvasBox.Size = new Size(745, 441);
            canvasBox.TabIndex = 0;
            canvasBox.TabStop = false;
            // 
            // makeSquareButton
            // 
            makeSquareButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            makeSquareButton.AutoSize = true;
            makeSquareButton.Location = new Point(751, 0);
            makeSquareButton.MinimumSize = new Size(130, 150);
            makeSquareButton.Name = "makeSquareButton";
            makeSquareButton.Size = new Size(140, 150);
            makeSquareButton.TabIndex = 1;
            makeSquareButton.Text = "Make Square";
            makeSquareButton.UseVisualStyleBackColor = true;
            makeSquareButton.Click += makeSquareButton_Click;
            // 
            // makeCircleButton
            // 
            makeCircleButton.Anchor = AnchorStyles.Right;
            makeCircleButton.Location = new Point(751, 147);
            makeCircleButton.Name = "makeCircleButton";
            makeCircleButton.Size = new Size(140, 150);
            makeCircleButton.TabIndex = 1;
            makeCircleButton.Text = "Make Circle";
            makeCircleButton.UseVisualStyleBackColor = true;
            makeCircleButton.Click += makeCircleButton_Click;
            // 
            // makeTriangularButton
            // 
            makeTriangularButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            makeTriangularButton.Location = new Point(751, 292);
            makeTriangularButton.Name = "makeTriangularButton";
            makeTriangularButton.Size = new Size(140, 150);
            makeTriangularButton.TabIndex = 3;
            makeTriangularButton.Text = "Make Triangular";
            makeTriangularButton.UseVisualStyleBackColor = true;
            makeTriangularButton.Click += makeTriangularButton_Click;
            // 
            // movingTimer
            // 
            movingTimer.Interval = 10;
            movingTimer.Tick += movingTimer_Tick;
            // 
            // fillerBox
            // 
            fillerBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            fillerBox.AutoSize = true;
            fillerBox.Location = new Point(665, 0);
            fillerBox.Name = "fillerBox";
            fillerBox.Size = new Size(80, 19);
            fillerBox.TabIndex = 4;
            fillerBox.Text = "Fill figures";
            fillerBox.UseVisualStyleBackColor = true;
            fillerBox.CheckedChanged += fillerBox_CheckedChanged;
            // 
            // Version2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(893, 441);
            Controls.Add(fillerBox);
            Controls.Add(makeTriangularButton);
            Controls.Add(makeCircleButton);
            Controls.Add(makeSquareButton);
            Controls.Add(canvasBox);
            Name = "Version2";
            Text = "Version2";
            ((System.ComponentModel.ISupportInitialize)canvasBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox canvasBox;
        private Button makeSquareButton;
        private Button makeCircleButton;
        private Button makeTriangularButton;
        private System.Windows.Forms.Timer movingTimer;
        private CheckBox fillerBox;
    }
}