
namespace BinaryChatter
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.OutputField = new System.Windows.Forms.TextBox();
            this.InputField = new System.Windows.Forms.TextBox();
            this.SelectionBox = new System.Windows.Forms.ComboBox();
            this.ViewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewPanel
            // 
            this.ViewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewPanel.AutoSize = true;
            this.ViewPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ViewPanel.Controls.Add(this.KeyLabel);
            this.ViewPanel.Controls.Add(this.KeyBox);
            this.ViewPanel.Controls.Add(this.OutputField);
            this.ViewPanel.Controls.Add(this.InputField);
            this.ViewPanel.Controls.Add(this.SelectionBox);
            this.ViewPanel.Location = new System.Drawing.Point(12, 12);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(360, 237);
            this.ViewPanel.TabIndex = 0;
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(182, 25);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(25, 13);
            this.KeyLabel.TabIndex = 4;
            this.KeyLabel.Text = "Key";
            // 
            // KeyBox
            // 
            this.KeyBox.Location = new System.Drawing.Point(213, 22);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(100, 20);
            this.KeyBox.TabIndex = 3;
            this.KeyBox.TextChanged += new System.EventHandler(this.KeyBox_TextChanged);
            // 
            // OutputField
            // 
            this.OutputField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputField.Location = new System.Drawing.Point(185, 62);
            this.OutputField.Multiline = true;
            this.OutputField.Name = "OutputField";
            this.OutputField.ReadOnly = true;
            this.OutputField.Size = new System.Drawing.Size(154, 154);
            this.OutputField.TabIndex = 2;
            // 
            // InputField
            // 
            this.InputField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputField.Location = new System.Drawing.Point(17, 62);
            this.InputField.Multiline = true;
            this.InputField.Name = "InputField";
            this.InputField.Size = new System.Drawing.Size(154, 154);
            this.InputField.TabIndex = 1;
            this.InputField.TextChanged += new System.EventHandler(this.InputField_TextChanged);
            // 
            // SelectionBox
            // 
            this.SelectionBox.BackColor = System.Drawing.SystemColors.Window;
            this.SelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectionBox.FormattingEnabled = true;
            this.SelectionBox.Items.AddRange(new object[] {
            "Text - Bin",
            "Bin - Text"});
            this.SelectionBox.Location = new System.Drawing.Point(17, 21);
            this.SelectionBox.Name = "SelectionBox";
            this.SelectionBox.Size = new System.Drawing.Size(121, 21);
            this.SelectionBox.TabIndex = 0;
            this.SelectionBox.SelectedIndexChanged += new System.EventHandler(this.SelectionBox_SelectedIndexChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.ViewPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "MainWindow";
            this.Text = "BinaryChatter";
            this.ViewPanel.ResumeLayout(false);
            this.ViewPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ViewPanel;
        private System.Windows.Forms.ComboBox SelectionBox;
        private System.Windows.Forms.TextBox InputField;
        private System.Windows.Forms.TextBox OutputField;
        private System.Windows.Forms.TextBox KeyBox;
        private System.Windows.Forms.Label KeyLabel;
    }
}

