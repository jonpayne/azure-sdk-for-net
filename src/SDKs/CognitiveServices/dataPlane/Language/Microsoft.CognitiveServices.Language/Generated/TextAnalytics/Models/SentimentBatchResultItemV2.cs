// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.CognitiveServices.Language.TextAnalytics.Models
{
    using Microsoft.CognitiveServices;
    using Microsoft.CognitiveServices.Language;
    using Microsoft.CognitiveServices.Language.TextAnalytics;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SentimentBatchResultItemV2
    {
        /// <summary>
        /// Initializes a new instance of the SentimentBatchResultItemV2 class.
        /// </summary>
        public SentimentBatchResultItemV2()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SentimentBatchResultItemV2 class.
        /// </summary>
        /// <param name="score">A decimal number between 0 and 1 denoting the
        /// sentiment of the document.
        /// A score above 0.7 usually refers to a positive document while a
        /// score below 0.3 normally has a negative connotation.
        /// Mid values refer to neutral text.</param>
        /// <param name="id">Unique document identifier.</param>
        public SentimentBatchResultItemV2(double? score = default(double?), string id = default(string))
        {
            Score = score;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a decimal number between 0 and 1 denoting the
        /// sentiment of the document.
        /// A score above 0.7 usually refers to a positive document while a
        /// score below 0.3 normally has a negative connotation.
        /// Mid values refer to neutral text.
        /// </summary>
        [JsonProperty(PropertyName = "score")]
        public double? Score { get; set; }

        /// <summary>
        /// Gets or sets unique document identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

    }
}