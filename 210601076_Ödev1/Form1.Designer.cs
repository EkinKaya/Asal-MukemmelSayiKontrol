
namespace nesne_ödevi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSonuc = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTek = new System.Windows.Forms.TabPage();
            this.tabPageCift = new System.Windows.Forms.TabPage();
            this.listCiftSayılar = new System.Windows.Forms.ListView();
            this.tabPageAsal = new System.Windows.Forms.TabPage();
            this.tabPageMukemmel = new System.Windows.Forms.TabPage();
            this.listMukemmelSayılar = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.listAsalSayılar = new System.Windows.Forms.ListView();
            this.listTekSayılar = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPageTek.SuspendLayout();
            this.tabPageCift.SuspendLayout();
            this.tabPageAsal.SuspendLayout();
            this.tabPageMukemmel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSonuc
            // 
            this.btnSonuc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSonuc.Location = new System.Drawing.Point(392, 102);
            this.btnSonuc.Name = "btnSonuc";
            this.btnSonuc.Size = new System.Drawing.Size(168, 43);
            this.btnSonuc.TabIndex = 0;
            this.btnSonuc.Text = "Sonuçları Görüntüle";
            this.btnSonuc.UseVisualStyleBackColor = false;
            this.btnSonuc.Click += new System.EventHandler(this.btnSonuc_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageTek);
            this.tabControl1.Controls.Add(this.tabPageCift);
            this.tabControl1.Controls.Add(this.tabPageAsal);
            this.tabControl1.Controls.Add(this.tabPageMukemmel);
            this.tabControl1.Location = new System.Drawing.Point(37, 265);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(552, 158);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPageTek
            // 
            this.tabPageTek.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPageTek.Controls.Add(this.listTekSayılar);
            this.tabPageTek.Location = new System.Drawing.Point(4, 25);
            this.tabPageTek.Name = "tabPageTek";
            this.tabPageTek.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTek.Size = new System.Drawing.Size(544, 129);
            this.tabPageTek.TabIndex = 0;
            this.tabPageTek.Text = "Tek Sayılar";
            // 
            // tabPageCift
            // 
            this.tabPageCift.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPageCift.Controls.Add(this.listCiftSayılar);
            this.tabPageCift.Location = new System.Drawing.Point(4, 25);
            this.tabPageCift.Name = "tabPageCift";
            this.tabPageCift.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCift.Size = new System.Drawing.Size(544, 129);
            this.tabPageCift.TabIndex = 1;
            this.tabPageCift.Text = "Çift Sayılar";
            // 
            // listCiftSayılar
            // 
            this.listCiftSayılar.HideSelection = false;
            this.listCiftSayılar.Location = new System.Drawing.Point(0, 0);
            this.listCiftSayılar.Name = "listCiftSayılar";
            this.listCiftSayılar.Size = new System.Drawing.Size(544, 133);
            this.listCiftSayılar.TabIndex = 0;
            this.listCiftSayılar.UseCompatibleStateImageBehavior = false;
            // 
            // tabPageAsal
            // 
            this.tabPageAsal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPageAsal.Controls.Add(this.listAsalSayılar);
            this.tabPageAsal.Location = new System.Drawing.Point(4, 25);
            this.tabPageAsal.Name = "tabPageAsal";
            this.tabPageAsal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAsal.Size = new System.Drawing.Size(544, 129);
            this.tabPageAsal.TabIndex = 2;
            this.tabPageAsal.Text = "Asal Sayılar";
            // 
            // tabPageMukemmel
            // 
            this.tabPageMukemmel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPageMukemmel.Controls.Add(this.listMukemmelSayılar);
            this.tabPageMukemmel.Location = new System.Drawing.Point(4, 25);
            this.tabPageMukemmel.Name = "tabPageMukemmel";
            this.tabPageMukemmel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMukemmel.Size = new System.Drawing.Size(544, 129);
            this.tabPageMukemmel.TabIndex = 3;
            this.tabPageMukemmel.Text = "Mükemmel Sayılar";
            // 
            // listMukemmelSayılar
            // 
            this.listMukemmelSayılar.HideSelection = false;
            this.listMukemmelSayılar.Location = new System.Drawing.Point(0, 0);
            this.listMukemmelSayılar.Name = "listMukemmelSayılar";
            this.listMukemmelSayılar.Size = new System.Drawing.Size(544, 129);
            this.listMukemmelSayılar.TabIndex = 0;
            this.listMukemmelSayılar.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox2);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSonuc);
            this.groupBox1.Location = new System.Drawing.Point(37, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 167);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Bilgileri";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(377, 53);
            this.maskedTextBox2.Mask = "00000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(171, 22);
            this.maskedTextBox2.TabIndex = 6;
            this.maskedTextBox2.ValidatingType = typeof(int);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(107, 54);
            this.maskedTextBox1.Mask = "00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(171, 22);
            this.maskedTextBox1.TabIndex = 5;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bitiş";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Başlangıç";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Hosgeldiin";
            this.notifyIcon1.Visible = true;
            // 
            // listAsalSayılar
            // 
            this.listAsalSayılar.HideSelection = false;
            this.listAsalSayılar.Location = new System.Drawing.Point(0, 0);
            this.listAsalSayılar.Name = "listAsalSayılar";
            this.listAsalSayılar.Size = new System.Drawing.Size(548, 129);
            this.listAsalSayılar.TabIndex = 0;
            this.listAsalSayılar.UseCompatibleStateImageBehavior = false;
            // 
            // listTekSayılar
            // 
            this.listTekSayılar.HideSelection = false;
            this.listTekSayılar.Location = new System.Drawing.Point(0, 3);
            this.listTekSayılar.Name = "listTekSayılar";
            this.listTekSayılar.Size = new System.Drawing.Size(544, 130);
            this.listTekSayılar.TabIndex = 0;
            this.listTekSayılar.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageTek.ResumeLayout(false);
            this.tabPageCift.ResumeLayout(false);
            this.tabPageAsal.ResumeLayout(false);
            this.tabPageMukemmel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSonuc;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTek;
        private System.Windows.Forms.TabPage tabPageCift;
        private System.Windows.Forms.TabPage tabPageAsal;
        private System.Windows.Forms.TabPage tabPageMukemmel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ListView listCiftSayılar;
        private System.Windows.Forms.ListView listMukemmelSayılar;
        private System.Windows.Forms.ListView listAsalSayılar;
        private System.Windows.Forms.ListView listTekSayılar;
    }
}

