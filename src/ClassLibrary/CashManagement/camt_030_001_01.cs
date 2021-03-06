
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



namespace i20022.camt03000101
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id camt.030.001.01 name NotificationOfCaseAssignment from Cash Management business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.030.001.01")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.030.001.01", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>camt03000101</b> (camt 03000101) of type camt03000101.
        /// </summary>
        [XmlElementAttribute("camt.030.001.01", Order=0)]
        public camt03000101 camt03000101;
    }
    
    /// <summary>
    /// Class <b>camt03000101</b> (camt 03000101).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(TypeName="camt.030.001.01", Namespace="urn:iso:std:iso:20022:tech:xsd:camt.030.001.01")]
    public class camt03000101
    {
        
        /// <summary>
        /// Element <b>Hdr</b> (Header) of type ReportHeader.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public ReportHeader Hdr;
        
        /// <summary>
        /// Element <b>Case</b> (Case) of type Case.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public Case Case;
        
        /// <summary>
        /// Element <b>Assgnmt</b> (Assignment) of type CaseAssignment.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public CaseAssignment Assgnmt;
        
        /// <summary>
        /// Element <b>Ntfctn</b> (Notification) of type CaseForwardingNotification.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public CaseForwardingNotification Ntfctn;
    }
    
    /// <summary>
    /// Class <b>ReportHeader</b> (Report Header).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.030.001.01")]
    public class ReportHeader
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>Fr</b> (From) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Fr;
        
        /// <summary>
        /// Element <b>To</b> (To) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string To;
        
        /// <summary>
        /// Element <b>CreDtTm</b> (Creation Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public System.DateTime CreDtTm;
    }
    
    /// <summary>
    /// Class <b>CaseForwardingNotification</b> (Case Forwarding Notification).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.030.001.01")]
    public class CaseForwardingNotification
    {
        
        /// <summary>
        /// Element <b>Justfn</b> (Justification) of type CaseForwardingNotification1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CaseForwardingNotification1Code Justfn;
    }
    
    /// <summary>
    /// Enumeration <b>CaseForwardingNotification1Code</b> (Case Forwarding Notification 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.030.001.01")]
    public enum CaseForwardingNotification1Code
    {
        
        /// <summary>
        /// <b>FTHI - Further Investigation</b>.
        /// </summary>
        FTHI,
        
        /// <summary>
        /// <b>CANC - Request To Cancel</b>.
        /// </summary>
        CANC,
        
        /// <summary>
        /// <b>MODI - Request To Modify</b>.
        /// </summary>
        MODI,
        
        /// <summary>
        /// <b>DTAU - Request Debit Authorisation</b>.
        /// </summary>
        DTAU,
        
        /// <summary>
        /// <b>SAIN - Sent Additional Information</b>.
        /// </summary>
        SAIN,
    }
    
    /// <summary>
    /// Class <b>CaseAssignment</b> (Case Assignment).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.030.001.01")]
    public class CaseAssignment
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>Assgnr</b> (Assigner) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Assgnr;
        
        /// <summary>
        /// Element <b>Assgne</b> (Assignee) of type string.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public string Assgne;
        
        /// <summary>
        /// Element <b>CreDtTm</b> (Creation Date Time) of type System.DateTime.
        /// </summary>
        [XmlElementAttribute(Order=3)]
        public System.DateTime CreDtTm;
    }
    
    /// <summary>
    /// Class <b>Case</b> (Case).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.030.001.01")]
    public class Case
    {
        
        /// <summary>
        /// Element <b>Id</b> (Identification) of type string.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public string Id;
        
        /// <summary>
        /// Element <b>Cretr</b> (Creator) of type string.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public string Cretr;
        
        /// <summary>
        /// Element <b>ReopCaseIndctn</b> (Reopen Case Indication) of type bool.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public bool ReopCaseIndctn;
        
        /// <summary>
        /// Element <b>ReopCaseIndctnSpecified</b> (Reopen Case Indication Specified) of type bool.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReopCaseIndctnSpecified;
    }
}
