
namespace CIS560Project
{
    partial class uxOutputLabel
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
            this.uxTotalEarningsPerRuntimeGroupsButton = new System.Windows.Forms.Button();
            this.uxMostPopularDirectorsButton = new System.Windows.Forms.Button();
            this.uxMovieEarningsButton = new System.Windows.Forms.Button();
            this.uxMovieIdLabel = new System.Windows.Forms.Label();
            this.uxMovieIdTextbox = new System.Windows.Forms.TextBox();
            this.uxTheatersTab = new System.Windows.Forms.TabPage();
            this.uxDateLabel = new System.Windows.Forms.Label();
            this.uxDatePicker = new System.Windows.Forms.DateTimePicker();
            this.uxAddMovieTab = new System.Windows.Forms.TabPage();
            this.uxRuntimeMinutesTextbox = new System.Windows.Forms.TextBox();
            this.uxRatingTextbox = new System.Windows.Forms.TextBox();
            this.uxMovieTitleTextbox = new System.Windows.Forms.TextBox();
            this.uxReleaseDateLabel = new System.Windows.Forms.Label();
            this.uxRuntimeMinutesLabel = new System.Windows.Forms.Label();
            this.uxRatingLabel = new System.Windows.Forms.Label();
            this.uxMovieTitleLabel = new System.Windows.Forms.Label();
            this.uxSearchLabel = new System.Windows.Forms.Label();
            this.uxReleaseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.uxAddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uxSearchTabControl.SuspendLayout();
            this.uxMoviesTab.SuspendLayout();
            this.uxTheatersTab.SuspendLayout();
            this.uxAddMovieTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxSearchTextbox
            // 
            this.uxSearchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchTextbox.Location = new System.Drawing.Point(45, 72);
            this.uxSearchTextbox.Name = "uxSearchTextbox";
            this.uxSearchTextbox.Size = new System.Drawing.Size(550, 28);
            this.uxSearchTextbox.TabIndex = 0;
            // 
            // uxSearchButton
            // 
            this.uxSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchButton.Location = new System.Drawing.Point(877, 50);
            this.uxSearchButton.Name = "uxSearchButton";
            this.uxSearchButton.Size = new System.Drawing.Size(200, 72);
            this.uxSearchButton.TabIndex = 1;
            this.uxSearchButton.Text = "Search";
            this.uxSearchButton.UseVisualStyleBackColor = true;
            this.uxSearchButton.Click += new System.EventHandler(this.uxSearchButton_Click);
            // 
            // uxTopTenListView
            // 
            this.uxTopTenListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTopTenListView.HideSelection = false;
            this.uxTopTenListView.Location = new System.Drawing.Point(485, 193);
            this.uxTopTenListView.Name = "uxTopTenListView";
            this.uxTopTenListView.Size = new System.Drawing.Size(592, 501);
            this.uxTopTenListView.TabIndex = 2;
            this.uxTopTenListView.UseCompatibleStateImageBehavior = false;
            this.uxTopTenListView.View = System.Windows.Forms.View.List;
            // 
            // uxSearchTabControl
            // 
            this.uxSearchTabControl.Controls.Add(this.uxMoviesTab);
            this.uxSearchTabControl.Controls.Add(this.uxTheatersTab);
            this.uxSearchTabControl.Controls.Add(this.uxAddMovieTab);
            this.uxSearchTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchTabControl.Location = new System.Drawing.Point(45, 133);
            this.uxSearchTabControl.Name = "uxSearchTabControl";
            this.uxSearchTabControl.SelectedIndex = 0;
            this.uxSearchTabControl.Size = new System.Drawing.Size(434, 561);
            this.uxSearchTabControl.TabIndex = 4;
            // 
            // uxMoviesTab
            // 
            this.uxMoviesTab.Controls.Add(this.uxTotalEarningsPerRuntimeGroupsButton);
            this.uxMoviesTab.Controls.Add(this.uxMostPopularDirectorsButton);
            this.uxMoviesTab.Controls.Add(this.uxMovieEarningsButton);
            this.uxMoviesTab.Controls.Add(this.uxMovieIdLabel);
            this.uxMoviesTab.Controls.Add(this.uxMovieIdTextbox);
            this.uxMoviesTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMoviesTab.Location = new System.Drawing.Point(4, 29);
            this.uxMoviesTab.Name = "uxMoviesTab";
            this.uxMoviesTab.Padding = new System.Windows.Forms.Padding(3);
            this.uxMoviesTab.Size = new System.Drawing.Size(426, 528);
            this.uxMoviesTab.TabIndex = 0;
            this.uxMoviesTab.Text = "Movies";
            this.uxMoviesTab.UseVisualStyleBackColor = true;
            // 
            // uxTotalEarningsPerRuntimeGroupsButton
            // 
            this.uxTotalEarningsPerRuntimeGroupsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTotalEarningsPerRuntimeGroupsButton.Location = new System.Drawing.Point(35, 290);
            this.uxTotalEarningsPerRuntimeGroupsButton.Name = "uxTotalEarningsPerRuntimeGroupsButton";
            this.uxTotalEarningsPerRuntimeGroupsButton.Size = new System.Drawing.Size(336, 53);
            this.uxTotalEarningsPerRuntimeGroupsButton.TabIndex = 3;
            this.uxTotalEarningsPerRuntimeGroupsButton.Text = "Total Earnings Per Runtime Groups";
            this.uxTotalEarningsPerRuntimeGroupsButton.UseVisualStyleBackColor = true;
            this.uxTotalEarningsPerRuntimeGroupsButton.Click += new System.EventHandler(this.uxTotalEarningsPerRuntimeGroups_Click);
            // 
            // uxMostPopularDirectorsButton
            // 
            this.uxMostPopularDirectorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMostPopularDirectorsButton.Location = new System.Drawing.Point(35, 202);
            this.uxMostPopularDirectorsButton.Name = "uxMostPopularDirectorsButton";
            this.uxMostPopularDirectorsButton.Size = new System.Drawing.Size(223, 53);
            this.uxMostPopularDirectorsButton.TabIndex = 3;
            this.uxMostPopularDirectorsButton.Text = "Most Popular Directors";
            this.uxMostPopularDirectorsButton.UseVisualStyleBackColor = true;
            this.uxMostPopularDirectorsButton.Click += new System.EventHandler(this.uxMostPopularDirectorsButton_Click);
            // 
            // uxMovieEarningsButton
            // 
            this.uxMovieEarningsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMovieEarningsButton.Location = new System.Drawing.Point(35, 115);
            this.uxMovieEarningsButton.Name = "uxMovieEarningsButton";
            this.uxMovieEarningsButton.Size = new System.Drawing.Size(223, 53);
            this.uxMovieEarningsButton.TabIndex = 3;
            this.uxMovieEarningsButton.Text = "Movie Earnings";
            this.uxMovieEarningsButton.UseVisualStyleBackColor = true;
            this.uxMovieEarningsButton.Click += new System.EventHandler(this.uxMovieEarningsButton_Click);
            // 
            // uxMovieIdLabel
            // 
            this.uxMovieIdLabel.AutoSize = true;
            this.uxMovieIdLabel.Location = new System.Drawing.Point(31, 31);
            this.uxMovieIdLabel.Name = "uxMovieIdLabel";
            this.uxMovieIdLabel.Size = new System.Drawing.Size(75, 20);
            this.uxMovieIdLabel.TabIndex = 1;
            this.uxMovieIdLabel.Text = "Movie ID:";
            // 
            // uxMovieIdTextbox
            // 
            this.uxMovieIdTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMovieIdTextbox.Location = new System.Drawing.Point(35, 54);
            this.uxMovieIdTextbox.Name = "uxMovieIdTextbox";
            this.uxMovieIdTextbox.Size = new System.Drawing.Size(191, 29);
            this.uxMovieIdTextbox.TabIndex = 0;
            // 
            // uxTheatersTab
            // 
            this.uxTheatersTab.Controls.Add(this.uxDateLabel);
            this.uxTheatersTab.Controls.Add(this.uxDatePicker);
            this.uxTheatersTab.Location = new System.Drawing.Point(4, 29);
            this.uxTheatersTab.Name = "uxTheatersTab";
            this.uxTheatersTab.Padding = new System.Windows.Forms.Padding(3);
            this.uxTheatersTab.Size = new System.Drawing.Size(426, 528);
            this.uxTheatersTab.TabIndex = 1;
            this.uxTheatersTab.Text = "Theaters";
            this.uxTheatersTab.UseVisualStyleBackColor = true;
            // 
            // uxDateLabel
            // 
            this.uxDateLabel.AutoSize = true;
            this.uxDateLabel.Location = new System.Drawing.Point(31, 31);
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
            this.uxDatePicker.ValueChanged += new System.EventHandler(this.uxDatePicker_ValueChanged);
            // 
            // uxAddMovieTab
            // 
            this.uxAddMovieTab.Controls.Add(this.uxAddButton);
            this.uxAddMovieTab.Controls.Add(this.uxReleaseDatePicker);
            this.uxAddMovieTab.Controls.Add(this.uxRuntimeMinutesTextbox);
            this.uxAddMovieTab.Controls.Add(this.uxRatingTextbox);
            this.uxAddMovieTab.Controls.Add(this.uxMovieTitleTextbox);
            this.uxAddMovieTab.Controls.Add(this.uxReleaseDateLabel);
            this.uxAddMovieTab.Controls.Add(this.uxRuntimeMinutesLabel);
            this.uxAddMovieTab.Controls.Add(this.uxRatingLabel);
            this.uxAddMovieTab.Controls.Add(this.uxMovieTitleLabel);
            this.uxAddMovieTab.Location = new System.Drawing.Point(4, 29);
            this.uxAddMovieTab.Name = "uxAddMovieTab";
            this.uxAddMovieTab.Size = new System.Drawing.Size(426, 528);
            this.uxAddMovieTab.TabIndex = 2;
            this.uxAddMovieTab.Text = "Add Movie";
            this.uxAddMovieTab.UseVisualStyleBackColor = true;
            // 
            // uxRuntimeMinutesTextbox
            // 
            this.uxRuntimeMinutesTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRuntimeMinutesTextbox.Location = new System.Drawing.Point(23, 227);
            this.uxRuntimeMinutesTextbox.Name = "uxRuntimeMinutesTextbox";
            this.uxRuntimeMinutesTextbox.Size = new System.Drawing.Size(229, 29);
            this.uxRuntimeMinutesTextbox.TabIndex = 1;
            // 
            // uxRatingTextbox
            // 
            this.uxRatingTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRatingTextbox.Location = new System.Drawing.Point(23, 141);
            this.uxRatingTextbox.Name = "uxRatingTextbox";
            this.uxRatingTextbox.Size = new System.Drawing.Size(229, 29);
            this.uxRatingTextbox.TabIndex = 1;
            // 
            // uxMovieTitleTextbox
            // 
            this.uxMovieTitleTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMovieTitleTextbox.Location = new System.Drawing.Point(23, 57);
            this.uxMovieTitleTextbox.Name = "uxMovieTitleTextbox";
            this.uxMovieTitleTextbox.Size = new System.Drawing.Size(229, 29);
            this.uxMovieTitleTextbox.TabIndex = 1;
            // 
            // uxReleaseDateLabel
            // 
            this.uxReleaseDateLabel.AutoSize = true;
            this.uxReleaseDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxReleaseDateLabel.Location = new System.Drawing.Point(19, 287);
            this.uxReleaseDateLabel.Name = "uxReleaseDateLabel";
            this.uxReleaseDateLabel.Size = new System.Drawing.Size(127, 24);
            this.uxReleaseDateLabel.TabIndex = 0;
            this.uxReleaseDateLabel.Text = "Release Date:";
            // 
            // uxRuntimeMinutesLabel
            // 
            this.uxRuntimeMinutesLabel.AutoSize = true;
            this.uxRuntimeMinutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRuntimeMinutesLabel.Location = new System.Drawing.Point(19, 200);
            this.uxRuntimeMinutesLabel.Name = "uxRuntimeMinutesLabel";
            this.uxRuntimeMinutesLabel.Size = new System.Drawing.Size(188, 24);
            this.uxRuntimeMinutesLabel.TabIndex = 0;
            this.uxRuntimeMinutesLabel.Text = "Runtime (in Minutes):";
            // 
            // uxRatingLabel
            // 
            this.uxRatingLabel.AutoSize = true;
            this.uxRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRatingLabel.Location = new System.Drawing.Point(19, 114);
            this.uxRatingLabel.Name = "uxRatingLabel";
            this.uxRatingLabel.Size = new System.Drawing.Size(68, 24);
            this.uxRatingLabel.TabIndex = 0;
            this.uxRatingLabel.Text = "Rating:";
            // 
            // uxMovieTitleLabel
            // 
            this.uxMovieTitleLabel.AutoSize = true;
            this.uxMovieTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMovieTitleLabel.Location = new System.Drawing.Point(19, 30);
            this.uxMovieTitleLabel.Name = "uxMovieTitleLabel";
            this.uxMovieTitleLabel.Size = new System.Drawing.Size(106, 24);
            this.uxMovieTitleLabel.TabIndex = 0;
            this.uxMovieTitleLabel.Text = "Movie Title:";
            // 
            // uxSearchLabel
            // 
            this.uxSearchLabel.AutoSize = true;
            this.uxSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchLabel.Location = new System.Drawing.Point(45, 45);
            this.uxSearchLabel.Name = "uxSearchLabel";
            this.uxSearchLabel.Size = new System.Drawing.Size(75, 24);
            this.uxSearchLabel.TabIndex = 5;
            this.uxSearchLabel.Text = "Search:";
            // 
            // uxReleaseDatePicker
            // 
            this.uxReleaseDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxReleaseDatePicker.Location = new System.Drawing.Point(23, 314);
            this.uxReleaseDatePicker.Name = "uxReleaseDatePicker";
            this.uxReleaseDatePicker.Size = new System.Drawing.Size(280, 26);
            this.uxReleaseDatePicker.TabIndex = 2;
            // 
            // uxAddButton
            // 
            this.uxAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddButton.Location = new System.Drawing.Point(23, 385);
            this.uxAddButton.Name = "uxAddButton";
            this.uxAddButton.Size = new System.Drawing.Size(148, 56);
            this.uxAddButton.TabIndex = 3;
            this.uxAddButton.Text = "Add";
            this.uxAddButton.UseVisualStyleBackColor = true;
            this.uxAddButton.Click += new System.EventHandler(this.uxAddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Output:";
            // 
            // uxOutputLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 746);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxSearchLabel);
            this.Controls.Add(this.uxSearchTabControl);
            this.Controls.Add(this.uxTopTenListView);
            this.Controls.Add(this.uxSearchButton);
            this.Controls.Add(this.uxSearchTextbox);
            this.Name = "uxOutputLabel";
            this.Text = "Form1";
            this.uxSearchTabControl.ResumeLayout(false);
            this.uxMoviesTab.ResumeLayout(false);
            this.uxMoviesTab.PerformLayout();
            this.uxTheatersTab.ResumeLayout(false);
            this.uxTheatersTab.PerformLayout();
            this.uxAddMovieTab.ResumeLayout(false);
            this.uxAddMovieTab.PerformLayout();
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
        private System.Windows.Forms.Label uxMovieIdLabel;
        private System.Windows.Forms.TextBox uxMovieIdTextbox;
        private System.Windows.Forms.Label uxSearchLabel;
        private System.Windows.Forms.Button uxMovieEarningsButton;
        private System.Windows.Forms.Button uxMostPopularDirectorsButton;
        private System.Windows.Forms.Button uxTotalEarningsPerRuntimeGroupsButton;
        private System.Windows.Forms.TabPage uxAddMovieTab;
        private System.Windows.Forms.TextBox uxRuntimeMinutesTextbox;
        private System.Windows.Forms.TextBox uxRatingTextbox;
        private System.Windows.Forms.TextBox uxMovieTitleTextbox;
        private System.Windows.Forms.Label uxReleaseDateLabel;
        private System.Windows.Forms.Label uxRuntimeMinutesLabel;
        private System.Windows.Forms.Label uxRatingLabel;
        private System.Windows.Forms.Label uxMovieTitleLabel;
        private System.Windows.Forms.Button uxAddButton;
        private System.Windows.Forms.DateTimePicker uxReleaseDatePicker;
        private System.Windows.Forms.Label label1;
    }
}

