using System.Windows.Forms;
using dnd.dnd;

namespace dnd.Controls
{
    internal class StatsControl : UserControl
    {
        private Label NameLbl;
        private Label levelLbl;
        private Label ClassLbl;
        private Label GoldLbl;
        private Label HpLbl;
        private Label StrengthLbl;
        private Label DexLbl;
        private Label constitutionLbl;
        private Label IntLbl;
        private Label label1;
        public Label CharismaLbl;
        private TextBox textBox7;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private Label xpLbl;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown6;
        private NumericUpDown numericUpDown7;
        private Hero hero;

        public StatsControl(Hero hero)
        {
            InitializeComponent();
            this.hero = hero;
        }

        private void InitializeComponent()
        {
            this.NameLbl = new System.Windows.Forms.Label();
            this.levelLbl = new System.Windows.Forms.Label();
            this.ClassLbl = new System.Windows.Forms.Label();
            this.GoldLbl = new System.Windows.Forms.Label();
            this.HpLbl = new System.Windows.Forms.Label();
            this.StrengthLbl = new System.Windows.Forms.Label();
            this.DexLbl = new System.Windows.Forms.Label();
            this.constitutionLbl = new System.Windows.Forms.Label();
            this.IntLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CharismaLbl = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.xpLbl = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.NameLbl.Location = new System.Drawing.Point(5, 3);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(38, 13);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Name:";
            // 
            // levelLbl
            // 
            this.levelLbl.AutoSize = true;
            this.levelLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.levelLbl.Location = new System.Drawing.Point(83, 3);
            this.levelLbl.Name = "levelLbl";
            this.levelLbl.Size = new System.Drawing.Size(36, 13);
            this.levelLbl.TabIndex = 1;
            this.levelLbl.Text = "Level:";
            // 
            // ClassLbl
            // 
            this.ClassLbl.AutoSize = true;
            this.ClassLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.ClassLbl.Location = new System.Drawing.Point(5, 37);
            this.ClassLbl.Name = "ClassLbl";
            this.ClassLbl.Size = new System.Drawing.Size(34, 13);
            this.ClassLbl.TabIndex = 2;
            this.ClassLbl.Text = "class:";
            // 
            // GoldLbl
            // 
            this.GoldLbl.AutoSize = true;
            this.GoldLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.GoldLbl.Location = new System.Drawing.Point(83, 37);
            this.GoldLbl.Name = "GoldLbl";
            this.GoldLbl.Size = new System.Drawing.Size(32, 13);
            this.GoldLbl.TabIndex = 3;
            this.GoldLbl.Text = "Gold:";
            // 
            // HpLbl
            // 
            this.HpLbl.AutoSize = true;
            this.HpLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.HpLbl.Location = new System.Drawing.Point(163, 3);
            this.HpLbl.Name = "HpLbl";
            this.HpLbl.Size = new System.Drawing.Size(25, 13);
            this.HpLbl.TabIndex = 4;
            this.HpLbl.Text = "HP:";
            // 
            // StrengthLbl
            // 
            this.StrengthLbl.AutoSize = true;
            this.StrengthLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.StrengthLbl.Location = new System.Drawing.Point(5, 80);
            this.StrengthLbl.Name = "StrengthLbl";
            this.StrengthLbl.Size = new System.Drawing.Size(53, 13);
            this.StrengthLbl.TabIndex = 5;
            this.StrengthLbl.Text = "Strength: ";
            // 
            // DexLbl
            // 
            this.DexLbl.AutoSize = true;
            this.DexLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.DexLbl.Location = new System.Drawing.Point(5, 110);
            this.DexLbl.Name = "DexLbl";
            this.DexLbl.Size = new System.Drawing.Size(54, 13);
            this.DexLbl.TabIndex = 6;
            this.DexLbl.Text = "Dexterity: ";
            // 
            // constitutionLbl
            // 
            this.constitutionLbl.AutoSize = true;
            this.constitutionLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.constitutionLbl.Location = new System.Drawing.Point(5, 140);
            this.constitutionLbl.Name = "constitutionLbl";
            this.constitutionLbl.Size = new System.Drawing.Size(68, 13);
            this.constitutionLbl.TabIndex = 7;
            this.constitutionLbl.Text = "Constitution: ";
            // 
            // IntLbl
            // 
            this.IntLbl.AutoSize = true;
            this.IntLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.IntLbl.Location = new System.Drawing.Point(5, 170);
            this.IntLbl.Name = "IntLbl";
            this.IntLbl.Size = new System.Drawing.Size(64, 13);
            this.IntLbl.TabIndex = 9;
            this.IntLbl.Text = "Intelligence:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(5, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Wisdom:";
            // 
            // CharismaLbl
            // 
            this.CharismaLbl.AutoSize = true;
            this.CharismaLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.CharismaLbl.Location = new System.Drawing.Point(5, 230);
            this.CharismaLbl.Name = "CharismaLbl";
            this.CharismaLbl.Size = new System.Drawing.Size(53, 13);
            this.CharismaLbl.TabIndex = 11;
            this.CharismaLbl.Text = "Charisma:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(40, 0);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(38, 20);
            this.textBox7.TabIndex = 18;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(190, 0);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(38, 20);
            this.textBox9.TabIndex = 20;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(40, 35);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(38, 20);
            this.textBox10.TabIndex = 21;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(190, 35);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(38, 20);
            this.textBox11.TabIndex = 23;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(120, 35);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(38, 20);
            this.textBox12.TabIndex = 22;
            // 
            // xpLbl
            // 
            this.xpLbl.AutoSize = true;
            this.xpLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.xpLbl.Location = new System.Drawing.Point(163, 37);
            this.xpLbl.Name = "xpLbl";
            this.xpLbl.Size = new System.Drawing.Size(24, 13);
            this.xpLbl.TabIndex = 24;
            this.xpLbl.Text = "XP:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(75, 200);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown1.TabIndex = 25;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(75, 230);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown2.TabIndex = 26;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(75, 168);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown3.TabIndex = 27;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(75, 140);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown4.TabIndex = 28;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(75, 111);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown5.TabIndex = 29;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(75, 78);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown6.TabIndex = 30;
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(119, 0);
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown7.TabIndex = 31;
            // 
            // StatsControl
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.numericUpDown7);
            this.Controls.Add(this.numericUpDown6);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.xpLbl);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.CharismaLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IntLbl);
            this.Controls.Add(this.constitutionLbl);
            this.Controls.Add(this.DexLbl);
            this.Controls.Add(this.StrengthLbl);
            this.Controls.Add(this.HpLbl);
            this.Controls.Add(this.GoldLbl);
            this.Controls.Add(this.ClassLbl);
            this.Controls.Add(this.levelLbl);
            this.Controls.Add(this.NameLbl);
            this.Name = "StatsControl";
            this.Size = new System.Drawing.Size(231, 309);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}