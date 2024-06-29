/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ChildConsignment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class ConsignmentType
{
    private ConsignmentType[] childConsignmentField;
    private PartyType consigneePartyField;
    private PartyType exporterPartyField;
    private PartyType consignorPartyField;
    private PartyType importerPartyField;
    private PartyType carrierPartyField;
    private PartyType freightForwarderPartyField;
    private PartyType notifyPartyField;
    private PartyType originalDespatchPartyField;
    private PartyType finalDeliveryPartyField;
    private PartyType performingCarrierPartyField;
    private PartyType substituteCarrierPartyField;
    private PartyType logisticsOperatorPartyField;
    private PartyType transportAdvisorPartyField;
    private PartyType hazardousItemNotificationPartyField;
    private PartyType insurancePartyField;
    private PartyType mortgageHolderPartyField;
    private PartyType billOfLadingHolderPartyField;
    private CountryType originalDepartureCountryField;
    private CountryType finalDestinationCountryField;
    private CountryType[] transitCountryField;
    private ContractType transportContractField;
    private TransportEventType[] transportEventField;
    private TransportationServiceType originalDespatchTransportationServiceField;
    private TransportationServiceType finalDeliveryTransportationServiceField;
    private DeliveryTermsType deliveryTermsField;
    private PaymentTermsType paymentTermsField;
    private PaymentTermsType collectPaymentTermsField;
    private PaymentTermsType disbursementPaymentTermsField;
    private PaymentTermsType prepaidPaymentTermsField;
    private AllowanceChargeType[] freightAllowanceChargeField;
    private AllowanceChargeType[] extraAllowanceChargeField;
    private ShipmentStageType[] mainCarriageShipmentStageField;
    private ShipmentStageType[] preCarriageShipmentStageField;
    private ShipmentStageType[] onCarriageShipmentStageField;
    private TransportHandlingUnitType[] transportHandlingUnitField;
    private LocationType1 firstArrivalPortLocationField;
    private LocationType1 lastExitPortLocationField;
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CarrierAssignedIDType CarrierAssignedID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConsigneeAssignedIDType ConsigneeAssignedID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConsignorAssignedIDType ConsignorAssignedID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FreightForwarderAssignedIDType FreightForwarderAssignedID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BrokerAssignedIDType BrokerAssignedID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ContractedCarrierAssignedIDType ContractedCarrierAssignedID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PerformingCarrierAssignedIDType PerformingCarrierAssignedID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SummaryDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SummaryDescriptionType[] SummaryDescription { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalInvoiceAmountType TotalInvoiceAmount { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DeclaredCustomsValueAmountType DeclaredCustomsValueAmount { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TariffDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TariffDescriptionType[] TariffDescription { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TariffCodeType TariffCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InsurancePremiumAmountType InsurancePremiumAmount { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public GrossWeightMeasureType GrossWeightMeasure { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NetWeightMeasureType NetWeightMeasure { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NetNetWeightMeasureType NetNetWeightMeasure { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ChargeableWeightMeasureType ChargeableWeightMeasure { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public GrossVolumeMeasureType GrossVolumeMeasure { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NetVolumeMeasureType NetVolumeMeasure { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LoadingLengthMeasureType LoadingLengthMeasure { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Remarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RemarksType[] Remarks { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HazardousRiskIndicatorType HazardousRiskIndicator { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AnimalFoodIndicatorType AnimalFoodIndicator { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HumanFoodIndicatorType HumanFoodIndicator { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LivestockIndicatorType LivestockIndicator { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BulkCargoIndicatorType BulkCargoIndicator { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ContainerizedIndicatorType ContainerizedIndicator { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public GeneralCargoIndicatorType GeneralCargoIndicator { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SpecialSecurityIndicatorType SpecialSecurityIndicator { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ThirdPartyPayerIndicatorType ThirdPartyPayerIndicator { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CarrierServiceInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CarrierServiceInstructionsType[] CarrierServiceInstructions { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CustomsClearanceServiceInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CustomsClearanceServiceInstructionsType[] CustomsClearanceServiceInstructions { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ForwarderServiceInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ForwarderServiceInstructionsType[] ForwarderServiceInstructions { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SpecialServiceInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SpecialServiceInstructionsType[] SpecialServiceInstructions { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SequenceIDType SequenceID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ShippingPriorityLevelCodeType ShippingPriorityLevelCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HandlingCodeType HandlingCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("HandlingInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HandlingInstructionsType[] HandlingInstructions { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Information", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InformationType[] Information { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalGoodsItemQuantityType TotalGoodsItemQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalTransportHandlingUnitQuantityType TotalTransportHandlingUnitQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InsuranceValueAmountType InsuranceValueAmount { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DeclaredForCarriageValueAmountType DeclaredForCarriageValueAmount { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DeclaredStatisticsValueAmountType DeclaredStatisticsValueAmount { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FreeOnBoardValueAmountType FreeOnBoardValueAmount { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SpecialInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SpecialInstructionsType[] SpecialInstructions { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SplitConsignmentIndicatorType SplitConsignmentIndicator { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DeliveryInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DeliveryInstructionsType[] DeliveryInstructions { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConsignmentQuantityType ConsignmentQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConsolidatableIndicatorType ConsolidatableIndicator { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("HaulageInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HaulageInstructionsType[] HaulageInstructions { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LoadingSequenceIDType LoadingSequenceID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ChildConsignmentQuantityType ChildConsignmentQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalPackagesQuantityType TotalPackagesQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ConsolidatedShipment")]
    public ShipmentType[] ConsolidatedShipment { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CustomsDeclaration")]
    public CustomsDeclarationType[] CustomsDeclaration { get; set; }

    /// <remarks/>
    public TransportEventType RequestedPickupTransportEvent { get; set; }

    /// <remarks/>
    public TransportEventType RequestedDeliveryTransportEvent { get; set; }

    /// <remarks/>
    public TransportEventType PlannedPickupTransportEvent { get; set; }

    /// <remarks/>
    public TransportEventType PlannedDeliveryTransportEvent { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Status")]
    public StatusType[] Status { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ChildConsignment")]
    public ConsignmentType[] ChildConsignment
    {
        get
        {
            return this.childConsignmentField;
        }

        set
        {
            this.childConsignmentField = value;
        }
    }

    /// <remarks/>
    public PartyType ConsigneeParty
    {
        get
        {
            return this.consigneePartyField;
        }

        set
        {
            this.consigneePartyField = value;
        }
    }

    /// <remarks/>
    public PartyType ExporterParty
    {
        get
        {
            return this.exporterPartyField;
        }

        set
        {
            this.exporterPartyField = value;
        }
    }

    /// <remarks/>
    public PartyType ConsignorParty
    {
        get
        {
            return this.consignorPartyField;
        }

        set
        {
            this.consignorPartyField = value;
        }
    }

    /// <remarks/>
    public PartyType ImporterParty
    {
        get
        {
            return this.importerPartyField;
        }

        set
        {
            this.importerPartyField = value;
        }
    }

    /// <remarks/>
    public PartyType CarrierParty
    {
        get
        {
            return this.carrierPartyField;
        }

        set
        {
            this.carrierPartyField = value;
        }
    }

    /// <remarks/>
    public PartyType FreightForwarderParty
    {
        get
        {
            return this.freightForwarderPartyField;
        }

        set
        {
            this.freightForwarderPartyField = value;
        }
    }

    /// <remarks/>
    public PartyType NotifyParty
    {
        get
        {
            return this.notifyPartyField;
        }

        set
        {
            this.notifyPartyField = value;
        }
    }

    /// <remarks/>
    public PartyType OriginalDespatchParty
    {
        get
        {
            return this.originalDespatchPartyField;
        }

        set
        {
            this.originalDespatchPartyField = value;
        }
    }

    /// <remarks/>
    public PartyType FinalDeliveryParty
    {
        get
        {
            return this.finalDeliveryPartyField;
        }

        set
        {
            this.finalDeliveryPartyField = value;
        }
    }

    /// <remarks/>
    public PartyType PerformingCarrierParty
    {
        get
        {
            return this.performingCarrierPartyField;
        }

        set
        {
            this.performingCarrierPartyField = value;
        }
    }

    /// <remarks/>
    public PartyType SubstituteCarrierParty
    {
        get
        {
            return this.substituteCarrierPartyField;
        }

        set
        {
            this.substituteCarrierPartyField = value;
        }
    }

    /// <remarks/>
    public PartyType LogisticsOperatorParty
    {
        get
        {
            return this.logisticsOperatorPartyField;
        }

        set
        {
            this.logisticsOperatorPartyField = value;
        }
    }

    /// <remarks/>
    public PartyType TransportAdvisorParty
    {
        get
        {
            return this.transportAdvisorPartyField;
        }

        set
        {
            this.transportAdvisorPartyField = value;
        }
    }

    /// <remarks/>
    public PartyType HazardousItemNotificationParty
    {
        get
        {
            return this.hazardousItemNotificationPartyField;
        }

        set
        {
            this.hazardousItemNotificationPartyField = value;
        }
    }

    /// <remarks/>
    public PartyType InsuranceParty
    {
        get
        {
            return this.insurancePartyField;
        }

        set
        {
            this.insurancePartyField = value;
        }
    }

    /// <remarks/>
    public PartyType MortgageHolderParty
    {
        get
        {
            return this.mortgageHolderPartyField;
        }

        set
        {
            this.mortgageHolderPartyField = value;
        }
    }

    /// <remarks/>
    public PartyType BillOfLadingHolderParty
    {
        get
        {
            return this.billOfLadingHolderPartyField;
        }

        set
        {
            this.billOfLadingHolderPartyField = value;
        }
    }

    /// <remarks/>
    public CountryType OriginalDepartureCountry
    {
        get
        {
            return this.originalDepartureCountryField;
        }

        set
        {
            this.originalDepartureCountryField = value;
        }
    }

    /// <remarks/>
    public CountryType FinalDestinationCountry
    {
        get
        {
            return this.finalDestinationCountryField;
        }

        set
        {
            this.finalDestinationCountryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TransitCountry")]
    public CountryType[] TransitCountry
    {
        get
        {
            return this.transitCountryField;
        }

        set
        {
            this.transitCountryField = value;
        }
    }

    /// <remarks/>
    public ContractType TransportContract
    {
        get
        {
            return this.transportContractField;
        }

        set
        {
            this.transportContractField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TransportEvent")]
    public TransportEventType[] TransportEvent
    {
        get
        {
            return this.transportEventField;
        }

        set
        {
            this.transportEventField = value;
        }
    }

    /// <remarks/>
    public TransportationServiceType OriginalDespatchTransportationService
    {
        get
        {
            return this.originalDespatchTransportationServiceField;
        }

        set
        {
            this.originalDespatchTransportationServiceField = value;
        }
    }

    /// <remarks/>
    public TransportationServiceType FinalDeliveryTransportationService
    {
        get
        {
            return this.finalDeliveryTransportationServiceField;
        }

        set
        {
            this.finalDeliveryTransportationServiceField = value;
        }
    }

    /// <remarks/>
    public DeliveryTermsType DeliveryTerms
    {
        get
        {
            return this.deliveryTermsField;
        }

        set
        {
            this.deliveryTermsField = value;
        }
    }

    /// <remarks/>
    public PaymentTermsType PaymentTerms
    {
        get
        {
            return this.paymentTermsField;
        }

        set
        {
            this.paymentTermsField = value;
        }
    }

    /// <remarks/>
    public PaymentTermsType CollectPaymentTerms
    {
        get
        {
            return this.collectPaymentTermsField;
        }

        set
        {
            this.collectPaymentTermsField = value;
        }
    }

    /// <remarks/>
    public PaymentTermsType DisbursementPaymentTerms
    {
        get
        {
            return this.disbursementPaymentTermsField;
        }

        set
        {
            this.disbursementPaymentTermsField = value;
        }
    }

    /// <remarks/>
    public PaymentTermsType PrepaidPaymentTerms
    {
        get
        {
            return this.prepaidPaymentTermsField;
        }

        set
        {
            this.prepaidPaymentTermsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FreightAllowanceCharge")]
    public AllowanceChargeType[] FreightAllowanceCharge
    {
        get
        {
            return this.freightAllowanceChargeField;
        }

        set
        {
            this.freightAllowanceChargeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ExtraAllowanceCharge")]
    public AllowanceChargeType[] ExtraAllowanceCharge
    {
        get
        {
            return this.extraAllowanceChargeField;
        }

        set
        {
            this.extraAllowanceChargeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("MainCarriageShipmentStage")]
    public ShipmentStageType[] MainCarriageShipmentStage
    {
        get
        {
            return this.mainCarriageShipmentStageField;
        }

        set
        {
            this.mainCarriageShipmentStageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PreCarriageShipmentStage")]
    public ShipmentStageType[] PreCarriageShipmentStage
    {
        get
        {
            return this.preCarriageShipmentStageField;
        }

        set
        {
            this.preCarriageShipmentStageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("OnCarriageShipmentStage")]
    public ShipmentStageType[] OnCarriageShipmentStage
    {
        get
        {
            return this.onCarriageShipmentStageField;
        }

        set
        {
            this.onCarriageShipmentStageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TransportHandlingUnit")]
    public TransportHandlingUnitType[] TransportHandlingUnit
    {
        get
        {
            return this.transportHandlingUnitField;
        }

        set
        {
            this.transportHandlingUnitField = value;
        }
    }

    /// <remarks/>
    public LocationType1 FirstArrivalPortLocation
    {
        get
        {
            return this.firstArrivalPortLocationField;
        }

        set
        {
            this.firstArrivalPortLocationField = value;
        }
    }

    /// <remarks/>
    public LocationType1 LastExitPortLocation
    {
        get
        {
            return this.lastExitPortLocationField;
        }

        set
        {
            this.lastExitPortLocationField = value;
        }
    }
}