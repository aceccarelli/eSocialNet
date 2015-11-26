// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

// 
//This source code was auto-generated by MonoXSD
//
namespace Schemas {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("Signature", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
    public partial class SignatureType {
        
        private SignedInfoType signedInfoField;
        
        private SignatureValueType signatureValueField;
        
        private KeyInfoType keyInfoField;
        
        private string idField;
        
        /// <remarks/>
        public SignedInfoType SignedInfo {
            get {
                return this.signedInfoField;
            }
            set {
                this.signedInfoField = value;
            }
        }
        
        /// <remarks/>
        public SignatureValueType SignatureValue {
            get {
                return this.signatureValueField;
            }
            set {
                this.signatureValueField = value;
            }
        }
        
        /// <remarks/>
        public KeyInfoType KeyInfo {
            get {
                return this.keyInfoField;
            }
            set {
                this.keyInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoType {
        
        private SignedInfoTypeCanonicalizationMethod canonicalizationMethodField;
        
        private SignedInfoTypeSignatureMethod signatureMethodField;
        
        private ReferenceType referenceField;
        
        private string idField;
        
        /// <remarks/>
        public SignedInfoTypeCanonicalizationMethod CanonicalizationMethod {
            get {
                return this.canonicalizationMethodField;
            }
            set {
                this.canonicalizationMethodField = value;
            }
        }
        
        /// <remarks/>
        public SignedInfoTypeSignatureMethod SignatureMethod {
            get {
                return this.signatureMethodField;
            }
            set {
                this.signatureMethodField = value;
            }
        }
        
        /// <remarks/>
        public ReferenceType Reference {
            get {
                return this.referenceField;
            }
            set {
                this.referenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoTypeCanonicalizationMethod {
        
        private string algorithmField;
        
        public SignedInfoTypeCanonicalizationMethod() {
            this.algorithmField = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Algorithm {
            get {
                return this.algorithmField;
            }
            set {
                this.algorithmField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.esocial.gov.br/schema/evt/evtAfastTemp/v02_01_00")]
    public partial class TIdeVinculoEstag {
        
        private string cpfTrabField;
        
        private string nisTrabField;
        
        private string matriculaField;
        
        /// <remarks/>
        public string cpfTrab {
            get {
                return this.cpfTrabField;
            }
            set {
                this.cpfTrabField = value;
            }
        }
        
        /// <remarks/>
        public string nisTrab {
            get {
                return this.nisTrabField;
            }
            set {
                this.nisTrabField = value;
            }
        }
        
        /// <remarks/>
        public string matricula {
            get {
                return this.matriculaField;
            }
            set {
                this.matriculaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.esocial.gov.br/schema/evt/evtAfastTemp/v02_01_00")]
    public partial class TEmpregador {
        
        private sbyte tpInscField;
        
        private string nrInscField;
        
        /// <remarks/>
        public sbyte tpInsc {
            get {
                return this.tpInscField;
            }
            set {
                this.tpInscField = value;
            }
        }
        
        /// <remarks/>
        public string nrInsc {
            get {
                return this.nrInscField;
            }
            set {
                this.nrInscField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.esocial.gov.br/schema/evt/evtAfastTemp/v02_01_00")]
    public partial class TIdeEveTrab {
        
        private sbyte indRetifField;
        
        private string nrReciboField;
        
        private sbyte tpAmbField;
        
        private sbyte procEmiField;
        
        private string verProcField;
        
        /// <remarks/>
        public sbyte indRetif {
            get {
                return this.indRetifField;
            }
            set {
                this.indRetifField = value;
            }
        }
        
        /// <remarks/>
        public string nrRecibo {
            get {
                return this.nrReciboField;
            }
            set {
                this.nrReciboField = value;
            }
        }
        
        /// <remarks/>
        public sbyte tpAmb {
            get {
                return this.tpAmbField;
            }
            set {
                this.tpAmbField = value;
            }
        }
        
        /// <remarks/>
        public sbyte procEmi {
            get {
                return this.procEmiField;
            }
            set {
                this.procEmiField = value;
            }
        }
        
        /// <remarks/>
        public string verProc {
            get {
                return this.verProcField;
            }
            set {
                this.verProcField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class X509DataType {
        
        private byte[] x509CertificateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] X509Certificate {
            get {
                return this.x509CertificateField;
            }
            set {
                this.x509CertificateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class KeyInfoType {
        
        private X509DataType x509DataField;
        
        private string idField;
        
        /// <remarks/>
        public X509DataType X509Data {
            get {
                return this.x509DataField;
            }
            set {
                this.x509DataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureValueType {
        
        private string idField;
        
        private byte[] valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType="base64Binary")]
        public byte[] Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class TransformType {
        
        private string[] xPathField;
        
        private TTransformURI algorithmField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("XPath")]
        public string[] XPath {
            get {
                return this.xPathField;
            }
            set {
                this.xPathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TTransformURI Algorithm {
            get {
                return this.algorithmField;
            }
            set {
                this.algorithmField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public enum TTransformURI {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.w3.org/2000/09/xmldsig#enveloped-signature")]
        httpwwww3org200009xmldsigenvelopedsignature,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.w3.org/TR/2001/REC-xml-c14n-20010315")]
        httpwwww3orgTR2001RECxmlc14n20010315,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class ReferenceType {
        
        private TransformType[] transformsField;
        
        private ReferenceTypeDigestMethod digestMethodField;
        
        private byte[] digestValueField;
        
        private string idField;
        
        private string uRIField;
        
        private string typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable=false)]
        public TransformType[] Transforms {
            get {
                return this.transformsField;
            }
            set {
                this.transformsField = value;
            }
        }
        
        /// <remarks/>
        public ReferenceTypeDigestMethod DigestMethod {
            get {
                return this.digestMethodField;
            }
            set {
                this.digestMethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] DigestValue {
            get {
                return this.digestValueField;
            }
            set {
                this.digestValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string URI {
            get {
                return this.uRIField;
            }
            set {
                this.uRIField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class ReferenceTypeDigestMethod {
        
        private string algorithmField;
        
        public ReferenceTypeDigestMethod() {
            this.algorithmField = "http://www.w3.org/2000/09/xmldsig#sha1";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Algorithm {
            get {
                return this.algorithmField;
            }
            set {
                this.algorithmField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoTypeSignatureMethod {
        
        private string algorithmField;
        
        public SignedInfoTypeSignatureMethod() {
            this.algorithmField = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Algorithm {
            get {
                return this.algorithmField;
            }
            set {
                this.algorithmField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtAfastTemp/v02_01_00")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.esocial.gov.br/schema/evt/evtAfastTemp/v02_01_00", IsNullable=false)]
    public partial class eSocial {
        
        private eSocialEvtAfastTemp evtAfastTempField;
        
        private SignatureType signatureField;
        
        /// <remarks/>
        public eSocialEvtAfastTemp evtAfastTemp {
            get {
                return this.evtAfastTempField;
            }
            set {
                this.evtAfastTempField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature {
            get {
                return this.signatureField;
            }
            set {
                this.signatureField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtAfastTemp/v02_01_00")]
    public partial class eSocialEvtAfastTemp {
        
        private TIdeEveTrab ideEventoField;
        
        private TEmpregador ideEmpregadorField;
        
        private TIdeVinculoEstag ideVinculoField;
        
        private eSocialEvtAfastTempInfoAfastamento infoAfastamentoField;
        
        private string idField;
        
        /// <remarks/>
        public TIdeEveTrab ideEvento {
            get {
                return this.ideEventoField;
            }
            set {
                this.ideEventoField = value;
            }
        }
        
        /// <remarks/>
        public TEmpregador ideEmpregador {
            get {
                return this.ideEmpregadorField;
            }
            set {
                this.ideEmpregadorField = value;
            }
        }
        
        /// <remarks/>
        public TIdeVinculoEstag ideVinculo {
            get {
                return this.ideVinculoField;
            }
            set {
                this.ideVinculoField = value;
            }
        }
        
        /// <remarks/>
        public eSocialEvtAfastTempInfoAfastamento infoAfastamento {
            get {
                return this.infoAfastamentoField;
            }
            set {
                this.infoAfastamentoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtAfastTemp/v02_01_00")]
    public partial class eSocialEvtAfastTempInfoAfastamento {
        
        private eSocialEvtAfastTempInfoAfastamentoIniAfastamento iniAfastamentoField;
        
        private eSocialEvtAfastTempInfoAfastamentoAltAfastamento altAfastamentoField;
        
        private eSocialEvtAfastTempInfoAfastamentoFimAfastamento fimAfastamentoField;
        
        /// <remarks/>
        public eSocialEvtAfastTempInfoAfastamentoIniAfastamento iniAfastamento {
            get {
                return this.iniAfastamentoField;
            }
            set {
                this.iniAfastamentoField = value;
            }
        }
        
        /// <remarks/>
        public eSocialEvtAfastTempInfoAfastamentoAltAfastamento altAfastamento {
            get {
                return this.altAfastamentoField;
            }
            set {
                this.altAfastamentoField = value;
            }
        }
        
        /// <remarks/>
        public eSocialEvtAfastTempInfoAfastamentoFimAfastamento fimAfastamento {
            get {
                return this.fimAfastamentoField;
            }
            set {
                this.fimAfastamentoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtAfastTemp/v02_01_00")]
    public partial class eSocialEvtAfastTempInfoAfastamentoIniAfastamento {
        
        private System.DateTime dtIniAfastField;
        
        private string codMotAfastField;
        
        private sbyte tpAcidTransitoField;
        
        private bool tpAcidTransitoFieldSpecified;
        
        private string observacaoField;
        
        private eSocialEvtAfastTempInfoAfastamentoIniAfastamentoInfoAtestado infoAtestadoField;
        
        private eSocialEvtAfastTempInfoAfastamentoIniAfastamentoInfoCessao infoCessaoField;
        
        private eSocialEvtAfastTempInfoAfastamentoIniAfastamentoInfoMandSind infoMandSindField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime dtIniAfast {
            get {
                return this.dtIniAfastField;
            }
            set {
                this.dtIniAfastField = value;
            }
        }
        
        /// <remarks/>
        public string codMotAfast {
            get {
                return this.codMotAfastField;
            }
            set {
                this.codMotAfastField = value;
            }
        }
        
        /// <remarks/>
        public sbyte tpAcidTransito {
            get {
                return this.tpAcidTransitoField;
            }
            set {
                this.tpAcidTransitoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tpAcidTransitoSpecified {
            get {
                return this.tpAcidTransitoFieldSpecified;
            }
            set {
                this.tpAcidTransitoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string observacao {
            get {
                return this.observacaoField;
            }
            set {
                this.observacaoField = value;
            }
        }
        
        /// <remarks/>
        public eSocialEvtAfastTempInfoAfastamentoIniAfastamentoInfoAtestado infoAtestado {
            get {
                return this.infoAtestadoField;
            }
            set {
                this.infoAtestadoField = value;
            }
        }
        
        /// <remarks/>
        public eSocialEvtAfastTempInfoAfastamentoIniAfastamentoInfoCessao infoCessao {
            get {
                return this.infoCessaoField;
            }
            set {
                this.infoCessaoField = value;
            }
        }
        
        /// <remarks/>
        public eSocialEvtAfastTempInfoAfastamentoIniAfastamentoInfoMandSind infoMandSind {
            get {
                return this.infoMandSindField;
            }
            set {
                this.infoMandSindField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtAfastTemp/v02_01_00")]
    public partial class eSocialEvtAfastTempInfoAfastamentoIniAfastamentoInfoAtestado {
        
        private string codCIDField;
        
        private string qtdDiasAfastField;
        
        private eSocialEvtAfastTempInfoAfastamentoIniAfastamentoInfoAtestadoEmitente emitenteField;
        
        /// <remarks/>
        public string codCID {
            get {
                return this.codCIDField;
            }
            set {
                this.codCIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
        public string qtdDiasAfast {
            get {
                return this.qtdDiasAfastField;
            }
            set {
                this.qtdDiasAfastField = value;
            }
        }
        
        /// <remarks/>
        public eSocialEvtAfastTempInfoAfastamentoIniAfastamentoInfoAtestadoEmitente emitente {
            get {
                return this.emitenteField;
            }
            set {
                this.emitenteField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtAfastTemp/v02_01_00")]
    public partial class eSocialEvtAfastTempInfoAfastamentoIniAfastamentoInfoAtestadoEmitente {
        
        private string nmEmitField;
        
        private sbyte ideOCField;
        
        private string nrOcField;
        
        private string ufOCField;
        
        /// <remarks/>
        public string nmEmit {
            get {
                return this.nmEmitField;
            }
            set {
                this.nmEmitField = value;
            }
        }
        
        /// <remarks/>
        public sbyte ideOC {
            get {
                return this.ideOCField;
            }
            set {
                this.ideOCField = value;
            }
        }
        
        /// <remarks/>
        public string nrOc {
            get {
                return this.nrOcField;
            }
            set {
                this.nrOcField = value;
            }
        }
        
        /// <remarks/>
        public string ufOC {
            get {
                return this.ufOCField;
            }
            set {
                this.ufOCField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtAfastTemp/v02_01_00")]
    public partial class eSocialEvtAfastTempInfoAfastamentoIniAfastamentoInfoCessao {
        
        private string cnpjCessField;
        
        private sbyte infOnusField;
        
        /// <remarks/>
        public string cnpjCess {
            get {
                return this.cnpjCessField;
            }
            set {
                this.cnpjCessField = value;
            }
        }
        
        /// <remarks/>
        public sbyte infOnus {
            get {
                return this.infOnusField;
            }
            set {
                this.infOnusField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtAfastTemp/v02_01_00")]
    public partial class eSocialEvtAfastTempInfoAfastamentoIniAfastamentoInfoMandSind {
        
        private string cnpjSindField;
        
        private sbyte infOnusRemunField;
        
        /// <remarks/>
        public string cnpjSind {
            get {
                return this.cnpjSindField;
            }
            set {
                this.cnpjSindField = value;
            }
        }
        
        /// <remarks/>
        public sbyte infOnusRemun {
            get {
                return this.infOnusRemunField;
            }
            set {
                this.infOnusRemunField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtAfastTemp/v02_01_00")]
    public partial class eSocialEvtAfastTempInfoAfastamentoAltAfastamento {
        
        private System.DateTime dtAltMotField;
        
        private string codMotAntField;
        
        private string codMotAfastField;
        
        private eSocialEvtAfastTempInfoAfastamentoAltAfastamentoIndEfRetroativo indEfRetroativoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime dtAltMot {
            get {
                return this.dtAltMotField;
            }
            set {
                this.dtAltMotField = value;
            }
        }
        
        /// <remarks/>
        public string codMotAnt {
            get {
                return this.codMotAntField;
            }
            set {
                this.codMotAntField = value;
            }
        }
        
        /// <remarks/>
        public string codMotAfast {
            get {
                return this.codMotAfastField;
            }
            set {
                this.codMotAfastField = value;
            }
        }
        
        /// <remarks/>
        public eSocialEvtAfastTempInfoAfastamentoAltAfastamentoIndEfRetroativo indEfRetroativo {
            get {
                return this.indEfRetroativoField;
            }
            set {
                this.indEfRetroativoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtAfastTemp/v02_01_00")]
    public enum eSocialEvtAfastTempInfoAfastamentoAltAfastamentoIndEfRetroativo {
        
        /// <remarks/>
        S,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtAfastTemp/v02_01_00")]
    public partial class eSocialEvtAfastTempInfoAfastamentoFimAfastamento {
        
        private System.DateTime dtTermAfastField;
        
        private string codMotAfastField;
        
        private string observacaoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime dtTermAfast {
            get {
                return this.dtTermAfastField;
            }
            set {
                this.dtTermAfastField = value;
            }
        }
        
        /// <remarks/>
        public string codMotAfast {
            get {
                return this.codMotAfastField;
            }
            set {
                this.codMotAfastField = value;
            }
        }
        
        /// <remarks/>
        public string observacao {
            get {
                return this.observacaoField;
            }
            set {
                this.observacaoField = value;
            }
        }
    }
}
