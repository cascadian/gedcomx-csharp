using Gedcomx.Model.Rt;
using Gedcomx.Model.Util;
using Gx.Types;
// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;

namespace Gx.Records
{

    /// <remarks>
    ///  An element representing a value in a record field.
    /// </remarks>
    /// <summary>
    ///  An element representing a value in a record field.
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gedcomx.org/v1/", TypeName = "FieldValue")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "http://gedcomx.org/v1/", TypeName = "FieldValue")]
    public sealed partial class FieldValue : Gx.Conclusion.Conclusion
    {

        private string _resource;
        private string _datatype;
        private string _type;
        private string _labelId;
        private string _text;
        /// <summary>
        ///  URI that resolves to the value of the field.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "resource")]
        [System.Xml.Serialization.SoapAttributeAttribute(AttributeName = "resource")]
        [Newtonsoft.Json.JsonProperty("resource")]
        public string Resource
        {
            get
            {
                return this._resource;
            }
            set
            {
                this._resource = value;
            }
        }
        /// <summary>
        ///  The datatype of the text value of the field.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "datatype")]
        [System.Xml.Serialization.SoapAttributeAttribute(AttributeName = "datatype")]
        [Newtonsoft.Json.JsonProperty("datatype")]
        public string Datatype
        {
            get
            {
                return this._datatype;
            }
            set
            {
                this._datatype = value;
            }
        }
        /// <summary>
        ///  The type of the field value.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "type")]
        [System.Xml.Serialization.SoapAttributeAttribute(AttributeName = "type")]
        [Newtonsoft.Json.JsonProperty("type")]
        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }

        /// <summary>
        ///  Convenience property for treating Type as an enum. See Gx.Types.FieldValueTypeQNameUtil for details on getter/setter functionality.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        [Newtonsoft.Json.JsonIgnore]
        public Gx.Types.FieldValueType KnownType
        {
            get
            {
                return XmlQNameEnumUtil.GetEnumValue<FieldValueType>(this._type);
            }
            set
            {
                this._type = XmlQNameEnumUtil.GetNameValue(value);
            }
        }
        /// <summary>
        ///  The id of the label applicable to this field value.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "labelId")]
        [System.Xml.Serialization.SoapAttributeAttribute(AttributeName = "labelId")]
        [Newtonsoft.Json.JsonProperty("labelId")]
        public string LabelId
        {
            get
            {
                return this._labelId;
            }
            set
            {
                this._labelId = value;
            }
        }
        /// <summary>
        ///  The text value.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "text", Namespace = "http://gedcomx.org/v1/")]
        [System.Xml.Serialization.SoapElementAttribute(ElementName = "text")]
        [Newtonsoft.Json.JsonProperty("text")]
        public string Text
        {
            get
            {
                return this._text;
            }
            set
            {
                this._text = value;
            }
        }

        /**
         * Accept a visitor.
         *
         * @param visitor The visitor to accept.
         */
        public void Accept(GedcomxModelVisitor visitor)
        {
            visitor.VisitFieldValue(this);
        }

        /**
         * Build out this field value with a type.
         *
         * @param type The type.
         * @return this.
         */
        public FieldValue SetType(String type)
        {
            Type = type;
            return this;
        }

        /**
         * Build out this field value with a type.
         *
         * @param type The type.
         * @return this.
         */
        public FieldValue SetType(FieldValueType type)
        {
            KnownType = type;
            return this;
        }

        /**
         * Build out this field value with a label id.
         *
         * @param labelId The label id.
         * @return this.
         */
        public FieldValue SetLabelId(String labelId)
        {
            LabelId = labelId;
            return this;
        }

        /**
         * Build out this field value with text.
         * @param text the text.
         * @return this.
         */
        public FieldValue SetText(String text)
        {
            Text = text;
            return this;
        }

        /**
         * Build out this field value with a data type.
         * @param datatype The data type.
         * @return this
         */
        public FieldValue SetDatatype(String datatype)
        {
            Datatype = datatype;
            return this;
        }

        /**
         * Build out this field value with a resource.
         * @param resource The resource.
         * @return this.
         */
        public FieldValue SetResource(String resource)
        {
            Resource = resource;
            return this;
        }
    }
}
