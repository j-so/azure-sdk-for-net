// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApplicationInsights.Management.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Annotation associated with an application insights resource.
    /// </summary>
    public partial class Annotation
    {
        /// <summary>
        /// Initializes a new instance of the Annotation class.
        /// </summary>
        public Annotation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Annotation class.
        /// </summary>
        /// <param name="annotationName">Name of annotation</param>
        /// <param name="category">Category of annotation, free form</param>
        /// <param name="eventTime">Time when event occurred</param>
        /// <param name="id">Unique Id for annotation</param>
        /// <param name="properties">Serialized JSON object for detailed
        /// properties</param>
        /// <param name="relatedAnnotation">Related parent annotation if
        /// any</param>
        public Annotation(string annotationName = default(string), string category = default(string), System.DateTime? eventTime = default(System.DateTime?), string id = default(string), string properties = default(string), string relatedAnnotation = default(string))
        {
            AnnotationName = annotationName;
            Category = category;
            EventTime = eventTime;
            Id = id;
            Properties = properties;
            RelatedAnnotation = relatedAnnotation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of annotation
        /// </summary>
        [JsonProperty(PropertyName = "AnnotationName")]
        public string AnnotationName { get; set; }

        /// <summary>
        /// Gets or sets category of annotation, free form
        /// </summary>
        [JsonProperty(PropertyName = "Category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets time when event occurred
        /// </summary>
        [JsonProperty(PropertyName = "EventTime")]
        public System.DateTime? EventTime { get; set; }

        /// <summary>
        /// Gets or sets unique Id for annotation
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets serialized JSON object for detailed properties
        /// </summary>
        [JsonProperty(PropertyName = "Properties")]
        public string Properties { get; set; }

        /// <summary>
        /// Gets or sets related parent annotation if any
        /// </summary>
        [JsonProperty(PropertyName = "RelatedAnnotation")]
        public string RelatedAnnotation { get; set; }

    }
}
