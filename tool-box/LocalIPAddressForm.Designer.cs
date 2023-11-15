namespace tool_box
{
    partial class LocalIPAddressForm
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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            IpTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            PortTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            PingButton = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(56, 129);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(47, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "目标IP";
            // 
            // IpTextBox
            // 
            IpTextBox.AnimateReadOnly = false;
            IpTextBox.BackgroundImageLayout = ImageLayout.None;
            IpTextBox.CharacterCasing = CharacterCasing.Normal;
            IpTextBox.Depth = 0;
            IpTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            IpTextBox.HideSelection = true;
            IpTextBox.LeadingIcon = null;
            IpTextBox.Location = new Point(128, 111);
            IpTextBox.MaxLength = 32767;
            IpTextBox.MouseState = MaterialSkin.MouseState.OUT;
            IpTextBox.Name = "IpTextBox";
            IpTextBox.PasswordChar = '\0';
            IpTextBox.PrefixSuffixText = null;
            IpTextBox.ReadOnly = false;
            IpTextBox.RightToLeft = RightToLeft.No;
            IpTextBox.SelectedText = "";
            IpTextBox.SelectionLength = 0;
            IpTextBox.SelectionStart = 0;
            IpTextBox.ShortcutsEnabled = true;
            IpTextBox.Size = new Size(145, 48);
            IpTextBox.TabIndex = 1;
            IpTextBox.TabStop = false;
            IpTextBox.TextAlign = HorizontalAlignment.Left;
            IpTextBox.TrailingIcon = null;
            IpTextBox.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(299, 129);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(33, 19);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "端口";
            // 
            // PortTextBox
            // 
            PortTextBox.AnimateReadOnly = false;
            PortTextBox.BackgroundImageLayout = ImageLayout.None;
            PortTextBox.CharacterCasing = CharacterCasing.Normal;
            PortTextBox.Depth = 0;
            PortTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            PortTextBox.HideSelection = true;
            PortTextBox.LeadingIcon = null;
            PortTextBox.Location = new Point(350, 111);
            PortTextBox.MaxLength = 32767;
            PortTextBox.MouseState = MaterialSkin.MouseState.OUT;
            PortTextBox.Name = "PortTextBox";
            PortTextBox.PasswordChar = '\0';
            PortTextBox.PrefixSuffixText = null;
            PortTextBox.ReadOnly = false;
            PortTextBox.RightToLeft = RightToLeft.No;
            PortTextBox.SelectedText = "";
            PortTextBox.SelectionLength = 0;
            PortTextBox.SelectionStart = 0;
            PortTextBox.ShortcutsEnabled = true;
            PortTextBox.Size = new Size(45, 48);
            PortTextBox.TabIndex = 3;
            PortTextBox.TabStop = false;
            PortTextBox.TextAlign = HorizontalAlignment.Left;
            PortTextBox.TrailingIcon = null;
            PortTextBox.UseSystemPasswordChar = false;
            // 
            // PingButton
            // 
            PingButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PingButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            PingButton.Depth = 0;
            PingButton.HighEmphasis = true;
            PingButton.Icon = null;
            PingButton.Location = new Point(44, 206);
            PingButton.Margin = new Padding(4, 6, 4, 6);
            PingButton.MouseState = MaterialSkin.MouseState.HOVER;
            PingButton.Name = "PingButton";
            PingButton.NoAccentTextColor = Color.Empty;
            PingButton.Size = new Size(64, 36);
            PingButton.TabIndex = 4;
            PingButton.Text = "ping";
            PingButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            PingButton.UseAccentColor = false;
            PingButton.UseVisualStyleBackColor = true;
            PingButton.Click += PingButton_Click;
            // 
            // LocalIPAddressForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 262);
            Controls.Add(PingButton);
            Controls.Add(PortTextBox);
            Controls.Add(materialLabel2);
            Controls.Add(IpTextBox);
            Controls.Add(materialLabel1);
            Name = "LocalIPAddressForm";
            Text = "IP工具箱";
            Load += LocalIPAddressForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 IpTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 PortTextBox;
        private MaterialSkin.Controls.MaterialButton PingButton;
    }
}