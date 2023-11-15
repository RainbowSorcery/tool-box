namespace tool_box
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
            GetLocalIpAddreass = new MaterialSkin.Controls.MaterialButton();
            CodeGenerator = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // GetLocalIpAddreass
            // 
            GetLocalIpAddreass.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GetLocalIpAddreass.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            GetLocalIpAddreass.Depth = 0;
            GetLocalIpAddreass.HighEmphasis = true;
            GetLocalIpAddreass.Icon = null;
            GetLocalIpAddreass.Location = new Point(25, 89);
            GetLocalIpAddreass.Margin = new Padding(4, 6, 4, 6);
            GetLocalIpAddreass.MouseState = MaterialSkin.MouseState.HOVER;
            GetLocalIpAddreass.Name = "GetLocalIpAddreass";
            GetLocalIpAddreass.NoAccentTextColor = Color.Empty;
            GetLocalIpAddreass.Size = new Size(98, 36);
            GetLocalIpAddreass.TabIndex = 0;
            GetLocalIpAddreass.Text = "获取本机IP";
            GetLocalIpAddreass.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            GetLocalIpAddreass.UseAccentColor = false;
            GetLocalIpAddreass.UseVisualStyleBackColor = true;
            GetLocalIpAddreass.Click += GetLocalIpAddreass_Click;
            // 
            // CodeGenerator
            // 
            CodeGenerator.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CodeGenerator.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            CodeGenerator.Depth = 0;
            CodeGenerator.HighEmphasis = true;
            CodeGenerator.Icon = null;
            CodeGenerator.Location = new Point(159, 89);
            CodeGenerator.Margin = new Padding(3, 4, 3, 4);
            CodeGenerator.MouseState = MaterialSkin.MouseState.HOVER;
            CodeGenerator.Name = "CodeGenerator";
            CodeGenerator.NoAccentTextColor = Color.Empty;
            CodeGenerator.Size = new Size(101, 36);
            CodeGenerator.TabIndex = 1;
            CodeGenerator.Text = "代码生成器";
            CodeGenerator.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            CodeGenerator.UseAccentColor = false;
            CodeGenerator.UseVisualStyleBackColor = true;
            CodeGenerator.Click += CodeGenerator_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 291);
            Controls.Add(CodeGenerator);
            Controls.Add(GetLocalIpAddreass);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton GetLocalIpAddreass;
        private MaterialSkin.Controls.MaterialButton CodeGenerator;
    }
}