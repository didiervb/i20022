
//                                      ______    ____   
//                                     |____  | "|__  |  
//                                      _   | |     | |  
//                                     | |  | |   __| |  
//                                     |_|  |_|  |_____| 
//                                                       
//  ---------------------------------------------------  
// |     _   ____     ___     ___    ____    ____      | 
// |    (_) |___ \   / _ \   / _ \  |___ \  |___ \     | 
// |    | |   __) | | | | | | | | |   __) |   __) |    | 
// |    | |  / __/  | |_| | | |_| |  / __/   / __/     | 
// |    |_| |_____|  \___/   \___/  |_____| |_____|    | 
// |                                                   | 
// |    AN ISO 20022 OPEN-SOURCE .NET CLASS LIBRARY    | 
// |            FOR MESSAGING APPLICATIONS             | 
// |                                                   | 
// |        Copyright (C) 2008 Mauricio Leventer       | 
// |                mleventer@i20022.com               | 
// |                                                   | 
//  ---------------------------------------------------  
//                                                       
// L I C E N S E                                         
//                                                       
// This program is free software; you can redistribute it
// and/or modify it under the terms of the GNU General   
// Public License as published by the Free Software      
// Foundation; either version 2 of the License, or (at   
// your option) any later version.                       
//                                                       
// This program is distributed in the hope that it will  
// be useful, but WITHOUT ANY WARRANTY; without even the 
// implied warranty of MERCHANTABILITY or FITNESS FOR A  
// PARTICULAR PURPOSE. See the GNU General Public License
// for more details.                                     
//                                                       
// You should have received a copy of the GNU General    
// Public License along with this program; if not, write 
// to the Free Software Foundation, Inc.,                
// 59 Temple Place, Suite 330, Boston, MA                
// 02111-1307 USA.                                       
//
//
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml.Serialization;



namespace i20022.setr05700101
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id setr.057.001.01 name OrderConfirmationStatusReportV01 from Securities Trade business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.01")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.01", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>OrdrConfStsRptV01</b> (Order Confirmation Status Report V01) of type OrderConfirmationStatusReportV01.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public OrderConfirmationStatusReportV01 OrdrConfStsRptV01;
    }
    
    /// <summary>
    /// Class <b>OrderConfirmationStatusReportV01</b> (Order Confirmation Status Report V01).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.01")]
    public class OrderConfirmationStatusReportV01
    {
        
        /// <summary>
        /// Element <b>MsgId</b> (Message Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public MessageIdentification1 MsgId;
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of AdditionalReference3.
        /// </summary>
        [XmlElementAttribute("OthrRef", typeof(AdditionalReference3), Order=1)]
        [XmlElementAttribute("RltdRef", typeof(AdditionalReference3), Order=1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public AdditionalReference3[] Items;
        
        /// <summary>
        /// Element <b>ItemsElementName</b> (Items Element Name) of type array of ItemsChoiceType.
        /// </summary>
        [XmlElementAttribute("ItemsElementName", Order=2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName;
        
        /// <summary>
        /// Element <b>IndvOrdrConfDtlsRpt</b> (Individual Order Confirmation Details Report) of type array of IndividualOrderConfirmationStatusAndReason1.
        /// </summary>
        [XmlElementAttribute("IndvOrdrConfDtlsRpt", Order=3)]
        public IndividualOrderConfirmationStatusAndReason1[] IndvOrdrConfDtlsRpt;
        
        /// <summary>
        /// Element <b>Xtnsn</b> (Extension) of type array of Extension1.
        /// </summary>
        [XmlElementAttribute("Xtnsn", Order=4)]
        public Extension1[] Xtnsn;
    }
    
    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.01")]
    public class MessageIdentification1
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>CreDtTm</b> (Creation Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public System.DateTime CreDtTm;
    }
    
    /// <summary>
    /// Class <b>Extension1</b> (Extension 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.01")]
    public class Extension1
    {
        
        /// <summary>
        /// Element <b>PlcAndNm</b> (Place And Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string PlcAndNm;
        
        /// <summary>
        /// Element <b>Txt</b> (Text) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Txt;
    }
    
    /// <summary>
    /// Class <b>AlternateSecurityIdentification1</b> (Alternate Security Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.01")]
    public class AlternateSecurityIdentification1
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute("DmstIdSrc", typeof(string), Order=1)]
        [XmlElementAttribute("PrtryIdSrc", typeof(string), Order=1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType</b> (Item Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType
    {
        
        /// <summary>
        /// <b>DmstIdSrc - Domestic Identification Source</b>.
        /// </summary>
        DmstIdSrc,
        
        /// <summary>
        /// <b>PrtryIdSrc - Proprietary Identification Source</b>.
        /// </summary>
        PrtryIdSrc,
    }
    
    /// <summary>
    /// Class <b>SecurityIdentification3Choice</b> (Security Identification 3Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.01")]
    public class SecurityIdentification3Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Belgn (Belgian) of type string 
        /// Blmbrg (Bloomberg) of type string 
        /// CTA (CTA) of type string 
        /// CUSIP (CUSIP) of type string 
        /// Cmon (Common) of type string 
        /// Dtch (Dutch) of type string 
        /// ISIN (ISIN) of type string 
        /// OthrPrtryId (Other Proprietary Identification) of type AlternateSecurityIdentification1 
        /// QUICK (QUICK) of type string 
        /// RIC (RIC) of type string 
        /// SCVM (Sicovam) of type string 
        /// SEDOL (SEDOL) of type string 
        /// TckrSymb (Ticker Symbol) of type string 
        /// Vlrn (Valoren) of type string 
        /// Wrtppr (Wertpapier) of type string 
        /// </summary>
        [XmlElementAttribute("Belgn", typeof(string), Order=0)]
        [XmlElementAttribute("Blmbrg", typeof(string), Order=0)]
        [XmlElementAttribute("CTA", typeof(string), Order=0)]
        [XmlElementAttribute("CUSIP", typeof(string), Order=0)]
        [XmlElementAttribute("Cmon", typeof(string), Order=0)]
        [XmlElementAttribute("Dtch", typeof(string), Order=0)]
        [XmlElementAttribute("ISIN", typeof(string), Order=0)]
        [XmlElementAttribute("OthrPrtryId", typeof(AlternateSecurityIdentification1), Order=0)]
        [XmlElementAttribute("QUICK", typeof(string), Order=0)]
        [XmlElementAttribute("RIC", typeof(string), Order=0)]
        [XmlElementAttribute("SCVM", typeof(string), Order=0)]
        [XmlElementAttribute("SEDOL", typeof(string), Order=0)]
        [XmlElementAttribute("TckrSymb", typeof(string), Order=0)]
        [XmlElementAttribute("Vlrn", typeof(string), Order=0)]
        [XmlElementAttribute("Wrtppr", typeof(string), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType1</b> (Item Choice Type 1).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.01", IncludeInSchema=false)]
    public enum ItemChoiceType1
    {
        
        /// <summary>
        /// <b>Belgn - Belgiam</b>.
        /// </summary>
        Belgn,
        
        /// <summary>
        /// <b>Blmbrg - Bloomberg Symbol</b>.
        /// </summary>
        Blmbrg,
        
        /// <summary>
        /// <b>CTA - Consolidated Tape Association</b>.
        /// </summary>
        CTA,
        
        /// <summary>
        /// <b>CUSIP - Committee on Uniform Security Identification Procedures</b>.
        /// </summary>
        CUSIP,
        
        /// <summary>
        /// <b>Cmon - Common</b>.
        /// </summary>
        Cmon,
        
        /// <summary>
        /// <b>Dtch - Dutch</b>.
        /// </summary>
        Dtch,
        
        /// <summary>
        /// <b>ISIN - International Securities Identification Number</b>.
        /// </summary>
        ISIN,
        
        /// <summary>
        /// <b>OthrPrtryId - Other Proprietary Identification</b>.
        /// </summary>
        OthrPrtryId,
        
        /// <summary>
        /// <b>QUICK - QUICK Security Id</b>.
        /// </summary>
        QUICK,
        
        /// <summary>
        /// <b>RIC - RIC Security Id</b>.
        /// </summary>
        RIC,
        
        /// <summary>
        /// <b>SCVM - Sicovam</b>.
        /// </summary>
        SCVM,
        
        /// <summary>
        /// <b>SEDOL - Stock Exchange Daily Official List</b>.
        /// </summary>
        SEDOL,
        
        /// <summary>
        /// <b>TckrSymb - Ticker Symbol</b>.
        /// </summary>
        TckrSymb,
        
        /// <summary>
        /// <b>Vlrn - Valoren</b>.
        /// </summary>
        Vlrn,
        
        /// <summary>
        /// <b>Wrtppr - Wertpapier</b>.
        /// </summary>
        Wrtppr,
    }
    
    /// <summary>
    /// Class <b>FinancialInstrument10</b> (Financial Instrument 10).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.01")]
    public class FinancialInstrument10
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type SecurityIdentification3Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public SecurityIdentification3Choice Id;
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Nm;
        
        /// <summary>
        /// Element <b>SplmtryId</b> (Supplementary Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string SplmtryId;
        
        /// <summary>
        /// Element <b>ClssTp</b> (Class Type) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string ClssTp;
        
        /// <summary>
        /// Element <b>SctiesForm</b> (Securities Form) of type FormOfSecurity1Code.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public FormOfSecurity1Code SctiesForm;
        
        /// <summary>
        /// Element <b>SctiesFormSpecified</b> (Securities Form Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SctiesFormSpecified;
        
        /// <summary>
        /// Element <b>DstrbtnPlcy</b> (Distribution Policy) of type DistributionPolicy1Code.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public DistributionPolicy1Code DstrbtnPlcy;
        
        /// <summary>
        /// Element <b>DstrbtnPlcySpecified</b> (Distribution Policy Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DstrbtnPlcySpecified;
        
        /// <summary>
        /// Element <b>PdctGrp</b> (Product Group) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string PdctGrp;
    }
    
    /// <summary>
    /// Enumeration <b>FormOfSecurity1Code</b> (Form Of Security 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.01")]
    public enum FormOfSecurity1Code
    {
        
        /// <summary>
        /// <b>BEAR - Bearer Share Exchange</b>.
        /// </summary>
        BEAR,
        
        /// <summary>
        /// <b>REGD - Registered / Registered Share Exchange</b>.
        /// </summary>
        REGD,
    }
    
    /// <summary>
    /// Enumeration <b>DistributionPolicy1Code</b> (Distribution Policy 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.01")]
    public enum DistributionPolicy1Code
    {
        
        /// <summary>
        /// <b>DIST - Distribution</b>.
        /// </summary>
        DIST,
        
        /// <summary>
        /// <b>ACCU - Accumulation</b>.
        /// </summary>
        ACCU,
    }
    
    /// <summary>
    /// Class <b>SimpleIdentificationInformation</b> (Simple Identification Information).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.01")]
    public class SimpleIdentificationInformation
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
    }
    
    /// <summary>
    /// Class <b>AccountIdentification1</b> (Account Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.01")]
    public class AccountIdentification1
    {
        
        /// <summary>
        /// Element <b>Prtry</b> (Proprietary) of type SimpleIdentificationInformation.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public SimpleIdentificationInformation Prtry;
    }
    
    /// <summary>
    /// Class <b>InvestmentAccount13</b> (Investment Account 13).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.01")]
    public class InvestmentAccount13
    {
        
        /// <summary>
        /// Element <b>AcctId</b> (Account Identification) of type AccountIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AccountIdentification1 AcctId;
        
        /// <summary>
        /// Element <b>AcctNm</b> (Account Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AcctNm;
        
        /// <summary>
        /// Element <b>AcctDsgnt</b> (Account Designation) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string AcctDsgnt;
        
        /// <summary>
        /// Element <b>OwnrId</b> (Owner Identification) of type array of PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute("OwnrId", Order=3)]
        public PartyIdentification2Choice[] OwnrId;
        
        /// <summary>
        /// Element <b>AcctSvcr</b> (Account Servicer) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public PartyIdentification2Choice AcctSvcr;
    }
    
    /// <summary>
    /// Class <b>PartyIdentification2Choice</b> (Party Identification 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.01")]
    public class PartyIdentification2Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// BICOrBEI (BIC Or BEI) of type string 
        /// NmAndAdr (Name And Address) of type NameAndAddress5 
        /// PrtryId (Proprietary Identification) of type GenericIdentification1 
        /// </summary>
        [XmlElementAttribute("BICOrBEI", typeof(string), Order=0)]
        [XmlElementAttribute("NmAndAdr", typeof(NameAndAddress5), Order=0)]
        [XmlElementAttribute("PrtryId", typeof(GenericIdentification1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>NameAndAddress5</b> (Name And Address 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.01")]
    public class NameAndAddress5
    {
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Nm;
        
        /// <summary>
        /// Element <b>Adr</b> (Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PostalAddress1 Adr;
    }
    
    /// <summary>
    /// Class <b>PostalAddress1</b> (Postal Address 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.01")]
    public class PostalAddress1
    {
        
        /// <summary>
        /// Element <b>AdrTp</b> (Address Type) of type AddressType2Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AddressType2Code AdrTp;
        
        /// <summary>
        /// Element <b>AdrTpSpecified</b> (Address Type Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdrTpSpecified;
        
        /// <summary>
        /// Element <b>AdrLine</b> (Address Line) of type array of string.
        /// </summary>
        [XmlElementAttribute("AdrLine", Order=1)]
        public string[] AdrLine;
        
        /// <summary>
        /// Element <b>StrtNm</b> (Street Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string StrtNm;
        
        /// <summary>
        /// Element <b>BldgNb</b> (Building Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string BldgNb;
        
        /// <summary>
        /// Element <b>PstCd</b> (Post Code) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string PstCd;
        
        /// <summary>
        /// Element <b>TwnNm</b> (Town Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public string TwnNm;
        
        /// <summary>
        /// Element <b>CtrySubDvsn</b> (Country Sub Division) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string CtrySubDvsn;
        
        /// <summary>
        /// Element <b>Ctry</b> (Country) of type string.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public string Ctry;
    }
    
    /// <summary>
    /// Enumeration <b>AddressType2Code</b> (Address Type 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.01")]
    public enum AddressType2Code
    {
        
        /// <summary>
        /// <b>ADDR - Postal</b>.
        /// </summary>
        ADDR,
        
        /// <summary>
        /// <b>PBOX - POBox</b>.
        /// </summary>
        PBOX,
        
        /// <summary>
        /// <b>HOME - Residential</b>.
        /// </summary>
        HOME,
        
        /// <summary>
        /// <b>BIZZ - Business</b>.
        /// </summary>
        BIZZ,
        
        /// <summary>
        /// <b>MLTO - Mail To</b>.
        /// </summary>
        MLTO,
        
        /// <summary>
        /// <b>DLVY - Delivery To</b>.
        /// </summary>
        DLVY,
    }
    
    /// <summary>
    /// Class <b>GenericIdentification1</b> (Generic Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.01")]
    public class GenericIdentification1
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>SchmeNm</b> (Scheme Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string SchmeNm;
        
        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Issr;
    }
    
    /// <summary>
    /// Class <b>ConfirmationRejectedStatus1</b> (Confirmation Rejected Status 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.01")]
    public class ConfirmationRejectedStatus1
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// DataSrcSchme (Data Source Scheme) of type GenericIdentification1 
        /// Rsn (Reason) of type RejectedConfirmationStatusReason1Code 
        /// XtndedRsn (Extended Reason) of type string 
        /// </summary>
        [XmlElementAttribute("DataSrcSchme", typeof(GenericIdentification1), Order=0)]
        [XmlElementAttribute("Rsn", typeof(RejectedConfirmationStatusReason1Code), Order=0)]
        [XmlElementAttribute("XtndedRsn", typeof(string), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Enumeration <b>RejectedConfirmationStatusReason1Code</b> (Rejected Confirmation Status Reason 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.01")]
    public enum RejectedConfirmationStatusReason1Code
    {
        
        /// <summary>
        /// <b>DSAF - Different Investment Account Details</b>.
        /// </summary>
        DSAF,
        
        /// <summary>
        /// <b>DFIN - Different Financial Instrument Details</b>.
        /// </summary>
        DFIN,
        
        /// <summary>
        /// <b>DBEN - Different Beneficiary Details</b>.
        /// </summary>
        DBEN,
        
        /// <summary>
        /// <b>DPTD - Different Place Of Trade</b>.
        /// </summary>
        DPTD,
        
        /// <summary>
        /// <b>DORD - Different Order Date Time</b>.
        /// </summary>
        DORD,
        
        /// <summary>
        /// <b>DCXR - Different Cancellation Right</b>.
        /// </summary>
        DCXR,
        
        /// <summary>
        /// <b>DUNB - Different Units Number</b>.
        /// </summary>
        DUNB,
        
        /// <summary>
        /// <b>DORT - Different Order Type</b>.
        /// </summary>
        DORT,
        
        /// <summary>
        /// <b>DROU - Different Rounding</b>.
        /// </summary>
        DROU,
        
        /// <summary>
        /// <b>DNAM - Different Net Amount</b>.
        /// </summary>
        DNAM,
        
        /// <summary>
        /// <b>DGAM - Different Gross Amount</b>.
        /// </summary>
        DGAM,
        
        /// <summary>
        /// <b>DHRR - Different Holdings Redemption Rate</b>.
        /// </summary>
        DHRR,
        
        /// <summary>
        /// <b>DGRP - Different Group 1Or 2Units</b>.
        /// </summary>
        DGRP,
        
        /// <summary>
        /// <b>DINP - Different Income Preference</b>.
        /// </summary>
        DINP,
        
        /// <summary>
        /// <b>DLIR - Different Letter Intent Reference</b>.
        /// </summary>
        DLIR,
        
        /// <summary>
        /// <b>DARR - Different Accumulation Right Reference</b>.
        /// </summary>
        DARR,
        
        /// <summary>
        /// <b>DPDI - Different Physical Delivery Indicator</b>.
        /// </summary>
        DPDI,
        
        /// <summary>
        /// <b>DRSC - Different Requested Settlement Currency</b>.
        /// </summary>
        DRSC,
        
        /// <summary>
        /// <b>DNAV - Different Requested NAVCurrency</b>.
        /// </summary>
        DNAV,
        
        /// <summary>
        /// <b>DFXD - Different Foreign Exchange Details</b>.
        /// </summary>
        DFXD,
        
        /// <summary>
        /// <b>DCHD - Different Charge Details</b>.
        /// </summary>
        DCHD,
        
        /// <summary>
        /// <b>DXOD - Different Commission Details</b>.
        /// </summary>
        DXOD,
        
        /// <summary>
        /// <b>DTAD - Different Tax Details</b>.
        /// </summary>
        DTAD,
        
        /// <summary>
        /// <b>DPDD - Different Physical Delivery Details</b>.
        /// </summary>
        DPDD,
        
        /// <summary>
        /// <b>DSCA - Different Settlement And Custody Details</b>.
        /// </summary>
        DSCA,
        
        /// <summary>
        /// <b>DPID - Different Payment Instrument Details</b>.
        /// </summary>
        DPID,
        
        /// <summary>
        /// <b>DSAM - Different Settlement Amount</b>.
        /// </summary>
        DSAM,
        
        /// <summary>
        /// <b>DSDT - Different Settlement Date</b>.
        /// </summary>
        DSDT,
        
        /// <summary>
        /// <b>DEXD - Different Extension Details</b>.
        /// </summary>
        DEXD,
        
        /// <summary>
        /// <b>DIMD - Different Intermediary Details</b>.
        /// </summary>
        DIMD,
        
        /// <summary>
        /// <b>DTRA - Different Total Redemption Amount</b>.
        /// </summary>
        DTRA,
        
        /// <summary>
        /// <b>DTSA - Different Total Subscription Amount</b>.
        /// </summary>
        DTSA,
        
        /// <summary>
        /// <b>DACI - Different Additional Cash In</b>.
        /// </summary>
        DACI,
        
        /// <summary>
        /// <b>DACO - Different Resulting Cash Out</b>.
        /// </summary>
        DACO,
        
        /// <summary>
        /// <b>DPSA - Different Percentage Of Total Subscription Amount</b>.
        /// </summary>
        DPSA,
        
        /// <summary>
        /// <b>DPRA - Different Percentage Of Total Redemption Amount</b>.
        /// </summary>
        DPRA,
        
        /// <summary>
        /// <b>DLID - Different Leg Identification</b>.
        /// </summary>
        DLID,
        
        /// <summary>
        /// <b>DORF - Different Order Reference</b>.
        /// </summary>
        DORF,
        
        /// <summary>
        /// <b>ULNK - Unknown Linkages Reference</b>.
        /// </summary>
        ULNK,
        
        /// <summary>
        /// <b>DREF - Duplicate Deal Reference</b>.
        /// </summary>
        DREF,
        
        /// <summary>
        /// <b>IVAG - Receiving Agent</b>.
        /// </summary>
        IVAG,
        
        /// <summary>
        /// <b>IRCU - Receivers Custodian</b>.
        /// </summary>
        IRCU,
        
        /// <summary>
        /// <b>IRIN - Receivers Intermediary</b>.
        /// </summary>
        IRIN,
        
        /// <summary>
        /// <b>ICAG - Delivering Agent</b>.
        /// </summary>
        ICAG,
        
        /// <summary>
        /// <b>IDCU - Deliverers Custodian</b>.
        /// </summary>
        IDCU,
        
        /// <summary>
        /// <b>IDIN - Deliverers Intermediary</b>.
        /// </summary>
        IDIN,
        
        /// <summary>
        /// <b>ICTR - Invalid Credit Transfer</b>.
        /// </summary>
        ICTR,
        
        /// <summary>
        /// <b>DMON - Settlement Amount</b>.
        /// </summary>
        DMON,
        
        /// <summary>
        /// <b>DDAT - Settlement Date</b>.
        /// </summary>
        DDAT,
        
        /// <summary>
        /// <b>NSLA - Not Compliant With SLA</b>.
        /// </summary>
        NSLA,
        
        /// <summary>
        /// <b>MEUT - Missing EUTax Information</b>.
        /// </summary>
        MEUT,
        
        /// <summary>
        /// <b>MCOM - Missing Commission</b>.
        /// </summary>
        MCOM,
        
        /// <summary>
        /// <b>MCHA - Missing Charge</b>.
        /// </summary>
        MCHA,
        
        /// <summary>
        /// <b>MTAX - Missing Tax Information</b>.
        /// </summary>
        MTAX,
        
        /// <summary>
        /// <b>NATA - Not Allowedto Amend</b>.
        /// </summary>
        NATA,
        
        /// <summary>
        /// <b>ALAT - Amendment Too Late</b>.
        /// </summary>
        ALAT,
    }
    
    /// <summary>
    /// Class <b>IndividualOrderConfirmationStatusAndReason1</b> (Individual Order Confirmation Status And Reason 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.01")]
    public class IndividualOrderConfirmationStatusAndReason1
    {
        
        /// <summary>
        /// Element <b>MstrRef</b> (Master Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string MstrRef;
        
        /// <summary>
        /// Element <b>OrdrRef</b> (Order Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string OrdrRef;
        
        /// <summary>
        /// Element <b>ClntRef</b> (Client Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string ClntRef;
        
        /// <summary>
        /// Element <b>DealRef</b> (Deal Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string DealRef;
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// [XOR] This element can be:
        /// AmdmntRjctd (Amendment Rejected) of type ConfirmationRejectedStatus1 
        /// ConfRjctd (Confirmation Rejected) of type ConfirmationRejectedStatus1 
        /// Sts (Status) of type OrderConfirmationStatus1Code 
        /// </summary>
        [XmlElementAttribute("AmdmntRjctd", typeof(ConfirmationRejectedStatus1), Order=4)]
        [XmlElementAttribute("ConfRjctd", typeof(ConfirmationRejectedStatus1), Order=4)]
        [XmlElementAttribute("Sts", typeof(OrderConfirmationStatus1Code), Order=4)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items;
        
        /// <summary>
        /// Element <b>ItemsElementName</b> (Items Element Name) of type array of ItemsChoiceType1.
        /// </summary>
        [XmlElementAttribute("ItemsElementName", Order=5)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName;
        
        /// <summary>
        /// Element <b>StsInitr</b> (Status Initiator) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public PartyIdentification2Choice StsInitr;
        
        /// <summary>
        /// Element <b>InvstmtAcctDtls</b> (Investment Account Details) of type InvestmentAccount13.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public InvestmentAccount13 InvstmtAcctDtls;
        
        /// <summary>
        /// Element <b>FinInstrmDtls</b> (Financial Instrument Details) of type FinancialInstrument10.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public FinancialInstrument10 FinInstrmDtls;
    }
    
    /// <summary>
    /// Enumeration <b>OrderConfirmationStatus1Code</b> (Order Confirmation Status 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.01")]
    public enum OrderConfirmationStatus1Code
    {
        
        /// <summary>
        /// <b>STNP - Sent To Next Party</b>.
        /// </summary>
        STNP,
        
        /// <summary>
        /// <b>CPNP - Communication Problem Next Party</b>.
        /// </summary>
        CPNP,
        
        /// <summary>
        /// <b>COAC - Confirmation Accepted</b>.
        /// </summary>
        COAC,
        
        /// <summary>
        /// <b>CREC - Confirmation Received</b>.
        /// </summary>
        CREC,
    }
    
    /// <summary>
    /// Enumeration <b>ItemsChoiceType1</b> (Items Choice Type 1).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.01", IncludeInSchema=false)]
    public enum ItemsChoiceType1
    {
        
        /// <summary>
        /// <b>AmdmntRjctd - Amendment Rejected</b>.
        /// </summary>
        AmdmntRjctd,
        
        /// <summary>
        /// <b>ConfRjctd - Confirmation Rejected</b>.
        /// </summary>
        ConfRjctd,
        
        /// <summary>
        /// <b>Sts - Status</b>.
        /// </summary>
        Sts,
    }
    
    /// <summary>
    /// Class <b>AdditionalReference3</b> (Additional Reference 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.01")]
    public class AdditionalReference3
    {
        
        /// <summary>
        /// Element <b>Ref</b> (Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Ref;
        
        /// <summary>
        /// Element <b>RefIssr</b> (Reference Issuer) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification2Choice RefIssr;
        
        /// <summary>
        /// Element <b>MsgNm</b> (Message Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string MsgNm;
    }
    
    /// <summary>
    /// Enumeration <b>ItemsChoiceType</b> (Items Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:setr.057.001.01", IncludeInSchema=false)]
    public enum ItemsChoiceType
    {
        
        /// <summary>
        /// <b>OthrRef - Other Reference</b>.
        /// </summary>
        OthrRef,
        
        /// <summary>
        /// <b>RltdRef - Related Reference</b>.
        /// </summary>
        RltdRef,
    }
}
