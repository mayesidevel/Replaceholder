﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Config {
    
    private Content[] contentField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Content")]
    public Content[] Content {
        get {
            return this.contentField;
        }
        set {
            this.contentField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class Content {
    
    private string valueField;
    
    private DataTypeValue dataTypeField;
    
    private string keyNameField;
    
    private bool criticalField;
    
    private bool criticalFieldSpecified;
    
    /// <remarks/>
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public DataTypeValue DataType {
        get {
            return this.dataTypeField;
        }
        set {
            this.dataTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string KeyName {
        get {
            return this.keyNameField;
        }
        set {
            this.keyNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Critical {
        get {
            return this.criticalField;
        }
        set {
            this.criticalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CriticalSpecified {
        get {
            return this.criticalFieldSpecified;
        }
        set {
            this.criticalFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
public enum DataTypeValue {
    
    /// <remarks/>
    Text,
    
    /// <remarks/>
    Path,
    
    /// <remarks/>
    Placeholder,
}
