namespace dnd.Controls
{
    partial class CharacterInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterInterface));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ArmorBtn = new System.Windows.Forms.Button();
            this.statsBtn = new System.Windows.Forms.Button();
            this.SkillsBtn = new System.Windows.Forms.Button();
            this.AbilitiesBtn = new System.Windows.Forms.Button();
            this.SpellsBtn = new System.Windows.Forms.Button();
            this.WeaponsBtn = new System.Windows.Forms.Button();
            this.CharacterSheetBtn = new System.Windows.Forms.Button();
            this.ProficencyBtn = new System.Windows.Forms.Button();
            this.PerceptionBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(100)))), ((int)(((byte)(96)))));
            this.flowLayoutPanel1.BackgroundImage = global::dnd.Properties.Resources.InterfaceBG;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(34, 48);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(229, 333);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ArmorBtn
            // 
            this.ArmorBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ArmorBtn.BackgroundImage")));
            this.ArmorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArmorBtn.Location = new System.Drawing.Point(257, 12);
            this.ArmorBtn.Name = "ArmorBtn";
            this.ArmorBtn.Size = new System.Drawing.Size(27, 28);
            this.ArmorBtn.TabIndex = 14;
            this.ArmorBtn.Text = "button7";
            this.ArmorBtn.UseVisualStyleBackColor = true;
            this.ArmorBtn.Click += new System.EventHandler(this.ArmorBtn_Click);
            // 
            // statsBtn
            // 
            this.statsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statsBtn.BackgroundImage")));
            this.statsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statsBtn.Location = new System.Drawing.Point(217, 10);
            this.statsBtn.Name = "statsBtn";
            this.statsBtn.Size = new System.Drawing.Size(27, 28);
            this.statsBtn.TabIndex = 13;
            this.statsBtn.Text = "button6";
            this.statsBtn.UseVisualStyleBackColor = true;
            this.statsBtn.Click += new System.EventHandler(this.statsBtn_Click);
            // 
            // SkillsBtn
            // 
            this.SkillsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SkillsBtn.BackgroundImage")));
            this.SkillsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SkillsBtn.Location = new System.Drawing.Point(176, 10);
            this.SkillsBtn.Name = "SkillsBtn";
            this.SkillsBtn.Size = new System.Drawing.Size(27, 28);
            this.SkillsBtn.TabIndex = 12;
            this.SkillsBtn.Text = "button5";
            this.SkillsBtn.UseVisualStyleBackColor = true;
            this.SkillsBtn.Click += new System.EventHandler(this.SkillsBtn_Click);
            // 
            // AbilitiesBtn
            // 
            this.AbilitiesBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AbilitiesBtn.BackgroundImage")));
            this.AbilitiesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AbilitiesBtn.Location = new System.Drawing.Point(135, 11);
            this.AbilitiesBtn.Name = "AbilitiesBtn";
            this.AbilitiesBtn.Size = new System.Drawing.Size(27, 28);
            this.AbilitiesBtn.TabIndex = 11;
            this.AbilitiesBtn.Text = "button4";
            this.AbilitiesBtn.UseVisualStyleBackColor = true;
            this.AbilitiesBtn.Click += new System.EventHandler(this.AbilitiesBtn_Click);
            // 
            // SpellsBtn
            // 
            this.SpellsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SpellsBtn.BackgroundImage")));
            this.SpellsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpellsBtn.Location = new System.Drawing.Point(95, 10);
            this.SpellsBtn.Name = "SpellsBtn";
            this.SpellsBtn.Size = new System.Drawing.Size(27, 28);
            this.SpellsBtn.TabIndex = 10;
            this.SpellsBtn.Text = "button3";
            this.SpellsBtn.UseVisualStyleBackColor = true;
            this.SpellsBtn.Click += new System.EventHandler(this.SpellsBtn_Click);
            // 
            // WeaponsBtn
            // 
            this.WeaponsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WeaponsBtn.BackgroundImage")));
            this.WeaponsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeaponsBtn.Location = new System.Drawing.Point(55, 11);
            this.WeaponsBtn.Name = "WeaponsBtn";
            this.WeaponsBtn.Size = new System.Drawing.Size(27, 28);
            this.WeaponsBtn.TabIndex = 9;
            this.WeaponsBtn.Text = "button2";
            this.WeaponsBtn.UseVisualStyleBackColor = true;
            this.WeaponsBtn.Click += new System.EventHandler(this.WeaponsBtn_Click);
            // 
            // CharacterSheetBtn
            // 
            this.CharacterSheetBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CharacterSheetBtn.BackgroundImage")));
            this.CharacterSheetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CharacterSheetBtn.Location = new System.Drawing.Point(12, 13);
            this.CharacterSheetBtn.Name = "CharacterSheetBtn";
            this.CharacterSheetBtn.Size = new System.Drawing.Size(27, 28);
            this.CharacterSheetBtn.TabIndex = 8;
            this.CharacterSheetBtn.Text = "button1";
            this.CharacterSheetBtn.UseVisualStyleBackColor = true;
            this.CharacterSheetBtn.Click += new System.EventHandler(this.CharacterSheetBtn_Click);
            // 
            // ProficencyBtn
            // 
            this.ProficencyBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProficencyBtn.BackgroundImage")));
            this.ProficencyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProficencyBtn.Location = new System.Drawing.Point(12, 387);
            this.ProficencyBtn.Name = "ProficencyBtn";
            this.ProficencyBtn.Size = new System.Drawing.Size(27, 28);
            this.ProficencyBtn.TabIndex = 15;
            this.ProficencyBtn.Text = "button2";
            this.ProficencyBtn.UseVisualStyleBackColor = true;
            this.ProficencyBtn.Click += new System.EventHandler(this.ProficencyBtn_Click);
            // 
            // PerceptionBtn
            // 
            this.PerceptionBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PerceptionBtn.BackgroundImage")));
            this.PerceptionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PerceptionBtn.Location = new System.Drawing.Point(55, 387);
            this.PerceptionBtn.Name = "PerceptionBtn";
            this.PerceptionBtn.Size = new System.Drawing.Size(27, 28);
            this.PerceptionBtn.TabIndex = 16;
            this.PerceptionBtn.Text = "button2";
            this.PerceptionBtn.UseVisualStyleBackColor = true;
            this.PerceptionBtn.Click += new System.EventHandler(this.PerceptionBtn_Click);
            // 
            // CharacterInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::dnd.Properties.Resources.Interface;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.PerceptionBtn);
            this.Controls.Add(this.ProficencyBtn);
            this.Controls.Add(this.ArmorBtn);
            this.Controls.Add(this.statsBtn);
            this.Controls.Add(this.SkillsBtn);
            this.Controls.Add(this.AbilitiesBtn);
            this.Controls.Add(this.SpellsBtn);
            this.Controls.Add(this.WeaponsBtn);
            this.Controls.Add(this.CharacterSheetBtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "CharacterInterface";
            this.Size = new System.Drawing.Size(296, 424);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ArmorBtn;
        private System.Windows.Forms.Button statsBtn;
        private System.Windows.Forms.Button SkillsBtn;
        private System.Windows.Forms.Button AbilitiesBtn;
        private System.Windows.Forms.Button SpellsBtn;
        private System.Windows.Forms.Button WeaponsBtn;
        private System.Windows.Forms.Button CharacterSheetBtn;
        private System.Windows.Forms.Button ProficencyBtn;
        private System.Windows.Forms.Button PerceptionBtn;
    }
}
