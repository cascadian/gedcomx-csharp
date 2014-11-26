// <auto-generated>
// 
//
// Generated by <a href="http://enunciate.codehaus.org">Enunciate</a>.
// </auto-generated>
using System;

namespace Gx.Fs.Tree {

  /// <remarks>
  ///  Enumeration of the possible change object types.
  /// </remarks>
  /// <summary>
  ///  Enumeration of the possible change object types.
  /// </summary>
  public enum ChangeObjectType {

    /// <summary>
    ///  Unspecified enum value.
    /// </summary>
    [System.Xml.Serialization.XmlEnumAttribute(Name="__NULL__")]
    [System.Xml.Serialization.SoapEnumAttribute(Name="__NULL__")]
    NULL,

    /// <summary>
    ///   A person was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Person")]
    Person,

    /// <summary>
    ///   A couple relationship was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Couple")]
    Couple,

    /// <summary>
    ///   A child-and-parents relationship was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://familysearch.org/v1/ChildAndParentsRelationship")]
    ChildAndParentsRelationship,

    /// <summary>
    ///   The man in a couple relationship was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://familysearch.org/v1/Man")]
    Man,

    /// <summary>
    ///   The man in a couple relationship was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://familysearch.org/v1/Woman")]
    Woman,

    /// <summary>
    ///   The father in a couple-child relationship was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://familysearch.org/v1/Father")]
    Father,

    /// <summary>
    ///   The mother in a couple-child relationship was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://familysearch.org/v1/Mother")]
    Mother,

    /// <summary>
    ///   The child in a couple-child relationship was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://familysearch.org/v1/Child")]
    Child,

    /// <summary>
    ///   A source reference was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/SourceReference")]
    SourceReference,

    /// <summary>
    ///   A discussion reference was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://familysearch.org/v1/DiscussionReference")]
    DiscussionReference,

    /// <summary>
    ///   An evidence reference was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://familysearch.org/v1/EvidenceReference")]
    EvidenceReference,

    /// <summary>
    ///   An affiliation fact was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://familysearch.org/v1/Affiliation")]
    Affiliation,

    /// <summary>
    ///   An annulment fact was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Annulment")]
    Annulment,

    /// <summary>
    ///   A bar mitzvah was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/BarMitzvah")]
    BarMitzvah,

    /// <summary>
    ///   A bar mitzvah was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/BatMitzvah")]
    BatMitzvah,

    /// <summary>
    ///   A birth fact was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Birth")]
    Birth,

    /// <summary>
    ///   A burial fact was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Burial")]
    Burial,

    /// <summary>
    ///   A christening fact was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Christening")]
    Christening,

    /// <summary>
    ///   A cremation fact was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Cremation")]
    Cremation,

    /// <summary>
    ///   A common law marriage fact was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/CommonLawMarriage")]
    CommonLawMarriage,

    /// <summary>
    ///   A death fact was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Death")]
    Death,

    /// <summary>
    ///   A divorce fact was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Divorce")]
    Divorce,

    /// <summary>
    ///   A marriage fact was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Marriage")]
    Marriage,

    /// <summary>
    ///   A military service fact was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/MilitaryService")]
    MilitaryService,

    /// <summary>
    ///   A naturalization fact was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Naturalization")]
    Naturalization,

    /// <summary>
    ///   An occupation fact was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Occupation")]
    Occupation,

    /// <summary>
    ///   A religion fact was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Religion")]
    Religion,

    /// <summary>
    ///   A residence fact was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Residence")]
    Residence,

    /// <summary>
    ///   A stillbirth fact was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Stillbirth")]
    Stillbirth,

    /// <summary>
    ///   A fact was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Fact")]
    Fact,

    /// <summary>
    ///   A caste fact was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Caste")]
    Caste,

    /// <summary>
    ///   A clan fact was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Clan")]
    Clan,

    /// <summary>
    ///   A national id fact was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/NationalId")]
    NationalId,

    /// <summary>
    ///   A nationality fact was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Nationality")]
    Nationality,

    /// <summary>
    ///   A physical description fact was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/PhysicalDescription")]
    PhysicalDescription,

    /// <summary>
    ///   An ethnicity fact was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Ethnicity")]
    Ethnicity,

    /// <summary>
    ///   A gender was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Gender")]
    Gender,

    /// <summary>
    ///   A note was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Note")]
    Note,

    /// <summary>
    ///   Name was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Name")]
    Name,

    /// <summary>
    ///   A birth name was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/BirthName")]
    BirthName,

    /// <summary>
    ///   An AKA name was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/AlsoKnownAs")]
    AlsoKnownAs,

    /// <summary>
    ///   An married name was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/MarriedName")]
    MarriedName,

    /// <summary>
    ///   An nickname was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://gedcomx.org/Nickname")]
    Nickname,

    /// <summary>
    ///   A died before eight fact was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://familysearch.org/v1/DiedBeforeEight")]
    DiedBeforeEight,

    /// <summary>
    ///   A tribe name fact was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://familysearch.org/v1/TribeName")]
    TribeName,

    /// <summary>
    ///   A birth order fact was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://familysearch.org/v1/BirthOrder")]
    BirthOrder,

    /// <summary>
    ///   A life sketch was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://familysearch.org/v1/LifeSketch")]
    LifeSketch,

    /// <summary>
    ///   A living status was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://familysearch.org/v1/LivingStatus")]
    LivingStatus,

    /// <summary>
    ///   A title of nobility fact was changed.
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://familysearch.org/v1/TitleOfNobility")]
    TitleOfNobility,

    /// <summary>
    ///   A not-a-match declaration
    /// </summary>
    [System.Xml.Serialization.XmlEnum("http://familysearch.org/v1/NotAMatch")]
    NotAMatch
  }
}
