﻿using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Api.Status;

public class Api : ControllerBase
{
    // GET /status
    [HttpGet("/status")]
    public async Task<ActionResult> GetTheStatusAsync()
    {
        var response = new GetStatusResponse("Looks Good Here!", DateTimeOffset.UtcNow);
        return Ok(response); // 
    }
}

public record GetStatusResponse(string Message, DateTimeOffset LastChecked);