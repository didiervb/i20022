
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



namespace i20022.sese00500102
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id sese.005.001.02 name TransferInInstructionV02 from Securities Settlement business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>TrfInInstrV02</b> (Transfer In Instruction V02) of type TransferInInstructionV02.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public TransferInInstructionV02 TrfInInstrV02;
    }
    
    /// <summary>
    /// Class <b>TransferInInstructionV02</b> (Transfer In Instruction V02).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class TransferInInstructionV02
    {
        
        /// <summary>
        /// Element <b>MsgId</b> (Message Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public MessageIdentification1 MsgId;
        
        /// <summary>
        /// Element <b>PoolRef</b> (Pool Reference) of type AdditionalReference2.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public AdditionalReference2 PoolRef;
        
        /// <summary>
        /// Element <b>PrvsRef</b> (Previous Reference) of type AdditionalReference2.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public AdditionalReference2 PrvsRef;
        
        /// <summary>
        /// Element <b>RltdRef</b> (Related Reference) of type AdditionalReference2.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public AdditionalReference2 RltdRef;
        
        /// <summary>
        /// Element <b>TrfDtls</b> (Transfer Details) of type Transfer5.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public Transfer5 TrfDtls;
        
        /// <summary>
        /// Element <b>FinInstrmDtls</b> (Financial Instrument Details) of type FinancialInstrument13.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public FinancialInstrument13 FinInstrmDtls;
        
        /// <summary>
        /// Element <b>AcctDtls</b> (Account Details) of type InvestmentAccount22.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public InvestmentAccount22 AcctDtls;
        
        /// <summary>
        /// Element <b>SttlmDtls</b> (Settlement Details) of type DeliverInformation3.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public DeliverInformation3 SttlmDtls;
        
        /// <summary>
        /// Element <b>CpyDtls</b> (Copy Details) of type CopyInformation2.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public CopyInformation2 CpyDtls;
        
        /// <summary>
        /// Element <b>Xtnsn</b> (Extension) of type array of Extension1.
        /// </summary>
        [XmlElementAttribute("Xtnsn", Order=9)]
        public Extension1[] Xtnsn;
    }
    
    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
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
    /// Class <b>BICIdentification1</b> (BIC Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class BICIdentification1
    {
        
        /// <summary>
        /// Element <b>BIC</b> (BIC) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string BIC;
    }
    
    /// <summary>
    /// Class <b>CopyInformation2</b> (Copy Information 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class CopyInformation2
    {
        
        /// <summary>
        /// Element <b>CpyInd</b> (Copy Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public bool CpyInd;
        
        /// <summary>
        /// Element <b>OrgnlRcvr</b> (Original Receiver) of type BICIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public BICIdentification1 OrgnlRcvr;
    }
    
    /// <summary>
    /// Class <b>NameAndAddress4</b> (Name And Address 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class NameAndAddress4
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
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
    /// Class <b>DeliveryParameters4</b> (Delivery Parameters 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class DeliveryParameters4
    {
        
        /// <summary>
        /// Element <b>RegdAdrInd</b> (Registered Address Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public bool RegdAdrInd;
        
        /// <summary>
        /// Element <b>NmAndAdr</b> (Name And Address) of type NameAndAddress4.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public NameAndAddress4 NmAndAdr;
        
        /// <summary>
        /// Element <b>CtctPrsn</b> (Contact Person) of type ContactIdentification2.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public ContactIdentification2 CtctPrsn;
    }
    
    /// <summary>
    /// Class <b>ContactIdentification2</b> (Contact Identification 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class ContactIdentification2
    {
        
        /// <summary>
        /// Element <b>NmPrfx</b> (Name Prefix) of type NamePrefix1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public NamePrefix1Code NmPrfx;
        
        /// <summary>
        /// Element <b>NmPrfxSpecified</b> (Name Prefix Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NmPrfxSpecified;
        
        /// <summary>
        /// Element <b>GvnNm</b> (Given Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string GvnNm;
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Nm;
        
        /// <summary>
        /// Element <b>PhneNb</b> (Phone Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string PhneNb;
        
        /// <summary>
        /// Element <b>MobNb</b> (Mobile Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string MobNb;
        
        /// <summary>
        /// Element <b>FaxNb</b> (Fax Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public string FaxNb;
        
        /// <summary>
        /// Element <b>EmailAdr</b> (Email Address) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string EmailAdr;
    }
    
    /// <summary>
    /// Enumeration <b>NamePrefix1Code</b> (Name Prefix 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public enum NamePrefix1Code
    {
        
        /// <summary>
        /// <b>DOCT - Doctor</b>.
        /// </summary>
        DOCT,
        
        /// <summary>
        /// <b>MIST - Mister</b>.
        /// </summary>
        MIST,
        
        /// <summary>
        /// <b>MISS - Miss</b>.
        /// </summary>
        MISS,
        
        /// <summary>
        /// <b>MADM - Madam</b>.
        /// </summary>
        MADM,
    }
    
    /// <summary>
    /// Class <b>ActiveOrHistoricCurrencyAnd13DecimalAmount</b> (Active Or Historic Currency And 13 Decimal Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class ActiveOrHistoricCurrencyAnd13DecimalAmount
    {
        
        /// <summary>
        /// Element <b>Ccy</b> (Currency) of type string.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Ccy;
        
        /// <summary>
        /// Element <b>Value</b> (Value) of type decimal.
        /// </summary>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value;
    }
    
    /// <summary>
    /// Class <b>Tax15</b> (Tax 15).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class Tax15
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Tp (Type) of type TaxType13Code 
        /// XtndedTp (Extended Type) of type string 
        /// </summary>
        [XmlElementAttribute("Tp", typeof(TaxType13Code), Order=0)]
        [XmlElementAttribute("XtndedTp", typeof(string), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveOrHistoricCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ActiveOrHistoricCurrencyAnd13DecimalAmount Amt;
        
        /// <summary>
        /// Element <b>Item1</b> (Item 1) of type object.
        /// [XOR] This element can be:
        /// Bsis (Basis) of type TaxationBasis2Code 
        /// XtndedBsis (Extended Basis) of type string 
        /// </summary>
        [XmlElementAttribute("Bsis", typeof(TaxationBasis2Code), Order=2)]
        [XmlElementAttribute("XtndedBsis", typeof(string), Order=2)]
        public object Item1;
        
        /// <summary>
        /// Element <b>RcptId</b> (Recipient Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public PartyIdentification2Choice RcptId;
        
        /// <summary>
        /// Element <b>XmptnInd</b> (Exemption Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public bool XmptnInd;
        
        /// <summary>
        /// Element <b>Item2</b> (Item 2) of type object.
        /// [XOR] This element can be:
        /// XmptnRsn (Exemption Reason) of type TaxExemptReason1Code 
        /// XtndedXmptnRsn (Extended Exemption Reason) of type string 
        /// </summary>
        [XmlElementAttribute("XmptnRsn", typeof(TaxExemptReason1Code), Order=5)]
        [XmlElementAttribute("XtndedXmptnRsn", typeof(string), Order=5)]
        public object Item2;
    }
    
    /// <summary>
    /// Enumeration <b>TaxType13Code</b> (Tax Type 13 Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public enum TaxType13Code
    {
        
        /// <summary>
        /// <b>COAX - Consumption Tax</b>.
        /// </summary>
        COAX,
        
        /// <summary>
        /// <b>EUTR - EUTax Retention</b>.
        /// </summary>
        EUTR,
        
        /// <summary>
        /// <b>LOCL - Local Tax</b>.
        /// </summary>
        LOCL,
        
        /// <summary>
        /// <b>NATI - National Tax</b>.
        /// </summary>
        NATI,
        
        /// <summary>
        /// <b>LEVY - Payment Levy Tax</b>.
        /// </summary>
        LEVY,
        
        /// <summary>
        /// <b>PROV - Provincial</b>.
        /// </summary>
        PROV,
        
        /// <summary>
        /// <b>STAM - Stamp Duty</b>.
        /// </summary>
        STAM,
        
        /// <summary>
        /// <b>STAT - State Tax</b>.
        /// </summary>
        STAT,
        
        /// <summary>
        /// <b>STEX - Stock Exchange Tax</b>.
        /// </summary>
        STEX,
        
        /// <summary>
        /// <b>CTAX - Tax Credit</b>.
        /// </summary>
        CTAX,
        
        /// <summary>
        /// <b>TRAX - Transaction Tax</b>.
        /// </summary>
        TRAX,
        
        /// <summary>
        /// <b>TRAN - Transfer Fee</b>.
        /// </summary>
        TRAN,
        
        /// <summary>
        /// <b>VATA - Value Added Tax</b>.
        /// </summary>
        VATA,
        
        /// <summary>
        /// <b>WITH - With / Withdrawal</b>.
        /// </summary>
        WITH,
    }
    
    /// <summary>
    /// Enumeration <b>TaxationBasis2Code</b> (Taxation Basis 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public enum TaxationBasis2Code
    {
        
        /// <summary>
        /// <b>FLAT - Flat</b>.
        /// </summary>
        FLAT,
        
        /// <summary>
        /// <b>PERU - Per Unit</b>.
        /// </summary>
        PERU,
    }
    
    /// <summary>
    /// Class <b>PartyIdentification2Choice</b> (Party Identification 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
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
    /// Class <b>GenericIdentification1</b> (Generic Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
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
    /// Enumeration <b>TaxExemptReason1Code</b> (Tax Exempt Reason 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public enum TaxExemptReason1Code
    {
        
        /// <summary>
        /// <b>NONE - None</b>.
        /// </summary>
        NONE,
        
        /// <summary>
        /// <b>MASA - Maxi ISA</b>.
        /// </summary>
        MASA,
        
        /// <summary>
        /// <b>MISA - Mini Cash ISA</b>.
        /// </summary>
        MISA,
        
        /// <summary>
        /// <b>SISA - Mini Stocks And Shares ISA</b>.
        /// </summary>
        SISA,
        
        /// <summary>
        /// <b>IISA - Mini Insurance ISA</b>.
        /// </summary>
        IISA,
        
        /// <summary>
        /// <b>CUYP - Current Year Payment</b>.
        /// </summary>
        CUYP,
        
        /// <summary>
        /// <b>PRYP - Prior Year Payment</b>.
        /// </summary>
        PRYP,
        
        /// <summary>
        /// <b>ASTR - Asset Transfer</b>.
        /// </summary>
        ASTR,
        
        /// <summary>
        /// <b>EMPY - Employee Prior Year</b>.
        /// </summary>
        EMPY,
        
        /// <summary>
        /// <b>EMCY - Employee Current Year</b>.
        /// </summary>
        EMCY,
        
        /// <summary>
        /// <b>EPRY - Employer Prior Year</b>.
        /// </summary>
        EPRY,
        
        /// <summary>
        /// <b>ECYE - Employer Current Year</b>.
        /// </summary>
        ECYE,
        
        /// <summary>
        /// <b>NFPI - Non Fund Prototype IRA</b>.
        /// </summary>
        NFPI,
        
        /// <summary>
        /// <b>NFQP - Non Fund Qualified Plan</b>.
        /// </summary>
        NFQP,
        
        /// <summary>
        /// <b>DECP - Defined Contribution Plan</b>.
        /// </summary>
        DECP,
        
        /// <summary>
        /// <b>IRAC - Individual Retirement Account</b>.
        /// </summary>
        IRAC,
        
        /// <summary>
        /// <b>IRAR - Individual Retirement Account Rollover</b>.
        /// </summary>
        IRAR,
        
        /// <summary>
        /// <b>KEOG - KEOGH</b>.
        /// </summary>
        KEOG,
        
        /// <summary>
        /// <b>PFSP - Profit Sharing Plan</b>.
        /// </summary>
        PFSP,
        
        /// <summary>
        /// <b>Item401K - Item 401K</b>.
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("401K")]
        Item401K,
        
        /// <summary>
        /// <b>SIRA - Self Directed IRA</b>.
        /// </summary>
        SIRA,
        
        /// <summary>
        /// <b>Item403B - Item 403B</b>.
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("403B")]
        Item403B,
        
        /// <summary>
        /// <b>Item457X - Item 457X</b>.
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("457X")]
        Item457X,
        
        /// <summary>
        /// <b>RIRA - Roth IRA Fund Prototype</b>.
        /// </summary>
        RIRA,
        
        /// <summary>
        /// <b>RIAN - Roth IRA Non Prototype</b>.
        /// </summary>
        RIAN,
        
        /// <summary>
        /// <b>RCRF - Roth Conversion IRAFund Prototype</b>.
        /// </summary>
        RCRF,
        
        /// <summary>
        /// <b>RCIP - Roth Conversion IRANon Prototype</b>.
        /// </summary>
        RCIP,
        
        /// <summary>
        /// <b>EIFP - Education IRAFund Prototype</b>.
        /// </summary>
        EIFP,
        
        /// <summary>
        /// <b>EIOP - Education IRANon Prototype</b>.
        /// </summary>
        EIOP,
    }
    
    /// <summary>
    /// Class <b>ActiveCurrencyAnd13DecimalAmount</b> (Active Currency And 13 Decimal Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class ActiveCurrencyAnd13DecimalAmount
    {
        
        /// <summary>
        /// Element <b>Ccy</b> (Currency) of type string.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Ccy;
        
        /// <summary>
        /// Element <b>Value</b> (Value) of type decimal.
        /// </summary>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value;
    }
    
    /// <summary>
    /// Class <b>Commission12</b> (Commission 12).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class Commission12
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Tp (Type) of type CommissionType7Code 
        /// XtndedTp (Extended Type) of type string 
        /// </summary>
        [XmlElementAttribute("Tp", typeof(CommissionType7Code), Order=0)]
        [XmlElementAttribute("XtndedTp", typeof(string), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>Item1</b> (Item 1) of type object.
        /// [XOR] This element can be:
        /// Bsis (Basis) of type TaxationBasis4Code 
        /// XtndedBsis (Extended Basis) of type string 
        /// </summary>
        [XmlElementAttribute("Bsis", typeof(TaxationBasis4Code), Order=1)]
        [XmlElementAttribute("XtndedBsis", typeof(string), Order=1)]
        public object Item1;
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveCurrencyAnd13DecimalAmount.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public ActiveCurrencyAnd13DecimalAmount Amt;
        
        /// <summary>
        /// Element <b>RcptId</b> (Recipient Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public PartyIdentification2Choice RcptId;
        
        /// <summary>
        /// Element <b>ComrclAgrmtRef</b> (Commercial Agreement Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string ComrclAgrmtRef;
    }
    
    /// <summary>
    /// Enumeration <b>CommissionType7Code</b> (Commission Type 7Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public enum CommissionType7Code
    {
        
        /// <summary>
        /// <b>FEND - Front End Load</b>.
        /// </summary>
        FEND,
        
        /// <summary>
        /// <b>BEND - Back End Load</b>.
        /// </summary>
        BEND,
    }
    
    /// <summary>
    /// Enumeration <b>TaxationBasis4Code</b> (Taxation Basis 4Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public enum TaxationBasis4Code
    {
        
        /// <summary>
        /// <b>FLAT - Flat</b>.
        /// </summary>
        FLAT,
        
        /// <summary>
        /// <b>PERU - Per Unit</b>.
        /// </summary>
        PERU,
        
        /// <summary>
        /// <b>GRAM - Gross Amount</b>.
        /// </summary>
        GRAM,
        
        /// <summary>
        /// <b>NEAM - Net Amount</b>.
        /// </summary>
        NEAM,
    }
    
    /// <summary>
    /// Class <b>ActiveOrHistoricCurrencyAndAmount</b> (Active Or Historic Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class ActiveOrHistoricCurrencyAndAmount
    {
        
        /// <summary>
        /// Element <b>Ccy</b> (Currency) of type string.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Ccy;
        
        /// <summary>
        /// Element <b>Value</b> (Value) of type decimal.
        /// </summary>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value;
    }
    
    /// <summary>
    /// Class <b>Charge20</b> (Charge 20).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class Charge20
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Tp (Type) of type ChargeType12Code 
        /// XtndedTp (Extended Type) of type string 
        /// </summary>
        [XmlElementAttribute("Tp", typeof(ChargeType12Code), Order=0)]
        [XmlElementAttribute("XtndedTp", typeof(string), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveOrHistoricCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ActiveOrHistoricCurrencyAndAmount Amt;
        
        /// <summary>
        /// Element <b>Item1</b> (Item 1) of type object.
        /// [XOR] This element can be:
        /// ChrgBsis (Charge Basis) of type TaxationBasis2Code 
        /// XtndedChrgBsis (Extended Charge Basis) of type string 
        /// </summary>
        [XmlElementAttribute("ChrgBsis", typeof(TaxationBasis2Code), Order=2)]
        [XmlElementAttribute("XtndedChrgBsis", typeof(string), Order=2)]
        public object Item1;
        
        /// <summary>
        /// Element <b>ChrgBr</b> (Charge Bearer) of type ChargeBearer1Code.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public ChargeBearer1Code ChrgBr;
        
        /// <summary>
        /// Element <b>ChrgBrSpecified</b> (Charge Bearer Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChrgBrSpecified;
        
        /// <summary>
        /// Element <b>RcptId</b> (Recipient Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public PartyIdentification2Choice RcptId;
    }
    
    /// <summary>
    /// Enumeration <b>ChargeType12Code</b> (Charge Type 12 Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public enum ChargeType12Code
    {
        
        /// <summary>
        /// <b>BEND - Back End Load</b>.
        /// </summary>
        BEND,
        
        /// <summary>
        /// <b>DISC - Discount</b>.
        /// </summary>
        DISC,
        
        /// <summary>
        /// <b>FEND - Front End Load</b>.
        /// </summary>
        FEND,
        
        /// <summary>
        /// <b>POST - Postage Charge</b>.
        /// </summary>
        POST,
        
        /// <summary>
        /// <b>REGF - Regulatory Fee</b>.
        /// </summary>
        REGF,
        
        /// <summary>
        /// <b>SHIP - Shipping Charge</b>.
        /// </summary>
        SHIP,
        
        /// <summary>
        /// <b>SPCN - Special Concessions</b>.
        /// </summary>
        SPCN,
        
        /// <summary>
        /// <b>TRAN - Transfer Fee</b>.
        /// </summary>
        TRAN,
    }
    
    /// <summary>
    /// Enumeration <b>ChargeBearer1Code</b> (Charge Bearer 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public enum ChargeBearer1Code
    {
        
        /// <summary>
        /// <b>OUR - Borne By Debtor</b>.
        /// </summary>
        OUR,
        
        /// <summary>
        /// <b>BEN - Borne By Creditor</b>.
        /// </summary>
        BEN,
        
        /// <summary>
        /// <b>SHA - Shared</b>.
        /// </summary>
        SHA,
    }
    
    /// <summary>
    /// Class <b>PartyIdentification21</b> (Party Identification 21).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class PartyIdentification21
    {
        
        /// <summary>
        /// Element <b>PtyId</b> (Party Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PartyIdentification2Choice PtyId;
        
        /// <summary>
        /// Element <b>PrcgRef</b> (Processing Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string PrcgRef;
        
        /// <summary>
        /// Element <b>PrcgDt</b> (Processing Date) of type DateAndDateTimeChoice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public DateAndDateTimeChoice PrcgDt;
        
        /// <summary>
        /// Element <b>CtctPrsn</b> (Contact Person) of type ContactIdentification2.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public ContactIdentification2 CtctPrsn;
    }
    
    /// <summary>
    /// Class <b>DateAndDateTimeChoice</b> (Date And Date Time Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class DateAndDateTimeChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute("Dt", typeof(System.DateTime), DataType="date", Order=0)]
        [XmlElementAttribute("DtTm", typeof(System.DateTime), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public System.DateTime Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType3.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType3 ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType3</b> (Item Choice Type 3).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02", IncludeInSchema=false)]
    public enum ItemChoiceType3
    {
        
        /// <summary>
        /// <b>Dt - Date</b>.
        /// </summary>
        Dt,
        
        /// <summary>
        /// <b>DtTm - Date Time</b>.
        /// </summary>
        DtTm,
    }
    
    /// <summary>
    /// Class <b>PartyIdentificationAndAccount4</b> (Party Identification And Account 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class PartyIdentificationAndAccount4
    {
        
        /// <summary>
        /// Element <b>PtyId</b> (Party Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PartyIdentification2Choice PtyId;
        
        /// <summary>
        /// Element <b>AcctId</b> (Account Identification) of type AccountIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public AccountIdentification1 AcctId;
        
        /// <summary>
        /// Element <b>PrcgRef</b> (Processing Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string PrcgRef;
        
        /// <summary>
        /// Element <b>PrcgDt</b> (Processing Date) of type DateAndDateTimeChoice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public DateAndDateTimeChoice PrcgDt;
        
        /// <summary>
        /// Element <b>SubAcctDtls</b> (Sub Account Details) of type SubAccount1.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public SubAccount1 SubAcctDtls;
        
        /// <summary>
        /// Element <b>CtctPrsn</b> (Contact Person) of type ContactIdentification2.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public ContactIdentification2 CtctPrsn;
    }
    
    /// <summary>
    /// Class <b>AccountIdentification1</b> (Account Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class AccountIdentification1
    {
        
        /// <summary>
        /// Element <b>Prtry</b> (Proprietary) of type SimpleIdentificationInformation.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public SimpleIdentificationInformation Prtry;
    }
    
    /// <summary>
    /// Class <b>SimpleIdentificationInformation</b> (Simple Identification Information).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class SimpleIdentificationInformation
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
    }
    
    /// <summary>
    /// Class <b>SubAccount1</b> (Sub Account 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class SubAccount1
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type AccountIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AccountIdentification1 Id;
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Nm;
        
        /// <summary>
        /// Element <b>Chrtc</b> (Characteristic) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Chrtc;
    }
    
    /// <summary>
    /// Class <b>PartyIdentificationAndAccount5</b> (Party Identification And Account 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class PartyIdentificationAndAccount5
    {
        
        /// <summary>
        /// Element <b>PtyId</b> (Party Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PartyIdentification2Choice PtyId;
        
        /// <summary>
        /// Element <b>AcctId</b> (Account Identification) of type AccountIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public AccountIdentification1 AcctId;
        
        /// <summary>
        /// Element <b>PrcgRef</b> (Processing Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string PrcgRef;
        
        /// <summary>
        /// Element <b>PrcgDt</b> (Processing Date) of type DateAndDateTimeChoice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public DateAndDateTimeChoice PrcgDt;
    }
    
    /// <summary>
    /// Class <b>Intermediary10</b> (Intermediary 10).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class Intermediary10
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PartyIdentification2Choice Id;
        
        /// <summary>
        /// Element <b>Acct</b> (Account) of type Account7.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public Account7 Acct;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Role (Role) of type InvestmentFundRole2Code 
        /// XtndedRole (Extended Role) of type string 
        /// </summary>
        [XmlElementAttribute("Role", typeof(InvestmentFundRole2Code), Order=2)]
        [XmlElementAttribute("XtndedRole", typeof(string), Order=2)]
        public object Item;
        
        /// <summary>
        /// Element <b>CtctPrsn</b> (Contact Person) of type ContactIdentification2.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public ContactIdentification2 CtctPrsn;
    }
    
    /// <summary>
    /// Class <b>Account7</b> (Account 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class Account7
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type AccountIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AccountIdentification1 Id;
        
        /// <summary>
        /// Element <b>AcctSvcr</b> (Account Servicer) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification2Choice AcctSvcr;
    }
    
    /// <summary>
    /// Enumeration <b>InvestmentFundRole2Code</b> (Investment Fund Role 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public enum InvestmentFundRole2Code
    {
        
        /// <summary>
        /// <b>FMCO - Fund Management Company</b>.
        /// </summary>
        FMCO,
        
        /// <summary>
        /// <b>REGI - Registrar</b>.
        /// </summary>
        REGI,
        
        /// <summary>
        /// <b>TRAG - Transfer Agent</b>.
        /// </summary>
        TRAG,
        
        /// <summary>
        /// <b>INTR - Intermediary / Interest Payment</b>.
        /// </summary>
        INTR,
        
        /// <summary>
        /// <b>DIST - Distribution</b>.
        /// </summary>
        DIST,
        
        /// <summary>
        /// <b>CONC - Concentrator</b>.
        /// </summary>
        CONC,
        
        /// <summary>
        /// <b>UCL1 - Underlying Client 1</b>.
        /// </summary>
        UCL1,
        
        /// <summary>
        /// <b>UCL2 - Underlying Client 2</b>.
        /// </summary>
        UCL2,
        
        /// <summary>
        /// <b>TRAN - Transfer Fee</b>.
        /// </summary>
        TRAN,
    }
    
    /// <summary>
    /// Class <b>InvestmentAccount24</b> (Investment Account 24).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class InvestmentAccount24
    {
        
        /// <summary>
        /// Element <b>OwnrId</b> (Owner Identification) of type array of PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute("OwnrId", Order=0)]
        public PartyIdentification2Choice[] OwnrId;
        
        /// <summary>
        /// Element <b>AcctId</b> (Account Identification) of type AccountIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public AccountIdentification1 AcctId;
        
        /// <summary>
        /// Element <b>AcctNm</b> (Account Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string AcctNm;
        
        /// <summary>
        /// Element <b>AcctDsgnt</b> (Account Designation) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string AcctDsgnt;
        
        /// <summary>
        /// Element <b>IntrmyInf</b> (Intermediary Information) of type array of Intermediary10.
        /// </summary>
        [XmlElementAttribute("IntrmyInf", Order=4)]
        public Intermediary10[] IntrmyInf;
        
        /// <summary>
        /// Element <b>SctiesForm</b> (Securities Form) of type FormOfSecurity1Code.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public FormOfSecurity1Code SctiesForm;
        
        /// <summary>
        /// Element <b>SctiesFormSpecified</b> (Securities Form Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SctiesFormSpecified;
        
        /// <summary>
        /// Element <b>DmtrlsdInd</b> (Dematerialised Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public bool DmtrlsdInd;
        
        /// <summary>
        /// Element <b>DmtrlsdIndSpecified</b> (Dematerialised Indicator Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DmtrlsdIndSpecified;
        
        /// <summary>
        /// Element <b>IncmPref</b> (Income Preference) of type IncomePreference1Code.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public IncomePreference1Code IncmPref;
        
        /// <summary>
        /// Element <b>IncmPrefSpecified</b> (Income Preference Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncmPrefSpecified;
        
        /// <summary>
        /// Element <b>BnfcryCertfctnCmpltn</b> (Beneficiary Certification Completion) of type BeneficiaryCertificationCompletion1Code.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public BeneficiaryCertificationCompletion1Code BnfcryCertfctnCmpltn;
        
        /// <summary>
        /// Element <b>BnfcryCertfctnCmpltnSpecified</b> (Beneficiary Certification Completion Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BnfcryCertfctnCmpltnSpecified;
        
        /// <summary>
        /// Element <b>AcctSvcr</b> (Account Servicer) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public PartyIdentification2Choice AcctSvcr;
        
        /// <summary>
        /// Element <b>SubAcctDtls</b> (Sub Account Details) of type SubAccount1.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public SubAccount1 SubAcctDtls;
    }
    
    /// <summary>
    /// Enumeration <b>FormOfSecurity1Code</b> (Form Of Security 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
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
    /// Enumeration <b>IncomePreference1Code</b> (Income Preference 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public enum IncomePreference1Code
    {
        
        /// <summary>
        /// <b>CASH - Cash</b>.
        /// </summary>
        CASH,
        
        /// <summary>
        /// <b>DRIP - Dividend Reinvestment</b>.
        /// </summary>
        DRIP,
    }
    
    /// <summary>
    /// Enumeration <b>BeneficiaryCertificationCompletion1Code</b> (Beneficiary Certification Completion 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public enum BeneficiaryCertificationCompletion1Code
    {
        
        /// <summary>
        /// <b>NCER - Certification Not Required</b>.
        /// </summary>
        NCER,
        
        /// <summary>
        /// <b>ELEC - Electronic Certification</b>.
        /// </summary>
        ELEC,
        
        /// <summary>
        /// <b>PHYS - Physical Certification</b>.
        /// </summary>
        PHYS,
    }
    
    /// <summary>
    /// Class <b>DeliveringPartiesAndAccount4</b> (Delivering Parties And Account 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class DeliveringPartiesAndAccount4
    {
        
        /// <summary>
        /// Element <b>DlvrrDtls</b> (Deliverer Details) of type InvestmentAccount24.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public InvestmentAccount24 DlvrrDtls;
        
        /// <summary>
        /// Element <b>DlvrrsCtdnDtls</b> (Deliverers Custodian Details) of type PartyIdentificationAndAccount5.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentificationAndAccount5 DlvrrsCtdnDtls;
        
        /// <summary>
        /// Element <b>DlvrrsIntrmyDtls</b> (Deliverers Intermediary Details) of type PartyIdentificationAndAccount5.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PartyIdentificationAndAccount5 DlvrrsIntrmyDtls;
        
        /// <summary>
        /// Element <b>DlvrgAgtDtls</b> (Delivering Agent Details) of type PartyIdentificationAndAccount4.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public PartyIdentificationAndAccount4 DlvrgAgtDtls;
        
        /// <summary>
        /// Element <b>SctiesSttlmSys</b> (Securities Settlement System) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string SctiesSttlmSys;
        
        /// <summary>
        /// Element <b>PlcOfSttlmDtls</b> (Place Of Settlement Details) of type PartyIdentification21.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public PartyIdentification21 PlcOfSttlmDtls;
    }
    
    /// <summary>
    /// Class <b>ActiveCurrencyAndAmount</b> (Active Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class ActiveCurrencyAndAmount
    {
        
        /// <summary>
        /// Element <b>Ccy</b> (Currency) of type string.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Ccy;
        
        /// <summary>
        /// Element <b>Value</b> (Value) of type decimal.
        /// </summary>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value;
    }
    
    /// <summary>
    /// Class <b>DeliverInformation3</b> (Deliver Information 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class DeliverInformation3
    {
        
        /// <summary>
        /// Element <b>SttlmAmt</b> (Settlement Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ActiveCurrencyAndAmount SttlmAmt;
        
        /// <summary>
        /// Element <b>StmpDtyInd</b> (Stamp Duty Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public bool StmpDtyInd;
        
        /// <summary>
        /// Element <b>NetAmt</b> (Net Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public ActiveCurrencyAndAmount NetAmt;
        
        /// <summary>
        /// Element <b>SttlmPtiesDtls</b> (Settlement Parties Details) of type DeliveringPartiesAndAccount4.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public DeliveringPartiesAndAccount4 SttlmPtiesDtls;
        
        /// <summary>
        /// Element <b>ChrgDtls</b> (Charge Details) of type array of Charge20.
        /// </summary>
        [XmlElementAttribute("ChrgDtls", Order=4)]
        public Charge20[] ChrgDtls;
        
        /// <summary>
        /// Element <b>ComssnDtls</b> (Commission Details) of type array of Commission12.
        /// </summary>
        [XmlElementAttribute("ComssnDtls", Order=5)]
        public Commission12[] ComssnDtls;
        
        /// <summary>
        /// Element <b>TaxDtls</b> (Tax Details) of type array of Tax15.
        /// </summary>
        [XmlElementAttribute("TaxDtls", Order=6)]
        public Tax15[] TaxDtls;
        
        /// <summary>
        /// Element <b>PhysTrfInd</b> (Physical Transfer Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public bool PhysTrfInd;
        
        /// <summary>
        /// Element <b>PhysTrfDtls</b> (Physical Transfer Details) of type DeliveryParameters4.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public DeliveryParameters4 PhysTrfDtls;
    }
    
    /// <summary>
    /// Class <b>Intermediary11</b> (Intermediary 11).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class Intermediary11
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PartyIdentification2Choice Id;
        
        /// <summary>
        /// Element <b>Acct</b> (Account) of type Account7.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public Account7 Acct;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Role (Role) of type InvestmentFundRole2Code 
        /// XtndedRole (Extended Role) of type string 
        /// </summary>
        [XmlElementAttribute("Role", typeof(InvestmentFundRole2Code), Order=2)]
        [XmlElementAttribute("XtndedRole", typeof(string), Order=2)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>InvestmentAccount22</b> (Investment Account 22).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class InvestmentAccount22
    {
        
        /// <summary>
        /// Element <b>OwnrId</b> (Owner Identification) of type array of PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute("OwnrId", Order=0)]
        public PartyIdentification2Choice[] OwnrId;
        
        /// <summary>
        /// Element <b>AcctId</b> (Account Identification) of type AccountIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public AccountIdentification1 AcctId;
        
        /// <summary>
        /// Element <b>AcctNm</b> (Account Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string AcctNm;
        
        /// <summary>
        /// Element <b>AcctDsgnt</b> (Account Designation) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string AcctDsgnt;
        
        /// <summary>
        /// Element <b>IntrmyInf</b> (Intermediary Information) of type array of Intermediary11.
        /// </summary>
        [XmlElementAttribute("IntrmyInf", Order=4)]
        public Intermediary11[] IntrmyInf;
        
        /// <summary>
        /// Element <b>SctiesForm</b> (Securities Form) of type FormOfSecurity1Code.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public FormOfSecurity1Code SctiesForm;
        
        /// <summary>
        /// Element <b>SctiesFormSpecified</b> (Securities Form Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SctiesFormSpecified;
        
        /// <summary>
        /// Element <b>DmtrlsdInd</b> (Dematerialised Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public bool DmtrlsdInd;
        
        /// <summary>
        /// Element <b>DmtrlsdIndSpecified</b> (Dematerialised Indicator Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DmtrlsdIndSpecified;
        
        /// <summary>
        /// Element <b>IncmPref</b> (Income Preference) of type IncomePreference1Code.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public IncomePreference1Code IncmPref;
        
        /// <summary>
        /// Element <b>IncmPrefSpecified</b> (Income Preference Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncmPrefSpecified;
        
        /// <summary>
        /// Element <b>BnfcryCertfctnCmpltn</b> (Beneficiary Certification Completion) of type BeneficiaryCertificationCompletion1Code.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public BeneficiaryCertificationCompletion1Code BnfcryCertfctnCmpltn;
        
        /// <summary>
        /// Element <b>BnfcryCertfctnCmpltnSpecified</b> (Beneficiary Certification Completion Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BnfcryCertfctnCmpltnSpecified;
        
        /// <summary>
        /// Element <b>SfkpgPlc</b> (Safekeeping Place) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public PartyIdentification2Choice SfkpgPlc;
        
        /// <summary>
        /// Element <b>AcctSvcr</b> (Account Servicer) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public PartyIdentification2Choice AcctSvcr;
    }
    
    /// <summary>
    /// Class <b>AlternateSecurityIdentification1</b> (Alternate Security Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
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
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType1</b> (Item Choice Type 1).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02", IncludeInSchema=false)]
    public enum ItemChoiceType1
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
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
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType2.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType2 ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType2</b> (Item Choice Type 2).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02", IncludeInSchema=false)]
    public enum ItemChoiceType2
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
    /// Class <b>FinancialInstrument13</b> (Financial Instrument 13).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class FinancialInstrument13
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
    }
    
    /// <summary>
    /// Enumeration <b>DistributionPolicy1Code</b> (Distribution Policy 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
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
    /// Class <b>FinancialInstrumentQuantity1</b> (Financial Instrument Quantity 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class FinancialInstrumentQuantity1
    {
        
        /// <summary>
        /// Element <b>Unit</b> (Unit) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public decimal Unit;
    }
    
    /// <summary>
    /// Class <b>DateFormat1Choice</b> (Date Format 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class DateFormat1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Cd (Code) of type SettlementDate1Code 
        /// DtTm (Date Time) of type System.DateTime 
        /// </summary>
        [XmlElementAttribute("Cd", typeof(SettlementDate1Code), Order=0)]
        [XmlElementAttribute("Dt", typeof(System.DateTime), DataType="date", Order=0)]
        [XmlElementAttribute("DtTm", typeof(System.DateTime), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>SettlementDate1Code</b> (Settlement Date 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public enum SettlementDate1Code
    {
        
        /// <summary>
        /// <b>ASAP - As Soon As Possible</b>.
        /// </summary>
        ASAP,
        
        /// <summary>
        /// <b>ENDC - At End Of Contract</b>.
        /// </summary>
        ENDC,
        
        /// <summary>
        /// <b>WHIF - When And If Issued</b>.
        /// </summary>
        WHIF,
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType</b> (Item Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02", IncludeInSchema=false)]
    public enum ItemChoiceType
    {
        
        /// <summary>
        /// <b>Cd - Code</b>.
        /// </summary>
        Cd,
        
        /// <summary>
        /// <b>Dt - Date</b>.
        /// </summary>
        Dt,
        
        /// <summary>
        /// <b>DtTm - Date Time</b>.
        /// </summary>
        DtTm,
    }
    
    /// <summary>
    /// Class <b>Transfer5</b> (Transfer 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class Transfer5
    {
        
        /// <summary>
        /// Element <b>MstrRef</b> (Master Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string MstrRef;
        
        /// <summary>
        /// Element <b>TrfRef</b> (Transfer Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string TrfRef;
        
        /// <summary>
        /// Element <b>ClntRef</b> (Client Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string ClntRef;
        
        /// <summary>
        /// Element <b>TrfDt</b> (Transfer Date) of type DateFormat1Choice.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public DateFormat1Choice TrfDt;
        
        /// <summary>
        /// Element <b>TtlUnitsNb</b> (Total Units Number) of type FinancialInstrumentQuantity1.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public FinancialInstrumentQuantity1 TtlUnitsNb;
        
        /// <summary>
        /// Element <b>OwnAcctTrfInd</b> (Own Account Transfer Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public bool OwnAcctTrfInd;
        
        /// <summary>
        /// Element <b>OwnAcctTrfIndSpecified</b> (Own Account Transfer Indicator Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OwnAcctTrfIndSpecified;
        
        /// <summary>
        /// Element <b>NonStdSttlmInf</b> (Non Standard Settlement Information) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string NonStdSttlmInf;
    }
    
    /// <summary>
    /// Class <b>StructuredLongPostalAddress1</b> (Structured Long Postal Address 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class StructuredLongPostalAddress1
    {
        
        /// <summary>
        /// Element <b>BldgNm</b> (Building Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string BldgNm;
        
        /// <summary>
        /// Element <b>StrtNm</b> (Street Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string StrtNm;
        
        /// <summary>
        /// Element <b>StrtBldgId</b> (Street Building Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string StrtBldgId;
        
        /// <summary>
        /// Element <b>Flr</b> (Floor) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string Flr;
        
        /// <summary>
        /// Element <b>TwnNm</b> (Town Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string TwnNm;
        
        /// <summary>
        /// Element <b>DstrctNm</b> (District Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public string DstrctNm;
        
        /// <summary>
        /// Element <b>RgnId</b> (Region Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string RgnId;
        
        /// <summary>
        /// Element <b>Stat</b> (State) of type string.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public string Stat;
        
        /// <summary>
        /// Element <b>CtyId</b> (County Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public string CtyId;
        
        /// <summary>
        /// Element <b>Ctry</b> (Country) of type string.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public string Ctry;
        
        /// <summary>
        /// Element <b>PstCdId</b> (Post Code Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public string PstCdId;
        
        /// <summary>
        /// Element <b>POB</b> (PostOfficeBox) of type string.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public string POB;
    }
    
    /// <summary>
    /// Class <b>LongPostalAddress1Choice</b> (Long Postal Address 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class LongPostalAddress1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Strd (Structured) of type StructuredLongPostalAddress1 
        /// Ustrd (Unstructured) of type string 
        /// </summary>
        [XmlElementAttribute("Strd", typeof(StructuredLongPostalAddress1), Order=0)]
        [XmlElementAttribute("Ustrd", typeof(string), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>NameAndAddress2</b> (Name And Address 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class NameAndAddress2
    {
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Nm;
        
        /// <summary>
        /// Element <b>Adr</b> (Address) of type LongPostalAddress1Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public LongPostalAddress1Choice Adr;
    }
    
    /// <summary>
    /// Class <b>PartyIdentification1Choice</b> (Party Identification 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class PartyIdentification1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// BICOrBEI (BIC Or BEI) of type string 
        /// NmAndAdr (Name And Address) of type NameAndAddress2 
        /// PrtryId (Proprietary Identification) of type GenericIdentification1 
        /// </summary>
        [XmlElementAttribute("BICOrBEI", typeof(string), Order=0)]
        [XmlElementAttribute("NmAndAdr", typeof(NameAndAddress2), Order=0)]
        [XmlElementAttribute("PrtryId", typeof(GenericIdentification1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>AdditionalReference2</b> (Additional Reference 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:sese.005.001.02")]
    public class AdditionalReference2
    {
        
        /// <summary>
        /// Element <b>Ref</b> (Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Ref;
        
        /// <summary>
        /// Element <b>RefIssr</b> (Reference Issuer) of type PartyIdentification1Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification1Choice RefIssr;
        
        /// <summary>
        /// Element <b>MsgNm</b> (Message Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string MsgNm;
    }
}
