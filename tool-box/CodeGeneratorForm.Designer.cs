namespace tool_box
{
    partial class CodeGeneratorForm
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
            GeneratorCodeButton = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // GeneratorCodeButton
            // 
            GeneratorCodeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GeneratorCodeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            GeneratorCodeButton.Depth = 0;
            GeneratorCodeButton.HighEmphasis = true;
            GeneratorCodeButton.Icon = null;
            GeneratorCodeButton.Location = new Point(381, 263);
            GeneratorCodeButton.Margin = new Padding(3, 4, 3, 4);
            GeneratorCodeButton.MouseState = MaterialSkin.MouseState.HOVER;
            GeneratorCodeButton.Name = "GeneratorCodeButton";
            GeneratorCodeButton.NoAccentTextColor = Color.Empty;
            GeneratorCodeButton.Size = new Size(64, 36);
            GeneratorCodeButton.TabIndex = 0;
            GeneratorCodeButton.Text = "生成";
            GeneratorCodeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            GeneratorCodeButton.UseAccentColor = false;
            GeneratorCodeButton.UseVisualStyleBackColor = true;
            GeneratorCodeButton.Click += materialButton1_Click;
            // 
            // CodeGenerator
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 319);
            Controls.Add(GeneratorCodeButton);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CodeGenerator";
            Padding = new Padding(2, 45, 2, 2);
            Text = "CodeGenerator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton GeneratorCodeButton;
    }
}