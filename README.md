# aaas.net
Addition As A Service, for .NET Core

## Deployment

`az login`

`az webapp up --sku F1 --name <app-name> --os-type linux`

Note: `<app-name>` must be unique across Azure.

Note: If you require hosting the AAAS.NET service in a specific region due to regulatory constraints, add `location <location-name`. Run `az account list-locations` to see a list of allowable regions for your Azure account.