using System;
using System.Web;
using System.Windows.Forms;

namespace NicePanel_Browser
{

    public class Form1 : System.Windows.Forms.Form
	{
        public Form1()
        {

            //This call is required by the Windows Form Designer.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
            chromiumWebBrowser1.AddressChanged += ChromiumWebBrowser1_AddressChanged;
            chromiumWebBrowser1.StatusMessage += ChromiumWebBrowser1_StatusMessage;
            chromiumWebBrowser1.Load("https://duckduckgo.com");
        }

        #region " Windows Form Designer generated code "

        //Form overrides dispose to clean up the component list.
        protected override void Dispose (bool disposing)
		{
			if (disposing)
			{
				if (!(components == null))
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		internal System.Windows.Forms.Panel Panel1;
		internal PureComponents.NicePanel.NicePanel NicePanel1;
		internal PureComponents.NicePanel.NicePanel NicePanel2;
		internal PureComponents.NicePanel.NicePanel NicePanel3;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.LinkLabel LinkLabel1;
		internal System.Windows.Forms.LinkLabel LinkLabel2;
		internal System.Windows.Forms.LinkLabel LinkLabel3;
		internal System.Windows.Forms.LinkLabel LinkLabel4;
		internal System.Windows.Forms.LinkLabel LinkLabel5;
		internal System.Windows.Forms.ContextMenu ContextMenuFavorites;
		internal System.Windows.Forms.MenuItem MenuItem1;
		internal System.Windows.Forms.MenuItem MenuItem2;
		internal System.Windows.Forms.MenuItem MenuItem3;
		internal System.Windows.Forms.Splitter Splitter1;
		internal System.Windows.Forms.Splitter Splitter2;
		internal System.Windows.Forms.Splitter Splitter3;
		internal PureComponents.NicePanel.NicePanel NicePanel4;
		internal System.Windows.Forms.Button Search;
		internal System.Windows.Forms.TextBox Keywords;
		internal System.Windows.Forms.RadioButton rbtVideos;
		internal System.Windows.Forms.RadioButton rbtImages;
		internal System.Windows.Forms.RadioButton rbtWeb;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox Address;
		internal System.Windows.Forms.Button Go;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        internal RadioButton rbtShopping;
        internal RadioButton rbtMaps;
        internal RadioButton rbtNews;
        internal System.Windows.Forms.Label Label4;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent ()
		{
            PureComponents.NicePanel.ContainerImage containerImage1 = new PureComponents.NicePanel.ContainerImage();
            PureComponents.NicePanel.HeaderImage headerImage1 = new PureComponents.NicePanel.HeaderImage();
            PureComponents.NicePanel.HeaderImage headerImage2 = new PureComponents.NicePanel.HeaderImage();
            PureComponents.NicePanel.PanelStyle panelStyle1 = new PureComponents.NicePanel.PanelStyle();
            PureComponents.NicePanel.ContainerStyle containerStyle1 = new PureComponents.NicePanel.ContainerStyle();
            PureComponents.NicePanel.PanelHeaderStyle panelHeaderStyle1 = new PureComponents.NicePanel.PanelHeaderStyle();
            PureComponents.NicePanel.PanelHeaderStyle panelHeaderStyle2 = new PureComponents.NicePanel.PanelHeaderStyle();
            PureComponents.NicePanel.ContainerImage containerImage2 = new PureComponents.NicePanel.ContainerImage();
            PureComponents.NicePanel.HeaderImage headerImage3 = new PureComponents.NicePanel.HeaderImage();
            PureComponents.NicePanel.HeaderImage headerImage4 = new PureComponents.NicePanel.HeaderImage();
            PureComponents.NicePanel.PanelStyle panelStyle2 = new PureComponents.NicePanel.PanelStyle();
            PureComponents.NicePanel.ContainerStyle containerStyle2 = new PureComponents.NicePanel.ContainerStyle();
            PureComponents.NicePanel.PanelHeaderStyle panelHeaderStyle3 = new PureComponents.NicePanel.PanelHeaderStyle();
            PureComponents.NicePanel.PanelHeaderStyle panelHeaderStyle4 = new PureComponents.NicePanel.PanelHeaderStyle();
            PureComponents.NicePanel.ContainerImage containerImage3 = new PureComponents.NicePanel.ContainerImage();
            PureComponents.NicePanel.HeaderImage headerImage5 = new PureComponents.NicePanel.HeaderImage();
            PureComponents.NicePanel.HeaderImage headerImage6 = new PureComponents.NicePanel.HeaderImage();
            PureComponents.NicePanel.PanelStyle panelStyle3 = new PureComponents.NicePanel.PanelStyle();
            PureComponents.NicePanel.ContainerStyle containerStyle3 = new PureComponents.NicePanel.ContainerStyle();
            PureComponents.NicePanel.PanelHeaderStyle panelHeaderStyle5 = new PureComponents.NicePanel.PanelHeaderStyle();
            PureComponents.NicePanel.PanelHeaderStyle panelHeaderStyle6 = new PureComponents.NicePanel.PanelHeaderStyle();
            PureComponents.NicePanel.ContainerImage containerImage4 = new PureComponents.NicePanel.ContainerImage();
            PureComponents.NicePanel.HeaderImage headerImage7 = new PureComponents.NicePanel.HeaderImage();
            PureComponents.NicePanel.HeaderImage headerImage8 = new PureComponents.NicePanel.HeaderImage();
            PureComponents.NicePanel.PanelStyle panelStyle4 = new PureComponents.NicePanel.PanelStyle();
            PureComponents.NicePanel.ContainerStyle containerStyle4 = new PureComponents.NicePanel.ContainerStyle();
            PureComponents.NicePanel.PanelHeaderStyle panelHeaderStyle7 = new PureComponents.NicePanel.PanelHeaderStyle();
            PureComponents.NicePanel.PanelHeaderStyle panelHeaderStyle8 = new PureComponents.NicePanel.PanelHeaderStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.NicePanel3 = new PureComponents.NicePanel.NicePanel();
            this.Label4 = new System.Windows.Forms.Label();
            this.Splitter3 = new System.Windows.Forms.Splitter();
            this.NicePanel2 = new PureComponents.NicePanel.NicePanel();
            this.rbtShopping = new System.Windows.Forms.RadioButton();
            this.rbtMaps = new System.Windows.Forms.RadioButton();
            this.rbtNews = new System.Windows.Forms.RadioButton();
            this.Search = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Keywords = new System.Windows.Forms.TextBox();
            this.rbtVideos = new System.Windows.Forms.RadioButton();
            this.rbtImages = new System.Windows.Forms.RadioButton();
            this.rbtWeb = new System.Windows.Forms.RadioButton();
            this.Label1 = new System.Windows.Forms.Label();
            this.Splitter2 = new System.Windows.Forms.Splitter();
            this.NicePanel1 = new PureComponents.NicePanel.NicePanel();
            this.ContextMenuFavorites = new System.Windows.Forms.ContextMenu();
            this.MenuItem1 = new System.Windows.Forms.MenuItem();
            this.MenuItem2 = new System.Windows.Forms.MenuItem();
            this.MenuItem3 = new System.Windows.Forms.MenuItem();
            this.LinkLabel5 = new System.Windows.Forms.LinkLabel();
            this.LinkLabel4 = new System.Windows.Forms.LinkLabel();
            this.LinkLabel3 = new System.Windows.Forms.LinkLabel();
            this.LinkLabel2 = new System.Windows.Forms.LinkLabel();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Splitter1 = new System.Windows.Forms.Splitter();
            this.NicePanel4 = new PureComponents.NicePanel.NicePanel();
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.Go = new System.Windows.Forms.Button();
            this.Address = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.NicePanel3.SuspendLayout();
            this.NicePanel2.SuspendLayout();
            this.NicePanel1.SuspendLayout();
            this.NicePanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.NicePanel3);
            this.Panel1.Controls.Add(this.Splitter3);
            this.Panel1.Controls.Add(this.NicePanel2);
            this.Panel1.Controls.Add(this.Splitter2);
            this.Panel1.Controls.Add(this.NicePanel1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(6, 6);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(204, 441);
            this.Panel1.TabIndex = 0;
            // 
            // NicePanel3
            // 
            this.NicePanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            containerImage1.Alignment = System.Drawing.ContentAlignment.TopRight;
            containerImage1.ClipArt = PureComponents.NicePanel.ImageClipArt.Help;
            containerImage1.Image = null;
            containerImage1.Size = PureComponents.NicePanel.ContainerImageSize.Small;
            containerImage1.Transparency = 70;
            this.NicePanel3.ContainerImage = containerImage1;
            this.NicePanel3.ContextMenuButton = false;
            this.NicePanel3.Controls.Add(this.Label4);
            this.NicePanel3.Dock = System.Windows.Forms.DockStyle.Top;
            headerImage1.ClipArt = PureComponents.NicePanel.ImageClipArt.None;
            headerImage1.Image = null;
            this.NicePanel3.FooterImage = headerImage1;
            this.NicePanel3.FooterText = "";
            this.NicePanel3.FooterVisible = false;
            this.NicePanel3.ForeColor = System.Drawing.Color.Black;
            headerImage2.ClipArt = PureComponents.NicePanel.ImageClipArt.Help;
            headerImage2.Image = null;
            this.NicePanel3.HeaderImage = headerImage2;
            this.NicePanel3.HeaderText = "Help";
            this.NicePanel3.IsExpanded = true;
            this.NicePanel3.Location = new System.Drawing.Point(0, 291);
            this.NicePanel3.Name = "NicePanel3";
            this.NicePanel3.OriginalFooterVisible = false;
            this.NicePanel3.OriginalHeight = 150;
            this.NicePanel3.Resizable = false;
            this.NicePanel3.Size = new System.Drawing.Size(204, 113);
            containerStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            containerStyle1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            containerStyle1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(45)))), ((int)(((byte)(150)))));
            containerStyle1.BorderStyle = PureComponents.NicePanel.BorderStyle.Solid;
            containerStyle1.CaptionAlign = PureComponents.NicePanel.CaptionAlign.Left;
            containerStyle1.FadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            containerStyle1.FillStyle = PureComponents.NicePanel.FillStyle.DiagonalForward;
            containerStyle1.FlashItemBackColor = System.Drawing.Color.Red;
            containerStyle1.FocusItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            containerStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            containerStyle1.ForeColor = System.Drawing.Color.Black;
            containerStyle1.Shape = PureComponents.NicePanel.Shape.Rounded;
            panelStyle1.ContainerStyle = containerStyle1;
            panelHeaderStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(42)))), ((int)(((byte)(127)))));
            panelHeaderStyle1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            panelHeaderStyle1.FadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(215)))));
            panelHeaderStyle1.FillStyle = PureComponents.NicePanel.FillStyle.HorizontalFading;
            panelHeaderStyle1.FlashBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(122)))), ((int)(((byte)(1)))));
            panelHeaderStyle1.FlashFadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(159)))));
            panelHeaderStyle1.FlashForeColor = System.Drawing.Color.White;
            panelHeaderStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            panelHeaderStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(198)))), ((int)(((byte)(237)))));
            panelHeaderStyle1.Size = PureComponents.NicePanel.PanelHeaderSize.Small;
            panelStyle1.FooterStyle = panelHeaderStyle1;
            panelHeaderStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(215)))));
            panelHeaderStyle2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            panelHeaderStyle2.FadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(42)))), ((int)(((byte)(127)))));
            panelHeaderStyle2.FillStyle = PureComponents.NicePanel.FillStyle.VerticalFading;
            panelHeaderStyle2.FlashBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(122)))), ((int)(((byte)(1)))));
            panelHeaderStyle2.FlashFadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(159)))));
            panelHeaderStyle2.FlashForeColor = System.Drawing.Color.White;
            panelHeaderStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            panelHeaderStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            panelHeaderStyle2.Size = PureComponents.NicePanel.PanelHeaderSize.Small;
            panelStyle1.HeaderStyle = panelHeaderStyle2;
            this.NicePanel3.Style = panelStyle1;
            this.NicePanel3.TabIndex = 2;
            this.NicePanel3.Text = "NicePanel3";
            // 
            // Label4
            // 
            this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Location = new System.Drawing.Point(8, 24);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(188, 80);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "This sample has been created using the PureComponents NicePanel. Using the mouse " +
    "you can collapse and expand panels on the left, it is possible to change their h" +
    "eight and width too.";
            // 
            // Splitter3
            // 
            this.Splitter3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Splitter3.Location = new System.Drawing.Point(0, 285);
            this.Splitter3.Name = "Splitter3";
            this.Splitter3.Size = new System.Drawing.Size(204, 6);
            this.Splitter3.TabIndex = 4;
            this.Splitter3.TabStop = false;
            // 
            // NicePanel2
            // 
            this.NicePanel2.BackColor = System.Drawing.Color.CornflowerBlue;
            containerImage2.Alignment = System.Drawing.ContentAlignment.TopRight;
            containerImage2.ClipArt = PureComponents.NicePanel.ImageClipArt.Search;
            containerImage2.Image = null;
            containerImage2.Size = PureComponents.NicePanel.ContainerImageSize.Small;
            containerImage2.Transparency = 50;
            this.NicePanel2.ContainerImage = containerImage2;
            this.NicePanel2.ContextMenuButton = false;
            this.NicePanel2.Controls.Add(this.rbtShopping);
            this.NicePanel2.Controls.Add(this.rbtMaps);
            this.NicePanel2.Controls.Add(this.rbtNews);
            this.NicePanel2.Controls.Add(this.Search);
            this.NicePanel2.Controls.Add(this.Label2);
            this.NicePanel2.Controls.Add(this.Keywords);
            this.NicePanel2.Controls.Add(this.rbtVideos);
            this.NicePanel2.Controls.Add(this.rbtImages);
            this.NicePanel2.Controls.Add(this.rbtWeb);
            this.NicePanel2.Controls.Add(this.Label1);
            this.NicePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            headerImage3.ClipArt = PureComponents.NicePanel.ImageClipArt.None;
            headerImage3.Image = null;
            this.NicePanel2.FooterImage = headerImage3;
            this.NicePanel2.FooterText = "";
            this.NicePanel2.FooterVisible = false;
            this.NicePanel2.ForeColor = System.Drawing.Color.Black;
            headerImage4.ClipArt = PureComponents.NicePanel.ImageClipArt.Search;
            headerImage4.Image = null;
            this.NicePanel2.HeaderImage = headerImage4;
            this.NicePanel2.HeaderText = "Search";
            this.NicePanel2.IsExpanded = true;
            this.NicePanel2.Location = new System.Drawing.Point(0, 121);
            this.NicePanel2.Name = "NicePanel2";
            this.NicePanel2.OriginalFooterVisible = false;
            this.NicePanel2.OriginalHeight = 150;
            this.NicePanel2.Resizable = false;
            this.NicePanel2.Size = new System.Drawing.Size(204, 164);
            containerStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            containerStyle2.BaseColor = System.Drawing.Color.CornflowerBlue;
            containerStyle2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(45)))), ((int)(((byte)(150)))));
            containerStyle2.BorderStyle = PureComponents.NicePanel.BorderStyle.Solid;
            containerStyle2.CaptionAlign = PureComponents.NicePanel.CaptionAlign.Left;
            containerStyle2.FadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            containerStyle2.FillStyle = PureComponents.NicePanel.FillStyle.DiagonalForward;
            containerStyle2.FlashItemBackColor = System.Drawing.Color.Red;
            containerStyle2.FocusItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            containerStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            containerStyle2.ForeColor = System.Drawing.Color.Black;
            containerStyle2.Shape = PureComponents.NicePanel.Shape.Rounded;
            panelStyle2.ContainerStyle = containerStyle2;
            panelHeaderStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(42)))), ((int)(((byte)(127)))));
            panelHeaderStyle3.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            panelHeaderStyle3.FadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(215)))));
            panelHeaderStyle3.FillStyle = PureComponents.NicePanel.FillStyle.HorizontalFading;
            panelHeaderStyle3.FlashBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(122)))), ((int)(((byte)(1)))));
            panelHeaderStyle3.FlashFadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(159)))));
            panelHeaderStyle3.FlashForeColor = System.Drawing.Color.White;
            panelHeaderStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            panelHeaderStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(198)))), ((int)(((byte)(237)))));
            panelHeaderStyle3.Size = PureComponents.NicePanel.PanelHeaderSize.Small;
            panelStyle2.FooterStyle = panelHeaderStyle3;
            panelHeaderStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(215)))));
            panelHeaderStyle4.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            panelHeaderStyle4.FadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(42)))), ((int)(((byte)(127)))));
            panelHeaderStyle4.FillStyle = PureComponents.NicePanel.FillStyle.VerticalFading;
            panelHeaderStyle4.FlashBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(122)))), ((int)(((byte)(1)))));
            panelHeaderStyle4.FlashFadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(159)))));
            panelHeaderStyle4.FlashForeColor = System.Drawing.Color.White;
            panelHeaderStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            panelHeaderStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            panelHeaderStyle4.Size = PureComponents.NicePanel.PanelHeaderSize.Small;
            panelStyle2.HeaderStyle = panelHeaderStyle4;
            this.NicePanel2.Style = panelStyle2;
            this.NicePanel2.TabIndex = 1;
            this.NicePanel2.Text = "NicePanel2";
            // 
            // rbtShopping
            // 
            this.rbtShopping.BackColor = System.Drawing.Color.Transparent;
            this.rbtShopping.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rbtShopping.Location = new System.Drawing.Point(72, 76);
            this.rbtShopping.Name = "rbtShopping";
            this.rbtShopping.Size = new System.Drawing.Size(72, 16);
            this.rbtShopping.TabIndex = 9;
            this.rbtShopping.Text = "Shopping";
            this.rbtShopping.UseVisualStyleBackColor = false;
            // 
            // rbtMaps
            // 
            this.rbtMaps.BackColor = System.Drawing.Color.Transparent;
            this.rbtMaps.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rbtMaps.Location = new System.Drawing.Point(72, 60);
            this.rbtMaps.Name = "rbtMaps";
            this.rbtMaps.Size = new System.Drawing.Size(72, 16);
            this.rbtMaps.TabIndex = 8;
            this.rbtMaps.Text = "Maps";
            this.rbtMaps.UseVisualStyleBackColor = false;
            // 
            // rbtNews
            // 
            this.rbtNews.BackColor = System.Drawing.Color.Transparent;
            this.rbtNews.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rbtNews.Location = new System.Drawing.Point(72, 44);
            this.rbtNews.Name = "rbtNews";
            this.rbtNews.Size = new System.Drawing.Size(72, 16);
            this.rbtNews.TabIndex = 7;
            this.rbtNews.Text = "News";
            this.rbtNews.UseVisualStyleBackColor = false;
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            this.Search.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Search.Location = new System.Drawing.Point(134, 136);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(60, 20);
            this.Search.TabIndex = 6;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Label2.Location = new System.Drawing.Point(8, 96);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(148, 13);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "With the following keyword(s):";
            // 
            // Keywords
            // 
            this.Keywords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Keywords.Location = new System.Drawing.Point(8, 112);
            this.Keywords.Name = "Keywords";
            this.Keywords.Size = new System.Drawing.Size(186, 20);
            this.Keywords.TabIndex = 4;
            this.Keywords.Text = "CefSharp";
            this.Keywords.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Keywords_KeyUp);
            // 
            // rbtVideos
            // 
            this.rbtVideos.BackColor = System.Drawing.Color.Transparent;
            this.rbtVideos.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rbtVideos.Location = new System.Drawing.Point(8, 76);
            this.rbtVideos.Name = "rbtVideos";
            this.rbtVideos.Size = new System.Drawing.Size(72, 16);
            this.rbtVideos.TabIndex = 3;
            this.rbtVideos.Text = "Videos";
            this.rbtVideos.UseVisualStyleBackColor = false;
            // 
            // rbtImages
            // 
            this.rbtImages.BackColor = System.Drawing.Color.Transparent;
            this.rbtImages.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rbtImages.Location = new System.Drawing.Point(8, 60);
            this.rbtImages.Name = "rbtImages";
            this.rbtImages.Size = new System.Drawing.Size(72, 16);
            this.rbtImages.TabIndex = 2;
            this.rbtImages.Text = "Images";
            this.rbtImages.UseVisualStyleBackColor = false;
            // 
            // rbtWeb
            // 
            this.rbtWeb.BackColor = System.Drawing.Color.Transparent;
            this.rbtWeb.Checked = true;
            this.rbtWeb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rbtWeb.Location = new System.Drawing.Point(8, 44);
            this.rbtWeb.Name = "rbtWeb";
            this.rbtWeb.Size = new System.Drawing.Size(72, 16);
            this.rbtWeb.TabIndex = 1;
            this.rbtWeb.TabStop = true;
            this.rbtWeb.Tag = "";
            this.rbtWeb.Text = "Web";
            this.rbtWeb.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Label1.Location = new System.Drawing.Point(4, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(59, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Search for:";
            // 
            // Splitter2
            // 
            this.Splitter2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Splitter2.Location = new System.Drawing.Point(0, 115);
            this.Splitter2.Name = "Splitter2";
            this.Splitter2.Size = new System.Drawing.Size(204, 6);
            this.Splitter2.TabIndex = 3;
            this.Splitter2.TabStop = false;
            // 
            // NicePanel1
            // 
            this.NicePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            containerImage3.Alignment = System.Drawing.ContentAlignment.TopRight;
            containerImage3.ClipArt = PureComponents.NicePanel.ImageClipArt.Star;
            containerImage3.Image = null;
            containerImage3.Size = PureComponents.NicePanel.ContainerImageSize.Small;
            containerImage3.Transparency = 50;
            this.NicePanel1.ContainerImage = containerImage3;
            this.NicePanel1.ContextMenu = this.ContextMenuFavorites;
            this.NicePanel1.Controls.Add(this.LinkLabel5);
            this.NicePanel1.Controls.Add(this.LinkLabel4);
            this.NicePanel1.Controls.Add(this.LinkLabel3);
            this.NicePanel1.Controls.Add(this.LinkLabel2);
            this.NicePanel1.Controls.Add(this.LinkLabel1);
            this.NicePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            headerImage5.ClipArt = PureComponents.NicePanel.ImageClipArt.None;
            headerImage5.Image = null;
            this.NicePanel1.FooterImage = headerImage5;
            this.NicePanel1.FooterText = "";
            this.NicePanel1.FooterVisible = false;
            this.NicePanel1.ForeColor = System.Drawing.Color.Black;
            headerImage6.ClipArt = PureComponents.NicePanel.ImageClipArt.Star;
            headerImage6.Image = null;
            this.NicePanel1.HeaderImage = headerImage6;
            this.NicePanel1.HeaderText = "Favorites";
            this.NicePanel1.IsExpanded = true;
            this.NicePanel1.Location = new System.Drawing.Point(0, 0);
            this.NicePanel1.Name = "NicePanel1";
            this.NicePanel1.OriginalFooterVisible = false;
            this.NicePanel1.OriginalHeight = 115;
            this.NicePanel1.Resizable = false;
            this.NicePanel1.Size = new System.Drawing.Size(204, 115);
            containerStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            containerStyle3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            containerStyle3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(45)))), ((int)(((byte)(150)))));
            containerStyle3.BorderStyle = PureComponents.NicePanel.BorderStyle.Solid;
            containerStyle3.CaptionAlign = PureComponents.NicePanel.CaptionAlign.Left;
            containerStyle3.FadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            containerStyle3.FillStyle = PureComponents.NicePanel.FillStyle.DiagonalForward;
            containerStyle3.FlashItemBackColor = System.Drawing.Color.Red;
            containerStyle3.FocusItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            containerStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            containerStyle3.ForeColor = System.Drawing.Color.Black;
            containerStyle3.Shape = PureComponents.NicePanel.Shape.Rounded;
            panelStyle3.ContainerStyle = containerStyle3;
            panelHeaderStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(42)))), ((int)(((byte)(127)))));
            panelHeaderStyle5.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            panelHeaderStyle5.FadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(215)))));
            panelHeaderStyle5.FillStyle = PureComponents.NicePanel.FillStyle.HorizontalFading;
            panelHeaderStyle5.FlashBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(122)))), ((int)(((byte)(1)))));
            panelHeaderStyle5.FlashFadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(159)))));
            panelHeaderStyle5.FlashForeColor = System.Drawing.Color.White;
            panelHeaderStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            panelHeaderStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(198)))), ((int)(((byte)(237)))));
            panelHeaderStyle5.Size = PureComponents.NicePanel.PanelHeaderSize.Small;
            panelStyle3.FooterStyle = panelHeaderStyle5;
            panelHeaderStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(215)))));
            panelHeaderStyle6.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            panelHeaderStyle6.FadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(42)))), ((int)(((byte)(127)))));
            panelHeaderStyle6.FillStyle = PureComponents.NicePanel.FillStyle.VerticalFading;
            panelHeaderStyle6.FlashBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(122)))), ((int)(((byte)(1)))));
            panelHeaderStyle6.FlashFadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(159)))));
            panelHeaderStyle6.FlashForeColor = System.Drawing.Color.White;
            panelHeaderStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            panelHeaderStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            panelHeaderStyle6.Size = PureComponents.NicePanel.PanelHeaderSize.Small;
            panelStyle3.HeaderStyle = panelHeaderStyle6;
            this.NicePanel1.Style = panelStyle3;
            this.NicePanel1.TabIndex = 0;
            this.NicePanel1.Text = "NicePanel1";
            // 
            // ContextMenuFavorites
            // 
            this.ContextMenuFavorites.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem1,
            this.MenuItem2,
            this.MenuItem3});
            this.ContextMenuFavorites.Popup += new System.EventHandler(this.ContextMenuFavorites_Popup);
            // 
            // MenuItem1
            // 
            this.MenuItem1.Index = 0;
            this.MenuItem1.Text = "Add to Favorites...";
            // 
            // MenuItem2
            // 
            this.MenuItem2.Index = 1;
            this.MenuItem2.Text = "Organize Favorites...";
            // 
            // MenuItem3
            // 
            this.MenuItem3.Index = 2;
            this.MenuItem3.Text = "Search Favorites";
            // 
            // LinkLabel5
            // 
            this.LinkLabel5.BackColor = System.Drawing.Color.Transparent;
            this.LinkLabel5.Location = new System.Drawing.Point(8, 92);
            this.LinkLabel5.Name = "LinkLabel5";
            this.LinkLabel5.Size = new System.Drawing.Size(180, 16);
            this.LinkLabel5.TabIndex = 4;
            this.LinkLabel5.TabStop = true;
            this.LinkLabel5.Text = "dotNet on YouTube";
            this.LinkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel5_LinkClicked);
            // 
            // LinkLabel4
            // 
            this.LinkLabel4.BackColor = System.Drawing.Color.Transparent;
            this.LinkLabel4.Location = new System.Drawing.Point(8, 40);
            this.LinkLabel4.Name = "LinkLabel4";
            this.LinkLabel4.Size = new System.Drawing.Size(180, 16);
            this.LinkLabel4.TabIndex = 0;
            this.LinkLabel4.TabStop = true;
            this.LinkLabel4.Text = "Microsoft Technical Docs";
            this.LinkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel4_LinkClicked);
            // 
            // LinkLabel3
            // 
            this.LinkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.LinkLabel3.Location = new System.Drawing.Point(8, 58);
            this.LinkLabel3.Name = "LinkLabel3";
            this.LinkLabel3.Size = new System.Drawing.Size(180, 16);
            this.LinkLabel3.TabIndex = 2;
            this.LinkLabel3.TabStop = true;
            this.LinkLabel3.Text = "Windows Forms .NET";
            this.LinkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel3_LinkClicked);
            // 
            // LinkLabel2
            // 
            this.LinkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.LinkLabel2.Location = new System.Drawing.Point(8, 24);
            this.LinkLabel2.Name = "LinkLabel2";
            this.LinkLabel2.Size = new System.Drawing.Size(180, 16);
            this.LinkLabel2.TabIndex = 1;
            this.LinkLabel2.TabStop = true;
            this.LinkLabel2.Text = "DuckDuckGo Search";
            this.LinkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.LinkLabel1.Location = new System.Drawing.Point(8, 75);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(180, 16);
            this.LinkLabel1.TabIndex = 3;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "Visual Studio on YouTube";
            this.LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // Splitter1
            // 
            this.Splitter1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Splitter1.Location = new System.Drawing.Point(210, 6);
            this.Splitter1.Name = "Splitter1";
            this.Splitter1.Size = new System.Drawing.Size(6, 441);
            this.Splitter1.TabIndex = 1;
            this.Splitter1.TabStop = false;
            // 
            // NicePanel4
            // 
            this.NicePanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            this.NicePanel4.CloseButton = true;
            this.NicePanel4.CollapseButton = false;
            containerImage4.Alignment = System.Drawing.ContentAlignment.BottomRight;
            containerImage4.ClipArt = PureComponents.NicePanel.ImageClipArt.None;
            containerImage4.Image = null;
            containerImage4.Size = PureComponents.NicePanel.ContainerImageSize.Small;
            containerImage4.Transparency = 50;
            this.NicePanel4.ContainerImage = containerImage4;
            this.NicePanel4.ContextMenuButton = false;
            this.NicePanel4.Controls.Add(this.chromiumWebBrowser1);
            this.NicePanel4.Controls.Add(this.Go);
            this.NicePanel4.Controls.Add(this.Address);
            this.NicePanel4.Controls.Add(this.Label3);
            this.NicePanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NicePanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            headerImage7.ClipArt = PureComponents.NicePanel.ImageClipArt.None;
            headerImage7.Image = null;
            this.NicePanel4.FooterImage = headerImage7;
            this.NicePanel4.FooterText = "Copyright  2004 PureComponents. All rights reserved.";
            this.NicePanel4.ForeColor = System.Drawing.Color.Black;
            headerImage8.ClipArt = PureComponents.NicePanel.ImageClipArt.Block;
            headerImage8.Image = null;
            this.NicePanel4.HeaderImage = headerImage8;
            this.NicePanel4.HeaderText = "PureComponents NicePanel Browser";
            this.NicePanel4.IsExpanded = true;
            this.NicePanel4.Location = new System.Drawing.Point(216, 6);
            this.NicePanel4.Name = "NicePanel4";
            this.NicePanel4.OriginalFooterVisible = true;
            this.NicePanel4.OriginalHeight = 150;
            this.NicePanel4.Resizable = false;
            this.NicePanel4.Size = new System.Drawing.Size(486, 441);
            containerStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            containerStyle4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            containerStyle4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(45)))), ((int)(((byte)(150)))));
            containerStyle4.BorderStyle = PureComponents.NicePanel.BorderStyle.Solid;
            containerStyle4.CaptionAlign = PureComponents.NicePanel.CaptionAlign.Left;
            containerStyle4.FadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(233)))));
            containerStyle4.FillStyle = PureComponents.NicePanel.FillStyle.Flat;
            containerStyle4.FlashItemBackColor = System.Drawing.Color.Red;
            containerStyle4.FocusItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            containerStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            containerStyle4.ForeColor = System.Drawing.Color.Black;
            containerStyle4.Shape = PureComponents.NicePanel.Shape.Rounded;
            panelStyle4.ContainerStyle = containerStyle4;
            panelHeaderStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(42)))), ((int)(((byte)(127)))));
            panelHeaderStyle7.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            panelHeaderStyle7.FadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(215)))));
            panelHeaderStyle7.FillStyle = PureComponents.NicePanel.FillStyle.HorizontalFading;
            panelHeaderStyle7.FlashBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(122)))), ((int)(((byte)(1)))));
            panelHeaderStyle7.FlashFadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(159)))));
            panelHeaderStyle7.FlashForeColor = System.Drawing.Color.White;
            panelHeaderStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            panelHeaderStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(198)))), ((int)(((byte)(237)))));
            panelHeaderStyle7.Size = PureComponents.NicePanel.PanelHeaderSize.Small;
            panelStyle4.FooterStyle = panelHeaderStyle7;
            panelHeaderStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(215)))));
            panelHeaderStyle8.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            panelHeaderStyle8.FadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(42)))), ((int)(((byte)(127)))));
            panelHeaderStyle8.FillStyle = PureComponents.NicePanel.FillStyle.VerticalFading;
            panelHeaderStyle8.FlashBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(122)))), ((int)(((byte)(1)))));
            panelHeaderStyle8.FlashFadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(159)))));
            panelHeaderStyle8.FlashForeColor = System.Drawing.Color.White;
            panelHeaderStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            panelHeaderStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            panelHeaderStyle8.Size = PureComponents.NicePanel.PanelHeaderSize.Large;
            panelStyle4.HeaderStyle = panelHeaderStyle8;
            this.NicePanel4.Style = panelStyle4;
            this.NicePanel4.TabIndex = 2;
            this.NicePanel4.Text = "NicePanel4";
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(6, 71);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(473, 348);
            this.chromiumWebBrowser1.TabIndex = 6;
            // 
            // Go
            // 
            this.Go.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Go.BackColor = System.Drawing.Color.LightBlue;
            this.Go.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Go.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Go.Location = new System.Drawing.Point(450, 45);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(30, 20);
            this.Go.TabIndex = 4;
            this.Go.Text = "Go";
            this.Go.UseVisualStyleBackColor = false;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // Address
            // 
            this.Address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Address.Location = new System.Drawing.Point(57, 45);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(389, 20);
            this.Address.TabIndex = 1;
            this.Address.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Address_KeyUp);
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.ForeColor = System.Drawing.Color.Navy;
            this.Label3.Location = new System.Drawing.Point(6, 47);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(51, 16);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "A&ddress:";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(708, 453);
            this.Controls.Add(this.NicePanel4);
            this.Controls.Add(this.Splitter1);
            this.Controls.Add(this.Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Text = "PureComponents NicePanel Browser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Panel1.ResumeLayout(false);
            this.NicePanel3.ResumeLayout(false);
            this.NicePanel2.ResumeLayout(false);
            this.NicePanel2.PerformLayout();
            this.NicePanel1.ResumeLayout(false);
            this.NicePanel4.ResumeLayout(false);
            this.NicePanel4.PerformLayout();
            this.ResumeLayout(false);

		}
		
		#endregion
		
		private void LinkLabel1_LinkClicked (System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
            //Visual Studio on YouTube
            chromiumWebBrowser1.Load("https://www.youtube.com/c/visualstudio");		
		}
		
		private void LinkLabel2_LinkClicked (System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
            //duckduckgo Search
            chromiumWebBrowser1.Load("https://duckduckgo.com");		
		}
		
		private void LinkLabel3_LinkClicked (System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
            //Windows Forms .NET
			chromiumWebBrowser1.Load("https://docs.microsoft.com/en-us/dotnet/desktop/winforms/overview/?view=netdesktop-6.0");			
        }
		
		private void LinkLabel4_LinkClicked (System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
            //Microsoft Technical Documentation
			chromiumWebBrowser1.Load("https://docs.microsoft.com/en-us/");			
		}
		
		private void LinkLabel5_LinkClicked (System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
            //dotNet on YouTube
			chromiumWebBrowser1.Load("https://www.youtube.com/c/dotNET");			
		}

        private void ChromiumWebBrowser1_StatusMessage(object sender, CefSharp.StatusMessageEventArgs e)
        {
            if (e.Value == "")
            {
                NicePanel4.BeginInvoke((Action)(() => NicePanel4.FooterText = "Copyright © 2004 PureComponents. All rights reserved."));
            }
            else
            {
                NicePanel4.BeginInvoke((Action)(() => NicePanel4.FooterText = e.Value));
            }
        }

        private void Search_Click (System.Object sender, System.EventArgs e)
		{
			string strKeywords;
			strKeywords = HttpUtility.UrlDecode(Keywords.Text);
            string ia = "web";
            //if (rbtWeb.Checked) ia = "web";
            if (rbtImages.Checked) ia = "images";
            if (rbtVideos.Checked) ia = "videos";
            if (rbtNews.Checked) ia = "news";
            if (rbtMaps.Checked) ia = "maps";
            if (rbtShopping.Checked) ia = "shopping";
            chromiumWebBrowser1.Load($"https://duckduckgo.com/?q={strKeywords}&t=h_&ia={ia}");
		}
		
		private void Keywords_KeyUp (object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				Search.PerformClick();
			}
		}
		
		private void Address_KeyUp (object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				Go.PerformClick();
			}
		}
		
		private void Go_Click (System.Object sender, System.EventArgs e)
		{
			chromiumWebBrowser1.Load(HttpUtility.UrlDecode(Address.Text));
		}

        private void ChromiumWebBrowser1_AddressChanged(object sender, CefSharp.AddressChangedEventArgs e)
        {
            Address.BeginInvoke((Action)(() => Address.Text = e.Address));
        }

        private void ContextMenuFavorites_Popup(object sender, EventArgs e)
        {

        }
    }	
}
