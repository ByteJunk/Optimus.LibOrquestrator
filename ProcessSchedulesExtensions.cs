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
    /// Extension methods for ProcessSchedules.
    /// </summary>
    public static partial class ProcessSchedulesExtensions
    {
            /// <summary>
            /// Gets the process schedules.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Jobs or OR.Jobs.Read.
            ///
            /// Required permissions: Schedules.View.
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
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static ODataValueOfIEnumerableOfProcessScheduleDto Get(this IProcessSchedules operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.GetAsync(expand, filter, select, orderby, top, skip, count, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the process schedules.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Jobs or OR.Jobs.Read.
            ///
            /// Required permissions: Schedules.View.
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
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataValueOfIEnumerableOfProcessScheduleDto> GetAsync(this IProcessSchedules operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(expand, filter, select, orderby, top, skip, count, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new process schedule.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Jobs or OR.Jobs.Write.
            ///
            /// Required permissions: Schedules.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static ProcessScheduleDto Post(this IProcessSchedules operations, ProcessScheduleDto body = default(ProcessScheduleDto), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.PostAsync(body, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new process schedule.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Jobs or OR.Jobs.Write.
            ///
            /// Required permissions: Schedules.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProcessScheduleDto> PostAsync(this IProcessSchedules operations, ProcessScheduleDto body = default(ProcessScheduleDto), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(body, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a single process schedule based on its key.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Jobs or OR.Jobs.Read.
            ///
            /// Required permissions: Schedules.View.
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
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static ProcessScheduleDto GetById(this IProcessSchedules operations, long key, string expand = default(string), string select = default(string), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.GetByIdAsync(key, expand, select, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a single process schedule based on its key.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Jobs or OR.Jobs.Read.
            ///
            /// Required permissions: Schedules.View.
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
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProcessScheduleDto> GetByIdAsync(this IProcessSchedules operations, long key, string expand = default(string), string select = default(string), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(key, expand, select, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Edits a process schedule.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Jobs or OR.Jobs.Write.
            ///
            /// Required permissions: Schedules.Edit.
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
            public static ProcessScheduleDto PutById(this IProcessSchedules operations, long key, ProcessScheduleDto body = default(ProcessScheduleDto), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.PutByIdAsync(key, body, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Edits a process schedule.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Jobs or OR.Jobs.Write.
            ///
            /// Required permissions: Schedules.Edit.
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
            public static async Task<ProcessScheduleDto> PutByIdAsync(this IProcessSchedules operations, long key, ProcessScheduleDto body = default(ProcessScheduleDto), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutByIdWithHttpMessagesAsync(key, body, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a process schedule.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Jobs or OR.Jobs.Write.
            ///
            /// Required permissions: Schedules.Delete.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static void DeleteById(this IProcessSchedules operations, long key, long? xUIPATHOrganizationUnitId = default(long?))
            {
                operations.DeleteByIdAsync(key, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a process schedule.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Jobs or OR.Jobs.Write.
            ///
            /// Required permissions: Schedules.Delete.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteByIdAsync(this IProcessSchedules operations, long key, long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteByIdWithHttpMessagesAsync(key, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Activates a process schedule associated with a queue
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Jobs or OR.Jobs.Write.
            ///
            /// Required permissions: Schedules.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static void ActivateById(this IProcessSchedules operations, long key, long? xUIPATHOrganizationUnitId = default(long?))
            {
                operations.ActivateByIdAsync(key, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Activates a process schedule associated with a queue
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Jobs or OR.Jobs.Write.
            ///
            /// Required permissions: Schedules.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ActivateByIdAsync(this IProcessSchedules operations, long key, long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ActivateByIdWithHttpMessagesAsync(key, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns a collection of all the ids of the robots associated to an schedule
            /// based on schedule Id.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Jobs or OR.Jobs.Read.
            ///
            /// Required permissions: Schedules.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// The Id of the schedule for which the robot ids are fetched.
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
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static ODataValueOfIEnumerableOfInt64 GetRobotIdsForScheduleByKey(this IProcessSchedules operations, long key, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), bool? count = default(bool?), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.GetRobotIdsForScheduleByKeyAsync(key, expand, filter, select, orderby, count, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a collection of all the ids of the robots associated to an schedule
            /// based on schedule Id.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Jobs or OR.Jobs.Read.
            ///
            /// Required permissions: Schedules.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// The Id of the schedule for which the robot ids are fetched.
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
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataValueOfIEnumerableOfInt64> GetRobotIdsForScheduleByKeyAsync(this IProcessSchedules operations, long key, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), bool? count = default(bool?), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetRobotIdsForScheduleByKeyWithHttpMessagesAsync(key, expand, filter, select, orderby, count, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Enables/disables a group of schedules.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Jobs or OR.Jobs.Write.
            ///
            /// Required permissions: Schedules.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// &lt;para /&gt;Enabled - If true the schedules will be enabled, if false the
            /// schedules will be disabled.
            /// &lt;para /&gt;ScheduleIds - The collection of ids of the affected
            /// schedules.
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
            public static ODataValueOfBoolean SetEnabled(this IProcessSchedules operations, ProcessSetEnabledRequest body = default(ProcessSetEnabledRequest), string expand = default(string), string select = default(string), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.SetEnabledAsync(body, expand, select, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Enables/disables a group of schedules.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Jobs or OR.Jobs.Write.
            ///
            /// Required permissions: Schedules.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// &lt;para /&gt;Enabled - If true the schedules will be enabled, if false the
            /// schedules will be disabled.
            /// &lt;para /&gt;ScheduleIds - The collection of ids of the affected
            /// schedules.
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
            public static async Task<ODataValueOfBoolean> SetEnabledAsync(this IProcessSchedules operations, ProcessSetEnabledRequest body = default(ProcessSetEnabledRequest), string expand = default(string), string select = default(string), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SetEnabledWithHttpMessagesAsync(body, expand, select, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
