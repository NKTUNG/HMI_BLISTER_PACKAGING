//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Neo.ApplicationFramework.Generated {
    using Neo.ApplicationFramework.Controls.Controls;
    using Neo.ApplicationFramework.Controls;
    using Neo.ApplicationFramework.Interfaces;
    using Neo.ApplicationFramework.Tools.Security;
    using Neo.ApplicationFramework.Tools.Actions;
    using Neo.ApplicationFramework.Common.MultiLanguage;
    
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public partial class TECHNICAL : Neo.ApplicationFramework.Controls.Controls.Form, Neo.ApplicationFramework.Interfaces.ISupportMultiLanguage {
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text1;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text3;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text4;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text5;
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture;
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture1;
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture4;
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture2;
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture3;
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture5;
        
        private Neo.ApplicationFramework.Controls.Symbol.PictureCF m_Picture6;
        
        private Neo.ApplicationFramework.Controls.Controls.Label m_Text;
        
        private bool m_Initialized_TECHNICAL;
        
        public TECHNICAL() {
            this.InitializeComponent();
            this.Adapter.Opened += new System.EventHandler(this.TECHNICAL_Opened);
            this.m_Picture4.MouseDown += new System.EventHandler(this.m_Picture4_Action_MouseDown);
            this.m_Picture2.MouseDown += new System.EventHandler(this.m_Picture2_Action_MouseDown);
            this.m_Picture3.MouseDown += new System.EventHandler(this.m_Picture3_Action_MouseDown);
            this.m_Picture5.MouseDown += new System.EventHandler(this.m_Picture5_Action_MouseDown);
            this.m_Picture6.MouseDown += new System.EventHandler(this.m_Picture6_Action_MouseDown);
            this.ApplyLanguageInitialize();
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text1 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text1);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text3 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text3);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text4 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text4);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text5 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text5);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture1 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture1);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture4 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture4);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture2 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture2);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture3 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture3);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture5 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture5);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter Picture6 {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.RenderableCFAdapter>(this.m_Picture6);
            }
        }
        
        protected Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter Text {
            get {
                return this.AdapterService.CreateAdapter<Neo.ApplicationFramework.Controls.Script.TextControlCFAdapter>(this.m_Text);
            }
        }
        
        private void InitializeComponent() {
            this.m_Text1 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Text3 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Text4 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Text5 = new Neo.ApplicationFramework.Controls.Controls.Label();
            this.m_Picture = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_Picture1 = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_Picture4 = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_Picture2 = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_Picture3 = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_Picture5 = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_Picture6 = new Neo.ApplicationFramework.Controls.Symbol.PictureCF();
            this.m_Text = new Neo.ApplicationFramework.Controls.Controls.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text)).BeginInit();
            this.SuspendLayout();
            // 
            // TECHNICAL
            // 
            this.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.BorderStyle = Neo.ApplicationFramework.Interfaces.ScreenBorderStyle.ThreeDBorder;
            this.ControlBox = false;
            // 
            // m_Text1
            // 
            this.m_Text1.AutoSize = false;
            this.m_Text1.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(150)))), ((int)(((byte)(70))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Text1.BitmapEffect = new Neo.ApplicationFramework.Common.Graphics.Logic.BitmapEffectCF(2, 0, Neo.ApplicationFramework.Common.Graphics.Logic.LightAngle.UpperLeft);
            this.m_Text1.BlinkDynamicsValue = false;
            this.m_Text1.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(1D, 1D, 1D, 1D);
            this.m_Text1.DelayMouseInputPeriod = 0;
            this.m_Text1.EnabledDynamicsValue = true;
            this.m_Text1.FontFamily = "Arial";
            this.m_Text1.FontSizePixels = 26;
            this.m_Text1.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m_Text1.Height = 72;
            this.m_Text1.Left = 618;
            this.m_Text1.MultiLine = true;
            this.m_Text1.Name = "m_Text1";
            this.m_Text1.ScreenOwnerName = "TECHNICAL";
            this.m_Text1.TextHorizontalAlignment = "Center";
            this.m_Text1.TextVerticalAlignment = "Center";
            this.m_Text1.Top = 333;
            this.m_Text1.VisibleDynamicsValue = true;
            this.m_Text1.Width = 137;
            // 
            // m_Text3
            // 
            this.m_Text3.AutoSize = false;
            this.m_Text3.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(150)))), ((int)(((byte)(70))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Text3.BitmapEffect = new Neo.ApplicationFramework.Common.Graphics.Logic.BitmapEffectCF(2, 0, Neo.ApplicationFramework.Common.Graphics.Logic.LightAngle.UpperLeft);
            this.m_Text3.BlinkDynamicsValue = false;
            this.m_Text3.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(1D, 1D, 1D, 1D);
            this.m_Text3.DelayMouseInputPeriod = 0;
            this.m_Text3.EnabledDynamicsValue = true;
            this.m_Text3.FontFamily = "Arial";
            this.m_Text3.FontSizePixels = 26;
            this.m_Text3.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m_Text3.Height = 72;
            this.m_Text3.Left = 226;
            this.m_Text3.MultiLine = true;
            this.m_Text3.Name = "m_Text3";
            this.m_Text3.ScreenOwnerName = "TECHNICAL";
            this.m_Text3.TextHorizontalAlignment = "Center";
            this.m_Text3.TextVerticalAlignment = "Center";
            this.m_Text3.Top = 333;
            this.m_Text3.VisibleDynamicsValue = true;
            this.m_Text3.Width = 146;
            // 
            // m_Text4
            // 
            this.m_Text4.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(150)))), ((int)(((byte)(70))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Text4.BitmapEffect = new Neo.ApplicationFramework.Common.Graphics.Logic.BitmapEffectCF(2, 0, Neo.ApplicationFramework.Common.Graphics.Logic.LightAngle.UpperLeft);
            this.m_Text4.BlinkDynamicsValue = false;
            this.m_Text4.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(1D, 1D, 1D, 1D);
            this.m_Text4.DelayMouseInputPeriod = 0;
            this.m_Text4.EnabledDynamicsValue = true;
            this.m_Text4.FontFamily = "Arial";
            this.m_Text4.FontSizePixels = 26;
            this.m_Text4.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m_Text4.Height = 34;
            this.m_Text4.Left = 415;
            this.m_Text4.MultiLine = true;
            this.m_Text4.Name = "m_Text4";
            this.m_Text4.ScreenOwnerName = "TECHNICAL";
            this.m_Text4.TextHorizontalAlignment = "Center";
            this.m_Text4.TextVerticalAlignment = "Center";
            this.m_Text4.Top = 333;
            this.m_Text4.VisibleDynamicsValue = true;
            this.m_Text4.Width = 62;
            // 
            // m_Text5
            // 
            this.m_Text5.Background = new Neo.ApplicationFramework.Common.Graphics.Logic.BrushCF(System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(150)))), ((int)(((byte)(70))))), System.Drawing.Color.Empty, Neo.ApplicationFramework.Interfaces.FillDirection.None);
            this.m_Text5.BitmapEffect = new Neo.ApplicationFramework.Common.Graphics.Logic.BitmapEffectCF(2, 0, Neo.ApplicationFramework.Common.Graphics.Logic.LightAngle.UpperLeft);
            this.m_Text5.BlinkDynamicsValue = false;
            this.m_Text5.BorderThickness = new Neo.ApplicationFramework.Common.Graphics.Logic.ThicknessCF(1D, 1D, 1D, 1D);
            this.m_Text5.DelayMouseInputPeriod = 0;
            this.m_Text5.EnabledDynamicsValue = true;
            this.m_Text5.FontFamily = "Arial";
            this.m_Text5.FontSizePixels = 26;
            this.m_Text5.Foreground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m_Text5.Height = 34;
            this.m_Text5.Left = 49;
            this.m_Text5.MultiLine = true;
            this.m_Text5.Name = "m_Text5";
            this.m_Text5.ScreenOwnerName = "TECHNICAL";
            this.m_Text5.TextHorizontalAlignment = "Center";
            this.m_Text5.TextVerticalAlignment = "Center";
            this.m_Text5.Top = 333;
            this.m_Text5.VisibleDynamicsValue = true;
            this.m_Text5.Width = 59;
            // 
            // m_Picture
            // 
            this.m_Picture.BlinkDynamicsValue = false;
            this.m_Picture.DelayMouseInputPeriod = 0;
            this.m_Picture.EnabledDynamicsValue = true;
            this.m_Picture.Height = 50;
            this.m_Picture.Left = 519;
            this.m_Picture.Name = "m_Picture";
            this.m_Picture.ScreenOwnerName = "TECHNICAL";
            this.m_Picture.Stretch = true;
            this.m_Picture.SymbolName = "engineering-icon-2";
            this.m_Picture.Top = 25;
            this.m_Picture.VisibleDynamicsValue = true;
            this.m_Picture.Width = 50;
            // 
            // m_Picture1
            // 
            this.m_Picture1.BlinkDynamicsValue = false;
            this.m_Picture1.DelayMouseInputPeriod = 0;
            this.m_Picture1.EnabledDynamicsValue = true;
            this.m_Picture1.Height = 152;
            this.m_Picture1.Left = 414;
            this.m_Picture1.Name = "m_Picture1";
            this.m_Picture1.ScreenOwnerName = "TECHNICAL";
            this.m_Picture1.Stretch = true;
            this.m_Picture1.SymbolName = "images (1)";
            this.m_Picture1.Top = 165;
            this.m_Picture1.VisibleDynamicsValue = true;
            this.m_Picture1.Width = 152;
            // 
            // m_Picture4
            // 
            this.m_Picture4.BlinkDynamicsValue = false;
            this.m_Picture4.DelayMouseInputPeriod = 0;
            this.m_Picture4.EnabledDynamicsValue = true;
            this.m_Picture4.Height = 160;
            this.m_Picture4.Left = 595;
            this.m_Picture4.Name = "m_Picture4";
            this.m_Picture4.ScreenOwnerName = "TECHNICAL";
            this.m_Picture4.Stretch = true;
            this.m_Picture4.SymbolName = "images (1) (1)";
            this.m_Picture4.Top = 165;
            this.m_Picture4.VisibleDynamicsValue = true;
            this.m_Picture4.Width = 160;
            // 
            // m_Picture2
            // 
            this.m_Picture2.BlinkDynamicsValue = false;
            this.m_Picture2.DelayMouseInputPeriod = 0;
            this.m_Picture2.EnabledDynamicsValue = true;
            this.m_Picture2.Height = 150;
            this.m_Picture2.Left = 49;
            this.m_Picture2.Name = "m_Picture2";
            this.m_Picture2.ScreenOwnerName = "TECHNICAL";
            this.m_Picture2.Stretch = true;
            this.m_Picture2.SymbolName = "easysetup";
            this.m_Picture2.Top = 170;
            this.m_Picture2.VisibleDynamicsValue = true;
            this.m_Picture2.Width = 150;
            // 
            // m_Picture3
            // 
            this.m_Picture3.BlinkDynamicsValue = false;
            this.m_Picture3.DelayMouseInputPeriod = 0;
            this.m_Picture3.EnabledDynamicsValue = true;
            this.m_Picture3.Height = 128;
            this.m_Picture3.Left = 235;
            this.m_Picture3.Name = "m_Picture3";
            this.m_Picture3.ScreenOwnerName = "TECHNICAL";
            this.m_Picture3.Stretch = true;
            this.m_Picture3.SymbolName = "automation_power_application_configuration_setup_process_install-512";
            this.m_Picture3.Top = 181;
            this.m_Picture3.VisibleDynamicsValue = true;
            this.m_Picture3.Width = 128;
            // 
            // m_Picture5
            // 
            this.m_Picture5.BlinkDynamicsValue = false;
            this.m_Picture5.DelayMouseInputPeriod = 0;
            this.m_Picture5.EnabledDynamicsValue = true;
            this.m_Picture5.Height = 54;
            this.m_Picture5.Left = 13;
            this.m_Picture5.Name = "m_Picture5";
            this.m_Picture5.ScreenOwnerName = "TECHNICAL";
            this.m_Picture5.Stretch = true;
            this.m_Picture5.SymbolName = "home-5-xxl";
            this.m_Picture5.Top = 23;
            this.m_Picture5.VisibleDynamicsValue = true;
            this.m_Picture5.Width = 54;
            // 
            // m_Picture6
            // 
            this.m_Picture6.BlinkDynamicsValue = false;
            this.m_Picture6.DelayMouseInputPeriod = 0;
            this.m_Picture6.EnabledDynamicsValue = true;
            this.m_Picture6.Height = 40;
            this.m_Picture6.Left = 721;
            this.m_Picture6.Name = "m_Picture6";
            this.m_Picture6.ScreenOwnerName = "TECHNICAL";
            this.m_Picture6.Stretch = true;
            this.m_Picture6.SymbolName = "tải xuống (1)";
            this.m_Picture6.Top = 31;
            this.m_Picture6.VisibleDynamicsValue = true;
            this.m_Picture6.Width = 40;
            // 
            // m_Text
            // 
            this.m_Text.BlinkDynamicsValue = false;
            this.m_Text.DelayMouseInputPeriod = 0;
            this.m_Text.EnabledDynamicsValue = true;
            this.m_Text.FontFamily = "Arial";
            this.m_Text.FontSizePixels = 22;
            this.m_Text.Height = 21;
            this.m_Text.Left = 571;
            this.m_Text.Name = "m_Text";
            this.m_Text.ScreenOwnerName = "TECHNICAL";
            this.m_Text.Top = 45;
            this.m_Text.VisibleDynamicsValue = true;
            this.m_Text.Width = 29;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.IsCacheable = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.ModalScreen = true;
            this.Name = "TECHNICAL";
            this.PopupScreen = false;
            this.ScreenID = null;
            this.ScreenTitle = "";
            this.StyleName = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.m_Initialized_TECHNICAL = true;
            this.AddControlsAndPrimitives();
            this.ResumeLayout(false);
        }
        
        protected override Neo.ApplicationFramework.Common.Alias.Entities.AliasInstancesCF CreateInstanceData() {
            System.Collections.Generic.List<Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF> instanceList = new System.Collections.Generic.List<Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF>(1);
            instanceList.Add(this.CreateInstanceData_Default());
            Neo.ApplicationFramework.Common.Alias.Entities.AliasInstancesCF aliasInstances = new Neo.ApplicationFramework.Common.Alias.Entities.AliasInstancesCF();
            aliasInstances.Instances = instanceList.ToArray();
            return aliasInstances;
        }
        
        private Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF CreateInstanceData_Default() {
            Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF aliasinstancecf1 = new Neo.ApplicationFramework.Common.Alias.Entities.AliasInstanceCF();
            aliasinstancecf1.Name = "Default";
            aliasinstancecf1.Values = new Neo.ApplicationFramework.Common.Alias.Entities.AliasValueCF[0];
            return aliasinstancecf1;
        }
        
        protected override void BindAliases() {
        }
        
        protected override void Dispose(bool disposing) {
            base.Dispose(disposing);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void AddControlsAndPrimitives() {
            if (!m_Initialized_TECHNICAL) {
                return;
            }
            this.AddControls();
            this.AddDrawingPrimitives();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void AddControls() {
            base.AddControls();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void AddDrawingPrimitives() {
            base.AddDrawingPrimitives();
            this.DrawingPrimitives.Add(this.m_Text1);
            this.DrawingPrimitives.Add(this.m_Text3);
            this.DrawingPrimitives.Add(this.m_Text4);
            this.DrawingPrimitives.Add(this.m_Text5);
            this.DrawingPrimitives.Add(this.m_Picture);
            this.DrawingPrimitives.Add(this.m_Picture1);
            this.DrawingPrimitives.Add(this.m_Picture4);
            this.DrawingPrimitives.Add(this.m_Picture2);
            this.DrawingPrimitives.Add(this.m_Picture3);
            this.DrawingPrimitives.Add(this.m_Picture5);
            this.DrawingPrimitives.Add(this.m_Picture6);
            this.DrawingPrimitives.Add(this.m_Text);
            ((System.ComponentModel.ISupportInitialize)(this.m_Text1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Picture6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Text)).EndInit();
        }
        
        private void m_Picture4_Action_MouseDown(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Picture4", "MouseDown", "Show Screen", "ALARM", "Default", "");
            Neo.ApplicationFramework.Generated.Globals.ALARM.Show();
        }
        
        private void m_Picture2_Action_MouseDown(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Picture2", "MouseDown", "Show Screen", "DRAG_OPERATION", "Default", "");
            Neo.ApplicationFramework.Generated.Globals.DRAG_OPERATION.Show();
        }
        
        private void m_Picture3_Action_MouseDown(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Picture3", "MouseDown", "Show Screen", "OPERATE_2", "Default", "");
            Neo.ApplicationFramework.Generated.Globals.OPERATE_2.Show();
        }
        
        private void m_Picture5_Action_MouseDown(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Picture5", "MouseDown", "Show Screen", "LOGIN", "Default", "");
            Neo.ApplicationFramework.Generated.Globals.LOGIN.Show();
        }
        
        private void m_Picture6_Action_MouseDown(object sender, System.EventArgs e) {
            Neo.ApplicationFramework.Generated.Globals.Security.Logout();
            Neo.ApplicationFramework.Generated.Globals.AuditTrailService.LogAction("m_Picture6", "MouseDown", "Show Screen", "START", "");
            Neo.ApplicationFramework.Generated.Globals.START.Show();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private void ApplyLanguageInternal() {
            Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(TECHNICAL));
            this.m_Text1.Text = resources.GetText("TECHNICAL.Text1.Text", "Lỗi thiết bị");
            this.m_Text3.Text = resources.GetText("TECHNICAL.Text3.Text", "Điều khiển \r\nthiết bị");
            this.m_Text4.Text = resources.GetText("TECHNICAL.Text4.Text", "Hiệu chuẩn \r\ncảm biến");
            this.m_Text5.Text = resources.GetText("TECHNICAL.Text5.Text", "Hiệu chỉnh\r\n thiết bị");
            this.m_Text.Text = resources.GetText("TECHNICAL.Text.Text", "User");
            this.ApplyResourcesOnForm();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        void Neo.ApplicationFramework.Interfaces.ISupportMultiLanguage.ApplyLanguage() {
            this.ApplyLanguage();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        protected override void ApplyLanguage() {
            if (((Neo.ApplicationFramework.Interfaces.IScreen)(this)).IsCachedDeactivated) {
                return;
            }
            this.ApplyLanguageInternal();
            base.ApplyLanguage();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void ApplyLanguageInitialize() {
            if (!m_Initialized_TECHNICAL) {
                return;
            }
            base.ApplyLanguageInitialize();
            this.ApplyLanguageInternal();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override void ConnectDataBindings() {
            base.ConnectDataBindings();
            Neo.ApplicationFramework.Common.Data.DynamicBinding dynamicBinding1 = new Neo.ApplicationFramework.Common.Data.DynamicBinding("Value", Neo.ApplicationFramework.Common.Data.DataItemProxyFactory.CreateProxy("Tags.SystemTagCurrentUser"), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never, Neo.ApplicationFramework.Common.Dynamics.VariantValueConverterCF.Default);
            this.m_Text.DataBindings.Add(dynamicBinding1);
            this.m_DynamicBindings.Add(dynamicBinding1);
        }
    }
}
