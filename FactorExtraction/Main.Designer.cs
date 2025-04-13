namespace FactorExtraction
{
    partial class FactorExtraction
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
            ChooseModeLabel = new Label();
            ChooseModeBox = new ComboBox();
            ChooseEnemyBox = new ComboBox();
            ChooseEnemyLabel = new Label();
            AddFactorToApp = new Button();
            ExtractionLabel = new Label();
            ExtractionButton = new Button();
            ConventionExtraction = new ListBox();
            ExtractionArea = new Panel();
            loadContex = new Label();
            SelectArea = new Panel();
            SelectReset = new Button();
            HellFactorLabel = new Label();
            AdditionalFactorLabel = new Label();
            ConventionFactorLabel = new Label();
            FactorIntroduction = new Label();
            HellExtraction = new ListBox();
            AdditionalExtraction = new ListBox();
            DecisionArea = new Panel();
            ShowFactor = new Button();
            DecideReset = new Button();
            HellSelect = new ListBox();
            HellFactorLabelSelect = new Label();
            AdditionalFactorLabelSelect = new Label();
            AdditionalSelect = new ListBox();
            ConventionSelect = new ListBox();
            ConventionFactorLabelSelect = new Label();
            SelectLabel = new Label();
            ExtractionArea.SuspendLayout();
            SelectArea.SuspendLayout();
            DecisionArea.SuspendLayout();
            SuspendLayout();
            // 
            // ChooseModeLabel
            // 
            ChooseModeLabel.AutoSize = true;
            ChooseModeLabel.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ChooseModeLabel.Location = new Point(28, 52);
            ChooseModeLabel.Name = "ChooseModeLabel";
            ChooseModeLabel.Size = new Size(167, 39);
            ChooseModeLabel.TabIndex = 0;
            ChooseModeLabel.Text = "选择模式：";
            // 
            // ChooseModeBox
            // 
            ChooseModeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ChooseModeBox.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ChooseModeBox.FormattingEnabled = true;
            ChooseModeBox.ImeMode = ImeMode.Off;
            ChooseModeBox.Items.AddRange(new object[] { "三因子", "四因子", "五因子" });
            ChooseModeBox.Location = new Point(185, 40);
            ChooseModeBox.Name = "ChooseModeBox";
            ChooseModeBox.Size = new Size(150, 60);
            ChooseModeBox.TabIndex = 2;
            ChooseModeBox.TabStop = false;
            ChooseModeBox.SelectedIndexChanged += ChooseModeBox_SelectedIndexChanged;
            // 
            // ChooseEnemyBox
            // 
            ChooseEnemyBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ChooseEnemyBox.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ChooseEnemyBox.FormattingEnabled = true;
            ChooseEnemyBox.Items.AddRange(new object[] { "终结族", "机器人", "光能者" });
            ChooseEnemyBox.Location = new Point(504, 40);
            ChooseEnemyBox.Name = "ChooseEnemyBox";
            ChooseEnemyBox.Size = new Size(150, 60);
            ChooseEnemyBox.TabIndex = 7;
            // 
            // ChooseEnemyLabel
            // 
            ChooseEnemyLabel.AutoSize = true;
            ChooseEnemyLabel.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ChooseEnemyLabel.Location = new Point(358, 52);
            ChooseEnemyLabel.Name = "ChooseEnemyLabel";
            ChooseEnemyLabel.Size = new Size(167, 39);
            ChooseEnemyLabel.TabIndex = 6;
            ChooseEnemyLabel.Text = "选择敌人：";
            // 
            // AddFactorToApp
            // 
            AddFactorToApp.Location = new Point(3, 3);
            AddFactorToApp.Name = "AddFactorToApp";
            AddFactorToApp.Size = new Size(30, 30);
            AddFactorToApp.TabIndex = 22;
            AddFactorToApp.Text = "A";
            AddFactorToApp.UseVisualStyleBackColor = true;
            AddFactorToApp.Click += AddFactorToApp_Click_1;
            // 
            // ExtractionLabel
            // 
            ExtractionLabel.AutoSize = true;
            ExtractionLabel.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ExtractionLabel.Location = new Point(186, 20);
            ExtractionLabel.Name = "ExtractionLabel";
            ExtractionLabel.Size = new Size(197, 39);
            ExtractionLabel.TabIndex = 8;
            ExtractionLabel.Text = "抽取出的因子";
            // 
            // ExtractionButton
            // 
            ExtractionButton.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ExtractionButton.Location = new Point(703, 22);
            ExtractionButton.Name = "ExtractionButton";
            ExtractionButton.Size = new Size(150, 100);
            ExtractionButton.TabIndex = 9;
            ExtractionButton.Text = "抽取!";
            ExtractionButton.UseVisualStyleBackColor = true;
            ExtractionButton.Click += ExtractionButton_Click;
            // 
            // ConventionExtraction
            // 
            ConventionExtraction.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ConventionExtraction.FormattingEnabled = true;
            ConventionExtraction.ItemHeight = 30;
            ConventionExtraction.Location = new Point(18, 111);
            ConventionExtraction.Name = "ConventionExtraction";
            ConventionExtraction.Size = new Size(180, 184);
            ConventionExtraction.TabIndex = 10;
            ConventionExtraction.SelectedIndexChanged += ConventionExtraction_SelectedIndexChanged;
            // 
            // ExtractionArea
            // 
            ExtractionArea.BorderStyle = BorderStyle.FixedSingle;
            ExtractionArea.Controls.Add(loadContex);
            ExtractionArea.Controls.Add(AddFactorToApp);
            ExtractionArea.Location = new Point(10, 10);
            ExtractionArea.Name = "ExtractionArea";
            ExtractionArea.Size = new Size(860, 125);
            ExtractionArea.TabIndex = 13;
            // 
            // loadContex
            // 
            loadContex.AutoSize = true;
            loadContex.Location = new Point(39, 11);
            loadContex.Name = "loadContex";
            loadContex.Size = new Size(0, 20);
            loadContex.TabIndex = 23;
            // 
            // SelectArea
            // 
            SelectArea.BorderStyle = BorderStyle.FixedSingle;
            SelectArea.Controls.Add(SelectReset);
            SelectArea.Controls.Add(HellFactorLabel);
            SelectArea.Controls.Add(AdditionalFactorLabel);
            SelectArea.Controls.Add(ConventionFactorLabel);
            SelectArea.Controls.Add(FactorIntroduction);
            SelectArea.Controls.Add(HellExtraction);
            SelectArea.Controls.Add(AdditionalExtraction);
            SelectArea.Controls.Add(ExtractionLabel);
            SelectArea.Controls.Add(ConventionExtraction);
            SelectArea.Location = new Point(10, 141);
            SelectArea.Name = "SelectArea";
            SelectArea.Size = new Size(585, 400);
            SelectArea.TabIndex = 14;
            // 
            // SelectReset
            // 
            SelectReset.Location = new Point(550, 3);
            SelectReset.Name = "SelectReset";
            SelectReset.Size = new Size(30, 30);
            SelectReset.TabIndex = 21;
            SelectReset.Text = "R";
            SelectReset.UseVisualStyleBackColor = true;
            SelectReset.Click += SelectReset_Click;
            // 
            // HellFactorLabel
            // 
            HellFactorLabel.AutoSize = true;
            HellFactorLabel.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            HellFactorLabel.Location = new Point(390, 78);
            HellFactorLabel.Name = "HellFactorLabel";
            HellFactorLabel.Size = new Size(105, 30);
            HellFactorLabel.TabIndex = 16;
            HellFactorLabel.Text = "阴间因子";
            // 
            // AdditionalFactorLabel
            // 
            AdditionalFactorLabel.AutoSize = true;
            AdditionalFactorLabel.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            AdditionalFactorLabel.Location = new Point(204, 78);
            AdditionalFactorLabel.Name = "AdditionalFactorLabel";
            AdditionalFactorLabel.Size = new Size(105, 30);
            AdditionalFactorLabel.TabIndex = 15;
            AdditionalFactorLabel.Text = "附加因子";
            // 
            // ConventionFactorLabel
            // 
            ConventionFactorLabel.AutoSize = true;
            ConventionFactorLabel.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ConventionFactorLabel.Location = new Point(18, 78);
            ConventionFactorLabel.Name = "ConventionFactorLabel";
            ConventionFactorLabel.Size = new Size(105, 30);
            ConventionFactorLabel.TabIndex = 14;
            ConventionFactorLabel.Text = "常规因子";
            // 
            // FactorIntroduction
            // 
            FactorIntroduction.AutoSize = true;
            FactorIntroduction.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            FactorIntroduction.Location = new Point(18, 307);
            FactorIntroduction.MaximumSize = new Size(550, 80);
            FactorIntroduction.MinimumSize = new Size(50, 80);
            FactorIntroduction.Name = "FactorIntroduction";
            FactorIntroduction.Size = new Size(50, 80);
            FactorIntroduction.TabIndex = 13;
            // 
            // HellExtraction
            // 
            HellExtraction.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            HellExtraction.FormattingEnabled = true;
            HellExtraction.ItemHeight = 30;
            HellExtraction.Location = new Point(390, 111);
            HellExtraction.Name = "HellExtraction";
            HellExtraction.Size = new Size(180, 184);
            HellExtraction.TabIndex = 12;
            HellExtraction.SelectedIndexChanged += HellExtraction_SelectedIndexChanged;
            // 
            // AdditionalExtraction
            // 
            AdditionalExtraction.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            AdditionalExtraction.FormattingEnabled = true;
            AdditionalExtraction.ItemHeight = 30;
            AdditionalExtraction.Location = new Point(204, 111);
            AdditionalExtraction.Name = "AdditionalExtraction";
            AdditionalExtraction.Size = new Size(180, 184);
            AdditionalExtraction.TabIndex = 11;
            AdditionalExtraction.SelectedIndexChanged += AdditionalExtraction_SelectedIndexChanged;
            // 
            // DecisionArea
            // 
            DecisionArea.BorderStyle = BorderStyle.FixedSingle;
            DecisionArea.Controls.Add(ShowFactor);
            DecisionArea.Controls.Add(DecideReset);
            DecisionArea.Controls.Add(HellSelect);
            DecisionArea.Controls.Add(HellFactorLabelSelect);
            DecisionArea.Controls.Add(AdditionalFactorLabelSelect);
            DecisionArea.Controls.Add(AdditionalSelect);
            DecisionArea.Controls.Add(ConventionSelect);
            DecisionArea.Controls.Add(ConventionFactorLabelSelect);
            DecisionArea.Controls.Add(SelectLabel);
            DecisionArea.Location = new Point(603, 141);
            DecisionArea.Name = "DecisionArea";
            DecisionArea.Size = new Size(267, 400);
            DecisionArea.TabIndex = 15;
            // 
            // ShowFactor
            // 
            ShowFactor.Location = new Point(232, 365);
            ShowFactor.Name = "ShowFactor";
            ShowFactor.Size = new Size(30, 30);
            ShowFactor.TabIndex = 21;
            ShowFactor.Text = "S";
            ShowFactor.UseVisualStyleBackColor = true;
            ShowFactor.Click += ShowFactor_Click;
            // 
            // DecideReset
            // 
            DecideReset.Location = new Point(232, 3);
            DecideReset.Name = "DecideReset";
            DecideReset.Size = new Size(30, 30);
            DecideReset.TabIndex = 20;
            DecideReset.Text = "R";
            DecideReset.UseVisualStyleBackColor = true;
            DecideReset.Click += DecideReset_Click;
            // 
            // HellSelect
            // 
            HellSelect.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            HellSelect.FormattingEnabled = true;
            HellSelect.ItemHeight = 30;
            HellSelect.Location = new Point(27, 312);
            HellSelect.Name = "HellSelect";
            HellSelect.Size = new Size(213, 34);
            HellSelect.TabIndex = 19;
            HellSelect.SelectedIndexChanged += HellSelect_SelectedIndexChanged;
            // 
            // HellFactorLabelSelect
            // 
            HellFactorLabelSelect.AutoSize = true;
            HellFactorLabelSelect.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            HellFactorLabelSelect.Location = new Point(81, 279);
            HellFactorLabelSelect.Name = "HellFactorLabelSelect";
            HellFactorLabelSelect.Size = new Size(105, 30);
            HellFactorLabelSelect.TabIndex = 17;
            HellFactorLabelSelect.Text = "阴间因子";
            // 
            // AdditionalFactorLabelSelect
            // 
            AdditionalFactorLabelSelect.AutoSize = true;
            AdditionalFactorLabelSelect.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            AdditionalFactorLabelSelect.Location = new Point(81, 149);
            AdditionalFactorLabelSelect.Name = "AdditionalFactorLabelSelect";
            AdditionalFactorLabelSelect.Size = new Size(105, 30);
            AdditionalFactorLabelSelect.TabIndex = 17;
            AdditionalFactorLabelSelect.Text = "附加因子";
            // 
            // AdditionalSelect
            // 
            AdditionalSelect.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            AdditionalSelect.FormattingEnabled = true;
            AdditionalSelect.ItemHeight = 30;
            AdditionalSelect.Location = new Point(27, 182);
            AdditionalSelect.Name = "AdditionalSelect";
            AdditionalSelect.Size = new Size(213, 94);
            AdditionalSelect.TabIndex = 18;
            AdditionalSelect.SelectedIndexChanged += AdditionalSelect_SelectedIndexChanged;
            // 
            // ConventionSelect
            // 
            ConventionSelect.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ConventionSelect.FormattingEnabled = true;
            ConventionSelect.ItemHeight = 30;
            ConventionSelect.Location = new Point(27, 111);
            ConventionSelect.Name = "ConventionSelect";
            ConventionSelect.Size = new Size(213, 34);
            ConventionSelect.TabIndex = 17;
            ConventionSelect.SelectedIndexChanged += ConventionSelect_SelectedIndexChanged;
            // 
            // ConventionFactorLabelSelect
            // 
            ConventionFactorLabelSelect.AutoSize = true;
            ConventionFactorLabelSelect.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ConventionFactorLabelSelect.Location = new Point(81, 78);
            ConventionFactorLabelSelect.Name = "ConventionFactorLabelSelect";
            ConventionFactorLabelSelect.Size = new Size(105, 30);
            ConventionFactorLabelSelect.TabIndex = 17;
            ConventionFactorLabelSelect.Text = "常规因子";
            // 
            // SelectLabel
            // 
            SelectLabel.AutoSize = true;
            SelectLabel.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            SelectLabel.Location = new Point(51, 20);
            SelectLabel.Name = "SelectLabel";
            SelectLabel.Size = new Size(167, 39);
            SelectLabel.TabIndex = 17;
            SelectLabel.Text = "选择的因子";
            // 
            // FactorExtraction
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(DecisionArea);
            Controls.Add(ExtractionButton);
            Controls.Add(ChooseEnemyBox);
            Controls.Add(ChooseEnemyLabel);
            Controls.Add(ChooseModeBox);
            Controls.Add(ChooseModeLabel);
            Controls.Add(ExtractionArea);
            Controls.Add(SelectArea);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FactorExtraction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "抽取因子";
            FormClosing += FactorExtraction_FormClosing;
            Load += Form1_Load;
            ExtractionArea.ResumeLayout(false);
            ExtractionArea.PerformLayout();
            SelectArea.ResumeLayout(false);
            SelectArea.PerformLayout();
            DecisionArea.ResumeLayout(false);
            DecisionArea.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ChooseModeLabel;
        private ComboBox ChooseModeBox;
        private ComboBox ChooseEnemyBox;
        private Label ChooseEnemyLabel;
        private Label ExtractionLabel;
        private Button ExtractionButton;
        private ListBox ConventionExtraction;
        private Panel ExtractionArea;
        private Panel SelectArea;
        private ListBox HellExtraction;
        private ListBox AdditionalExtraction;
        private Label HellFactorLabel;
        private Label AdditionalFactorLabel;
        private Label ConventionFactorLabel;
        private Panel DecisionArea;
        private Label FactorIntroduction;
        private Label SelectLabel;
        private Label ConventionFactorLabelSelect;
        private ListBox ConventionSelect;
        private Button SelectReset;
        private Button DecideReset;
        private ListBox HellSelect;
        private Label HellFactorLabelSelect;
        private Label AdditionalFactorLabelSelect;
        private ListBox AdditionalSelect;
        private Button AddFactorToApp;
        private Button ShowFactor;
        private Label loadContex;
    }
}
