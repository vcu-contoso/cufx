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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using VyStar.ApiStandards.CUFX.Attributes;
using VyStar.ApiStandards.CUFX.Models;

namespace VyStar.ApiStandards.CUFX.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class HoldMessageApiController : ControllerBase
    { 
        /// <summary>
        /// Example of delete operation for HoldMessage
        /// </summary>
        /// <remarks>All values that can be sent in a Hold message.  Contains message context, hold filter and a hold list. This is a wrapper used to more easily serialize the complete message.  All values are optional.  See example specifications for usage. </remarks>
        /// <param name="holdMessage">HoldMessage Specification</param>
        /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/CUFX/CUFX/4.5/HoldMessage/Delete")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("DeleteHoldMessage")]
        [SwaggerResponse(statusCode: 200, type: typeof(InlineResponse20024), description: "OK")]
        public virtual async Task<IActionResult> DeleteHoldMessage([FromBody]HoldMessage2 holdMessage, CancellationToken cancellationToken)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(InlineResponse20024));
            string exampleJson = null;
            exampleJson = "{\n  \"holdMessage\" : {\n    \"holdList\" : {\n      \"totalPages\" : 6,\n      \"pageSize\" : 1,\n      \"positionIndex\" : \"positionIndex\",\n      \"currentPage\" : 0,\n      \"returnPositionIndex\" : \"returnPositionIndex\",\n      \"returnPage\" : 5,\n      \"hold\" : [ {\n        \"reason\" : \"Unknown\",\n        \"amount\" : {\n          \"exchangeRate\" : 2.3021358869347655,\n          \"value\" : 5.637376656633329,\n          \"currencyCode\" : \"AED\"\n        },\n        \"accountSubType\" : \"accountSubType\",\n        \"accountType\" : \"Checking\",\n        \"actualReleaseDate\" : \"actualReleaseDate\",\n        \"description\" : \"description\",\n        \"customData\" : {\n          \"valuePair\" : [ {\n            \"name\" : \"name\",\n            \"value\" : \"value\"\n          }, {\n            \"name\" : \"name\",\n            \"value\" : \"value\"\n          } ],\n          \"totalPages\" : 2,\n          \"pageSize\" : 7,\n          \"positionIndex\" : \"positionIndex\",\n          \"currentPage\" : 5,\n          \"returnPositionIndex\" : \"returnPositionIndex\",\n          \"returnPage\" : 9\n        },\n        \"feeId\" : \"feeId\",\n        \"transactionId\" : \"transactionId\",\n        \"payee\" : \"payee\",\n        \"accountId\" : \"accountId\",\n        \"holdStatus\" : \"Active\",\n        \"endCheckNumber\" : \"endCheckNumber\",\n        \"holdType\" : \"GeneralPurpose\",\n        \"holdId\" : \"holdId\",\n        \"effectiveDate\" : \"effectiveDate\",\n        \"startCheckNumber\" : \"startCheckNumber\",\n        \"expirationDate\" : \"expirationDate\"\n      }, {\n        \"reason\" : \"Unknown\",\n        \"amount\" : {\n          \"exchangeRate\" : 2.3021358869347655,\n          \"value\" : 5.637376656633329,\n          \"currencyCode\" : \"AED\"\n        },\n        \"accountSubType\" : \"accountSubType\",\n        \"accountType\" : \"Checking\",\n        \"actualReleaseDate\" : \"actualReleaseDate\",\n        \"description\" : \"description\",\n        \"customData\" : {\n          \"valuePair\" : [ {\n            \"name\" : \"name\",\n            \"value\" : \"value\"\n          }, {\n            \"name\" : \"name\",\n            \"value\" : \"value\"\n          } ],\n          \"totalPages\" : 2,\n          \"pageSize\" : 7,\n          \"positionIndex\" : \"positionIndex\",\n          \"currentPage\" : 5,\n          \"returnPositionIndex\" : \"returnPositionIndex\",\n          \"returnPage\" : 9\n        },\n        \"feeId\" : \"feeId\",\n        \"transactionId\" : \"transactionId\",\n        \"payee\" : \"payee\",\n        \"accountId\" : \"accountId\",\n        \"holdStatus\" : \"Active\",\n        \"endCheckNumber\" : \"endCheckNumber\",\n        \"holdType\" : \"GeneralPurpose\",\n        \"holdId\" : \"holdId\",\n        \"effectiveDate\" : \"effectiveDate\",\n        \"startCheckNumber\" : \"startCheckNumber\",\n        \"expirationDate\" : \"expirationDate\"\n      } ]\n    },\n    \"messageContext\" : {\n      \"includeZeroNumerics\" : true,\n      \"vendorId\" : \"vendorId\",\n      \"customData\" : {\n        \"valuePair\" : [ {\n          \"name\" : \"name\",\n          \"value\" : \"value\"\n        }, {\n          \"name\" : \"name\",\n          \"value\" : \"value\"\n        } ],\n        \"totalPages\" : 2,\n        \"pageSize\" : 7,\n        \"positionIndex\" : \"positionIndex\",\n        \"currentPage\" : 5,\n        \"returnPositionIndex\" : \"returnPositionIndex\",\n        \"returnPage\" : 9\n      },\n      \"sessionId\" : \"sessionId\",\n      \"receivingNetworkNodeId\" : \"receivingNetworkNodeId\",\n      \"includeBlankFields\" : true,\n      \"fiId\" : \"fiId\",\n      \"dataSourceId\" : \"dataSourceId\",\n      \"environment\" : \"environment\",\n      \"userList\" : {\n        \"totalPages\" : 6,\n        \"pageSize\" : 1,\n        \"positionIndex\" : \"positionIndex\",\n        \"currentPage\" : 0,\n        \"returnPositionIndex\" : \"returnPositionIndex\",\n        \"user\" : [ {\n          \"userIdType\" : \"EmployeeId\",\n          \"processorSessionId\" : \"processorSessionId\",\n          \"customData\" : {\n            \"valuePair\" : [ {\n              \"name\" : \"name\",\n              \"value\" : \"value\"\n            }, {\n              \"name\" : \"name\",\n              \"value\" : \"value\"\n            } ],\n            \"totalPages\" : 2,\n            \"pageSize\" : 7,\n            \"positionIndex\" : \"positionIndex\",\n            \"currentPage\" : 5,\n            \"returnPositionIndex\" : \"returnPositionIndex\",\n            \"returnPage\" : 9\n          },\n          \"partyId\" : \"partyId\",\n          \"userId\" : \"userId\"\n        }, {\n          \"userIdType\" : \"EmployeeId\",\n          \"processorSessionId\" : \"processorSessionId\",\n          \"customData\" : {\n            \"valuePair\" : [ {\n              \"name\" : \"name\",\n              \"value\" : \"value\"\n            }, {\n              \"name\" : \"name\",\n              \"value\" : \"value\"\n            } ],\n            \"totalPages\" : 2,\n            \"pageSize\" : 7,\n            \"positionIndex\" : \"positionIndex\",\n            \"currentPage\" : 5,\n            \"returnPositionIndex\" : \"returnPositionIndex\",\n            \"returnPage\" : 9\n          },\n          \"partyId\" : \"partyId\",\n          \"userId\" : \"userId\"\n        } ],\n        \"returnPage\" : 5\n      },\n      \"cufxVersion\" : \"1.0.3\",\n      \"statusList\" : {\n        \"totalPages\" : 2,\n        \"pageSize\" : 4,\n        \"positionIndex\" : \"positionIndex\",\n        \"currentPage\" : 3,\n        \"returnPositionIndex\" : \"returnPositionIndex\",\n        \"returnPage\" : 7,\n        \"status\" : [ {\n          \"referenceIndex\" : 7,\n          \"statusSubCode\" : \"statusSubCode\",\n          \"statusType\" : \"Success\",\n          \"substitutionList\" : {\n            \"substitution\" : [ {\n              \"id\" : \"id\",\n              \"value\" : \"value\"\n            }, {\n              \"id\" : \"id\",\n              \"value\" : \"value\"\n            } ],\n            \"totalPages\" : 1,\n            \"pageSize\" : 1,\n            \"positionIndex\" : \"positionIndex\",\n            \"currentPage\" : 1,\n            \"returnPositionIndex\" : \"returnPositionIndex\",\n            \"returnPage\" : 6\n          },\n          \"statusMessage\" : \"statusMessage\",\n          \"referenceId\" : \"referenceId\",\n          \"statusCode\" : \"ValueOutOfRangeError\"\n        }, {\n          \"referenceIndex\" : 7,\n          \"statusSubCode\" : \"statusSubCode\",\n          \"statusType\" : \"Success\",\n          \"substitutionList\" : {\n            \"substitution\" : [ {\n              \"id\" : \"id\",\n              \"value\" : \"value\"\n            }, {\n              \"id\" : \"id\",\n              \"value\" : \"value\"\n            } ],\n            \"totalPages\" : 1,\n            \"pageSize\" : 1,\n            \"positionIndex\" : \"positionIndex\",\n            \"currentPage\" : 1,\n            \"returnPositionIndex\" : \"returnPositionIndex\",\n            \"returnPage\" : 6\n          },\n          \"statusMessage\" : \"statusMessage\",\n          \"referenceId\" : \"referenceId\",\n          \"statusCode\" : \"ValueOutOfRangeError\"\n        } ]\n      },\n      \"requestId\" : \"requestId\",\n      \"appId\" : \"appId\",\n      \"sendingNetworkNodeId\" : \"sendingNetworkNodeId\",\n      \"returnDataFilter\" : \"All\",\n      \"configurationId\" : \"configurationId\"\n    }\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InlineResponse20024>(exampleJson)
            : default(InlineResponse20024);
            //TODO: Change the data returned
            return await Task.FromResult<IActionResult>(new ObjectResult(example));
        }

        /// <summary>
        /// Example of get operation for HoldMessage
        /// </summary>
        /// <remarks>All values that can be sent in a Hold message.  Contains message context, hold filter and a hold list. This is a wrapper used to more easily serialize the complete message.  All values are optional.  See example specifications for usage. </remarks>
        /// <param name="holdMessage">HoldMessage Specification</param>
        /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/CUFX/CUFX/4.5/HoldMessage/Get")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("GetHoldMessage")]
        [SwaggerResponse(statusCode: 200, type: typeof(InlineResponse20024), description: "OK")]
        public virtual async Task<IActionResult> GetHoldMessage([FromBody]HoldMessage3 holdMessage, CancellationToken cancellationToken)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(InlineResponse20024));
            string exampleJson = null;
            exampleJson = "{\n  \"holdMessage\" : {\n    \"holdList\" : {\n      \"totalPages\" : 6,\n      \"pageSize\" : 1,\n      \"positionIndex\" : \"positionIndex\",\n      \"currentPage\" : 0,\n      \"returnPositionIndex\" : \"returnPositionIndex\",\n      \"returnPage\" : 5,\n      \"hold\" : [ {\n        \"reason\" : \"Unknown\",\n        \"amount\" : {\n          \"exchangeRate\" : 2.3021358869347655,\n          \"value\" : 5.637376656633329,\n          \"currencyCode\" : \"AED\"\n        },\n        \"accountSubType\" : \"accountSubType\",\n        \"accountType\" : \"Checking\",\n        \"actualReleaseDate\" : \"actualReleaseDate\",\n        \"description\" : \"description\",\n        \"customData\" : {\n          \"valuePair\" : [ {\n            \"name\" : \"name\",\n            \"value\" : \"value\"\n          }, {\n            \"name\" : \"name\",\n            \"value\" : \"value\"\n          } ],\n          \"totalPages\" : 2,\n          \"pageSize\" : 7,\n          \"positionIndex\" : \"positionIndex\",\n          \"currentPage\" : 5,\n          \"returnPositionIndex\" : \"returnPositionIndex\",\n          \"returnPage\" : 9\n        },\n        \"feeId\" : \"feeId\",\n        \"transactionId\" : \"transactionId\",\n        \"payee\" : \"payee\",\n        \"accountId\" : \"accountId\",\n        \"holdStatus\" : \"Active\",\n        \"endCheckNumber\" : \"endCheckNumber\",\n        \"holdType\" : \"GeneralPurpose\",\n        \"holdId\" : \"holdId\",\n        \"effectiveDate\" : \"effectiveDate\",\n        \"startCheckNumber\" : \"startCheckNumber\",\n        \"expirationDate\" : \"expirationDate\"\n      }, {\n        \"reason\" : \"Unknown\",\n        \"amount\" : {\n          \"exchangeRate\" : 2.3021358869347655,\n          \"value\" : 5.637376656633329,\n          \"currencyCode\" : \"AED\"\n        },\n        \"accountSubType\" : \"accountSubType\",\n        \"accountType\" : \"Checking\",\n        \"actualReleaseDate\" : \"actualReleaseDate\",\n        \"description\" : \"description\",\n        \"customData\" : {\n          \"valuePair\" : [ {\n            \"name\" : \"name\",\n            \"value\" : \"value\"\n          }, {\n            \"name\" : \"name\",\n            \"value\" : \"value\"\n          } ],\n          \"totalPages\" : 2,\n          \"pageSize\" : 7,\n          \"positionIndex\" : \"positionIndex\",\n          \"currentPage\" : 5,\n          \"returnPositionIndex\" : \"returnPositionIndex\",\n          \"returnPage\" : 9\n        },\n        \"feeId\" : \"feeId\",\n        \"transactionId\" : \"transactionId\",\n        \"payee\" : \"payee\",\n        \"accountId\" : \"accountId\",\n        \"holdStatus\" : \"Active\",\n        \"endCheckNumber\" : \"endCheckNumber\",\n        \"holdType\" : \"GeneralPurpose\",\n        \"holdId\" : \"holdId\",\n        \"effectiveDate\" : \"effectiveDate\",\n        \"startCheckNumber\" : \"startCheckNumber\",\n        \"expirationDate\" : \"expirationDate\"\n      } ]\n    },\n    \"messageContext\" : {\n      \"includeZeroNumerics\" : true,\n      \"vendorId\" : \"vendorId\",\n      \"customData\" : {\n        \"valuePair\" : [ {\n          \"name\" : \"name\",\n          \"value\" : \"value\"\n        }, {\n          \"name\" : \"name\",\n          \"value\" : \"value\"\n        } ],\n        \"totalPages\" : 2,\n        \"pageSize\" : 7,\n        \"positionIndex\" : \"positionIndex\",\n        \"currentPage\" : 5,\n        \"returnPositionIndex\" : \"returnPositionIndex\",\n        \"returnPage\" : 9\n      },\n      \"sessionId\" : \"sessionId\",\n      \"receivingNetworkNodeId\" : \"receivingNetworkNodeId\",\n      \"includeBlankFields\" : true,\n      \"fiId\" : \"fiId\",\n      \"dataSourceId\" : \"dataSourceId\",\n      \"environment\" : \"environment\",\n      \"userList\" : {\n        \"totalPages\" : 6,\n        \"pageSize\" : 1,\n        \"positionIndex\" : \"positionIndex\",\n        \"currentPage\" : 0,\n        \"returnPositionIndex\" : \"returnPositionIndex\",\n        \"user\" : [ {\n          \"userIdType\" : \"EmployeeId\",\n          \"processorSessionId\" : \"processorSessionId\",\n          \"customData\" : {\n            \"valuePair\" : [ {\n              \"name\" : \"name\",\n              \"value\" : \"value\"\n            }, {\n              \"name\" : \"name\",\n              \"value\" : \"value\"\n            } ],\n            \"totalPages\" : 2,\n            \"pageSize\" : 7,\n            \"positionIndex\" : \"positionIndex\",\n            \"currentPage\" : 5,\n            \"returnPositionIndex\" : \"returnPositionIndex\",\n            \"returnPage\" : 9\n          },\n          \"partyId\" : \"partyId\",\n          \"userId\" : \"userId\"\n        }, {\n          \"userIdType\" : \"EmployeeId\",\n          \"processorSessionId\" : \"processorSessionId\",\n          \"customData\" : {\n            \"valuePair\" : [ {\n              \"name\" : \"name\",\n              \"value\" : \"value\"\n            }, {\n              \"name\" : \"name\",\n              \"value\" : \"value\"\n            } ],\n            \"totalPages\" : 2,\n            \"pageSize\" : 7,\n            \"positionIndex\" : \"positionIndex\",\n            \"currentPage\" : 5,\n            \"returnPositionIndex\" : \"returnPositionIndex\",\n            \"returnPage\" : 9\n          },\n          \"partyId\" : \"partyId\",\n          \"userId\" : \"userId\"\n        } ],\n        \"returnPage\" : 5\n      },\n      \"cufxVersion\" : \"1.0.3\",\n      \"statusList\" : {\n        \"totalPages\" : 2,\n        \"pageSize\" : 4,\n        \"positionIndex\" : \"positionIndex\",\n        \"currentPage\" : 3,\n        \"returnPositionIndex\" : \"returnPositionIndex\",\n        \"returnPage\" : 7,\n        \"status\" : [ {\n          \"referenceIndex\" : 7,\n          \"statusSubCode\" : \"statusSubCode\",\n          \"statusType\" : \"Success\",\n          \"substitutionList\" : {\n            \"substitution\" : [ {\n              \"id\" : \"id\",\n              \"value\" : \"value\"\n            }, {\n              \"id\" : \"id\",\n              \"value\" : \"value\"\n            } ],\n            \"totalPages\" : 1,\n            \"pageSize\" : 1,\n            \"positionIndex\" : \"positionIndex\",\n            \"currentPage\" : 1,\n            \"returnPositionIndex\" : \"returnPositionIndex\",\n            \"returnPage\" : 6\n          },\n          \"statusMessage\" : \"statusMessage\",\n          \"referenceId\" : \"referenceId\",\n          \"statusCode\" : \"ValueOutOfRangeError\"\n        }, {\n          \"referenceIndex\" : 7,\n          \"statusSubCode\" : \"statusSubCode\",\n          \"statusType\" : \"Success\",\n          \"substitutionList\" : {\n            \"substitution\" : [ {\n              \"id\" : \"id\",\n              \"value\" : \"value\"\n            }, {\n              \"id\" : \"id\",\n              \"value\" : \"value\"\n            } ],\n            \"totalPages\" : 1,\n            \"pageSize\" : 1,\n            \"positionIndex\" : \"positionIndex\",\n            \"currentPage\" : 1,\n            \"returnPositionIndex\" : \"returnPositionIndex\",\n            \"returnPage\" : 6\n          },\n          \"statusMessage\" : \"statusMessage\",\n          \"referenceId\" : \"referenceId\",\n          \"statusCode\" : \"ValueOutOfRangeError\"\n        } ]\n      },\n      \"requestId\" : \"requestId\",\n      \"appId\" : \"appId\",\n      \"sendingNetworkNodeId\" : \"sendingNetworkNodeId\",\n      \"returnDataFilter\" : \"All\",\n      \"configurationId\" : \"configurationId\"\n    }\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InlineResponse20024>(exampleJson)
            : default(InlineResponse20024);
            //TODO: Change the data returned
            return await Task.FromResult<IActionResult>(new ObjectResult(example));
        }

        /// <summary>
        /// Example of post operation for HoldMessage
        /// </summary>
        /// <remarks>All values that can be sent in a Hold message.  Contains message context, hold filter and a hold list. This is a wrapper used to more easily serialize the complete message.  All values are optional.  See example specifications for usage. </remarks>
        /// <param name="holdMessage">HoldMessage Specification</param>
        /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
        /// <response code="200">OK</response>
        [HttpPost]
        [Route("/CUFX/CUFX/4.5/HoldMessage")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PostHoldMessage")]
        [SwaggerResponse(statusCode: 200, type: typeof(InlineResponse20024), description: "OK")]
        public virtual async Task<IActionResult> PostHoldMessage([FromBody]HoldMessage1 holdMessage, CancellationToken cancellationToken)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(InlineResponse20024));
            string exampleJson = null;
            exampleJson = "{\n  \"holdMessage\" : {\n    \"holdList\" : {\n      \"totalPages\" : 6,\n      \"pageSize\" : 1,\n      \"positionIndex\" : \"positionIndex\",\n      \"currentPage\" : 0,\n      \"returnPositionIndex\" : \"returnPositionIndex\",\n      \"returnPage\" : 5,\n      \"hold\" : [ {\n        \"reason\" : \"Unknown\",\n        \"amount\" : {\n          \"exchangeRate\" : 2.3021358869347655,\n          \"value\" : 5.637376656633329,\n          \"currencyCode\" : \"AED\"\n        },\n        \"accountSubType\" : \"accountSubType\",\n        \"accountType\" : \"Checking\",\n        \"actualReleaseDate\" : \"actualReleaseDate\",\n        \"description\" : \"description\",\n        \"customData\" : {\n          \"valuePair\" : [ {\n            \"name\" : \"name\",\n            \"value\" : \"value\"\n          }, {\n            \"name\" : \"name\",\n            \"value\" : \"value\"\n          } ],\n          \"totalPages\" : 2,\n          \"pageSize\" : 7,\n          \"positionIndex\" : \"positionIndex\",\n          \"currentPage\" : 5,\n          \"returnPositionIndex\" : \"returnPositionIndex\",\n          \"returnPage\" : 9\n        },\n        \"feeId\" : \"feeId\",\n        \"transactionId\" : \"transactionId\",\n        \"payee\" : \"payee\",\n        \"accountId\" : \"accountId\",\n        \"holdStatus\" : \"Active\",\n        \"endCheckNumber\" : \"endCheckNumber\",\n        \"holdType\" : \"GeneralPurpose\",\n        \"holdId\" : \"holdId\",\n        \"effectiveDate\" : \"effectiveDate\",\n        \"startCheckNumber\" : \"startCheckNumber\",\n        \"expirationDate\" : \"expirationDate\"\n      }, {\n        \"reason\" : \"Unknown\",\n        \"amount\" : {\n          \"exchangeRate\" : 2.3021358869347655,\n          \"value\" : 5.637376656633329,\n          \"currencyCode\" : \"AED\"\n        },\n        \"accountSubType\" : \"accountSubType\",\n        \"accountType\" : \"Checking\",\n        \"actualReleaseDate\" : \"actualReleaseDate\",\n        \"description\" : \"description\",\n        \"customData\" : {\n          \"valuePair\" : [ {\n            \"name\" : \"name\",\n            \"value\" : \"value\"\n          }, {\n            \"name\" : \"name\",\n            \"value\" : \"value\"\n          } ],\n          \"totalPages\" : 2,\n          \"pageSize\" : 7,\n          \"positionIndex\" : \"positionIndex\",\n          \"currentPage\" : 5,\n          \"returnPositionIndex\" : \"returnPositionIndex\",\n          \"returnPage\" : 9\n        },\n        \"feeId\" : \"feeId\",\n        \"transactionId\" : \"transactionId\",\n        \"payee\" : \"payee\",\n        \"accountId\" : \"accountId\",\n        \"holdStatus\" : \"Active\",\n        \"endCheckNumber\" : \"endCheckNumber\",\n        \"holdType\" : \"GeneralPurpose\",\n        \"holdId\" : \"holdId\",\n        \"effectiveDate\" : \"effectiveDate\",\n        \"startCheckNumber\" : \"startCheckNumber\",\n        \"expirationDate\" : \"expirationDate\"\n      } ]\n    },\n    \"messageContext\" : {\n      \"includeZeroNumerics\" : true,\n      \"vendorId\" : \"vendorId\",\n      \"customData\" : {\n        \"valuePair\" : [ {\n          \"name\" : \"name\",\n          \"value\" : \"value\"\n        }, {\n          \"name\" : \"name\",\n          \"value\" : \"value\"\n        } ],\n        \"totalPages\" : 2,\n        \"pageSize\" : 7,\n        \"positionIndex\" : \"positionIndex\",\n        \"currentPage\" : 5,\n        \"returnPositionIndex\" : \"returnPositionIndex\",\n        \"returnPage\" : 9\n      },\n      \"sessionId\" : \"sessionId\",\n      \"receivingNetworkNodeId\" : \"receivingNetworkNodeId\",\n      \"includeBlankFields\" : true,\n      \"fiId\" : \"fiId\",\n      \"dataSourceId\" : \"dataSourceId\",\n      \"environment\" : \"environment\",\n      \"userList\" : {\n        \"totalPages\" : 6,\n        \"pageSize\" : 1,\n        \"positionIndex\" : \"positionIndex\",\n        \"currentPage\" : 0,\n        \"returnPositionIndex\" : \"returnPositionIndex\",\n        \"user\" : [ {\n          \"userIdType\" : \"EmployeeId\",\n          \"processorSessionId\" : \"processorSessionId\",\n          \"customData\" : {\n            \"valuePair\" : [ {\n              \"name\" : \"name\",\n              \"value\" : \"value\"\n            }, {\n              \"name\" : \"name\",\n              \"value\" : \"value\"\n            } ],\n            \"totalPages\" : 2,\n            \"pageSize\" : 7,\n            \"positionIndex\" : \"positionIndex\",\n            \"currentPage\" : 5,\n            \"returnPositionIndex\" : \"returnPositionIndex\",\n            \"returnPage\" : 9\n          },\n          \"partyId\" : \"partyId\",\n          \"userId\" : \"userId\"\n        }, {\n          \"userIdType\" : \"EmployeeId\",\n          \"processorSessionId\" : \"processorSessionId\",\n          \"customData\" : {\n            \"valuePair\" : [ {\n              \"name\" : \"name\",\n              \"value\" : \"value\"\n            }, {\n              \"name\" : \"name\",\n              \"value\" : \"value\"\n            } ],\n            \"totalPages\" : 2,\n            \"pageSize\" : 7,\n            \"positionIndex\" : \"positionIndex\",\n            \"currentPage\" : 5,\n            \"returnPositionIndex\" : \"returnPositionIndex\",\n            \"returnPage\" : 9\n          },\n          \"partyId\" : \"partyId\",\n          \"userId\" : \"userId\"\n        } ],\n        \"returnPage\" : 5\n      },\n      \"cufxVersion\" : \"1.0.3\",\n      \"statusList\" : {\n        \"totalPages\" : 2,\n        \"pageSize\" : 4,\n        \"positionIndex\" : \"positionIndex\",\n        \"currentPage\" : 3,\n        \"returnPositionIndex\" : \"returnPositionIndex\",\n        \"returnPage\" : 7,\n        \"status\" : [ {\n          \"referenceIndex\" : 7,\n          \"statusSubCode\" : \"statusSubCode\",\n          \"statusType\" : \"Success\",\n          \"substitutionList\" : {\n            \"substitution\" : [ {\n              \"id\" : \"id\",\n              \"value\" : \"value\"\n            }, {\n              \"id\" : \"id\",\n              \"value\" : \"value\"\n            } ],\n            \"totalPages\" : 1,\n            \"pageSize\" : 1,\n            \"positionIndex\" : \"positionIndex\",\n            \"currentPage\" : 1,\n            \"returnPositionIndex\" : \"returnPositionIndex\",\n            \"returnPage\" : 6\n          },\n          \"statusMessage\" : \"statusMessage\",\n          \"referenceId\" : \"referenceId\",\n          \"statusCode\" : \"ValueOutOfRangeError\"\n        }, {\n          \"referenceIndex\" : 7,\n          \"statusSubCode\" : \"statusSubCode\",\n          \"statusType\" : \"Success\",\n          \"substitutionList\" : {\n            \"substitution\" : [ {\n              \"id\" : \"id\",\n              \"value\" : \"value\"\n            }, {\n              \"id\" : \"id\",\n              \"value\" : \"value\"\n            } ],\n            \"totalPages\" : 1,\n            \"pageSize\" : 1,\n            \"positionIndex\" : \"positionIndex\",\n            \"currentPage\" : 1,\n            \"returnPositionIndex\" : \"returnPositionIndex\",\n            \"returnPage\" : 6\n          },\n          \"statusMessage\" : \"statusMessage\",\n          \"referenceId\" : \"referenceId\",\n          \"statusCode\" : \"ValueOutOfRangeError\"\n        } ]\n      },\n      \"requestId\" : \"requestId\",\n      \"appId\" : \"appId\",\n      \"sendingNetworkNodeId\" : \"sendingNetworkNodeId\",\n      \"returnDataFilter\" : \"All\",\n      \"configurationId\" : \"configurationId\"\n    }\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InlineResponse20024>(exampleJson)
            : default(InlineResponse20024);
            //TODO: Change the data returned
            return await Task.FromResult<IActionResult>(new ObjectResult(example));
        }

        /// <summary>
        /// Example of put operation for HoldMessage
        /// </summary>
        /// <remarks>All values that can be sent in a Hold message.  Contains message context, hold filter and a hold list. This is a wrapper used to more easily serialize the complete message.  All values are optional.  See example specifications for usage. </remarks>
        /// <param name="holdMessage">HoldMessage Specification</param>
        /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
        /// <response code="200">OK</response>
        [HttpPut]
        [Route("/CUFX/CUFX/4.5/HoldMessage")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PutHoldMessage")]
        [SwaggerResponse(statusCode: 200, type: typeof(InlineResponse20024), description: "OK")]
        public virtual async Task<IActionResult> PutHoldMessage([FromBody]HoldMessage holdMessage, CancellationToken cancellationToken)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(InlineResponse20024));
            string exampleJson = null;
            exampleJson = "{\n  \"holdMessage\" : {\n    \"holdList\" : {\n      \"totalPages\" : 6,\n      \"pageSize\" : 1,\n      \"positionIndex\" : \"positionIndex\",\n      \"currentPage\" : 0,\n      \"returnPositionIndex\" : \"returnPositionIndex\",\n      \"returnPage\" : 5,\n      \"hold\" : [ {\n        \"reason\" : \"Unknown\",\n        \"amount\" : {\n          \"exchangeRate\" : 2.3021358869347655,\n          \"value\" : 5.637376656633329,\n          \"currencyCode\" : \"AED\"\n        },\n        \"accountSubType\" : \"accountSubType\",\n        \"accountType\" : \"Checking\",\n        \"actualReleaseDate\" : \"actualReleaseDate\",\n        \"description\" : \"description\",\n        \"customData\" : {\n          \"valuePair\" : [ {\n            \"name\" : \"name\",\n            \"value\" : \"value\"\n          }, {\n            \"name\" : \"name\",\n            \"value\" : \"value\"\n          } ],\n          \"totalPages\" : 2,\n          \"pageSize\" : 7,\n          \"positionIndex\" : \"positionIndex\",\n          \"currentPage\" : 5,\n          \"returnPositionIndex\" : \"returnPositionIndex\",\n          \"returnPage\" : 9\n        },\n        \"feeId\" : \"feeId\",\n        \"transactionId\" : \"transactionId\",\n        \"payee\" : \"payee\",\n        \"accountId\" : \"accountId\",\n        \"holdStatus\" : \"Active\",\n        \"endCheckNumber\" : \"endCheckNumber\",\n        \"holdType\" : \"GeneralPurpose\",\n        \"holdId\" : \"holdId\",\n        \"effectiveDate\" : \"effectiveDate\",\n        \"startCheckNumber\" : \"startCheckNumber\",\n        \"expirationDate\" : \"expirationDate\"\n      }, {\n        \"reason\" : \"Unknown\",\n        \"amount\" : {\n          \"exchangeRate\" : 2.3021358869347655,\n          \"value\" : 5.637376656633329,\n          \"currencyCode\" : \"AED\"\n        },\n        \"accountSubType\" : \"accountSubType\",\n        \"accountType\" : \"Checking\",\n        \"actualReleaseDate\" : \"actualReleaseDate\",\n        \"description\" : \"description\",\n        \"customData\" : {\n          \"valuePair\" : [ {\n            \"name\" : \"name\",\n            \"value\" : \"value\"\n          }, {\n            \"name\" : \"name\",\n            \"value\" : \"value\"\n          } ],\n          \"totalPages\" : 2,\n          \"pageSize\" : 7,\n          \"positionIndex\" : \"positionIndex\",\n          \"currentPage\" : 5,\n          \"returnPositionIndex\" : \"returnPositionIndex\",\n          \"returnPage\" : 9\n        },\n        \"feeId\" : \"feeId\",\n        \"transactionId\" : \"transactionId\",\n        \"payee\" : \"payee\",\n        \"accountId\" : \"accountId\",\n        \"holdStatus\" : \"Active\",\n        \"endCheckNumber\" : \"endCheckNumber\",\n        \"holdType\" : \"GeneralPurpose\",\n        \"holdId\" : \"holdId\",\n        \"effectiveDate\" : \"effectiveDate\",\n        \"startCheckNumber\" : \"startCheckNumber\",\n        \"expirationDate\" : \"expirationDate\"\n      } ]\n    },\n    \"messageContext\" : {\n      \"includeZeroNumerics\" : true,\n      \"vendorId\" : \"vendorId\",\n      \"customData\" : {\n        \"valuePair\" : [ {\n          \"name\" : \"name\",\n          \"value\" : \"value\"\n        }, {\n          \"name\" : \"name\",\n          \"value\" : \"value\"\n        } ],\n        \"totalPages\" : 2,\n        \"pageSize\" : 7,\n        \"positionIndex\" : \"positionIndex\",\n        \"currentPage\" : 5,\n        \"returnPositionIndex\" : \"returnPositionIndex\",\n        \"returnPage\" : 9\n      },\n      \"sessionId\" : \"sessionId\",\n      \"receivingNetworkNodeId\" : \"receivingNetworkNodeId\",\n      \"includeBlankFields\" : true,\n      \"fiId\" : \"fiId\",\n      \"dataSourceId\" : \"dataSourceId\",\n      \"environment\" : \"environment\",\n      \"userList\" : {\n        \"totalPages\" : 6,\n        \"pageSize\" : 1,\n        \"positionIndex\" : \"positionIndex\",\n        \"currentPage\" : 0,\n        \"returnPositionIndex\" : \"returnPositionIndex\",\n        \"user\" : [ {\n          \"userIdType\" : \"EmployeeId\",\n          \"processorSessionId\" : \"processorSessionId\",\n          \"customData\" : {\n            \"valuePair\" : [ {\n              \"name\" : \"name\",\n              \"value\" : \"value\"\n            }, {\n              \"name\" : \"name\",\n              \"value\" : \"value\"\n            } ],\n            \"totalPages\" : 2,\n            \"pageSize\" : 7,\n            \"positionIndex\" : \"positionIndex\",\n            \"currentPage\" : 5,\n            \"returnPositionIndex\" : \"returnPositionIndex\",\n            \"returnPage\" : 9\n          },\n          \"partyId\" : \"partyId\",\n          \"userId\" : \"userId\"\n        }, {\n          \"userIdType\" : \"EmployeeId\",\n          \"processorSessionId\" : \"processorSessionId\",\n          \"customData\" : {\n            \"valuePair\" : [ {\n              \"name\" : \"name\",\n              \"value\" : \"value\"\n            }, {\n              \"name\" : \"name\",\n              \"value\" : \"value\"\n            } ],\n            \"totalPages\" : 2,\n            \"pageSize\" : 7,\n            \"positionIndex\" : \"positionIndex\",\n            \"currentPage\" : 5,\n            \"returnPositionIndex\" : \"returnPositionIndex\",\n            \"returnPage\" : 9\n          },\n          \"partyId\" : \"partyId\",\n          \"userId\" : \"userId\"\n        } ],\n        \"returnPage\" : 5\n      },\n      \"cufxVersion\" : \"1.0.3\",\n      \"statusList\" : {\n        \"totalPages\" : 2,\n        \"pageSize\" : 4,\n        \"positionIndex\" : \"positionIndex\",\n        \"currentPage\" : 3,\n        \"returnPositionIndex\" : \"returnPositionIndex\",\n        \"returnPage\" : 7,\n        \"status\" : [ {\n          \"referenceIndex\" : 7,\n          \"statusSubCode\" : \"statusSubCode\",\n          \"statusType\" : \"Success\",\n          \"substitutionList\" : {\n            \"substitution\" : [ {\n              \"id\" : \"id\",\n              \"value\" : \"value\"\n            }, {\n              \"id\" : \"id\",\n              \"value\" : \"value\"\n            } ],\n            \"totalPages\" : 1,\n            \"pageSize\" : 1,\n            \"positionIndex\" : \"positionIndex\",\n            \"currentPage\" : 1,\n            \"returnPositionIndex\" : \"returnPositionIndex\",\n            \"returnPage\" : 6\n          },\n          \"statusMessage\" : \"statusMessage\",\n          \"referenceId\" : \"referenceId\",\n          \"statusCode\" : \"ValueOutOfRangeError\"\n        }, {\n          \"referenceIndex\" : 7,\n          \"statusSubCode\" : \"statusSubCode\",\n          \"statusType\" : \"Success\",\n          \"substitutionList\" : {\n            \"substitution\" : [ {\n              \"id\" : \"id\",\n              \"value\" : \"value\"\n            }, {\n              \"id\" : \"id\",\n              \"value\" : \"value\"\n            } ],\n            \"totalPages\" : 1,\n            \"pageSize\" : 1,\n            \"positionIndex\" : \"positionIndex\",\n            \"currentPage\" : 1,\n            \"returnPositionIndex\" : \"returnPositionIndex\",\n            \"returnPage\" : 6\n          },\n          \"statusMessage\" : \"statusMessage\",\n          \"referenceId\" : \"referenceId\",\n          \"statusCode\" : \"ValueOutOfRangeError\"\n        } ]\n      },\n      \"requestId\" : \"requestId\",\n      \"appId\" : \"appId\",\n      \"sendingNetworkNodeId\" : \"sendingNetworkNodeId\",\n      \"returnDataFilter\" : \"All\",\n      \"configurationId\" : \"configurationId\"\n    }\n  }\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InlineResponse20024>(exampleJson)
            : default(InlineResponse20024);
            //TODO: Change the data returned
            return await Task.FromResult<IActionResult>(new ObjectResult(example));
        }
    }
}
