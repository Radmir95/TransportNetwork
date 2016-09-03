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
        private Button btnBusDrivers;
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
            this.labelNameOfSystem = new System.Windows.Forms.Label();
            this.btnBusDrivers = new System.Windows.Forms.Button();
            this.btnBusses = new System.Windows.Forms.Button();
            this.btnWaybills = new System.Windows.Forms.Button();
            this.btnTours = new System.Windows.Forms.Button();
            this.btnMakeSale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNameOfSystem
            // 
            this.labelNameOfSystem.AutoSize = true;
            this.labelNameOfSystem.Location = new System.Drawing.Point(277, 33);
            this.labelNameOfSystem.Name = "labelNameOfSystem";
            this.labelNameOfSystem.Size = new System.Drawing.Size(57, 13);
            this.labelNameOfSystem.TabIndex = 0;
            this.labelNameOfSystem.Text = "Название";
            // 
            // btnEmployees
            // 
            this.btnBusDrivers.Location = new System.Drawing.Point(34, 56);
            this.btnBusDrivers.Name = "btnEmployees";
            this.btnBusDrivers.Size = new System.Drawing.Size(104, 23);
            this.btnBusDrivers.TabIndex = 1;
            this.btnBusDrivers.Text = "Водители";
            this.btnBusDrivers.UseVisualStyleBackColor = true;
            this.btnBusDrivers.Click += new System.EventHandler(this.btnBusDrivers_Click);
            // 
            // btnBusses
            // 
            this.btnBusses.Location = new System.Drawing.Point(34, 101);
            this.btnBusses.Name = "btnBusses";
            this.btnBusses.Size = new System.Drawing.Size(104, 23);
            this.btnBusses.TabIndex = 2;
            this.btnBusses.Text = global::TransportNetwork.WebFormsApplication.Properties.Resources.ControlForm_InitializeComponent_автобусы;
            this.btnBusses.UseVisualStyleBackColor = true;
            // 
            // btnWaybills
            // 
            this.btnWaybills.Location = new System.Drawing.Point(34, 151);
            this.btnWaybills.Name = "btnWaybills";
            this.btnWaybills.Size = new System.Drawing.Size(104, 23);
            this.btnWaybills.TabIndex = 3;
            this.btnWaybills.Text = global::TransportNetwork.WebFormsApplication.Properties.Resources.ControlForm_InitializeComponent_путевые_листы;
            this.btnWaybills.UseVisualStyleBackColor = true;
            // 
            // btnTours
            // 
            this.btnTours.Location = new System.Drawing.Point(34, 201);
            this.btnTours.Name = "btnTours";
            this.btnTours.Size = new System.Drawing.Size(104, 23);
            this.btnTours.TabIndex = 4;
            this.btnTours.Text = global::TransportNetwork.WebFormsApplication.Properties.Resources.ControlForm_InitializeComponent_рейсы;
            this.btnTours.UseVisualStyleBackColor = true;
            // 
            // btnMakeSale
            // 
            this.btnMakeSale.Location = new System.Drawing.Point(34, 244);
            this.btnMakeSale.Name = "btnMakeSale";
            this.btnMakeSale.Size = new System.Drawing.Size(104, 23);
            this.btnMakeSale.TabIndex = 5;
            this.btnMakeSale.Text = global::TransportNetwork.WebFormsApplication.Properties.Resources.ControlForm_InitializeComponent_продажа_билетов;
            this.btnMakeSale.UseVisualStyleBackColor = true;
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 378);
            this.Controls.Add(this.btnMakeSale);
            this.Controls.Add(this.btnTours);
            this.Controls.Add(this.btnWaybills);
            this.Controls.Add(this.btnBusses);
            this.Controls.Add(this.btnBusDrivers);
            this.Controls.Add(this.labelNameOfSystem);
            this.Name = "ControlForm";
            this.Text = "Главная форма";
            this.ResumeLayout(false);
            this.PerformLayout();

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

        private void BtnBusDrivers_Click(object sender, EventArgs e)
        {



        }
    }
}