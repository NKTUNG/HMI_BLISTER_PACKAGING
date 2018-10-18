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
	using System.Reflection;
    
	public delegate void Handler();
	
	public partial class Tags
	{
		public Handler Update = null;
		
		void Tags_ServerInfo(System.Object sender, Neo.ApplicationFramework.Interfaces.Events.ServerInfoArgs e)
		{
			
		}
		
		public static T StringToTag<T>(string tagName) where T : class
		{
			Type type = typeof(T);
			FieldInfo[] props = Globals.Tags.GetType().GetFields();
			foreach (FieldInfo prop in props) {
				if (prop.FieldType.Equals(type)) {
					if (prop.Name.Equals(tagName, StringComparison.CurrentCultureIgnoreCase)) {
						return (T)prop.GetValue(Globals.Tags);
					}               
				}
			}
			return null;
		}
		
		void SystemTagLatestLoadedRecipeName_ValueChange(System.Object sender, Core.Api.DataSource.ValueChangedEventArgs e)
		{
			if(Update != null)
			{
				Update();
			}
		}
	}
}
