var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Personal_Web_ApiService>("apiservice");

builder.AddProject<Projects.Personal_Web_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
