﻿
namespace GoldenE.horarios
{
    partial class AgregaHorario
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTipoDeLeccion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxKardexAlumno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSalon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxNivel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxlecc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxMaestros = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBoxMaestros);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxlecc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxNivel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBoxSalon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxTipoDeLeccion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxKardexAlumno);
            this.groupBox1.Location = new System.Drawing.Point(52, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 220);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tipo Leccion";
            // 
            // comboBoxTipoDeLeccion
            // 
            this.comboBoxTipoDeLeccion.FormattingEnabled = true;
            this.comboBoxTipoDeLeccion.Location = new System.Drawing.Point(125, 84);
            this.comboBoxTipoDeLeccion.Name = "comboBoxTipoDeLeccion";
            this.comboBoxTipoDeLeccion.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoDeLeccion.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kardex del alumno";
            // 
            // textBoxKardexAlumno
            // 
            this.textBoxKardexAlumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKardexAlumno.Location = new System.Drawing.Point(148, 49);
            this.textBoxKardexAlumno.Name = "textBoxKardexAlumno";
            this.textBoxKardexAlumno.Size = new System.Drawing.Size(100, 13);
            this.textBoxKardexAlumno.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(318, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.Value = new System.DateTime(2020, 12, 9, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Hora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Salon";
            // 
            // comboBoxSalon
            // 
            this.comboBoxSalon.FormattingEnabled = true;
            this.comboBoxSalon.Location = new System.Drawing.Point(332, 84);
            this.comboBoxSalon.Name = "comboBoxSalon";
            this.comboBoxSalon.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSalon.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nivel";
            // 
            // comboBoxNivel
            // 
            this.comboBoxNivel.FormattingEnabled = true;
            this.comboBoxNivel.Location = new System.Drawing.Point(108, 132);
            this.comboBoxNivel.Name = "comboBoxNivel";
            this.comboBoxNivel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNivel.TabIndex = 29;
            this.comboBoxNivel.SelectedIndexChanged += new System.EventHandler(this.comboBoxNivel_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Leccion";
            // 
            // comboBoxlecc
            // 
            this.comboBoxlecc.FormattingEnabled = true;
            this.comboBoxlecc.Location = new System.Drawing.Point(332, 132);
            this.comboBoxlecc.Name = "comboBoxlecc";
            this.comboBoxlecc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxlecc.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(474, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Maestros";
            // 
            // comboBoxMaestros
            // 
            this.comboBoxMaestros.FormattingEnabled = true;
            this.comboBoxMaestros.Location = new System.Drawing.Point(531, 158);
            this.comboBoxMaestros.Name = "comboBoxMaestros";
            this.comboBoxMaestros.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMaestros.TabIndex = 33;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.listBox1.Location = new System.Drawing.Point(587, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 26;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AgregaHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AgregaHorario";
            this.Text = "AgregaHorario";
            this.Load += new System.EventHandler(this.AgregaHorario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTipoDeLeccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxKardexAlumno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxlecc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNivel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSalon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxMaestros;
        private System.Windows.Forms.ListBox listBox1;
    }
}