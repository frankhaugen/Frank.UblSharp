/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("EmissionCalculationMethod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class EmissionCalculationMethodType
{
    private LocationType1 measurementFromLocationField;
    private LocationType1 measurementToLocationField;
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CalculationMethodCodeType CalculationMethodCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FullnessIndicationCodeType FullnessIndicationCode { get; set; }

    /// <remarks/>
    public LocationType1 MeasurementFromLocation
    {
        get
        {
            return this.measurementFromLocationField;
        }

        set
        {
            this.measurementFromLocationField = value;
        }
    }

    /// <remarks/>
    public LocationType1 MeasurementToLocation
    {
        get
        {
            return this.measurementToLocationField;
        }

        set
        {
            this.measurementToLocationField = value;
        }
    }
}