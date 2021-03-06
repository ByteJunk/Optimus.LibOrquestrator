// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Optimus.LibOrquestrator.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class BulkItemDtoOfString
    {
        /// <summary>
        /// Initializes a new instance of the BulkItemDtoOfString class.
        /// </summary>
        public BulkItemDtoOfString()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BulkItemDtoOfString class.
        /// </summary>
        /// <param name="status">Possible values include: 'Continue',
        /// 'SwitchingProtocols', 'Processing', 'EarlyHints', 'OK', 'Created',
        /// 'Accepted', 'NonAuthoritativeInformation', 'NoContent',
        /// 'ResetContent', 'PartialContent', 'MultiStatus', 'AlreadyReported',
        /// 'IMUsed', 'MultipleChoices', 'Ambiguous', 'MovedPermanently',
        /// 'Moved', 'Found', 'Redirect', 'SeeOther', 'RedirectMethod',
        /// 'NotModified', 'UseProxy', 'Unused', 'TemporaryRedirect',
        /// 'RedirectKeepVerb', 'PermanentRedirect', 'BadRequest',
        /// 'Unauthorized', 'PaymentRequired', 'Forbidden', 'NotFound',
        /// 'MethodNotAllowed', 'NotAcceptable', 'ProxyAuthenticationRequired',
        /// 'RequestTimeout', 'Conflict', 'Gone', 'LengthRequired',
        /// 'PreconditionFailed', 'RequestEntityTooLarge', 'RequestUriTooLong',
        /// 'UnsupportedMediaType', 'RequestedRangeNotSatisfiable',
        /// 'ExpectationFailed', 'MisdirectedRequest', 'UnprocessableEntity',
        /// 'Locked', 'FailedDependency', 'UpgradeRequired',
        /// 'PreconditionRequired', 'TooManyRequests',
        /// 'RequestHeaderFieldsTooLarge', 'UnavailableForLegalReasons',
        /// 'InternalServerError', 'NotImplemented', 'BadGateway',
        /// 'ServiceUnavailable', 'GatewayTimeout', 'HttpVersionNotSupported',
        /// 'VariantAlsoNegotiates', 'InsufficientStorage', 'LoopDetected',
        /// 'NotExtended', 'NetworkAuthenticationRequired'</param>
        public BulkItemDtoOfString(string key = default(string), BulkItemDto1Status? status = default(BulkItemDto1Status?), string body = default(string))
        {
            Key = key;
            Status = status;
            Body = body;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Key")]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Continue',
        /// 'SwitchingProtocols', 'Processing', 'EarlyHints', 'OK', 'Created',
        /// 'Accepted', 'NonAuthoritativeInformation', 'NoContent',
        /// 'ResetContent', 'PartialContent', 'MultiStatus', 'AlreadyReported',
        /// 'IMUsed', 'MultipleChoices', 'Ambiguous', 'MovedPermanently',
        /// 'Moved', 'Found', 'Redirect', 'SeeOther', 'RedirectMethod',
        /// 'NotModified', 'UseProxy', 'Unused', 'TemporaryRedirect',
        /// 'RedirectKeepVerb', 'PermanentRedirect', 'BadRequest',
        /// 'Unauthorized', 'PaymentRequired', 'Forbidden', 'NotFound',
        /// 'MethodNotAllowed', 'NotAcceptable', 'ProxyAuthenticationRequired',
        /// 'RequestTimeout', 'Conflict', 'Gone', 'LengthRequired',
        /// 'PreconditionFailed', 'RequestEntityTooLarge', 'RequestUriTooLong',
        /// 'UnsupportedMediaType', 'RequestedRangeNotSatisfiable',
        /// 'ExpectationFailed', 'MisdirectedRequest', 'UnprocessableEntity',
        /// 'Locked', 'FailedDependency', 'UpgradeRequired',
        /// 'PreconditionRequired', 'TooManyRequests',
        /// 'RequestHeaderFieldsTooLarge', 'UnavailableForLegalReasons',
        /// 'InternalServerError', 'NotImplemented', 'BadGateway',
        /// 'ServiceUnavailable', 'GatewayTimeout', 'HttpVersionNotSupported',
        /// 'VariantAlsoNegotiates', 'InsufficientStorage', 'LoopDetected',
        /// 'NotExtended', 'NetworkAuthenticationRequired'
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public BulkItemDto1Status? Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Body")]
        public string Body { get; set; }

    }
}
