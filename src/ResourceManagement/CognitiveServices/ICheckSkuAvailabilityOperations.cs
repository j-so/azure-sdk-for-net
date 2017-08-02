// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.CognitiveServices.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.CognitiveServices;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// CheckSkuAvailabilityOperations operations.
    /// </summary>
    public partial interface ICheckSkuAvailabilityOperations
    {
        /// <summary>
        /// Check available SKUs.
        /// </summary>
        /// <param name='skus'>
        /// The SKU of the resource.
        /// </param>
        /// <param name='kind'>
        /// The Kind of the resource. Possible values include: 'Academic',
        /// 'Bing.Autosuggest', 'Bing.Search', 'Bing.Speech',
        /// 'Bing.SpellCheck', 'ComputerVision', 'ContentModerator',
        /// 'CustomSpeech', 'Emotion', 'Face', 'LUIS', 'Recommendations',
        /// 'SpeakerRecognition', 'Speech', 'SpeechTranslation',
        /// 'TextAnalytics', 'TextTranslation', 'WebLM'
        /// </param>
        /// <param name='type'>
        /// The Type of the resource.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CheckSkuAvailabilityResultListInner>> ListWithHttpMessagesAsync(IList<string> skus, string kind, string type, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}