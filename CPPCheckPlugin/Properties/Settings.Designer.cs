﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VSPackage.CPPCheckPlugin.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("c:\\Program Files (x86)\\Cppcheck\\cppcheck.exe")]
        public string CPPcheckPath {
            get {
                return ((string)(this["CPPcheckPath"]));
            }
            set {
                this["CPPcheckPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool InconclusiveChecksEnabled {
            get {
                return ((bool)(this["InconclusiveChecksEnabled"]));
            }
            set {
                this["InconclusiveChecksEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DefaultArguments {
            get {
                return ((string)(this["DefaultArguments"]));
            }
            set {
                this["DefaultArguments"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ProjectOnlyCheckCurrentConfig {
            get {
                return ((bool)(this["ProjectOnlyCheckCurrentConfig"]));
            }
            set {
                this["ProjectOnlyCheckCurrentConfig"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool FileOnlyCheckCurrentConfig {
            get {
                return ((bool)(this["FileOnlyCheckCurrentConfig"]));
            }
            set {
                this["FileOnlyCheckCurrentConfig"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("style,information,warning,performance,portability")]
        public string SeveritiesString {
            get {
                return ((string)(this["SeveritiesString"]));
            }
            set {
                this["SeveritiesString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("unmatchedSuppression")]
        public string SuppressionsString {
            get {
                return ((string)(this["SuppressionsString"]));
            }
            set {
                this["SuppressionsString"] = value;
            }
        }
    }
}
