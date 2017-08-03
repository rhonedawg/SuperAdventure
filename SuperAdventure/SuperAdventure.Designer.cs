/*
 * Created by SharpDevelop.
 * User: Ross
 * Date: 6/22/2017
 * Time: 8:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SuperAdventure
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbHitPoints;
		private System.Windows.Forms.Label lbGold;
		private System.Windows.Forms.Label lbExperience;
		private System.Windows.Forms.Label lbLevel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cboWeapons;
		private System.Windows.Forms.ComboBox cboPotions;
		private System.Windows.Forms.Button btnUseWeapon;
		private System.Windows.Forms.Button btnUsePotion;
		private System.Windows.Forms.Button btnNorth;
		private System.Windows.Forms.Button btnEast;
		private System.Windows.Forms.Button btnSouth;
		private System.Windows.Forms.Button btnWest;
		private System.Windows.Forms.RichTextBox rtbLocation;
		private System.Windows.Forms.RichTextBox rtbMessages;
		private System.Windows.Forms.DataGridView dgvInventory;
		private System.Windows.Forms.DataGridView dgvQuests;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lbHitPoints = new System.Windows.Forms.Label();
			this.lbGold = new System.Windows.Forms.Label();
			this.lbExperience = new System.Windows.Forms.Label();
			this.lbLevel = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cboWeapons = new System.Windows.Forms.ComboBox();
			this.cboPotions = new System.Windows.Forms.ComboBox();
			this.btnUseWeapon = new System.Windows.Forms.Button();
			this.btnUsePotion = new System.Windows.Forms.Button();
			this.btnNorth = new System.Windows.Forms.Button();
			this.btnEast = new System.Windows.Forms.Button();
			this.btnSouth = new System.Windows.Forms.Button();
			this.btnWest = new System.Windows.Forms.Button();
			this.rtbLocation = new System.Windows.Forms.RichTextBox();
			this.rtbMessages = new System.Windows.Forms.RichTextBox();
			this.dgvInventory = new System.Windows.Forms.DataGridView();
			this.dgvQuests = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(18, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Hit Points:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(18, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Gold:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(18, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Experience:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(18, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Level:";
			// 
			// lbHitPoints
			// 
			this.lbHitPoints.Location = new System.Drawing.Point(110, 19);
			this.lbHitPoints.Name = "lbHitPoints";
			this.lbHitPoints.Size = new System.Drawing.Size(100, 23);
			this.lbHitPoints.TabIndex = 4;
			// 
			// lbGold
			// 
			this.lbGold.Location = new System.Drawing.Point(110, 45);
			this.lbGold.Name = "lbGold";
			this.lbGold.Size = new System.Drawing.Size(100, 23);
			this.lbGold.TabIndex = 5;
			// 
			// lbExperience
			// 
			this.lbExperience.Location = new System.Drawing.Point(110, 73);
			this.lbExperience.Name = "lbExperience";
			this.lbExperience.Size = new System.Drawing.Size(100, 23);
			this.lbExperience.TabIndex = 6;
			// 
			// lbLevel
			// 
			this.lbLevel.Location = new System.Drawing.Point(110, 99);
			this.lbLevel.Name = "lbLevel";
			this.lbLevel.Size = new System.Drawing.Size(100, 23);
			this.lbLevel.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(617, 531);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Select action";
			// 
			// cboWeapons
			// 
			this.cboWeapons.FormattingEnabled = true;
			this.cboWeapons.Location = new System.Drawing.Point(369, 559);
			this.cboWeapons.Name = "cboWeapons";
			this.cboWeapons.Size = new System.Drawing.Size(121, 21);
			this.cboWeapons.TabIndex = 9;
			// 
			// cboPotions
			// 
			this.cboPotions.FormattingEnabled = true;
			this.cboPotions.Location = new System.Drawing.Point(369, 593);
			this.cboPotions.Name = "cboPotions";
			this.cboPotions.Size = new System.Drawing.Size(121, 21);
			this.cboPotions.TabIndex = 10;
			// 
			// btnUseWeapon
			// 
			this.btnUseWeapon.Location = new System.Drawing.Point(620, 559);
			this.btnUseWeapon.Name = "btnUseWeapon";
			this.btnUseWeapon.Size = new System.Drawing.Size(75, 23);
			this.btnUseWeapon.TabIndex = 11;
			this.btnUseWeapon.Text = "Use";
			this.btnUseWeapon.UseVisualStyleBackColor = true;
			this.btnUseWeapon.Click += new System.EventHandler(this.BtnUseWeaponClick);
			// 
			// btnUsePotion
			// 
			this.btnUsePotion.Location = new System.Drawing.Point(620, 593);
			this.btnUsePotion.Name = "btnUsePotion";
			this.btnUsePotion.Size = new System.Drawing.Size(75, 23);
			this.btnUsePotion.TabIndex = 12;
			this.btnUsePotion.Text = "Use";
			this.btnUsePotion.UseVisualStyleBackColor = true;
			this.btnUsePotion.Click += new System.EventHandler(this.BtnUsePotionClick);
			// 
			// btnNorth
			// 
			this.btnNorth.Location = new System.Drawing.Point(493, 433);
			this.btnNorth.Name = "btnNorth";
			this.btnNorth.Size = new System.Drawing.Size(75, 23);
			this.btnNorth.TabIndex = 13;
			this.btnNorth.Text = "North";
			this.btnNorth.UseVisualStyleBackColor = true;
			this.btnNorth.Click += new System.EventHandler(this.BtnNorthClick);
			// 
			// btnEast
			// 
			this.btnEast.Location = new System.Drawing.Point(573, 457);
			this.btnEast.Name = "btnEast";
			this.btnEast.Size = new System.Drawing.Size(75, 23);
			this.btnEast.TabIndex = 14;
			this.btnEast.Text = "East";
			this.btnEast.UseVisualStyleBackColor = true;
			this.btnEast.Click += new System.EventHandler(this.BtnEastClick);
			// 
			// btnSouth
			// 
			this.btnSouth.Location = new System.Drawing.Point(493, 487);
			this.btnSouth.Name = "btnSouth";
			this.btnSouth.Size = new System.Drawing.Size(75, 23);
			this.btnSouth.TabIndex = 15;
			this.btnSouth.Text = "South";
			this.btnSouth.UseVisualStyleBackColor = true;
			this.btnSouth.Click += new System.EventHandler(this.BtnSouthClick);
			// 
			// btnWest
			// 
			this.btnWest.Location = new System.Drawing.Point(412, 457);
			this.btnWest.Name = "btnWest";
			this.btnWest.Size = new System.Drawing.Size(75, 23);
			this.btnWest.TabIndex = 16;
			this.btnWest.Text = "West";
			this.btnWest.UseVisualStyleBackColor = true;
			this.btnWest.Click += new System.EventHandler(this.BtnWestClick);
			// 
			// rtbLocation
			// 
			this.rtbLocation.Location = new System.Drawing.Point(347, 19);
			this.rtbLocation.Name = "rtbLocation";
			this.rtbLocation.ReadOnly = true;
			this.rtbLocation.Size = new System.Drawing.Size(360, 105);
			this.rtbLocation.TabIndex = 17;
			this.rtbLocation.Text = "";
			// 
			// rtbMessages
			// 
			this.rtbMessages.Location = new System.Drawing.Point(347, 130);
			this.rtbMessages.Name = "rtbMessages";
			this.rtbMessages.ReadOnly = true;
			this.rtbMessages.Size = new System.Drawing.Size(360, 286);
			this.rtbMessages.TabIndex = 18;
			this.rtbMessages.Text = "";
			// 
			// dgvInventory
			// 
			this.dgvInventory.AllowUserToAddRows = false;
			this.dgvInventory.AllowUserToDeleteRows = false;
			this.dgvInventory.AllowUserToResizeRows = false;
			this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvInventory.Enabled = false;
			this.dgvInventory.Location = new System.Drawing.Point(16, 130);
			this.dgvInventory.MultiSelect = false;
			this.dgvInventory.Name = "dgvInventory";
			this.dgvInventory.ReadOnly = true;
			this.dgvInventory.RowHeadersVisible = false;
			this.dgvInventory.Size = new System.Drawing.Size(312, 309);
			this.dgvInventory.TabIndex = 19;
			// 
			// dgvQuests
			// 
			this.dgvQuests.AllowUserToAddRows = false;
			this.dgvQuests.AllowUserToDeleteRows = false;
			this.dgvQuests.AllowUserToResizeRows = false;
			this.dgvQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvQuests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvQuests.Enabled = false;
			this.dgvQuests.Location = new System.Drawing.Point(16, 446);
			this.dgvQuests.MultiSelect = false;
			this.dgvQuests.Name = "dgvQuests";
			this.dgvQuests.ReadOnly = true;
			this.dgvQuests.RowHeadersVisible = false;
			this.dgvQuests.Size = new System.Drawing.Size(312, 189);
			this.dgvQuests.TabIndex = 20;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(719, 651);
			this.Controls.Add(this.dgvQuests);
			this.Controls.Add(this.dgvInventory);
			this.Controls.Add(this.rtbMessages);
			this.Controls.Add(this.rtbLocation);
			this.Controls.Add(this.btnWest);
			this.Controls.Add(this.btnSouth);
			this.Controls.Add(this.btnEast);
			this.Controls.Add(this.btnNorth);
			this.Controls.Add(this.btnUsePotion);
			this.Controls.Add(this.btnUseWeapon);
			this.Controls.Add(this.cboPotions);
			this.Controls.Add(this.cboWeapons);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lbLevel);
			this.Controls.Add(this.lbExperience);
			this.Controls.Add(this.lbGold);
			this.Controls.Add(this.lbHitPoints);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "SuperAdventure";
			((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
