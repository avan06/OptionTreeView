﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OptionTreeViewTestApp.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.12.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ValueKey123")]
        public string strKey {
            get {
                return ((string)(this["strKey"]));
            }
            set {
                this["strKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1|1_General|1_Enum|This is Enum1")]
        public global::OptionTreeView.Option<OptionTreeViewTestApp.ImageType> Enum1 {
            get {
                return ((global::OptionTreeView.Option<OptionTreeViewTestApp.ImageType>)(this["Enum1"]));
            }
            set {
                this["Enum1"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Bmp|1_General|1_Enum|This is Enum2")]
        public global::OptionTreeView.Option<OptionTreeViewTestApp.ImageType> Enum2 {
            get {
                return ((global::OptionTreeView.Option<OptionTreeViewTestApp.ImageType>)(this["Enum2"]));
            }
            set {
                this["Enum2"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CornflowerBlue|1_General|2_KnownColor|This is KnownColor1")]
        public global::OptionTreeView.Option<System.Drawing.KnownColor> Color1 {
            get {
                return ((global::OptionTreeView.Option<System.Drawing.KnownColor>)(this["Color1"]));
            }
            set {
                this["Color1"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DarkSeaGreen|1_General|2_KnownColor|This is KnownColor2")]
        public global::OptionTreeView.Option<System.Drawing.KnownColor> Color2 {
            get {
                return ((global::OptionTreeView.Option<System.Drawing.KnownColor>)(this["Color2"]));
            }
            set {
                this["Color2"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DarkSeaGreen|1_General|2_KnownColor|This is Color1")]
        public global::OptionTreeView.Option<System.Drawing.Color> Color3 {
            get {
                return ((global::OptionTreeView.Option<System.Drawing.Color>)(this["Color3"]));
            }
            set {
                this["Color3"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("99B4D1|1_General|2_KnownColor|This is Color2")]
        public global::OptionTreeView.Option<System.Drawing.Color> Color4 {
            get {
                return ((global::OptionTreeView.Option<System.Drawing.Color>)(this["Color4"]));
            }
            set {
                this["Color4"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("[FontFamily: Name=Microsoft Sans Serif]|1_General|3_FontFamily|This is FontFamily" +
            "1")]
        public global::OptionTreeView.Option<System.Drawing.FontFamily> FontFamily1 {
            get {
                return ((global::OptionTreeView.Option<System.Drawing.FontFamily>)(this["FontFamily1"]));
            }
            set {
                this["FontFamily1"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Ctrl + NumPad0|1_General|4_KeyOptions|This is Key1")]
        public global::OptionTreeView.Option<System.Windows.Forms.Keys> Key1 {
            get {
                return ((global::OptionTreeView.Option<System.Windows.Forms.Keys>)(this["Key1"]));
            }
            set {
                this["Key1"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Shift + D4|1_General|4_KeyOptions|This is Key2")]
        public global::OptionTreeView.Option<System.Windows.Forms.Keys> Key2 {
            get {
                return ((global::OptionTreeView.Option<System.Windows.Forms.Keys>)(this["Key2"]));
            }
            set {
                this["Key2"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Alt + OemMinus|1_General|4_KeyOptions|This is Key3")]
        public global::OptionTreeView.Option<System.Windows.Forms.Keys> Key3 {
            get {
                return ((global::OptionTreeView.Option<System.Windows.Forms.Keys>)(this["Key3"]));
            }
            set {
                this["Key3"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("192.168.1.1|1_General|Z_Connect1|This is IP")]
        public global::OptionTreeView.Option<string> IP {
            get {
                return ((global::OptionTreeView.Option<string>)(this["IP"]));
            }
            set {
                this["IP"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("80|1_General|Z_Connect1|This is PORT|0|10000")]
        public global::OptionTreeView.Option<int> PORT {
            get {
                return ((global::OptionTreeView.Option<int>)(this["PORT"]));
            }
            set {
                this["PORT"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("9.99|1_General|Connect2|This is Version|0.5|10.5")]
        public global::OptionTreeView.Option<float> Version {
            get {
                return ((global::OptionTreeView.Option<float>)(this["Version"]));
            }
            set {
                this["Version"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("TEST|1_General|Connect2|This is Type")]
        public global::OptionTreeView.Option<string> Type {
            get {
                return ((global::OptionTreeView.Option<string>)(this["Type"]));
            }
            set {
                this["Type"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("true|1_General|Connect3|This is Work3")]
        public global::OptionTreeView.Option<bool> Work3 {
            get {
                return ((global::OptionTreeView.Option<bool>)(this["Work3"]));
            }
            set {
                this["Work3"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("false|1_General|Connect3|This is Work4")]
        public global::OptionTreeView.Option<bool> Work4 {
            get {
                return ((global::OptionTreeView.Option<bool>)(this["Work4"]));
            }
            set {
                this["Work4"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("false|1_General|Connect3|This is Work5")]
        public global::OptionTreeView.Option<bool> Work5 {
            get {
                return ((global::OptionTreeView.Option<bool>)(this["Work5"]));
            }
            set {
                this["Work5"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("true|1_General|Connect3|This is Work6")]
        public global::OptionTreeView.Option<bool> Work6 {
            get {
                return ((global::OptionTreeView.Option<bool>)(this["Work6"]));
            }
            set {
                this["Work6"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("true|1_General|Connect3|This is Work7")]
        public global::OptionTreeView.Option<bool> Work7 {
            get {
                return ((global::OptionTreeView.Option<bool>)(this["Work7"]));
            }
            set {
                this["Work7"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("true|1_General|Connect3|This is Work8")]
        public global::OptionTreeView.Option<bool> Work8 {
            get {
                return ((global::OptionTreeView.Option<bool>)(this["Work8"]));
            }
            set {
                this["Work8"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("false|1_General|Connect3|This is Work9")]
        public global::OptionTreeView.Option<bool> Work9 {
            get {
                return ((global::OptionTreeView.Option<bool>)(this["Work9"]));
            }
            set {
                this["Work9"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1.23|1_General|Connect3|This is Setting3")]
        public global::OptionTreeView.Option<float> Setting3 {
            get {
                return ((global::OptionTreeView.Option<float>)(this["Setting3"]));
            }
            set {
                this["Setting3"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4.56|1_General|Connect3|This is Setting4")]
        public global::OptionTreeView.Option<float> Setting4 {
            get {
                return ((global::OptionTreeView.Option<float>)(this["Setting4"]));
            }
            set {
                this["Setting4"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("7.89|1_General|Connect3|This is Setting5")]
        public global::OptionTreeView.Option<float> Setting5 {
            get {
                return ((global::OptionTreeView.Option<float>)(this["Setting5"]));
            }
            set {
                this["Setting5"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.98|1_General|Connect3|This is Setting6")]
        public global::OptionTreeView.Option<float> Setting6 {
            get {
                return ((global::OptionTreeView.Option<float>)(this["Setting6"]));
            }
            set {
                this["Setting6"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("true||Z_Connect1|This is Work1")]
        public global::OptionTreeView.Option<bool> Work1_abcdef123456789_abcdef123456789_abcdef123456789 {
            get {
                return ((global::OptionTreeView.Option<bool>)(this["Work1_abcdef123456789_abcdef123456789_abcdef123456789"]));
            }
            set {
                this["Work1_abcdef123456789_abcdef123456789_abcdef123456789"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("false||Connect2|This is Work2")]
        public global::OptionTreeView.Option<bool> Work2 {
            get {
                return ((global::OptionTreeView.Option<bool>)(this["Work2"]));
            }
            set {
                this["Work2"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("123|Other||This is Setting1|-100|400")]
        public global::OptionTreeView.Option<int> Setting1 {
            get {
                return ((global::OptionTreeView.Option<int>)(this["Setting1"]));
            }
            set {
                this["Setting1"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("456|Other||This is Setting2|400|9999")]
        public global::OptionTreeView.Option<int> Setting2 {
            get {
                return ((global::OptionTreeView.Option<int>)(this["Setting2"]));
            }
            set {
                this["Setting2"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0x400000000|Other||This is Setting3ulongHex")]
        public global::OptionTreeView.Option<ulong> Setting3ulongHex {
            get {
                return ((global::OptionTreeView.Option<ulong>)(this["Setting3ulongHex"]));
            }
            set {
                this["Setting3ulongHex"] = value;
            }
        }
    }
}
