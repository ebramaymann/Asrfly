namespace Asrfly.Gui.GuiHome
{
    partial class HomeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            buttonAddInput = new System.Windows.Forms.Button();
            buttonAddOutput = new System.Windows.Forms.Button();
            buttonAddUser = new System.Windows.Forms.Button();
            buttonAddProject = new System.Windows.Forms.Button();
            buttonAddSupplier = new System.Windows.Forms.Button();
            buttonAddCustomer = new System.Windows.Forms.Button();
            buttonAddCategory = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            labelCompanyName = new System.Windows.Forms.Label();
            pictureBoxLogo = new System.Windows.Forms.PictureBox();
            labelWelcome = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.SteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 319);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1112, 173);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.icons8_smart_96px;
            pictureBox1.Location = new System.Drawing.Point(494, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(53, 45);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            groupBox1.Controls.Add(buttonAddInput);
            groupBox1.Controls.Add(buttonAddOutput);
            groupBox1.Controls.Add(buttonAddUser);
            groupBox1.Controls.Add(buttonAddProject);
            groupBox1.Controls.Add(buttonAddSupplier);
            groupBox1.Controls.Add(buttonAddCustomer);
            groupBox1.Controls.Add(buttonAddCategory);
            groupBox1.Location = new System.Drawing.Point(69, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(983, 103);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "اضافة";
            // 
            // buttonAddInput
            // 
            buttonAddInput.Image = Properties.Resources.icons8_input_32px;
            buttonAddInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAddInput.Location = new System.Drawing.Point(7, 41);
            buttonAddInput.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            buttonAddInput.Name = "buttonAddInput";
            buttonAddInput.Size = new System.Drawing.Size(132, 40);
            buttonAddInput.TabIndex = 7;
            buttonAddInput.Text = "قبض";
            buttonAddInput.UseVisualStyleBackColor = true;
            // 
            // buttonAddOutput
            // 
            buttonAddOutput.Image = Properties.Resources.icons8_output_32px;
            buttonAddOutput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAddOutput.Location = new System.Drawing.Point(147, 41);
            buttonAddOutput.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            buttonAddOutput.Name = "buttonAddOutput";
            buttonAddOutput.Size = new System.Drawing.Size(132, 40);
            buttonAddOutput.TabIndex = 6;
            buttonAddOutput.Text = "صرف";
            buttonAddOutput.UseVisualStyleBackColor = true;
            // 
            // buttonAddUser
            // 
            buttonAddUser.Image = Properties.Resources.icons8_users_32px_1;
            buttonAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAddUser.Location = new System.Drawing.Point(287, 41);
            buttonAddUser.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new System.Drawing.Size(132, 40);
            buttonAddUser.TabIndex = 5;
            buttonAddUser.Text = "مستخدم";
            buttonAddUser.UseVisualStyleBackColor = true;
            // 
            // buttonAddProject
            // 
            buttonAddProject.Image = Properties.Resources.icons8_microsoft_project_32px;
            buttonAddProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAddProject.Location = new System.Drawing.Point(427, 41);
            buttonAddProject.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            buttonAddProject.Name = "buttonAddProject";
            buttonAddProject.Size = new System.Drawing.Size(132, 40);
            buttonAddProject.TabIndex = 4;
            buttonAddProject.Text = "مشروع";
            buttonAddProject.UseVisualStyleBackColor = true;
            // 
            // buttonAddSupplier
            // 
            buttonAddSupplier.Image = Properties.Resources.icons8_supplier_32px;
            buttonAddSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAddSupplier.Location = new System.Drawing.Point(563, 41);
            buttonAddSupplier.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            buttonAddSupplier.Name = "buttonAddSupplier";
            buttonAddSupplier.Size = new System.Drawing.Size(132, 40);
            buttonAddSupplier.TabIndex = 3;
            buttonAddSupplier.Text = "مورد";
            buttonAddSupplier.UseVisualStyleBackColor = true;
            // 
            // buttonAddCustomer
            // 
            buttonAddCustomer.Image = Properties.Resources.icons8_users_32px;
            buttonAddCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAddCustomer.Location = new System.Drawing.Point(703, 41);
            buttonAddCustomer.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            buttonAddCustomer.Name = "buttonAddCustomer";
            buttonAddCustomer.Size = new System.Drawing.Size(132, 40);
            buttonAddCustomer.TabIndex = 2;
            buttonAddCustomer.Text = "عميل";
            buttonAddCustomer.UseVisualStyleBackColor = true;
            // 
            // buttonAddCategory
            // 
            buttonAddCategory.Image = Properties.Resources.icons8_categorize_32px;
            buttonAddCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAddCategory.Location = new System.Drawing.Point(843, 41);
            buttonAddCategory.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            buttonAddCategory.Name = "buttonAddCategory";
            buttonAddCategory.Size = new System.Drawing.Size(132, 40);
            buttonAddCategory.TabIndex = 1;
            buttonAddCategory.Text = "صنف";
            buttonAddCategory.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Cairo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(553, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(165, 45);
            label1.TabIndex = 0;
            label1.Text = "الوصول السريع";
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            panel2.Controls.Add(labelCompanyName);
            panel2.Controls.Add(pictureBoxLogo);
            panel2.Location = new System.Drawing.Point(683, 72);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(348, 97);
            panel2.TabIndex = 1;
            // 
            // labelCompanyName
            // 
            labelCompanyName.Font = new System.Drawing.Font("Cairo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelCompanyName.Location = new System.Drawing.Point(16, 13);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new System.Drawing.Size(266, 74);
            labelCompanyName.TabIndex = 5;
            labelCompanyName.Text = "ابرام";
            labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Right;
            pictureBoxLogo.Image = Properties.Resources.icons8_enter_key_80px;
            pictureBoxLogo.Location = new System.Drawing.Point(282, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new System.Drawing.Size(66, 97);
            pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 4;
            pictureBoxLogo.TabStop = false;
            // 
            // labelWelcome
            // 
            labelWelcome.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelWelcome.Location = new System.Drawing.Point(145, 87);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new System.Drawing.Size(269, 74);
            labelWelcome.TabIndex = 6;
            labelWelcome.Text = "مرحبا بك مجددا";
            labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HomeUserControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(labelWelcome);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            Name = "HomeUserControl";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Size = new System.Drawing.Size(1112, 492);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Button buttonAddInput;
        private System.Windows.Forms.Button buttonAddOutput;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonAddProject;
        private System.Windows.Forms.Button buttonAddSupplier;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label labelWelcome;
    }
}
