// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Optimus.LibOrquestrator
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// GenericTasks operations.
    /// </summary>
    public partial interface IGenericTasks
    {
        /// <summary>
        /// Complete the task by saving task data and action taken
        /// </summary>
        /// <remarks>
        /// OAuth required scopes: OR.Tasks or OR.Tasks.Write.
        ///
        /// Required permissions: Tasks.Edit.
        /// </remarks>
        /// <param name='body'>
        /// TaskCompletionRequest
        /// </param>
        /// <param name='xUIPATHOrganizationUnitId'>
        /// Folder/OrganizationUnit Id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse> CompleteTaskWithHttpMessagesAsync(TaskCompletionRequest body = default(TaskCompletionRequest), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a new Generic Task.
        /// </summary>
        /// <remarks>
        /// OAuth required scopes: OR.Tasks or OR.Tasks.Write.
        ///
        /// Required permissions: Tasks.Create.
        /// </remarks>
        /// <param name='body'>
        /// The task to be created.
        /// </param>
        /// <param name='xUIPATHOrganizationUnitId'>
        /// Folder/OrganizationUnit Id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<TaskDataDto>> CreateTaskWithHttpMessagesAsync(TaskCreateRequest body = default(TaskCreateRequest), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns task data dto
        /// </summary>
        /// <remarks>
        /// OAuth required scopes: OR.Tasks or OR.Tasks.Read.
        ///
        /// Required permissions: Tasks.View.
        /// </remarks>
        /// <param name='taskId'>
        /// Task id
        /// </param>
        /// <param name='xUIPATHOrganizationUnitId'>
        /// Folder/OrganizationUnit Id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<TaskDataDto>> GetTaskDataByIdWithHttpMessagesAsync(long? taskId = default(long?), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Save changes done by the current user and Reassign Task to another
        /// user
        /// </summary>
        /// <remarks>
        /// OAuth required scopes: OR.Tasks or OR.Tasks.Write.
        ///
        /// Required permissions: Tasks.Edit.
        /// </remarks>
        /// <param name='body'>
        /// TaskSaveAndReassignmentRequest
        /// </param>
        /// <param name='xUIPATHOrganizationUnitId'>
        /// Folder/OrganizationUnit Id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse> SaveAndReassignTaskWithHttpMessagesAsync(TaskSaveAndReassignmentRequest body = default(TaskSaveAndReassignmentRequest), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Save Task data
        /// </summary>
        /// <remarks>
        /// OAuth required scopes: OR.Tasks or OR.Tasks.Write.
        ///
        /// Required permissions: Tasks.Edit.
        /// </remarks>
        /// <param name='body'>
        /// TaskDataSaveRequest
        /// </param>
        /// <param name='xUIPATHOrganizationUnitId'>
        /// Folder/OrganizationUnit Id
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse> SaveTaskDataWithHttpMessagesAsync(TaskDataSaveRequest body = default(TaskDataSaveRequest), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}