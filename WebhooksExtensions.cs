// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Optimus.LibOrquestrator
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Webhooks.
    /// </summary>
    public static partial class WebhooksExtensions
    {
            /// <summary>
            /// List webhooks
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Webhooks or OR.Webhooks.Read.
            ///
            /// Required permissions: Webhooks.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='filter'>
            /// Restricts the set of items returned. The maximum number of expressions is
            /// 100.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='orderby'>
            /// Specifies the order in which items are returned. The maximum number of
            /// expressions is 5.
            /// </param>
            /// <param name='top'>
            /// Limits the number of items returned from a collection. The maximum value is
            /// 1000.
            /// </param>
            /// <param name='skip'>
            /// Excludes the specified number of items of the queried collection from the
            /// result.
            /// </param>
            /// <param name='count'>
            /// Indicates whether the total count of items within a collection are returned
            /// in the result.
            /// </param>
            public static ODataValueOfIEnumerableOfWebhookDto Get(this IWebhooks operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?))
            {
                return operations.GetAsync(expand, filter, select, orderby, top, skip, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List webhooks
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Webhooks or OR.Webhooks.Read.
            ///
            /// Required permissions: Webhooks.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='filter'>
            /// Restricts the set of items returned. The maximum number of expressions is
            /// 100.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='orderby'>
            /// Specifies the order in which items are returned. The maximum number of
            /// expressions is 5.
            /// </param>
            /// <param name='top'>
            /// Limits the number of items returned from a collection. The maximum value is
            /// 1000.
            /// </param>
            /// <param name='skip'>
            /// Excludes the specified number of items of the queried collection from the
            /// result.
            /// </param>
            /// <param name='count'>
            /// Indicates whether the total count of items within a collection are returned
            /// in the result.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataValueOfIEnumerableOfWebhookDto> GetAsync(this IWebhooks operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(expand, filter, select, orderby, top, skip, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a new webhook subscription
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Webhooks or OR.Webhooks.Write.
            ///
            /// Required permissions: Webhooks.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static WebhookDto Post(this IWebhooks operations, WebhookDto body = default(WebhookDto))
            {
                return operations.PostAsync(body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a new webhook subscription
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Webhooks or OR.Webhooks.Write.
            ///
            /// Required permissions: Webhooks.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WebhookDto> PostAsync(this IWebhooks operations, WebhookDto body = default(WebhookDto), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a single webhook
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Webhooks or OR.Webhooks.Read.
            ///
            /// Required permissions: Webhooks.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            public static WebhookDto GetById(this IWebhooks operations, long key, string expand = default(string), string select = default(string))
            {
                return operations.GetByIdAsync(key, expand, select).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a single webhook
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Webhooks or OR.Webhooks.Read.
            ///
            /// Required permissions: Webhooks.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WebhookDto> GetByIdAsync(this IWebhooks operations, long key, string expand = default(string), string select = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(key, expand, select, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update an existing webhook subscription
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Webhooks or OR.Webhooks.Write.
            ///
            /// Required permissions: Webhooks.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static WebhookDto PutById(this IWebhooks operations, long key, WebhookDto body = default(WebhookDto))
            {
                return operations.PutByIdAsync(key, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update an existing webhook subscription
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Webhooks or OR.Webhooks.Write.
            ///
            /// Required permissions: Webhooks.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WebhookDto> PutByIdAsync(this IWebhooks operations, long key, WebhookDto body = default(WebhookDto), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutByIdWithHttpMessagesAsync(key, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Patches a webhook
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Webhooks or OR.Webhooks.Write.
            ///
            /// Required permissions: Webhooks.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static WebhookDto PatchById(this IWebhooks operations, long key, WebhookDto body = default(WebhookDto))
            {
                return operations.PatchByIdAsync(key, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Patches a webhook
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Webhooks or OR.Webhooks.Write.
            ///
            /// Required permissions: Webhooks.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<WebhookDto> PatchByIdAsync(this IWebhooks operations, long key, WebhookDto body = default(WebhookDto), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PatchByIdWithHttpMessagesAsync(key, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a webhook subscription
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Webhooks or OR.Webhooks.Write.
            ///
            /// Required permissions: Webhooks.Delete.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            public static void DeleteById(this IWebhooks operations, long key)
            {
                operations.DeleteByIdAsync(key).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a webhook subscription
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Webhooks or OR.Webhooks.Write.
            ///
            /// Required permissions: Webhooks.Delete.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteByIdAsync(this IWebhooks operations, long key, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteByIdWithHttpMessagesAsync(key, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Sends a Ping request to webhook endpoint.
            /// Used for testing connectivity and availability of target URL
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Webhooks or OR.Webhooks.Write.
            ///
            /// Required permissions: Webhooks.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            public static PingEventDto PingById(this IWebhooks operations, long key, string expand = default(string), string select = default(string))
            {
                return operations.PingByIdAsync(key, expand, select).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sends a Ping request to webhook endpoint.
            /// Used for testing connectivity and availability of target URL
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Webhooks or OR.Webhooks.Write.
            ///
            /// Required permissions: Webhooks.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PingEventDto> PingByIdAsync(this IWebhooks operations, long key, string expand = default(string), string select = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PingByIdWithHttpMessagesAsync(key, expand, select, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of event types a webhook can subscribe to
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Webhooks or OR.Webhooks.Read.
            ///
            /// Required permissions: Webhooks.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='filter'>
            /// Restricts the set of items returned. The maximum number of expressions is
            /// 100.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='orderby'>
            /// Specifies the order in which items are returned. The maximum number of
            /// expressions is 5.
            /// </param>
            /// <param name='count'>
            /// Indicates whether the total count of items within a collection are returned
            /// in the result.
            /// </param>
            public static ODataValueOfIEnumerableOfWebhookEventTypeDto GetEventTypes(this IWebhooks operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), bool? count = default(bool?))
            {
                return operations.GetEventTypesAsync(expand, filter, select, orderby, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of event types a webhook can subscribe to
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Webhooks or OR.Webhooks.Read.
            ///
            /// Required permissions: Webhooks.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='filter'>
            /// Restricts the set of items returned. The maximum number of expressions is
            /// 100.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='orderby'>
            /// Specifies the order in which items are returned. The maximum number of
            /// expressions is 5.
            /// </param>
            /// <param name='count'>
            /// Indicates whether the total count of items within a collection are returned
            /// in the result.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataValueOfIEnumerableOfWebhookEventTypeDto> GetEventTypesAsync(this IWebhooks operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), bool? count = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetEventTypesWithHttpMessagesAsync(expand, filter, select, orderby, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Triggers an event of type "custom"
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Webhooks or OR.Webhooks.Write.
            ///
            /// Required permissions: Webhooks.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Any custom event data payload
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            public static CustomEventDto TriggerCustom(this IWebhooks operations, IDictionary<string, object> body = default(IDictionary<string, object>), string expand = default(string), string select = default(string))
            {
                return operations.TriggerCustomAsync(body, expand, select).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Triggers an event of type "custom"
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Webhooks or OR.Webhooks.Write.
            ///
            /// Required permissions: Webhooks.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// Any custom event data payload
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CustomEventDto> TriggerCustomAsync(this IWebhooks operations, IDictionary<string, object> body = default(IDictionary<string, object>), string expand = default(string), string select = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.TriggerCustomWithHttpMessagesAsync(body, expand, select, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
