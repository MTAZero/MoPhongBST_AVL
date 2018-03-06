namespace MoPhongAVL_BST.GUI
{
    partial class FrmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.btnXoaCay = new System.Windows.Forms.Button();
            this.btnDuyetCay = new System.Windows.Forms.Button();
            this.btnXoaNode = new System.Windows.Forms.Button();
            this.btnCapNhatThongTin = new System.Windows.Forms.Button();
            this.btnTimNode = new System.Windows.Forms.Button();
            this.btnThemNode = new System.Windows.Forms.Button();
            this.groupType = new System.Windows.Forms.GroupBox();
            this.rdTinChi = new System.Windows.Forms.RadioButton();
            this.rdDTB = new System.Windows.Forms.RadioButton();
            this.rdNgaySinh = new System.Windows.Forms.RadioButton();
            this.rdHoTen = new System.Windows.Forms.RadioButton();
            this.groupLoaiCay = new System.Windows.Forms.GroupBox();
            this.rdAVL = new System.Windows.Forms.RadioButton();
            this.rdBST = new System.Windows.Forms.RadioButton();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.btnSkip = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelChucNang.SuspendLayout();
            this.groupType.SuspendLayout();
            this.groupLoaiCay.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelMain);
            this.panel1.Controls.Add(this.panelChucNang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1334, 701);
            this.panel1.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMain.Controls.Add(this.groupBox3);
            this.panelMain.Location = new System.Drawing.Point(301, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1031, 699);
            this.panelMain.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.panelDraw);
            this.groupBox3.Location = new System.Drawing.Point(14, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1010, 677);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Biểu diễn cây";
            // 
            // panelDraw
            // 
            this.panelDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDraw.Location = new System.Drawing.Point(3, 20);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(1004, 654);
            this.panelDraw.TabIndex = 0;
            // 
            // panelChucNang
            // 
            this.panelChucNang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelChucNang.Controls.Add(this.btnSkip);
            this.panelChucNang.Controls.Add(this.btnXoaCay);
            this.panelChucNang.Controls.Add(this.btnDuyetCay);
            this.panelChucNang.Controls.Add(this.btnXoaNode);
            this.panelChucNang.Controls.Add(this.btnCapNhatThongTin);
            this.panelChucNang.Controls.Add(this.btnTimNode);
            this.panelChucNang.Controls.Add(this.btnThemNode);
            this.panelChucNang.Controls.Add(this.groupType);
            this.panelChucNang.Controls.Add(this.groupLoaiCay);
            this.panelChucNang.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelChucNang.Location = new System.Drawing.Point(0, 0);
            this.panelChucNang.Name = "panelChucNang";
            this.panelChucNang.Size = new System.Drawing.Size(301, 699);
            this.panelChucNang.TabIndex = 0;
            // 
            // btnXoaCay
            // 
            this.btnXoaCay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnXoaCay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoaCay.Location = new System.Drawing.Point(9, 401);
            this.btnXoaCay.Name = "btnXoaCay";
            this.btnXoaCay.Size = new System.Drawing.Size(284, 40);
            this.btnXoaCay.TabIndex = 7;
            this.btnXoaCay.Text = "Xóa tất cả các Node";
            this.btnXoaCay.UseVisualStyleBackColor = false;
            this.btnXoaCay.Click += new System.EventHandler(this.btnXoaCay_Click);
            // 
            // btnDuyetCay
            // 
            this.btnDuyetCay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDuyetCay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDuyetCay.Location = new System.Drawing.Point(146, 355);
            this.btnDuyetCay.Name = "btnDuyetCay";
            this.btnDuyetCay.Size = new System.Drawing.Size(147, 40);
            this.btnDuyetCay.TabIndex = 6;
            this.btnDuyetCay.Text = "Duyệt cây";
            this.btnDuyetCay.UseVisualStyleBackColor = false;
            this.btnDuyetCay.Click += new System.EventHandler(this.btnDuyetCay_Click);
            // 
            // btnXoaNode
            // 
            this.btnXoaNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnXoaNode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoaNode.Location = new System.Drawing.Point(9, 355);
            this.btnXoaNode.Name = "btnXoaNode";
            this.btnXoaNode.Size = new System.Drawing.Size(131, 40);
            this.btnXoaNode.TabIndex = 5;
            this.btnXoaNode.Text = "Xóa Node";
            this.btnXoaNode.UseVisualStyleBackColor = false;
            this.btnXoaNode.Click += new System.EventHandler(this.btnXoaNode_Click);
            // 
            // btnCapNhatThongTin
            // 
            this.btnCapNhatThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCapNhatThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapNhatThongTin.Location = new System.Drawing.Point(9, 309);
            this.btnCapNhatThongTin.Name = "btnCapNhatThongTin";
            this.btnCapNhatThongTin.Size = new System.Drawing.Size(284, 40);
            this.btnCapNhatThongTin.TabIndex = 4;
            this.btnCapNhatThongTin.Text = "Cập nhật thông tin Node";
            this.btnCapNhatThongTin.UseVisualStyleBackColor = false;
            this.btnCapNhatThongTin.Click += new System.EventHandler(this.btnCapNhatThongTin_Click);
            // 
            // btnTimNode
            // 
            this.btnTimNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTimNode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimNode.Location = new System.Drawing.Point(146, 263);
            this.btnTimNode.Name = "btnTimNode";
            this.btnTimNode.Size = new System.Drawing.Size(147, 40);
            this.btnTimNode.TabIndex = 3;
            this.btnTimNode.Text = "Tìm Node";
            this.btnTimNode.UseVisualStyleBackColor = false;
            this.btnTimNode.Click += new System.EventHandler(this.btnTimNode_Click);
            // 
            // btnThemNode
            // 
            this.btnThemNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThemNode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemNode.Location = new System.Drawing.Point(9, 263);
            this.btnThemNode.Name = "btnThemNode";
            this.btnThemNode.Size = new System.Drawing.Size(131, 40);
            this.btnThemNode.TabIndex = 2;
            this.btnThemNode.Text = "Thêm Node";
            this.btnThemNode.UseVisualStyleBackColor = false;
            this.btnThemNode.Click += new System.EventHandler(this.btnThemNode_Click);
            // 
            // groupType
            // 
            this.groupType.Controls.Add(this.rdTinChi);
            this.groupType.Controls.Add(this.rdDTB);
            this.groupType.Controls.Add(this.rdNgaySinh);
            this.groupType.Controls.Add(this.rdHoTen);
            this.groupType.Location = new System.Drawing.Point(9, 94);
            this.groupType.Name = "groupType";
            this.groupType.Size = new System.Drawing.Size(284, 163);
            this.groupType.TabIndex = 1;
            this.groupType.TabStop = false;
            this.groupType.Text = "Thao tác với trường";
            // 
            // rdTinChi
            // 
            this.rdTinChi.AutoSize = true;
            this.rdTinChi.Location = new System.Drawing.Point(21, 125);
            this.rdTinChi.Name = "rdTinChi";
            this.rdTinChi.Size = new System.Drawing.Size(112, 21);
            this.rdTinChi.TabIndex = 3;
            this.rdTinChi.Text = "Tín chỉ tích lũy";
            this.rdTinChi.UseVisualStyleBackColor = true;
            // 
            // rdDTB
            // 
            this.rdDTB.AutoSize = true;
            this.rdDTB.Location = new System.Drawing.Point(21, 91);
            this.rdDTB.Name = "rdDTB";
            this.rdDTB.Size = new System.Drawing.Size(120, 21);
            this.rdDTB.TabIndex = 2;
            this.rdDTB.Text = "Điểm trung bình";
            this.rdDTB.UseVisualStyleBackColor = true;
            // 
            // rdNgaySinh
            // 
            this.rdNgaySinh.AutoSize = true;
            this.rdNgaySinh.Location = new System.Drawing.Point(21, 57);
            this.rdNgaySinh.Name = "rdNgaySinh";
            this.rdNgaySinh.Size = new System.Drawing.Size(85, 21);
            this.rdNgaySinh.TabIndex = 1;
            this.rdNgaySinh.Text = "Ngày sinh";
            this.rdNgaySinh.UseVisualStyleBackColor = true;
            // 
            // rdHoTen
            // 
            this.rdHoTen.AutoSize = true;
            this.rdHoTen.Checked = true;
            this.rdHoTen.Location = new System.Drawing.Point(21, 23);
            this.rdHoTen.Name = "rdHoTen";
            this.rdHoTen.Size = new System.Drawing.Size(84, 21);
            this.rdHoTen.TabIndex = 0;
            this.rdHoTen.TabStop = true;
            this.rdHoTen.Text = "Họ và tên";
            this.rdHoTen.UseVisualStyleBackColor = true;
            // 
            // groupLoaiCay
            // 
            this.groupLoaiCay.Controls.Add(this.rdAVL);
            this.groupLoaiCay.Controls.Add(this.rdBST);
            this.groupLoaiCay.Location = new System.Drawing.Point(9, 9);
            this.groupLoaiCay.Name = "groupLoaiCay";
            this.groupLoaiCay.Size = new System.Drawing.Size(284, 79);
            this.groupLoaiCay.TabIndex = 0;
            this.groupLoaiCay.TabStop = false;
            this.groupLoaiCay.Text = "Loại cây";
            // 
            // rdAVL
            // 
            this.rdAVL.AutoSize = true;
            this.rdAVL.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.rdAVL.Location = new System.Drawing.Point(153, 32);
            this.rdAVL.Name = "rdAVL";
            this.rdAVL.Size = new System.Drawing.Size(89, 21);
            this.rdAVL.TabIndex = 1;
            this.rdAVL.Text = "AVL Tree";
            this.rdAVL.UseVisualStyleBackColor = true;
            // 
            // rdBST
            // 
            this.rdBST.AutoSize = true;
            this.rdBST.Checked = true;
            this.rdBST.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.rdBST.Location = new System.Drawing.Point(21, 32);
            this.rdBST.Name = "rdBST";
            this.rdBST.Size = new System.Drawing.Size(90, 21);
            this.rdBST.TabIndex = 0;
            this.rdBST.TabStop = true;
            this.rdBST.Text = "BST Tree";
            this.rdBST.UseVisualStyleBackColor = true;
            // 
            // Timer
            // 
            this.Timer.Interval = 750;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSkip.Location = new System.Drawing.Point(9, 646);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(284, 40);
            this.btnSkip.TabIndex = 8;
            this.btnSkip.Text = "Bỏ qua mô phỏng";
            this.btnSkip.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1334, 701);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMain";
            this.Text = "Mô phỏng BST ";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panelChucNang.ResumeLayout(false);
            this.groupType.ResumeLayout(false);
            this.groupType.PerformLayout();
            this.groupLoaiCay.ResumeLayout(false);
            this.groupLoaiCay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelChucNang;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox groupType;
        private System.Windows.Forms.GroupBox groupLoaiCay;
        private System.Windows.Forms.Button btnCapNhatThongTin;
        private System.Windows.Forms.Button btnTimNode;
        private System.Windows.Forms.Button btnThemNode;
        private System.Windows.Forms.RadioButton rdTinChi;
        private System.Windows.Forms.RadioButton rdDTB;
        private System.Windows.Forms.RadioButton rdNgaySinh;
        private System.Windows.Forms.RadioButton rdHoTen;
        private System.Windows.Forms.RadioButton rdAVL;
        private System.Windows.Forms.RadioButton rdBST;
        private System.Windows.Forms.Button btnDuyetCay;
        private System.Windows.Forms.Button btnXoaNode;
        private System.Windows.Forms.Button btnXoaCay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panelDraw;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button btnSkip;
    }
}