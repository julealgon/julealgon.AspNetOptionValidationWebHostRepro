namespace julealgon.AspNetOptionValidationWebHostRepro.Controllers;

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[Route("[controller]")]
public sealed class SamplesController : ControllerBase
{
    [HttpGet]
    public List<string> GetSamples() => ["Sample1", "Sample2"];
}
