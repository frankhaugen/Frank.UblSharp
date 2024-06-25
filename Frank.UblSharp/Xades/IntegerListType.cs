namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("IntegerListType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=true)]
public partial class IntegerListType
{
        
    private System.Collections.Generic.List<System.String> _int;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("int", DataType="integer", Order=0)]
    public string[] @__Int
    {
        get
        {
            return _int?.ToArray();
        }
        set
        {
            _int = value == null ? null : new System.Collections.Generic.List<System.String>(value);
        }
    }
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<System.String> Int
    {
        get { return _int ?? (_int = new System.Collections.Generic.List<System.String>()); }
        set { _int = value; }
    }

}