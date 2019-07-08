namespace Forms
{
    partial class CalculatorForm
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
            this.CalculatorButtonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.FourthButton = new System.Windows.Forms.Button();
            this.FifthButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FirstButton = new System.Windows.Forms.Button();
            this.SecondButton = new System.Windows.Forms.Button();
            this.ThirdButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.CalculatorButtonTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculatorButtonTableLayoutPanel
            // 
            this.CalculatorButtonTableLayoutPanel.ColumnCount = 3;
            this.CalculatorButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.CalculatorButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.CalculatorButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.EqualButton, 2, 3);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.ZeroButton, 1, 3);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.ThirdButton, 2, 2);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.SecondButton, 1, 2);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.FirstButton, 0, 2);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.SixButton, 2, 1);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.FifthButton, 1, 1);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.FourthButton, 0, 1);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.NineButton, 2, 0);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.EightButton, 1, 0);
            this.CalculatorButtonTableLayoutPanel.Controls.Add(this.SevenButton, 0, 0);
            this.CalculatorButtonTableLayoutPanel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculatorButtonTableLayoutPanel.Location = new System.Drawing.Point(13, 92);
            this.CalculatorButtonTableLayoutPanel.Name = "CalculatorButtonTableLayoutPanel";
            this.CalculatorButtonTableLayoutPanel.RowCount = 4;
            this.CalculatorButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalculatorButtonTableLayoutPanel.Size = new System.Drawing.Size(759, 360);
            this.CalculatorButtonTableLayoutPanel.TabIndex = 0;
            // 
            // SevenButton
            // 
            this.SevenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SevenButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SevenButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SevenButton.Location = new System.Drawing.Point(3, 3);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(246, 84);
            this.SevenButton.TabIndex = 0;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EightButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.EightButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EightButton.Location = new System.Drawing.Point(255, 3);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(247, 84);
            this.EightButton.TabIndex = 1;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NineButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.NineButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NineButton.Location = new System.Drawing.Point(508, 3);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(248, 84);
            this.NineButton.TabIndex = 2;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // FourthButton
            // 
            this.FourthButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FourthButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.FourthButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FourthButton.Location = new System.Drawing.Point(3, 93);
            this.FourthButton.Name = "FourthButton";
            this.FourthButton.Size = new System.Drawing.Size(246, 84);
            this.FourthButton.TabIndex = 3;
            this.FourthButton.Text = "4";
            this.FourthButton.UseVisualStyleBackColor = false;
            this.FourthButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // FifthButton
            // 
            this.FifthButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FifthButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.FifthButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FifthButton.Location = new System.Drawing.Point(255, 93);
            this.FifthButton.Name = "FifthButton";
            this.FifthButton.Size = new System.Drawing.Size(247, 84);
            this.FifthButton.TabIndex = 4;
            this.FifthButton.Text = "5";
            this.FifthButton.UseVisualStyleBackColor = false;
            this.FifthButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SixButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SixButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SixButton.Location = new System.Drawing.Point(508, 93);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(248, 84);
            this.SixButton.TabIndex = 5;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // FirstButton
            // 
            this.FirstButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.FirstButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FirstButton.Location = new System.Drawing.Point(3, 183);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(246, 84);
            this.FirstButton.TabIndex = 6;
            this.FirstButton.Text = "1";
            this.FirstButton.UseVisualStyleBackColor = false;
            this.FirstButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // SecondButton
            // 
            this.SecondButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SecondButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SecondButton.Location = new System.Drawing.Point(255, 183);
            this.SecondButton.Name = "SecondButton";
            this.SecondButton.Size = new System.Drawing.Size(247, 84);
            this.SecondButton.TabIndex = 7;
            this.SecondButton.Text = "2";
            this.SecondButton.UseVisualStyleBackColor = false;
            this.SecondButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // ThirdButton
            // 
            this.ThirdButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThirdButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ThirdButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ThirdButton.Location = new System.Drawing.Point(508, 183);
            this.ThirdButton.Name = "ThirdButton";
            this.ThirdButton.Size = new System.Drawing.Size(248, 84);
            this.ThirdButton.TabIndex = 8;
            this.ThirdButton.Text = "3";
            this.ThirdButton.UseVisualStyleBackColor = false;
            this.ThirdButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZeroButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.ZeroButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ZeroButton.Location = new System.Drawing.Point(255, 273);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(247, 84);
            this.ZeroButton.TabIndex = 10;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // EqualButton
            // 
            this.EqualButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EqualButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.EqualButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EqualButton.Location = new System.Drawing.Point(508, 273);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(248, 84);
            this.EqualButton.TabIndex = 11;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = false;
            this.EqualButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultLabel.Font = new System.Drawing.Font("Arial Narrow", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(16, 13);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(753, 60);
            this.ResultLabel.TabIndex = 1;
            this.ResultLabel.Text = "0";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ResultLabel.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.CalculatorButtonTableLayoutPanel);
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.CalculatorButtonTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CalculatorButtonTableLayoutPanel;
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button ThirdButton;
        private System.Windows.Forms.Button SecondButton;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FifthButton;
        private System.Windows.Forms.Button FourthButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Label ResultLabel;
    }
}

