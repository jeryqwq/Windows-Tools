﻿namespace 桌面特效小工具
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.pan_SysBtn = new CCWin.SkinControl.SkinPanel();
            this.btn_menu = new CCWin.SkinControl.SkinButton();
            this.btn_gofoward = new CCWin.SkinControl.SkinButton();
            this.btn_goback = new CCWin.SkinControl.SkinButton();
            this.btn_mainpage = new CCWin.SkinControl.SkinButton();
            this.btn_skin = new CCWin.SkinControl.SkinButton();
            this.btn_setting = new CCWin.SkinControl.SkinButton();
            this.btn_min = new CCWin.SkinControl.SkinButton();
            this.btn_Close = new CCWin.SkinControl.SkinButton();
            this.menu_setting = new CCWin.SkinControl.SkinContextMenuStrip();
            this.主页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.桌面时钟ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置中心ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小组ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.软件源码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.反馈建议ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_tabcontrol = new CCWin.SkinControl.SkinPanel();
            this.tab_tool = new CCWin.SkinControl.SkinTabControl();
            this.page_main = new CCWin.SkinControl.SkinTabPage();
            this.page_background = new CCWin.SkinControl.SkinTabPage();
            this.skinButton3 = new CCWin.SkinControl.SkinButton();
            this.tvList = new CCWin.SkinControl.SkinTreeView();
            this.gifLoading = new CCWin.SkinControl.GifBox();
            this.lvList = new CCWin.SkinControl.SkinListView();
            this.skinTextBox1 = new CCWin.SkinControl.SkinTextBox();
            this.page_proctect = new CCWin.SkinControl.SkinTabPage();
            this.btn_loop = new CCWin.SkinControl.SkinButton();
            this.btn_begin = new CCWin.SkinControl.SkinButton();
            this.skinRadioButton5 = new CCWin.SkinControl.SkinRadioButton();
            this.skinRadioButton10 = new CCWin.SkinControl.SkinRadioButton();
            this.skinRadioButton8 = new CCWin.SkinControl.SkinRadioButton();
            this.skinRadioButton6 = new CCWin.SkinControl.SkinRadioButton();
            this.skinRadioButton13 = new CCWin.SkinControl.SkinRadioButton();
            this.skinRadioButton2 = new CCWin.SkinControl.SkinRadioButton();
            this.panel_web = new System.Windows.Forms.Panel();
            this.web = new System.Windows.Forms.WebBrowser();
            this.page_games = new CCWin.SkinControl.SkinTabPage();
            this.page_js = new CCWin.SkinControl.SkinTabPage();
            this.tab_file = new CCWin.SkinControl.SkinTabPage();
            this.skinButton6 = new CCWin.SkinControl.SkinButton();
            this.skinButton5 = new CCWin.SkinControl.SkinButton();
            this.skinButton4 = new CCWin.SkinControl.SkinButton();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.panel_webFile = new System.Windows.Forms.Panel();
            this.page_setting = new CCWin.SkinControl.SkinTabPage();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.ToolTip = new CCWin.SkinToolTip(this.components);
            this.btn_ChangClocl = new CCWin.SkinControl.SkinButton();
            this.timer_hide = new System.Windows.Forms.Timer(this.components);
            this.pan_SysBtn.SuspendLayout();
            this.menu_setting.SuspendLayout();
            this.panel_tabcontrol.SuspendLayout();
            this.tab_tool.SuspendLayout();
            this.page_background.SuspendLayout();
            this.page_proctect.SuspendLayout();
            this.panel_web.SuspendLayout();
            this.tab_file.SuspendLayout();
            this.page_setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_SysBtn
            // 
            this.pan_SysBtn.BackColor = System.Drawing.Color.Transparent;
            this.pan_SysBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pan_SysBtn.BackgroundImage")));
            this.pan_SysBtn.Controls.Add(this.btn_menu);
            this.pan_SysBtn.Controls.Add(this.btn_gofoward);
            this.pan_SysBtn.Controls.Add(this.btn_goback);
            this.pan_SysBtn.Controls.Add(this.btn_mainpage);
            this.pan_SysBtn.Controls.Add(this.btn_skin);
            this.pan_SysBtn.Controls.Add(this.btn_setting);
            this.pan_SysBtn.Controls.Add(this.btn_min);
            this.pan_SysBtn.Controls.Add(this.btn_Close);
            this.pan_SysBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.pan_SysBtn.DownBack = null;
            this.pan_SysBtn.Location = new System.Drawing.Point(-1, 0);
            this.pan_SysBtn.MouseBack = null;
            this.pan_SysBtn.Name = "pan_SysBtn";
            this.pan_SysBtn.NormlBack = null;
            this.pan_SysBtn.Size = new System.Drawing.Size(716, 47);
            this.pan_SysBtn.TabIndex = 3;
            this.pan_SysBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pan_SysBtn_MouseDown);
            this.pan_SysBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pan_SysBtn_MouseMove);
            // 
            // btn_menu
            // 
            this.btn_menu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_menu.BackColor = System.Drawing.Color.Transparent;
            this.btn_menu.BaseColor = System.Drawing.Color.Transparent;
            this.btn_menu.BorderColor = System.Drawing.Color.Transparent;
            this.btn_menu.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_menu.DownBack = ((System.Drawing.Image)(resources.GetObject("btn_menu.DownBack")));
            this.btn_menu.DownBaseColor = System.Drawing.Color.Transparent;
            this.btn_menu.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btn_menu.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_menu.ForeColor = System.Drawing.Color.White;
            this.btn_menu.GlowColor = System.Drawing.Color.Transparent;
            this.btn_menu.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btn_menu.Location = new System.Drawing.Point(610, 14);
            this.btn_menu.MouseBack = ((System.Drawing.Image)(resources.GetObject("btn_menu.MouseBack")));
            this.btn_menu.MouseBaseColor = System.Drawing.Color.Transparent;
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.NormlBack = ((System.Drawing.Image)(resources.GetObject("btn_menu.NormlBack")));
            this.btn_menu.Size = new System.Drawing.Size(16, 16);
            this.btn_menu.TabIndex = 8;
            this.ToolTip.SetToolTip(this.btn_menu, "菜单");
            this.btn_menu.UseVisualStyleBackColor = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_gofoward
            // 
            this.btn_gofoward.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_gofoward.BackColor = System.Drawing.Color.Transparent;
            this.btn_gofoward.BaseColor = System.Drawing.Color.Transparent;
            this.btn_gofoward.BorderColor = System.Drawing.Color.Transparent;
            this.btn_gofoward.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_gofoward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gofoward.DownBack = ((System.Drawing.Image)(resources.GetObject("btn_gofoward.DownBack")));
            this.btn_gofoward.DownBaseColor = System.Drawing.Color.Transparent;
            this.btn_gofoward.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btn_gofoward.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_gofoward.ForeColor = System.Drawing.Color.White;
            this.btn_gofoward.GlowColor = System.Drawing.Color.Transparent;
            this.btn_gofoward.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btn_gofoward.Location = new System.Drawing.Point(201, 14);
            this.btn_gofoward.MouseBack = ((System.Drawing.Image)(resources.GetObject("btn_gofoward.MouseBack")));
            this.btn_gofoward.MouseBaseColor = System.Drawing.Color.Transparent;
            this.btn_gofoward.Name = "btn_gofoward";
            this.btn_gofoward.NormlBack = ((System.Drawing.Image)(resources.GetObject("btn_gofoward.NormlBack")));
            this.btn_gofoward.Size = new System.Drawing.Size(16, 16);
            this.btn_gofoward.TabIndex = 7;
            this.ToolTip.SetToolTip(this.btn_gofoward, "下一页");
            this.btn_gofoward.UseVisualStyleBackColor = false;
            this.btn_gofoward.Click += new System.EventHandler(this.btn_gofoward_Click);
            // 
            // btn_goback
            // 
            this.btn_goback.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_goback.BackColor = System.Drawing.Color.Transparent;
            this.btn_goback.BaseColor = System.Drawing.Color.Transparent;
            this.btn_goback.BorderColor = System.Drawing.Color.Black;
            this.btn_goback.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_goback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_goback.DownBack = ((System.Drawing.Image)(resources.GetObject("btn_goback.DownBack")));
            this.btn_goback.DownBaseColor = System.Drawing.Color.Transparent;
            this.btn_goback.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btn_goback.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_goback.ForeColor = System.Drawing.Color.White;
            this.btn_goback.GlowColor = System.Drawing.Color.Transparent;
            this.btn_goback.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btn_goback.IsDrawBorder = false;
            this.btn_goback.Location = new System.Drawing.Point(184, 14);
            this.btn_goback.MouseBack = ((System.Drawing.Image)(resources.GetObject("btn_goback.MouseBack")));
            this.btn_goback.MouseBaseColor = System.Drawing.Color.Transparent;
            this.btn_goback.Name = "btn_goback";
            this.btn_goback.NormlBack = ((System.Drawing.Image)(resources.GetObject("btn_goback.NormlBack")));
            this.btn_goback.Size = new System.Drawing.Size(16, 16);
            this.btn_goback.TabIndex = 6;
            this.ToolTip.SetToolTip(this.btn_goback, "上一页");
            this.btn_goback.UseVisualStyleBackColor = false;
            this.btn_goback.Click += new System.EventHandler(this.btn_goback_Click);
            // 
            // btn_mainpage
            // 
            this.btn_mainpage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_mainpage.BackColor = System.Drawing.Color.Transparent;
            this.btn_mainpage.BaseColor = System.Drawing.Color.Transparent;
            this.btn_mainpage.BorderColor = System.Drawing.Color.Transparent;
            this.btn_mainpage.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_mainpage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mainpage.DownBack = ((System.Drawing.Image)(resources.GetObject("btn_mainpage.DownBack")));
            this.btn_mainpage.DownBaseColor = System.Drawing.Color.Transparent;
            this.btn_mainpage.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btn_mainpage.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_mainpage.ForeColor = System.Drawing.Color.White;
            this.btn_mainpage.GlowColor = System.Drawing.Color.Transparent;
            this.btn_mainpage.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btn_mainpage.Location = new System.Drawing.Point(-2, -1);
            this.btn_mainpage.MouseBack = ((System.Drawing.Image)(resources.GetObject("btn_mainpage.MouseBack")));
            this.btn_mainpage.MouseBaseColor = System.Drawing.Color.Transparent;
            this.btn_mainpage.Name = "btn_mainpage";
            this.btn_mainpage.NormlBack = ((System.Drawing.Image)(resources.GetObject("btn_mainpage.NormlBack")));
            this.btn_mainpage.Size = new System.Drawing.Size(176, 51);
            this.btn_mainpage.TabIndex = 5;
            this.ToolTip.SetToolTip(this.btn_mainpage, "回到主页");
            this.btn_mainpage.UseVisualStyleBackColor = false;
            // 
            // btn_skin
            // 
            this.btn_skin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_skin.BackColor = System.Drawing.Color.Transparent;
            this.btn_skin.BaseColor = System.Drawing.Color.Transparent;
            this.btn_skin.BorderColor = System.Drawing.Color.Transparent;
            this.btn_skin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_skin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_skin.DownBack = ((System.Drawing.Image)(resources.GetObject("btn_skin.DownBack")));
            this.btn_skin.DownBaseColor = System.Drawing.Color.Transparent;
            this.btn_skin.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btn_skin.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_skin.ForeColor = System.Drawing.Color.White;
            this.btn_skin.GlowColor = System.Drawing.Color.Transparent;
            this.btn_skin.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btn_skin.Location = new System.Drawing.Point(546, 14);
            this.btn_skin.MouseBack = ((System.Drawing.Image)(resources.GetObject("btn_skin.MouseBack")));
            this.btn_skin.MouseBaseColor = System.Drawing.Color.Transparent;
            this.btn_skin.Name = "btn_skin";
            this.btn_skin.NormlBack = ((System.Drawing.Image)(resources.GetObject("btn_skin.NormlBack")));
            this.btn_skin.Size = new System.Drawing.Size(16, 16);
            this.btn_skin.TabIndex = 4;
            this.ToolTip.SetToolTip(this.btn_skin, "请选择一个皮肤");
            this.btn_skin.UseVisualStyleBackColor = false;
            this.btn_skin.Click += new System.EventHandler(this.btn_skin_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_setting.BackColor = System.Drawing.Color.Transparent;
            this.btn_setting.BaseColor = System.Drawing.Color.Transparent;
            this.btn_setting.BorderColor = System.Drawing.Color.Transparent;
            this.btn_setting.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_setting.DownBack = null;
            this.btn_setting.DownBaseColor = System.Drawing.Color.Transparent;
            this.btn_setting.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btn_setting.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_setting.ForeColor = System.Drawing.Color.White;
            this.btn_setting.GlowColor = System.Drawing.Color.Transparent;
            this.btn_setting.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btn_setting.Location = new System.Drawing.Point(578, 14);
            this.btn_setting.MouseBack = ((System.Drawing.Image)(resources.GetObject("btn_setting.MouseBack")));
            this.btn_setting.MouseBaseColor = System.Drawing.Color.Transparent;
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.NormlBack = ((System.Drawing.Image)(resources.GetObject("btn_setting.NormlBack")));
            this.btn_setting.Size = new System.Drawing.Size(16, 16);
            this.btn_setting.TabIndex = 3;
            this.ToolTip.SetToolTip(this.btn_setting, "设置");
            this.btn_setting.UseVisualStyleBackColor = false;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // btn_min
            // 
            this.btn_min.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_min.BackColor = System.Drawing.Color.Transparent;
            this.btn_min.BaseColor = System.Drawing.Color.Transparent;
            this.btn_min.BorderColor = System.Drawing.Color.Transparent;
            this.btn_min.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_min.DownBack = ((System.Drawing.Image)(resources.GetObject("btn_min.DownBack")));
            this.btn_min.DownBaseColor = System.Drawing.Color.Transparent;
            this.btn_min.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btn_min.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_min.ForeColor = System.Drawing.Color.White;
            this.btn_min.GlowColor = System.Drawing.Color.Transparent;
            this.btn_min.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btn_min.Location = new System.Drawing.Point(666, 14);
            this.btn_min.MouseBack = ((System.Drawing.Image)(resources.GetObject("btn_min.MouseBack")));
            this.btn_min.MouseBaseColor = System.Drawing.Color.Transparent;
            this.btn_min.Name = "btn_min";
            this.btn_min.NormlBack = ((System.Drawing.Image)(resources.GetObject("btn_min.NormlBack")));
            this.btn_min.Size = new System.Drawing.Size(16, 16);
            this.btn_min.TabIndex = 2;
            this.ToolTip.SetToolTip(this.btn_min, "最小化");
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BaseColor = System.Drawing.Color.Transparent;
            this.btn_Close.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Close.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.DownBack = ((System.Drawing.Image)(resources.GetObject("btn_Close.DownBack")));
            this.btn_Close.DownBaseColor = System.Drawing.Color.Transparent;
            this.btn_Close.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btn_Close.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.GlowColor = System.Drawing.Color.Transparent;
            this.btn_Close.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btn_Close.Location = new System.Drawing.Point(690, 14);
            this.btn_Close.MouseBack = ((System.Drawing.Image)(resources.GetObject("btn_Close.MouseBack")));
            this.btn_Close.MouseBaseColor = System.Drawing.Color.Transparent;
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.NormlBack = ((System.Drawing.Image)(resources.GetObject("btn_Close.NormlBack")));
            this.btn_Close.Size = new System.Drawing.Size(16, 16);
            this.btn_Close.TabIndex = 0;
            this.ToolTip.SetToolTip(this.btn_Close, "关闭");
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // menu_setting
            // 
            this.menu_setting.Arrow = System.Drawing.SystemColors.Highlight;
            this.menu_setting.AutoSize = false;
            this.menu_setting.Back = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_setting.BackRadius = 4;
            this.menu_setting.Base = System.Drawing.SystemColors.Highlight;
            this.menu_setting.DropDownImageSeparator = System.Drawing.SystemColors.Highlight;
            this.menu_setting.Fore = System.Drawing.Color.Black;
            this.menu_setting.HoverFore = System.Drawing.Color.White;
            this.menu_setting.ItemAnamorphosis = false;
            this.menu_setting.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu_setting.ItemBorderShow = true;
            this.menu_setting.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu_setting.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu_setting.ItemRadius = 10;
            this.menu_setting.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.menu_setting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.主页ToolStripMenuItem,
            this.桌面时钟ToolStripMenuItem,
            this.设置中心ToolStripMenuItem,
            this.小组ToolStripMenuItem,
            this.软件源码ToolStripMenuItem,
            this.反馈建议ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menu_setting.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.menu_setting.Name = "menu_setting";
            this.menu_setting.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.menu_setting.Size = new System.Drawing.Size(115, 160);
            this.menu_setting.SkinAllColor = true;
            this.menu_setting.TitleAnamorphosis = false;
            this.menu_setting.TitleColor = System.Drawing.Color.White;
            this.menu_setting.TitleRadius = 10;
            this.menu_setting.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 主页ToolStripMenuItem
            // 
            this.主页ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("主页ToolStripMenuItem.Image")));
            this.主页ToolStripMenuItem.Name = "主页ToolStripMenuItem";
            this.主页ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.主页ToolStripMenuItem.Text = "主页";
            this.主页ToolStripMenuItem.Click += new System.EventHandler(this.主页ToolStripMenuItem_Click);
            // 
            // 桌面时钟ToolStripMenuItem
            // 
            this.桌面时钟ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("桌面时钟ToolStripMenuItem.Image")));
            this.桌面时钟ToolStripMenuItem.Name = "桌面时钟ToolStripMenuItem";
            this.桌面时钟ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.桌面时钟ToolStripMenuItem.Text = "桌面时钟";
            this.桌面时钟ToolStripMenuItem.Click += new System.EventHandler(this.桌面时钟ToolStripMenuItem_Click);
            // 
            // 设置中心ToolStripMenuItem
            // 
            this.设置中心ToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.设置中心ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("设置中心ToolStripMenuItem.Image")));
            this.设置中心ToolStripMenuItem.Name = "设置中心ToolStripMenuItem";
            this.设置中心ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.设置中心ToolStripMenuItem.Text = "设置中心";
            this.设置中心ToolStripMenuItem.Click += new System.EventHandler(this.设置中心ToolStripMenuItem_Click);
            // 
            // 小组ToolStripMenuItem
            // 
            this.小组ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("小组ToolStripMenuItem.Image")));
            this.小组ToolStripMenuItem.Name = "小组ToolStripMenuItem";
            this.小组ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.小组ToolStripMenuItem.Text = "小组人员";
            this.小组ToolStripMenuItem.Click += new System.EventHandler(this.小组ToolStripMenuItem_Click);
            // 
            // 软件源码ToolStripMenuItem
            // 
            this.软件源码ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("软件源码ToolStripMenuItem.Image")));
            this.软件源码ToolStripMenuItem.Name = "软件源码ToolStripMenuItem";
            this.软件源码ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.软件源码ToolStripMenuItem.Text = "软件源码";
            // 
            // 反馈建议ToolStripMenuItem
            // 
            this.反馈建议ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("反馈建议ToolStripMenuItem.Image")));
            this.反馈建议ToolStripMenuItem.Name = "反馈建议ToolStripMenuItem";
            this.反馈建议ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.反馈建议ToolStripMenuItem.Text = "反馈建议";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("关于ToolStripMenuItem.Image")));
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // panel_tabcontrol
            // 
            this.panel_tabcontrol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_tabcontrol.BackColor = System.Drawing.Color.Transparent;
            this.panel_tabcontrol.Controls.Add(this.tab_tool);
            this.panel_tabcontrol.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_tabcontrol.DownBack = null;
            this.panel_tabcontrol.Location = new System.Drawing.Point(-1, 43);
            this.panel_tabcontrol.MouseBack = null;
            this.panel_tabcontrol.Name = "panel_tabcontrol";
            this.panel_tabcontrol.NormlBack = null;
            this.panel_tabcontrol.Size = new System.Drawing.Size(719, 490);
            this.panel_tabcontrol.TabIndex = 4;
            // 
            // tab_tool
            // 
            this.tab_tool.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tab_tool.AnimationStart = true;
            this.tab_tool.AnimatorType = CCWin.SkinControl.AnimationType.Transparent;
            this.tab_tool.ArrowBaseColor = System.Drawing.Color.Transparent;
            this.tab_tool.ArrowBorderColor = System.Drawing.Color.Transparent;
            this.tab_tool.ArrowColor = System.Drawing.Color.Transparent;
            this.tab_tool.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.tab_tool.Controls.Add(this.page_main);
            this.tab_tool.Controls.Add(this.page_background);
            this.tab_tool.Controls.Add(this.page_proctect);
            this.tab_tool.Controls.Add(this.page_games);
            this.tab_tool.Controls.Add(this.page_js);
            this.tab_tool.Controls.Add(this.tab_file);
            this.tab_tool.Controls.Add(this.page_setting);
            this.tab_tool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_tool.HeadBack = null;
            this.tab_tool.HotTrack = true;
            this.tab_tool.ImgSize = new System.Drawing.Size(45, 30);
            this.tab_tool.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.tab_tool.ImgTxtSpace = 0;
            this.tab_tool.Interval = 50;
            this.tab_tool.ItemSize = new System.Drawing.Size(102, 51);
            this.tab_tool.Location = new System.Drawing.Point(0, 0);
            this.tab_tool.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.tab_tool.Name = "tab_tool";
            this.tab_tool.Padding = new System.Drawing.Point(0, 0);
            this.tab_tool.PageArrowDown = null;
            this.tab_tool.PageArrowHover = null;
            this.tab_tool.PageArrowRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.tab_tool.PageBaseColor = System.Drawing.Color.Transparent;
            this.tab_tool.PageBorderColor = System.Drawing.Color.Transparent;
            this.tab_tool.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("tab_tool.PageCloseHover")));
            this.tab_tool.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("tab_tool.PageCloseNormal")));
            this.tab_tool.PageDown = ((System.Drawing.Image)(resources.GetObject("tab_tool.PageDown")));
            this.tab_tool.PageDownTxtColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tab_tool.PageHover = ((System.Drawing.Image)(resources.GetObject("tab_tool.PageHover")));
            this.tab_tool.PageHoverTxtColor = System.Drawing.Color.Aqua;
            this.tab_tool.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Top;
            this.tab_tool.PageNorml = null;
            this.tab_tool.PageNormlTxtColor = System.Drawing.Color.White;
            this.tab_tool.SelectedIndex = 2;
            this.tab_tool.Size = new System.Drawing.Size(719, 490);
            this.tab_tool.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab_tool.TabIndex = 6;
            this.tab_tool.SelectedIndexChanged += new System.EventHandler(this.tab_tool_SelectedIndexChanged);
            // 
            // page_main
            // 
            this.page_main.BackColor = System.Drawing.Color.Transparent;
            this.page_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.page_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_main.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.page_main.Location = new System.Drawing.Point(0, 0);
            this.page_main.Name = "page_main";
            this.page_main.Size = new System.Drawing.Size(719, 439);
            this.page_main.TabIndex = 5;
            this.page_main.TabItemImage = ((System.Drawing.Image)(resources.GetObject("page_main.TabItemImage")));
            this.page_main.Text = "主页";
            // 
            // page_background
            // 
            this.page_background.BackColor = System.Drawing.Color.Transparent;
            this.page_background.Controls.Add(this.skinButton3);
            this.page_background.Controls.Add(this.tvList);
            this.page_background.Controls.Add(this.gifLoading);
            this.page_background.Controls.Add(this.lvList);
            this.page_background.Controls.Add(this.skinTextBox1);
            this.page_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_background.Location = new System.Drawing.Point(0, 0);
            this.page_background.Name = "page_background";
            this.page_background.Size = new System.Drawing.Size(719, 439);
            this.page_background.TabIndex = 0;
            this.page_background.TabItemImage = ((System.Drawing.Image)(resources.GetObject("page_background.TabItemImage")));
            this.page_background.Text = "在线壁纸";
            this.page_background.ToolTipText = "桌面屏保";
            // 
            // skinButton3
            // 
            this.skinButton3.BackColor = System.Drawing.Color.Transparent;
            this.skinButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinButton3.BackgroundImage")));
            this.skinButton3.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton3.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton3.DownBack = ((System.Drawing.Image)(resources.GetObject("skinButton3.DownBack")));
            this.skinButton3.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton3.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton3.FadeGlow = false;
            this.skinButton3.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton3.ForeColor = System.Drawing.Color.Transparent;
            this.skinButton3.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton3.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton3.Location = new System.Drawing.Point(459, 16);
            this.skinButton3.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinButton3.MouseBack")));
            this.skinButton3.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton3.Name = "skinButton3";
            this.skinButton3.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinButton3.NormlBack")));
            this.skinButton3.Size = new System.Drawing.Size(109, 34);
            this.skinButton3.TabIndex = 34;
            this.skinButton3.Text = "百度一下";
            this.skinButton3.UseVisualStyleBackColor = true;
            // 
            // tvList
            // 
            this.tvList.Location = new System.Drawing.Point(0, 75);
            this.tvList.Name = "tvList";
            this.tvList.Size = new System.Drawing.Size(174, 362);
            this.tvList.TabIndex = 4;
            // 
            // gifLoading
            // 
            this.gifLoading.BackColor = System.Drawing.Color.White;
            this.gifLoading.BorderColor = System.Drawing.Color.White;
            this.gifLoading.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gifLoading.Image = null;
            this.gifLoading.Location = new System.Drawing.Point(384, 234);
            this.gifLoading.Name = "gifLoading";
            this.gifLoading.Size = new System.Drawing.Size(132, 101);
            this.gifLoading.TabIndex = 3;
            this.gifLoading.Text = "加载中...";
            this.gifLoading.Visible = false;
            // 
            // lvList
            // 
            this.lvList.Location = new System.Drawing.Point(171, 75);
            this.lvList.Name = "lvList";
            this.lvList.OwnerDraw = true;
            this.lvList.Size = new System.Drawing.Size(539, 362);
            this.lvList.TabIndex = 2;
            this.lvList.UseCompatibleStateImageBehavior = false;
            // 
            // skinTextBox1
            // 
            this.skinTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox1.DownBack = null;
            this.skinTextBox1.Icon = null;
            this.skinTextBox1.IconIsButton = false;
            this.skinTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.IsPasswordChat = '\0';
            this.skinTextBox1.IsSystemPasswordChar = false;
            this.skinTextBox1.Lines = new string[0];
            this.skinTextBox1.Location = new System.Drawing.Point(124, 25);
            this.skinTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox1.MaxLength = 32767;
            this.skinTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox1.MouseBack = null;
            this.skinTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.Multiline = false;
            this.skinTextBox1.Name = "skinTextBox1";
            this.skinTextBox1.NormlBack = null;
            this.skinTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox1.ReadOnly = false;
            this.skinTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox1.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.skinTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox1.SkinTxt.Name = "BaseText";
            this.skinTextBox1.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.skinTextBox1.SkinTxt.TabIndex = 0;
            this.skinTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.SkinTxt.WaterText = "自定义关键字搜索";
            this.skinTextBox1.TabIndex = 5;
            this.skinTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.WaterText = "自定义关键字搜索";
            this.skinTextBox1.WordWrap = true;
            // 
            // page_proctect
            // 
            this.page_proctect.BackColor = System.Drawing.Color.Transparent;
            this.page_proctect.Controls.Add(this.btn_loop);
            this.page_proctect.Controls.Add(this.btn_begin);
            this.page_proctect.Controls.Add(this.skinRadioButton5);
            this.page_proctect.Controls.Add(this.skinRadioButton10);
            this.page_proctect.Controls.Add(this.skinRadioButton8);
            this.page_proctect.Controls.Add(this.skinRadioButton6);
            this.page_proctect.Controls.Add(this.skinRadioButton13);
            this.page_proctect.Controls.Add(this.skinRadioButton2);
            this.page_proctect.Controls.Add(this.panel_web);
            this.page_proctect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_proctect.Location = new System.Drawing.Point(0, 0);
            this.page_proctect.Name = "page_proctect";
            this.page_proctect.Size = new System.Drawing.Size(719, 439);
            this.page_proctect.TabIndex = 1;
            this.page_proctect.TabItemImage = ((System.Drawing.Image)(resources.GetObject("page_proctect.TabItemImage")));
            this.page_proctect.Text = "桌面屏保";
            this.page_proctect.ToolTipText = "桌面屏保";
            // 
            // btn_loop
            // 
            this.btn_loop.BackColor = System.Drawing.Color.Transparent;
            this.btn_loop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_loop.BackgroundImage")));
            this.btn_loop.BaseColor = System.Drawing.Color.Transparent;
            this.btn_loop.BorderColor = System.Drawing.Color.Transparent;
            this.btn_loop.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_loop.DownBack = ((System.Drawing.Image)(resources.GetObject("btn_loop.DownBack")));
            this.btn_loop.DownBaseColor = System.Drawing.Color.Transparent;
            this.btn_loop.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btn_loop.FadeGlow = false;
            this.btn_loop.Font = new System.Drawing.Font("微软雅黑 Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_loop.ForeColor = System.Drawing.Color.Transparent;
            this.btn_loop.GlowColor = System.Drawing.Color.Transparent;
            this.btn_loop.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btn_loop.Location = new System.Drawing.Point(409, 10);
            this.btn_loop.MouseBack = ((System.Drawing.Image)(resources.GetObject("btn_loop.MouseBack")));
            this.btn_loop.MouseBaseColor = System.Drawing.Color.Transparent;
            this.btn_loop.Name = "btn_loop";
            this.btn_loop.NormlBack = ((System.Drawing.Image)(resources.GetObject("btn_loop.NormlBack")));
            this.btn_loop.Size = new System.Drawing.Size(112, 42);
            this.btn_loop.TabIndex = 42;
            this.btn_loop.Text = "循环";
            this.btn_loop.UseVisualStyleBackColor = true;
            // 
            // btn_begin
            // 
            this.btn_begin.BackColor = System.Drawing.Color.Transparent;
            this.btn_begin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_begin.BackgroundImage")));
            this.btn_begin.BaseColor = System.Drawing.Color.Transparent;
            this.btn_begin.BorderColor = System.Drawing.Color.Transparent;
            this.btn_begin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_begin.DownBack = ((System.Drawing.Image)(resources.GetObject("btn_begin.DownBack")));
            this.btn_begin.DownBaseColor = System.Drawing.Color.Transparent;
            this.btn_begin.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btn_begin.FadeGlow = false;
            this.btn_begin.Font = new System.Drawing.Font("微软雅黑 Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_begin.ForeColor = System.Drawing.Color.Transparent;
            this.btn_begin.GlowColor = System.Drawing.Color.Transparent;
            this.btn_begin.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btn_begin.Location = new System.Drawing.Point(169, 10);
            this.btn_begin.MouseBack = ((System.Drawing.Image)(resources.GetObject("btn_begin.MouseBack")));
            this.btn_begin.MouseBaseColor = System.Drawing.Color.Transparent;
            this.btn_begin.Name = "btn_begin";
            this.btn_begin.NormlBack = ((System.Drawing.Image)(resources.GetObject("btn_begin.NormlBack")));
            this.btn_begin.Size = new System.Drawing.Size(112, 42);
            this.btn_begin.TabIndex = 41;
            this.btn_begin.Text = "预览";
            this.btn_begin.UseVisualStyleBackColor = true;
            this.btn_begin.Click += new System.EventHandler(this.btn_begin_Click_1);
            // 
            // skinRadioButton5
            // 
            this.skinRadioButton5.AutoSize = true;
            this.skinRadioButton5.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButton5.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButton5.DefaultRadioButtonWidth = 11;
            this.skinRadioButton5.DownBack = null;
            this.skinRadioButton5.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButton5.ForeColor = System.Drawing.Color.Gainsboro;
            this.skinRadioButton5.IsEnabledDraw = false;
            this.skinRadioButton5.LightEffect = false;
            this.skinRadioButton5.LightEffectWidth = 0;
            this.skinRadioButton5.Location = new System.Drawing.Point(77, 84);
            this.skinRadioButton5.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinRadioButton5.MouseBack")));
            this.skinRadioButton5.Name = "skinRadioButton5";
            this.skinRadioButton5.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinRadioButton5.NormlBack")));
            this.skinRadioButton5.SelectedDownBack = null;
            this.skinRadioButton5.SelectedMouseBack = ((System.Drawing.Image)(resources.GetObject("skinRadioButton5.SelectedMouseBack")));
            this.skinRadioButton5.SelectedNormlBack = ((System.Drawing.Image)(resources.GetObject("skinRadioButton5.SelectedNormlBack")));
            this.skinRadioButton5.Size = new System.Drawing.Size(74, 21);
            this.skinRadioButton5.TabIndex = 40;
            this.skinRadioButton5.Text = "浩瀚宇宙";
            this.skinRadioButton5.UseVisualStyleBackColor = false;
            // 
            // skinRadioButton10
            // 
            this.skinRadioButton10.AutoSize = true;
            this.skinRadioButton10.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinRadioButton10.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.skinRadioButton10.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButton10.DefaultRadioButtonWidth = 11;
            this.skinRadioButton10.DownBack = null;
            this.skinRadioButton10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.skinRadioButton10.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButton10.ForeColor = System.Drawing.Color.Gainsboro;
            this.skinRadioButton10.LightEffect = false;
            this.skinRadioButton10.LightEffectWidth = 0;
            this.skinRadioButton10.Location = new System.Drawing.Point(328, 57);
            this.skinRadioButton10.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinRadioButton10.MouseBack")));
            this.skinRadioButton10.Name = "skinRadioButton10";
            this.skinRadioButton10.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinRadioButton10.NormlBack")));
            this.skinRadioButton10.SelectedDownBack = null;
            this.skinRadioButton10.SelectedMouseBack = ((System.Drawing.Image)(resources.GetObject("skinRadioButton10.SelectedMouseBack")));
            this.skinRadioButton10.SelectedNormlBack = ((System.Drawing.Image)(resources.GetObject("skinRadioButton10.SelectedNormlBack")));
            this.skinRadioButton10.Size = new System.Drawing.Size(73, 21);
            this.skinRadioButton10.TabIndex = 39;
            this.skinRadioButton10.Text = "黑客帝国";
            this.skinRadioButton10.UseVisualStyleBackColor = true;
            this.skinRadioButton10.CheckedChanged += new System.EventHandler(this.skinRadioButton10_CheckedChanged_1);
            // 
            // skinRadioButton8
            // 
            this.skinRadioButton8.AutoSize = true;
            this.skinRadioButton8.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButton8.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButton8.DefaultRadioButtonWidth = 11;
            this.skinRadioButton8.DownBack = null;
            this.skinRadioButton8.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButton8.ForeColor = System.Drawing.Color.Gainsboro;
            this.skinRadioButton8.IsEnabledDraw = false;
            this.skinRadioButton8.LightEffect = false;
            this.skinRadioButton8.LightEffectWidth = 0;
            this.skinRadioButton8.Location = new System.Drawing.Point(557, 57);
            this.skinRadioButton8.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinRadioButton8.MouseBack")));
            this.skinRadioButton8.Name = "skinRadioButton8";
            this.skinRadioButton8.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinRadioButton8.NormlBack")));
            this.skinRadioButton8.SelectedDownBack = null;
            this.skinRadioButton8.SelectedMouseBack = ((System.Drawing.Image)(resources.GetObject("skinRadioButton8.SelectedMouseBack")));
            this.skinRadioButton8.SelectedNormlBack = ((System.Drawing.Image)(resources.GetObject("skinRadioButton8.SelectedNormlBack")));
            this.skinRadioButton8.Size = new System.Drawing.Size(66, 21);
            this.skinRadioButton8.TabIndex = 37;
            this.skinRadioButton8.Text = "3D花瓣";
            this.skinRadioButton8.UseVisualStyleBackColor = false;
            this.skinRadioButton8.CheckedChanged += new System.EventHandler(this.skinRadioButton8_CheckedChanged);
            // 
            // skinRadioButton6
            // 
            this.skinRadioButton6.AutoSize = true;
            this.skinRadioButton6.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButton6.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButton6.DefaultRadioButtonWidth = 11;
            this.skinRadioButton6.DownBack = null;
            this.skinRadioButton6.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButton6.ForeColor = System.Drawing.Color.Gainsboro;
            this.skinRadioButton6.IsEnabledDraw = false;
            this.skinRadioButton6.LightEffect = false;
            this.skinRadioButton6.LightEffectWidth = 0;
            this.skinRadioButton6.Location = new System.Drawing.Point(556, 84);
            this.skinRadioButton6.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinRadioButton6.MouseBack")));
            this.skinRadioButton6.Name = "skinRadioButton6";
            this.skinRadioButton6.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinRadioButton6.NormlBack")));
            this.skinRadioButton6.SelectedDownBack = null;
            this.skinRadioButton6.SelectedMouseBack = ((System.Drawing.Image)(resources.GetObject("skinRadioButton6.SelectedMouseBack")));
            this.skinRadioButton6.SelectedNormlBack = ((System.Drawing.Image)(resources.GetObject("skinRadioButton6.SelectedNormlBack")));
            this.skinRadioButton6.Size = new System.Drawing.Size(74, 21);
            this.skinRadioButton6.TabIndex = 38;
            this.skinRadioButton6.Text = "弹幕动画";
            this.skinRadioButton6.UseVisualStyleBackColor = false;
            // 
            // skinRadioButton13
            // 
            this.skinRadioButton13.AutoSize = true;
            this.skinRadioButton13.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButton13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinRadioButton13.ControlState = CCWin.SkinClass.ControlState.Focused;
            this.skinRadioButton13.DefaultRadioButtonWidth = 11;
            this.skinRadioButton13.DownBack = null;
            this.skinRadioButton13.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButton13.ForeColor = System.Drawing.Color.Gainsboro;
            this.skinRadioButton13.IsEnabledDraw = false;
            this.skinRadioButton13.LightEffect = false;
            this.skinRadioButton13.LightEffectWidth = 0;
            this.skinRadioButton13.Location = new System.Drawing.Point(328, 84);
            this.skinRadioButton13.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinRadioButton13.MouseBack")));
            this.skinRadioButton13.Name = "skinRadioButton13";
            this.skinRadioButton13.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinRadioButton13.NormlBack")));
            this.skinRadioButton13.SelectedDownBack = null;
            this.skinRadioButton13.SelectedMouseBack = ((System.Drawing.Image)(resources.GetObject("skinRadioButton13.SelectedMouseBack")));
            this.skinRadioButton13.SelectedNormlBack = ((System.Drawing.Image)(resources.GetObject("skinRadioButton13.SelectedNormlBack")));
            this.skinRadioButton13.Size = new System.Drawing.Size(66, 21);
            this.skinRadioButton13.TabIndex = 35;
            this.skinRadioButton13.Text = "酷炫3D";
            this.skinRadioButton13.UseVisualStyleBackColor = false;
            // 
            // skinRadioButton2
            // 
            this.skinRadioButton2.AutoSize = true;
            this.skinRadioButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButton2.DefaultRadioButtonWidth = 11;
            this.skinRadioButton2.DownBack = null;
            this.skinRadioButton2.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButton2.ForeColor = System.Drawing.Color.Gainsboro;
            this.skinRadioButton2.IsEnabledDraw = false;
            this.skinRadioButton2.LightEffect = false;
            this.skinRadioButton2.LightEffectWidth = 0;
            this.skinRadioButton2.Location = new System.Drawing.Point(77, 57);
            this.skinRadioButton2.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinRadioButton2.MouseBack")));
            this.skinRadioButton2.Name = "skinRadioButton2";
            this.skinRadioButton2.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinRadioButton2.NormlBack")));
            this.skinRadioButton2.SelectedDownBack = null;
            this.skinRadioButton2.SelectedMouseBack = ((System.Drawing.Image)(resources.GetObject("skinRadioButton2.SelectedMouseBack")));
            this.skinRadioButton2.SelectedNormlBack = ((System.Drawing.Image)(resources.GetObject("skinRadioButton2.SelectedNormlBack")));
            this.skinRadioButton2.Size = new System.Drawing.Size(74, 21);
            this.skinRadioButton2.TabIndex = 36;
            this.skinRadioButton2.Text = "模拟星空";
            this.skinRadioButton2.UseVisualStyleBackColor = false;
            this.skinRadioButton2.CheckedChanged += new System.EventHandler(this.skinRadioButton2_CheckedChanged);
            // 
            // panel_web
            // 
            this.panel_web.Controls.Add(this.web);
            this.panel_web.Location = new System.Drawing.Point(3, 121);
            this.panel_web.Name = "panel_web";
            this.panel_web.Size = new System.Drawing.Size(709, 315);
            this.panel_web.TabIndex = 34;
            // 
            // web
            // 
            this.web.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web.IsWebBrowserContextMenuEnabled = false;
            this.web.Location = new System.Drawing.Point(0, 0);
            this.web.MinimumSize = new System.Drawing.Size(20, 20);
            this.web.Name = "web";
            this.web.ScrollBarsEnabled = false;
            this.web.Size = new System.Drawing.Size(709, 315);
            this.web.TabIndex = 0;
            this.web.WebBrowserShortcutsEnabled = false;
            this.web.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.web_PreviewKeyDown);
            // 
            // page_games
            // 
            this.page_games.BackColor = System.Drawing.Color.Transparent;
            this.page_games.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_games.Location = new System.Drawing.Point(0, 0);
            this.page_games.Name = "page_games";
            this.page_games.Size = new System.Drawing.Size(719, 439);
            this.page_games.TabIndex = 3;
            this.page_games.TabItemImage = ((System.Drawing.Image)(resources.GetObject("page_games.TabItemImage")));
            this.page_games.Text = "桌面小游戏";
            this.page_games.ToolTipText = "桌面小游戏";
            // 
            // page_js
            // 
            this.page_js.BackColor = System.Drawing.Color.Transparent;
            this.page_js.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_js.Location = new System.Drawing.Point(0, 0);
            this.page_js.Name = "page_js";
            this.page_js.Size = new System.Drawing.Size(719, 439);
            this.page_js.TabIndex = 2;
            this.page_js.TabItemImage = ((System.Drawing.Image)(resources.GetObject("page_js.TabItemImage")));
            this.page_js.Text = "桌面特效";
            this.page_js.ToolTipText = "桌面特效";
            // 
            // tab_file
            // 
            this.tab_file.BackColor = System.Drawing.Color.Transparent;
            this.tab_file.Controls.Add(this.skinButton6);
            this.tab_file.Controls.Add(this.skinButton5);
            this.tab_file.Controls.Add(this.skinButton4);
            this.tab_file.Controls.Add(this.skinButton1);
            this.tab_file.Controls.Add(this.panel_webFile);
            this.tab_file.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_file.Location = new System.Drawing.Point(0, 0);
            this.tab_file.Name = "tab_file";
            this.tab_file.Size = new System.Drawing.Size(719, 439);
            this.tab_file.TabIndex = 6;
            this.tab_file.TabItemImage = ((System.Drawing.Image)(resources.GetObject("tab_file.TabItemImage")));
            this.tab_file.Text = "桌面文件整理";
            // 
            // skinButton6
            // 
            this.skinButton6.BackColor = System.Drawing.Color.Transparent;
            this.skinButton6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinButton6.BackgroundImage")));
            this.skinButton6.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton6.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton6.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton6.DownBack = ((System.Drawing.Image)(resources.GetObject("skinButton6.DownBack")));
            this.skinButton6.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton6.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton6.FadeGlow = false;
            this.skinButton6.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton6.ForeColor = System.Drawing.Color.Transparent;
            this.skinButton6.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton6.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton6.Location = new System.Drawing.Point(410, 18);
            this.skinButton6.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinButton6.MouseBack")));
            this.skinButton6.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton6.Name = "skinButton6";
            this.skinButton6.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinButton6.NormlBack")));
            this.skinButton6.Size = new System.Drawing.Size(101, 35);
            this.skinButton6.TabIndex = 37;
            this.skinButton6.Text = "一键还原";
            this.skinButton6.UseVisualStyleBackColor = true;
            // 
            // skinButton5
            // 
            this.skinButton5.BackColor = System.Drawing.Color.Transparent;
            this.skinButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinButton5.BackgroundImage")));
            this.skinButton5.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton5.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton5.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton5.DownBack = ((System.Drawing.Image)(resources.GetObject("skinButton5.DownBack")));
            this.skinButton5.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton5.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton5.FadeGlow = false;
            this.skinButton5.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton5.ForeColor = System.Drawing.Color.Transparent;
            this.skinButton5.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton5.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton5.Location = new System.Drawing.Point(552, 18);
            this.skinButton5.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinButton5.MouseBack")));
            this.skinButton5.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton5.Name = "skinButton5";
            this.skinButton5.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinButton5.NormlBack")));
            this.skinButton5.Size = new System.Drawing.Size(88, 35);
            this.skinButton5.TabIndex = 36;
            this.skinButton5.Text = "上一页";
            this.skinButton5.UseVisualStyleBackColor = true;
            // 
            // skinButton4
            // 
            this.skinButton4.BackColor = System.Drawing.Color.Transparent;
            this.skinButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinButton4.BackgroundImage")));
            this.skinButton4.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton4.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton4.DownBack = ((System.Drawing.Image)(resources.GetObject("skinButton4.DownBack")));
            this.skinButton4.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton4.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton4.FadeGlow = false;
            this.skinButton4.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton4.ForeColor = System.Drawing.Color.Transparent;
            this.skinButton4.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton4.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton4.Location = new System.Drawing.Point(225, 18);
            this.skinButton4.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinButton4.MouseBack")));
            this.skinButton4.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton4.Name = "skinButton4";
            this.skinButton4.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinButton4.NormlBack")));
            this.skinButton4.Size = new System.Drawing.Size(144, 35);
            this.skinButton4.TabIndex = 35;
            this.skinButton4.Text = "一键桌面整理";
            this.skinButton4.UseVisualStyleBackColor = true;
            this.skinButton4.Click += new System.EventHandler(this.skinButton4_Click_1);
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinButton1.BackgroundImage")));
            this.skinButton1.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton1.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = ((System.Drawing.Image)(resources.GetObject("skinButton1.DownBack")));
            this.skinButton1.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton1.FadeGlow = false;
            this.skinButton1.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton1.ForeColor = System.Drawing.Color.Transparent;
            this.skinButton1.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton1.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton1.Location = new System.Drawing.Point(68, 18);
            this.skinButton1.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinButton1.MouseBack")));
            this.skinButton1.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinButton1.NormlBack")));
            this.skinButton1.Size = new System.Drawing.Size(116, 35);
            this.skinButton1.TabIndex = 34;
            this.skinButton1.Text = "加载桌面";
            this.skinButton1.UseVisualStyleBackColor = true;
            // 
            // panel_webFile
            // 
            this.panel_webFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_webFile.Location = new System.Drawing.Point(0, 72);
            this.panel_webFile.Name = "panel_webFile";
            this.panel_webFile.Size = new System.Drawing.Size(715, 364);
            this.panel_webFile.TabIndex = 0;
            // 
            // page_setting
            // 
            this.page_setting.BackColor = System.Drawing.Color.Transparent;
            this.page_setting.Controls.Add(this.skinButton2);
            this.page_setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page_setting.Location = new System.Drawing.Point(0, 0);
            this.page_setting.Name = "page_setting";
            this.page_setting.Size = new System.Drawing.Size(719, 439);
            this.page_setting.TabIndex = 4;
            this.page_setting.TabItemImage = ((System.Drawing.Image)(resources.GetObject("page_setting.TabItemImage")));
            this.page_setting.Text = "设置";
            this.page_setting.ToolTipText = "设置";
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinButton2.BackgroundImage")));
            this.skinButton2.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton2.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = ((System.Drawing.Image)(resources.GetObject("skinButton2.DownBack")));
            this.skinButton2.DownBaseColor = System.Drawing.Color.Transparent;
            this.skinButton2.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton2.FadeGlow = false;
            this.skinButton2.Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton2.ForeColor = System.Drawing.Color.Transparent;
            this.skinButton2.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton2.InnerBorderColor = System.Drawing.Color.Transparent;
            this.skinButton2.Location = new System.Drawing.Point(584, 357);
            this.skinButton2.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinButton2.MouseBack")));
            this.skinButton2.MouseBaseColor = System.Drawing.Color.Transparent;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinButton2.NormlBack")));
            this.skinButton2.Size = new System.Drawing.Size(72, 34);
            this.skinButton2.TabIndex = 33;
            this.skinButton2.Text = "保存";
            this.skinButton2.UseVisualStyleBackColor = true;
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 5000;
            this.ToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ToolTip.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ToolTip.Border = System.Drawing.Color.Black;
            this.ToolTip.InitialDelay = 500;
            this.ToolTip.OwnerDraw = true;
            this.ToolTip.ReshowDelay = 800;
            this.ToolTip.TipFore = System.Drawing.Color.Black;
            this.ToolTip.TitleFore = System.Drawing.Color.Navy;
            // 
            // btn_ChangClocl
            // 
            this.btn_ChangClocl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_ChangClocl.BackColor = System.Drawing.Color.Transparent;
            this.btn_ChangClocl.BaseColor = System.Drawing.Color.Transparent;
            this.btn_ChangClocl.BorderColor = System.Drawing.Color.Transparent;
            this.btn_ChangClocl.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_ChangClocl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChangClocl.DownBack = ((System.Drawing.Image)(resources.GetObject("btn_ChangClocl.DownBack")));
            this.btn_ChangClocl.DownBaseColor = System.Drawing.Color.Transparent;
            this.btn_ChangClocl.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btn_ChangClocl.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ChangClocl.ForeColor = System.Drawing.Color.White;
            this.btn_ChangClocl.GlowColor = System.Drawing.Color.Transparent;
            this.btn_ChangClocl.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btn_ChangClocl.Location = new System.Drawing.Point(623, 62);
            this.btn_ChangClocl.MouseBack = ((System.Drawing.Image)(resources.GetObject("btn_ChangClocl.MouseBack")));
            this.btn_ChangClocl.MouseBaseColor = System.Drawing.Color.Transparent;
            this.btn_ChangClocl.Name = "btn_ChangClocl";
            this.btn_ChangClocl.NormlBack = ((System.Drawing.Image)(resources.GetObject("btn_ChangClocl.NormlBack")));
            this.btn_ChangClocl.Size = new System.Drawing.Size(68, 55);
            this.btn_ChangClocl.TabIndex = 5;
            this.ToolTip.SetToolTip(this.btn_ChangClocl, "切换到时钟模式");
            this.btn_ChangClocl.UseVisualStyleBackColor = false;
            this.btn_ChangClocl.Click += new System.EventHandler(this.skinButton4_Click);
            // 
            // timer_hide
            // 
            this.timer_hide.Interval = 1;
            this.timer_hide.Tick += new System.EventHandler(this.timer_hide_Tick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackPalace = ((System.Drawing.Image)(resources.GetObject("$this.BackPalace")));
            this.BackShade = false;
            this.BackToColor = false;
            this.BorderColor = System.Drawing.Color.Transparent;
            this.CanResize = false;
            this.CaptionHeight = 4;
            this.ClientSize = new System.Drawing.Size(714, 535);
            this.ControlBox = false;
            this.Controls.Add(this.btn_ChangClocl);
            this.Controls.Add(this.panel_tabcontrol);
            this.Controls.Add(this.pan_SysBtn);
            this.DropBack = false;
            this.EffectBack = System.Drawing.Color.Transparent;
            this.EffectCaption = CCWin.TitleType.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.InnerBorderColor = System.Drawing.Color.Transparent;
            this.MdiBackColor = System.Drawing.Color.Transparent;
            this.Mobile = CCWin.MobileStyle.None;
            this.Name = "Form_Main";
            this.Radius = 10;
            this.ShadowWidth = 10;
            this.ShowDrawIcon = false;
            this.Text = "";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pan_SysBtn.ResumeLayout(false);
            this.menu_setting.ResumeLayout(false);
            this.panel_tabcontrol.ResumeLayout(false);
            this.tab_tool.ResumeLayout(false);
            this.page_background.ResumeLayout(false);
            this.page_proctect.ResumeLayout(false);
            this.page_proctect.PerformLayout();
            this.panel_web.ResumeLayout(false);
            this.tab_file.ResumeLayout(false);
            this.page_setting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel pan_SysBtn;
        private CCWin.SkinControl.SkinButton btn_gofoward;
        private CCWin.SkinControl.SkinButton btn_goback;
        private CCWin.SkinControl.SkinButton btn_mainpage;
        private CCWin.SkinControl.SkinButton btn_skin;
        private CCWin.SkinControl.SkinButton btn_setting;
        private CCWin.SkinControl.SkinButton btn_min;
        private CCWin.SkinControl.SkinButton btn_Close;
        private CCWin.SkinControl.SkinButton btn_menu;
        private CCWin.SkinControl.SkinContextMenuStrip menu_setting;
        private System.Windows.Forms.ToolStripMenuItem 主页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置中心ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 软件源码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 反馈建议ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小组ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 桌面时钟ToolStripMenuItem;
        private CCWin.SkinControl.SkinPanel panel_tabcontrol;
        private CCWin.SkinControl.SkinTabControl tab_tool;
        private CCWin.SkinControl.SkinTabPage page_main;
        private CCWin.SkinControl.SkinTabPage page_background;
        private CCWin.SkinControl.SkinTabPage page_setting;
        private CCWin.SkinControl.SkinTabPage page_proctect;
        private CCWin.SkinControl.SkinTabPage page_js;
        private CCWin.SkinControl.SkinTabPage page_games;
        private CCWin.SkinControl.SkinButton skinButton2;
        private System.Windows.Forms.Panel panel_web;
        private System.Windows.Forms.WebBrowser web;
        private new CCWin.SkinToolTip ToolTip;
        private CCWin.SkinControl.SkinTreeView tvList;
        private CCWin.SkinControl.GifBox gifLoading;
        private CCWin.SkinControl.SkinListView lvList;
        private CCWin.SkinControl.SkinButton skinButton3;
        private CCWin.SkinControl.SkinTextBox skinTextBox1;
        private CCWin.SkinControl.SkinButton btn_loop;
        private CCWin.SkinControl.SkinButton btn_begin;
        private CCWin.SkinControl.SkinRadioButton skinRadioButton5;
        private CCWin.SkinControl.SkinRadioButton skinRadioButton10;
        private CCWin.SkinControl.SkinRadioButton skinRadioButton8;
        private CCWin.SkinControl.SkinRadioButton skinRadioButton6;
        private CCWin.SkinControl.SkinRadioButton skinRadioButton13;
        private CCWin.SkinControl.SkinRadioButton skinRadioButton2;
        private CCWin.SkinControl.SkinButton btn_ChangClocl;
        private System.Windows.Forms.Timer timer_hide;
        private CCWin.SkinControl.SkinTabPage tab_file;
        private CCWin.SkinControl.SkinButton skinButton5;
        private CCWin.SkinControl.SkinButton skinButton4;
        private CCWin.SkinControl.SkinButton skinButton1;
        private System.Windows.Forms.Panel panel_webFile;
        private CCWin.SkinControl.SkinButton skinButton6;
    }
}

