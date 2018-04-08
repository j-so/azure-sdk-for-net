// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// SSH configuration settings for the VM
    /// </summary>
    public partial class SshConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the SshConfiguration class.
        /// </summary>
        public SshConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SshConfiguration class.
        /// </summary>
        /// <param name="userAccountSettings">Settings for user account to be
        /// created on a node.</param>
        /// <param name="publicIPsToAllow">List of source IP ranges to allow
        /// SSH connection to a node.</param>
        public SshConfiguration(UserAccountSettings userAccountSettings, IList<string> publicIPsToAllow = default(IList<string>))
        {
            PublicIPsToAllow = publicIPsToAllow;
            UserAccountSettings = userAccountSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of source IP ranges to allow SSH connection to a
        /// node.
        /// </summary>
        /// <remarks>
        /// Default value is '*' can be used to match all source IPs. Maximum
        /// number of IP ranges that can be specified are 400.
        /// </remarks>
        [JsonProperty(PropertyName = "publicIPsToAllow")]
        public IList<string> PublicIPsToAllow { get; set; }

        /// <summary>
        /// Gets or sets settings for user account to be created on a node.
        /// </summary>
        [JsonProperty(PropertyName = "userAccountSettings")]
        public UserAccountSettings UserAccountSettings { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (UserAccountSettings == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UserAccountSettings");
            }
            if (UserAccountSettings != null)
            {
                UserAccountSettings.Validate();
            }
        }
    }
}
