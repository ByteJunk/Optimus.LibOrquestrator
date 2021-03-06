// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Optimus.LibOrquestrator
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Queues.
    /// </summary>
    public static partial class QueuesExtensions
    {
            /// <summary>
            /// Sets the result of a transaction.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Queues or OR.Queues.Write.
            ///
            /// Required permissions: Queues.View and Transactions.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static void SetTransactionResultById(this IQueues operations, long key, QueuesSetTransactionResultParameters body = default(QueuesSetTransactionResultParameters), long? xUIPATHOrganizationUnitId = default(long?))
            {
                operations.SetTransactionResultByIdAsync(key, body, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sets the result of a transaction.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Queues or OR.Queues.Write.
            ///
            /// Required permissions: Queues.View and Transactions.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task SetTransactionResultByIdAsync(this IQueues operations, long key, QueuesSetTransactionResultParameters body = default(QueuesSetTransactionResultParameters), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.SetTransactionResultByIdWithHttpMessagesAsync(key, body, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Adds a new queue item.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Queues or OR.Queues.Write.
            ///
            /// Required permissions: Queues.View and Transactions.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static QueueItemDto AddQueueItem(this IQueues operations, QueuesAddQueueItemParameters body = default(QueuesAddQueueItemParameters), string expand = default(string), string select = default(string), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.AddQueueItemAsync(body, expand, select, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Adds a new queue item.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Queues or OR.Queues.Write.
            ///
            /// Required permissions: Queues.View and Transactions.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<QueueItemDto> AddQueueItemAsync(this IQueues operations, QueuesAddQueueItemParameters body = default(QueuesAddQueueItemParameters), string expand = default(string), string select = default(string), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddQueueItemWithHttpMessagesAsync(body, expand, select, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Bulk adds queue items
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Queues or OR.Queues.Write.
            ///
            /// Required permissions: Queues.View and Transactions.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static BulkOperationResponseDtoOfFailedQueueItemDto BulkAddQueueItems(this IQueues operations, QueuesBulkAddQueueItemsParameters body = default(QueuesBulkAddQueueItemsParameters), string expand = default(string), string select = default(string), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.BulkAddQueueItemsAsync(body, expand, select, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Bulk adds queue items
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Queues or OR.Queues.Write.
            ///
            /// Required permissions: Queues.View and Transactions.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BulkOperationResponseDtoOfFailedQueueItemDto> BulkAddQueueItemsAsync(this IQueues operations, QueuesBulkAddQueueItemsParameters body = default(QueuesBulkAddQueueItemsParameters), string expand = default(string), string select = default(string), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BulkAddQueueItemsWithHttpMessagesAsync(body, expand, select, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Starts a transaction.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Queues or OR.Queues.Write.
            ///
            /// Required permissions: Queues.View and Transactions.View and
            /// Transactions.Create and Transactions.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static QueueItemDto StartTransaction(this IQueues operations, QueuesStartTransactionParameters body = default(QueuesStartTransactionParameters), string expand = default(string), string select = default(string), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.StartTransactionAsync(body, expand, select, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Starts a transaction.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Queues or OR.Queues.Write.
            ///
            /// Required permissions: Queues.View and Transactions.View and
            /// Transactions.Create and Transactions.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<QueueItemDto> StartTransactionAsync(this IQueues operations, QueuesStartTransactionParameters body = default(QueuesStartTransactionParameters), string expand = default(string), string select = default(string), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.StartTransactionWithHttpMessagesAsync(body, expand, select, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
