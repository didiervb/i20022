
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



namespace i20022.tsmt02200102
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id tsmt.022.001.02 name MisMatchRejectionV02 from Trade Services Management business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.022.001.02")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.022.001.02", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>MisMtchRjctn</b> (Mis Match Rejection) of type MisMatchRejectionV02.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public MisMatchRejectionV02 MisMtchRjctn;
    }
    
    /// <summary>
    /// Class <b>MisMatchRejectionV02</b> (Mis Match Rejection V02).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.022.001.02")]
    public class MisMatchRejectionV02
    {
        
        /// <summary>
        /// Element <b>RjctnId</b> (Rejection Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public MessageIdentification1 RjctnId;
        
        /// <summary>
        /// Element <b>TxId</b> (Transaction Identification) of type SimpleIdentificationInformation.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public SimpleIdentificationInformation TxId;
        
        /// <summary>
        /// Element <b>SubmitrTxRef</b> (Submitter Transaction Reference) of type SimpleIdentificationInformation.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public SimpleIdentificationInformation SubmitrTxRef;
        
        /// <summary>
        /// Element <b>DataSetMtchRptRef</b> (Data Set Match Report Reference) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public MessageIdentification1 DataSetMtchRptRef;
        
        /// <summary>
        /// Element <b>RjctnRsn</b> (Rejection Reason) of type RejectionReason1Choice.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public RejectionReason1Choice RjctnRsn;
    }
    
    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.022.001.02")]
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
    /// Class <b>RejectedElement1</b> (Rejected Element 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.022.001.02")]
    public class RejectedElement1
    {
        
        /// <summary>
        /// Element <b>ElmtSeqNb</b> (Element Sequence Number) of type decimal.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public decimal ElmtSeqNb;
        
        /// <summary>
        /// Element <b>IndvRjctnRsn</b> (Individual Rejection Reason) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string IndvRjctnRsn;
    }
    
    /// <summary>
    /// Class <b>Reason2</b> (Reason 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.022.001.02")]
    public class Reason2
    {
        
        /// <summary>
        /// Element <b>Desc</b> (Description) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Desc;
    }
    
    /// <summary>
    /// Class <b>RejectionReason1Choice</b> (Rejection Reason 1Choice).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.022.001.02")]
    public class RejectionReason1Choice
    {
        
        /// <summary>
        /// Element <b>Items</b> (Items) of type array of object.
        /// [XOR] This element can be:
        /// GblRjctnRsn (Global Rejection Reason) of type Reason2 
        /// RjctdElmt (Rejected Element) of type RejectedElement1 
        /// </summary>
        [XmlElementAttribute("GblRjctnRsn", typeof(Reason2), Order=0)]
        [XmlElementAttribute("RjctdElmt", typeof(RejectedElement1), Order=0)]
        public object[] Items;
    }
    
    /// <summary>
    /// Class <b>SimpleIdentificationInformation</b> (Simple Identification Information).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.022.001.02")]
    public class SimpleIdentificationInformation
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
    }
}
