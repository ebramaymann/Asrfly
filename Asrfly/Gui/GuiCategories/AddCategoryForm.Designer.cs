namespace Asrfly.Gui.GuiCategories
{
    partial class AddCategoryForm
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
            panel1 = new System.Windows.Forms.Panel();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            textBoxName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            textBoxBalance = new System.Windows.Forms.TextBox();
            comboBoxType = new System.Windows.Forms.ComboBox();
            richTextBoxDetails = new System.Windows.Forms.RichTextBox();
            buttonSaveAndClose = new System.Windows.Forms.Button();
            buttonSave = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonSaveAndClose);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 424);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(573, 67);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBoxDetails);
            groupBox1.Controls.Add(comboBoxType);
            groupBox1.Controls.Add(textBoxBalance);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(575, 406);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات الصنف";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(257, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(89, 30);
            label1.TabIndex = 0;
            label1.Text = "اسم الصنف";
            // 
            // textBoxName
            // 
            textBoxName.Location = new System.Drawing.Point(30, 66);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(523, 37);
            textBoxName.TabIndex = 1;
            textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(257, 124);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 30);
            label2.TabIndex = 0;
            label2.Text = "نوع الصنف";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(257, 206);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 30);
            label3.TabIndex = 0;
            label3.Text = "التفاصيل";
            label3.UseMnemonic = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(269, 320);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(53, 30);
            label4.TabIndex = 0;
            label4.Text = "الرصيد";
            // 
            // textBoxBalance
            // 
            textBoxBalance.Enabled = false;
            textBoxBalance.Location = new System.Drawing.Point(30, 353);
            textBoxBalance.Name = "textBoxBalance";
            textBoxBalance.Size = new System.Drawing.Size(523, 37);
            textBoxBalance.TabIndex = 1;
            textBoxBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "صرف", "قبض" });
            comboBoxType.Location = new System.Drawing.Point(30, 157);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new System.Drawing.Size(523, 38);
            comboBoxType.TabIndex = 2;
            // 
            // richTextBoxDetails
            // 
            richTextBoxDetails.Location = new System.Drawing.Point(30, 239);
            richTextBoxDetails.Name = "richTextBoxDetails";
            richTextBoxDetails.Size = new System.Drawing.Size(523, 78);
            richTextBoxDetails.TabIndex = 3;
            richTextBoxDetails.Text = "";
            // 
            // buttonSaveAndClose
            // 
            buttonSaveAndClose.Image = Properties.Resources.icons8_save_32px;
            buttonSaveAndClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSaveAndClose.Location = new System.Drawing.Point(392, 8);
            buttonSaveAndClose.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            buttonSaveAndClose.Name = "buttonSaveAndClose";
            buttonSaveAndClose.Padding = new System.Windows.Forms.Padding(5);
            buttonSaveAndClose.Size = new System.Drawing.Size(168, 46);
            buttonSaveAndClose.TabIndex = 2;
            buttonSaveAndClose.Text = "حفظ و غلق";
            buttonSaveAndClose.UseVisualStyleBackColor = true;
            buttonSaveAndClose.Click += buttonSaveAndClose_Click;
            // 
            // buttonSave
            // 
            buttonSave.Image = Properties.Resources.icons8_save_32px_1;
            buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSave.Location = new System.Drawing.Point(13, 8);
            buttonSave.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            buttonSave.Name = "buttonSave";
            buttonSave.Padding = new System.Windows.Forms.Padding(5);
            buttonSave.Size = new System.Drawing.Size(114, 46);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "حفظ";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // AddCategoryForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(573, 491);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddCategoryForm";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "أضافة \\ تعديل صنف";
            TopMost = true;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxDetails;
        private System.Windows.Forms.Button buttonSaveAndClose;
        private System.Windows.Forms.Button buttonSave;
    }
}