using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TransportNetwork.WebFormsApplication.Properties;

namespace TransportNetwork.WebFormsApplication
{
    partial class ControlForm
    {
        private Button btnBusses;
        private Button btnEmployees;
        private Button btnMakeSale;
        private Button btnTours;
        private Button btnWaybills;


        private readonly IContainer components = null;
        private Label labelNameOfSystem;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            labelNameOfSystem = new Label();
            btnEmployees = new Button();
            btnBusses = new Button();
            btnWaybills = new Button();
            btnTours = new Button();
            btnMakeSale = new Button();
            SuspendLayout();

            labelNameOfSystem.AutoSize = true;
            labelNameOfSystem.Location = new Point(277, 33);
            labelNameOfSystem.Name = "labelNameOfSystem";
            labelNameOfSystem.Size = new Size(57, 13);
            labelNameOfSystem.TabIndex = 0;
            labelNameOfSystem.Text = Resources.ControlForm_InitializeComponent_Название;

            btnEmployees.Location = new Point(34, 56);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(104, 23);
            btnEmployees.TabIndex = 1;
            btnEmployees.Text = Resources.ControlForm_InitializeComponent_сотрудники;
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += BtnEmployees_Click;
            ;

            btnBusses.Location = new Point(34, 101);
            btnBusses.Name = "btnBusses";
            btnBusses.Size = new Size(104, 23);
            btnBusses.TabIndex = 2;
            btnBusses.Text = Resources.ControlForm_InitializeComponent_автобусы;
            btnBusses.UseVisualStyleBackColor = true;
            btnBusses.Click += BtnBusses_Click;

            btnWaybills.Location = new Point(34, 151);
            btnWaybills.Name = "btnWaybills";
            btnWaybills.Size = new Size(104, 23);
            btnWaybills.TabIndex = 3;
            btnWaybills.Text = Resources.ControlForm_InitializeComponent_путевые_листы;
            btnWaybills.UseVisualStyleBackColor = true;
            btnWaybills.Click += BtnWaybills_Click;

            btnTours.Location = new Point(34, 201);
            btnTours.Name = "btnTours";
            btnTours.Size = new Size(104, 23);
            btnTours.TabIndex = 4;
            btnTours.Text = Resources.ControlForm_InitializeComponent_рейсы;
            btnTours.UseVisualStyleBackColor = true;
            btnTours.Click += BtnTours_Click;

            btnMakeSale.Location = new Point(34, 244);
            btnMakeSale.Name = "btnMakeSale";
            btnMakeSale.Size = new Size(104, 23);
            btnMakeSale.TabIndex = 5;
            btnMakeSale.Text = Resources.ControlForm_InitializeComponent_продажа_билетов;
            btnMakeSale.UseVisualStyleBackColor = true;
            btnMakeSale.Click += BtnMakeSale_Click;

            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 378);
            Controls.Add(btnMakeSale);
            Controls.Add(btnTours);
            Controls.Add(btnWaybills);
            Controls.Add(btnBusses);
            Controls.Add(btnEmployees);
            Controls.Add(labelNameOfSystem);
            Name = "ControlForm";
            Text = Resources.ControlForm_InitializeComponent_Главная_форма;
            Load += ControlForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnMakeSale_Click(object sender, EventArgs e)
        {
        }

        private void BtnTours_Click(object sender, EventArgs e)
        {
        }

        private void BtnWaybills_Click(object sender, EventArgs e)
        {
        }

        private void BtnBusses_Click(object sender, EventArgs e)
        {
        }

        private void BtnEmployees_Click(object sender, EventArgs e)
        {
        }
    }
}