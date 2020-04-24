namespace Container_Vervoer
{
    partial class ContainerManagementForm
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
            this.grpbx_ConfigureShip = new System.Windows.Forms.GroupBox();
            this.bttn_SetShipConfiguration = new System.Windows.Forms.Button();
            this.lbl_ShipHeight = new System.Windows.Forms.Label();
            this.lbl_ShipWidth = new System.Windows.Forms.Label();
            this.lbl_ShipLength = new System.Windows.Forms.Label();
            this.nmrc_ShipHeight = new System.Windows.Forms.NumericUpDown();
            this.nmrc_ShipWidth = new System.Windows.Forms.NumericUpDown();
            this.nmrc_ShipLength = new System.Windows.Forms.NumericUpDown();
            this.grpbx_ContainersView = new System.Windows.Forms.GroupBox();
            this.lstbx_containers = new System.Windows.Forms.ListBox();
            this.bttn_SortContainers = new System.Windows.Forms.Button();
            this.bttn_ClearContainers = new System.Windows.Forms.Button();
            this.bttn_RemoveContainer = new System.Windows.Forms.Button();
            this.grpbx_AddContainers = new System.Windows.Forms.GroupBox();
            this.bttn_AddContainers = new System.Windows.Forms.Button();
            this.rdbttn_Cooled = new System.Windows.Forms.RadioButton();
            this.rdbttn_Valuable = new System.Windows.Forms.RadioButton();
            this.rdbttn_Standard = new System.Windows.Forms.RadioButton();
            this.nmrc_TotalContainersToAdd = new System.Windows.Forms.NumericUpDown();
            this.lbl_TotalContainersToAdd = new System.Windows.Forms.Label();
            this.nmrc_ContainerWeight = new System.Windows.Forms.NumericUpDown();
            this.lbl_ContainerWeight = new System.Windows.Forms.Label();
            this.grpbx_SortedContainersOutput = new System.Windows.Forms.GroupBox();
            this.txtbx_Log = new System.Windows.Forms.TextBox();
            this.txtbx_SortedContainers = new System.Windows.Forms.TextBox();
            this.lbl_BalanceShip = new System.Windows.Forms.Label();
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.grpbx_ConfigureShip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrc_ShipHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrc_ShipWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrc_ShipLength)).BeginInit();
            this.grpbx_ContainersView.SuspendLayout();
            this.grpbx_AddContainers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrc_TotalContainersToAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrc_ContainerWeight)).BeginInit();
            this.grpbx_SortedContainersOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbx_ConfigureShip
            // 
            this.grpbx_ConfigureShip.Controls.Add(this.bttn_SetShipConfiguration);
            this.grpbx_ConfigureShip.Controls.Add(this.lbl_ShipHeight);
            this.grpbx_ConfigureShip.Controls.Add(this.lbl_ShipWidth);
            this.grpbx_ConfigureShip.Controls.Add(this.lbl_ShipLength);
            this.grpbx_ConfigureShip.Controls.Add(this.nmrc_ShipHeight);
            this.grpbx_ConfigureShip.Controls.Add(this.nmrc_ShipWidth);
            this.grpbx_ConfigureShip.Controls.Add(this.nmrc_ShipLength);
            this.grpbx_ConfigureShip.Location = new System.Drawing.Point(16, 15);
            this.grpbx_ConfigureShip.Margin = new System.Windows.Forms.Padding(4);
            this.grpbx_ConfigureShip.Name = "grpbx_ConfigureShip";
            this.grpbx_ConfigureShip.Padding = new System.Windows.Forms.Padding(4);
            this.grpbx_ConfigureShip.Size = new System.Drawing.Size(267, 177);
            this.grpbx_ConfigureShip.TabIndex = 0;
            this.grpbx_ConfigureShip.TabStop = false;
            this.grpbx_ConfigureShip.Text = "Configure Ship";
            // 
            // bttn_SetShipConfiguration
            // 
            this.bttn_SetShipConfiguration.Location = new System.Drawing.Point(12, 134);
            this.bttn_SetShipConfiguration.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_SetShipConfiguration.Name = "bttn_SetShipConfiguration";
            this.bttn_SetShipConfiguration.Size = new System.Drawing.Size(247, 28);
            this.bttn_SetShipConfiguration.TabIndex = 2;
            this.bttn_SetShipConfiguration.Text = "Set Ship Configuration";
            this.bttn_SetShipConfiguration.UseVisualStyleBackColor = true;
            this.bttn_SetShipConfiguration.Click += new System.EventHandler(this.bttn_SetShipConfiguration_Click);
            // 
            // lbl_ShipHeight
            // 
            this.lbl_ShipHeight.AutoSize = true;
            this.lbl_ShipHeight.Location = new System.Drawing.Point(8, 101);
            this.lbl_ShipHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ShipHeight.Name = "lbl_ShipHeight";
            this.lbl_ShipHeight.Size = new System.Drawing.Size(81, 17);
            this.lbl_ShipHeight.TabIndex = 5;
            this.lbl_ShipHeight.Text = "Ship Height";
            // 
            // lbl_ShipWidth
            // 
            this.lbl_ShipWidth.AutoSize = true;
            this.lbl_ShipWidth.Location = new System.Drawing.Point(8, 69);
            this.lbl_ShipWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ShipWidth.Name = "lbl_ShipWidth";
            this.lbl_ShipWidth.Size = new System.Drawing.Size(76, 17);
            this.lbl_ShipWidth.TabIndex = 4;
            this.lbl_ShipWidth.Text = "Ship Width";
            // 
            // lbl_ShipLength
            // 
            this.lbl_ShipLength.AutoSize = true;
            this.lbl_ShipLength.Location = new System.Drawing.Point(8, 37);
            this.lbl_ShipLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ShipLength.Name = "lbl_ShipLength";
            this.lbl_ShipLength.Size = new System.Drawing.Size(84, 17);
            this.lbl_ShipLength.TabIndex = 3;
            this.lbl_ShipLength.Text = "Ship Length";
            // 
            // nmrc_ShipHeight
            // 
            this.nmrc_ShipHeight.Location = new System.Drawing.Point(143, 98);
            this.nmrc_ShipHeight.Margin = new System.Windows.Forms.Padding(4);
            this.nmrc_ShipHeight.Name = "nmrc_ShipHeight";
            this.nmrc_ShipHeight.Size = new System.Drawing.Size(124, 22);
            this.nmrc_ShipHeight.TabIndex = 2;
            this.nmrc_ShipHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmrc_ShipWidth
            // 
            this.nmrc_ShipWidth.Location = new System.Drawing.Point(143, 66);
            this.nmrc_ShipWidth.Margin = new System.Windows.Forms.Padding(4);
            this.nmrc_ShipWidth.Name = "nmrc_ShipWidth";
            this.nmrc_ShipWidth.Size = new System.Drawing.Size(124, 22);
            this.nmrc_ShipWidth.TabIndex = 1;
            this.nmrc_ShipWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmrc_ShipLength
            // 
            this.nmrc_ShipLength.Location = new System.Drawing.Point(143, 34);
            this.nmrc_ShipLength.Margin = new System.Windows.Forms.Padding(4);
            this.nmrc_ShipLength.Name = "nmrc_ShipLength";
            this.nmrc_ShipLength.Size = new System.Drawing.Size(124, 22);
            this.nmrc_ShipLength.TabIndex = 0;
            this.nmrc_ShipLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grpbx_ContainersView
            // 
            this.grpbx_ContainersView.Controls.Add(this.lstbx_containers);
            this.grpbx_ContainersView.Controls.Add(this.bttn_SortContainers);
            this.grpbx_ContainersView.Controls.Add(this.bttn_ClearContainers);
            this.grpbx_ContainersView.Controls.Add(this.bttn_RemoveContainer);
            this.grpbx_ContainersView.Location = new System.Drawing.Point(291, 15);
            this.grpbx_ContainersView.Margin = new System.Windows.Forms.Padding(4);
            this.grpbx_ContainersView.Name = "grpbx_ContainersView";
            this.grpbx_ContainersView.Padding = new System.Windows.Forms.Padding(4);
            this.grpbx_ContainersView.Size = new System.Drawing.Size(505, 177);
            this.grpbx_ContainersView.TabIndex = 1;
            this.grpbx_ContainersView.TabStop = false;
            this.grpbx_ContainersView.Text = "Containers";
            // 
            // lstbx_containers
            // 
            this.lstbx_containers.FormattingEnabled = true;
            this.lstbx_containers.ItemHeight = 16;
            this.lstbx_containers.Location = new System.Drawing.Point(7, 27);
            this.lstbx_containers.Name = "lstbx_containers";
            this.lstbx_containers.Size = new System.Drawing.Size(218, 148);
            this.lstbx_containers.TabIndex = 8;
            // 
            // bttn_SortContainers
            // 
            this.bttn_SortContainers.Location = new System.Drawing.Point(232, 118);
            this.bttn_SortContainers.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_SortContainers.Name = "bttn_SortContainers";
            this.bttn_SortContainers.Size = new System.Drawing.Size(160, 28);
            this.bttn_SortContainers.TabIndex = 7;
            this.bttn_SortContainers.Text = "Sort Containers";
            this.bttn_SortContainers.UseVisualStyleBackColor = true;
            this.bttn_SortContainers.Click += new System.EventHandler(this.bttn_SortContainers_Click);
            // 
            // bttn_ClearContainers
            // 
            this.bttn_ClearContainers.Location = new System.Drawing.Point(232, 82);
            this.bttn_ClearContainers.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_ClearContainers.Name = "bttn_ClearContainers";
            this.bttn_ClearContainers.Size = new System.Drawing.Size(160, 28);
            this.bttn_ClearContainers.TabIndex = 6;
            this.bttn_ClearContainers.Text = "Clear Containers";
            this.bttn_ClearContainers.UseVisualStyleBackColor = true;
            this.bttn_ClearContainers.Click += new System.EventHandler(this.bttn_ClearContainers_Click);
            // 
            // bttn_RemoveContainer
            // 
            this.bttn_RemoveContainer.Location = new System.Drawing.Point(232, 47);
            this.bttn_RemoveContainer.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_RemoveContainer.Name = "bttn_RemoveContainer";
            this.bttn_RemoveContainer.Size = new System.Drawing.Size(160, 28);
            this.bttn_RemoveContainer.TabIndex = 5;
            this.bttn_RemoveContainer.Text = "Remove Container";
            this.bttn_RemoveContainer.UseVisualStyleBackColor = true;
            this.bttn_RemoveContainer.Click += new System.EventHandler(this.bttn_RemoveContainer_Click);
            // 
            // grpbx_AddContainers
            // 
            this.grpbx_AddContainers.Controls.Add(this.bttn_AddContainers);
            this.grpbx_AddContainers.Controls.Add(this.rdbttn_Cooled);
            this.grpbx_AddContainers.Controls.Add(this.rdbttn_Valuable);
            this.grpbx_AddContainers.Controls.Add(this.rdbttn_Standard);
            this.grpbx_AddContainers.Controls.Add(this.nmrc_TotalContainersToAdd);
            this.grpbx_AddContainers.Controls.Add(this.lbl_TotalContainersToAdd);
            this.grpbx_AddContainers.Controls.Add(this.nmrc_ContainerWeight);
            this.grpbx_AddContainers.Controls.Add(this.lbl_ContainerWeight);
            this.grpbx_AddContainers.Location = new System.Drawing.Point(804, 15);
            this.grpbx_AddContainers.Margin = new System.Windows.Forms.Padding(4);
            this.grpbx_AddContainers.Name = "grpbx_AddContainers";
            this.grpbx_AddContainers.Padding = new System.Windows.Forms.Padding(4);
            this.grpbx_AddContainers.Size = new System.Drawing.Size(392, 177);
            this.grpbx_AddContainers.TabIndex = 2;
            this.grpbx_AddContainers.TabStop = false;
            this.grpbx_AddContainers.Text = "Add Containers";
            // 
            // bttn_AddContainers
            // 
            this.bttn_AddContainers.Location = new System.Drawing.Point(12, 142);
            this.bttn_AddContainers.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_AddContainers.Name = "bttn_AddContainers";
            this.bttn_AddContainers.Size = new System.Drawing.Size(372, 28);
            this.bttn_AddContainers.TabIndex = 7;
            this.bttn_AddContainers.Text = "Add Containers";
            this.bttn_AddContainers.UseVisualStyleBackColor = true;
            this.bttn_AddContainers.Click += new System.EventHandler(this.bttn_AddContainers_Click);
            // 
            // rdbttn_Cooled
            // 
            this.rdbttn_Cooled.AutoSize = true;
            this.rdbttn_Cooled.Location = new System.Drawing.Point(252, 78);
            this.rdbttn_Cooled.Margin = new System.Windows.Forms.Padding(4);
            this.rdbttn_Cooled.Name = "rdbttn_Cooled";
            this.rdbttn_Cooled.Size = new System.Drawing.Size(73, 21);
            this.rdbttn_Cooled.TabIndex = 6;
            this.rdbttn_Cooled.Text = "Cooled";
            this.rdbttn_Cooled.UseVisualStyleBackColor = true;
            // 
            // rdbttn_Valuable
            // 
            this.rdbttn_Valuable.AutoSize = true;
            this.rdbttn_Valuable.Location = new System.Drawing.Point(252, 47);
            this.rdbttn_Valuable.Margin = new System.Windows.Forms.Padding(4);
            this.rdbttn_Valuable.Name = "rdbttn_Valuable";
            this.rdbttn_Valuable.Size = new System.Drawing.Size(84, 21);
            this.rdbttn_Valuable.TabIndex = 5;
            this.rdbttn_Valuable.Text = "Valuable";
            this.rdbttn_Valuable.UseVisualStyleBackColor = true;
            // 
            // rdbttn_Standard
            // 
            this.rdbttn_Standard.AutoSize = true;
            this.rdbttn_Standard.Checked = true;
            this.rdbttn_Standard.Location = new System.Drawing.Point(252, 16);
            this.rdbttn_Standard.Margin = new System.Windows.Forms.Padding(4);
            this.rdbttn_Standard.Name = "rdbttn_Standard";
            this.rdbttn_Standard.Size = new System.Drawing.Size(87, 21);
            this.rdbttn_Standard.TabIndex = 4;
            this.rdbttn_Standard.TabStop = true;
            this.rdbttn_Standard.Text = "Standard";
            this.rdbttn_Standard.UseVisualStyleBackColor = true;
            // 
            // nmrc_TotalContainersToAdd
            // 
            this.nmrc_TotalContainersToAdd.Location = new System.Drawing.Point(12, 102);
            this.nmrc_TotalContainersToAdd.Margin = new System.Windows.Forms.Padding(4);
            this.nmrc_TotalContainersToAdd.Name = "nmrc_TotalContainersToAdd";
            this.nmrc_TotalContainersToAdd.Size = new System.Drawing.Size(199, 22);
            this.nmrc_TotalContainersToAdd.TabIndex = 3;
            this.nmrc_TotalContainersToAdd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_TotalContainersToAdd
            // 
            this.lbl_TotalContainersToAdd.AutoSize = true;
            this.lbl_TotalContainersToAdd.Location = new System.Drawing.Point(8, 75);
            this.lbl_TotalContainersToAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TotalContainersToAdd.Name = "lbl_TotalContainersToAdd";
            this.lbl_TotalContainersToAdd.Size = new System.Drawing.Size(166, 17);
            this.lbl_TotalContainersToAdd.TabIndex = 2;
            this.lbl_TotalContainersToAdd.Text = "Total Containers To Add:";
            // 
            // nmrc_ContainerWeight
            // 
            this.nmrc_ContainerWeight.Location = new System.Drawing.Point(12, 47);
            this.nmrc_ContainerWeight.Margin = new System.Windows.Forms.Padding(4);
            this.nmrc_ContainerWeight.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nmrc_ContainerWeight.Name = "nmrc_ContainerWeight";
            this.nmrc_ContainerWeight.Size = new System.Drawing.Size(199, 22);
            this.nmrc_ContainerWeight.TabIndex = 1;
            // 
            // lbl_ContainerWeight
            // 
            this.lbl_ContainerWeight.AutoSize = true;
            this.lbl_ContainerWeight.Location = new System.Drawing.Point(8, 20);
            this.lbl_ContainerWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ContainerWeight.Name = "lbl_ContainerWeight";
            this.lbl_ContainerWeight.Size = new System.Drawing.Size(121, 17);
            this.lbl_ContainerWeight.TabIndex = 0;
            this.lbl_ContainerWeight.Text = "Container Weight:";
            // 
            // grpbx_SortedContainersOutput
            // 
            this.grpbx_SortedContainersOutput.Controls.Add(this.lbl_BalanceShip);
            this.grpbx_SortedContainersOutput.Controls.Add(this.lbl_Balance);
            this.grpbx_SortedContainersOutput.Controls.Add(this.txtbx_Log);
            this.grpbx_SortedContainersOutput.Controls.Add(this.txtbx_SortedContainers);
            this.grpbx_SortedContainersOutput.Location = new System.Drawing.Point(16, 199);
            this.grpbx_SortedContainersOutput.Margin = new System.Windows.Forms.Padding(4);
            this.grpbx_SortedContainersOutput.Name = "grpbx_SortedContainersOutput";
            this.grpbx_SortedContainersOutput.Padding = new System.Windows.Forms.Padding(4);
            this.grpbx_SortedContainersOutput.Size = new System.Drawing.Size(1172, 340);
            this.grpbx_SortedContainersOutput.TabIndex = 3;
            this.grpbx_SortedContainersOutput.TabStop = false;
            this.grpbx_SortedContainersOutput.Text = "Output (Sorted Containers):";
            // 
            // txtbx_Log
            // 
            this.txtbx_Log.AllowDrop = true;
            this.txtbx_Log.Location = new System.Drawing.Point(508, 24);
            this.txtbx_Log.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_Log.Multiline = true;
            this.txtbx_Log.Name = "txtbx_Log";
            this.txtbx_Log.ReadOnly = true;
            this.txtbx_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbx_Log.Size = new System.Drawing.Size(492, 308);
            this.txtbx_Log.TabIndex = 1;
            // 
            // txtbx_SortedContainers
            // 
            this.txtbx_SortedContainers.AllowDrop = true;
            this.txtbx_SortedContainers.Location = new System.Drawing.Point(8, 23);
            this.txtbx_SortedContainers.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_SortedContainers.Multiline = true;
            this.txtbx_SortedContainers.Name = "txtbx_SortedContainers";
            this.txtbx_SortedContainers.ReadOnly = true;
            this.txtbx_SortedContainers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbx_SortedContainers.Size = new System.Drawing.Size(492, 308);
            this.txtbx_SortedContainers.TabIndex = 0;
            // 
            // lbl_BalanceShip
            // 
            this.lbl_BalanceShip.AutoSize = true;
            this.lbl_BalanceShip.Location = new System.Drawing.Point(1008, 36);
            this.lbl_BalanceShip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BalanceShip.Name = "lbl_BalanceShip";
            this.lbl_BalanceShip.Size = new System.Drawing.Size(70, 21);
            this.lbl_BalanceShip.TabIndex = 6;
            this.lbl_BalanceShip.Text = "no data";
            // 
            // lbl_Balance
            // 
            this.lbl_Balance.AutoSize = true;
            this.lbl_Balance.Location = new System.Drawing.Point(1008, 19);
            this.lbl_Balance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Balance.Name = "lbl_Balance";
            this.lbl_Balance.Size = new System.Drawing.Size(79, 21);
            this.lbl_Balance.TabIndex = 5;
            this.lbl_Balance.Text = "Balance:";
            // 
            // ContainerManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 554);
            this.Controls.Add(this.grpbx_SortedContainersOutput);
            this.Controls.Add(this.grpbx_AddContainers);
            this.Controls.Add(this.grpbx_ContainersView);
            this.Controls.Add(this.grpbx_ConfigureShip);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ContainerManagementForm";
            this.Text = "Container Management";
            this.grpbx_ConfigureShip.ResumeLayout(false);
            this.grpbx_ConfigureShip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrc_ShipHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrc_ShipWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrc_ShipLength)).EndInit();
            this.grpbx_ContainersView.ResumeLayout(false);
            this.grpbx_AddContainers.ResumeLayout(false);
            this.grpbx_AddContainers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrc_TotalContainersToAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrc_ContainerWeight)).EndInit();
            this.grpbx_SortedContainersOutput.ResumeLayout(false);
            this.grpbx_SortedContainersOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbx_ConfigureShip;
        private System.Windows.Forms.GroupBox grpbx_ContainersView;
        private System.Windows.Forms.Button bttn_SetShipConfiguration;
        private System.Windows.Forms.Label lbl_ShipHeight;
        private System.Windows.Forms.Label lbl_ShipWidth;
        private System.Windows.Forms.Label lbl_ShipLength;
        private System.Windows.Forms.NumericUpDown nmrc_ShipHeight;
        private System.Windows.Forms.NumericUpDown nmrc_ShipWidth;
        private System.Windows.Forms.NumericUpDown nmrc_ShipLength;
        private System.Windows.Forms.Button bttn_SortContainers;
        private System.Windows.Forms.Button bttn_ClearContainers;
        private System.Windows.Forms.Button bttn_RemoveContainer;
        private System.Windows.Forms.GroupBox grpbx_AddContainers;
        private System.Windows.Forms.Button bttn_AddContainers;
        private System.Windows.Forms.RadioButton rdbttn_Cooled;
        private System.Windows.Forms.RadioButton rdbttn_Valuable;
        private System.Windows.Forms.RadioButton rdbttn_Standard;
        private System.Windows.Forms.NumericUpDown nmrc_TotalContainersToAdd;
        private System.Windows.Forms.Label lbl_TotalContainersToAdd;
        private System.Windows.Forms.NumericUpDown nmrc_ContainerWeight;
        private System.Windows.Forms.Label lbl_ContainerWeight;
        private System.Windows.Forms.GroupBox grpbx_SortedContainersOutput;
        private System.Windows.Forms.TextBox txtbx_SortedContainers;
        private System.Windows.Forms.ListBox lstbx_containers;
        private System.Windows.Forms.TextBox txtbx_Log;
        private System.Windows.Forms.Label lbl_BalanceShip;
        private System.Windows.Forms.Label lbl_Balance;
    }
}

