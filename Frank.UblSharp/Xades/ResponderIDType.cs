namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ResponderIDType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=true)]
public partial class ResponderIDType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ByKey", typeof(byte[]), DataType="base64Binary", Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("ByName", typeof(string), Order=0)]
    public object @__Item;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public object Item
    {
        get
        {
            return __Item;
        }
        set
        {
            __Item = value;
        }
    }

}