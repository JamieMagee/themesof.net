using Octokit.Webhooks;

namespace ThemesOfDotNet.Services;

public sealed class GitHubEventProcessingService : WebhookEventProcessor
{
    private readonly WorkspaceService _workspaceService;

    public GitHubEventProcessingService(WorkspaceService workspaceService)
    {
        _workspaceService = workspaceService;
    }

    public override Task ProcessWebhookAsync(WebhookHeaders headers, WebhookEvent webhookEvent)
    {
        _workspaceService.UpdateGitHub(headers, webhookEvent);
        return Task.CompletedTask;
    }
}
