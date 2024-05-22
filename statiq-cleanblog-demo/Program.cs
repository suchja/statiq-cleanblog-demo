return await Bootstrapper
  .Factory
  .CreateWeb(args)
  .DeployToGitHubPages(
        "suchja",
        "statiq-cleanblog-demo",
        Config.FromSetting<string>("GITHUB_TOKEN")
    ).RunAsync();
  