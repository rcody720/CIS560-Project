
namespace CIS560Project
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
            this.uxSearchTextbox = new System.Windows.Forms.TextBox();
            this.uxSearchButton = new System.Windows.Forms.Button();
            this.uxTopTenListView = new System.Windows.Forms.ListView();
            this.uxSearchTabControl = new System.Windows.Forms.TabControl();
            this.uxMoviesTab = new System.Windows.Forms.TabPage();
            this.uxTheatersTab = new System.Windows.Forms.TabPage();
            this.uxDateLabel = new System.Windows.Forms.Label();
            this.uxDatePicker = new System.Windows.Forms.DateTimePicker();
            this.uxSearchTabControl.SuspendLayout();
            this.uxTheatersTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxSearchTextbox
            // 
            this.uxSearchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchTextbox.Location = new System.Drawing.Point(45, 50);
            this.uxSearchTextbox.Name = "uxSearchTextbox";
            this.uxSearchTextbox.Size = new System.Drawing.Size(677, 28);
            this.uxSearchTextbox.TabIndex = 0;
            // 
            // uxSearchButton
            // 
            this.uxSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchButton.Location = new System.Drawing.Point(794, 50);
            this.uxSearchButton.Name = "uxSearchButton";
            this.uxSearchButton.Size = new System.Drawing.Size(200, 72);
            this.uxSearchButton.TabIndex = 1;
            this.uxSearchButton.Text = "Search";
            this.uxSearchButton.UseVisualStyleBackColor = true;
            // 
            // uxTopTenListView
            // 
            this.uxTopTenListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTopTenListView.HideSelection = false;
            this.uxTopTenListView.Location = new System.Drawing.Point(701, 162);
            this.uxTopTenListView.Name = "uxTopTenListView";
            this.uxTopTenListView.Size = new System.Drawing.Size(292, 533);
            this.uxTopTenListView.TabIndex = 2;
            this.uxTopTenListView.UseCompatibleStateImageBehavior = false;
            // 
            // uxSearchTabControl
            // 
            this.uxSearchTabControl.Controls.Add(this.uxMoviesTab);
            this.uxSearchTabControl.Controls.Add(this.uxTheatersTab);
            this.uxSearchTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchTabControl.Location = new System.Drawing.Point(45, 133);
            this.uxSearchTabControl.Name = "uxSearchTabControl";
            this.uxSearchTabControl.SelectedIndex = 0;
            this.uxSearchTabControl.Size = new System.Drawing.Size(615, 561);
            this.uxSearchTabControl.TabIndex = 4;
            // 
            // uxMoviesTab
            // 
            this.uxMoviesTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMoviesTab.Location = new System.Drawing.Point(4, 29);
            this.uxMoviesTab.Name = "uxMoviesTab";
            this.uxMoviesTab.Padding = new System.Windows.Forms.Padding(3);
            this.uxMoviesTab.Size = new System.Drawing.Size(607, 528);
            this.uxMoviesTab.TabIndex = 0;
            this.uxMoviesTab.Text = "Movies";
            this.uxMoviesTab.UseVisualStyleBackColor = true;
            // 
            // uxTheatersTab
            // 
            this.uxTheatersTab.Controls.Add(this.uxDateLabel);
            this.uxTheatersTab.Controls.Add(this.uxDatePicker);
            this.uxTheatersTab.Location = new System.Drawing.Point(4, 29);
            this.uxTheatersTab.Name = "uxTheatersTab";
            this.uxTheatersTab.Padding = new System.Windows.Forms.Padding(3);
            this.uxTheatersTab.Size = new System.Drawing.Size(607, 528);
            this.uxTheatersTab.TabIndex = 1;
            this.uxTheatersTab.Text = "Theaters";
            this.uxTheatersTab.UseVisualStyleBackColor = true;
            // 
            // uxDateLabel
            // 
            this.uxDateLabel.AutoSize = true;
            this.uxDateLabel.Location = new System.Drawing.Point(31, 22);
            this.uxDateLabel.Name = "uxDateLabel";
            this.uxDateLabel.Size = new System.Drawing.Size(48, 20);
            this.uxDateLabel.TabIndex = 1;
            this.uxDateLabel.Text = "Date:";
            this.uxDateLabel.UseMnemonic = false;
            // 
            // uxDatePicker
            // 
            this.uxDatePicker.Location = new System.Drawing.Point(35, 64);
            this.uxDatePicker.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.uxDatePicker.MinDate = new System.DateTime(2021, 4, 14, 0, 0, 0, 0);
            this.uxDatePicker.Name = "uxDatePicker";
            this.uxDatePicker.Size = new System.Drawing.Size(339, 26);
            this.uxDatePicker.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 746);
            this.Controls.Add(this.uxSearchTabControl);
            this.Controls.Add(this.uxTopTenListView);
            this.Controls.Add(this.uxSearchButton);
            this.Controls.Add(this.uxSearchTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.uxSearchTabControl.ResumeLayout(false);
            this.uxTheatersTab.ResumeLayout(false);
            this.uxTheatersTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxSearchTextbox;
        private System.Windows.Forms.Button uxSearchButton;
        private System.Windows.Forms.ListView uxTopTenListView;
        private System.Windows.Forms.TabControl uxSearchTabControl;
        private System.Windows.Forms.TabPage uxMoviesTab;
        private System.Windows.Forms.TabPage uxTheatersTab;
        private System.Windows.Forms.Label uxDateLabel;
        private System.Windows.Forms.DateTimePicker uxDatePicker;
    }
}

