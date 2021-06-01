
namespace VideoRental_project_c
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
            this.label14 = new System.Windows.Forms.Label();
            this.CustomerMobile = new System.Windows.Forms.NumericUpDown();
            this.Customer_Delete = new System.Windows.Forms.Button();
            this.CustomerUpdate = new System.Windows.Forms.Button();
            this.CustomerAdd = new System.Windows.Forms.Button();
            this.CustomerAddress = new System.Windows.Forms.TextBox();
            this.CustomerLName = new System.Windows.Forms.TextBox();
            this.CustomerFName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtp_ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_IssueDate = new System.Windows.Forms.DateTimePicker();
            this.txt_MovieID = new System.Windows.Forms.TextBox();
            this.txt_CustomerID = new System.Windows.Forms.TextBox();
            this.btn_DeleteVideo = new System.Windows.Forms.Button();
            this.btn_ReturnVideo = new System.Windows.Forms.Button();
            this.btn_BookVideo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.movie_year = new System.Windows.Forms.TextBox();
            this.VideoDelete = new System.Windows.Forms.Button();
            this.VideoUpdate = new System.Windows.Forms.Button();
            this.VideoAdd = new System.Windows.Forms.Button();
            this.VideoCopies = new System.Windows.Forms.NumericUpDown();
            this.VideoCost = new System.Windows.Forms.NumericUpDown();
            this.VideoGenre = new System.Windows.Forms.TextBox();
            this.VideoPlot = new System.Windows.Forms.TextBox();
            this.VideoRatting = new System.Windows.Forms.TextBox();
            this.VideoTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.show_rentals = new System.Windows.Forms.Button();
            this.show_videos = new System.Windows.Forms.Button();
            this.show_customers = new System.Windows.Forms.Button();
            this.all_data_Show_grid = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerMobile)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_data_Show_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(6, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 24);
            this.label14.TabIndex = 196;
            this.label14.Text = "Movie ID";
            // 
            // CustomerMobile
            // 
            this.CustomerMobile.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerMobile.Location = new System.Drawing.Point(132, 117);
            this.CustomerMobile.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.CustomerMobile.Name = "CustomerMobile";
            this.CustomerMobile.Size = new System.Drawing.Size(154, 29);
            this.CustomerMobile.TabIndex = 192;
            // 
            // Customer_Delete
            // 
            this.Customer_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Customer_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Customer_Delete.Location = new System.Drawing.Point(12, 264);
            this.Customer_Delete.Name = "Customer_Delete";
            this.Customer_Delete.Size = new System.Drawing.Size(274, 43);
            this.Customer_Delete.TabIndex = 191;
            this.Customer_Delete.Text = "Delete";
            this.Customer_Delete.UseVisualStyleBackColor = false;
            this.Customer_Delete.Click += new System.EventHandler(this.Customer_Delete_Click);
            // 
            // CustomerUpdate
            // 
            this.CustomerUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CustomerUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomerUpdate.Location = new System.Drawing.Point(132, 220);
            this.CustomerUpdate.Name = "CustomerUpdate";
            this.CustomerUpdate.Size = new System.Drawing.Size(154, 38);
            this.CustomerUpdate.TabIndex = 190;
            this.CustomerUpdate.Text = "Update";
            this.CustomerUpdate.UseVisualStyleBackColor = false;
            this.CustomerUpdate.Click += new System.EventHandler(this.CustomerUpdate_Click);
            // 
            // CustomerAdd
            // 
            this.CustomerAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CustomerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomerAdd.Location = new System.Drawing.Point(12, 220);
            this.CustomerAdd.Name = "CustomerAdd";
            this.CustomerAdd.Size = new System.Drawing.Size(101, 38);
            this.CustomerAdd.TabIndex = 188;
            this.CustomerAdd.Text = "Add";
            this.CustomerAdd.UseVisualStyleBackColor = false;
            this.CustomerAdd.Click += new System.EventHandler(this.CustomerAdd_Click);
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerAddress.Location = new System.Drawing.Point(132, 153);
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.Size = new System.Drawing.Size(154, 32);
            this.CustomerAddress.TabIndex = 189;
            // 
            // CustomerLName
            // 
            this.CustomerLName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLName.Location = new System.Drawing.Point(132, 77);
            this.CustomerLName.Name = "CustomerLName";
            this.CustomerLName.Size = new System.Drawing.Size(154, 32);
            this.CustomerLName.TabIndex = 187;
            // 
            // CustomerFName
            // 
            this.CustomerFName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerFName.Location = new System.Drawing.Point(132, 39);
            this.CustomerFName.Name = "CustomerFName";
            this.CustomerFName.Size = new System.Drawing.Size(154, 32);
            this.CustomerFName.TabIndex = 186;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(6, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 24);
            this.label8.TabIndex = 185;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(6, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 24);
            this.label9.TabIndex = 184;
            this.label9.Text = "Mobile No.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(6, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 24);
            this.label10.TabIndex = 183;
            this.label10.Text = "Last Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(6, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 24);
            this.label11.TabIndex = 182;
            this.label11.Text = "First Name";
            // 
            // dtp_ReturnDate
            // 
            this.dtp_ReturnDate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ReturnDate.Location = new System.Drawing.Point(168, 155);
            this.dtp_ReturnDate.Name = "dtp_ReturnDate";
            this.dtp_ReturnDate.Size = new System.Drawing.Size(154, 32);
            this.dtp_ReturnDate.TabIndex = 205;
            // 
            // dtp_IssueDate
            // 
            this.dtp_IssueDate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_IssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_IssueDate.Location = new System.Drawing.Point(168, 112);
            this.dtp_IssueDate.Name = "dtp_IssueDate";
            this.dtp_IssueDate.Size = new System.Drawing.Size(154, 32);
            this.dtp_IssueDate.TabIndex = 204;
            // 
            // txt_MovieID
            // 
            this.txt_MovieID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MovieID.Location = new System.Drawing.Point(168, 71);
            this.txt_MovieID.Name = "txt_MovieID";
            this.txt_MovieID.Size = new System.Drawing.Size(154, 32);
            this.txt_MovieID.TabIndex = 203;
            // 
            // txt_CustomerID
            // 
            this.txt_CustomerID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CustomerID.Location = new System.Drawing.Point(168, 30);
            this.txt_CustomerID.Name = "txt_CustomerID";
            this.txt_CustomerID.Size = new System.Drawing.Size(154, 32);
            this.txt_CustomerID.TabIndex = 202;
            // 
            // btn_DeleteVideo
            // 
            this.btn_DeleteVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_DeleteVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteVideo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_DeleteVideo.Location = new System.Drawing.Point(12, 229);
            this.btn_DeleteVideo.Name = "btn_DeleteVideo";
            this.btn_DeleteVideo.Size = new System.Drawing.Size(274, 37);
            this.btn_DeleteVideo.TabIndex = 201;
            this.btn_DeleteVideo.Text = "Delete";
            this.btn_DeleteVideo.UseVisualStyleBackColor = false;
            this.btn_DeleteVideo.Click += new System.EventHandler(this.btn_DeleteVideo_Click);
            // 
            // btn_ReturnVideo
            // 
            this.btn_ReturnVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ReturnVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReturnVideo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ReturnVideo.Location = new System.Drawing.Point(132, 191);
            this.btn_ReturnVideo.Name = "btn_ReturnVideo";
            this.btn_ReturnVideo.Size = new System.Drawing.Size(154, 32);
            this.btn_ReturnVideo.TabIndex = 200;
            this.btn_ReturnVideo.Text = "Return";
            this.btn_ReturnVideo.UseVisualStyleBackColor = false;
            this.btn_ReturnVideo.Click += new System.EventHandler(this.btn_ReturnVideo_Click);
            // 
            // btn_BookVideo
            // 
            this.btn_BookVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_BookVideo.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BookVideo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_BookVideo.Location = new System.Drawing.Point(10, 191);
            this.btn_BookVideo.Name = "btn_BookVideo";
            this.btn_BookVideo.Size = new System.Drawing.Size(101, 32);
            this.btn_BookVideo.TabIndex = 199;
            this.btn_BookVideo.Text = "Issue";
            this.btn_BookVideo.UseVisualStyleBackColor = false;
            this.btn_BookVideo.Click += new System.EventHandler(this.btn_BookVideo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(7, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 24);
            this.label12.TabIndex = 198;
            this.label12.Text = "Date of Return ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(7, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 24);
            this.label13.TabIndex = 197;
            this.label13.Text = "Date of Issue";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtp_ReturnDate);
            this.groupBox3.Controls.Add(this.dtp_IssueDate);
            this.groupBox3.Controls.Add(this.txt_MovieID);
            this.groupBox3.Controls.Add(this.txt_CustomerID);
            this.groupBox3.Controls.Add(this.btn_DeleteVideo);
            this.groupBox3.Controls.Add(this.btn_ReturnVideo);
            this.groupBox3.Controls.Add(this.btn_BookVideo);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(666, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 330);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Movie";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(6, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 24);
            this.label15.TabIndex = 195;
            this.label15.Text = "Customer ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CustomerMobile);
            this.groupBox2.Controls.Add(this.Customer_Delete);
            this.groupBox2.Controls.Add(this.CustomerUpdate);
            this.groupBox2.Controls.Add(this.CustomerAdd);
            this.groupBox2.Controls.Add(this.CustomerAddress);
            this.groupBox2.Controls.Add(this.CustomerLName);
            this.groupBox2.Controls.Add(this.CustomerFName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(332, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 339);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Customer ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.movie_year);
            this.groupBox1.Controls.Add(this.VideoDelete);
            this.groupBox1.Controls.Add(this.VideoUpdate);
            this.groupBox1.Controls.Add(this.VideoAdd);
            this.groupBox1.Controls.Add(this.VideoCopies);
            this.groupBox1.Controls.Add(this.VideoCost);
            this.groupBox1.Controls.Add(this.VideoGenre);
            this.groupBox1.Controls.Add(this.VideoPlot);
            this.groupBox1.Controls.Add(this.VideoRatting);
            this.groupBox1.Controls.Add(this.VideoTitle);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(13, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 348);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Movie";
            // 
            // movie_year
            // 
            this.movie_year.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_year.Location = new System.Drawing.Point(127, 96);
            this.movie_year.Name = "movie_year";
            this.movie_year.Size = new System.Drawing.Size(154, 32);
            this.movie_year.TabIndex = 210;
            this.movie_year.TextChanged += new System.EventHandler(this.movie_year_TextChanged);
            // 
            // VideoDelete
            // 
            this.VideoDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VideoDelete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.VideoDelete.Location = new System.Drawing.Point(196, 297);
            this.VideoDelete.Name = "VideoDelete";
            this.VideoDelete.Size = new System.Drawing.Size(85, 32);
            this.VideoDelete.TabIndex = 209;
            this.VideoDelete.Text = "Delete";
            this.VideoDelete.UseVisualStyleBackColor = false;
            this.VideoDelete.Click += new System.EventHandler(this.VideoDelete_Click);
            // 
            // VideoUpdate
            // 
            this.VideoUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VideoUpdate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.VideoUpdate.Location = new System.Drawing.Point(105, 297);
            this.VideoUpdate.Name = "VideoUpdate";
            this.VideoUpdate.Size = new System.Drawing.Size(85, 32);
            this.VideoUpdate.TabIndex = 208;
            this.VideoUpdate.Text = "Update";
            this.VideoUpdate.UseVisualStyleBackColor = false;
            this.VideoUpdate.Click += new System.EventHandler(this.VideoUpdate_Click);
            // 
            // VideoAdd
            // 
            this.VideoAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VideoAdd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.VideoAdd.Location = new System.Drawing.Point(14, 295);
            this.VideoAdd.Name = "VideoAdd";
            this.VideoAdd.Size = new System.Drawing.Size(85, 32);
            this.VideoAdd.TabIndex = 207;
            this.VideoAdd.Text = "Add";
            this.VideoAdd.UseVisualStyleBackColor = false;
            this.VideoAdd.Click += new System.EventHandler(this.VideoAdd_Click);
            // 
            // VideoCopies
            // 
            this.VideoCopies.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoCopies.Location = new System.Drawing.Point(127, 135);
            this.VideoCopies.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.VideoCopies.Name = "VideoCopies";
            this.VideoCopies.Size = new System.Drawing.Size(154, 29);
            this.VideoCopies.TabIndex = 206;
            // 
            // VideoCost
            // 
            this.VideoCost.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoCost.Location = new System.Drawing.Point(127, 171);
            this.VideoCost.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.VideoCost.Name = "VideoCost";
            this.VideoCost.Size = new System.Drawing.Size(154, 29);
            this.VideoCost.TabIndex = 205;
            this.VideoCost.ValueChanged += new System.EventHandler(this.VideoCost_ValueChanged);
            // 
            // VideoGenre
            // 
            this.VideoGenre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoGenre.Location = new System.Drawing.Point(127, 244);
            this.VideoGenre.Name = "VideoGenre";
            this.VideoGenre.Size = new System.Drawing.Size(154, 32);
            this.VideoGenre.TabIndex = 203;
            // 
            // VideoPlot
            // 
            this.VideoPlot.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoPlot.Location = new System.Drawing.Point(127, 206);
            this.VideoPlot.Name = "VideoPlot";
            this.VideoPlot.Size = new System.Drawing.Size(154, 32);
            this.VideoPlot.TabIndex = 202;
            // 
            // VideoRatting
            // 
            this.VideoRatting.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoRatting.Location = new System.Drawing.Point(127, 58);
            this.VideoRatting.Name = "VideoRatting";
            this.VideoRatting.Size = new System.Drawing.Size(154, 32);
            this.VideoRatting.TabIndex = 201;
            // 
            // VideoTitle
            // 
            this.VideoTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoTitle.Location = new System.Drawing.Point(127, 20);
            this.VideoTitle.Name = "VideoTitle";
            this.VideoTitle.Size = new System.Drawing.Size(154, 32);
            this.VideoTitle.TabIndex = 200;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(26, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 199;
            this.label7.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(26, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 24);
            this.label6.TabIndex = 198;
            this.label6.Text = "Plot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(27, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 197;
            this.label5.Text = "Copies";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(27, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 196;
            this.label4.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(26, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 195;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 194;
            this.label2.Text = "Ratting";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(26, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 24);
            this.label16.TabIndex = 193;
            this.label16.Text = "Title";
            // 
            // show_rentals
            // 
            this.show_rentals.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_rentals.ForeColor = System.Drawing.Color.DarkRed;
            this.show_rentals.Location = new System.Drawing.Point(407, 24);
            this.show_rentals.Name = "show_rentals";
            this.show_rentals.Size = new System.Drawing.Size(146, 43);
            this.show_rentals.TabIndex = 12;
            this.show_rentals.Text = "Show Rentals";
            this.show_rentals.UseVisualStyleBackColor = true;
            this.show_rentals.Click += new System.EventHandler(this.show_rentals_Click);
            // 
            // show_videos
            // 
            this.show_videos.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_videos.ForeColor = System.Drawing.Color.DarkRed;
            this.show_videos.Location = new System.Drawing.Point(244, 24);
            this.show_videos.Name = "show_videos";
            this.show_videos.Size = new System.Drawing.Size(136, 43);
            this.show_videos.TabIndex = 11;
            this.show_videos.Text = "Show Videos";
            this.show_videos.UseVisualStyleBackColor = true;
            this.show_videos.Click += new System.EventHandler(this.show_videos_Click);
            // 
            // show_customers
            // 
            this.show_customers.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_customers.ForeColor = System.Drawing.Color.DarkRed;
            this.show_customers.Location = new System.Drawing.Point(62, 24);
            this.show_customers.Name = "show_customers";
            this.show_customers.Size = new System.Drawing.Size(176, 43);
            this.show_customers.TabIndex = 10;
            this.show_customers.Text = "Show Customers";
            this.show_customers.UseVisualStyleBackColor = true;
            this.show_customers.Click += new System.EventHandler(this.show_customers_Click);
            // 
            // all_data_Show_grid
            // 
            this.all_data_Show_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.all_data_Show_grid.Location = new System.Drawing.Point(38, 73);
            this.all_data_Show_grid.Name = "all_data_Show_grid";
            this.all_data_Show_grid.Size = new System.Drawing.Size(938, 223);
            this.all_data_Show_grid.TabIndex = 9;
            this.all_data_Show_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.all_data_Show_grid_CellClick);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkRed;
            this.button4.Location = new System.Drawing.Point(750, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(202, 43);
            this.button4.TabIndex = 17;
            this.button4.Text = "Popular Customers";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.DarkRed;
            this.button5.Location = new System.Drawing.Point(559, 24);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 43);
            this.button5.TabIndex = 16;
            this.button5.Text = "Popular Videos";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1047, 690);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.show_rentals);
            this.Controls.Add(this.show_videos);
            this.Controls.Add(this.show_customers);
            this.Controls.Add(this.all_data_Show_grid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerMobile)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_data_Show_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown CustomerMobile;
        private System.Windows.Forms.Button Customer_Delete;
        private System.Windows.Forms.Button CustomerUpdate;
        private System.Windows.Forms.Button CustomerAdd;
        private System.Windows.Forms.TextBox CustomerAddress;
        private System.Windows.Forms.TextBox CustomerLName;
        private System.Windows.Forms.TextBox CustomerFName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtp_ReturnDate;
        private System.Windows.Forms.DateTimePicker dtp_IssueDate;
        private System.Windows.Forms.TextBox txt_MovieID;
        private System.Windows.Forms.TextBox txt_CustomerID;
        private System.Windows.Forms.Button btn_DeleteVideo;
        private System.Windows.Forms.Button btn_ReturnVideo;
        private System.Windows.Forms.Button btn_BookVideo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox movie_year;
        private System.Windows.Forms.Button VideoDelete;
        private System.Windows.Forms.Button VideoUpdate;
        private System.Windows.Forms.Button VideoAdd;
        private System.Windows.Forms.NumericUpDown VideoCopies;
        private System.Windows.Forms.NumericUpDown VideoCost;
        private System.Windows.Forms.TextBox VideoGenre;
        private System.Windows.Forms.TextBox VideoPlot;
        private System.Windows.Forms.TextBox VideoRatting;
        private System.Windows.Forms.TextBox VideoTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button show_rentals;
        private System.Windows.Forms.Button show_videos;
        private System.Windows.Forms.Button show_customers;
        private System.Windows.Forms.DataGridView all_data_Show_grid;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

