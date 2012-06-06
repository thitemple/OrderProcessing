namespace OrderProcessing.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://vintem.com.br/orderprocessing/schemas/2012-06",@"Order")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::OrderProcessing.Schemas.Total), XPath = @"/*[local-name()='Order' and namespace-uri()='http://vintem.com.br/orderprocessing/schemas/2012-06']/*[local-name()='Total' and namespace-uri()='http://vintem.com.br/orderprocessing/schemas/2012-06']", XsdType = @"decimal")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Decimal), "Total", XPath = @"/*[local-name()='Order' and namespace-uri()='http://vintem.com.br/orderprocessing/schemas/2012-06']/*[local-name()='Total' and namespace-uri()='http://vintem.com.br/orderprocessing/schemas/2012-06']", XsdType = @"decimal")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Order"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"OrderProcessing.Schemas.OrderProperties", typeof(global::OrderProcessing.Schemas.OrderProperties))]
    public sealed class Order : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://vintem.com.br/orderprocessing/schemas/2012-06"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://OrderProcessing.OrderProperties"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://vintem.com.br/orderprocessing/schemas/2012-06"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://OrderProcessing.OrderProperties"" location=""OrderProcessing.Schemas.OrderProperties"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Order"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:Total"" xpath=""/*[local-name()='Order' and namespace-uri()='http://vintem.com.br/orderprocessing/schemas/2012-06']/*[local-name()='Total' and namespace-uri()='http://vintem.com.br/orderprocessing/schemas/2012-06']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Order' and namespace-uri()='http://vintem.com.br/orderprocessing/schemas/2012-06']/*[local-name()='Total' and namespace-uri()='http://vintem.com.br/orderprocessing/schemas/2012-06']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""OrderId"" type=""xs:positiveInteger"" />
        <xs:element name=""CustomerName"" type=""xs:string"" />
        <xs:element name=""Date"" type=""xs:dateTime"" />
        <xs:element name=""Total"">
          <xs:simpleType>
            <xs:restriction base=""xs:decimal"">
              <xs:minInclusive value=""0"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Order() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Order";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
