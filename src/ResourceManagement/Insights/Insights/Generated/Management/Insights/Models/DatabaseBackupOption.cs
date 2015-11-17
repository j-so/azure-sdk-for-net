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
using System.Linq;
using Microsoft.Azure.Management.Insights.Models;

namespace Microsoft.Azure.Management.Insights.Models
{
    /// <summary>
    /// The options for the database backup job.
    /// </summary>
    public partial class DatabaseBackupOption
    {
        private DatabaseConsistencyOption _consistencyOption;
        
        /// <summary>
        /// Optional. Gets or sets the database consistency option.
        /// </summary>
        public DatabaseConsistencyOption ConsistencyOption
        {
            get { return this._consistencyOption; }
            set { this._consistencyOption = value; }
        }
        
        private bool _keepAtLeastOneBackup;
        
        /// <summary>
        /// Optional. Gets or sets the keep at least one backup flag.Whether at
        /// least one exported file will be kept.
        /// </summary>
        public bool KeepAtLeastOneBackup
        {
            get { return this._keepAtLeastOneBackup; }
            set { this._keepAtLeastOneBackup = value; }
        }
        
        private TimeSpan _repeatInterval;
        
        /// <summary>
        /// Optional. Gets or sets the repeat interval.How often the automated
        /// export job will run.
        /// </summary>
        public TimeSpan RepeatInterval
        {
            get { return this._repeatInterval; }
            set { this._repeatInterval = value; }
        }
        
        private TimeSpan _retentionPeriod;
        
        /// <summary>
        /// Optional. Gets or sets the retention period.How long the exported
        /// files will be saved.
        /// </summary>
        public TimeSpan RetentionPeriod
        {
            get { return this._retentionPeriod; }
            set { this._retentionPeriod = value; }
        }
        
        private DateTime _startTime;
        
        /// <summary>
        /// Optional. Gets or sets the start time for the job.
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DatabaseBackupOption class.
        /// </summary>
        public DatabaseBackupOption()
        {
        }
    }
}
