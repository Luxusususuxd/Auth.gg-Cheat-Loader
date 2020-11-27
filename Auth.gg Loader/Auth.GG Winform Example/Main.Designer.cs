namespace Auth.GG_Winform_Example
{
    public partial class Main : global::System.Windows.Forms.Form
    {
        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && this.components != null;
            if (flag)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Siticone.UI.AnimatorNS.Animation animation3 = new Siticone.UI.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneTransition1 = new Siticone.UI.WinForms.SiticoneTransition();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userid = new Siticone.UI.WinForms.SiticoneLabel();
            this.email = new Siticone.UI.WinForms.SiticoneLabel();
            this.hwid = new Siticone.UI.WinForms.SiticoneLabel();
            this.uservariable = new Siticone.UI.WinForms.SiticoneLabel();
            this.userrank = new Siticone.UI.WinForms.SiticoneLabel();
            this.ip = new Siticone.UI.WinForms.SiticoneLabel();
            this.expiry = new Siticone.UI.WinForms.SiticoneLabel();
            this.lastlogin = new Siticone.UI.WinForms.SiticoneLabel();
            this.registerdate = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneRoundedButton2 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton1 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.username = new Siticone.UI.WinForms.SiticoneLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.siticoneShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BorderRadius = 10;
            this.siticoneTransition1.SetDecoration(this.siticoneControlBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.siticoneControlBox1.HoveredState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(955, 4);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 1;
            this.siticoneControlBox1.Click += new System.EventHandler(this.siticoneControlBox1_Click);
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BorderRadius = 10;
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneTransition1.SetDecoration(this.siticoneControlBox2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(910, 4);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox2.TabIndex = 2;
            // 
            // siticoneTransition1
            // 
            this.siticoneTransition1.AnimationType = Siticone.UI.AnimatorNS.AnimationType.Rotate;
            this.siticoneTransition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(50);
            animation3.RotateCoeff = 1F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 1F;
            this.siticoneTransition1.DefaultAnimation = animation3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(11, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Module";
            // 
            // userid
            // 
            this.userid.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.userid, Siticone.UI.AnimatorNS.DecorationType.None);
            this.userid.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userid.Location = new System.Drawing.Point(2, 118);
            this.userid.Margin = new System.Windows.Forms.Padding(2);
            this.userid.Name = "userid";
            this.userid.Size = new System.Drawing.Size(77, 15);
            this.userid.TabIndex = 37;
            this.userid.Text = "siticoneLabel1";
            this.userid.Click += new System.EventHandler(this.userid_Click);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.email, Siticone.UI.AnimatorNS.DecorationType.None);
            this.email.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.email.Location = new System.Drawing.Point(2, 152);
            this.email.Margin = new System.Windows.Forms.Padding(2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(77, 15);
            this.email.TabIndex = 39;
            this.email.Text = "siticoneLabel3";
            // 
            // hwid
            // 
            this.hwid.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.hwid, Siticone.UI.AnimatorNS.DecorationType.None);
            this.hwid.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hwid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hwid.Location = new System.Drawing.Point(2, 192);
            this.hwid.Margin = new System.Windows.Forms.Padding(2);
            this.hwid.Name = "hwid";
            this.hwid.Size = new System.Drawing.Size(77, 15);
            this.hwid.TabIndex = 40;
            this.hwid.Text = "siticoneLabel4";
            // 
            // uservariable
            // 
            this.uservariable.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.uservariable, Siticone.UI.AnimatorNS.DecorationType.None);
            this.uservariable.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uservariable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uservariable.Location = new System.Drawing.Point(2, 231);
            this.uservariable.Margin = new System.Windows.Forms.Padding(2);
            this.uservariable.Name = "uservariable";
            this.uservariable.Size = new System.Drawing.Size(77, 15);
            this.uservariable.TabIndex = 41;
            this.uservariable.Text = "siticoneLabel4";
            // 
            // userrank
            // 
            this.userrank.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.userrank, Siticone.UI.AnimatorNS.DecorationType.None);
            this.userrank.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userrank.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userrank.Location = new System.Drawing.Point(2, 270);
            this.userrank.Margin = new System.Windows.Forms.Padding(2);
            this.userrank.Name = "userrank";
            this.userrank.Size = new System.Drawing.Size(77, 15);
            this.userrank.TabIndex = 42;
            this.userrank.Text = "siticoneLabel4";
            // 
            // ip
            // 
            this.ip.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.ip, Siticone.UI.AnimatorNS.DecorationType.None);
            this.ip.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ip.Location = new System.Drawing.Point(2, 309);
            this.ip.Margin = new System.Windows.Forms.Padding(2);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(77, 15);
            this.ip.TabIndex = 43;
            this.ip.Text = "siticoneLabel4";
            // 
            // expiry
            // 
            this.expiry.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.expiry, Siticone.UI.AnimatorNS.DecorationType.None);
            this.expiry.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.expiry.Location = new System.Drawing.Point(2, 349);
            this.expiry.Margin = new System.Windows.Forms.Padding(2);
            this.expiry.Name = "expiry";
            this.expiry.Size = new System.Drawing.Size(77, 15);
            this.expiry.TabIndex = 44;
            this.expiry.Text = "siticoneLabel4";
            // 
            // lastlogin
            // 
            this.lastlogin.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.lastlogin, Siticone.UI.AnimatorNS.DecorationType.None);
            this.lastlogin.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lastlogin.Location = new System.Drawing.Point(2, 392);
            this.lastlogin.Margin = new System.Windows.Forms.Padding(2);
            this.lastlogin.Name = "lastlogin";
            this.lastlogin.Size = new System.Drawing.Size(77, 15);
            this.lastlogin.TabIndex = 45;
            this.lastlogin.Text = "siticoneLabel4";
            // 
            // registerdate
            // 
            this.registerdate.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.registerdate, Siticone.UI.AnimatorNS.DecorationType.None);
            this.registerdate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerdate.Location = new System.Drawing.Point(2, 432);
            this.registerdate.Margin = new System.Windows.Forms.Padding(2);
            this.registerdate.Name = "registerdate";
            this.registerdate.Size = new System.Drawing.Size(77, 15);
            this.registerdate.TabIndex = 46;
            this.registerdate.Text = "siticoneLabel4";
            // 
            // siticoneRoundedButton2
            // 
            this.siticoneRoundedButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(252)))), ((int)(((byte)(3)))));
            this.siticoneRoundedButton2.BorderThickness = 1;
            this.siticoneRoundedButton2.CheckedState.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.CustomImages.Parent = this.siticoneRoundedButton2;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(252)))), ((int)(((byte)(3)))));
            this.siticoneRoundedButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton2.ForeColor = System.Drawing.Color.Black;
            this.siticoneRoundedButton2.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton2.HoveredState.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.Location = new System.Drawing.Point(180, 31);
            this.siticoneRoundedButton2.Name = "siticoneRoundedButton2";
            this.siticoneRoundedButton2.ShadowDecoration.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.Size = new System.Drawing.Size(166, 27);
            this.siticoneRoundedButton2.TabIndex = 47;
            this.siticoneRoundedButton2.Text = "Inject";
            this.siticoneRoundedButton2.Click += new System.EventHandler(this.siticoneRoundedButton2_Click);
            // 
            // siticoneRoundedButton1
            // 
            this.siticoneRoundedButton1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.siticoneRoundedButton1.BorderThickness = 1;
            this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneRoundedButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.siticoneRoundedButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneRoundedButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton1.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.siticoneRoundedButton1.HoveredState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Location = new System.Drawing.Point(75, 31);
            this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
            this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Size = new System.Drawing.Size(99, 27);
            this.siticoneRoundedButton1.TabIndex = 48;
            this.siticoneRoundedButton1.Text = "Open CS:GO";
            this.siticoneRoundedButton1.Click += new System.EventHandler(this.siticoneRoundedButton1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(2, 585);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 49;
            this.label3.Text = "V1.0.0.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(72, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 39);
            this.label4.TabIndex = 50;
            this.label4.Text = "*Note: It may take up to 2 minutes for the cheat to load in\r\n             the gam" +
    "e. Slower internet connections may slow \r\n             down the process of injec" +
    "tion.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.userid);
            this.panel1.Controls.Add(this.registerdate);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.hwid);
            this.panel1.Controls.Add(this.uservariable);
            this.panel1.Controls.Add(this.lastlogin);
            this.panel1.Controls.Add(this.userrank);
            this.panel1.Controls.Add(this.expiry);
            this.panel1.Controls.Add(this.ip);
            this.siticoneTransition1.SetDecoration(this.panel1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(23, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 472);
            this.panel1.TabIndex = 51;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.siticoneTransition1.SetDecoration(this.panel3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(51, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 3);
            this.panel3.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Cambria Math", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(168, -20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 84);
            this.label5.TabIndex = 47;
            this.label5.Text = "Info";
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.username, Siticone.UI.AnimatorNS.DecorationType.None);
            this.username.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.username.Location = new System.Drawing.Point(2, 85);
            this.username.Margin = new System.Windows.Forms.Padding(2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(77, 15);
            this.username.TabIndex = 38;
            this.username.Text = "siticoneLabel2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.panel2.Controls.Add(this.siticoneRoundedButton2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.siticoneRoundedButton1);
            this.siticoneTransition1.SetDecoration(this.panel2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(557, 406);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 136);
            this.panel2.TabIndex = 52;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1004, 597);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.siticoneControlBox1);
            this.siticoneTransition1.SetDecoration(this, Siticone.UI.AnimatorNS.DecorationType.BottomMirror);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auth.GG WInform";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x04000001 RID: 1
        private global::System.ComponentModel.IContainer components = null;

        // Token: 0x04000002 RID: 2
        private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

        // Token: 0x04000004 RID: 4
        private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

        // Token: 0x04000005 RID: 5
        private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

        // Token: 0x04000009 RID: 9
        private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

        // Token: 0x0400000A RID: 10
        private global::System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;
        private Siticone.UI.WinForms.SiticoneLabel hwid;
        private Siticone.UI.WinForms.SiticoneLabel email;
        private Siticone.UI.WinForms.SiticoneLabel userid;
        private Siticone.UI.WinForms.SiticoneLabel registerdate;
        private Siticone.UI.WinForms.SiticoneLabel lastlogin;
        private Siticone.UI.WinForms.SiticoneLabel expiry;
        private Siticone.UI.WinForms.SiticoneLabel ip;
        private Siticone.UI.WinForms.SiticoneLabel userrank;
        private Siticone.UI.WinForms.SiticoneLabel uservariable;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton2;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private Siticone.UI.WinForms.SiticoneLabel username;
        private System.Windows.Forms.Panel panel3;
    }
}