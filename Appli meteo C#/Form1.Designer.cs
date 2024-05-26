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
            labConditions = new Label();
            labSunrise = new Label();
            labDetails = new Label();
            labSunset = new Label();
            labWindSpeed = new Label();
            picIcon = new PictureBox();
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
            // labConditions
            // 
            labConditions.AutoSize = true;
            labConditions.BackColor = Color.Transparent;
            labConditions.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labConditions.ForeColor = Color.White;
            labConditions.Location = new Point(130, 167);
            labConditions.Name = "labConditions";
            labConditions.Size = new Size(121, 25);
            labConditions.TabIndex = 3;
            labConditions.Text = "Conditions :";
            labConditions.Click += label2_Click;
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
            picIcon.Location = new Point(469, 167);
            picIcon.Name = "picIcon";
            picIcon.Size = new Size(242, 200);
            picIcon.TabIndex = 8;
            picIcon.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(picIcon);
            Controls.Add(labWindSpeed);
            Controls.Add(labSunset);
            Controls.Add(labDetails);
            Controls.Add(labSunrise);
            Controls.Add(labConditions);
            Controls.Add(btnSearch);
            Controls.Add(TBcity);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TBcity;
        private Button btnSearch;
        private Label labConditions;
        private Label labSunrise;
        private Label labDetails;
        private Label labSunset;
        private Label labWindSpeed;
        private PictureBox picIcon;
    }
}
