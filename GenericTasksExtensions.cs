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
    /// Extension methods for GenericTasks.
    /// </summary>
    public static partial class GenericTasksExtensions
    {
            /// <summary>
            /// Complete the task by saving task data and action taken
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Tasks or OR.Tasks.Write.
            ///
            /// Required permissions: Tasks.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// TaskCompletionRequest
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static void CompleteTask(this IGenericTasks operations, TaskCompletionRequest body = default(TaskCompletionRequest), long? xUIPATHOrganizationUnitId = default(long?))
            {
                operations.CompleteTaskAsync(body, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Complete the task by saving task data and action taken
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Tasks or OR.Tasks.Write.
            ///
            /// Required permissions: Tasks.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// TaskCompletionRequest
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CompleteTaskAsync(this IGenericTasks operations, TaskCompletionRequest body = default(TaskCompletionRequest), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.CompleteTaskWithHttpMessagesAsync(body, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates a new Generic Task.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Tasks or OR.Tasks.Write.
            ///
            /// Required permissions: Tasks.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// The task to be created.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static TaskDataDto CreateTask(this IGenericTasks operations, TaskCreateRequest body = default(TaskCreateRequest), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.CreateTaskAsync(body, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new Generic Task.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Tasks or OR.Tasks.Write.
            ///
            /// Required permissions: Tasks.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// The task to be created.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TaskDataDto> CreateTaskAsync(this IGenericTasks operations, TaskCreateRequest body = default(TaskCreateRequest), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateTaskWithHttpMessagesAsync(body, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns task data dto
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Tasks or OR.Tasks.Read.
            ///
            /// Required permissions: Tasks.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='taskId'>
            /// Task id
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static TaskDataDto GetTaskDataById(this IGenericTasks operations, long? taskId = default(long?), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.GetTaskDataByIdAsync(taskId, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns task data dto
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Tasks or OR.Tasks.Read.
            ///
            /// Required permissions: Tasks.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='taskId'>
            /// Task id
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TaskDataDto> GetTaskDataByIdAsync(this IGenericTasks operations, long? taskId = default(long?), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTaskDataByIdWithHttpMessagesAsync(taskId, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Save changes done by the current user and Reassign Task to another user
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Tasks or OR.Tasks.Write.
            ///
            /// Required permissions: Tasks.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// TaskSaveAndReassignmentRequest
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static void SaveAndReassignTask(this IGenericTasks operations, TaskSaveAndReassignmentRequest body = default(TaskSaveAndReassignmentRequest), long? xUIPATHOrganizationUnitId = default(long?))
            {
                operations.SaveAndReassignTaskAsync(body, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Save changes done by the current user and Reassign Task to another user
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Tasks or OR.Tasks.Write.
            ///
            /// Required permissions: Tasks.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// TaskSaveAndReassignmentRequest
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task SaveAndReassignTaskAsync(this IGenericTasks operations, TaskSaveAndReassignmentRequest body = default(TaskSaveAndReassignmentRequest), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.SaveAndReassignTaskWithHttpMessagesAsync(body, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Save Task data
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Tasks or OR.Tasks.Write.
            ///
            /// Required permissions: Tasks.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// TaskDataSaveRequest
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static void SaveTaskData(this IGenericTasks operations, TaskDataSaveRequest body = default(TaskDataSaveRequest), long? xUIPATHOrganizationUnitId = default(long?))
            {
                operations.SaveTaskDataAsync(body, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Save Task data
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Tasks or OR.Tasks.Write.
            ///
            /// Required permissions: Tasks.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// TaskDataSaveRequest
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task SaveTaskDataAsync(this IGenericTasks operations, TaskDataSaveRequest body = default(TaskDataSaveRequest), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.SaveTaskDataWithHttpMessagesAsync(body, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
