
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



namespace i20022.acmt00300102
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id acmt.003.001.02 name AccountModificationInstructionV02 from Account Management business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>AcctModInstrV02</b> (Account Modification Instruction V02) of type AccountModificationInstructionV02.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AccountModificationInstructionV02 AcctModInstrV02;
    }
    
    /// <summary>
    /// Class <b>AccountModificationInstructionV02</b> (Account Modification Instruction V02).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class AccountModificationInstructionV02
    {
        
        /// <summary>
        /// Element <b>MsgId</b> (Message Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public MessageIdentification1 MsgId;
        
        /// <summary>
        /// Element <b>PrvsRef</b> (Previous Reference) of type AdditionalReference3.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public AdditionalReference3 PrvsRef;
        
        /// <summary>
        /// Element <b>InstrDtls</b> (Instruction Details) of type InvestmentAccountModificationDetails.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public InvestmentAccountModificationDetails InstrDtls;
        
        /// <summary>
        /// Element <b>InvstmtAcctSelctn</b> (Investment Account Selection) of type InvestmentAccountSelection2.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public InvestmentAccountSelection2 InvstmtAcctSelctn;
        
        /// <summary>
        /// Element <b>ModfdInvstmtAcct</b> (Modified Investment Account) of type InvestmentAccount28.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public InvestmentAccount28 ModfdInvstmtAcct;
        
        /// <summary>
        /// Element <b>ModfdAcctPties</b> (Modified Account Parties) of type array of AccountParties4.
        /// </summary>
        [XmlElementAttribute("ModfdAcctPties", Order=5)]
        public AccountParties4[] ModfdAcctPties;
        
        /// <summary>
        /// Element <b>ModfdIntrmies</b> (Modified Intermediaries) of type array of ModificationScope7.
        /// </summary>
        [XmlElementAttribute("ModfdIntrmies", Order=6)]
        public ModificationScope7[] ModfdIntrmies;
        
        /// <summary>
        /// Element <b>ModfdPlcmnt</b> (Modified Placement) of type ReferredAgent1.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public ReferredAgent1 ModfdPlcmnt;
        
        /// <summary>
        /// Element <b>ModfdIsseAllcn</b> (Modified Issue Allocation) of type ModificationScope9.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public ModificationScope9 ModfdIsseAllcn;
        
        /// <summary>
        /// Element <b>ModfdSvgsInvstmtPlan</b> (Modified Savings Investment Plan) of type array of ModificationScope8.
        /// </summary>
        [XmlElementAttribute("ModfdSvgsInvstmtPlan", Order=9)]
        public ModificationScope8[] ModfdSvgsInvstmtPlan;
        
        /// <summary>
        /// Element <b>ModfdWdrwlInvstmtPlan</b> (Modified Withdrawal Investment Plan) of type array of ModificationScope8.
        /// </summary>
        [XmlElementAttribute("ModfdWdrwlInvstmtPlan", Order=10)]
        public ModificationScope8[] ModfdWdrwlInvstmtPlan;
        
        /// <summary>
        /// Element <b>ModfdCshSttlm</b> (Modified Cash Settlement) of type array of InvestmentFundCashSettlementInformation4.
        /// </summary>
        [XmlElementAttribute("ModfdCshSttlm", Order=11)]
        public InvestmentFundCashSettlementInformation4[] ModfdCshSttlm;
        
        /// <summary>
        /// Element <b>ModfdSvcLvlAgrmt</b> (Modified Service Level Agreement) of type array of ModificationScope10.
        /// </summary>
        [XmlElementAttribute("ModfdSvcLvlAgrmt", Order=12)]
        public ModificationScope10[] ModfdSvcLvlAgrmt;
        
        /// <summary>
        /// Element <b>Xtnsn</b> (Extension) of type array of Extension1.
        /// </summary>
        [XmlElementAttribute("Xtnsn", Order=13)]
        public Extension1[] Xtnsn;
    }
    
    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
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
    /// Class <b>DocumentToSend1</b> (Document To Send 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class DocumentToSend1
    {
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Tp;
        
        /// <summary>
        /// Element <b>Rcpt</b> (Recipient) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification2Choice Rcpt;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// MtdOfTrnsmssn (Method Of Transmission) of type CommunicationMethod1Code 
        /// XtndedMtdOfTrnsmssn (Extended Method Of Transmission) of type string 
        /// </summary>
        [XmlElementAttribute("MtdOfTrnsmssn", typeof(CommunicationMethod1Code), Order=2)]
        [XmlElementAttribute("XtndedMtdOfTrnsmssn", typeof(string), Order=2)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>PartyIdentification2Choice</b> (Party Identification 2Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
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
    /// Enumeration <b>CommunicationMethod1Code</b> (Communication Method 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public enum CommunicationMethod1Code
    {
        
        /// <summary>
        /// <b>SWMT - SWIFTMT</b>.
        /// </summary>
        SWMT,
        
        /// <summary>
        /// <b>SWMX - SWIFTMX</b>.
        /// </summary>
        SWMX,
        
        /// <summary>
        /// <b>FAXI - Fax</b>.
        /// </summary>
        FAXI,
        
        /// <summary>
        /// <b>EMAL - Email</b>.
        /// </summary>
        EMAL,
        
        /// <summary>
        /// <b>PROP - Proposed</b>.
        /// </summary>
        PROP,
    }
    
    /// <summary>
    /// Class <b>ModificationScope10</b> (Modification Scope 10).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class ModificationScope10
    {
        
        /// <summary>
        /// Element <b>ModScpIndctn</b> (Modification Scope Indication) of type DataModification1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DataModification1Code ModScpIndctn;
        
        /// <summary>
        /// Element <b>SvcLvlAgrmt</b> (Service Level Agreement) of type DocumentToSend1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public DocumentToSend1 SvcLvlAgrmt;
    }
    
    /// <summary>
    /// Enumeration <b>DataModification1Code</b> (Data Modification 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public enum DataModification1Code
    {
        
        /// <summary>
        /// <b>INSE - Insert New Data Set</b>.
        /// </summary>
        INSE,
        
        /// <summary>
        /// <b>UPDT - Update And Resend</b>.
        /// </summary>
        UPDT,
        
        /// <summary>
        /// <b>DELT - Delete Data Set</b>.
        /// </summary>
        DELT,
    }
    
    /// <summary>
    /// Class <b>Cheque4</b> (Cheque 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class Cheque4
    {
        
        /// <summary>
        /// Element <b>PyeeId</b> (Payee Identification) of type NameAndAddress5.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public NameAndAddress5 PyeeId;
    }
    
    /// <summary>
    /// Class <b>PaymentInstrument9</b> (Payment Instrument 9).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class PaymentInstrument9
    {
        
        /// <summary>
        /// Element <b>SttlmCcy</b> (Settlement Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string SttlmCcy;
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// [XOR] This element can be:
        /// BkrsDrftDtls (Bankers Draft Details) of type Cheque4 
        /// ChqDtls (Cheque Details) of type Cheque4 
        /// CshAcctDtls (Cash Account Details) of type CashAccount4 
        /// </summary>
        [XmlElementAttribute("BkrsDrftDtls", typeof(Cheque4), Order=1)]
        [XmlElementAttribute("ChqDtls", typeof(Cheque4), Order=1)]
        [XmlElementAttribute("CshAcctDtls", typeof(CashAccount4), Order=1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items;
        
        /// <summary>
        /// Element <b>ItemsElementName</b> (Items Element Name) of type array of ItemsChoiceType2.
        /// </summary>
        [XmlElementAttribute("ItemsElementName", Order=2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType2[] ItemsElementName;
    }
    
    /// <summary>
    /// Class <b>CashAccount4</b> (Cash Account 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class CashAccount4
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type AccountIdentificationAndName3.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AccountIdentificationAndName3 Id;
        
        /// <summary>
        /// Element <b>AcctOwnr</b> (Account Owner) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification2Choice AcctOwnr;
        
        /// <summary>
        /// Element <b>AcctSvcr</b> (Account Servicer) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PartyIdentification2Choice AcctSvcr;
        
        /// <summary>
        /// Element <b>AcctSvcrBrnch</b> (Account Servicer Branch) of type BranchData.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public BranchData AcctSvcrBrnch;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// InvstmtAcctTp (Investment Account Type) of type FundCashAccount2Code 
        /// XtndedInvstmtAcctTp (Extended Investment Account Type) of type string 
        /// </summary>
        [XmlElementAttribute("InvstmtAcctTp", typeof(FundCashAccount2Code), Order=4)]
        [XmlElementAttribute("XtndedInvstmtAcctTp", typeof(string), Order=4)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>AccountIdentificationAndName3</b> (Account Identification And Name 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class AccountIdentificationAndName3
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type CashAccountIdentification1Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CashAccountIdentification1Choice Id;
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Nm;
    }
    
    /// <summary>
    /// Class <b>CashAccountIdentification1Choice</b> (Cash Account Identification 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class CashAccountIdentification1Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// BBAN (BBAN) of type string 
        /// DmstAcct (Domestic Account) of type SimpleIdentificationInformation 
        /// IBAN (IBAN) of type string 
        /// UPIC (UPIC) of type string 
        /// </summary>
        [XmlElementAttribute("BBAN", typeof(string), Order=0)]
        [XmlElementAttribute("DmstAcct", typeof(SimpleIdentificationInformation), Order=0)]
        [XmlElementAttribute("IBAN", typeof(string), Order=0)]
        [XmlElementAttribute("UPIC", typeof(string), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType3.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType3 ItemElementName;
    }
    
    /// <summary>
    /// Class <b>SimpleIdentificationInformation</b> (Simple Identification Information).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class SimpleIdentificationInformation
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType3</b> (Item Choice Type 3).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02", IncludeInSchema=false)]
    public enum ItemChoiceType3
    {
        
        /// <summary>
        /// <b>BBAN - Basic Bank Account Number</b>.
        /// </summary>
        BBAN,
        
        /// <summary>
        /// <b>DmstAcct - Domestic Account</b>.
        /// </summary>
        DmstAcct,
        
        /// <summary>
        /// <b>IBAN - International Bank Account Number</b>.
        /// </summary>
        IBAN,
        
        /// <summary>
        /// <b>UPIC - Universal Promotional Identification Code</b>.
        /// </summary>
        UPIC,
    }
    
    /// <summary>
    /// Class <b>BranchData</b> (Branch Data).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class BranchData
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Nm;
        
        /// <summary>
        /// Element <b>PstlAdr</b> (Postal Address) of type PostalAddress1.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PostalAddress1 PstlAdr;
    }
    
    /// <summary>
    /// Enumeration <b>FundCashAccount2Code</b> (Fund Cash Account 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public enum FundCashAccount2Code
    {
        
        /// <summary>
        /// <b>CASH - Cash</b>.
        /// </summary>
        CASH,
        
        /// <summary>
        /// <b>CPFO - Pension Fund Ordinary</b>.
        /// </summary>
        CPFO,
        
        /// <summary>
        /// <b>CPFS - Pension Fund Special</b>.
        /// </summary>
        CPFS,
        
        /// <summary>
        /// <b>SRSA - Retirement Scheme</b>.
        /// </summary>
        SRSA,
    }
    
    /// <summary>
    /// Enumeration <b>ItemsChoiceType2</b> (Items Choice Type 2).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02", IncludeInSchema=false)]
    public enum ItemsChoiceType2
    {
        
        /// <summary>
        /// <b>BkrsDrftDtls - Bankers Draft Details</b>.
        /// </summary>
        BkrsDrftDtls,
        
        /// <summary>
        /// <b>ChqDtls - Cheque Details</b>.
        /// </summary>
        ChqDtls,
        
        /// <summary>
        /// <b>CshAcctDtls - Cash Account Details</b>.
        /// </summary>
        CshAcctDtls,
    }
    
    /// <summary>
    /// Class <b>ClearingSystemMemberIdentificationChoice</b> (Clearing System Member Identification Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class ClearingSystemMemberIdentificationChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type string.
        /// </summary>
        [XmlElementAttribute("ATBLZ", typeof(string), Order=0)]
        [XmlElementAttribute("AUBSBs", typeof(string), Order=0)]
        [XmlElementAttribute("AUBSBx", typeof(string), Order=0)]
        [XmlElementAttribute("CACPA", typeof(string), Order=0)]
        [XmlElementAttribute("CHBC", typeof(string), Order=0)]
        [XmlElementAttribute("CHSIC", typeof(string), Order=0)]
        [XmlElementAttribute("DEBLZ", typeof(string), Order=0)]
        [XmlElementAttribute("ESNCC", typeof(string), Order=0)]
        [XmlElementAttribute("GBSC", typeof(string), Order=0)]
        [XmlElementAttribute("HKNCC", typeof(string), Order=0)]
        [XmlElementAttribute("IENSC", typeof(string), Order=0)]
        [XmlElementAttribute("ITNCC", typeof(string), Order=0)]
        [XmlElementAttribute("NZNCC", typeof(string), Order=0)]
        [XmlElementAttribute("PTNCC", typeof(string), Order=0)]
        [XmlElementAttribute("RUCB", typeof(string), Order=0)]
        [XmlElementAttribute("USCH", typeof(string), Order=0)]
        [XmlElementAttribute("USCHU", typeof(string), Order=0)]
        [XmlElementAttribute("USFW", typeof(string), Order=0)]
        [XmlElementAttribute("ZANCC", typeof(string), Order=0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item;
        
        /// <summary>
        /// Element <b>ItemElementName</b> (Item Element Name) of type ItemChoiceType4.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType4 ItemElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemChoiceType4</b> (Item Choice Type 4).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02", IncludeInSchema=false)]
    public enum ItemChoiceType4
    {
        
        /// <summary>
        /// <b>ATBLZ - Austrian Bankleitzahl Identifier</b>.
        /// </summary>
        ATBLZ,
        
        /// <summary>
        /// <b>AUBSBs - Small Network Identifier</b>.
        /// </summary>
        AUBSBs,
        
        /// <summary>
        /// <b>AUBSBx - Extensive Branch Network Identifier</b>.
        /// </summary>
        AUBSBx,
        
        /// <summary>
        /// <b>CACPA - Canadian Payments ARN Identifier</b>.
        /// </summary>
        CACPA,
        
        /// <summary>
        /// <b>CHBC - Swiss BC Identifier</b>.
        /// </summary>
        CHBC,
        
        /// <summary>
        /// <b>CHSIC - Swiss SIC Identifier</b>.
        /// </summary>
        CHSIC,
        
        /// <summary>
        /// <b>DEBLZ - German Bankleitzahl Identifier</b>.
        /// </summary>
        DEBLZ,
        
        /// <summary>
        /// <b>ESNCC - Spanish Domestic Interbanking Identifier</b>.
        /// </summary>
        ESNCC,
        
        /// <summary>
        /// <b>GBSC - UK Domestic Sort Code Identifier</b>.
        /// </summary>
        GBSC,
        
        /// <summary>
        /// <b>HKNCC - Hong Kong Bank Identifier</b>.
        /// </summary>
        HKNCC,
        
        /// <summary>
        /// <b>IENSC - Irish NSC Identifier</b>.
        /// </summary>
        IENSC,
        
        /// <summary>
        /// <b>ITNCC - Italian Domestic Identifier</b>.
        /// </summary>
        ITNCC,
        
        /// <summary>
        /// <b>NZNCC - New Zealand NCC Identifier</b>.
        /// </summary>
        NZNCC,
        
        /// <summary>
        /// <b>PTNCC - Portuguese NCC Identifier</b>.
        /// </summary>
        PTNCC,
        
        /// <summary>
        /// <b>RUCB - Russian Central Bank Identification Code Identifier</b>.
        /// </summary>
        RUCB,
        
        /// <summary>
        /// <b>USCH - CHIPS Participant Identifier</b>.
        /// </summary>
        USCH,
        
        /// <summary>
        /// <b>USCHU - CHIPS Universal Identifier</b>.
        /// </summary>
        USCHU,
        
        /// <summary>
        /// <b>USFW - Fedwire Routing Number Identifier</b>.
        /// </summary>
        USFW,
        
        /// <summary>
        /// <b>ZANCC - South African NCC Identifier</b>.
        /// </summary>
        ZANCC,
    }
    
    /// <summary>
    /// Class <b>FinancialInstitutionIdentification3Choice</b> (Financial Institution Identification 3Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class FinancialInstitutionIdentification3Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// BIC (BIC) of type string 
        /// ClrSysMmbId (Clearing System Member Identification) of type ClearingSystemMemberIdentificationChoice 
        /// NmAndAdr (Name And Address) of type NameAndAddress5 
        /// PrtryId (Proprietary Identification) of type SimpleIdentificationInformation 
        /// </summary>
        [XmlElementAttribute("BIC", typeof(string), Order=0)]
        [XmlElementAttribute("ClrSysMmbId", typeof(ClearingSystemMemberIdentificationChoice), Order=0)]
        [XmlElementAttribute("NmAndAdr", typeof(NameAndAddress5), Order=0)]
        [XmlElementAttribute("PrtryId", typeof(SimpleIdentificationInformation), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>DirectDebitMandate4</b> (Direct Debit Mandate 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class DirectDebitMandate4
    {
        
        /// <summary>
        /// Element <b>DbtrAcct</b> (Debtor Account) of type AccountIdentificationAndName3.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AccountIdentificationAndName3 DbtrAcct;
        
        /// <summary>
        /// Element <b>Dbtr</b> (Debtor) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification2Choice Dbtr;
        
        /// <summary>
        /// Element <b>DbtrTaxIdNb</b> (Debtor Tax Identification Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string DbtrTaxIdNb;
        
        /// <summary>
        /// Element <b>DbtrNtlRegnNb</b> (Debtor National Registration Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string DbtrNtlRegnNb;
        
        /// <summary>
        /// Element <b>Cdtr</b> (Creditor) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public PartyIdentification2Choice Cdtr;
        
        /// <summary>
        /// Element <b>DbtrAgt</b> (Debtor Agent) of type FinancialInstitutionIdentification3Choice.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public FinancialInstitutionIdentification3Choice DbtrAgt;
        
        /// <summary>
        /// Element <b>DbtrAgtBrnch</b> (Debtor Agent Branch) of type BranchData.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public BranchData DbtrAgtBrnch;
        
        /// <summary>
        /// Element <b>CdtrAgt</b> (Creditor Agent) of type FinancialInstitutionIdentification3Choice.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public FinancialInstitutionIdentification3Choice CdtrAgt;
        
        /// <summary>
        /// Element <b>CdtrAgtBrnch</b> (Creditor Agent Branch) of type BranchData.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public BranchData CdtrAgtBrnch;
        
        /// <summary>
        /// Element <b>RegnId</b> (Registration Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public string RegnId;
        
        /// <summary>
        /// Element <b>MndtId</b> (Mandate Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public string MndtId;
    }
    
    /// <summary>
    /// Class <b>PaymentCard2</b> (Payment Card 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class PaymentCard2
    {
        
        /// <summary>
        /// Element <b>Tp</b> (Type) of type CardType1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CardType1Code Tp;
        
        /// <summary>
        /// Element <b>Nb</b> (Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Nb;
        
        /// <summary>
        /// Element <b>HldrNm</b> (Holder Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string HldrNm;
        
        /// <summary>
        /// Element <b>StartDt</b> (Start Date) of type string.
        /// </summary>
        [XmlElementAttribute(DataType="gYearMonth", Order=3)]
        public string StartDt;
        
        /// <summary>
        /// Element <b>XpryDt</b> (Expiry Date) of type string.
        /// </summary>
        [XmlElementAttribute(DataType="gYearMonth", Order=4)]
        public string XpryDt;
        
        /// <summary>
        /// Element <b>CardIssrNm</b> (Card Issuer Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public string CardIssrNm;
        
        /// <summary>
        /// Element <b>CardIssrId</b> (Card Issuer Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public PartyIdentification2Choice CardIssrId;
        
        /// <summary>
        /// Element <b>SctyCd</b> (Security Code) of type string.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public string SctyCd;
        
        /// <summary>
        /// Element <b>SeqNb</b> (Sequence Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public string SeqNb;
    }
    
    /// <summary>
    /// Enumeration <b>CardType1Code</b> (Card Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public enum CardType1Code
    {
        
        /// <summary>
        /// <b>CRDT - Credit Card</b>.
        /// </summary>
        CRDT,
        
        /// <summary>
        /// <b>DBIT - Debit Card</b>.
        /// </summary>
        DBIT,
    }
    
    /// <summary>
    /// Class <b>PaymentInstrument8</b> (Payment Instrument 8).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class PaymentInstrument8
    {
        
        /// <summary>
        /// Element <b>SttlmCcy</b> (Settlement Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string SttlmCcy;
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// [XOR] This element can be:
        /// BkrsDrft (Bankers Draft) of type bool 
        /// Chq (Cheque) of type bool 
        /// CshAcctDtls (Cash Account Details) of type CashAccount4 
        /// DrctDbtDtls (Direct Debit Details) of type DirectDebitMandate4 
        /// PmtCardDtls (Payment Card Details) of type PaymentCard2 
        /// </summary>
        [XmlElementAttribute("BkrsDrft", typeof(bool), Order=1)]
        [XmlElementAttribute("Chq", typeof(bool), Order=1)]
        [XmlElementAttribute("CshAcctDtls", typeof(CashAccount4), Order=1)]
        [XmlElementAttribute("DrctDbtDtls", typeof(DirectDebitMandate4), Order=1)]
        [XmlElementAttribute("PmtCardDtls", typeof(PaymentCard2), Order=1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items;
        
        /// <summary>
        /// Element <b>ItemsElementName</b> (Items Element Name) of type array of ItemsChoiceType1.
        /// </summary>
        [XmlElementAttribute("ItemsElementName", Order=2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName;
    }
    
    /// <summary>
    /// Enumeration <b>ItemsChoiceType1</b> (Items Choice Type 1).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02", IncludeInSchema=false)]
    public enum ItemsChoiceType1
    {
        
        /// <summary>
        /// <b>BkrsDrft - Bankers Draft</b>.
        /// </summary>
        BkrsDrft,
        
        /// <summary>
        /// <b>Chq - Cheque</b>.
        /// </summary>
        Chq,
        
        /// <summary>
        /// <b>CshAcctDtls - Cash Account Details</b>.
        /// </summary>
        CshAcctDtls,
        
        /// <summary>
        /// <b>DrctDbtDtls - Direct Debit Details</b>.
        /// </summary>
        DrctDbtDtls,
        
        /// <summary>
        /// <b>PmtCardDtls - Payment Card Details</b>.
        /// </summary>
        PmtCardDtls,
    }
    
    /// <summary>
    /// Class <b>InvestmentFundCashSettlementInformation4</b> (Investment Fund Cash Settlement Information 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class InvestmentFundCashSettlementInformation4
    {
        
        /// <summary>
        /// Element <b>ModScpIndctn</b> (Modification Scope Indication) of type DataModification2Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DataModification2Code ModScpIndctn;
        
        /// <summary>
        /// Element <b>SbcptPmtInstrm</b> (Subscription Payment Instrument) of type PaymentInstrument8.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PaymentInstrument8 SbcptPmtInstrm;
        
        /// <summary>
        /// Element <b>RedPmtInstrm</b> (Redemption Payment Instrument) of type PaymentInstrument9.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public PaymentInstrument9 RedPmtInstrm;
        
        /// <summary>
        /// Element <b>DvddPmtInstrm</b> (Dividend Payment Instrument) of type PaymentInstrument9.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public PaymentInstrument9 DvddPmtInstrm;
        
        /// <summary>
        /// Element <b>SvgsPlanPmtInstrm</b> (Savings Plan Payment Instrument) of type PaymentInstrument8.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public PaymentInstrument8 SvgsPlanPmtInstrm;
    }
    
    /// <summary>
    /// Enumeration <b>DataModification2Code</b> (Data Modification 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public enum DataModification2Code
    {
        
        /// <summary>
        /// <b>INSE - Insert New Data Set</b>.
        /// </summary>
        INSE,
        
        /// <summary>
        /// <b>DELT - Delete Data Set</b>.
        /// </summary>
        DELT,
    }
    
    /// <summary>
    /// Class <b>Repartition1</b> (Repartition 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class Repartition1
    {
        
        /// <summary>
        /// Element <b>Pctg</b> (Percentage) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public decimal Pctg;
        
        /// <summary>
        /// Element <b>FinInstrm</b> (Financial Instrument) of type FinancialInstrument10.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public FinancialInstrument10 FinInstrm;
    }
    
    /// <summary>
    /// Class <b>FinancialInstrument10</b> (Financial Instrument 10).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
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
    /// Class <b>SecurityIdentification3Choice</b> (Security Identification 3Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
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
    /// Class <b>AlternateSecurityIdentification1</b> (Alternate Security Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02", IncludeInSchema=false)]
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
    /// Enumeration <b>ItemChoiceType1</b> (Item Choice Type 1).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02", IncludeInSchema=false)]
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
    /// Enumeration <b>FormOfSecurity1Code</b> (Form Of Security 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
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
    /// Class <b>ActiveCurrencyAndAmount</b> (Active Currency And Amount).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
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
    /// Class <b>InvestmentPlan5</b> (Investment Plan 5).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class InvestmentPlan5
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Frqcy (Frequency) of type EventFrequency1Code 
        /// XtndedFrqcy (Extended Frequency) of type string 
        /// </summary>
        [XmlElementAttribute("Frqcy", typeof(EventFrequency1Code), Order=0)]
        [XmlElementAttribute("XtndedFrqcy", typeof(string), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>StartDt</b> (Start Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=1)]
        public System.DateTime StartDt;
        
        /// <summary>
        /// Element <b>EndDt</b> (End Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=2)]
        public System.DateTime EndDt;
        
        /// <summary>
        /// Element <b>EndDtSpecified</b> (End Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndDtSpecified;
        
        /// <summary>
        /// Element <b>Amt</b> (Amount) of type ActiveCurrencyAndAmount.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public ActiveCurrencyAndAmount Amt;
        
        /// <summary>
        /// Element <b>GrssAmtInd</b> (Gross Amount Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public bool GrssAmtInd;
        
        /// <summary>
        /// Element <b>GrssAmtIndSpecified</b> (Gross Amount Indicator Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GrssAmtIndSpecified;
        
        /// <summary>
        /// Element <b>IncmPref</b> (Income Preference) of type IncomePreference1Code.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public IncomePreference1Code IncmPref;
        
        /// <summary>
        /// Element <b>IncmPrefSpecified</b> (Income Preference Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncmPrefSpecified;
        
        /// <summary>
        /// Element <b>InitlNbOfInstlmt</b> (Initial Number Of Instalment) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public decimal InitlNbOfInstlmt;
        
        /// <summary>
        /// Element <b>InitlNbOfInstlmtSpecified</b> (Initial Number Of Instalment Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InitlNbOfInstlmtSpecified;
        
        /// <summary>
        /// Element <b>TtlNbOfInstlmt</b> (Total Number Of Instalment) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public decimal TtlNbOfInstlmt;
        
        /// <summary>
        /// Element <b>TtlNbOfInstlmtSpecified</b> (Total Number Of Instalment Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TtlNbOfInstlmtSpecified;
        
        /// <summary>
        /// Element <b>RndgDrctn</b> (Rounding Direction) of type RoundingDirection1Code.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public RoundingDirection1Code RndgDrctn;
        
        /// <summary>
        /// Element <b>RndgDrctnSpecified</b> (Rounding Direction Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RndgDrctnSpecified;
        
        /// <summary>
        /// Element <b>SctyDtls</b> (Security Details) of type array of Repartition1.
        /// </summary>
        [XmlElementAttribute("SctyDtls", Order=9)]
        public Repartition1[] SctyDtls;
        
        /// <summary>
        /// Element <b>ModfdCshSttlm</b> (Modified Cash Settlement) of type array of InvestmentFundCashSettlementInformation4.
        /// </summary>
        [XmlElementAttribute("ModfdCshSttlm", Order=10)]
        public InvestmentFundCashSettlementInformation4[] ModfdCshSttlm;
    }
    
    /// <summary>
    /// Enumeration <b>EventFrequency1Code</b> (Event Frequency 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public enum EventFrequency1Code
    {
        
        /// <summary>
        /// <b>YEAR - Annual</b>.
        /// </summary>
        YEAR,
        
        /// <summary>
        /// <b>SEMI - Semi Annual</b>.
        /// </summary>
        SEMI,
        
        /// <summary>
        /// <b>QUTR - Quarterly</b>.
        /// </summary>
        QUTR,
        
        /// <summary>
        /// <b>TOMN - Every Two Months</b>.
        /// </summary>
        TOMN,
        
        /// <summary>
        /// <b>MNTH - Monthly</b>.
        /// </summary>
        MNTH,
        
        /// <summary>
        /// <b>TWMN - Twice A Month</b>.
        /// </summary>
        TWMN,
        
        /// <summary>
        /// <b>TOWK - Every Two Weeks</b>.
        /// </summary>
        TOWK,
        
        /// <summary>
        /// <b>WEEK - Weekly</b>.
        /// </summary>
        WEEK,
        
        /// <summary>
        /// <b>DAIL - Daily</b>.
        /// </summary>
        DAIL,
        
        /// <summary>
        /// <b>ADHO - Adhoc</b>.
        /// </summary>
        ADHO,
        
        /// <summary>
        /// <b>INDA - Intra Day</b>.
        /// </summary>
        INDA,
        
        /// <summary>
        /// <b>OVNG - Overnight</b>.
        /// </summary>
        OVNG,
        
        /// <summary>
        /// <b>ONDE - On Demand</b>.
        /// </summary>
        ONDE,
    }
    
    /// <summary>
    /// Enumeration <b>IncomePreference1Code</b> (Income Preference 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
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
    /// Enumeration <b>RoundingDirection1Code</b> (Rounding Direction 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public enum RoundingDirection1Code
    {
        
        /// <summary>
        /// <b>RDUP - Round Up</b>.
        /// </summary>
        RDUP,
        
        /// <summary>
        /// <b>RDWN - Round Down</b>.
        /// </summary>
        RDWN,
        
        /// <summary>
        /// <b>STAN - Round To Nearest</b>.
        /// </summary>
        STAN,
        
        /// <summary>
        /// <b>DIST - Distribution</b>.
        /// </summary>
        DIST,
    }
    
    /// <summary>
    /// Class <b>ModificationScope8</b> (Modification Scope 8).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class ModificationScope8
    {
        
        /// <summary>
        /// Element <b>ModScpIndctn</b> (Modification Scope Indication) of type DataModification1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DataModification1Code ModScpIndctn;
        
        /// <summary>
        /// Element <b>InvstmtPlan</b> (Investment Plan) of type InvestmentPlan5.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public InvestmentPlan5 InvstmtPlan;
    }
    
    /// <summary>
    /// Class <b>DeMinimusNotApplicable1</b> (De Minimus Not Applicable 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class DeMinimusNotApplicable1
    {
        
        /// <summary>
        /// Element <b>RstrctdPrsnRsn</b> (Restricted Person Reason) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string RstrctdPrsnRsn;
    }
    
    /// <summary>
    /// Class <b>DeMinimusApplicable1</b> (De Minimus Applicable 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class DeMinimusApplicable1
    {
        
        /// <summary>
        /// Element <b>NewIssePrmssn</b> (New Issue Permission) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public bool NewIssePrmssn;
        
        /// <summary>
        /// Element <b>Pctg</b> (Percentage) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public decimal Pctg;
        
        /// <summary>
        /// Element <b>PctgSpecified</b> (Percentage Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PctgSpecified;
    }
    
    /// <summary>
    /// Class <b>NewIssueAllocation1</b> (New Issue Allocation 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class NewIssueAllocation1
    {
        
        /// <summary>
        /// Element <b>Rstrctd</b> (Restricted) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public bool Rstrctd;
        
        /// <summary>
        /// Element <b>XmptPrsnRsn</b> (Exempt Person Reason) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string XmptPrsnRsn;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// DeMnmsAplbl (De Minimus Applicable) of type DeMinimusApplicable1 
        /// DeMnmsNotAplbl (De Minimus Not Applicable) of type DeMinimusNotApplicable1 
        /// </summary>
        [XmlElementAttribute("DeMnmsAplbl", typeof(DeMinimusApplicable1), Order=2)]
        [XmlElementAttribute("DeMnmsNotAplbl", typeof(DeMinimusNotApplicable1), Order=2)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>ModificationScope9</b> (Modification Scope 9).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class ModificationScope9
    {
        
        /// <summary>
        /// Element <b>ModScpIndctn</b> (Modification Scope Indication) of type DataModification1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DataModification1Code ModScpIndctn;
        
        /// <summary>
        /// Element <b>IsseAllcn</b> (Issue Allocation) of type NewIssueAllocation1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public NewIssueAllocation1 IsseAllcn;
    }
    
    /// <summary>
    /// Class <b>ReferredAgent1</b> (Referred Agent 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class ReferredAgent1
    {
        
        /// <summary>
        /// Element <b>Rfrd</b> (Referred) of type Referred1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public Referred1Code Rfrd;
        
        /// <summary>
        /// Element <b>RfrdPlcmntAgt</b> (Referred Placement Agent) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification2Choice RfrdPlcmntAgt;
    }
    
    /// <summary>
    /// Enumeration <b>Referred1Code</b> (Referred 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public enum Referred1Code
    {
        
        /// <summary>
        /// <b>REFR - Referred</b>.
        /// </summary>
        REFR,
        
        /// <summary>
        /// <b>NRFR - Not Referred</b>.
        /// </summary>
        NRFR,
        
        /// <summary>
        /// <b>UKNW - Unknown Case</b>.
        /// </summary>
        UKNW,
    }
    
    /// <summary>
    /// Class <b>Intermediary13</b> (Intermediary 13).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class Intermediary13
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type PartyIdentification4Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PartyIdentification4Choice Id;
        
        /// <summary>
        /// Element <b>Acct</b> (Account) of type Account2.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public Account2 Acct;
        
        /// <summary>
        /// Element <b>WvdTrlrComssnInd</b> (Waived Trailer Commission Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public bool WvdTrlrComssnInd;
        
        /// <summary>
        /// Element <b>WvdTrlrComssnIndSpecified</b> (Waived Trailer Commission Indicator Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WvdTrlrComssnIndSpecified;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Role (Role) of type InvestmentFundRole3Code 
        /// XtndedRole (Extended Role) of type string 
        /// </summary>
        [XmlElementAttribute("Role", typeof(InvestmentFundRole3Code), Order=3)]
        [XmlElementAttribute("XtndedRole", typeof(string), Order=3)]
        public object Item;
        
        /// <summary>
        /// Element <b>PmryComAdr</b> (Primary Communication Address) of type CommunicationAddress3.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public CommunicationAddress3 PmryComAdr;
        
        /// <summary>
        /// Element <b>ScndryComAdr</b> (Secondary Communication Address) of type CommunicationAddress3.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public CommunicationAddress3 ScndryComAdr;
        
        /// <summary>
        /// Element <b>NmAndAdr</b> (Name And Address) of type NameAndAddress4.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public NameAndAddress4 NmAndAdr;
    }
    
    /// <summary>
    /// Class <b>PartyIdentification4Choice</b> (Party Identification 4Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class PartyIdentification4Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// BICOrBEI (BIC Or BEI) of type string 
        /// PrtryId (Proprietary Identification) of type GenericIdentification1 
        /// </summary>
        [XmlElementAttribute("BICOrBEI", typeof(string), Order=0)]
        [XmlElementAttribute("PrtryId", typeof(GenericIdentification1), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>Account2</b> (Account 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class Account2
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
    /// Class <b>AccountIdentification1</b> (Account Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class AccountIdentification1
    {
        
        /// <summary>
        /// Element <b>Prtry</b> (Proprietary) of type SimpleIdentificationInformation.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public SimpleIdentificationInformation Prtry;
    }
    
    /// <summary>
    /// Enumeration <b>InvestmentFundRole3Code</b> (Investment Fund Role 3Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public enum InvestmentFundRole3Code
    {
        
        /// <summary>
        /// <b>CACO - Cash Correspondent</b>.
        /// </summary>
        CACO,
        
        /// <summary>
        /// <b>CUST - Custodial Account</b>.
        /// </summary>
        CUST,
        
        /// <summary>
        /// <b>DATP - Data Provider</b>.
        /// </summary>
        DATP,
        
        /// <summary>
        /// <b>FIAG - Final Agent</b>.
        /// </summary>
        FIAG,
        
        /// <summary>
        /// <b>FMCO - Fund Management Company</b>.
        /// </summary>
        FMCO,
        
        /// <summary>
        /// <b>FACT - Fund Accountant</b>.
        /// </summary>
        FACT,
        
        /// <summary>
        /// <b>INVS - Investor</b>.
        /// </summary>
        INVS,
        
        /// <summary>
        /// <b>INVE - Under Investigation</b>.
        /// </summary>
        INVE,
        
        /// <summary>
        /// <b>PAYI - Paying Agent</b>.
        /// </summary>
        PAYI,
        
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
        /// <b>FNBR - Fund Broker</b>.
        /// </summary>
        FNBR,
        
        /// <summary>
        /// <b>FTAG - First Agent</b>.
        /// </summary>
        FTAG,
        
        /// <summary>
        /// <b>FIAD - Financial Advisor</b>.
        /// </summary>
        FIAD,
        
        /// <summary>
        /// <b>DIST - Distribution</b>.
        /// </summary>
        DIST,
        
        /// <summary>
        /// <b>CONC - Concentrator</b>.
        /// </summary>
        CONC,
    }
    
    /// <summary>
    /// Class <b>CommunicationAddress3</b> (Communication Address 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class CommunicationAddress3
    {
        
        /// <summary>
        /// Element <b>Email</b> (Email) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Email;
        
        /// <summary>
        /// Element <b>Phne</b> (Phone) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Phne;
        
        /// <summary>
        /// Element <b>Mob</b> (Mobile) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Mob;
        
        /// <summary>
        /// Element <b>FaxNb</b> (Fax Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string FaxNb;
        
        /// <summary>
        /// Element <b>TlxAdr</b> (Telex Address) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string TlxAdr;
        
        /// <summary>
        /// Element <b>URLAdr</b> (URL Address) of type string.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public string URLAdr;
    }
    
    /// <summary>
    /// Class <b>NameAndAddress4</b> (Name And Address 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
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
    /// Class <b>ModificationScope7</b> (Modification Scope 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class ModificationScope7
    {
        
        /// <summary>
        /// Element <b>ModScpIndctn</b> (Modification Scope Indication) of type DataModification1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DataModification1Code ModScpIndctn;
        
        /// <summary>
        /// Element <b>Intrmy</b> (Intermediary) of type Intermediary13.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public Intermediary13 Intrmy;
    }
    
    /// <summary>
    /// Class <b>ExtendedParty1</b> (Extended Party 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class ExtendedParty1
    {
        
        /// <summary>
        /// Element <b>XtndedPtyRole</b> (Extended Party Role) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string XtndedPtyRole;
        
        /// <summary>
        /// Element <b>OthrPtyDtls</b> (Other Party Details) of type InvestmentAccountOwnershipInformation4.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public InvestmentAccountOwnershipInformation4 OthrPtyDtls;
    }
    
    /// <summary>
    /// Class <b>InvestmentAccountOwnershipInformation4</b> (Investment Account Ownership Information 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class InvestmentAccountOwnershipInformation4
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// IndvPrsn (Individual Person) of type IndividualPerson11 
        /// Org (Organisation) of type Organisation3 
        /// </summary>
        [XmlElementAttribute("IndvPrsn", typeof(IndividualPerson11), Order=0)]
        [XmlElementAttribute("Org", typeof(Organisation3), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>Item1</b> (Item 1) of type object.
        /// [XOR] This element can be:
        /// MnyLndrgChck (Money Laundering Check) of type MoneyLaunderingCheck1Code 
        /// XtndedMnyLndrgChck (Extended Money Laundering Check) of type string 
        /// </summary>
        [XmlElementAttribute("MnyLndrgChck", typeof(MoneyLaunderingCheck1Code), Order=1)]
        [XmlElementAttribute("XtndedMnyLndrgChck", typeof(string), Order=1)]
        public object Item1;
        
        /// <summary>
        /// Element <b>OwnrshBnfcryRate</b> (Ownership Beneficiary Rate) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public decimal OwnrshBnfcryRate;
        
        /// <summary>
        /// Element <b>OwnrshBnfcryRateSpecified</b> (Ownership Beneficiary Rate Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OwnrshBnfcryRateSpecified;
        
        /// <summary>
        /// Element <b>ClntId</b> (Client Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string ClntId;
        
        /// <summary>
        /// Element <b>FsclXmptn</b> (Fiscal Exemption) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public bool FsclXmptn;
        
        /// <summary>
        /// Element <b>FsclXmptnSpecified</b> (Fiscal Exemption Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FsclXmptnSpecified;
        
        /// <summary>
        /// Element <b>SgntryRghtInd</b> (Signatory Right Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public bool SgntryRghtInd;
        
        /// <summary>
        /// Element <b>SgntryRghtIndSpecified</b> (Signatory Right Indicator Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SgntryRghtIndSpecified;
        
        /// <summary>
        /// Element <b>ModfdInvstrPrflVldtn</b> (Modified Investor Profile Validation) of type array of ModificationScope11.
        /// </summary>
        [XmlElementAttribute("ModfdInvstrPrflVldtn", Order=6)]
        public ModificationScope11[] ModfdInvstrPrflVldtn;
    }
    
    /// <summary>
    /// Class <b>IndividualPerson11</b> (Individual Person 11).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class IndividualPerson11
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// NmPrfx (Name Prefix) of type NamePrefix1Code 
        /// XtndedNmPrfx (Extended Name Prefix) of type string 
        /// </summary>
        [XmlElementAttribute("NmPrfx", typeof(NamePrefix1Code), Order=0)]
        [XmlElementAttribute("XtndedNmPrfx", typeof(string), Order=0)]
        public object Item;
        
        /// <summary>
        /// Element <b>GvnNm</b> (Given Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string GvnNm;
        
        /// <summary>
        /// Element <b>MddlNm</b> (Middle Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string MddlNm;
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string Nm;
        
        /// <summary>
        /// Element <b>NmSfx</b> (Name Suffix) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string NmSfx;
        
        /// <summary>
        /// Element <b>Gndr</b> (Gender) of type GenderCode.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public GenderCode Gndr;
        
        /// <summary>
        /// Element <b>GndrSpecified</b> (Gender Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GndrSpecified;
        
        /// <summary>
        /// Element <b>Lang</b> (Language) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string Lang;
        
        /// <summary>
        /// Element <b>BirthDt</b> (Birth Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=7)]
        public System.DateTime BirthDt;
        
        /// <summary>
        /// Element <b>CtryOfBirth</b> (Country Of Birth) of type string.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public string CtryOfBirth;
        
        /// <summary>
        /// Element <b>PrvcOfBirth</b> (Province Of Birth) of type string.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public string PrvcOfBirth;
        
        /// <summary>
        /// Element <b>CityOfBirth</b> (City Of Birth) of type string.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public string CityOfBirth;
        
        /// <summary>
        /// Element <b>Prfssn</b> (Profession) of type string.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public string Prfssn;
        
        /// <summary>
        /// Element <b>TaxtnCtry</b> (Taxation Country) of type string.
        /// </summary>
        [XmlElementAttribute(Order=12)]
        public string TaxtnCtry;
        
        /// <summary>
        /// Element <b>CtryAndResdtlSts</b> (Country And Residential Status) of type CountryAndResidentialStatusType1.
        /// </summary>
        [XmlElementAttribute(Order=13)]
        public CountryAndResidentialStatusType1 CtryAndResdtlSts;
        
        /// <summary>
        /// Element <b>BizFctn</b> (Business Function) of type string.
        /// </summary>
        [XmlElementAttribute(Order=14)]
        public string BizFctn;
        
        /// <summary>
        /// Element <b>EmplngCpny</b> (Employing Company) of type string.
        /// </summary>
        [XmlElementAttribute(Order=15)]
        public string EmplngCpny;
        
        /// <summary>
        /// Element <b>ModfdPstlAdr</b> (Modified Postal Address) of type array of ModificationScope1.
        /// </summary>
        [XmlElementAttribute("ModfdPstlAdr", Order=16)]
        public ModificationScope1[] ModfdPstlAdr;
        
        /// <summary>
        /// Element <b>ModfdCtznsh</b> (Modified Citizenship) of type array of ModificationScope3.
        /// </summary>
        [XmlElementAttribute("ModfdCtznsh", Order=17)]
        public ModificationScope3[] ModfdCtznsh;
        
        /// <summary>
        /// Element <b>PmryComAdr</b> (Primary Communication Address) of type CommunicationAddress3.
        /// </summary>
        [XmlElementAttribute(Order=18)]
        public CommunicationAddress3 PmryComAdr;
        
        /// <summary>
        /// Element <b>ScndryComAdr</b> (Secondary Communication Address) of type CommunicationAddress3.
        /// </summary>
        [XmlElementAttribute(Order=19)]
        public CommunicationAddress3 ScndryComAdr;
        
        /// <summary>
        /// Element <b>ModfdOthrId</b> (Modified Other Identification) of type array of ModificationScope2.
        /// </summary>
        [XmlElementAttribute("ModfdOthrId", Order=20)]
        public ModificationScope2[] ModfdOthrId;
    }
    
    /// <summary>
    /// Enumeration <b>NamePrefix1Code</b> (Name Prefix 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
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
    /// Enumeration <b>GenderCode</b> (Gender Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public enum GenderCode
    {
        
        /// <summary>
        /// <b>MALE - Male</b>.
        /// </summary>
        MALE,
        
        /// <summary>
        /// <b>FEMA - Female</b>.
        /// </summary>
        FEMA,
    }
    
    /// <summary>
    /// Class <b>CountryAndResidentialStatusType1</b> (Country And Residential Status Type 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class CountryAndResidentialStatusType1
    {
        
        /// <summary>
        /// Element <b>Ctry</b> (Country) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Ctry;
        
        /// <summary>
        /// Element <b>ResdtlSts</b> (Residential Status) of type ResidentialStatus1Code.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public ResidentialStatus1Code ResdtlSts;
    }
    
    /// <summary>
    /// Enumeration <b>ResidentialStatus1Code</b> (Residential Status 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public enum ResidentialStatus1Code
    {
        
        /// <summary>
        /// <b>RESI - Resident</b>.
        /// </summary>
        RESI,
        
        /// <summary>
        /// <b>PRES - Permanent Resident</b>.
        /// </summary>
        PRES,
        
        /// <summary>
        /// <b>NRES - Non Resident</b>.
        /// </summary>
        NRES,
    }
    
    /// <summary>
    /// Class <b>ModificationScope1</b> (Modification Scope 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class ModificationScope1
    {
        
        /// <summary>
        /// Element <b>ModScpIndctn</b> (Modification Scope Indication) of type DataModification1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DataModification1Code ModScpIndctn;
        
        /// <summary>
        /// Element <b>PstlAdr</b> (Postal Address) of type PostalAddress3.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PostalAddress3 PstlAdr;
    }
    
    /// <summary>
    /// Class <b>PostalAddress3</b> (Postal Address 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class PostalAddress3
    {
        
        /// <summary>
        /// Element <b>AdrTp</b> (Address Type) of type AddressType1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public AddressType1Code AdrTp;
        
        /// <summary>
        /// Element <b>MlngInd</b> (Mailing Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public bool MlngInd;
        
        /// <summary>
        /// Element <b>RegnAdrInd</b> (Registration Address Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public bool RegnAdrInd;
        
        /// <summary>
        /// Element <b>NmAndAdr</b> (Name And Address) of type NameAndAddress4.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public NameAndAddress4 NmAndAdr;
    }
    
    /// <summary>
    /// Enumeration <b>AddressType1Code</b> (Address Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public enum AddressType1Code
    {
        
        /// <summary>
        /// <b>HOME - Residential</b>.
        /// </summary>
        HOME,
        
        /// <summary>
        /// <b>BIZZ - Business</b>.
        /// </summary>
        BIZZ,
    }
    
    /// <summary>
    /// Class <b>ModificationScope3</b> (Modification Scope 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class ModificationScope3
    {
        
        /// <summary>
        /// Element <b>ModScpIndctn</b> (Modification Scope Indication) of type DataModification2Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DataModification2Code ModScpIndctn;
        
        /// <summary>
        /// Element <b>Ctznsh</b> (Citizenship) of type CitizenshipInformation.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public CitizenshipInformation Ctznsh;
    }
    
    /// <summary>
    /// Class <b>CitizenshipInformation</b> (Citizenship Information).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class CitizenshipInformation
    {
        
        /// <summary>
        /// Element <b>Ntlty</b> (Nationality) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Ntlty;
        
        /// <summary>
        /// Element <b>MnrInd</b> (Minor Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public bool MnrInd;
    }
    
    /// <summary>
    /// Class <b>ModificationScope2</b> (Modification Scope 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class ModificationScope2
    {
        
        /// <summary>
        /// Element <b>ModScpIndctn</b> (Modification Scope Indication) of type DataModification2Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DataModification2Code ModScpIndctn;
        
        /// <summary>
        /// Element <b>OthrId</b> (Other Identification) of type GenericIdentification9.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public GenericIdentification9 OthrId;
    }
    
    /// <summary>
    /// Class <b>GenericIdentification9</b> (Generic Identification 9).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class GenericIdentification9
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// IdTp (Identification Type) of type PersonIdentificationType1Code 
        /// XtndedIdTp (Extended Identification Type) of type string 
        /// </summary>
        [XmlElementAttribute("IdTp", typeof(PersonIdentificationType1Code), Order=1)]
        [XmlElementAttribute("XtndedIdTp", typeof(string), Order=1)]
        public object Item;
        
        /// <summary>
        /// Element <b>Issr</b> (Issuer) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Issr;
        
        /// <summary>
        /// Element <b>IsseDt</b> (Issue Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=3)]
        public System.DateTime IsseDt;
        
        /// <summary>
        /// Element <b>IsseDtSpecified</b> (Issue Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsseDtSpecified;
        
        /// <summary>
        /// Element <b>XpryDt</b> (Expiry Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=4)]
        public System.DateTime XpryDt;
        
        /// <summary>
        /// Element <b>XpryDtSpecified</b> (Expiry Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XpryDtSpecified;
    }
    
    /// <summary>
    /// Enumeration <b>PersonIdentificationType1Code</b> (Person Identification Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public enum PersonIdentificationType1Code
    {
        
        /// <summary>
        /// <b>PASS - Passport</b>.
        /// </summary>
        PASS,
        
        /// <summary>
        /// <b>CPFA - CPFAccount Number</b>.
        /// </summary>
        CPFA,
        
        /// <summary>
        /// <b>SRSA - Retirement Scheme</b>.
        /// </summary>
        SRSA,
        
        /// <summary>
        /// <b>NRIN - National Registration Identification Number</b>.
        /// </summary>
        NRIN,
        
        /// <summary>
        /// <b>OTHR - Other</b>.
        /// </summary>
        OTHR,
        
        /// <summary>
        /// <b>DRLC - Drivers License Number</b>.
        /// </summary>
        DRLC,
        
        /// <summary>
        /// <b>SOCS - Social Security Number</b>.
        /// </summary>
        SOCS,
        
        /// <summary>
        /// <b>AREG - Alien Registration Number</b>.
        /// </summary>
        AREG,
        
        /// <summary>
        /// <b>IDCD - Identity Card Number</b>.
        /// </summary>
        IDCD,
        
        /// <summary>
        /// <b>EMID - Employer Identification Number</b>.
        /// </summary>
        EMID,
    }
    
    /// <summary>
    /// Class <b>Organisation3</b> (Organisation 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class Organisation3
    {
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Nm;
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type PartyIdentification4Choice.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyIdentification4Choice Id;
        
        /// <summary>
        /// Element <b>Purp</b> (Purpose) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Purp;
        
        /// <summary>
        /// Element <b>TaxtnCtry</b> (Taxation Country) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string TaxtnCtry;
        
        /// <summary>
        /// Element <b>RegnCtry</b> (Registration Country) of type string.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public string RegnCtry;
        
        /// <summary>
        /// Element <b>RegnDt</b> (Registration Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=5)]
        public System.DateTime RegnDt;
        
        /// <summary>
        /// Element <b>RegnDtSpecified</b> (Registration Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RegnDtSpecified;
        
        /// <summary>
        /// Element <b>TaxIdNb</b> (Tax Identification Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string TaxIdNb;
        
        /// <summary>
        /// Element <b>NtlRegnNb</b> (National Registration Number) of type string.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public string NtlRegnNb;
        
        /// <summary>
        /// Element <b>ModfdPstlAdr</b> (Modified Postal Address) of type array of ModificationScope1.
        /// </summary>
        [XmlElementAttribute("ModfdPstlAdr", Order=8)]
        public ModificationScope1[] ModfdPstlAdr;
        
        /// <summary>
        /// Element <b>PmryComAdr</b> (Primary Communication Address) of type CommunicationAddress3.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public CommunicationAddress3 PmryComAdr;
        
        /// <summary>
        /// Element <b>ScndryComAdr</b> (Secondary Communication Address) of type CommunicationAddress3.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public CommunicationAddress3 ScndryComAdr;
    }
    
    /// <summary>
    /// Enumeration <b>MoneyLaunderingCheck1Code</b> (Money Laundering Check 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public enum MoneyLaunderingCheck1Code
    {
        
        /// <summary>
        /// <b>PASS - Passport</b>.
        /// </summary>
        PASS,
        
        /// <summary>
        /// <b>NOTC - Not Checked</b>.
        /// </summary>
        NOTC,
        
        /// <summary>
        /// <b>EXEM - Exempt Below Limit</b>.
        /// </summary>
        EXEM,
        
        /// <summary>
        /// <b>CLMO - Client Money Type Exempt</b>.
        /// </summary>
        CLMO,
        
        /// <summary>
        /// <b>AUTH - Authorised Credit</b>.
        /// </summary>
        AUTH,
        
        /// <summary>
        /// <b>POEP - Postal Or Electronic Payment Exempt</b>.
        /// </summary>
        POEP,
    }
    
    /// <summary>
    /// Class <b>ModificationScope11</b> (Modification Scope 11).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class ModificationScope11
    {
        
        /// <summary>
        /// Element <b>ModScpIndctn</b> (Modification Scope Indication) of type DataModification2Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DataModification2Code ModScpIndctn;
        
        /// <summary>
        /// Element <b>InvstrPrflVldtn</b> (Investor Profile Validation) of type PartyProfileInformation1.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public PartyProfileInformation1 InvstrPrflVldtn;
    }
    
    /// <summary>
    /// Class <b>PartyProfileInformation1</b> (Party Profile Information 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class PartyProfileInformation1
    {
        
        /// <summary>
        /// Element <b>CertfctnInd</b> (Certification Indicator) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public bool CertfctnInd;
        
        /// <summary>
        /// Element <b>VldtngPty</b> (Validating Party) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string VldtngPty;
        
        /// <summary>
        /// Element <b>ChckngPty</b> (Checking Party) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string ChckngPty;
        
        /// <summary>
        /// Element <b>RspnsblPty</b> (Responsible Party) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string RspnsblPty;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// CertTp (Certificate Type) of type CertificateType1Code 
        /// XtndedCertTp (Extended Certificate Type) of type string 
        /// </summary>
        [XmlElementAttribute("CertTp", typeof(CertificateType1Code), Order=4)]
        [XmlElementAttribute("XtndedCertTp", typeof(string), Order=4)]
        public object Item;
        
        /// <summary>
        /// Element <b>ChckngDt</b> (Checking Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=5)]
        public System.DateTime ChckngDt;
        
        /// <summary>
        /// Element <b>ChckngDtSpecified</b> (Checking Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChckngDtSpecified;
        
        /// <summary>
        /// Element <b>ChckngFrqcy</b> (Checking Frequency) of type EventFrequency1Code.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public EventFrequency1Code ChckngFrqcy;
        
        /// <summary>
        /// Element <b>ChckngFrqcySpecified</b> (Checking Frequency Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChckngFrqcySpecified;
        
        /// <summary>
        /// Element <b>NxtRvsnDt</b> (Next Revision Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=7)]
        public System.DateTime NxtRvsnDt;
        
        /// <summary>
        /// Element <b>NxtRvsnDtSpecified</b> (Next Revision Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NxtRvsnDtSpecified;
        
        /// <summary>
        /// Element <b>SlryRg</b> (Salary Range) of type string.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public string SlryRg;
        
        /// <summary>
        /// Element <b>SrcOfWlth</b> (Source Of Wealth) of type string.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public string SrcOfWlth;
    }
    
    /// <summary>
    /// Enumeration <b>CertificateType1Code</b> (Certificate Type 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public enum CertificateType1Code
    {
        
        /// <summary>
        /// <b>DFOR - Due Formation And Organisation</b>.
        /// </summary>
        DFOR,
        
        /// <summary>
        /// <b>GOST - Good Standing</b>.
        /// </summary>
        GOST,
        
        /// <summary>
        /// <b>LREF - Letter Of Reference</b>.
        /// </summary>
        LREF,
        
        /// <summary>
        /// <b>AMLC - Anti Money Laundering</b>.
        /// </summary>
        AMLC,
        
        /// <summary>
        /// <b>INCU - Incumbency</b>.
        /// </summary>
        INCU,
        
        /// <summary>
        /// <b>PASS - Passport</b>.
        /// </summary>
        PASS,
        
        /// <summary>
        /// <b>DVLC - Driving License</b>.
        /// </summary>
        DVLC,
        
        /// <summary>
        /// <b>IDEN - Identity Card</b>.
        /// </summary>
        IDEN,
        
        /// <summary>
        /// <b>PRAD - Proof Of Address</b>.
        /// </summary>
        PRAD,
    }
    
    /// <summary>
    /// Class <b>AccountParties4</b> (Account Parties 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class AccountParties4
    {
        
        /// <summary>
        /// Element <b>ModScpIndctn</b> (Modification Scope Indication) of type DataModification1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DataModification1Code ModScpIndctn;
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of InvestmentAccountOwnershipInformation4.
        /// </summary>
        [XmlElementAttribute("CtdnForMnr", typeof(InvestmentAccountOwnershipInformation4), Order=1)]
        [XmlElementAttribute("JntOwnr", typeof(InvestmentAccountOwnershipInformation4), Order=1)]
        [XmlElementAttribute("Nmnee", typeof(InvestmentAccountOwnershipInformation4), Order=1)]
        [XmlElementAttribute("PmryOwnr", typeof(InvestmentAccountOwnershipInformation4), Order=1)]
        [XmlElementAttribute("Trstee", typeof(InvestmentAccountOwnershipInformation4), Order=1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public InvestmentAccountOwnershipInformation4[] Items;
        
        /// <summary>
        /// Element <b>ItemsElementName</b> (Items Element Name) of type array of ItemsChoiceType.
        /// </summary>
        [XmlElementAttribute("ItemsElementName", Order=2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName;
        
        /// <summary>
        /// Element <b>ScndryOwnr</b> (Secondary Owner) of type InvestmentAccountOwnershipInformation4.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public InvestmentAccountOwnershipInformation4 ScndryOwnr;
        
        /// <summary>
        /// Element <b>Bnfcry</b> (Beneficiary) of type InvestmentAccountOwnershipInformation4.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public InvestmentAccountOwnershipInformation4 Bnfcry;
        
        /// <summary>
        /// Element <b>PwrOfAttny</b> (Power Of Attorney) of type InvestmentAccountOwnershipInformation4.
        /// </summary>
        [XmlElementAttribute(Order=5)]
        public InvestmentAccountOwnershipInformation4 PwrOfAttny;
        
        /// <summary>
        /// Element <b>LglGuardn</b> (Legal Guardian) of type InvestmentAccountOwnershipInformation4.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public InvestmentAccountOwnershipInformation4 LglGuardn;
        
        /// <summary>
        /// Element <b>SucssrOnDth</b> (Successor On Death) of type InvestmentAccountOwnershipInformation4.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public InvestmentAccountOwnershipInformation4 SucssrOnDth;
        
        /// <summary>
        /// Element <b>Admstr</b> (Administrator) of type InvestmentAccountOwnershipInformation4.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public InvestmentAccountOwnershipInformation4 Admstr;
        
        /// <summary>
        /// Element <b>Grntr</b> (Granter) of type array of InvestmentAccountOwnershipInformation4.
        /// </summary>
        [XmlElementAttribute("Grntr", Order=9)]
        public InvestmentAccountOwnershipInformation4[] Grntr;
        
        /// <summary>
        /// Element <b>Sttlr</b> (Settler) of type array of InvestmentAccountOwnershipInformation4.
        /// </summary>
        [XmlElementAttribute("Sttlr", Order=10)]
        public InvestmentAccountOwnershipInformation4[] Sttlr;
        
        /// <summary>
        /// Element <b>OthrPty</b> (Other Party) of type array of ExtendedParty1.
        /// </summary>
        [XmlElementAttribute("OthrPty", Order=11)]
        public ExtendedParty1[] OthrPty;
    }
    
    /// <summary>
    /// Enumeration <b>ItemsChoiceType</b> (Items Choice Type).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02", IncludeInSchema=false)]
    public enum ItemsChoiceType
    {
        
        /// <summary>
        /// <b>CtdnForMnr - Custodian For Minor</b>.
        /// </summary>
        CtdnForMnr,
        
        /// <summary>
        /// <b>JntOwnr - Joint Owner</b>.
        /// </summary>
        JntOwnr,
        
        /// <summary>
        /// <b>Nmnee - Nominee</b>.
        /// </summary>
        Nmnee,
        
        /// <summary>
        /// <b>PmryOwnr - Primary Owner</b>.
        /// </summary>
        PmryOwnr,
        
        /// <summary>
        /// <b>Trstee - Trustee</b>.
        /// </summary>
        Trstee,
    }
    
    /// <summary>
    /// Class <b>RoundingParameters1</b> (Rounding Parameters 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class RoundingParameters1
    {
        
        /// <summary>
        /// Element <b>RndgMdlus</b> (Rounding Modulus) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public decimal RndgMdlus;
        
        /// <summary>
        /// Element <b>RndgMdlusSpecified</b> (Rounding Modulus Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RndgMdlusSpecified;
        
        /// <summary>
        /// Element <b>RndgDrctn</b> (Rounding Direction) of type RoundingDirection1Code.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public RoundingDirection1Code RndgDrctn;
    }
    
    /// <summary>
    /// Class <b>ModificationScope12</b> (Modification Scope 12).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class ModificationScope12
    {
        
        /// <summary>
        /// Element <b>ModScpIndctn</b> (Modification Scope Indication) of type DataModification2Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public DataModification2Code ModScpIndctn;
        
        /// <summary>
        /// Element <b>FndDtls</b> (Fund Details) of type FinancialInstrument10.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public FinancialInstrument10 FndDtls;
    }
    
    /// <summary>
    /// Class <b>InvestmentAccount28</b> (Investment Account 28).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class InvestmentAccount28
    {
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Nm;
        
        /// <summary>
        /// Element <b>Dsgnt</b> (Designation) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Dsgnt;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// Tp (Type) of type FundCashAccount3Code 
        /// XtndedTp (Extended Type) of type string 
        /// </summary>
        [XmlElementAttribute("Tp", typeof(FundCashAccount3Code), Order=2)]
        [XmlElementAttribute("XtndedTp", typeof(string), Order=2)]
        public object Item;
        
        /// <summary>
        /// Element <b>Item1</b> (Item 1) of type object.
        /// [XOR] This element can be:
        /// OwnrshTp (Ownership Type) of type AccountOwnershipType3Code 
        /// XtndedOwnrshTp (Extended Ownership Type) of type string 
        /// </summary>
        [XmlElementAttribute("OwnrshTp", typeof(AccountOwnershipType3Code), Order=3)]
        [XmlElementAttribute("XtndedOwnrshTp", typeof(string), Order=3)]
        public object Item1;
        
        /// <summary>
        /// Element <b>Item2</b> (Item 2) of type object.
        /// [XOR] This element can be:
        /// TaxXmptnRsn (Tax Exemption Reason) of type TaxExemptReason1Code 
        /// XtndedTaxXmptnRsn (Extended Tax Exemption Reason) of type string 
        /// </summary>
        [XmlElementAttribute("TaxXmptnRsn", typeof(TaxExemptReason1Code), Order=4)]
        [XmlElementAttribute("XtndedTaxXmptnRsn", typeof(string), Order=4)]
        public object Item2;
        
        /// <summary>
        /// Element <b>Item3</b> (Item 3) of type object.
        /// [XOR] This element can be:
        /// StmtFrqcy (Statement Frequency) of type EventFrequency1Code 
        /// XtndedStmtFrqcy (Extended Statement Frequency) of type string 
        /// </summary>
        [XmlElementAttribute("StmtFrqcy", typeof(EventFrequency1Code), Order=5)]
        [XmlElementAttribute("XtndedStmtFrqcy", typeof(string), Order=5)]
        public object Item3;
        
        /// <summary>
        /// Element <b>RefCcy</b> (Reference Currency) of type string.
        /// </summary>
        [XmlElementAttribute(Order=6)]
        public string RefCcy;
        
        /// <summary>
        /// Element <b>Lang</b> (Language) of type string.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public string Lang;
        
        /// <summary>
        /// Element <b>IncmPref</b> (Income Preference) of type IncomePreference1Code.
        /// </summary>
        [XmlElementAttribute(Order=8)]
        public IncomePreference1Code IncmPref;
        
        /// <summary>
        /// Element <b>IncmPrefSpecified</b> (Income Preference Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncmPrefSpecified;
        
        /// <summary>
        /// Element <b>TaxWhldgMtd</b> (Tax Withholding Method) of type TaxWithholdingMethod1Code.
        /// </summary>
        [XmlElementAttribute(Order=9)]
        public TaxWithholdingMethod1Code TaxWhldgMtd;
        
        /// <summary>
        /// Element <b>TaxWhldgMtdSpecified</b> (Tax Withholding Method Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxWhldgMtdSpecified;
        
        /// <summary>
        /// Element <b>LttrInttRef</b> (Letter Intent Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=10)]
        public string LttrInttRef;
        
        /// <summary>
        /// Element <b>AcmltnRghtRef</b> (Accumulation Right Reference) of type string.
        /// </summary>
        [XmlElementAttribute(Order=11)]
        public string AcmltnRghtRef;
        
        /// <summary>
        /// Element <b>ReqrdSgntriesNb</b> (Required Signatories Number) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=12)]
        public decimal ReqrdSgntriesNb;
        
        /// <summary>
        /// Element <b>ReqrdSgntriesNbSpecified</b> (Required Signatories Number Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReqrdSgntriesNbSpecified;
        
        /// <summary>
        /// Element <b>FndFmlyNm</b> (Fund Family Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=13)]
        public string FndFmlyNm;
        
        /// <summary>
        /// Element <b>ModfdFndDtls</b> (Modified Fund Details) of type array of ModificationScope12.
        /// </summary>
        [XmlElementAttribute("ModfdFndDtls", Order=14)]
        public ModificationScope12[] ModfdFndDtls;
        
        /// <summary>
        /// Element <b>RndgDtls</b> (Rounding Details) of type RoundingParameters1.
        /// </summary>
        [XmlElementAttribute(Order=15)]
        public RoundingParameters1 RndgDtls;
        
        /// <summary>
        /// Element <b>AcctSvcr</b> (Account Servicer) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=16)]
        public PartyIdentification2Choice AcctSvcr;
    }
    
    /// <summary>
    /// Enumeration <b>FundCashAccount3Code</b> (Fund Cash Account 3Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public enum FundCashAccount3Code
    {
        
        /// <summary>
        /// <b>CASH - Cash</b>.
        /// </summary>
        CASH,
        
        /// <summary>
        /// <b>CPFO - Pension Fund Ordinary</b>.
        /// </summary>
        CPFO,
        
        /// <summary>
        /// <b>CPFS - Pension Fund Special</b>.
        /// </summary>
        CPFS,
        
        /// <summary>
        /// <b>SRSA - Retirement Scheme</b>.
        /// </summary>
        SRSA,
        
        /// <summary>
        /// <b>HEDG - Hedge Fund</b>.
        /// </summary>
        HEDG,
    }
    
    /// <summary>
    /// Enumeration <b>AccountOwnershipType3Code</b> (Account Ownership Type 3Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public enum AccountOwnershipType3Code
    {
        
        /// <summary>
        /// <b>JOIN - Joint Account With Survivorship Rights</b>.
        /// </summary>
        JOIN,
        
        /// <summary>
        /// <b>COMO - Joint Account In Common</b>.
        /// </summary>
        COMO,
        
        /// <summary>
        /// <b>CUST - Custodial Account</b>.
        /// </summary>
        CUST,
        
        /// <summary>
        /// <b>SIGL - Single Owner Account</b>.
        /// </summary>
        SIGL,
        
        /// <summary>
        /// <b>JOIT - Joint Account</b>.
        /// </summary>
        JOIT,
        
        /// <summary>
        /// <b>CORP - Corporation</b>.
        /// </summary>
        CORP,
        
        /// <summary>
        /// <b>PART - Formal Partnership</b>.
        /// </summary>
        PART,
        
        /// <summary>
        /// <b>TRUS - Formal Trust</b>.
        /// </summary>
        TRUS,
        
        /// <summary>
        /// <b>NOMI - Nominee</b>.
        /// </summary>
        NOMI,
        
        /// <summary>
        /// <b>NFPO - Non Profit Organisation</b>.
        /// </summary>
        NFPO,
        
        /// <summary>
        /// <b>ONIS - Other Non Individual</b>.
        /// </summary>
        ONIS,
        
        /// <summary>
        /// <b>EURE - EUResidual Entity</b>.
        /// </summary>
        EURE,
        
        /// <summary>
        /// <b>GOVO - Governemental Organisation</b>.
        /// </summary>
        GOVO,
        
        /// <summary>
        /// <b>LLCO - Limited Liability Company</b>.
        /// </summary>
        LLCO,
        
        /// <summary>
        /// <b>RGIC - Registered Investment Company</b>.
        /// </summary>
        RGIC,
    }
    
    /// <summary>
    /// Enumeration <b>TaxExemptReason1Code</b> (Tax Exempt Reason 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
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
    /// Enumeration <b>TaxWithholdingMethod1Code</b> (Tax Withholding Method 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public enum TaxWithholdingMethod1Code
    {
        
        /// <summary>
        /// <b>WTHD - Withhold Tax</b>.
        /// </summary>
        WTHD,
        
        /// <summary>
        /// <b>REPT - Report Tax</b>.
        /// </summary>
        REPT,
        
        /// <summary>
        /// <b>CRTF - Tax Certificate</b>.
        /// </summary>
        CRTF,
        
        /// <summary>
        /// <b>WTRE - Withhold Tax And Report</b>.
        /// </summary>
        WTRE,
    }
    
    /// <summary>
    /// Class <b>Intermediary7</b> (Intermediary 7).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class Intermediary7
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public PartyIdentification2Choice Id;
        
        /// <summary>
        /// Element <b>Acct</b> (Account) of type Account2.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public Account2 Acct;
    }
    
    /// <summary>
    /// Class <b>PartyIdentification5Choice</b> (Party Identification 5Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class PartyIdentification5Choice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// BICOrBEI (BIC Or BEI) of type string 
        /// NmAndAdr (Name And Address) of type NameAndAddress5 
        /// NtlRegnNb (National Registration Number) of type string 
        /// PrtryId (Proprietary Identification) of type GenericIdentification1 
        /// TaxIdNb (Tax Identification Number) of type string 
        /// </summary>
        [XmlElementAttribute("BICOrBEI", typeof(string), Order=0)]
        [XmlElementAttribute("NmAndAdr", typeof(NameAndAddress5), Order=0)]
        [XmlElementAttribute("NtlRegnNb", typeof(string), Order=0)]
        [XmlElementAttribute("PrtryId", typeof(GenericIdentification1), Order=0)]
        [XmlElementAttribute("TaxIdNb", typeof(string), Order=0)]
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
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02", IncludeInSchema=false)]
    public enum ItemChoiceType2
    {
        
        /// <summary>
        /// <b>BICOrBEI - BIC Or BEI</b>.
        /// </summary>
        BICOrBEI,
        
        /// <summary>
        /// <b>NmAndAdr - Name And Address</b>.
        /// </summary>
        NmAndAdr,
        
        /// <summary>
        /// <b>NtlRegnNb - National Registration Number</b>.
        /// </summary>
        NtlRegnNb,
        
        /// <summary>
        /// <b>PrtryId - Proprietary Identification</b>.
        /// </summary>
        PrtryId,
        
        /// <summary>
        /// <b>TaxIdNb - Tax Identification Number</b>.
        /// </summary>
        TaxIdNb,
    }
    
    /// <summary>
    /// Class <b>IndividualPerson4</b> (Individual Person 4).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class IndividualPerson4
    {
        
        /// <summary>
        /// Element <b>GvnNm</b> (Given Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string GvnNm;
        
        /// <summary>
        /// Element <b>MddlNm</b> (Middle Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string MddlNm;
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Nm;
        
        /// <summary>
        /// Element <b>Gndr</b> (Gender) of type GenderCode.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public GenderCode Gndr;
        
        /// <summary>
        /// Element <b>GndrSpecified</b> (Gender Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GndrSpecified;
        
        /// <summary>
        /// Element <b>BirthDt</b> (Birth Date) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(DataType="date", Order=4)]
        public System.DateTime BirthDt;
        
        /// <summary>
        /// Element <b>BirthDtSpecified</b> (Birth Date Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BirthDtSpecified;
    }
    
    /// <summary>
    /// Class <b>GenericIdentification10</b> (Generic Identification 10).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class GenericIdentification10
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// IdTp (Identification Type) of type PersonIdentificationType1Code 
        /// XtndedIdTp (Extended Identification Type) of type string 
        /// </summary>
        [XmlElementAttribute("IdTp", typeof(PersonIdentificationType1Code), Order=1)]
        [XmlElementAttribute("XtndedIdTp", typeof(string), Order=1)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>IndividualPersonIdentificationChoice</b> (Individual Person Identification Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class IndividualPersonIdentificationChoice
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// IdNb (Identification Number) of type GenericIdentification10 
        /// PrsnNm (Person Name) of type IndividualPerson4 
        /// </summary>
        [XmlElementAttribute("IdNb", typeof(GenericIdentification10), Order=0)]
        [XmlElementAttribute("PrsnNm", typeof(IndividualPerson4), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>InvestmentAccount29</b> (Investment Account 29).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class InvestmentAccount29
    {
        
        /// <summary>
        /// Element <b>Nm</b> (Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Nm;
        
        /// <summary>
        /// Element <b>Dsgnt</b> (Designation) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Dsgnt;
        
        /// <summary>
        /// Element <b>FndTp</b> (Fund Type) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string FndTp;
        
        /// <summary>
        /// Element <b>FndFmlyNm</b> (Fund Family Name) of type string.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public string FndFmlyNm;
        
        /// <summary>
        /// Element <b>SctyDtls</b> (Security Details) of type FinancialInstrument10.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public FinancialInstrument10 SctyDtls;
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// IndvOwnrId (Individual Owner Identification) of type IndividualPersonIdentificationChoice 
        /// OrgOwnrId (Organisation Owner Identification) of type PartyIdentification5Choice 
        /// </summary>
        [XmlElementAttribute("IndvOwnrId", typeof(IndividualPersonIdentificationChoice), Order=5)]
        [XmlElementAttribute("OrgOwnrId", typeof(PartyIdentification5Choice), Order=5)]
        public object Item;
        
        /// <summary>
        /// Element <b>Intrmy</b> (Intermediary) of type array of Intermediary7.
        /// </summary>
        [XmlElementAttribute("Intrmy", Order=6)]
        public Intermediary7[] Intrmy;
        
        /// <summary>
        /// Element <b>AcctSvcr</b> (Account Servicer) of type PartyIdentification2Choice.
        /// </summary>
        [XmlElementAttribute(Order=7)]
        public PartyIdentification2Choice AcctSvcr;
    }
    
    /// <summary>
    /// Class <b>InvestmentAccountSelection2</b> (Investment Account Selection 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class InvestmentAccountSelection2
    {
        
        /// <summary>
        /// Element <b>Item</b> (Item) of type object.
        /// [XOR] This element can be:
        /// AcctId (Account Identification) of type AccountIdentification1 
        /// OthrAcctSelctnData (Other Account Selection Data) of type InvestmentAccount29 
        /// </summary>
        [XmlElementAttribute("AcctId", typeof(AccountIdentification1), Order=0)]
        [XmlElementAttribute("OthrAcctSelctnData", typeof(InvestmentAccount29), Order=0)]
        public object Item;
    }
    
    /// <summary>
    /// Class <b>InvestmentAccountModificationDetails</b> (Investment Account Modification Details).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
    public class InvestmentAccountModificationDetails
    {
        
        /// <summary>
        /// Element <b>ModRsn</b> (Modification Reason) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string ModRsn;
        
        /// <summary>
        /// Element <b>AcctApplId</b> (Account Application Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string AcctApplId;
    }
    
    /// <summary>
    /// Class <b>AdditionalReference3</b> (Additional Reference 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.003.001.02")]
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
}
