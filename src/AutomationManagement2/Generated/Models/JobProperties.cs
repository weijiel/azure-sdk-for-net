// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// Definition of job parameters.
    /// </summary>
    public partial class JobProperties
    {
        private DateTimeOffset _creationTime;
        
        /// <summary>
        /// Optional. Gets or sets the creation time of the job.
        /// </summary>
        public DateTimeOffset CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }
        
        private DateTimeOffset _endTime;
        
        /// <summary>
        /// Optional. Gets or sets the end time of the job.
        /// </summary>
        public DateTimeOffset EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }
        
        private string _exception;
        
        /// <summary>
        /// Optional. Gets or sets the exception of the job.
        /// </summary>
        public string Exception
        {
            get { return this._exception; }
            set { this._exception = value; }
        }
        
        private Guid _jobId;
        
        /// <summary>
        /// Optional. Gets or sets the id of the job.
        /// </summary>
        public Guid JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }
        
        private DateTimeOffset _lastModifiedTime;
        
        /// <summary>
        /// Optional. Gets or sets the last modified time of the job.
        /// </summary>
        public DateTimeOffset LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }
        
        private DateTimeOffset _lastStatusModifiedTime;
        
        /// <summary>
        /// Optional. Gets or sets the last status modified time of the job.
        /// </summary>
        public DateTimeOffset LastStatusModifiedTime
        {
            get { return this._lastStatusModifiedTime; }
            set { this._lastStatusModifiedTime = value; }
        }
        
        private IDictionary<string, string> _parameters;
        
        /// <summary>
        /// Optional. Gets or sets the parameters of the job.
        /// </summary>
        public IDictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }
        
        private RunbookAssociationProperty _runbook;
        
        /// <summary>
        /// Optional. Gets or sets the runbook.
        /// </summary>
        public RunbookAssociationProperty Runbook
        {
            get { return this._runbook; }
            set { this._runbook = value; }
        }
        
        private DateTimeOffset _startTime;
        
        /// <summary>
        /// Optional. Gets or sets the start time of the job.
        /// </summary>
        public DateTimeOffset StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }
        
        private string _status;
        
        /// <summary>
        /// Optional. Gets or sets the status of the job.
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        private string _statusDetails;
        
        /// <summary>
        /// Optional. Gets or sets the status details of the job.
        /// </summary>
        public string StatusDetails
        {
            get { return this._statusDetails; }
            set { this._statusDetails = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the JobProperties class.
        /// </summary>
        public JobProperties()
        {
            this.Parameters = new LazyDictionary<string, string>();
        }
    }
}