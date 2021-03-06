/**
* Copyright 2018 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using System.Collections.Generic;
using IBM.WatsonDeveloperCloud.PersonalityInsights.v3.Model;

namespace IBM.WatsonDeveloperCloud.PersonalityInsights.v3
{
    public partial interface IPersonalityInsightsService
    {
        /// <summary>
        /// Get profile.
        ///
        /// Generates a personality profile for the author of the input text. The service accepts a maximum of 20 MB of
        /// input content, but it requires much less text to produce an accurate profile; for more information, see
        /// [Providing sufficient
        /// input](https://console.bluemix.net/docs/services/personality-insights/input.html#sufficient). The service
        /// analyzes text in Arabic, English, Japanese, Korean, or Spanish and returns its results in a variety of
        /// languages. You can provide plain text, HTML, or JSON input by specifying the **Content-Type** parameter; the
        /// default is `text/plain`. Request a JSON or comma-separated values (CSV) response by specifying the
        /// **Accept** parameter; CSV output includes a fixed number of columns and optional headers.
        ///
        /// Per the JSON specification, the default character encoding for JSON content is effectively always UTF-8; per
        /// the HTTP specification, the default encoding for plain text and HTML is ISO-8859-1 (effectively, the ASCII
        /// character set). When specifying a content type of plain text or HTML, include the `charset` parameter to
        /// indicate the character encoding of the input text; for example: `Content-Type: text/plain;charset=utf-8`.
        ///
        /// For detailed information about calling the service and the responses it can generate, see [Requesting a
        /// profile](https://console.bluemix.net/docs/services/personality-insights/input.html), [Understanding a JSON
        /// profile](https://console.bluemix.net/docs/services/personality-insights/output.html), and [Understanding a
        /// CSV profile](https://console.bluemix.net/docs/services/personality-insights/output-csv.html).
        /// </summary>
        /// <param name="content">A maximum of 20 MB of content to analyze, though the service requires much less text;
        /// for more information, see [Providing sufficient
        /// input](https://console.bluemix.net/docs/services/personality-insights/input.html#sufficient). For JSON
        /// input, provide an object of type `Content`.</param>
        /// <param name="contentType">The type of the input. A character encoding can be specified by including a
        /// `charset` parameter. For example, 'text/html;charset=utf-8'.</param>
        /// <param name="contentLanguage">The language of the input text for the request: Arabic, English, Japanese,
        /// Korean, or Spanish. Regional variants are treated as their parent language; for example, `en-US` is
        /// interpreted as `en`.
        ///
        /// The effect of the **Content-Language** parameter depends on the **Content-Type** parameter. When
        /// **Content-Type** is `text/plain` or `text/html`, **Content-Language** is the only way to specify the
        /// language. When **Content-Type** is `application/json`, **Content-Language** overrides a language specified
        /// with the `language` parameter of a `ContentItem` object, and content items that specify a different language
        /// are ignored; omit this parameter to base the language on the specification of the content items. You can
        /// specify any combination of languages for **Content-Language** and **Accept-Language**. (optional, default to
        /// en)</param>
        /// <param name="acceptLanguage">The desired language of the response. For two-character arguments, regional
        /// variants are treated as their parent language; for example, `en-US` is interpreted as `en`. You can specify
        /// any combination of languages for the input and response content. (optional, default to en)</param>
        /// <param name="rawScores">Indicates whether a raw score in addition to a normalized percentile is returned for
        /// each characteristic; raw scores are not compared with a sample population. By default, only normalized
        /// percentiles are returned. (optional, default to false)</param>
        /// <param name="csvHeaders">Indicates whether column labels are returned with a CSV response. By default, no
        /// column labels are returned. Applies only when the **Accept** parameter is set to `text/csv`. (optional,
        /// default to false)</param>
        /// <param name="consumptionPreferences">Indicates whether consumption preferences are returned with the
        /// results. By default, no consumption preferences are returned. (optional, default to false)</param>
        /// <param name="customData">Custom data object to pass data including custom request headers.</param>
        /// <returns><see cref="Profile" />Profile</returns>
        Profile Profile(Content content, string contentType, string contentLanguage = null, string acceptLanguage = null, bool? rawScores = null, bool? csvHeaders = null, bool? consumptionPreferences = null, Dictionary<string, object> customData = null);
        /// <summary>
        /// Get profile as csv.
        ///
        /// Generates a personality profile for the author of the input text. The service accepts a maximum of 20 MB of
        /// input content, but it requires much less text to produce an accurate profile; for more information, see
        /// [Providing sufficient
        /// input](https://console.bluemix.net/docs/services/personality-insights/input.html#sufficient). The service
        /// analyzes text in Arabic, English, Japanese, Korean, or Spanish and returns its results in a variety of
        /// languages. You can provide plain text, HTML, or JSON input by specifying the **Content-Type** parameter; the
        /// default is `text/plain`. Request a JSON or comma-separated values (CSV) response by specifying the
        /// **Accept** parameter; CSV output includes a fixed number of columns and optional headers.
        ///
        /// Per the JSON specification, the default character encoding for JSON content is effectively always UTF-8; per
        /// the HTTP specification, the default encoding for plain text and HTML is ISO-8859-1 (effectively, the ASCII
        /// character set). When specifying a content type of plain text or HTML, include the `charset` parameter to
        /// indicate the character encoding of the input text; for example: `Content-Type: text/plain;charset=utf-8`.
        ///
        /// For detailed information about calling the service and the responses it can generate, see [Requesting a
        /// profile](https://console.bluemix.net/docs/services/personality-insights/input.html), [Understanding a JSON
        /// profile](https://console.bluemix.net/docs/services/personality-insights/output.html), and [Understanding a
        /// CSV profile](https://console.bluemix.net/docs/services/personality-insights/output-csv.html).
        /// </summary>
        /// <param name="content">A maximum of 20 MB of content to analyze, though the service requires much less text;
        /// for more information, see [Providing sufficient
        /// input](https://console.bluemix.net/docs/services/personality-insights/input.html#sufficient). For JSON
        /// input, provide an object of type `Content`.</param>
        /// <param name="contentType">The type of the input. A character encoding can be specified by including a
        /// `charset` parameter. For example, 'text/html;charset=utf-8'.</param>
        /// <param name="contentLanguage">The language of the input text for the request: Arabic, English, Japanese,
        /// Korean, or Spanish. Regional variants are treated as their parent language; for example, `en-US` is
        /// interpreted as `en`.
        ///
        /// The effect of the **Content-Language** parameter depends on the **Content-Type** parameter. When
        /// **Content-Type** is `text/plain` or `text/html`, **Content-Language** is the only way to specify the
        /// language. When **Content-Type** is `application/json`, **Content-Language** overrides a language specified
        /// with the `language` parameter of a `ContentItem` object, and content items that specify a different language
        /// are ignored; omit this parameter to base the language on the specification of the content items. You can
        /// specify any combination of languages for **Content-Language** and **Accept-Language**. (optional, default to
        /// en)</param>
        /// <param name="acceptLanguage">The desired language of the response. For two-character arguments, regional
        /// variants are treated as their parent language; for example, `en-US` is interpreted as `en`. You can specify
        /// any combination of languages for the input and response content. (optional, default to en)</param>
        /// <param name="rawScores">Indicates whether a raw score in addition to a normalized percentile is returned for
        /// each characteristic; raw scores are not compared with a sample population. By default, only normalized
        /// percentiles are returned. (optional, default to false)</param>
        /// <param name="csvHeaders">Indicates whether column labels are returned with a CSV response. By default, no
        /// column labels are returned. Applies only when the **Accept** parameter is set to `text/csv`. (optional,
        /// default to false)</param>
        /// <param name="consumptionPreferences">Indicates whether consumption preferences are returned with the
        /// results. By default, no consumption preferences are returned. (optional, default to false)</param>
        /// <param name="customData">Custom data object to pass data including custom request headers.</param>
        /// <returns><see cref="System.IO.FileStream" />System.IO.FileStream</returns>
        System.IO.MemoryStream ProfileAsCsv(Content content, string contentType, string contentLanguage = null, string acceptLanguage = null, bool? rawScores = null, bool? csvHeaders = null, bool? consumptionPreferences = null, Dictionary<string, object> customData = null);
    }
}
