var builder = DistributedApplication.CreateBuilder(args);

// Api projects
var apiHeroes = builder.AddProject<Projects.MyHero_API>("myhero-api");

builder.Build().Run();