
namespace TransportNetwork.WebFormsApplication
{
    partial class ControlForm
    {


        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelNameOfSystem;


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

            labelNameOfSystem = new System.Windows.Forms.Label();
            btnEmployees = new System.Windows.Forms.Button();
            btnBusses = new System.Windows.Forms.Button();
            btnWaybills = new System.Windows.Forms.Button();
            btnTours = new System.Windows.Forms.Button();
            btnMakeSale = new System.Windows.Forms.Button();
            SuspendLayout();
            
            labelNameOfSystem.AutoSize = true;
            labelNameOfSystem.Location = new System.Drawing.Point(277, 33);
            labelNameOfSystem.Name = "labelNameOfSystem";
            labelNameOfSystem.Size = new System.Drawing.Size(57, 13);
            labelNameOfSystem.TabIndex = 0;
            labelNameOfSystem.Text = "Название";
            
            btnEmployees.Location = new System.Drawing.Point(34, 56);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new System.Drawing.Size(104, 23);
            btnEmployees.TabIndex = 1;
            btnEmployees.Text = "сотрудники";
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += button1_Click;
            
            btnBusses.Location = new System.Drawing.Point(34, 101);
            btnBusses.Name = "btnBusses";
            btnBusses.Size = new System.Drawing.Size(104, 23);
            btnBusses.TabIndex = 2;
            btnBusses.Text = "автобусы";
            btnBusses.UseVisualStyleBackColor = true;
            btnBusses.Click += button2_Click;
            
            btnWaybills.Location = new System.Drawing.Point(34, 151);
            btnWaybills.Name = "btnWaybills";
            btnWaybills.Size = new System.Drawing.Size(104, 23);
            btnWaybills.TabIndex = 3;
            btnWaybills.Text = "путевые листы";
            btnWaybills.UseVisualStyleBackColor = true;
            btnWaybills.Click += button3_Click;
            
            btnTours.Location = new System.Drawing.Point(34, 201);
            btnTours.Name = "btnTours";
            btnTours.Size = new System.Drawing.Size(104, 23);
            btnTours.TabIndex = 4;
            btnTours.Text = "рейсы";
            btnTours.UseVisualStyleBackColor = true;
            btnTours.Click += button4_Click;
            
            btnMakeSale.Location = new System.Drawing.Point(34, 244);
            btnMakeSale.Name = "btnMakeSale";
            btnMakeSale.Size = new System.Drawing.Size(104, 23);
            btnMakeSale.TabIndex = 5;
            btnMakeSale.Text = "продажа билетов";
            btnMakeSale.UseVisualStyleBackColor = true;
            btnMakeSale.Click += button5_Click;
            
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(656, 378);
            Controls.Add(btnMakeSale);
            Controls.Add(btnTours);
            Controls.Add(btnWaybills);
            Controls.Add(btnBusses);
            Controls.Add(btnEmployees);
            Controls.Add(labelNameOfSystem);
            Name = "ControlForm";
            Text = "Главная форма";
            Load += ControlForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnBusses;
        private System.Windows.Forms.Button btnWaybills;
        private System.Windows.Forms.Button btnTours;
        private System.Windows.Forms.Button btnMakeSale;
    }
}

