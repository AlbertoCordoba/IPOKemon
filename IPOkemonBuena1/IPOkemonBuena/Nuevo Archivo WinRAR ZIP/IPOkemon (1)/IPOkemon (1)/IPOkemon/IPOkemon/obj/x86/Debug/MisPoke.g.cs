﻿#pragma checksum "C:\Users\G531\Desktop\IPOkemonBuena1\IPOkemonBuena\Nuevo Archivo WinRAR ZIP\IPOkemon (1)\IPOkemon (1)\IPOkemon\IPOkemon\MisPoke.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "22E65CC87A500EA9C4041FDC8B23426546D7BB2BF8752D4D212DAD43BF6B8A11"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IPOkemon
{
    partial class MisPokemon : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MisPoke.xaml line 11
                {
                    this.MisPoke = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // MisPoke.xaml line 25
                {
                    this.Titulo_img = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4: // MisPoke.xaml line 39
                {
                    this.btnAronMCC = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnAronMCC).Click += this.btnAron_Click;
                }
                break;
            case 5: // MisPoke.xaml line 40
                {
                    this.AronControl = (global::IPOkemon.AronMCC)(target);
                }
                break;
            case 6: // MisPoke.xaml line 34
                {
                    this.btnAzumarill = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnAzumarill).Click += this.btnAzumarill_Click;
                }
                break;
            case 7: // MisPoke.xaml line 35
                {
                    this.AzumarillControl = (global::IPOkemon.AzumarillACR)(target);
                }
                break;
            case 8: // MisPoke.xaml line 28
                {
                    this.btnCharmander = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnCharmander).Click += this.btnCharmander_Click;
                }
                break;
            case 9: // MisPoke.xaml line 29
                {
                    this.CharmanderControl = (global::IPOkemon.CharmanderFJDR)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

