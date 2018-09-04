﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EXOFiddlerInspector.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.7.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"HTTP 502: False Positive. By design Office 365 Autodiscover does not respond to autodiscover.contoso.onmicrosoft.com for example on port 443. Validate this message by confirming this is an Office 365 IP address and perform a telnet to the IP address on port 80.")]
        public string HTTP502AutodiscoverFalsePositive {
            get {
                return ((string)(this["HTTP502AutodiscoverFalsePositive"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"HTTP 403: Forbidden. Is your firewall or web proxy blocking Outlook connectivity? To fire this message a HTTP 403 response code was detected 
and ""Access Denied"" was found in the response body. Check the Raw and WebView tabs, do you see anything which indicates traffic is blocked?


")]
        public string HTTP403WebProxyBlocking {
            get {
                return ((string)(this["HTTP403WebProxyBlocking"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"HTTP 503: FederatedSTSUnreachable.
The fedeation service is unreachable or unavailable. Check the Raw tab for additional details.
Check the realm page for the authenticating domain.
https://login.microsoftonline.com/GetUserRealm.srf?Login=user@contoso.com&xml=1
Expected responses:
AuthURL: Expected to show federation service logon page.
STSAuthURL: Expected to show HTTP 400
MEXURL: Expected to show long stream of XML data.

If any of these show the HTTP 503 Service Unavailable this confirms a consistent failure on the federation service.
If however you get the expected responses, this does not neccessarily mean the federation service / everything authentication is healthy.")]
        public string HTTP503FederatedSTSUnreachable {
            get {
                return ((string)(this["HTTP503FederatedSTSUnreachable"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://en.wikipedia.org/wiki/List_of_HTTP_status_codes")]
        public string HTTPStatusCodesURL {
            get {
                return ((string)(this["HTTPStatusCodesURL"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("HTTP 200: Errors found in response body. Check the Raw tab, click \'View in Notepa" +
            "d\' button bottom right, and search for error in the response to review.\r\n")]
        public string HTTP200ErrorsFound {
            get {
                return ((string)(this["HTTP200ErrorsFound"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("HTTP 401: Unauthorized. These are expected and are not an issue as long as a HTTP" +
            " 200 is seen for authentication to the server which issued the HTTP 401 unauthor" +
            "ized security challenge.")]
        public string HTTP401Unauthorized {
            get {
                return ((string)(this["HTTP401Unauthorized"]));
            }
            set {
                this["HTTP401Unauthorized"] = value;
            }
        }
    }
}
