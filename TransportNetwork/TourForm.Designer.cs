namespace TransportNetwork.WebFormsApplication
{
    partial class TourForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.listOfTours = new System.Windows.Forms.ComboBox();
            this.timeOfArrivalTb = new System.Windows.Forms.MaskedTextBox();
            this.timeOfDepartureTb = new System.Windows.Forms.MaskedTextBox();
            this.pointOfArrivalList = new System.Windows.Forms.ComboBox();
            this.pointOfDepartureList = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.distanceTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.freeSeatsTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listOfPassenger = new System.Windows.Forms.ComboBox();
            this.firstNameTb = new System.Windows.Forms.TextBox();
            this.surNameTb = new System.Windows.Forms.TextBox();
            this.telephoneTb = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер";
            // 
            // listOfTours
            // 
            this.listOfTours.FormattingEnabled = true;
            this.listOfTours.Location = new System.Drawing.Point(121, 40);
            this.listOfTours.Name = "listOfTours";
            this.listOfTours.Size = new System.Drawing.Size(100, 21);
            this.listOfTours.TabIndex = 32;
            // 
            // timeOfArrivalTb
            // 
            this.timeOfArrivalTb.Location = new System.Drawing.Point(164, 122);
            this.timeOfArrivalTb.Name = "timeOfArrivalTb";
            this.timeOfArrivalTb.Size = new System.Drawing.Size(100, 20);
            this.timeOfArrivalTb.TabIndex = 91;
            this.timeOfArrivalTb.ValidatingType = typeof(System.DateTime);
            // 
            // timeOfDepartureTb
            // 
            this.timeOfDepartureTb.Location = new System.Drawing.Point(164, 90);
            this.timeOfDepartureTb.Name = "timeOfDepartureTb";
            this.timeOfDepartureTb.Size = new System.Drawing.Size(100, 20);
            this.timeOfDepartureTb.TabIndex = 90;
            this.timeOfDepartureTb.ValidatingType = typeof(System.DateTime);
            // 
            // pointOfArrivalList
            // 
            this.pointOfArrivalList.FormattingEnabled = true;
            this.pointOfArrivalList.Items.AddRange(new object[] {
            "Москва",
            "Альметьевск",
            "УФА",
            "Набережные челны",
            "Саратов",
            "Санкт-Петербург",
            "Чебоксары"});
            this.pointOfArrivalList.Location = new System.Drawing.Point(164, 187);
            this.pointOfArrivalList.Name = "pointOfArrivalList";
            this.pointOfArrivalList.Size = new System.Drawing.Size(100, 21);
            this.pointOfArrivalList.TabIndex = 89;
            // 
            // pointOfDepartureList
            // 
            this.pointOfDepartureList.FormattingEnabled = true;
            this.pointOfDepartureList.Items.AddRange(new object[] {
            "Казань"});
            this.pointOfDepartureList.Location = new System.Drawing.Point(165, 152);
            this.pointOfDepartureList.Name = "pointOfDepartureList";
            this.pointOfDepartureList.Size = new System.Drawing.Size(99, 21);
            this.pointOfDepartureList.TabIndex = 88;
            this.pointOfDepartureList.Text = "Казань";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 87;
            this.label13.Text = "Место прибытия";
            // 
            // distanceTb
            // 
            this.distanceTb.Location = new System.Drawing.Point(164, 227);
            this.distanceTb.Name = "distanceTb";
            this.distanceTb.Size = new System.Drawing.Size(100, 20);
            this.distanceTb.TabIndex = 86;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 85;
            this.label9.Text = "Отправление";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 84;
            this.label10.Text = "Прибытие";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 83;
            this.label11.Text = "Расстояние";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 82;
            this.label12.Text = "Место отправления";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 81;
            this.label8.Text = "Список рейсов";
            // 
            // freeSeatsTb
            // 
            this.freeSeatsTb.Location = new System.Drawing.Point(164, 272);
            this.freeSeatsTb.Name = "freeSeatsTb";
            this.freeSeatsTb.Size = new System.Drawing.Size(100, 20);
            this.freeSeatsTb.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 92;
            this.label2.Text = "Свободные места";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 94;
            this.button1.Text = "Продать место";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SellSeat_Click);
            // 
            // listOfPassenger
            // 
            this.listOfPassenger.FormattingEnabled = true;
            this.listOfPassenger.Location = new System.Drawing.Point(432, 117);
            this.listOfPassenger.Name = "listOfPassenger";
            this.listOfPassenger.Size = new System.Drawing.Size(100, 21);
            this.listOfPassenger.TabIndex = 103;
            // 
            // firstNameTb
            // 
            this.firstNameTb.Location = new System.Drawing.Point(432, 150);
            this.firstNameTb.Name = "firstNameTb";
            this.firstNameTb.Size = new System.Drawing.Size(100, 20);
            this.firstNameTb.TabIndex = 102;
            // 
            // surNameTb
            // 
            this.surNameTb.Location = new System.Drawing.Point(432, 187);
            this.surNameTb.Name = "surNameTb";
            this.surNameTb.Size = new System.Drawing.Size(100, 20);
            this.surNameTb.TabIndex = 101;
            // 
            // telephoneTb
            // 
            this.telephoneTb.Location = new System.Drawing.Point(432, 224);
            this.telephoneTb.Name = "telephoneTb";
            this.telephoneTb.Size = new System.Drawing.Size(100, 20);
            this.telephoneTb.TabIndex = 100;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(366, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 99;
            this.label15.Text = "Номер";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(366, 157);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 98;
            this.label16.Text = "Имя";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(366, 187);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 97;
            this.label17.Text = "Фамилия";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(366, 224);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 96;
            this.label18.Text = "Телефон";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(429, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 95;
            this.label14.Text = "Клиенты:";
            // 
            // TourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 360);
            this.Controls.Add(this.listOfPassenger);
            this.Controls.Add(this.firstNameTb);
            this.Controls.Add(this.surNameTb);
            this.Controls.Add(this.telephoneTb);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.freeSeatsTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeOfArrivalTb);
            this.Controls.Add(this.timeOfDepartureTb);
            this.Controls.Add(this.pointOfArrivalList);
            this.Controls.Add(this.pointOfDepartureList);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.distanceTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listOfTours);
            this.Controls.Add(this.label1);
            this.Name = "TourForm";
            this.Text = "Продажа билетов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listOfTours;
        private System.Windows.Forms.MaskedTextBox timeOfArrivalTb;
        private System.Windows.Forms.MaskedTextBox timeOfDepartureTb;
        private System.Windows.Forms.ComboBox pointOfArrivalList;
        private System.Windows.Forms.ComboBox pointOfDepartureList;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox distanceTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox freeSeatsTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox listOfPassenger;
        private System.Windows.Forms.TextBox firstNameTb;
        private System.Windows.Forms.TextBox surNameTb;
        private System.Windows.Forms.TextBox telephoneTb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
    }
}