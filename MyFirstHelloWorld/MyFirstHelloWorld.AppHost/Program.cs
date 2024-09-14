var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.MyFirstHelloWorld_ApiService>("apiservice");

builder.AddProject<Projects.MyFirstHelloWorld_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
