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
            this.pointOfDepartureTb = new System.Windows.Forms.MaskedTextBox();
            this.pointOfArrivalTb = new System.Windows.Forms.MaskedTextBox();
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
            this.distanceTb.Location = new System.Drawing.Point(165, 220);
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
            this.button1.Location = new System.Drawing.Point(107, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 94;
            this.button1.Text = "Продать место";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SellSeat_Click);
            // 
            // pointOfDepartureTb
            // 
            this.pointOfDepartureTb.Location = new System.Drawing.Point(165, 187);
            this.pointOfDepartureTb.Name = "pointOfDepartureTb";
            this.pointOfDepartureTb.Size = new System.Drawing.Size(100, 20);
            this.pointOfDepartureTb.TabIndex = 95;
            this.pointOfDepartureTb.ValidatingType = typeof(System.DateTime);
            // 
            // pointOfArrivalTb
            // 
            this.pointOfArrivalTb.Location = new System.Drawing.Point(164, 155);
            this.pointOfArrivalTb.Name = "pointOfArrivalTb";
            this.pointOfArrivalTb.Size = new System.Drawing.Size(100, 20);
            this.pointOfArrivalTb.TabIndex = 96;
            this.pointOfArrivalTb.ValidatingType = typeof(System.DateTime);
            // 
            // TourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 360);
            this.Controls.Add(this.pointOfArrivalTb);
            this.Controls.Add(this.pointOfDepartureTb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.freeSeatsTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeOfArrivalTb);
            this.Controls.Add(this.timeOfDepartureTb);
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
        private System.Windows.Forms.MaskedTextBox pointOfDepartureTb;
        private System.Windows.Forms.MaskedTextBox pointOfArrivalTb;
    }
}