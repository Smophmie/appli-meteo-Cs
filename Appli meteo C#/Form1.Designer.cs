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
            Conditions = new Label();
            labWindSpeed = new Label();
            labConditions = new Label();
            label2 = new Label();
            weatherData = new Label();
            windSpeed = new Label();
            sunsetData = new Label();
            sunriseData = new Label();
            labSunrise = new Label();
            labSunset = new Label();
            labTemp = new Label();
            tempData = new Label();
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
            // Conditions
            // 
            Conditions.AutoSize = true;
            Conditions.BackColor = Color.Transparent;
            Conditions.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Conditions.ForeColor = Color.White;
            Conditions.Location = new Point(192, 181);
            Conditions.Name = "Conditions";
            Conditions.Size = new Size(205, 25);
            Conditions.TabIndex = 5;
            Conditions.Text = "Conditions actuelles :";
            // 
            // labWindSpeed
            // 
            labWindSpeed.AutoSize = true;
            labWindSpeed.BackColor = Color.Transparent;
            labWindSpeed.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labWindSpeed.ForeColor = Color.White;
            labWindSpeed.Location = new Point(192, 269);
            labWindSpeed.Name = "labWindSpeed";
            labWindSpeed.Size = new Size(161, 25);
            labWindSpeed.TabIndex = 7;
            labWindSpeed.Text = "Vitesse du vent :";
            // 
            // labConditions
            // 
            labConditions.AutoSize = true;
            labConditions.BackColor = Color.Transparent;
            labConditions.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labConditions.ForeColor = Color.White;
            labConditions.Location = new Point(365, 167);
            labConditions.Name = "labConditions";
            labConditions.Size = new Size(0, 25);
            labConditions.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(365, 167);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 10;
            // 
            // weatherData
            // 
            weatherData.AutoSize = true;
            weatherData.BackColor = Color.Transparent;
            weatherData.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            weatherData.ForeColor = Color.White;
            weatherData.Location = new Point(403, 181);
            weatherData.Name = "weatherData";
            weatherData.Size = new Size(169, 25);
            weatherData.TabIndex = 12;
            weatherData.Text = "non communiqué";
            // 
            // windSpeed
            // 
            windSpeed.AutoSize = true;
            windSpeed.BackColor = Color.Transparent;
            windSpeed.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            windSpeed.ForeColor = Color.White;
            windSpeed.Location = new Point(403, 269);
            windSpeed.Name = "windSpeed";
            windSpeed.Size = new Size(169, 25);
            windSpeed.TabIndex = 16;
            windSpeed.Text = "non communiqué";
            // 
            // sunsetData
            // 
            sunsetData.AutoSize = true;
            sunsetData.BackColor = Color.Transparent;
            sunsetData.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sunsetData.ForeColor = Color.White;
            sunsetData.Location = new Point(403, 370);
            sunsetData.Name = "sunsetData";
            sunsetData.Size = new Size(169, 25);
            sunsetData.TabIndex = 17;
            sunsetData.Text = "non communiqué";
            // 
            // sunriseData
            // 
            sunriseData.AutoSize = true;
            sunriseData.BackColor = Color.Transparent;
            sunriseData.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sunriseData.ForeColor = Color.White;
            sunriseData.Location = new Point(403, 317);
            sunriseData.Name = "sunriseData";
            sunriseData.Size = new Size(169, 25);
            sunriseData.TabIndex = 18;
            sunriseData.Text = "non communiqué";
            // 
            // labSunrise
            // 
            labSunrise.AutoSize = true;
            labSunrise.BackColor = Color.Transparent;
            labSunrise.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labSunrise.ForeColor = Color.White;
            labSunrise.Location = new Point(192, 317);
            labSunrise.Name = "labSunrise";
            labSunrise.Size = new Size(156, 25);
            labSunrise.TabIndex = 19;
            labSunrise.Text = "Lever du soleil :";
            // 
            // labSunset
            // 
            labSunset.AutoSize = true;
            labSunset.BackColor = Color.Transparent;
            labSunset.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labSunset.ForeColor = Color.White;
            labSunset.Location = new Point(192, 370);
            labSunset.Name = "labSunset";
            labSunset.Size = new Size(180, 25);
            labSunset.TabIndex = 20;
            labSunset.Text = "Coucher du soleil :";
            // 
            // labTemp
            // 
            labTemp.AutoSize = true;
            labTemp.BackColor = Color.Transparent;
            labTemp.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labTemp.ForeColor = Color.White;
            labTemp.Location = new Point(193, 225);
            labTemp.Name = "labTemp";
            labTemp.Size = new Size(144, 25);
            labTemp.TabIndex = 21;
            labTemp.Text = "Température  :";
            // 
            // tempData
            // 
            tempData.AutoSize = true;
            tempData.BackColor = Color.Transparent;
            tempData.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tempData.ForeColor = Color.White;
            tempData.Location = new Point(404, 225);
            tempData.Name = "tempData";
            tempData.Size = new Size(169, 25);
            tempData.TabIndex = 22;
            tempData.Text = "non communiqué";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(tempData);
            Controls.Add(labTemp);
            Controls.Add(labSunset);
            Controls.Add(labSunrise);
            Controls.Add(sunriseData);
            Controls.Add(sunsetData);
            Controls.Add(windSpeed);
            Controls.Add(weatherData);
            Controls.Add(label2);
            Controls.Add(labConditions);
            Controls.Add(labWindSpeed);
            Controls.Add(Conditions);
            Controls.Add(btnSearch);
            Controls.Add(TBcity);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TBcity;
        private Button btnSearch;
        private Label lab1;
        private Label Conditions;
        private Label labWindSpeed;
        private Label labConditions;
        private Label label2;
        private Label lab2;
        private Label weatherData;
        private Label windSpeed;
        private Label sunsetData;
        private Label sunriseData;
        private Label labSunrise;
        private Label labSunset;
        private Label labTemp;
        private Label tempData;
    }
}
