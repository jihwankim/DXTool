﻿namespace Tool
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.View = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CylinderPosY = new System.Windows.Forms.TextBox();
            this.CylinderPosZ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CylinderPosX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CylinderRotateY = new System.Windows.Forms.TextBox();
            this.CylinderRotateZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CylinderRotateX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.View)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(0, 0);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(400, 300);
            this.View.TabIndex = 0;
            this.View.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(406, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cylinder";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CylinderPosY);
            this.groupBox3.Controls.Add(this.CylinderPosZ);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.CylinderPosX);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(68, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(66, 97);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Position";
            // 
            // CylinderPosY
            // 
            this.CylinderPosY.Location = new System.Drawing.Point(25, 43);
            this.CylinderPosY.MaxLength = 2;
            this.CylinderPosY.Name = "CylinderPosY";
            this.CylinderPosY.Size = new System.Drawing.Size(25, 21);
            this.CylinderPosY.TabIndex = 3;
            this.CylinderPosY.Text = "0";
            this.CylinderPosY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsNumber);
            // 
            // CylinderPosZ
            // 
            this.CylinderPosZ.Location = new System.Drawing.Point(25, 70);
            this.CylinderPosZ.MaxLength = 2;
            this.CylinderPosZ.Name = "CylinderPosZ";
            this.CylinderPosZ.Size = new System.Drawing.Size(25, 21);
            this.CylinderPosZ.TabIndex = 5;
            this.CylinderPosZ.Text = "0";
            this.CylinderPosZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsNumber);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Z";
            // 
            // CylinderPosX
            // 
            this.CylinderPosX.Location = new System.Drawing.Point(25, 16);
            this.CylinderPosX.MaxLength = 2;
            this.CylinderPosX.Name = "CylinderPosX";
            this.CylinderPosX.Size = new System.Drawing.Size(25, 21);
            this.CylinderPosX.TabIndex = 1;
            this.CylinderPosX.Text = "0";
            this.CylinderPosX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsNumber);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "Y";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CylinderRotateY);
            this.groupBox2.Controls.Add(this.CylinderRotateZ);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.CylinderRotateX);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(56, 97);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rotate";
            // 
            // CylinderRotateY
            // 
            this.CylinderRotateY.Location = new System.Drawing.Point(25, 43);
            this.CylinderRotateY.MaxLength = 2;
            this.CylinderRotateY.Name = "CylinderRotateY";
            this.CylinderRotateY.Size = new System.Drawing.Size(25, 21);
            this.CylinderRotateY.TabIndex = 3;
            this.CylinderRotateY.Text = "0";
            this.CylinderRotateY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsNumber);
            // 
            // CylinderRotateZ
            // 
            this.CylinderRotateZ.Location = new System.Drawing.Point(25, 70);
            this.CylinderRotateZ.MaxLength = 2;
            this.CylinderRotateZ.Name = "CylinderRotateZ";
            this.CylinderRotateZ.Size = new System.Drawing.Size(25, 21);
            this.CylinderRotateZ.TabIndex = 5;
            this.CylinderRotateZ.Text = "0";
            this.CylinderRotateZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsNumber);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Z";
            // 
            // CylinderRotateX
            // 
            this.CylinderRotateX.Location = new System.Drawing.Point(25, 16);
            this.CylinderRotateX.MaxLength = 2;
            this.CylinderRotateX.Name = "CylinderRotateX";
            this.CylinderRotateX.Size = new System.Drawing.Size(25, 21);
            this.CylinderRotateX.TabIndex = 1;
            this.CylinderRotateX.Text = "0";
            this.CylinderRotateX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IsNumber);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 301);
            this.Controls.Add(this.View);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "짱지환짱";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Release);
            ((System.ComponentModel.ISupportInitialize)(this.View)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox View;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CylinderRotateZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CylinderRotateY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CylinderRotateX;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox CylinderPosY;
        private System.Windows.Forms.TextBox CylinderPosZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CylinderPosX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

