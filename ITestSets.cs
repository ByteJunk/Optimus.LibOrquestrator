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
    /// TestSets operations.
    /// </summary>
    public partial interface ITestSets
    {
        /// <summary>
        /// Returns a list of Test Sets cross-folder when no current folder is
        /// sent by header.
        /// It will return Test Sets from folder where current user has
        /// TestSetsView.
        /// If there is none, will return forbidden.
        /// </summary>
        /// <remarks>
        /// OAuth required scopes: OR.TestSets or OR.TestSets.Read.
        ///
        /// Required permissions: TestSets.View.
        ///
        /// Responses:
        /// 200 Returns a list of Test Sets filtered with queryOptions
        /// 403 If the caller doesn't have permissions to view Test Sets
        /// </remarks>
        /// <param name='mandatoryPermissions'>
        /// </param>
        /// <param name='atLeastOnePermissions'>
        /// </param>
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
        Task<HttpOperationResponse<ODataValueOfIEnumerableOfTestSetDto>> GetWithHttpMessagesAsync(IList<string> mandatoryPermissions = default(IList<string>), IList<string> atLeastOnePermissions = default(IList<string>), string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a new Test Set
        /// </summary>
        /// <remarks>
        /// OAuth required scopes: OR.TestSets or OR.TestSets.Write.
        ///
        /// Required permissions: TestSets.Create.
        ///
        /// Responses:
        /// 201 Returns the newly created Test Set
        /// 403 If the caller doesn't have permissions to create Test Sets
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
        Task<HttpOperationResponse<TestSetDto>> PostWithHttpMessagesAsync(TestSetDto body = default(TestSetDto), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Return a specific Test Set identified by key
        /// </summary>
        /// <remarks>
        /// OAuth required scopes: OR.TestSets or OR.TestSets.Read.
        ///
        /// Required permissions: TestSets.View.
        ///
        /// Responses:
        /// 200 Return a specific Test Set identified by key
        /// 403 If the caller doesn't have permissions to view Test Sets
        /// 404 If the Test Set is not found
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
        Task<HttpOperationResponse<TestSetDto>> GetByIdWithHttpMessagesAsync(long key, string expand = default(string), string select = default(string), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update an existing Test Set
        /// </summary>
        /// <remarks>
        /// OAuth required scopes: OR.TestSets or OR.TestSets.Write.
        ///
        /// Required permissions: TestSets.Edit.
        ///
        /// Responses:
        /// 200 Returns the updated Test Set
        /// 403 If the caller doesn't have permissions to update Test Sets
        /// </remarks>
        /// <param name='key'>
        /// ID of the Test Set to be updated
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
        Task<HttpOperationResponse<TestSetDto>> PutByIdWithHttpMessagesAsync(long key, TestSetDto body = default(TestSetDto), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete a test set
        /// </summary>
        /// <remarks>
        /// OAuth required scopes: OR.TestSets or OR.TestSets.Write.
        ///
        /// Required permissions: TestSets.Delete.
        ///
        /// Responses:
        /// 204 The Test Set was deleted
        /// 403 If the caller doesn't have permissions to delete Test Sets
        /// </remarks>
        /// <param name='key'>
        /// ID of the Test Set to delete
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
    }
}
