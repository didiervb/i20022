
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



namespace i20022.tsmt02600102
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id tsmt.026.001.02 name StatusChangeRequestV02 from Trade Services Management business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.026.001.02")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.026.001.02", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>StsChngReq</b> (Status Change Request) of type StatusChangeRequestV02.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public StatusChangeRequestV02 StsChngReq;
    }
    
    /// <summary>
    /// Class <b>StatusChangeRequestV02</b> (Status Change Request V02).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.026.001.02")]
    public class StatusChangeRequestV02
    {
        
        /// <summary>
        /// Element <b>ReqId</b> (Request Identification) of type MessageIdentification1.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public MessageIdentification1 ReqId;
        
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
        /// Element <b>ReqdSts</b> (Requested Status) of type TransactionStatus3.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public TransactionStatus3 ReqdSts;
        
        /// <summary>
        /// Element <b>ReqRsn</b> (Request Reason) of type Reason2.
        /// </summary>
        [XmlElementAttribute(Order=4)]
        public Reason2 ReqRsn;
    }
    
    /// <summary>
    /// Class <b>MessageIdentification1</b> (Message Identification 1).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.026.001.02")]
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
    /// Class <b>Reason2</b> (Reason 2).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.026.001.02")]
    public class Reason2
    {
        
        /// <summary>
        /// Element <b>Desc</b> (Description) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Desc;
    }
    
    /// <summary>
    /// Class <b>TransactionStatus3</b> (Transaction Status 3).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.026.001.02")]
    public class TransactionStatus3
    {
        
        /// <summary>
        /// Element <b>Sts</b> (Status) of type BaselineStatus2Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public BaselineStatus2Code Sts;
    }
    
    /// <summary>
    /// Enumeration <b>BaselineStatus2Code</b> (Baseline Status 2Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.026.001.02")]
    public enum BaselineStatus2Code
    {
        
        /// <summary>
        /// <b>COMP - Complete</b>.
        /// </summary>
        COMP,
        
        /// <summary>
        /// <b>CLSD - Closed</b>.
        /// </summary>
        CLSD,
        
        /// <summary>
        /// <b>ACTV - Active</b>.
        /// </summary>
        ACTV,
    }
    
    /// <summary>
    /// Class <b>SimpleIdentificationInformation</b> (Simple Identification Information).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:tsmt.026.001.02")]
    public class SimpleIdentificationInformation
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
    }
}
