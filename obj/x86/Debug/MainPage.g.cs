﻿#pragma checksum "C:\Users\ArkadiyG\Desktop\Semester 2\OOC#\Works to submit\Sended Works\4 project Drinks Vending Machine\Drinks Vending Machine\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C4B5C105DCFC6F4D383128E5F8B40248"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Drinks_Vending_Machine
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 15
                {
                    this.showChoice = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // MainPage.xaml line 21
                {
                    this.drinkCup = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.drinkCup).Click += this.BT_Click_Take;
                }
                break;
            case 4: // MainPage.xaml line 30
                {
                    this.coffeeList = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 5: // MainPage.xaml line 58
                {
                    global::Windows.UI.Xaml.Controls.Button element5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element5).Click += this.BT_Click_Accept;
                }
                break;
            case 6: // MainPage.xaml line 66
                {
                    global::Windows.UI.Xaml.Controls.Primitives.ToggleButton element6 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)element6).Click += this.Big_Cups_Click;
                }
                break;
            case 7: // MainPage.xaml line 75
                {
                    global::Windows.UI.Xaml.Controls.Primitives.ToggleButton element7 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)element7).Click += this.Little_Cups_Click;
                }
                break;
            case 8: // MainPage.xaml line 83
                {
                    this.CoinSlot = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.CoinSlot).Click += this.PayMoney_Click;
                }
                break;
            case 9: // MainPage.xaml line 95
                {
                    this.TenShekels = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.TenShekels).Click += this.Ten_Shekels_Click;
                }
                break;
            case 10: // MainPage.xaml line 107
                {
                    this.FiveShekels = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.FiveShekels).Click += this.Five_Shekels_Click;
                }
                break;
            case 11: // MainPage.xaml line 119
                {
                    this.OneShekel = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.OneShekel).Click += this.One_Shekel_Click;
                }
                break;
            case 12: // MainPage.xaml line 131
                {
                    this.FiftyAgorot = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.FiftyAgorot).Click += this.Fifty_Agorot_Click;
                }
                break;
            case 13: // MainPage.xaml line 36
                {
                    this.choice1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.choice1).Click += this.BT_Click_Latte;
                }
                break;
            case 14: // MainPage.xaml line 43
                {
                    this.choice2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.choice2).Click += this.BT_Click_Cappuchino;
                }
                break;
            case 15: // MainPage.xaml line 50
                {
                    this.choice3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.choice3).Click += this.BT_Click_IrishCoffee;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

