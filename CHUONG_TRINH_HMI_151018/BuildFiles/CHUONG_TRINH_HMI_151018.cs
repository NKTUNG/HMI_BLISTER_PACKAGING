using System.Collections;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Threading;
using Core.Api.Application;
using Core.Api.Service;
using Core.Api.Tools;
using Core.Api.Utilities;
using Core.Utilities.Utilities;
using Core.Engine.Application;
using Neo.ApplicationFramework.Attributes;
using Neo.ApplicationFramework.Common;
using Neo.ApplicationFramework.Common.Runtime;
using Neo.ApplicationFramework.Common.TypeConverters;
using Neo.ApplicationFramework.Common.Utilities;
using Neo.ApplicationFramework.Interfaces;
using Neo.ApplicationFramework.Measurement;
using Neo.ApplicationFramework.Storage.Settings;
using Neo.ApplicationFramework.Tools.Runtime;
using Neo.ApplicationFramework.Tools.Storage;

[assembly: AssemblyVersion("2.40.44.0")]
[assembly: NeoDesignerVersion("2.40.44.0")]

namespace Neo.ApplicationFramework.Generated
{
    public class Globals : GlobalsBase
    {
        private static readonly log4net.ILog m_Log = log4net.LogManager.GetLogger(typeof(Globals));

        static Globals()
        {
            
        }

        public Globals() 
            : base(CreateToolManager())
        {
            m_ProjectSettings.MainScreenTitle = "TEST_CONNECT_PLCS7_1200";
            m_ProjectSettings.Topmost = true;
            m_ProjectSettings.StartupLocation = new Point(0, 0);
            m_ProjectSettings.MaximizeOnStartup = false;
            m_ProjectSettings.UseWideScrollbars = false;
            m_ProjectSettings.MainScreenSize = new Size(800,480);
            m_ProjectSettings.BorderStyle = ScreenBorderStyle.ThreeDBorder;
            m_ProjectSettings.InputDelay = 2000;
            m_ProjectSettings.IsOnScreenKeyboardEnabled = true;
            m_ProjectSettings.KeyboardLayoutName = "US";
            m_ProjectSettings.TerminalGroup = TerminalGroup.Default;
            List<IStorageProviderSetting> storageProviderSettingsList = new List<IStorageProviderSetting>() {
                new ProjectStorageProviderSetting("BackupAtStartup", false), new ProjectStorageProviderSetting("MaxSize", 0), 
            };
            m_ProjectSettings.StorageProviderSettings = new LocallyHostedProjectStorageProviderSettings("SQLite Database", storageProviderSettingsList, "");
            m_SystemSettings.AutomaticallyTurnOfBacklight = false;
            m_SystemSettings.BacklightTimeout = 900;    
            m_SystemSettings.KeepBacklightOnIfNotifierWindowIsVisible = false;
            Dictionary<ComPort, PortMode> comPortModes = new Dictionary<ComPort, PortMode>();
            comPortModes.Add(ComPort.COM1, PortMode.Nonconfigurable); comPortModes.Add(ComPort.COM2, PortMode.rs422); comPortModes.Add(ComPort.COM3, PortMode.Nonconfigurable); comPortModes.Add(ComPort.COM4, PortMode.rs485);                            
            m_SystemSettings.ComPortModes = comPortModes;                            
            m_SystemSettings.KeyBeep = true;
            m_SystemSettings.TimeZoneDisplayName = "";
            m_SystemSettings.TimeZoneId = -1;
            m_SystemSettings.RegionLCID = 0;
            m_SystemSettings.AdjustForDaylightSaving = true;
            m_SystemSettings.FtpServerEnabled = false;
            m_SystemSettings.FtpServerFriendlyNamesEnabled = false;
            m_SystemSettings.FtpServerAllowAnonymous = false;
            m_SystemSettings.FtpServerSdCardAccess = false;
            m_SystemSettings.FtpServerUsbAccess = false;
            m_SystemSettings.FtpServerDefaultDir = @"";
            m_SystemSettings.NTLMUser = @"";
            m_SystemSettings.NTLMPassword = @"";
            m_SystemSettings.VncServerEnabled = true;
            m_SystemSettings.VncTcpPort = 5900;
            m_SystemSettings.VncHttpTcpPort = 5800;
            m_SystemSettings.VncViewOnlyPassword = @"123456";
            m_SystemSettings.VncFullAccessPassword = @"12345678";
            m_SystemSettings.VncActiveConnectionNotification = true;
            m_SystemSettings.IsKeyPanel = false;
            m_SystemSettings.IsHeadless = false;
            m_SystemSettings.AlarmButtonShowScreenTarget = @"";
            m_SystemSettings.ScreenRotationAngle = 0;
            m_SystemSettings.BeShellMenuPassword = @"";
            m_SystemSettings.ProjectGuid = new Guid("2cea7606-4631-427a-b994-925e544e1152");
        }
        
        
        private static IToolManager CreateToolManager()
        {
            string executablePath = typeof(Globals).Module.FullyQualifiedName;            
            // take simulation into account
            var coreApplication = Environment.OSVersion.Platform != PlatformID.WinCE ? (ICoreApplication)new CoreApplication(true, executablePath) : (ICoreApplication)new CoreApplicationCe();
            IToolManager toolManager = new ApplicationEngineCe().CreateToolManager(true, coreApplication, Path.Combine(coreApplication.StartupPath, "Modules.cfgtool"));
            return toolManager;
        }
            

        
       

        /// <summary>
        /// Neo generated code - do not modify
        /// the contents of this method(s) with the code editor.
        /// </summary>        
                    public static IPrinterDevice Printer1
                    {
                        get
                        {
                            IDeviceManagerServiceCF deviceManagerService = ServiceContainerCF.GetService<IDeviceManagerServiceCF>();
                            return deviceManagerService.GetOutputDevice<IPrinterDevice>();
                        }
                    }           
                    public static IScreenAdapter SETUP2
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<SETUP2>("Screens.SETUP2.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter ALARM
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<ALARM>("Screens.ALARM.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter TECHNICAL
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<TECHNICAL>("Screens.TECHNICAL.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter LOGINHISTORY
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<LOGINHISTORY>("Screens.LOGINHISTORY.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter OPERATE
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<OPERATE>("Screens.OPERATE.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter SETUP
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<SETUP>("Screens.SETUP.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter QLSX
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<QLSX>("Screens.QLSX.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter LOGIN
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<LOGIN>("Screens.LOGIN.Default").Adapter;
                        }
                    }           
                    public static Recipe1 Recipe1
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Recipe1>("Recipe1");
                        }
                    }           
                    public static DataLogger2 DataLogger2
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<DataLogger2>("DataLogger2");
                        }
                    }           
                    public static DataLogger1 DataLogger1
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<DataLogger1>("DataLogger1");
                        }
                    }           
                    public static TextLibrary TextLibrary
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<TextLibrary>("TextLibrary");
                        }
                    }           
                    public static Reports Reports
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Reports>("Reports");
                        }
                    }           
                    public static AuditTrail AuditTrail
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<AuditTrail>("AuditTrail");
                        }
                    }           
                    public static WebServerRootComponent WebServerRootComponent
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<WebServerRootComponent>("WebServerRootComponent");
                        }
                    }           
                    public static OpcUaServerRootComponent OpcUaServerRootComponent
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<OpcUaServerRootComponent>("OpcUaServerRootComponent");
                        }
                    }           
                    public static AlarmServer AlarmServer
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<AlarmServer>("AlarmServer");
                        }
                    }           
                    public static Tags Tags
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Tags>("Tags");
                        }
                    }           
                    public static MultipleLanguages MultipleLanguages
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<MultipleLanguages>("MultipleLanguages");
                        }
                    }           
                    public static Expressions Expressions
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Expressions>("Expressions");
                        }
                    }           
                    public static LicenseRootComponent LicenseRootComponent
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<LicenseRootComponent>("LicenseRootComponent");
                        }
                    }           
                    public static Security Security
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<Security>("Security");
                        }
                    }           
                    public static ProjectConfiguration ProjectConfiguration
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<ProjectConfiguration>("ProjectConfiguration");
                        }
                    }           
                    public static SntpClientRootComponent SntpClientRootComponent
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<SntpClientRootComponent>("SntpClientRootComponent");
                        }
                    }           
                    public static IScreenAdapter OPERATE_2
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<OPERATE_2>("Screens.OPERATE_2.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter DRAG_OPERATION
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<DRAG_OPERATION>("Screens.DRAG_OPERATION.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter OPERATOR
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<OPERATOR>("Screens.OPERATOR.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter LCSP
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<LCSP>("Screens.LCSP.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter REPORT
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<REPORT>("Screens.REPORT.Default").Adapter;
                        }
                    }           
                    public static IScreenAdapter START
                    {
                        get
                        {
                            return GlobalReferenceService.Value.GetObject<START>("Screens.START.Default").Adapter;
                        }
                    }   
        [MTAThread]
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "NeoMainThread";
            
            InitializeBeHwApiLog();
            
            
            
            UserStartupMessage.SendUserStartupMessageToBeijerShell("Loading Files");
            if (!StopWatchCF.Silent)
                StopWatchCF.Send("Starting Project");
            StopWatchCF.SetTimestamp("***** Project Startup Time *****");
            while (ProcessExplorer.WaitForAttachDebugger)
            {
                Thread.Sleep(1000);
            }
            IsCompiledForCE = true;
            IsCompiledForDesktopWindowsPanel = false;

            Instance = new Globals();
        	if (!Instance.CheckIfApplicationCanRun())
				return;

            string executingAssemblyName = Assembly.GetExecutingAssembly().FullName;
            string executablePath = typeof(Globals).Module.FullyQualifiedName;

            Instance.Go(executingAssemblyName, executablePath, args, new string[]{"SntpClientRootComponent","ProjectConfiguration","Security","LicenseRootComponent","Expressions","Tags","MultipleLanguages","TextLibrary","AlarmServer","OpcUaServerRootComponent","WebServerRootComponent","AuditTrail","Reports","PLC_S7_1200","DataLogger1","DataLogger2","Recipe1","ProjectImages"}, new string[]{}, () => START);
        }

    }
}