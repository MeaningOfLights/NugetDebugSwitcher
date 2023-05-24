namespace NuGetDebugSwitcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            folderBrowserDialog1 = new FolderBrowserDialog();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            txtModernizationDirectory = new TextBox();
            label3 = new Label();
            txtTargetVersion = new TextBox();
            btnUpdatePackager = new Button();
            label2 = new Label();
            txtSourcePackage = new TextBox();
            lnkConvertResults = new LinkLabel();
            groupBox3 = new GroupBox();
            txtOutputDebug = new TextBox();
            groupBox4 = new GroupBox();
            label7 = new Label();
            txtNuGetPackageVersion = new TextBox();
            btnRemoveSymLink = new Button();
            label4 = new Label();
            txtSwitchProjectsToDebugDirectory = new TextBox();
            label5 = new Label();
            txtDebugProjRef = new TextBox();
            btnAddSymLink = new Button();
            label6 = new Label();
            txtNuGetPackage = new TextBox();
            linkLabel1 = new LinkLabel();
            btnSourceLanguageDir = new Button();
            txtOutput = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txtOutput);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(lnkConvertResults);
            groupBox1.Location = new Point(12, 532);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(815, 514);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bulk Update Package Versions";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtModernizationDirectory);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtTargetVersion);
            groupBox2.Controls.Add(btnUpdatePackager);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnSourceLanguageDir);
            groupBox2.Controls.Add(txtSourcePackage);
            groupBox2.Location = new Point(16, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(799, 215);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 121);
            label1.Name = "label1";
            label1.Size = new Size(174, 20);
            label1.TabIndex = 8;
            label1.Text = "Modernization Directory:";
            // 
            // txtModernizationDirectory
            // 
            txtModernizationDirectory.Location = new Point(190, 117);
            txtModernizationDirectory.Name = "txtModernizationDirectory";
            txtModernizationDirectory.Size = new Size(574, 27);
            txtModernizationDirectory.TabIndex = 7;
            txtModernizationDirectory.Text = "C:\\Dev\\ProjectA\\";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 77);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 6;
            label3.Text = "Target Package:";
            // 
            // txtTargetVersion
            // 
            txtTargetVersion.Location = new Point(161, 73);
            txtTargetVersion.Name = "txtTargetVersion";
            txtTargetVersion.Size = new Size(603, 27);
            txtTargetVersion.TabIndex = 4;
            txtTargetVersion.Text = "2.0.6";
            // 
            // btnUpdatePackager
            // 
            btnUpdatePackager.Location = new Point(6, 168);
            btnUpdatePackager.Name = "btnUpdatePackager";
            btnUpdatePackager.Size = new Size(758, 29);
            btnUpdatePackager.TabIndex = 3;
            btnUpdatePackager.Text = "Update Packages in .csproj files";
            btnUpdatePackager.UseVisualStyleBackColor = true;
            btnUpdatePackager.Click += btnUpdatePackager_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 30);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 2;
            label2.Text = "Source Package:";
            // 
            // txtSourcePackage
            // 
            txtSourcePackage.Location = new Point(162, 26);
            txtSourcePackage.Name = "txtSourcePackage";
            txtSourcePackage.Size = new Size(563, 27);
            txtSourcePackage.TabIndex = 0;
            txtSourcePackage.Text = "ProjectA.Base";
            // 
            // lnkConvertResults
            // 
            lnkConvertResults.AutoSize = true;
            lnkConvertResults.Location = new Point(494, 195);
            lnkConvertResults.Name = "lnkConvertResults";
            lnkConvertResults.Size = new Size(0, 20);
            lnkConvertResults.TabIndex = 5;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(txtOutputDebug);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(linkLabel1);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(815, 514);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Switch Package References to Project";
            // 
            // txtOutputDebug
            // 
            txtOutputDebug.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtOutputDebug.Location = new Point(20, 318);
            txtOutputDebug.Multiline = true;
            txtOutputDebug.Name = "txtOutputDebug";
            txtOutputDebug.ScrollBars = ScrollBars.Vertical;
            txtOutputDebug.Size = new Size(781, 186);
            txtOutputDebug.TabIndex = 7;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(txtNuGetPackageVersion);
            groupBox4.Controls.Add(btnRemoveSymLink);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(txtSwitchProjectsToDebugDirectory);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(txtDebugProjRef);
            groupBox4.Controls.Add(btnAddSymLink);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(txtNuGetPackage);
            groupBox4.Location = new Point(16, 25);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(776, 264);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 75);
            label7.Name = "label7";
            label7.Size = new Size(106, 20);
            label7.TabIndex = 11;
            label7.Text = "NuGet Version:";
            // 
            // txtNuGetPackageVersion
            // 
            txtNuGetPackageVersion.Location = new Point(161, 71);
            txtNuGetPackageVersion.Name = "txtNuGetPackageVersion";
            txtNuGetPackageVersion.Size = new Size(603, 27);
            txtNuGetPackageVersion.TabIndex = 10;
            txtNuGetPackageVersion.Text = "2.1.0";
            // 
            // btnRemoveSymLink
            // 
            btnRemoveSymLink.Location = new Point(388, 214);
            btnRemoveSymLink.Name = "btnRemoveSymLink";
            btnRemoveSymLink.Size = new Size(381, 29);
            btnRemoveSymLink.TabIndex = 9;
            btnRemoveSymLink.Text = "Remove Symlink";
            btnRemoveSymLink.UseVisualStyleBackColor = true;
            btnRemoveSymLink.Click += btnAddSymLink_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 167);
            label4.Name = "label4";
            label4.Size = new Size(214, 20);
            label4.TabIndex = 8;
            label4.Text = "Switch to Project Ref Directory:";
            // 
            // txtSwitchProjectsToDebugDirectory
            // 
            txtSwitchProjectsToDebugDirectory.Location = new Point(230, 163);
            txtSwitchProjectsToDebugDirectory.Name = "txtSwitchProjectsToDebugDirectory";
            txtSwitchProjectsToDebugDirectory.Size = new Size(540, 27);
            txtSwitchProjectsToDebugDirectory.TabIndex = 7;
            txtSwitchProjectsToDebugDirectory.Text = "C:\\Dev\\Solution1\\src\\ProjectA\\";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 118);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 6;
            label5.Text = "Debug Proj Ref";
            // 
            // txtDebugProjRef
            // 
            txtDebugProjRef.Location = new Point(161, 114);
            txtDebugProjRef.Name = "txtDebugProjRef";
            txtDebugProjRef.Size = new Size(608, 27);
            txtDebugProjRef.TabIndex = 4;
            txtDebugProjRef.Text = "C:\\Dev\\Library1\\src\\Base\\bin\\Debug";
            // 
            // btnAddSymLink
            // 
            btnAddSymLink.Location = new Point(6, 214);
            btnAddSymLink.Name = "btnAddSymLink";
            btnAddSymLink.Size = new Size(376, 29);
            btnAddSymLink.TabIndex = 3;
            btnAddSymLink.Text = "Switch To Symlink";
            btnAddSymLink.UseVisualStyleBackColor = true;
            btnAddSymLink.Click += btnAddSymLink_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 30);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 2;
            label6.Text = "NuGet Package:";
            // 
            // txtNuGetPackage
            // 
            txtNuGetPackage.Location = new Point(162, 26);
            txtNuGetPackage.Name = "txtNuGetPackage";
            txtNuGetPackage.Size = new Size(608, 27);
            txtNuGetPackage.TabIndex = 0;
            txtNuGetPackage.Text = "DebugProjectOfNuGet.Base";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(494, 195);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 5;
            // 
            // btnSourceLanguageDir
            // 
            btnSourceLanguageDir.Enabled = false;
            btnSourceLanguageDir.Location = new Point(731, 24);
            btnSourceLanguageDir.Name = "btnSourceLanguageDir";
            btnSourceLanguageDir.Size = new Size(39, 29);
            btnSourceLanguageDir.TabIndex = 1;
            btnSourceLanguageDir.Text = "...";
            btnSourceLanguageDir.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            txtOutput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtOutput.Location = new Point(11, 256);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(790, 186);
            txtOutput.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 1060);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "NuGet Debug Switcher";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FolderBrowserDialog folderBrowserDialog1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox txtModernizationDirectory;
        private Label label3;
        private Button btnTargetLanguageDir;
        private TextBox txtTargetVersion;
        private Button btnUpdatePackager;
        private Label label2;
        private TextBox txtSourcePackage;
        private LinkLabel lnkConvertResults;
        private GroupBox groupBox3;
        private TextBox txtOutputDebug;
        private GroupBox groupBox4;
        private Button btnRemoveSymLink;
        private Label label4;
        private TextBox txtSwitchProjectsToDebugDirectory;
        private Label label5;
        private TextBox txtDebugProjRef;
        private Button btnAddSymLink;
        private Label label6;
        private TextBox txtNuGetPackage;
        private LinkLabel linkLabel1;
        private Label label7;
        private TextBox txtNuGetPackageVersion;
        private TextBox txtOutput;
        private Button btnSourceLanguageDir;
    }
}