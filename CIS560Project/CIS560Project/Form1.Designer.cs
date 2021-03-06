
namespace CIS560Project
{
    partial class uxForm
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
            this.uxGenreComboBox = new System.Windows.Forms.ComboBox();
            this.uxDirectorLabel = new System.Windows.Forms.Label();
            this.uxActorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxMovieIdLabel = new System.Windows.Forms.Label();
            this.uxDirectorTextbox = new System.Windows.Forms.TextBox();
            this.uxActorTextbox = new System.Windows.Forms.TextBox();
            this.uxMovieIdTextbox = new System.Windows.Forms.TextBox();
            this.uxTheatersTab = new System.Windows.Forms.TabPage();
            this.uxDateLabel = new System.Windows.Forms.Label();
            this.uxDatePicker = new System.Windows.Forms.DateTimePicker();
            this.uxAddMovieTab = new System.Windows.Forms.TabPage();
            this.uxAddButton = new System.Windows.Forms.Button();
            this.uxReleaseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.uxAddDiretorTextbox = new System.Windows.Forms.TextBox();
            this.uxRuntimeMinutesTextbox = new System.Windows.Forms.TextBox();
            this.uxRatingTextbox = new System.Windows.Forms.TextBox();
            this.uxMovieTitleTextbox = new System.Windows.Forms.TextBox();
            this.uxAddDirectorLabel = new System.Windows.Forms.Label();
            this.uxReleaseDateLabel = new System.Windows.Forms.Label();
            this.uxRuntimeMinutesLabel = new System.Windows.Forms.Label();
            this.uxRatingLabel = new System.Windows.Forms.Label();
            this.uxMovieTitleLabel = new System.Windows.Forms.Label();
            this.uxMovieStatsTab = new System.Windows.Forms.TabPage();
            this.uxTotalEarningsPerRuntimeGroupsButton = new System.Windows.Forms.Button();
            this.uxMostPopularDirectorsButton = new System.Windows.Forms.Button();
            this.uxMovieEarningsButton = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uxAddReviewButton = new System.Windows.Forms.Button();
            this.uxScoreUpDown = new System.Windows.Forms.NumericUpDown();
            this.uxUsernameTextbox = new System.Windows.Forms.TextBox();
            this.uxReviewMovieTitleTextbox = new System.Windows.Forms.TextBox();
            this.uxScoreLabel = new System.Windows.Forms.Label();
            this.uxUsernameLabel = new System.Windows.Forms.Label();
            this.uxReviewMovieTitleLabel = new System.Windows.Forms.Label();
            this.uxGenreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uxSalaryLabel = new System.Windows.Forms.Label();
            this.uxAddSalaryUpDown = new System.Windows.Forms.NumericUpDown();
            this.uxSearchTabControl.SuspendLayout();
            this.uxMoviesTab.SuspendLayout();
            this.uxTheatersTab.SuspendLayout();
            this.uxAddMovieTab.SuspendLayout();
            this.uxMovieStatsTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxScoreUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxAddSalaryUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // uxSearchTextbox
            // 
            this.uxSearchTextbox.BackColor = System.Drawing.Color.White;
            this.uxSearchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchTextbox.Location = new System.Drawing.Point(27, 72);
            this.uxSearchTextbox.Name = "uxSearchTextbox";
            this.uxSearchTextbox.Size = new System.Drawing.Size(550, 28);
            this.uxSearchTextbox.TabIndex = 0;
            // 
            // uxSearchButton
            // 
            this.uxSearchButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.uxSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchButton.ForeColor = System.Drawing.SystemColors.Control;
            this.uxSearchButton.Location = new System.Drawing.Point(723, 50);
            this.uxSearchButton.Name = "uxSearchButton";
            this.uxSearchButton.Size = new System.Drawing.Size(249, 72);
            this.uxSearchButton.TabIndex = 1;
            this.uxSearchButton.Text = "Search";
            this.uxSearchButton.UseVisualStyleBackColor = false;
            this.uxSearchButton.Click += new System.EventHandler(this.uxSearchButton_Click);
            // 
            // uxTopTenListView
            // 
            this.uxTopTenListView.BackColor = System.Drawing.Color.White;
            this.uxTopTenListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTopTenListView.HideSelection = false;
            this.uxTopTenListView.Location = new System.Drawing.Point(559, 195);
            this.uxTopTenListView.Name = "uxTopTenListView";
            this.uxTopTenListView.Size = new System.Drawing.Size(835, 528);
            this.uxTopTenListView.TabIndex = 2;
            this.uxTopTenListView.UseCompatibleStateImageBehavior = false;
            this.uxTopTenListView.View = System.Windows.Forms.View.List;
            // 
            // uxSearchTabControl
            // 
            this.uxSearchTabControl.Controls.Add(this.uxMoviesTab);
            this.uxSearchTabControl.Controls.Add(this.uxTheatersTab);
            this.uxSearchTabControl.Controls.Add(this.uxAddMovieTab);
            this.uxSearchTabControl.Controls.Add(this.uxMovieStatsTab);
            this.uxSearchTabControl.Controls.Add(this.tabPage1);
            this.uxSearchTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearchTabControl.Location = new System.Drawing.Point(23, 166);
            this.uxSearchTabControl.Name = "uxSearchTabControl";
            this.uxSearchTabControl.SelectedIndex = 0;
            this.uxSearchTabControl.Size = new System.Drawing.Size(526, 557);
            this.uxSearchTabControl.TabIndex = 4;
            // 
            // uxMoviesTab
            // 
            this.uxMoviesTab.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.uxMoviesTab.Controls.Add(this.uxGenreComboBox);
            this.uxMoviesTab.Controls.Add(this.uxDirectorLabel);
            this.uxMoviesTab.Controls.Add(this.uxActorLabel);
            this.uxMoviesTab.Controls.Add(this.label2);
            this.uxMoviesTab.Controls.Add(this.uxMovieIdLabel);
            this.uxMoviesTab.Controls.Add(this.uxDirectorTextbox);
            this.uxMoviesTab.Controls.Add(this.uxActorTextbox);
            this.uxMoviesTab.Controls.Add(this.uxMovieIdTextbox);
            this.uxMoviesTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMoviesTab.Location = new System.Drawing.Point(4, 29);
            this.uxMoviesTab.Name = "uxMoviesTab";
            this.uxMoviesTab.Padding = new System.Windows.Forms.Padding(3);
            this.uxMoviesTab.Size = new System.Drawing.Size(518, 524);
            this.uxMoviesTab.TabIndex = 0;
            this.uxMoviesTab.Text = "Advanced Movie Search";
            // 
            // uxGenreComboBox
            // 
            this.uxGenreComboBox.FormattingEnabled = true;
            this.uxGenreComboBox.Items.AddRange(new object[] {
            "Action",
            "Animation",
            "Comedy",
            "Crime",
            "Drama",
            "Experimental",
            "Fantasy",
            "Historical",
            "Horror",
            "Romance",
            "ScienceFiction",
            "Thriller",
            "Western",
            "Other"});
            this.uxGenreComboBox.Location = new System.Drawing.Point(35, 157);
            this.uxGenreComboBox.Name = "uxGenreComboBox";
            this.uxGenreComboBox.Size = new System.Drawing.Size(190, 28);
            this.uxGenreComboBox.TabIndex = 2;
            // 
            // uxDirectorLabel
            // 
            this.uxDirectorLabel.AutoSize = true;
            this.uxDirectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDirectorLabel.ForeColor = System.Drawing.Color.White;
            this.uxDirectorLabel.Location = new System.Drawing.Point(31, 313);
            this.uxDirectorLabel.Name = "uxDirectorLabel";
            this.uxDirectorLabel.Size = new System.Drawing.Size(75, 24);
            this.uxDirectorLabel.TabIndex = 1;
            this.uxDirectorLabel.Text = "Director";
            // 
            // uxActorLabel
            // 
            this.uxActorLabel.AutoSize = true;
            this.uxActorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxActorLabel.ForeColor = System.Drawing.Color.White;
            this.uxActorLabel.Location = new System.Drawing.Point(31, 218);
            this.uxActorLabel.Name = "uxActorLabel";
            this.uxActorLabel.Size = new System.Drawing.Size(59, 24);
            this.uxActorLabel.TabIndex = 1;
            this.uxActorLabel.Text = "Actor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Genre:";
            // 
            // uxMovieIdLabel
            // 
            this.uxMovieIdLabel.AutoSize = true;
            this.uxMovieIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMovieIdLabel.ForeColor = System.Drawing.Color.White;
            this.uxMovieIdLabel.Location = new System.Drawing.Point(31, 27);
            this.uxMovieIdLabel.Name = "uxMovieIdLabel";
            this.uxMovieIdLabel.Size = new System.Drawing.Size(88, 24);
            this.uxMovieIdLabel.TabIndex = 1;
            this.uxMovieIdLabel.Text = "Movie ID:";
            // 
            // uxDirectorTextbox
            // 
            this.uxDirectorTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDirectorTextbox.Location = new System.Drawing.Point(34, 340);
            this.uxDirectorTextbox.Name = "uxDirectorTextbox";
            this.uxDirectorTextbox.Size = new System.Drawing.Size(191, 29);
            this.uxDirectorTextbox.TabIndex = 0;
            // 
            // uxActorTextbox
            // 
            this.uxActorTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxActorTextbox.Location = new System.Drawing.Point(35, 245);
            this.uxActorTextbox.Name = "uxActorTextbox";
            this.uxActorTextbox.Size = new System.Drawing.Size(191, 29);
            this.uxActorTextbox.TabIndex = 0;
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
            this.uxTheatersTab.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.uxTheatersTab.Controls.Add(this.uxDateLabel);
            this.uxTheatersTab.Controls.Add(this.uxDatePicker);
            this.uxTheatersTab.Location = new System.Drawing.Point(4, 29);
            this.uxTheatersTab.Name = "uxTheatersTab";
            this.uxTheatersTab.Padding = new System.Windows.Forms.Padding(3);
            this.uxTheatersTab.Size = new System.Drawing.Size(518, 524);
            this.uxTheatersTab.TabIndex = 1;
            this.uxTheatersTab.Text = "Theaters";
            // 
            // uxDateLabel
            // 
            this.uxDateLabel.AutoSize = true;
            this.uxDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDateLabel.ForeColor = System.Drawing.Color.White;
            this.uxDateLabel.Location = new System.Drawing.Point(31, 31);
            this.uxDateLabel.Name = "uxDateLabel";
            this.uxDateLabel.Size = new System.Drawing.Size(141, 24);
            this.uxDateLabel.TabIndex = 1;
            this.uxDateLabel.Text = "Showtimes For:";
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
            this.uxAddMovieTab.BackColor = System.Drawing.Color.DimGray;
            this.uxAddMovieTab.Controls.Add(this.uxAddSalaryUpDown);
            this.uxAddMovieTab.Controls.Add(this.uxAddButton);
            this.uxAddMovieTab.Controls.Add(this.uxReleaseDatePicker);
            this.uxAddMovieTab.Controls.Add(this.uxAddDiretorTextbox);
            this.uxAddMovieTab.Controls.Add(this.uxRuntimeMinutesTextbox);
            this.uxAddMovieTab.Controls.Add(this.uxRatingTextbox);
            this.uxAddMovieTab.Controls.Add(this.uxMovieTitleTextbox);
            this.uxAddMovieTab.Controls.Add(this.uxSalaryLabel);
            this.uxAddMovieTab.Controls.Add(this.uxAddDirectorLabel);
            this.uxAddMovieTab.Controls.Add(this.uxReleaseDateLabel);
            this.uxAddMovieTab.Controls.Add(this.uxRuntimeMinutesLabel);
            this.uxAddMovieTab.Controls.Add(this.uxRatingLabel);
            this.uxAddMovieTab.Controls.Add(this.uxMovieTitleLabel);
            this.uxAddMovieTab.Location = new System.Drawing.Point(4, 29);
            this.uxAddMovieTab.Name = "uxAddMovieTab";
            this.uxAddMovieTab.Size = new System.Drawing.Size(518, 524);
            this.uxAddMovieTab.TabIndex = 2;
            this.uxAddMovieTab.Text = "Add Movie";
            // 
            // uxAddButton
            // 
            this.uxAddButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.uxAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddButton.ForeColor = System.Drawing.SystemColors.Control;
            this.uxAddButton.Location = new System.Drawing.Point(23, 442);
            this.uxAddButton.Name = "uxAddButton";
            this.uxAddButton.Size = new System.Drawing.Size(148, 56);
            this.uxAddButton.TabIndex = 3;
            this.uxAddButton.Text = "Add";
            this.uxAddButton.UseVisualStyleBackColor = false;
            this.uxAddButton.Click += new System.EventHandler(this.uxAddButton_Click);
            // 
            // uxReleaseDatePicker
            // 
            this.uxReleaseDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxReleaseDatePicker.Location = new System.Drawing.Point(23, 384);
            this.uxReleaseDatePicker.Name = "uxReleaseDatePicker";
            this.uxReleaseDatePicker.Size = new System.Drawing.Size(280, 26);
            this.uxReleaseDatePicker.TabIndex = 2;
            // 
            // uxAddDiretorTextbox
            // 
            this.uxAddDiretorTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddDiretorTextbox.Location = new System.Drawing.Point(23, 298);
            this.uxAddDiretorTextbox.Name = "uxAddDiretorTextbox";
            this.uxAddDiretorTextbox.Size = new System.Drawing.Size(229, 29);
            this.uxAddDiretorTextbox.TabIndex = 1;
            // 
            // uxRuntimeMinutesTextbox
            // 
            this.uxRuntimeMinutesTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRuntimeMinutesTextbox.Location = new System.Drawing.Point(23, 214);
            this.uxRuntimeMinutesTextbox.Name = "uxRuntimeMinutesTextbox";
            this.uxRuntimeMinutesTextbox.Size = new System.Drawing.Size(229, 29);
            this.uxRuntimeMinutesTextbox.TabIndex = 1;
            // 
            // uxRatingTextbox
            // 
            this.uxRatingTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRatingTextbox.Location = new System.Drawing.Point(23, 127);
            this.uxRatingTextbox.Name = "uxRatingTextbox";
            this.uxRatingTextbox.Size = new System.Drawing.Size(229, 29);
            this.uxRatingTextbox.TabIndex = 1;
            // 
            // uxMovieTitleTextbox
            // 
            this.uxMovieTitleTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMovieTitleTextbox.Location = new System.Drawing.Point(23, 47);
            this.uxMovieTitleTextbox.Name = "uxMovieTitleTextbox";
            this.uxMovieTitleTextbox.Size = new System.Drawing.Size(229, 29);
            this.uxMovieTitleTextbox.TabIndex = 1;
            // 
            // uxAddDirectorLabel
            // 
            this.uxAddDirectorLabel.AutoSize = true;
            this.uxAddDirectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddDirectorLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.uxAddDirectorLabel.Location = new System.Drawing.Point(19, 271);
            this.uxAddDirectorLabel.Name = "uxAddDirectorLabel";
            this.uxAddDirectorLabel.Size = new System.Drawing.Size(80, 24);
            this.uxAddDirectorLabel.TabIndex = 0;
            this.uxAddDirectorLabel.Text = "Director:";
            // 
            // uxReleaseDateLabel
            // 
            this.uxReleaseDateLabel.AutoSize = true;
            this.uxReleaseDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxReleaseDateLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.uxReleaseDateLabel.Location = new System.Drawing.Point(19, 357);
            this.uxReleaseDateLabel.Name = "uxReleaseDateLabel";
            this.uxReleaseDateLabel.Size = new System.Drawing.Size(127, 24);
            this.uxReleaseDateLabel.TabIndex = 0;
            this.uxReleaseDateLabel.Text = "Release Date:";
            // 
            // uxRuntimeMinutesLabel
            // 
            this.uxRuntimeMinutesLabel.AutoSize = true;
            this.uxRuntimeMinutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRuntimeMinutesLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.uxRuntimeMinutesLabel.Location = new System.Drawing.Point(19, 187);
            this.uxRuntimeMinutesLabel.Name = "uxRuntimeMinutesLabel";
            this.uxRuntimeMinutesLabel.Size = new System.Drawing.Size(188, 24);
            this.uxRuntimeMinutesLabel.TabIndex = 0;
            this.uxRuntimeMinutesLabel.Text = "Runtime (in Minutes):";
            // 
            // uxRatingLabel
            // 
            this.uxRatingLabel.AutoSize = true;
            this.uxRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRatingLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.uxRatingLabel.Location = new System.Drawing.Point(19, 100);
            this.uxRatingLabel.Name = "uxRatingLabel";
            this.uxRatingLabel.Size = new System.Drawing.Size(68, 24);
            this.uxRatingLabel.TabIndex = 0;
            this.uxRatingLabel.Text = "Rating:";
            // 
            // uxMovieTitleLabel
            // 
            this.uxMovieTitleLabel.AutoSize = true;
            this.uxMovieTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMovieTitleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.uxMovieTitleLabel.Location = new System.Drawing.Point(19, 20);
            this.uxMovieTitleLabel.Name = "uxMovieTitleLabel";
            this.uxMovieTitleLabel.Size = new System.Drawing.Size(106, 24);
            this.uxMovieTitleLabel.TabIndex = 0;
            this.uxMovieTitleLabel.Text = "Movie Title:";
            // 
            // uxMovieStatsTab
            // 
            this.uxMovieStatsTab.BackColor = System.Drawing.Color.DimGray;
            this.uxMovieStatsTab.Controls.Add(this.uxTotalEarningsPerRuntimeGroupsButton);
            this.uxMovieStatsTab.Controls.Add(this.uxMostPopularDirectorsButton);
            this.uxMovieStatsTab.Controls.Add(this.uxMovieEarningsButton);
            this.uxMovieStatsTab.Location = new System.Drawing.Point(4, 29);
            this.uxMovieStatsTab.Name = "uxMovieStatsTab";
            this.uxMovieStatsTab.Size = new System.Drawing.Size(518, 524);
            this.uxMovieStatsTab.TabIndex = 3;
            this.uxMovieStatsTab.Text = "Movie Stats";
            // 
            // uxTotalEarningsPerRuntimeGroupsButton
            // 
            this.uxTotalEarningsPerRuntimeGroupsButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.uxTotalEarningsPerRuntimeGroupsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.uxTotalEarningsPerRuntimeGroupsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uxTotalEarningsPerRuntimeGroupsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTotalEarningsPerRuntimeGroupsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.uxTotalEarningsPerRuntimeGroupsButton.Location = new System.Drawing.Point(47, 221);
            this.uxTotalEarningsPerRuntimeGroupsButton.Name = "uxTotalEarningsPerRuntimeGroupsButton";
            this.uxTotalEarningsPerRuntimeGroupsButton.Size = new System.Drawing.Size(336, 53);
            this.uxTotalEarningsPerRuntimeGroupsButton.TabIndex = 4;
            this.uxTotalEarningsPerRuntimeGroupsButton.Text = "Total Earnings Per Runtime Groups";
            this.uxTotalEarningsPerRuntimeGroupsButton.UseVisualStyleBackColor = false;
            this.uxTotalEarningsPerRuntimeGroupsButton.Click += new System.EventHandler(this.uxTotalEarningsPerRuntimeGroups_Click);
            // 
            // uxMostPopularDirectorsButton
            // 
            this.uxMostPopularDirectorsButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.uxMostPopularDirectorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMostPopularDirectorsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.uxMostPopularDirectorsButton.Location = new System.Drawing.Point(47, 133);
            this.uxMostPopularDirectorsButton.Name = "uxMostPopularDirectorsButton";
            this.uxMostPopularDirectorsButton.Size = new System.Drawing.Size(223, 53);
            this.uxMostPopularDirectorsButton.TabIndex = 5;
            this.uxMostPopularDirectorsButton.Text = "Most Popular Directors";
            this.uxMostPopularDirectorsButton.UseVisualStyleBackColor = false;
            this.uxMostPopularDirectorsButton.Click += new System.EventHandler(this.uxMostPopularDirectorsButton_Click);
            // 
            // uxMovieEarningsButton
            // 
            this.uxMovieEarningsButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.uxMovieEarningsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMovieEarningsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.uxMovieEarningsButton.Location = new System.Drawing.Point(47, 46);
            this.uxMovieEarningsButton.Name = "uxMovieEarningsButton";
            this.uxMovieEarningsButton.Size = new System.Drawing.Size(223, 53);
            this.uxMovieEarningsButton.TabIndex = 6;
            this.uxMovieEarningsButton.Text = "Movie Earnings";
            this.uxMovieEarningsButton.UseVisualStyleBackColor = false;
            this.uxMovieEarningsButton.Click += new System.EventHandler(this.uxMovieEarningsButton_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPage1.Controls.Add(this.uxAddReviewButton);
            this.tabPage1.Controls.Add(this.uxScoreUpDown);
            this.tabPage1.Controls.Add(this.uxUsernameTextbox);
            this.tabPage1.Controls.Add(this.uxReviewMovieTitleTextbox);
            this.tabPage1.Controls.Add(this.uxScoreLabel);
            this.tabPage1.Controls.Add(this.uxUsernameLabel);
            this.tabPage1.Controls.Add(this.uxReviewMovieTitleLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(518, 524);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Reviews";
            // 
            // uxAddReviewButton
            // 
            this.uxAddReviewButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.uxAddReviewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddReviewButton.ForeColor = System.Drawing.SystemColors.Control;
            this.uxAddReviewButton.Location = new System.Drawing.Point(39, 337);
            this.uxAddReviewButton.Name = "uxAddReviewButton";
            this.uxAddReviewButton.Size = new System.Drawing.Size(148, 56);
            this.uxAddReviewButton.TabIndex = 5;
            this.uxAddReviewButton.Text = "Add";
            this.uxAddReviewButton.UseVisualStyleBackColor = false;
            this.uxAddReviewButton.Click += new System.EventHandler(this.uxAddReviewButton_Click);
            // 
            // uxScoreUpDown
            // 
            this.uxScoreUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxScoreUpDown.Location = new System.Drawing.Point(39, 263);
            this.uxScoreUpDown.Name = "uxScoreUpDown";
            this.uxScoreUpDown.Size = new System.Drawing.Size(229, 29);
            this.uxScoreUpDown.TabIndex = 4;
            // 
            // uxUsernameTextbox
            // 
            this.uxUsernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUsernameTextbox.Location = new System.Drawing.Point(39, 69);
            this.uxUsernameTextbox.Name = "uxUsernameTextbox";
            this.uxUsernameTextbox.Size = new System.Drawing.Size(229, 29);
            this.uxUsernameTextbox.TabIndex = 3;
            // 
            // uxReviewMovieTitleTextbox
            // 
            this.uxReviewMovieTitleTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxReviewMovieTitleTextbox.Location = new System.Drawing.Point(39, 164);
            this.uxReviewMovieTitleTextbox.Name = "uxReviewMovieTitleTextbox";
            this.uxReviewMovieTitleTextbox.Size = new System.Drawing.Size(229, 29);
            this.uxReviewMovieTitleTextbox.TabIndex = 3;
            // 
            // uxScoreLabel
            // 
            this.uxScoreLabel.AutoSize = true;
            this.uxScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxScoreLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.uxScoreLabel.Location = new System.Drawing.Point(35, 236);
            this.uxScoreLabel.Name = "uxScoreLabel";
            this.uxScoreLabel.Size = new System.Drawing.Size(128, 24);
            this.uxScoreLabel.TabIndex = 2;
            this.uxScoreLabel.Text = "Score (0 - 10):";
            // 
            // uxUsernameLabel
            // 
            this.uxUsernameLabel.AutoSize = true;
            this.uxUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUsernameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.uxUsernameLabel.Location = new System.Drawing.Point(35, 42);
            this.uxUsernameLabel.Name = "uxUsernameLabel";
            this.uxUsernameLabel.Size = new System.Drawing.Size(102, 24);
            this.uxUsernameLabel.TabIndex = 2;
            this.uxUsernameLabel.Text = "Username:";
            // 
            // uxReviewMovieTitleLabel
            // 
            this.uxReviewMovieTitleLabel.AutoSize = true;
            this.uxReviewMovieTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxReviewMovieTitleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.uxReviewMovieTitleLabel.Location = new System.Drawing.Point(35, 137);
            this.uxReviewMovieTitleLabel.Name = "uxReviewMovieTitleLabel";
            this.uxReviewMovieTitleLabel.Size = new System.Drawing.Size(106, 24);
            this.uxReviewMovieTitleLabel.TabIndex = 2;
            this.uxReviewMovieTitleLabel.Text = "Movie Title:";
            // 
            // uxGenreLabel
            // 
            this.uxGenreLabel.AutoSize = true;
            this.uxGenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGenreLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.uxGenreLabel.Location = new System.Drawing.Point(23, 45);
            this.uxGenreLabel.Name = "uxGenreLabel";
            this.uxGenreLabel.Size = new System.Drawing.Size(75, 24);
            this.uxGenreLabel.TabIndex = 5;
            this.uxGenreLabel.Text = "Search:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(555, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Output:";
            // 
            // uxSalaryLabel
            // 
            this.uxSalaryLabel.AutoSize = true;
            this.uxSalaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSalaryLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.uxSalaryLabel.Location = new System.Drawing.Point(289, 271);
            this.uxSalaryLabel.Name = "uxSalaryLabel";
            this.uxSalaryLabel.Size = new System.Drawing.Size(66, 24);
            this.uxSalaryLabel.TabIndex = 0;
            this.uxSalaryLabel.Text = "Salary:";
            // 
            // uxAddSalaryUpDown
            // 
            this.uxAddSalaryUpDown.DecimalPlaces = 2;
            this.uxAddSalaryUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddSalaryUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.uxAddSalaryUpDown.InterceptArrowKeys = false;
            this.uxAddSalaryUpDown.Location = new System.Drawing.Point(293, 298);
            this.uxAddSalaryUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.uxAddSalaryUpDown.Name = "uxAddSalaryUpDown";
            this.uxAddSalaryUpDown.Size = new System.Drawing.Size(138, 29);
            this.uxAddSalaryUpDown.TabIndex = 4;
            // 
            // uxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1407, 746);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxGenreLabel);
            this.Controls.Add(this.uxSearchTabControl);
            this.Controls.Add(this.uxTopTenListView);
            this.Controls.Add(this.uxSearchButton);
            this.Controls.Add(this.uxSearchTextbox);
            this.Name = "uxForm";
            this.Text = "Movie Database";
            this.uxSearchTabControl.ResumeLayout(false);
            this.uxMoviesTab.ResumeLayout(false);
            this.uxMoviesTab.PerformLayout();
            this.uxTheatersTab.ResumeLayout(false);
            this.uxTheatersTab.PerformLayout();
            this.uxAddMovieTab.ResumeLayout(false);
            this.uxAddMovieTab.PerformLayout();
            this.uxMovieStatsTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxScoreUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxAddSalaryUpDown)).EndInit();
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
        private System.Windows.Forms.Label uxGenreLabel;
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
        private System.Windows.Forms.TabPage uxMovieStatsTab;
        private System.Windows.Forms.Button uxTotalEarningsPerRuntimeGroupsButton;
        private System.Windows.Forms.Button uxMostPopularDirectorsButton;
        private System.Windows.Forms.Button uxMovieEarningsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox uxGenreComboBox;
        private System.Windows.Forms.Label uxActorLabel;
        private System.Windows.Forms.TextBox uxActorTextbox;
        private System.Windows.Forms.Label uxDirectorLabel;
        private System.Windows.Forms.TextBox uxDirectorTextbox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox uxUsernameTextbox;
        private System.Windows.Forms.TextBox uxReviewMovieTitleTextbox;
        private System.Windows.Forms.Label uxScoreLabel;
        private System.Windows.Forms.Label uxUsernameLabel;
        private System.Windows.Forms.Label uxReviewMovieTitleLabel;
        private System.Windows.Forms.NumericUpDown uxScoreUpDown;
        private System.Windows.Forms.Button uxAddReviewButton;
        private System.Windows.Forms.TextBox uxAddDiretorTextbox;
        private System.Windows.Forms.Label uxAddDirectorLabel;
        private System.Windows.Forms.NumericUpDown uxAddSalaryUpDown;
        private System.Windows.Forms.Label uxSalaryLabel;
    }
}

