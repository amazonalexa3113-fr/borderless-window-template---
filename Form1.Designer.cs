namespace draggable_borderless_window
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
            dragPanel = new Panel();
            minBtn = new Button();
            maxBtn = new Button();
            closeBtn = new Button();
            formLabel = new Label();
            label1 = new Label();
            trackBar1 = new TrackBar();
            viewOpSlider = new Button();
            dragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // dragPanel
            // 
            dragPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dragPanel.BackColor = SystemColors.ControlDark;
            dragPanel.Controls.Add(minBtn);
            dragPanel.Controls.Add(maxBtn);
            dragPanel.Controls.Add(closeBtn);
            dragPanel.Controls.Add(formLabel);
            dragPanel.Location = new Point(12, 12);
            dragPanel.Name = "dragPanel";
            dragPanel.Size = new Size(776, 26);
            dragPanel.TabIndex = 0;
            dragPanel.MouseDoubleClick += dragPanel_DoubleClick;
            dragPanel.MouseDown += Form1_MouseDown;
            // 
            // minBtn
            // 
            minBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minBtn.BackColor = Color.Black;
            minBtn.FlatStyle = FlatStyle.Popup;
            minBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            minBtn.ForeColor = SystemColors.ControlLightLight;
            minBtn.Location = new Point(701, 3);
            minBtn.Name = "minBtn";
            minBtn.Size = new Size(20, 20);
            minBtn.TabIndex = 3;
            minBtn.Text = "—";
            minBtn.UseVisualStyleBackColor = false;
            minBtn.Click += minBtn_Click;
            // 
            // maxBtn
            // 
            maxBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maxBtn.BackColor = Color.Black;
            maxBtn.FlatStyle = FlatStyle.Popup;
            maxBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            maxBtn.ForeColor = SystemColors.ControlLightLight;
            maxBtn.Location = new Point(727, 3);
            maxBtn.Name = "maxBtn";
            maxBtn.Size = new Size(20, 20);
            maxBtn.TabIndex = 2;
            maxBtn.Text = "▭";
            maxBtn.UseVisualStyleBackColor = false;
            maxBtn.Click += maxBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeBtn.BackColor = Color.Red;
            closeBtn.FlatStyle = FlatStyle.Popup;
            closeBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            closeBtn.ForeColor = SystemColors.ControlLightLight;
            closeBtn.Location = new Point(753, 3);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(20, 20);
            closeBtn.TabIndex = 1;
            closeBtn.Text = "X";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // formLabel
            // 
            formLabel.AutoSize = true;
            formLabel.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            formLabel.Location = new Point(0, 1);
            formLabel.Name = "formLabel";
            formLabel.Size = new Size(176, 25);
            formLabel.TabIndex = 0;
            formLabel.Text = "insert text here :skull:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoEllipsis = true;
            label1.Font = new Font("Raster", 50F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(39, 193);
            label1.Name = "label1";
            label1.Size = new Size(720, 86);
            label1.TabIndex = 1;
            label1.Text = "nothing to show here :P";
            // 
            // trackBar1
            // 
            trackBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trackBar1.Location = new Point(12, 382);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(776, 45);
            trackBar1.Maximum = 100;
            trackBar1.Value = 100;
            trackBar1.Visible = false;
            trackBar1.TabIndex = 2;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // viewOpSlider
            // 
            viewOpSlider.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            viewOpSlider.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            viewOpSlider.Location = new Point(332, 336);
            viewOpSlider.Name = "viewOpSlider";
            viewOpSlider.Size = new Size(124, 23);
            viewOpSlider.TabIndex = 3;
            viewOpSlider.Text = "opacity changer";
            viewOpSlider.UseVisualStyleBackColor = true;
            viewOpSlider.Click += viewOpSlider_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(viewOpSlider);
            Controls.Add(trackBar1);
            Controls.Add(label1);
            Controls.Add(dragPanel);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(250, 125);
            Name = "Form1";
            Text = "just a draggable borderless window";
            dragPanel.ResumeLayout(false);
            dragPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel dragPanel;
        private Label formLabel;
        private Button closeBtn;
        private Button minBtn;
        private Button maxBtn;
        private Label label1;
        private TrackBar trackBar1;
        private Button viewOpSlider;
    }
}
