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
    /// Extension methods for TestSets.
    /// </summary>
    public static partial class TestSetsExtensions
    {
            /// <summary>
            /// Returns a list of Test Sets cross-folder when no current folder is sent by
            /// header.
            /// It will return Test Sets from folder where current user has TestSetsView.
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
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='mandatoryPermissions'>
            /// </param>
            /// <param name='atLeastOnePermissions'>
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
            public static ODataValueOfIEnumerableOfTestSetDto Get(this ITestSets operations, IList<string> mandatoryPermissions = default(IList<string>), IList<string> atLeastOnePermissions = default(IList<string>), string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.GetAsync(mandatoryPermissions, atLeastOnePermissions, expand, filter, select, orderby, top, skip, count, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of Test Sets cross-folder when no current folder is sent by
            /// header.
            /// It will return Test Sets from folder where current user has TestSetsView.
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
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='mandatoryPermissions'>
            /// </param>
            /// <param name='atLeastOnePermissions'>
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
            public static async Task<ODataValueOfIEnumerableOfTestSetDto> GetAsync(this ITestSets operations, IList<string> mandatoryPermissions = default(IList<string>), IList<string> atLeastOnePermissions = default(IList<string>), string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(mandatoryPermissions, atLeastOnePermissions, expand, filter, select, orderby, top, skip, count, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

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
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static TestSetDto Post(this ITestSets operations, TestSetDto body = default(TestSetDto), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.PostAsync(body, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

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
            public static async Task<TestSetDto> PostAsync(this ITestSets operations, TestSetDto body = default(TestSetDto), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(body, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

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
            public static TestSetDto GetById(this ITestSets operations, long key, string expand = default(string), string select = default(string), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.GetByIdAsync(key, expand, select, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

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
            public static async Task<TestSetDto> GetByIdAsync(this ITestSets operations, long key, string expand = default(string), string select = default(string), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(key, expand, select, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

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
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// ID of the Test Set to be updated
            /// </param>
            /// <param name='body'>
            /// Update information
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static TestSetDto PutById(this ITestSets operations, long key, TestSetDto body = default(TestSetDto), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.PutByIdAsync(key, body, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

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
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// ID of the Test Set to be updated
            /// </param>
            /// <param name='body'>
            /// Update information
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TestSetDto> PutByIdAsync(this ITestSets operations, long key, TestSetDto body = default(TestSetDto), long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutByIdWithHttpMessagesAsync(key, body, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

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
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// ID of the Test Set to delete
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static void DeleteById(this ITestSets operations, long key, long? xUIPATHOrganizationUnitId = default(long?))
            {
                operations.DeleteByIdAsync(key, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

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
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// ID of the Test Set to delete
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteByIdAsync(this ITestSets operations, long key, long? xUIPATHOrganizationUnitId = default(long?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteByIdWithHttpMessagesAsync(key, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
