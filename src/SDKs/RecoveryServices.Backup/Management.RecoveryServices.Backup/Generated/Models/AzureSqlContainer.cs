// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Azure Sql workload-specific container.
    /// </summary>
    public partial class AzureSqlContainer : ProtectionContainer
    {
        /// <summary>
        /// Initializes a new instance of the AzureSqlContainer class.
        /// </summary>
        public AzureSqlContainer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureSqlContainer class.
        /// </summary>
        /// <param name="friendlyName">Friendly name of the container.</param>
        /// <param name="backupManagementType">Type of backup managemenent for
        /// the container. Possible values include: 'Invalid', 'AzureIaasVM',
        /// 'MAB', 'DPM', 'AzureBackupServer', 'AzureSql', 'AzureStorage',
        /// 'AzureWorkload', 'DefaultBackup'</param>
        /// <param name="registrationStatus">Status of registration of the
        /// container with the Recovery Services Vault.</param>
        /// <param name="healthStatus">Status of health of the
        /// container.</param>
        public AzureSqlContainer(string friendlyName = default(string), string backupManagementType = default(string), string registrationStatus = default(string), string healthStatus = default(string))
            : base(friendlyName, backupManagementType, registrationStatus, healthStatus)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}