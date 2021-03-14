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
    /// TestSetSchedules operations.
    /// </summary>
    public partial interface ITestSetSchedules
    {
        /// <summary>
        /// Returns a list of test set execution schedules
        /// </summary>
        /// <remarks>
        /// OAuth required scopes: OR.TestSetSchedules or
        /// OR.TestSetSchedules.Read.
        ///
        /// Required permissions: TestSetSchedules.View.
        ///
        /// Responses:
        /// 200 Returns a list of test set execution schedules filtered with
        /// queryOptions
        /// 403 If the caller doesn't have permissions to view test set
        /// execution schedules
        /// </remarks>
        /// <param name='expand'>
        /// Indicates the related entities to be represented inline. The
        /// maximum depth is 2.
        /// </param>
        /// <param name='filter'>
        /// Restricts the set of items returned. The maximum number of
        /// expressions is 100.
        /// </param>
        /// <param name='select'>
        /// Limits the properties returned in the result.
        /// </param>
        /// <param name='orderby'>
        /// Specifies the order in which items are returned. The maximum number
        /// of expressions is 5.
        /// </param>
        /// <param name='top'>
        /// Limits the number of items returned from a collection. The maximum
        /// value is 1000.
        /// </param>
        /// <param name='skip'>
        /// Excludes the specified number of items of the queried collection
        /// from the result.
        /// </param>
        /// <param name='count'>
        /// Indicates whether the total count of items within a collection are
        /// returned in the result.
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
        Task<HttpOperationResponse<ODataValueOfIEnumerableOfTestSetScheduleDto>> GetWithHttpMessagesAsync(string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a new test set execution schedule
        /// </summary>
        /// <remarks>
        /// OAuth required scopes: OR.TestSetSchedules or
        /// OR.TestSetSchedules.Write.
        ///
        /// Required permissions: TestSetSchedules.Create.
        ///
        /// Responses:
        /// 201 Returns the newly created test set execution schedule
        /// 403 If the caller doesn't have permissions to create test set
        /// execution schedules
        /// </remarks>
        /// <param name='body'>
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
        Task<HttpOperationResponse<TestSetScheduleDto>> PostWithHttpMessagesAsync(TestSetScheduleDto body = default(TestSetScheduleDto), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Return a specific test set execution schedule identified by key
        /// </summary>
        /// <remarks>
        /// OAuth required scopes: OR.TestSetSchedules or
        /// OR.TestSetSchedules.Read.
        ///
        /// Required permissions: TestSetSchedules.View.
        ///
        /// Responses:
        /// 200 Return a specific test set execution schedule identified by key
        /// 403 If the caller doesn't have permissions to view test set
        /// execution schedules
        /// 404 It the test set execution schedule is not found
        /// </remarks>
        /// <param name='key'>
        /// </param>
        /// <param name='expand'>
        /// Indicates the related entities to be represented inline. The
        /// maximum depth is 2.
        /// </param>
        /// <param name='select'>
        /// Limits the properties returned in the result.
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
        Task<HttpOperationResponse<TestSetScheduleDto>> GetByIdWithHttpMessagesAsync(long key, string expand = default(string), string select = default(string), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update an existing test set execution schedule
        /// </summary>
        /// <remarks>
        /// OAuth required scopes: OR.TestSetSchedules or
        /// OR.TestSetSchedules.Write.
        ///
        /// Required permissions: TestSetSchedules.Edit.
        ///
        /// Responses:
        /// 201 Returns the updated test set execution schedule
        /// 403 If the caller doesn't have permissions to update test set
        /// execution schedules
        /// </remarks>
        /// <param name='key'>
        /// ID of the test set execution schedule to be updated
        /// </param>
        /// <param name='body'>
        /// Update information
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
        Task<HttpOperationResponse<TestSetScheduleDto>> PutByIdWithHttpMessagesAsync(long key, TestSetScheduleDto body = default(TestSetScheduleDto), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete an existing test set execution schedule
        /// </summary>
        /// <remarks>
        /// OAuth required scopes: OR.TestSetSchedules or
        /// OR.TestSetSchedules.Write.
        ///
        /// Required permissions: TestSetSchedules.Delete.
        ///
        /// Responses:
        /// 204 The test set execution schedule was deleted
        /// 403 If the caller doesn't have permissions to delete test set
        /// execution schedules
        /// </remarks>
        /// <param name='key'>
        /// ID of the test set execution schedule to be deleted
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
        Task<HttpOperationResponse> DeleteByIdWithHttpMessagesAsync(long key, long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Enables / disables a list of test set execution schedules.
        /// </summary>
        /// <remarks>
        /// OAuth required scopes: OR.TestSetSchedules or
        /// OR.TestSetSchedules.Write.
        ///
        /// Required permissions: TestSetSchedules.Edit.
        /// </remarks>
        /// <param name='body'>
        /// &lt;para /&gt;enabled: if true the test set schedules will be
        /// enabled, if false they will be disabled.
        /// &lt;para /&gt;scheduleIds: the ids of the test set schedules to be
        /// enabled or disabled.
        /// </param>
        /// <param name='expand'>
        /// Indicates the related entities to be represented inline. The
        /// maximum depth is 2.
        /// </param>
        /// <param name='select'>
        /// Limits the properties returned in the result.
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
        Task<HttpOperationResponse<ODataValueOfBoolean>> SetEnabledWithHttpMessagesAsync(TestSetSchedulesSetEnabledParameters body = default(TestSetSchedulesSetEnabledParameters), string expand = default(string), string select = default(string), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
