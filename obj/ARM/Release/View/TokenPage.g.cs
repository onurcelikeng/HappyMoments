﻿

#pragma checksum "D:\Projects\HappyMoments\Project\HappyMoments\HappyMoments\View\TokenPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4D3100F17C1650309D227F5533C2D946"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HappyMomentsUWP.View
{
    partial class TokenPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 138 "..\..\..\View\TokenPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.confirmButton_Tapped;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 82 "..\..\..\View\TokenPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.delete_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 84 "..\..\..\View\TokenPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.add_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


