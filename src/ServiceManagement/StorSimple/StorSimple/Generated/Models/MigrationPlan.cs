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
using Microsoft.WindowsAzure.Management.StorSimple.Models;

namespace Microsoft.WindowsAzure.Management.StorSimple.Models
{
    /// <summary>
    /// Migration plan class
    /// </summary>
    public partial class MigrationPlan
    {
        private string _configId;
        
        /// <summary>
        /// Required. Gets or sets the config ID passed while importing the
        /// config
        /// </summary>
        public string ConfigId
        {
            get { return this._configId; }
            set { this._configId = value; }
        }
        
        private string _deviceName;
        
        /// <summary>
        /// Required. Gets or sets the target devicename where the migration
        /// plan is computed
        /// </summary>
        public string DeviceName
        {
            get { return this._deviceName; }
            set { this._deviceName = value; }
        }
        
        private IList<MigrationPlanInfo> _migrationPlanInfo;
        
        /// <summary>
        /// Required. Gets or sets list of migration plans for all data
        /// container specified in the config imported
        /// </summary>
        public IList<MigrationPlanInfo> MigrationPlanInfo
        {
            get { return this._migrationPlanInfo; }
            set { this._migrationPlanInfo = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the MigrationPlan class.
        /// </summary>
        public MigrationPlan()
        {
            this.MigrationPlanInfo = new LazyList<MigrationPlanInfo>();
        }
        
        /// <summary>
        /// Initializes a new instance of the MigrationPlan class with required
        /// arguments.
        /// </summary>
        public MigrationPlan(string configId, string deviceName, List<MigrationPlanInfo> migrationPlanInfo)
            : this()
        {
            if (configId == null)
            {
                throw new ArgumentNullException("configId");
            }
            if (deviceName == null)
            {
                throw new ArgumentNullException("deviceName");
            }
            if (migrationPlanInfo == null)
            {
                throw new ArgumentNullException("migrationPlanInfo");
            }
            this.ConfigId = configId;
            this.DeviceName = deviceName;
            this.MigrationPlanInfo = migrationPlanInfo;
        }
    }
}