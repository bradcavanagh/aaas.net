# aaas.net
Addition As A Service, for .NET Core

This service is inspired by the [Python-based AAAS](https://github.com/WeMakeServices/AAAS). I made the decision to provide a .NET Core solution because Python isn't quite as enterprise-grade as C# is, obviously. This service can also be easily deployed to Azure, making it even more enterprise-grade.

.NET Core AAAS can be found at https://aaas-dotnet.azurewebsites.net/

## Usage

`https://aaas-dotnet.azurewebsites.net/api/{x}/{y}`

`x` must be an integer between 0 and 9, inclusive.

`y` must be an integer between 0 and 9, inclusive.

## Deployment

`az login`

`az webapp up --sku F1 --name <app-name> --os-type linux`

Note: `<app-name>` must be unique across Azure.

Note: I already have `aaas-dotnet` so don't try to take it.

Note: If you are required to host the AAAS.NET service in a specific region due to regulatory constraints, add `location <location-name>`. Run `az account list-locations` to see a list of allowable regions for your Azure account.

## Future Work

1. Bring in Terraform configuration to configure the App Service Plan and App Service, while also bringing in an Azure Virtual Network for security, and Azure Front Door to provide even more scaling and security. Doing this will enable Standard and Premium tier App Service Plans, as Free and Basic tier plans cannot be placed within a VNet. Enabling Standard and Premium tier App Service Plans will allow for horizontal autoscaling, allowing for greater throughput, and the rate limiting could then be loosened up to two requests per day.

1. Containerize the deployment by using Docker, as all enterprise-grade solutions use containers.

1. Examine Azure Kubernetes Service or Service Mesh because that's what enterprise-grade solutions use as well.

1. Consider implementing "add two strings" together functionality, as the Python AAAS does. As an example, you should be able to hit the `/add/one/two` endpoint and get back `3` as your answer. To implement this, the obvious route is to create a "string-to-integer" microservice.

Pull requests implementing the above will be considered.