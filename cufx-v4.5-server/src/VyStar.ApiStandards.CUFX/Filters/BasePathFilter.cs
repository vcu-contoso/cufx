/*
 * Credit Union Financial eXchange
 *
 * Credit Union Industry Standard. The following API examples are producedz using scripting methods to create a swagger representation of the XML/XSDs. In the event of any noted deviations, the published XSDs on www.cufxstandards.com are the basis of intended content and behavior. Please see https://bonifii.com/cufx-terms-of-use for the terms of use applicable for CUFX.
 *
 * The version of the OpenAPI document: 4.5
 * 
 * Generated by: https://openapi-generator.tech
 */

using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace VyStar.ApiStandards.CUFX.Filters
{
    /// <summary>
    /// BasePath Document Filter sets BasePath property of OpenAPI and removes it from the individual URL paths
    /// </summary>
    public class BasePathFilter : IDocumentFilter
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="basePath">BasePath to remove from Operations</param>
        public BasePathFilter(string basePath)
        {
            BasePath = basePath;
        }

        /// <summary>
        /// Gets the BasePath of the OpenAPI Doc
        /// </summary>
        /// <returns>The BasePath of the OpenAPI Doc</returns>
        public string BasePath { get; }

        /// <summary>
        /// Apply the filter
        /// </summary>
        /// <param name="openapiDoc">OpenApiDocument</param>
        /// <param name="context">FilterContext</param>
        public void Apply(OpenApiDocument openapiDoc, DocumentFilterContext context)
        {
            //openapiDoc.BasePath = BasePath;

            var pathsToModify = openapiDoc.Paths.Where(p => p.Key.StartsWith(BasePath)).ToList();

            foreach (var (key, value) in pathsToModify)
            {
                if (key.StartsWith(BasePath))
                {
                    var newKey = Regex.Replace(key, $"^{BasePath}", string.Empty);
                    openapiDoc.Paths.Remove(key);
                    openapiDoc.Paths.Add(newKey, value);
                }
            }
        }
    }
}