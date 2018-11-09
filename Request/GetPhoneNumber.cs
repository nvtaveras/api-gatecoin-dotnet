using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack;

using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Account/Phone", "GET", Summary = @"Get user phone number", Notes = @"")]
public class GetPhoneNumber : IReturn<PhoneNumberResponse>
{
}
}

