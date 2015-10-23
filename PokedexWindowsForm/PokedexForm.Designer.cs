using System.Windows.Forms;

namespace PokedexWindowsForm
{
    partial class PokedexForm
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
            this.pokemonSprite = new System.Windows.Forms.PictureBox();
            this.pokemonSplitContainer = new System.Windows.Forms.SplitContainer();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.labelMaleFemaleRatio = new System.Windows.Forms.Label();
            this.labelPokemonName = new System.Windows.Forms.Label();
            this.labelGrowthRate = new System.Windows.Forms.Label();
            this.labelEvYield = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSpecialDefence = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSpecialAttack = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDefence = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelAttack = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelHP = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelAbilities = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelSpecies = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panelMoveList = new System.Windows.Forms.Panel();
            this.labelMovesList = new System.Windows.Forms.Label();
            this.listViewMoveList = new System.Windows.Forms.ListView();
            this.columnHeaderLearnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pokemonSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonSplitContainer)).BeginInit();
            this.pokemonSplitContainer.Panel1.SuspendLayout();
            this.pokemonSplitContainer.Panel2.SuspendLayout();
            this.pokemonSplitContainer.SuspendLayout();
            this.panelDetails.SuspendLayout();
            this.panelMoveList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pokemonSprite
            // 
            this.pokemonSprite.Location = new System.Drawing.Point(15, 27);
            this.pokemonSprite.Name = "pokemonSprite";
            this.pokemonSprite.Size = new System.Drawing.Size(164, 129);
            this.pokemonSprite.TabIndex = 0;
            this.pokemonSprite.TabStop = false;
            // 
            // pokemonSplitContainer
            // 
            this.pokemonSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pokemonSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.pokemonSplitContainer.Name = "pokemonSplitContainer";
            // 
            // pokemonSplitContainer.Panel1
            // 
            this.pokemonSplitContainer.Panel1.Controls.Add(this.panelDetails);
            // 
            // pokemonSplitContainer.Panel2
            // 
            this.pokemonSplitContainer.Panel2.Controls.Add(this.panelMoveList);
            this.pokemonSplitContainer.Size = new System.Drawing.Size(723, 495);
            this.pokemonSplitContainer.SplitterDistance = 260;
            this.pokemonSplitContainer.TabIndex = 5;
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.labelMaleFemaleRatio);
            this.panelDetails.Controls.Add(this.labelPokemonName);
            this.panelDetails.Controls.Add(this.labelGrowthRate);
            this.panelDetails.Controls.Add(this.pokemonSprite);
            this.panelDetails.Controls.Add(this.labelEvYield);
            this.panelDetails.Controls.Add(this.label1);
            this.panelDetails.Controls.Add(this.labelSpeed);
            this.panelDetails.Controls.Add(this.label2);
            this.panelDetails.Controls.Add(this.labelSpecialDefence);
            this.panelDetails.Controls.Add(this.label3);
            this.panelDetails.Controls.Add(this.labelSpecialAttack);
            this.panelDetails.Controls.Add(this.label4);
            this.panelDetails.Controls.Add(this.labelDefence);
            this.panelDetails.Controls.Add(this.label5);
            this.panelDetails.Controls.Add(this.labelAttack);
            this.panelDetails.Controls.Add(this.label6);
            this.panelDetails.Controls.Add(this.labelHP);
            this.panelDetails.Controls.Add(this.label7);
            this.panelDetails.Controls.Add(this.labelAbilities);
            this.panelDetails.Controls.Add(this.label8);
            this.panelDetails.Controls.Add(this.labelType);
            this.panelDetails.Controls.Add(this.label9);
            this.panelDetails.Controls.Add(this.labelSpecies);
            this.panelDetails.Controls.Add(this.label10);
            this.panelDetails.Controls.Add(this.label13);
            this.panelDetails.Controls.Add(this.label11);
            this.panelDetails.Controls.Add(this.label12);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetails.Location = new System.Drawing.Point(0, 0);
            this.panelDetails.MinimumSize = new System.Drawing.Size(261, 490);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(261, 495);
            this.panelDetails.TabIndex = 27;
            // 
            // labelMaleFemaleRatio
            // 
            this.labelMaleFemaleRatio.AutoSize = true;
            this.labelMaleFemaleRatio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaleFemaleRatio.Location = new System.Drawing.Point(120, 443);
            this.labelMaleFemaleRatio.Name = "labelMaleFemaleRatio";
            this.labelMaleFemaleRatio.Size = new System.Drawing.Size(131, 14);
            this.labelMaleFemaleRatio.TabIndex = 26;
            this.labelMaleFemaleRatio.Text = "{{ labelMaleFemaleRatio }}";
            // 
            // labelPokemonName
            // 
            this.labelPokemonName.AutoSize = true;
            this.labelPokemonName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPokemonName.Location = new System.Drawing.Point(12, 9);
            this.labelPokemonName.Name = "labelPokemonName";
            this.labelPokemonName.Size = new System.Drawing.Size(145, 14);
            this.labelPokemonName.TabIndex = 1;
            this.labelPokemonName.Text = "{{ pokemon name label }}";
            // 
            // labelGrowthRate
            // 
            this.labelGrowthRate.AutoSize = true;
            this.labelGrowthRate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrowthRate.Location = new System.Drawing.Point(84, 421);
            this.labelGrowthRate.Name = "labelGrowthRate";
            this.labelGrowthRate.Size = new System.Drawing.Size(110, 14);
            this.labelGrowthRate.TabIndex = 25;
            this.labelGrowthRate.Text = "{{ labelGrowthRate }}";
            // 
            // labelEvYield
            // 
            this.labelEvYield.AutoSize = true;
            this.labelEvYield.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvYield.Location = new System.Drawing.Point(65, 399);
            this.labelEvYield.Name = "labelEvYield";
            this.labelEvYield.Size = new System.Drawing.Size(87, 14);
            this.labelEvYield.TabIndex = 24;
            this.labelEvYield.Text = "{{ labelEvYield }}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Species: ";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeed.Location = new System.Drawing.Point(63, 372);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(82, 14);
            this.labelSpeed.TabIndex = 23;
            this.labelSpeed.Text = "{{ labelSpeed }}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type:";
            // 
            // labelSpecialDefence
            // 
            this.labelSpecialDefence.AutoSize = true;
            this.labelSpecialDefence.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpecialDefence.Location = new System.Drawing.Point(111, 348);
            this.labelSpecialDefence.Name = "labelSpecialDefence";
            this.labelSpecialDefence.Size = new System.Drawing.Size(127, 14);
            this.labelSpecialDefence.TabIndex = 22;
            this.labelSpecialDefence.Text = "{{ labelSpecialDefence }}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Abilities:";
            // 
            // labelSpecialAttack
            // 
            this.labelSpecialAttack.AutoSize = true;
            this.labelSpecialAttack.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpecialAttack.Location = new System.Drawing.Point(102, 325);
            this.labelSpecialAttack.Name = "labelSpecialAttack";
            this.labelSpecialAttack.Size = new System.Drawing.Size(117, 14);
            this.labelSpecialAttack.TabIndex = 21;
            this.labelSpecialAttack.Text = "{{ labelSpecialAttack }}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Stats:";
            // 
            // labelDefence
            // 
            this.labelDefence.AutoSize = true;
            this.labelDefence.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDefence.Location = new System.Drawing.Point(73, 301);
            this.labelDefence.Name = "labelDefence";
            this.labelDefence.Size = new System.Drawing.Size(92, 14);
            this.labelDefence.TabIndex = 20;
            this.labelDefence.Text = "{{ labelDefence }}";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "HP:";
            // 
            // labelAttack
            // 
            this.labelAttack.AutoSize = true;
            this.labelAttack.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAttack.Location = new System.Drawing.Point(63, 277);
            this.labelAttack.Name = "labelAttack";
            this.labelAttack.Size = new System.Drawing.Size(82, 14);
            this.labelAttack.TabIndex = 19;
            this.labelAttack.Text = "{{ labelAttack }}";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 14);
            this.label6.TabIndex = 7;
            this.label6.Text = "Attack:";
            // 
            // labelHP
            // 
            this.labelHP.AutoSize = true;
            this.labelHP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHP.Location = new System.Drawing.Point(47, 254);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(64, 14);
            this.labelHP.TabIndex = 18;
            this.labelHP.Text = "{{ labelHP }}";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 14);
            this.label7.TabIndex = 8;
            this.label7.Text = "Defence:";
            // 
            // labelAbilities
            // 
            this.labelAbilities.AutoSize = true;
            this.labelAbilities.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAbilities.Location = new System.Drawing.Point(59, 208);
            this.labelAbilities.Name = "labelAbilities";
            this.labelAbilities.Size = new System.Drawing.Size(88, 14);
            this.labelAbilities.TabIndex = 17;
            this.labelAbilities.Text = "{{ labelAbilities }}";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 14);
            this.label8.TabIndex = 9;
            this.label8.Text = "Special Attack:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(47, 185);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(74, 14);
            this.labelType.TabIndex = 16;
            this.labelType.Text = "{{ labelType }}";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 14);
            this.label9.TabIndex = 10;
            this.label9.Text = "Special Defence:";
            // 
            // labelSpecies
            // 
            this.labelSpecies.AutoSize = true;
            this.labelSpecies.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpecies.Location = new System.Drawing.Point(63, 163);
            this.labelSpecies.Name = "labelSpecies";
            this.labelSpecies.Size = new System.Drawing.Size(90, 14);
            this.labelSpecies.TabIndex = 15;
            this.labelSpecies.Text = "{{ labelSpecies }}";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 14);
            this.label10.TabIndex = 11;
            this.label10.Text = "Speed:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 443);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 14);
            this.label13.TabIndex = 14;
            this.label13.Text = "Male / Female Ratio:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 399);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 14);
            this.label11.TabIndex = 12;
            this.label11.Text = "EV Yield:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 421);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 14);
            this.label12.TabIndex = 13;
            this.label12.Text = "Growth Rate:";
            // 
            // panelMoveList
            // 
            this.panelMoveList.Controls.Add(this.labelMovesList);
            this.panelMoveList.Controls.Add(this.listViewMoveList);
            this.panelMoveList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMoveList.Location = new System.Drawing.Point(0, 0);
            this.panelMoveList.Name = "panelMoveList";
            this.panelMoveList.Size = new System.Drawing.Size(459, 495);
            this.panelMoveList.TabIndex = 1;
            // 
            // labelMovesList
            // 
            this.labelMovesList.AutoSize = true;
            this.labelMovesList.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMovesList.Location = new System.Drawing.Point(12, 9);
            this.labelMovesList.Name = "labelMovesList";
            this.labelMovesList.Size = new System.Drawing.Size(61, 14);
            this.labelMovesList.TabIndex = 1;
            this.labelMovesList.Text = "Move List";
            // 
            // listViewMoveList
            // 
            this.listViewMoveList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderLearnType,
            this.columnHeaderLevel,
            this.columnHeaderName,
            this.columnHeaderPP});
            this.listViewMoveList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewMoveList.GridLines = true;
            this.listViewMoveList.Location = new System.Drawing.Point(0, 32);
            this.listViewMoveList.MultiSelect = false;
            this.listViewMoveList.Name = "listViewMoveList";
            this.listViewMoveList.Size = new System.Drawing.Size(459, 463);
            this.listViewMoveList.TabIndex = 0;
            this.listViewMoveList.UseCompatibleStateImageBehavior = false;
            this.listViewMoveList.View = System.Windows.Forms.View.Details;
            this.listViewMoveList.ColumnClick += new ColumnClickEventHandler(listViewMoveList_ColumnClick);
            // 
            // columnHeaderLearnType
            // 
            this.columnHeaderLearnType.Text = "Learn Type";
            this.columnHeaderLearnType.Width = 85;
            // 
            // columnHeaderLevel
            // 
            this.columnHeaderLevel.Text = "Level";
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 267;
            // 
            // columnHeaderPP
            // 
            this.columnHeaderPP.Text = "PP";
            this.columnHeaderPP.Width = 43;
            // 
            // PokedexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 495);
            this.Controls.Add(this.pokemonSplitContainer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(739, 534);
            this.Name = "PokedexForm";
            this.Text = "Pokedex";
            ((System.ComponentModel.ISupportInitialize)(this.pokemonSprite)).EndInit();
            this.pokemonSplitContainer.Panel1.ResumeLayout(false);
            this.pokemonSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pokemonSplitContainer)).EndInit();
            this.pokemonSplitContainer.ResumeLayout(false);
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.panelMoveList.ResumeLayout(false);
            this.panelMoveList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pokemonSprite;
        private System.Windows.Forms.SplitContainer pokemonSplitContainer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPokemonName;
        private System.Windows.Forms.ListView listViewMoveList;
        private System.Windows.Forms.ColumnHeader columnHeaderLearnType;
        private System.Windows.Forms.ColumnHeader columnHeaderLevel;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.Label labelEvYield;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelSpecialDefence;
        private System.Windows.Forms.Label labelSpecialAttack;
        private System.Windows.Forms.Label labelDefence;
        private System.Windows.Forms.Label labelAttack;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Label labelAbilities;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelSpecies;
        private System.Windows.Forms.Label labelGrowthRate;
        private System.Windows.Forms.Label labelMaleFemaleRatio;
        private System.Windows.Forms.ColumnHeader columnHeaderPP;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Panel panelMoveList;
        private System.Windows.Forms.Label labelMovesList;
    }
}

