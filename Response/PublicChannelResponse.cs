using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GatecoinServiceInterface.Model;
namespace GatecoinServiceInterface.Response{
public class PublicChannelResponse : CommonResponse
{
public Dictionary<System.String,System.String> Data {get; set; } 
}
}

