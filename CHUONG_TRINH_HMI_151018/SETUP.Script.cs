//--------------------------------------------------------------
// Press F1 to get help about using script.
// To access an object that is not located in the current class, start the call with Globals.
// When using events and timers be cautious not to generate memoryleaks,
// please see the help for more information.
//---------------------------------------------------------------

namespace Neo.ApplicationFramework.Generated
{
    using System.Windows.Forms;
    using System;
    using System.Drawing;
    using Neo.ApplicationFramework.Tools;
    using Neo.ApplicationFramework.Common.Graphics.Logic;
    using Neo.ApplicationFramework.Controls;
    using Neo.ApplicationFramework.Interfaces;
	using GlobalDataItem = Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem;
    
    
    public partial class SETUP
    {
		void SETUP_Opened(System.Object sender, System.EventArgs e)
		{
			UpdateSanPhamInfo();
			Globals.Tags.Update = new Handler(UpdateSanPhamInfo);
		}
		
		public void UpdateSanPhamInfo()
		{
			SanPham.Text = Globals.Tags.SystemTagLatestLoadedRecipeName.Value.ToString();
			MaSanPham.Text = Globals.Tags.Masanpham.Value.ToString();
		}
		
		void MaSanPham_GotFocus(System.Object sender, System.EventArgs e)
		{
			
		}
		
    }
}
