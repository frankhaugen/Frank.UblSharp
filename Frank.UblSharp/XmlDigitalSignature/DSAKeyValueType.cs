namespace Frank.UblSharp.XmlDigitalSignature;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("DSAKeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[System.Xml.Serialization.XmlRootAttribute("DSAKeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
public partial class DSAKeyValueType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("P", DataType="base64Binary")]
    public byte[] @__P;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Q", DataType="base64Binary")]
    public byte[] @__Q;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("G", DataType="base64Binary")]
    public byte[] @__G;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Y", DataType="base64Binary")]
    public byte[] @__Y;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("J", DataType="base64Binary")]
    public byte[] @__J;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Seed", DataType="base64Binary")]
    public byte[] @__Seed;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PgenCounter", DataType="base64Binary")]
    public byte[] @__PgenCounter;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public byte[] P
    {
        get
        {
            return __P;
        }
        set
        {
            __P = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public byte[] Q
    {
        get
        {
            return __Q;
        }
        set
        {
            __Q = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public byte[] G
    {
        get
        {
            return __G;
        }
        set
        {
            __G = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public byte[] Y
    {
        get
        {
            return __Y;
        }
        set
        {
            __Y = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public byte[] J
    {
        get
        {
            return __J;
        }
        set
        {
            __J = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public byte[] Seed
    {
        get
        {
            return __Seed;
        }
        set
        {
            __Seed = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public byte[] PgenCounter
    {
        get
        {
            return __PgenCounter;
        }
        set
        {
            __PgenCounter = value;
        }
    }

}