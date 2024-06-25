namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("UnsignedDataObjectProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("UnsignedDataObjectProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class UnsignedDataObjectPropertiesType
{
        
    private System.Collections.Generic.List<AnyType> _unsignedDataObjectProperty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UnsignedDataObjectProperty", Order=0)]
    public AnyType[] @__UnsignedDataObjectProperty
    {
        get
        {
            return _unsignedDataObjectProperty?.ToArray();
        }
        set
        {
            _unsignedDataObjectProperty = value == null ? null : new System.Collections.Generic.List<AnyType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("Id", DataType="ID")]
    public string @__Id;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<AnyType> UnsignedDataObjectProperty
    {
        get { return _unsignedDataObjectProperty ?? (_unsignedDataObjectProperty = new System.Collections.Generic.List<AnyType>()); }
        set { _unsignedDataObjectProperty = value; }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Id
    {
        get
        {
            return __Id;
        }
        set
        {
            __Id = value;
        }
    }

}