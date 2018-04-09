namespace Win32_Api_Handler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mouseWinHandleTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.onMouseChkBox = new System.Windows.Forms.CheckBox();
            this.subWidthLbl = new System.Windows.Forms.Label();
            this.subHeightLbl = new System.Windows.Forms.Label();
            this.heightLbl = new System.Windows.Forms.Label();
            this.xLbl = new System.Windows.Forms.Label();
            this.subParentTextLbl = new System.Windows.Forms.Label();
            this.parentTxtLbl = new System.Windows.Forms.Label();
            this.subControlTextLbl = new System.Windows.Forms.Label();
            this.handleTextLbl = new System.Windows.Forms.Label();
            this.subClassnameLbl = new System.Windows.Forms.Label();
            this.classNameLbl = new System.Windows.Forms.Label();
            this.subHandleLbl = new System.Windows.Forms.Label();
            this.HandleLbl = new System.Windows.Forms.Label();
            this.subParentLbl = new System.Windows.Forms.Label();
            this.parentLbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dynamicTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.staticCodeTextBox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.wmGetTextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.setTextTxtBox1 = new System.Windows.Forms.TextBox();
            this.sendMsgBtn = new System.Windows.Forms.Button();
            this.wmComboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pinvokeBtn = new System.Windows.Forms.Button();
            this.controlGrabber1 = new Win32_Api_Handler.CustomControls.ControlGrabber();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlGrabber1)).BeginInit();
            this.SuspendLayout();
            // 
            // mouseWinHandleTimer
            // 
            this.mouseWinHandleTimer.Enabled = true;
            this.mouseWinHandleTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(422, 248);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pinvokeBtn);
            this.tabPage1.Controls.Add(this.onMouseChkBox);
            this.tabPage1.Controls.Add(this.controlGrabber1);
            this.tabPage1.Controls.Add(this.subWidthLbl);
            this.tabPage1.Controls.Add(this.subHeightLbl);
            this.tabPage1.Controls.Add(this.heightLbl);
            this.tabPage1.Controls.Add(this.xLbl);
            this.tabPage1.Controls.Add(this.subParentTextLbl);
            this.tabPage1.Controls.Add(this.parentTxtLbl);
            this.tabPage1.Controls.Add(this.subControlTextLbl);
            this.tabPage1.Controls.Add(this.handleTextLbl);
            this.tabPage1.Controls.Add(this.subClassnameLbl);
            this.tabPage1.Controls.Add(this.classNameLbl);
            this.tabPage1.Controls.Add(this.subHandleLbl);
            this.tabPage1.Controls.Add(this.HandleLbl);
            this.tabPage1.Controls.Add(this.subParentLbl);
            this.tabPage1.Controls.Add(this.parentLbl);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(414, 219);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Handle Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // onMouseChkBox
            // 
            this.onMouseChkBox.AutoSize = true;
            this.onMouseChkBox.Checked = true;
            this.onMouseChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.onMouseChkBox.Location = new System.Drawing.Point(9, 196);
            this.onMouseChkBox.Name = "onMouseChkBox";
            this.onMouseChkBox.Size = new System.Drawing.Size(77, 17);
            this.onMouseChkBox.TabIndex = 15;
            this.onMouseChkBox.Text = "OnMouse";
            this.onMouseChkBox.UseVisualStyleBackColor = true;
            this.onMouseChkBox.CheckedChanged += new System.EventHandler(this.onMouseChkBox_CheckedChanged);
            // 
            // subWidthLbl
            // 
            this.subWidthLbl.AutoSize = true;
            this.subWidthLbl.Location = new System.Drawing.Point(94, 156);
            this.subWidthLbl.Name = "subWidthLbl";
            this.subWidthLbl.Size = new System.Drawing.Size(11, 13);
            this.subWidthLbl.TabIndex = 13;
            this.subWidthLbl.Text = "-";
            // 
            // subHeightLbl
            // 
            this.subHeightLbl.AutoSize = true;
            this.subHeightLbl.Location = new System.Drawing.Point(94, 133);
            this.subHeightLbl.Name = "subHeightLbl";
            this.subHeightLbl.Size = new System.Drawing.Size(11, 13);
            this.subHeightLbl.TabIndex = 12;
            this.subHeightLbl.Text = "-";
            // 
            // heightLbl
            // 
            this.heightLbl.AutoSize = true;
            this.heightLbl.Location = new System.Drawing.Point(6, 133);
            this.heightLbl.Name = "heightLbl";
            this.heightLbl.Size = new System.Drawing.Size(45, 13);
            this.heightLbl.TabIndex = 11;
            this.heightLbl.Text = "Height:";
            // 
            // xLbl
            // 
            this.xLbl.AutoSize = true;
            this.xLbl.Location = new System.Drawing.Point(6, 156);
            this.xLbl.Name = "xLbl";
            this.xLbl.Size = new System.Drawing.Size(45, 13);
            this.xLbl.TabIndex = 10;
            this.xLbl.Text = "Width: ";
            // 
            // subParentTextLbl
            // 
            this.subParentTextLbl.AutoSize = true;
            this.subParentTextLbl.Location = new System.Drawing.Point(94, 65);
            this.subParentTextLbl.Name = "subParentTextLbl";
            this.subParentTextLbl.Size = new System.Drawing.Size(11, 13);
            this.subParentTextLbl.TabIndex = 9;
            this.subParentTextLbl.Text = "-";
            // 
            // parentTxtLbl
            // 
            this.parentTxtLbl.AutoSize = true;
            this.parentTxtLbl.Location = new System.Drawing.Point(6, 65);
            this.parentTxtLbl.Name = "parentTxtLbl";
            this.parentTxtLbl.Size = new System.Drawing.Size(68, 13);
            this.parentTxtLbl.TabIndex = 8;
            this.parentTxtLbl.Text = "Parent Text: ";
            // 
            // subControlTextLbl
            // 
            this.subControlTextLbl.AutoSize = true;
            this.subControlTextLbl.Location = new System.Drawing.Point(94, 111);
            this.subControlTextLbl.Name = "subControlTextLbl";
            this.subControlTextLbl.Size = new System.Drawing.Size(11, 13);
            this.subControlTextLbl.TabIndex = 7;
            this.subControlTextLbl.Text = "-";
            // 
            // handleTextLbl
            // 
            this.handleTextLbl.AutoSize = true;
            this.handleTextLbl.Location = new System.Drawing.Point(6, 111);
            this.handleTextLbl.Name = "handleTextLbl";
            this.handleTextLbl.Size = new System.Drawing.Size(71, 13);
            this.handleTextLbl.TabIndex = 6;
            this.handleTextLbl.Text = "Control Text:";
            // 
            // subClassnameLbl
            // 
            this.subClassnameLbl.AutoSize = true;
            this.subClassnameLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subClassnameLbl.Location = new System.Drawing.Point(94, 88);
            this.subClassnameLbl.Name = "subClassnameLbl";
            this.subClassnameLbl.Size = new System.Drawing.Size(11, 13);
            this.subClassnameLbl.TabIndex = 5;
            this.subClassnameLbl.Text = "-";
            // 
            // classNameLbl
            // 
            this.classNameLbl.AutoSize = true;
            this.classNameLbl.Location = new System.Drawing.Point(6, 88);
            this.classNameLbl.Name = "classNameLbl";
            this.classNameLbl.Size = new System.Drawing.Size(71, 13);
            this.classNameLbl.TabIndex = 4;
            this.classNameLbl.Text = "Class Name: ";
            // 
            // subHandleLbl
            // 
            this.subHandleLbl.AutoSize = true;
            this.subHandleLbl.Location = new System.Drawing.Point(94, 19);
            this.subHandleLbl.Name = "subHandleLbl";
            this.subHandleLbl.Size = new System.Drawing.Size(11, 13);
            this.subHandleLbl.TabIndex = 3;
            this.subHandleLbl.Text = "-";
            // 
            // HandleLbl
            // 
            this.HandleLbl.AutoSize = true;
            this.HandleLbl.Location = new System.Drawing.Point(6, 19);
            this.HandleLbl.Name = "HandleLbl";
            this.HandleLbl.Size = new System.Drawing.Size(47, 13);
            this.HandleLbl.TabIndex = 2;
            this.HandleLbl.Text = "Handle:";
            // 
            // subParentLbl
            // 
            this.subParentLbl.AutoSize = true;
            this.subParentLbl.Location = new System.Drawing.Point(94, 42);
            this.subParentLbl.Name = "subParentLbl";
            this.subParentLbl.Size = new System.Drawing.Size(11, 13);
            this.subParentLbl.TabIndex = 1;
            this.subParentLbl.Text = "-";
            // 
            // parentLbl
            // 
            this.parentLbl.AutoSize = true;
            this.parentLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentLbl.Location = new System.Drawing.Point(6, 42);
            this.parentLbl.Name = "parentLbl";
            this.parentLbl.Size = new System.Drawing.Size(43, 13);
            this.parentLbl.TabIndex = 0;
            this.parentLbl.Text = "Parent:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dynamicTextBox);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(414, 219);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dynamic Code";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dynamicTextBox
            // 
            this.dynamicTextBox.BackColor = System.Drawing.Color.White;
            this.dynamicTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dynamicTextBox.Location = new System.Drawing.Point(4, 6);
            this.dynamicTextBox.Multiline = true;
            this.dynamicTextBox.Name = "dynamicTextBox";
            this.dynamicTextBox.ReadOnly = true;
            this.dynamicTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dynamicTextBox.Size = new System.Drawing.Size(404, 213);
            this.dynamicTextBox.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.staticCodeTextBox);
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(414, 219);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Static Code";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // staticCodeTextBox
            // 
            this.staticCodeTextBox.BackColor = System.Drawing.Color.White;
            this.staticCodeTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticCodeTextBox.Location = new System.Drawing.Point(4, 6);
            this.staticCodeTextBox.Multiline = true;
            this.staticCodeTextBox.Name = "staticCodeTextBox";
            this.staticCodeTextBox.ReadOnly = true;
            this.staticCodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.staticCodeTextBox.Size = new System.Drawing.Size(404, 212);
            this.staticCodeTextBox.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.wmGetTextBox1);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.setTextTxtBox1);
            this.tabPage4.Controls.Add(this.sendMsgBtn);
            this.tabPage4.Controls.Add(this.wmComboBox1);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(414, 219);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Windows Message Utility";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "WM_GETTEXT:";
            // 
            // wmGetTextBox1
            // 
            this.wmGetTextBox1.BackColor = System.Drawing.Color.White;
            this.wmGetTextBox1.Location = new System.Drawing.Point(85, 118);
            this.wmGetTextBox1.Name = "wmGetTextBox1";
            this.wmGetTextBox1.ReadOnly = true;
            this.wmGetTextBox1.Size = new System.Drawing.Size(263, 20);
            this.wmGetTextBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "WM_SETTEXT:";
            // 
            // setTextTxtBox1
            // 
            this.setTextTxtBox1.Location = new System.Drawing.Point(85, 92);
            this.setTextTxtBox1.Name = "setTextTxtBox1";
            this.setTextTxtBox1.Size = new System.Drawing.Size(263, 20);
            this.setTextTxtBox1.TabIndex = 3;
            // 
            // sendMsgBtn
            // 
            this.sendMsgBtn.Location = new System.Drawing.Point(285, 190);
            this.sendMsgBtn.Name = "sendMsgBtn";
            this.sendMsgBtn.Size = new System.Drawing.Size(106, 23);
            this.sendMsgBtn.TabIndex = 2;
            this.sendMsgBtn.Text = "Send Message";
            this.sendMsgBtn.UseVisualStyleBackColor = true;
            this.sendMsgBtn.Click += new System.EventHandler(this.sendMsgBtn_Click);
            // 
            // wmComboBox1
            // 
            this.wmComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wmComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wmComboBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wmComboBox1.FormattingEnabled = true;
            this.wmComboBox1.Location = new System.Drawing.Point(260, 40);
            this.wmComboBox1.Name = "wmComboBox1";
            this.wmComboBox1.Size = new System.Drawing.Size(139, 21);
            this.wmComboBox1.TabIndex = 1;
            this.wmComboBox1.SelectedIndexChanged += new System.EventHandler(this.wmComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Windows Messages";
            // 
            // pinvokeBtn
            // 
            this.pinvokeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pinvokeBtn.Location = new System.Drawing.Point(345, 6);
            this.pinvokeBtn.Name = "pinvokeBtn";
            this.pinvokeBtn.Size = new System.Drawing.Size(63, 26);
            this.pinvokeBtn.TabIndex = 16;
            this.pinvokeBtn.Text = "pInvokes";
            this.pinvokeBtn.UseVisualStyleBackColor = true;
            this.pinvokeBtn.Click += new System.EventHandler(this.pinvokeBtn_Click);
            // 
            // controlGrabber1
            // 
            this.controlGrabber1.BackColor = System.Drawing.Color.LightGray;
            this.controlGrabber1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("controlGrabber1.BackgroundImage")));
            this.controlGrabber1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.controlGrabber1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.controlGrabber1.Location = new System.Drawing.Point(361, 183);
            this.controlGrabber1.Name = "controlGrabber1";
            this.controlGrabber1.Size = new System.Drawing.Size(37, 33);
            this.controlGrabber1.TabIndex = 14;
            this.controlGrabber1.TabStop = false;
            this.controlGrabber1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlGrabber1_MouseDown);
            this.controlGrabber1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.controlGrabber1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 255);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Win32 Api Handler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlGrabber1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer mouseWinHandleTimer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label subParentLbl;
        private System.Windows.Forms.Label parentLbl;
        private System.Windows.Forms.Label subHandleLbl;
        private System.Windows.Forms.Label HandleLbl;
        private System.Windows.Forms.Label subClassnameLbl;
        private System.Windows.Forms.Label classNameLbl;
        private System.Windows.Forms.Label subControlTextLbl;
        private System.Windows.Forms.Label handleTextLbl;
        private System.Windows.Forms.Label subParentTextLbl;
        private System.Windows.Forms.Label parentTxtLbl;
        private System.Windows.Forms.Label subWidthLbl;
        private System.Windows.Forms.Label subHeightLbl;
        private System.Windows.Forms.Label heightLbl;
        private System.Windows.Forms.Label xLbl;
        private CustomControls.ControlGrabber controlGrabber1;
        private System.Windows.Forms.CheckBox onMouseChkBox;
        private System.Windows.Forms.TextBox dynamicTextBox;
        private System.Windows.Forms.TextBox staticCodeTextBox;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox setTextTxtBox1;
        private System.Windows.Forms.Button sendMsgBtn;
        private System.Windows.Forms.ComboBox wmComboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox wmGetTextBox1;
        private System.Windows.Forms.Button pinvokeBtn;
    }
}

