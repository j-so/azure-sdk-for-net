// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for EncryptionConfigType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EncryptionConfigType
    {
        [EnumMember(Value = "UserManaged")]
        UserManaged,
        [EnumMember(Value = "ServiceManaged")]
        ServiceManaged
    }
    internal static class EncryptionConfigTypeEnumExtension
    {
        internal static string ToSerializedValue(this EncryptionConfigType? value)
        {
            return value == null ? null : ((EncryptionConfigType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this EncryptionConfigType value)
        {
            switch( value )
            {
                case EncryptionConfigType.UserManaged:
                    return "UserManaged";
                case EncryptionConfigType.ServiceManaged:
                    return "ServiceManaged";
            }
            return null;
        }

        internal static EncryptionConfigType? ParseEncryptionConfigType(this string value)
        {
            switch( value )
            {
                case "UserManaged":
                    return EncryptionConfigType.UserManaged;
                case "ServiceManaged":
                    return EncryptionConfigType.ServiceManaged;
            }
            return null;
        }
    }
}