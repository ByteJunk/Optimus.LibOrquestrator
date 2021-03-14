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
    /// Extension methods for Users.
    /// </summary>
    public static partial class UsersExtensions
    {
            /// <summary>
            /// Gets users.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Users or OR.Users.Read.
            ///
            /// Required permissions: Users.View.
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
            public static ODataValueOfIEnumerableOfUserDto Get(this IUsers operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?))
            {
                return operations.GetAsync(expand, filter, select, orderby, top, skip, count).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets users.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Users or OR.Users.Read.
            ///
            /// Required permissions: Users.View.
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
            public static async Task<ODataValueOfIEnumerableOfUserDto> GetAsync(this IUsers operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(expand, filter, select, orderby, top, skip, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new user.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Users or OR.Users.Write.
            ///
            /// Required permissions: Users.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static UserDto Post(this IUsers operations, UserDto body = default(UserDto))
            {
                return operations.PostAsync(body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new user.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Users or OR.Users.Write.
            ///
            /// Required permissions: Users.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<UserDto> PostAsync(this IUsers operations, UserDto body = default(UserDto), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a user based on its id.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Users or OR.Users.Read.
            ///
            /// Requires authentication.
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
            public static UserDto GetById(this IUsers operations, long key, string expand = default(string), string select = default(string))
            {
                return operations.GetByIdAsync(key, expand, select).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a user based on its id.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Users or OR.Users.Read.
            ///
            /// Requires authentication.
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
            public static async Task<UserDto> GetByIdAsync(this IUsers operations, long key, string expand = default(string), string select = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(key, expand, select, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Edits a user.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Users or OR.Users.Write.
            ///
            /// Required permissions: Users.Edit or Robots.Create or Robots.Edit or
            /// Robots.Delete.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static UserDto PutById(this IUsers operations, long key, UserDto body = default(UserDto))
            {
                return operations.PutByIdAsync(key, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Edits a user.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Users or OR.Users.Write.
            ///
            /// Required permissions: Users.Edit or Robots.Create or Robots.Edit or
            /// Robots.Delete.
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
            public static async Task<UserDto> PutByIdAsync(this IUsers operations, long key, UserDto body = default(UserDto), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutByIdWithHttpMessagesAsync(key, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Partially updates a user.
            /// Cannot update roles or organization units via this endpoint.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Users or OR.Users.Write.
            ///
            /// Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static void PatchById(this IUsers operations, long key, UserDto body = default(UserDto))
            {
                operations.PatchByIdAsync(key, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Partially updates a user.
            /// Cannot update roles or organization units via this endpoint.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Users or OR.Users.Write.
            ///
            /// Requires authentication.
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
            public static async Task PatchByIdAsync(this IUsers operations, long key, UserDto body = default(UserDto), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PatchByIdWithHttpMessagesAsync(key, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Deletes a user.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Users or OR.Users.Write.
            ///
            /// Required permissions: Users.Delete.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            public static void DeleteById(this IUsers operations, long key)
            {
                operations.DeleteByIdAsync(key).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a user.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Users or OR.Users.Write.
            ///
            /// Required permissions: Users.Delete.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteByIdAsync(this IUsers operations, long key, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteByIdWithHttpMessagesAsync(key, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Changes the culture for the specified user
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Users or OR.Users.Write.
            ///
            /// Required permissions: Users.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static void ChangeUserCultureById(this IUsers operations, long key, UsersChangeUserCultureParameters body = default(UsersChangeUserCultureParameters))
            {
                operations.ChangeUserCultureByIdAsync(key, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Changes the culture for the specified user
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Users or OR.Users.Write.
            ///
            /// Required permissions: Users.Edit.
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
            public static async Task ChangeUserCultureByIdAsync(this IUsers operations, long key, UsersChangeUserCultureParameters body = default(UsersChangeUserCultureParameters), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ChangeUserCultureByIdWithHttpMessagesAsync(key, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Activate or deactivate a user
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Users or OR.Users.Write.
            ///
            /// Required permissions: Users.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static void SetActiveById(this IUsers operations, long key, UsersSetActiveParameters body = default(UsersSetActiveParameters))
            {
                operations.SetActiveByIdAsync(key, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Activate or deactivate a user
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Users or OR.Users.Write.
            ///
            /// Required permissions: Users.Edit.
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
            public static async Task SetActiveByIdAsync(this IUsers operations, long key, UsersSetActiveParameters body = default(UsersSetActiveParameters), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.SetActiveByIdWithHttpMessagesAsync(key, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Associates/dissociates the given user with/from an organization unit based
            /// on toggle parameter.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Users or OR.Users.Write.
            ///
            /// Required permissions: Users.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='body'>
            /// &lt;para /&gt;Toggle - States whether to associate or to dissociate the
            /// organization unit with/from the user.
            /// &lt;para /&gt;OrganizationUnitId - The id of the organization unit to be
            /// associated/dissociated.
            /// </param>
            public static void ToggleOrganizationUnitById(this IUsers operations, long key, UsersToggleOrganizationUnitParameters body = default(UsersToggleOrganizationUnitParameters))
            {
                operations.ToggleOrganizationUnitByIdAsync(key, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Associates/dissociates the given user with/from an organization unit based
            /// on toggle parameter.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Users or OR.Users.Write.
            ///
            /// Required permissions: Users.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='body'>
            /// &lt;para /&gt;Toggle - States whether to associate or to dissociate the
            /// organization unit with/from the user.
            /// &lt;para /&gt;OrganizationUnitId - The id of the organization unit to be
            /// associated/dissociated.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ToggleOrganizationUnitByIdAsync(this IUsers operations, long key, UsersToggleOrganizationUnitParameters body = default(UsersToggleOrganizationUnitParameters), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ToggleOrganizationUnitByIdWithHttpMessagesAsync(key, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Associates/dissociates the given user with/from a role based on toggle
            /// parameter.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Users or OR.Users.Write.
            ///
            /// Required permissions: Users.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='body'>
            /// &lt;para /&gt;Toggle - States whether to associate or to dissociate the
            /// role with/from the user.
            /// &lt;para /&gt;Role - The name of the role to be associated/dissociated.
            /// </param>
            public static void ToggleRoleById(this IUsers operations, long key, UsersToggleRoleParameters body = default(UsersToggleRoleParameters))
            {
                operations.ToggleRoleByIdAsync(key, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Associates/dissociates the given user with/from a role based on toggle
            /// parameter.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Users or OR.Users.Write.
            ///
            /// Required permissions: Users.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='body'>
            /// &lt;para /&gt;Toggle - States whether to associate or to dissociate the
            /// role with/from the user.
            /// &lt;para /&gt;Role - The name of the role to be associated/dissociated.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ToggleRoleByIdAsync(this IUsers operations, long key, UsersToggleRoleParameters body = default(UsersToggleRoleParameters), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ToggleRoleByIdWithHttpMessagesAsync(key, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Changes the culture for the current user
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Users or OR.Users.Write.
            ///
            /// Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static void ChangeCulture(this IUsers operations, UsersChangeCultureParameters body = default(UsersChangeCultureParameters))
            {
                operations.ChangeCultureAsync(body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Changes the culture for the current user
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Users or OR.Users.Write.
            ///
            /// Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ChangeCultureAsync(this IUsers operations, UsersChangeCultureParameters body = default(UsersChangeCultureParameters), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ChangeCultureWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns a user permission collection containing data about the current user
            /// and all the permissions it has.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Users or OR.Users.Read.
            ///
            /// Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            public static UserPermissionsCollection GetCurrentPermissions(this IUsers operations, string expand = default(string), string select = default(string))
            {
                return operations.GetCurrentPermissionsAsync(expand, select).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a user permission collection containing data about the current user
            /// and all the permissions it has.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Users or OR.Users.Read.
            ///
            /// Requires authentication.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
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
            public static async Task<UserPermissionsCollection> GetCurrentPermissionsAsync(this IUsers operations, string expand = default(string), string select = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCurrentPermissionsWithHttpMessagesAsync(expand, select, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns details about the user currently logged into Orchestrator.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Users or OR.Users.Read.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            public static UserDto GetCurrentUser(this IUsers operations, string expand = default(string), string select = default(string))
            {
                return operations.GetCurrentUserAsync(expand, select).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns details about the user currently logged into Orchestrator.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Users or OR.Users.Read.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
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
            public static async Task<UserDto> GetCurrentUserAsync(this IUsers operations, string expand = default(string), string select = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCurrentUserWithHttpMessagesAsync(expand, select, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Imports from AD all users from the given group and associates them with
            /// given roles.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Users or OR.Users.Write.
            ///
            /// Required permissions: Users.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// &lt;para /&gt;Group - The name of the AD group whose users are to be
            /// imported.
            /// &lt;para /&gt;RolesList - The collection of roles the imported users will
            /// be associated with.
            /// &lt;para /&gt;OrganizationUnitIds - The collection of ids of the
            /// organization units the imported users will be associated with.
            /// </param>
            public static void ImportUsers(this IUsers operations, UsersImportUsersParameters body = default(UsersImportUsersParameters))
            {
                operations.ImportUsersAsync(body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Imports from AD all users from the given group and associates them with
            /// given roles.
            /// </summary>
            /// <remarks>
            /// OAuth required scopes: OR.Users or OR.Users.Write.
            ///
            /// Required permissions: Users.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// &lt;para /&gt;Group - The name of the AD group whose users are to be
            /// imported.
            /// &lt;para /&gt;RolesList - The collection of roles the imported users will
            /// be associated with.
            /// &lt;para /&gt;OrganizationUnitIds - The collection of ids of the
            /// organization units the imported users will be associated with.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ImportUsersAsync(this IUsers operations, UsersImportUsersParameters body = default(UsersImportUsersParameters), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ImportUsersWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}