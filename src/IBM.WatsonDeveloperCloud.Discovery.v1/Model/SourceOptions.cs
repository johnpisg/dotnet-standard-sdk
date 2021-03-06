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
using Newtonsoft.Json;

namespace IBM.WatsonDeveloperCloud.Discovery.v1.Model
{
    /// <summary>
    /// The **options** object defines which items to crawl from the source system.
    /// </summary>
    public class SourceOptions : BaseModel
    {
        /// <summary>
        /// Array of folders to crawl from the Box source. Only valid, and required, when the **type** field of the
        /// **source** object is set to `box`.
        /// </summary>
        /// <value>
        /// Array of folders to crawl from the Box source. Only valid, and required, when the **type** field of the
        /// **source** object is set to `box`.
        /// </value>
        [JsonProperty("folders", NullValueHandling = NullValueHandling.Ignore)]
        public List<SourceOptionsFolder> Folders { get; set; }
        /// <summary>
        /// Array of Salesforce document object types to crawl from the Salesforce source. Only valid, and required,
        /// when the **type** field of the **source** object is set to `salesforce`.
        /// </summary>
        /// <value>
        /// Array of Salesforce document object types to crawl from the Salesforce source. Only valid, and required,
        /// when the **type** field of the **source** object is set to `salesforce`.
        /// </value>
        [JsonProperty("objects", NullValueHandling = NullValueHandling.Ignore)]
        public List<SourceOptionsObject> Objects { get; set; }
        /// <summary>
        /// Array of Microsoft SharePointoint Online site collections to crawl from the SharePoint source. Only valid
        /// and required when the **type** field of the **source** object is set to `sharepoint`.
        /// </summary>
        /// <value>
        /// Array of Microsoft SharePointoint Online site collections to crawl from the SharePoint source. Only valid
        /// and required when the **type** field of the **source** object is set to `sharepoint`.
        /// </value>
        [JsonProperty("site_collections", NullValueHandling = NullValueHandling.Ignore)]
        public List<SourceOptionsSiteColl> SiteCollections { get; set; }
    }

}
