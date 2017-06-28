// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using Azure;
    using Management;
    using Logic;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The sku type.
    /// </summary>
    public partial class Sku
    {
        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        public Sku() { }

        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        /// <param name="name">The name. Possible values include:
        /// 'NotSpecified', 'Free', 'Shared', 'Basic', 'Standard',
        /// 'Premium'</param>
        /// <param name="plan">The reference to plan.</param>
        public Sku(SkuName name, ResourceReference plan = default(ResourceReference))
        {
            Name = name;
            Plan = plan;
        }

        /// <summary>
        /// Gets or sets the name. Possible values include: 'NotSpecified',
        /// 'Free', 'Shared', 'Basic', 'Standard', 'Premium'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public SkuName Name { get; set; }

        /// <summary>
        /// Gets or sets the reference to plan.
        /// </summary>
        [JsonProperty(PropertyName = "plan")]
        public ResourceReference Plan { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
