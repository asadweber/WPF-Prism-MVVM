using Microsoft.AspNetCore.Mvc;

namespace Web.Core.Frame.Serialization
{
  public sealed class JsonContentResult : ContentResult
  {
    public JsonContentResult()
    {
      ContentType = "application/json";
    }
  }
}
