namespace Appli_meteo_C_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            TBcity = new TextBox();
            btnSearch = new Button();
            lab1 = new Label();
            labSunrise = new Label();
            labDetails = new Label();
            labSunset = new Label();
            labWindSpeed = new Label();
            picIcon = new PictureBox();
            labConditions = new Label();
            label2 = new Label();
            lab2 = new Label();
            lab4 = new Label();
            lab6 = new Label();
            lab8 = new Label();
            lab10 = new Label();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(162, 78);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 0;
            label1.Text = "Ville :";
            // 
            // TBcity
            // 
            TBcity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TBcity.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBcity.Location = new Point(232, 75);
            TBcity.Name = "TBcity";
            TBcity.Size = new Size(232, 33);
            TBcity.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSearch.BackColor = Color.Transparent;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(496, 75);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(127, 33);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Rechercher";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lab1
            // 
            lab1.AutoSize = true;
            lab1.BackColor = Color.Transparent;
            lab1.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lab1.ForeColor = Color.White;
            lab1.Location = new Point(130, 167);
            lab1.Name = "lab1";
            lab1.Size = new Size(121, 25);
            lab1.TabIndex = 3;
            lab1.Text = "Conditions :";
            lab1.Click += label2_Click;
            // 
            // labSunrise
            // 
            labSunrise.AutoSize = true;
            labSunrise.BackColor = Color.Transparent;
            labSunrise.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labSunrise.ForeColor = Color.White;
            labSunrise.Location = new Point(130, 250);
            labSunrise.Name = "labSunrise";
            labSunrise.Size = new Size(156, 25);
            labSunrise.TabIndex = 4;
            labSunrise.Text = "Lever du soleil :";
            // 
            // labDetails
            // 
            labDetails.AutoSize = true;
            labDetails.BackColor = Color.Transparent;
            labDetails.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labDetails.ForeColor = Color.White;
            labDetails.Location = new Point(130, 208);
            labDetails.Name = "labDetails";
            labDetails.Size = new Size(85, 25);
            labDetails.TabIndex = 5;
            labDetails.Text = "Détails :";
            // 
            // labSunset
            // 
            labSunset.AutoSize = true;
            labSunset.BackColor = Color.Transparent;
            labSunset.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labSunset.ForeColor = Color.White;
            labSunset.Location = new Point(130, 295);
            labSunset.Name = "labSunset";
            labSunset.Size = new Size(180, 25);
            labSunset.TabIndex = 6;
            labSunset.Text = "Coucher du soleil :";
            // 
            // labWindSpeed
            // 
            labWindSpeed.AutoSize = true;
            labWindSpeed.BackColor = Color.Transparent;
            labWindSpeed.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labWindSpeed.ForeColor = Color.White;
            labWindSpeed.Location = new Point(130, 342);
            labWindSpeed.Name = "labWindSpeed";
            labWindSpeed.Size = new Size(161, 25);
            labWindSpeed.TabIndex = 7;
            labWindSpeed.Text = "Vitesse du vent :";
            // 
            // picIcon
            // 
            picIcon.BackColor = Color.Transparent;
            picIcon.Location = new Point(582, 167);
            picIcon.Name = "picIcon";
            picIcon.Size = new Size(129, 108);
            picIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picIcon.TabIndex = 8;
            picIcon.TabStop = false;
            // 
            // labConditions
            // 
            labConditions.AutoSize = true;
            labConditions.BackColor = Color.Transparent;
            labConditions.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labConditions.ForeColor = Color.White;
            labConditions.Location = new Point(303, 167);
            labConditions.Name = "labConditions";
            labConditions.Size = new Size(0, 25);
            labConditions.TabIndex = 9;
            labConditions.Click += label2_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(303, 167);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 10;
            // 
            // lab2
            // 
            lab2.AutoSize = true;
            lab2.BackColor = Color.Transparent;
            lab2.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lab2.ForeColor = Color.White;
            lab2.Location = new Point(309, 167);
            lab2.Name = "lab2";
            lab2.Size = new Size(169, 25);
            lab2.TabIndex = 11;
            lab2.Text = "non communiqué";
            // 
            // lab4
            // 
            lab4.AutoSize = true;
            lab4.BackColor = Color.Transparent;
            lab4.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lab4.ForeColor = Color.White;
            lab4.Location = new Point(309, 208);
            lab4.Name = "lab4";
            lab4.Size = new Size(169, 25);
            lab4.TabIndex = 12;
            lab4.Text = "non communiqué";
            // 
            // lab6
            // 
            lab6.AutoSize = true;
            lab6.BackColor = Color.Transparent;
            lab6.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lab6.ForeColor = Color.White;
            lab6.Location = new Point(309, 250);
            lab6.Name = "lab6";
            lab6.Size = new Size(169, 25);
            lab6.TabIndex = 14;
            lab6.Text = "non communiqué";
            // 
            // lab8
            // 
            lab8.AutoSize = true;
            lab8.BackColor = Color.Transparent;
            lab8.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lab8.ForeColor = Color.White;
            lab8.Location = new Point(309, 295);
            lab8.Name = "lab8";
            lab8.Size = new Size(169, 25);
            lab8.TabIndex = 15;
            lab8.Text = "non communiqué";
            // 
            // lab10
            // 
            lab10.AutoSize = true;
            lab10.BackColor = Color.Transparent;
            lab10.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lab10.ForeColor = Color.White;
            lab10.Location = new Point(309, 342);
            lab10.Name = "lab10";
            lab10.Size = new Size(169, 25);
            lab10.TabIndex = 16;
            lab10.Text = "non communiqué";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lab10);
            Controls.Add(lab8);
            Controls.Add(lab6);
            Controls.Add(lab4);
            Controls.Add(lab2);
            Controls.Add(label2);
            Controls.Add(labConditions);
            Controls.Add(picIcon);
            Controls.Add(labWindSpeed);
            Controls.Add(labSunset);
            Controls.Add(labDetails);
            Controls.Add(labSunrise);
            Controls.Add(lab1);
            Controls.Add(btnSearch);
            Controls.Add(TBcity);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TBcity;
        private Button btnSearch;
        private Label lab1;
        private Label labSunrise;
        private Label labDetails;
        private Label labSunset;
        private Label labWindSpeed;
        private PictureBox picIcon;
        private Label labConditions;
        private Label label2;
        private Label lab2;
        private Label lab4;
        private Label lab6;
        private Label lab8;
        private Label lab10;
    }
}
