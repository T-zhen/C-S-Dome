namespace SuperMarketCashler
{
    partial class FrmBalance
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
            this.components = new System.ComponentModel.Container();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtVip = new SuperMarketCommon.SuperText(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAmount = new SuperMarketCommon.SuperText(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtPay = new SuperMarketCommon.SuperText(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.radQRCode = new System.Windows.Forms.RadioButton();
            this.radCard = new System.Windows.Forms.RadioButton();
            this.radMoney = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Red;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(299, 386);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 25);
            this.label15.TabIndex = 41;
            this.label15.Text = "ESC：取消支付";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(140, 386);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 25);
            this.label14.TabIndex = 40;
            this.label14.Text = "Enter：完成支付";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(343, 314);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 25);
            this.label13.TabIndex = 39;
            this.label13.Text = "F3：扫码";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(236, 314);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 25);
            this.label12.TabIndex = 38;
            this.label12.Text = "F2：刷卡";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(128, 314);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 25);
            this.label11.TabIndex = 37;
            this.label11.Text = "F1：现金";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(0, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(568, 4);
            this.label10.TabIndex = 36;
            // 
            // txtVip
            // 
            this.txtVip.BackColor = System.Drawing.Color.White;
            this.txtVip.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtVip.ForeColor = System.Drawing.Color.Black;
            this.txtVip.Location = new System.Drawing.Point(164, 224);
            this.txtVip.Multiline = true;
            this.txtVip.Name = "txtVip";
            this.txtVip.Size = new System.Drawing.Size(235, 25);
            this.txtVip.TabIndex = 22;
            this.txtVip.Tag = "vip";
            this.txtVip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVip_KeyDown);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(84, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 25);
            this.label9.TabIndex = 35;
            this.label9.Text = "会员帐号：";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(1, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(563, 4);
            this.label8.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(396, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "元";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(396, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "元";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.White;
            this.txtAmount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAmount.ForeColor = System.Drawing.Color.Black;
            this.txtAmount.Location = new System.Drawing.Point(173, 160);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(217, 25);
            this.txtAmount.TabIndex = 23;
            this.txtAmount.Tag = "pay";
            this.txtAmount.Text = "0.00";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(84, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "实际收款：";
            // 
            // txtPay
            // 
            this.txtPay.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtPay.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPay.Location = new System.Drawing.Point(173, 121);
            this.txtPay.Multiline = true;
            this.txtPay.Name = "txtPay";
            this.txtPay.ReadOnly = true;
            this.txtPay.Size = new System.Drawing.Size(217, 25);
            this.txtPay.TabIndex = 30;
            this.txtPay.TabStop = false;
            this.txtPay.Text = "0.00";
            this.txtPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(84, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "应该支付：";
            // 
            // radQRCode
            // 
            this.radQRCode.AutoCheck = false;
            this.radQRCode.AutoSize = true;
            this.radQRCode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radQRCode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radQRCode.Location = new System.Drawing.Point(342, 67);
            this.radQRCode.Name = "radQRCode";
            this.radQRCode.Size = new System.Drawing.Size(60, 25);
            this.radQRCode.TabIndex = 28;
            this.radQRCode.Text = "扫码";
            this.radQRCode.UseVisualStyleBackColor = true;
            // 
            // radCard
            // 
            this.radCard.AutoCheck = false;
            this.radCard.AutoSize = true;
            this.radCard.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radCard.Location = new System.Drawing.Point(276, 66);
            this.radCard.Name = "radCard";
            this.radCard.Size = new System.Drawing.Size(60, 25);
            this.radCard.TabIndex = 27;
            this.radCard.Text = "刷卡";
            this.radCard.UseVisualStyleBackColor = true;
            // 
            // radMoney
            // 
            this.radMoney.AutoCheck = false;
            this.radMoney.AutoSize = true;
            this.radMoney.Checked = true;
            this.radMoney.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radMoney.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radMoney.Location = new System.Drawing.Point(210, 66);
            this.radMoney.Name = "radMoney";
            this.radMoney.Size = new System.Drawing.Size(60, 25);
            this.radMoney.TabIndex = 26;
            this.radMoney.Text = "现金";
            this.radMoney.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(121, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "支付方式：";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(0, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(564, 4);
            this.label2.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "购物结算";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(253, 260);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 16);
            this.label16.TabIndex = 42;
            this.label16.Text = "手机号或会员号";
            // 
            // FrmBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(566, 453);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtVip);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radQRCode);
            this.Controls.Add(this.radCard);
            this.Controls.Add(this.radMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBalance";
            this.Text = "FrmBalance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private SuperMarketCommon.SuperText txtVip;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private SuperMarketCommon.SuperText txtAmount;
        private System.Windows.Forms.Label label5;
        private SuperMarketCommon.SuperText txtPay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radQRCode;
        private System.Windows.Forms.RadioButton radCard;
        private System.Windows.Forms.RadioButton radMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
    }
}