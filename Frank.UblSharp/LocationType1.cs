/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName = "LocationType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ActivityFinalLocation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class LocationType1
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Conditions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConditionsType[] Conditions { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CountrySubentityType CountrySubentity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CountrySubentityCodeType CountrySubentityCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LocationTypeCodeType LocationTypeCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InformationURIType InformationURI { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NameType1 Name { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ValidityPeriod")]
    public PeriodType[] ValidityPeriod { get; set; }

    /// <remarks/>
    public AddressType Address { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SubsidiaryLocation")]
    public LocationType1[] SubsidiaryLocation { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("LocationCoordinate")]
    public LocationCoordinateType[] LocationCoordinate { get; set; }
}