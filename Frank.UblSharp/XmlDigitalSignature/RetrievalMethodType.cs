namespace Frank.UblSharp.XmlDigitalSignature;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("RetrievalMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[System.Xml.Serialization.XmlRootAttribute("RetrievalMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
public partial class RetrievalMethodType
{
        
    private System.Collections.Generic.List<TransformType> _transforms;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlArrayAttribute("Transforms", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable=false)]
    public TransformType[] @__Transforms
    {
        get
        {
            return _transforms?.ToArray();
        }
        set
        {
            _transforms = value == null ? null : new System.Collections.Generic.List<TransformType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("URI", DataType="anyURI")]
    public string @__URI;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("Type", DataType="anyURI")]
    public string @__Type;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TransformType> Transforms
    {
        get { return _transforms ?? (_transforms = new System.Collections.Generic.List<TransformType>()); }
        set { _transforms = value; }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string URI
    {
        get
        {
            return __URI;
        }
        set
        {
            __URI = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Type
    {
        get
        {
            return __Type;
        }
        set
        {
            __Type = value;
        }
    }

}