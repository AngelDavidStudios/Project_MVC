var builder = DistributedApplication.CreateBuilder(args);

// Api projects
var apiHeroes = builder.AddProject<Projects.MyHero_API>("myhero-api");

// Frontend projects
builder.AddNpmApp("vue", "../MyHero-UI")
    .WithReference(apiHeroes)
    .WithHttpEndpoint(env: "PORT")
    .WithExternalHttpEndpoints()
    .PublishAsDockerFile();

builder.Build().Run();