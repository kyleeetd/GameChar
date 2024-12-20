namespace Game_Character
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtHealth = new System.Windows.Forms.TextBox();
            this.txtStrength = new System.Windows.Forms.TextBox();
            this.txtMana = new System.Windows.Forms.TextBox();
            this.txtIntelligence = new System.Windows.Forms.TextBox();
            this.cmbCharacterType = new System.Windows.Forms.ComboBox();
            this.txtCharacterDetails = new System.Windows.Forms.TextBox();
            this.btnaddcharacter = new System.Windows.Forms.Button();
            this.btnselectcharacter = new System.Windows.Forms.Button();
            this.btnattack = new System.Windows.Forms.Button();
            this.btndefend = new System.Windows.Forms.Button();
            this.btnlevelup = new System.Windows.Forms.Button();
            this.pictureboxmage = new System.Windows.Forms.PictureBox();
            this.timermovement = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxwarrior = new System.Windows.Forms.PictureBox();
            this.pictureBoxopponent = new System.Windows.Forms.PictureBox();
            this.listBoxCharacter = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxmage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxwarrior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxopponent)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtName.Location = new System.Drawing.Point(33, 56);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(249, 24);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "\r\nName:";
            this.txtName.UseWaitCursor = true;
            this.txtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // txtLevel
            // 
            this.txtLevel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLevel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtLevel.Location = new System.Drawing.Point(33, 111);
            this.txtLevel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(249, 24);
            this.txtLevel.TabIndex = 1;
            this.txtLevel.Text = "Level:";
            this.txtLevel.TextChanged += new System.EventHandler(this.TxtLevel_TextChanged);
            // 
            // txtHealth
            // 
            this.txtHealth.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtHealth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHealth.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtHealth.Location = new System.Drawing.Point(33, 167);
            this.txtHealth.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(249, 24);
            this.txtHealth.TabIndex = 2;
            this.txtHealth.Text = "Health:";
            this.txtHealth.TextChanged += new System.EventHandler(this.TxtHealth_TextChanged);
            // 
            // txtStrength
            // 
            this.txtStrength.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtStrength.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStrength.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtStrength.Location = new System.Drawing.Point(33, 278);
            this.txtStrength.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtStrength.Name = "txtStrength";
            this.txtStrength.Size = new System.Drawing.Size(249, 24);
            this.txtStrength.TabIndex = 3;
            this.txtStrength.Text = "Strength(Warrior):";
            this.txtStrength.TextChanged += new System.EventHandler(this.TxtStrength_TextChanged);
            // 
            // txtMana
            // 
            this.txtMana.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtMana.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMana.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtMana.Location = new System.Drawing.Point(33, 326);
            this.txtMana.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMana.Name = "txtMana";
            this.txtMana.Size = new System.Drawing.Size(200, 24);
            this.txtMana.TabIndex = 4;
            this.txtMana.Text = "Mana(Mage):";
            this.txtMana.TextChanged += new System.EventHandler(this.TxtMana_TextChanged);
            // 
            // txtIntelligence
            // 
            this.txtIntelligence.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtIntelligence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIntelligence.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtIntelligence.Location = new System.Drawing.Point(33, 374);
            this.txtIntelligence.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtIntelligence.Name = "txtIntelligence";
            this.txtIntelligence.Size = new System.Drawing.Size(200, 24);
            this.txtIntelligence.TabIndex = 5;
            this.txtIntelligence.Text = "Intelligence(Mana):";
            this.txtIntelligence.TextChanged += new System.EventHandler(this.TxtIntelligence_TextChanged);
            // 
            // cmbCharacterType
            // 
            this.cmbCharacterType.AutoCompleteCustomSource.AddRange(new string[] {
            "Warrior,",
            "Mage"});
            this.cmbCharacterType.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cmbCharacterType.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbCharacterType.FormattingEnabled = true;
            this.cmbCharacterType.Items.AddRange(new object[] {
            "Warrior,",
            "Mage"});
            this.cmbCharacterType.Location = new System.Drawing.Point(33, 222);
            this.cmbCharacterType.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmbCharacterType.Name = "cmbCharacterType";
            this.cmbCharacterType.Size = new System.Drawing.Size(200, 32);
            this.cmbCharacterType.TabIndex = 6;
            this.cmbCharacterType.Text = "Items: Warrior, Mage";
            this.cmbCharacterType.SelectedIndexChanged += new System.EventHandler(this.CmbCharacterType_SelectedIndexChanged);
            // 
            // txtCharacterDetails
            // 
            this.txtCharacterDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCharacterDetails.AutoCompleteCustomSource.AddRange(new string[] {
            "Name: Lyra Goldenblade",
            "",
            "Appearance:",
            "-",
            "",
            "A tall, athletic young woman with sun-kissed skin and toned muscles, ",
            "  reflecting years of combat training.",
            "-",
            "Have a long, flowing pink hair .",
            "-",
            "Her piercing amber eyes seem to glow with determination"});
            this.txtCharacterDetails.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtCharacterDetails.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCharacterDetails.Location = new System.Drawing.Point(935, 32);
            this.txtCharacterDetails.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCharacterDetails.Multiline = true;
            this.txtCharacterDetails.Name = "txtCharacterDetails";
            this.txtCharacterDetails.ReadOnly = true;
            this.txtCharacterDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCharacterDetails.Size = new System.Drawing.Size(203, 34);
            this.txtCharacterDetails.TabIndex = 8;
            this.txtCharacterDetails.Text = resources.GetString("txtCharacterDetails.Text");
            this.txtCharacterDetails.TextChanged += new System.EventHandler(this.TxtCharacterDetails_TextChanged);
            // 
            // btnaddcharacter
            // 
            this.btnaddcharacter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaddcharacter.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnaddcharacter.Location = new System.Drawing.Point(33, 560);
            this.btnaddcharacter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnaddcharacter.Name = "btnaddcharacter";
            this.btnaddcharacter.Size = new System.Drawing.Size(0, 0);
            this.btnaddcharacter.TabIndex = 10;
            this.btnaddcharacter.Text = "Add Character";
            this.btnaddcharacter.UseVisualStyleBackColor = false;
            this.btnaddcharacter.Click += new System.EventHandler(this.Btnaddcharacter_Click);
            // 
            // btnselectcharacter
            // 
            this.btnselectcharacter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnselectcharacter.BackColor = System.Drawing.Color.DarkCyan;
            this.btnselectcharacter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnselectcharacter.BackgroundImage")));
            this.btnselectcharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnselectcharacter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnselectcharacter.Location = new System.Drawing.Point(54, 644);
            this.btnselectcharacter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnselectcharacter.Name = "btnselectcharacter";
            this.btnselectcharacter.Size = new System.Drawing.Size(0, 0);
            this.btnselectcharacter.TabIndex = 11;
            this.btnselectcharacter.Text = "Select Character";
            this.btnselectcharacter.UseVisualStyleBackColor = false;
            this.btnselectcharacter.Click += new System.EventHandler(this.Btnselectcharacter_Click);
            // 
            // btnattack
            // 
            this.btnattack.BackColor = System.Drawing.Color.Transparent;
            this.btnattack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnattack.BackgroundImage")));
            this.btnattack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnattack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnattack.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnattack.ForeColor = System.Drawing.Color.Lavender;
            this.btnattack.ImageKey = "(none)";
            this.btnattack.Location = new System.Drawing.Point(585, 548);
            this.btnattack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnattack.Name = "btnattack";
            this.btnattack.Size = new System.Drawing.Size(167, 79);
            this.btnattack.TabIndex = 12;
            this.btnattack.Text = "Attack";
            this.btnattack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnattack.UseVisualStyleBackColor = false;
            this.btnattack.Click += new System.EventHandler(this.Btnattack_Click);
            // 
            // btndefend
            // 
            this.btndefend.BackColor = System.Drawing.Color.Transparent;
            this.btndefend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndefend.BackgroundImage")));
            this.btndefend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btndefend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndefend.Font = new System.Drawing.Font("Colonna MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndefend.ForeColor = System.Drawing.Color.Lavender;
            this.btndefend.Location = new System.Drawing.Point(776, 537);
            this.btndefend.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btndefend.Name = "btndefend";
            this.btndefend.Size = new System.Drawing.Size(188, 80);
            this.btndefend.TabIndex = 13;
            this.btndefend.Text = "Defend";
            this.btndefend.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndefend.UseVisualStyleBackColor = false;
            this.btndefend.Click += new System.EventHandler(this.Btndefend_Click);
            // 
            // btnlevelup
            // 
            this.btnlevelup.BackColor = System.Drawing.Color.Transparent;
            this.btnlevelup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlevelup.BackgroundImage")));
            this.btnlevelup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlevelup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlevelup.Font = new System.Drawing.Font("Colonna MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlevelup.ForeColor = System.Drawing.Color.Lavender;
            this.btnlevelup.Location = new System.Drawing.Point(972, 537);
            this.btnlevelup.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnlevelup.Name = "btnlevelup";
            this.btnlevelup.Size = new System.Drawing.Size(184, 80);
            this.btnlevelup.TabIndex = 14;
            this.btnlevelup.Text = "Level Up";
            this.btnlevelup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnlevelup.UseVisualStyleBackColor = false;
            this.btnlevelup.Click += new System.EventHandler(this.Btnlevelup_Click);
            // 
            // pictureboxmage
            // 
            this.pictureboxmage.BackColor = System.Drawing.Color.Transparent;
            this.pictureboxmage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureboxmage.BackgroundImage")));
            this.pictureboxmage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureboxmage.ErrorImage = null;
            this.pictureboxmage.InitialImage = null;
            this.pictureboxmage.Location = new System.Drawing.Point(232, 385);
            this.pictureboxmage.Name = "pictureboxmage";
            this.pictureboxmage.Size = new System.Drawing.Size(108, 129);
            this.pictureboxmage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxmage.TabIndex = 15;
            this.pictureboxmage.TabStop = false;
            this.pictureboxmage.Click += new System.EventHandler(this.Pictureboxcharacter_Click);
            // 
            // timermovement
            // 
            this.timermovement.Enabled = true;
            this.timermovement.Interval = 50;
            // 
            // pictureBoxwarrior
            // 
            this.pictureBoxwarrior.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxwarrior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxwarrior.ErrorImage = null;
            this.pictureBoxwarrior.Image = global::Game_Character.Properties.Resources.character5moving;
            this.pictureBoxwarrior.InitialImage = null;
            this.pictureBoxwarrior.Location = new System.Drawing.Point(328, 142);
            this.pictureBoxwarrior.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pictureBoxwarrior.Name = "pictureBoxwarrior";
            this.pictureBoxwarrior.Size = new System.Drawing.Size(333, 364);
            this.pictureBoxwarrior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxwarrior.TabIndex = 16;
            this.pictureBoxwarrior.TabStop = false;
            this.pictureBoxwarrior.Click += new System.EventHandler(this.PictureBoxwarrior_Click);
            // 
            // pictureBoxopponent
            // 
            this.pictureBoxopponent.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxopponent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxopponent.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxopponent.Image")));
            this.pictureBoxopponent.Location = new System.Drawing.Point(720, 142);
            this.pictureBoxopponent.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pictureBoxopponent.Name = "pictureBoxopponent";
            this.pictureBoxopponent.Size = new System.Drawing.Size(362, 403);
            this.pictureBoxopponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxopponent.TabIndex = 17;
            this.pictureBoxopponent.TabStop = false;
            this.pictureBoxopponent.Click += new System.EventHandler(this.pictureBoxopponent_Click);
            // 
            // listBoxCharacter
            // 
            this.listBoxCharacter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxCharacter.BackColor = System.Drawing.Color.DarkSlateGray;
            this.listBoxCharacter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxCharacter.FormattingEnabled = true;
            this.listBoxCharacter.ItemHeight = 24;
            this.listBoxCharacter.Items.AddRange(new object[] {
            "warrior,",
            "mage"});
            this.listBoxCharacter.Location = new System.Drawing.Point(58, 442);
            this.listBoxCharacter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.listBoxCharacter.Name = "listBoxCharacter";
            this.listBoxCharacter.Size = new System.Drawing.Size(65, 48);
            this.listBoxCharacter.TabIndex = 7;
            this.listBoxCharacter.SelectedIndexChanged += new System.EventHandler(this.ListBoxCharacter_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1194, 654);
            this.Controls.Add(this.pictureBoxopponent);
            this.Controls.Add(this.pictureBoxwarrior);
            this.Controls.Add(this.cmbCharacterType);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pictureboxmage);
            this.Controls.Add(this.btnlevelup);
            this.Controls.Add(this.btndefend);
            this.Controls.Add(this.btnattack);
            this.Controls.Add(this.btnselectcharacter);
            this.Controls.Add(this.btnaddcharacter);
            this.Controls.Add(this.txtCharacterDetails);
            this.Controls.Add(this.listBoxCharacter);
            this.Controls.Add(this.txtIntelligence);
            this.Controls.Add(this.txtMana);
            this.Controls.Add(this.txtStrength);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(50, 100);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxmage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxwarrior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxopponent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.TextBox txtHealth;
        private System.Windows.Forms.TextBox txtStrength;
        private System.Windows.Forms.TextBox txtMana;
        private System.Windows.Forms.TextBox txtIntelligence;
        private System.Windows.Forms.ComboBox cmbCharacterType;
        private System.Windows.Forms.TextBox txtCharacterDetails;
        private System.Windows.Forms.Button btnaddcharacter;
        private System.Windows.Forms.Button btnselectcharacter;
        private System.Windows.Forms.Button btnattack;
        private System.Windows.Forms.Button btndefend;
        private System.Windows.Forms.Button btnlevelup;
        private System.Windows.Forms.PictureBox pictureboxmage;
        private System.Windows.Forms.Timer timermovement;
        private System.Windows.Forms.PictureBox pictureBoxwarrior;
        private System.Windows.Forms.PictureBox pictureBoxopponent;
        private System.Windows.Forms.ListBox listBoxCharacter;
    }
}

