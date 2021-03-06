
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



namespace i20022.camt03100101
{
    
    
    /// <summary>
    /// <b>Document</b> is the root class of the ISO 20022 message
    /// with id camt.031.001.01 name RejectCaseAssignment from Cash Management business area.
    /// Repository:R 6.14.4.1 v524 - 8 December 2008
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.031.001.01")]
    [XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.031.001.01", IsNullable=false)]
    public class Document
    {
        
        /// <summary>
        /// Element <b>camt03100101</b> (camt 03100101) of type camt03100101.
        /// </summary>
        [XmlElementAttribute("camt.031.001.01", Order=0)]
        public camt03100101 camt03100101;
    }
    
    /// <summary>
    /// Class <b>camt03100101</b> (camt 03100101).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(TypeName="camt.031.001.01", Namespace="urn:iso:std:iso:20022:tech:xsd:camt.031.001.01")]
    public class camt03100101
    {
        
        /// <summary>
        /// Element <b>Assgnmt</b> (Assignment) of type CaseAssignment.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CaseAssignment Assgnmt;
        
        /// <summary>
        /// Element <b>Case</b> (Case) of type Case.
        /// </summary>
        [XmlElementAttribute(Order=1)]
        public Case Case;
        
        /// <summary>
        /// Element <b>Justfn</b> (Justification) of type CaseAssignmentRejectionJustification.
        /// </summary>
        [XmlElementAttribute(Order=2)]
        public CaseAssignmentRejectionJustification Justfn;
    }
    
    /// <summary>
    /// Class <b>CaseAssignment</b> (Case Assignment).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.031.001.01")]
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
    /// Class <b>CaseAssignmentRejectionJustification</b> (Case Assignment Rejection Justification).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.031.001.01")]
    public class CaseAssignmentRejectionJustification
    {
        
        /// <summary>
        /// Element <b>RjctnRsn</b> (Rejection Reason) of type CaseAssignmentRejection1Code.
        /// </summary>
        [XmlElementAttribute(Order=0)]
        public CaseAssignmentRejection1Code RjctnRsn;
    }
    
    /// <summary>
    /// Enumeration <b>CaseAssignmentRejection1Code</b> (Case Assignment Rejection 1Code).
    /// </summary>
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.031.001.01")]
    public enum CaseAssignmentRejection1Code
    {
        
        /// <summary>
        /// <b>NFND - Underlying Payment Not Found</b>.
        /// </summary>
        NFND,
        
        /// <summary>
        /// <b>NAUT - Not Authorised To Investigate</b>.
        /// </summary>
        NAUT,
        
        /// <summary>
        /// <b>UKNW - Unknown Case</b>.
        /// </summary>
        UKNW,
        
        /// <summary>
        /// <b>RJCT - Payment Rejected</b>.
        /// </summary>
        RJCT,
        
        /// <summary>
        /// <b>CNCL - Cancelled By Client</b>.
        /// </summary>
        CNCL,
    }
    
    /// <summary>
    /// Class <b>Case</b> (Case).
    /// </summary>
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:camt.031.001.01")]
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
