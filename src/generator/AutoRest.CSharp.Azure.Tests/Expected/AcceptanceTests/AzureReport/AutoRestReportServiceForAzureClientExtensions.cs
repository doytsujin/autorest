// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsAzureReport
{
    using Fixtures.Azure;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AutoRestReportServiceForAzureClient.
    /// </summary>
    public static partial class AutoRestReportServiceForAzureClientExtensions
    {
            /// <summary>
            /// Get test coverage report
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IDictionary<string, int?> GetReport(this IAutoRestReportServiceForAzureClient operations)
            {
                return operations.GetReportAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get test coverage report
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IDictionary<string, int?>> GetReportAsync(this IAutoRestReportServiceForAzureClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetReportWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
