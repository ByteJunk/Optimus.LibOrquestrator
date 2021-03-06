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
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// TestAutomation operations.
    /// </summary>
    public partial interface ITestAutomation
    {
        /// <summary>
        /// Cancels the specified test case execution.
        /// </summary>
        /// <remarks>
        /// OAuth required scopes: OR.TestSetExecutions or
        /// OR.TestSetExecutions.Write.
        ///
        /// Required permissions: TestSetExecutions.Edit.
        ///
        /// Responses:
        /// 202 Accepted
        /// 403 If the caller doesn't have permissions to cancel a test set
        /// execution
        /// </remarks>
        /// <param name='testCaseExecutionId'>
        /// Id for the test case execution to be canceled
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
        Task<HttpOperationResponse> CancelTestCaseExecutionWithHttpMessagesAsync(long? testCaseExecutionId = default(long?), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Cancels the specified test set execution.
        /// </summary>
        /// <remarks>
        /// OAuth required scopes: OR.TestSetExecutions or
        /// OR.TestSetExecutions.Write.
        ///
        /// Required permissions: TestSetExecutions.Edit.
        ///
        /// Responses:
        /// 202 Accepted
        /// 403 If the caller doesn't have permissions to cancel a test set
        /// execution
        /// </remarks>
        /// <param name='testSetExecutionId'>
        /// Id for the test set execution to be canceled
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
        Task<HttpOperationResponse> CancelTestSetExecutionWithHttpMessagesAsync(long? testSetExecutionId = default(long?), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// This will create a test set with source type API.This endpoint it
        /// is supposed to be used by API integration.
        /// </summary>
        /// <remarks>
        /// OAuth required scopes: OR.TestSets or OR.TestSets.Write.
        ///
        /// Required permissions: TestSets.Create.
        ///
        /// Responses:
        /// 201 Created returns test set Id
        /// 403 If the caller doesn't have permissions to create a test set
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
        Task<HttpOperationResponse<long?>> CreateTestSetForReleaseVersionWithHttpMessagesAsync(BuildTestSetRequestMessage body = default(BuildTestSetRequestMessage), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the screenshot for the specified test case assertion.
        /// </summary>
        /// <remarks>
        /// OAuth required scopes: OR.TestSetExecutions or
        /// OR.TestSetExecutions.Read.
        ///
        /// Required permissions: TestSetExecutions.View.
        ///
        /// Responses:
        /// 200 OK
        /// 404 If the test case assertion is not found or the screenshot
        /// storage location is not found
        /// </remarks>
        /// <param name='testCaseAssertionId'>
        /// Id of the test case assertion
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
        Task<HttpOperationResponse<Stream>> GetAssertionScreenshotWithHttpMessagesAsync(long? testCaseAssertionId = default(long?), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the screenshot for the specified test case assertion.
        /// </summary>
        /// <remarks>
        /// OAuth required scopes: OR.TestSetExecutions or
        /// OR.TestSetExecutions.Write.
        ///
        /// Required permissions: TestSetExecutions.View.
        ///
        /// Responses:
        /// 200 OK
        /// 404 If the test case assertion is not found or the screenshot
        /// storage location is not found
        /// </remarks>
        /// <param name='testCaseAssertionId'>
        /// Id of the test case assertion
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
        Task<HttpOperationResponse<Stream>> GetAssertionScreenshot1WithHttpMessagesAsync(long? testCaseAssertionId = default(long?), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the package identifier and the latest version for the specified
        /// test case.
        /// </summary>
        /// <remarks>
        /// OAuth required scopes: OR.Execution or OR.Execution.Read.
        ///
        /// Requires authentication.
        ///
        /// Responses:
        /// 200 OK
        /// 403 If the caller doesn't have permissions to retrieve packages
        /// 404 If there is no test case with the specified UniqueId
        /// </remarks>
        /// <param name='testCaseUniqueId'>
        /// </param>
        /// <param name='packageIdentifier'>
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
        Task<HttpOperationResponse<TestPackageInfoDto>> GetPackageInfoByTestCaseUniqueIdWithHttpMessagesAsync(System.Guid? testCaseUniqueId = default(System.Guid?), string packageIdentifier = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// This will list all the processes filtered by package identifier and
        /// version cross-folder when no current folder is sent by header.
        /// </summary>
        /// <remarks>
        /// OAuth required scopes: OR.Execution or OR.Execution.Read.
        ///
        /// Required permissions: Processes.View.
        ///
        /// Responses:
        /// 200 OK
        /// 404 If there is no release for the specified package identifier
        /// </remarks>
        /// <param name='packageIdentifier'>
        /// </param>
        /// <param name='version'>
        /// </param>
        /// <param name='mandatoryPermissions'>
        /// If in a cross-folder scenario, these represent the additional
        /// permissions
        /// required in the folders the data is retrieved from; all permissions
        /// in this set must be met
        /// </param>
        /// <param name='atLeastOnePermissions'>
        /// If in a cross-folder scenario, these represent the additional
        /// permissions
        /// required in the folders the data is retrieved from; at least one
        /// permission in this set must be met
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
        Task<HttpOperationResponse<IList<TestReleaseVersionDto>>> GetReleasesForPackageVersionWithHttpMessagesAsync(string packageIdentifier = default(string), string version = default(string), IList<string> mandatoryPermissions = default(IList<string>), IList<string> atLeastOnePermissions = default(IList<string>), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Start a test set execution.
        /// </summary>
        /// <remarks>
        /// OAuth required scopes: OR.TestSetExecutions or
        /// OR.TestSetExecutions.Write.
        ///
        /// Required permissions: TestSetExecutions.Create.
        ///
        /// Responses:
        /// 200 OK returns test set execution Id
        /// 403 If the caller doesn't have permissions to execute a test set
        /// 404 If the test set was not found
        /// </remarks>
        /// <param name='testSetId'>
        /// The Id of the test set
        /// </param>
        /// <param name='triggerType'>
        /// Specifies how was the execution triggered. Possible values include:
        /// 'Manual', 'Scheduled', 'ExternalTool'
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
        Task<HttpOperationResponse<long?>> StartTestSetExecutionWithHttpMessagesAsync(long? testSetId = default(long?), ExecutionTriggerType? triggerType = default(ExecutionTriggerType?), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Start a test set execution with additional options.
        /// </summary>
        /// <remarks>
        /// OAuth required scopes: OR.TestSetExecutions or
        /// OR.TestSetExecutions.Write.
        ///
        /// Required permissions: TestSetExecutions.Create.
        ///
        /// Responses:
        /// 200 OK returns test set execution Id
        /// 403 If the caller doesn't have permissions to execute a test set
        /// 404 If the test set was not found
        /// </remarks>
        /// <param name='body'>
        /// Provides options to set the BatchExecutionKey and TriggerType and
        /// override the input parameters for specific test cases
        /// </param>
        /// <param name='testSetId'>
        /// The Id of the test set
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
        Task<HttpOperationResponse<long?>> StartTestSetExecutionWithOptionsWithHttpMessagesAsync(TestSetExecutionOptionsDto body = default(TestSetExecutionOptionsDto), long? testSetId = default(long?), long? xUIPATHOrganizationUnitId = default(long?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
