/*
 * Credit Union Financial eXchange
 *
 * Credit Union Industry Standard. The following API examples are producedz using scripting methods to create a swagger representation of the XML/XSDs. In the event of any noted deviations, the published XSDs on www.cufxstandards.com are the basis of intended content and behavior. Please see https://bonifii.com/cufx-terms-of-use for the terms of use applicable for CUFX.
 *
 * The version of the OpenAPI document: 4.5
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace VyStar.ApiStandards.CUFX.Formatters
{
    /// <inheritdoc />
    public class InputFormatterStream : InputFormatter
    {
        /// <inheritdoc />
        public InputFormatterStream()
        {
            SupportedMediaTypes.Add("application/octet-stream");
            SupportedMediaTypes.Add("image/jpeg");
        }

        /// <inheritdoc />
        public override Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context)
        {
            return InputFormatterResult.SuccessAsync(context.HttpContext.Request.Body);
        }

        /// <inheritdoc />
        protected override bool CanReadType(Type type)
        {
            if (type == typeof(Stream))
            {
                return true;
            }

            return false;
        }
    }
}