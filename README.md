afunc
====================

### Deploying from PowerShell

First, copy `azureDeploy.json` locally (or clone the repo), then run something like this:

    New-AzureRmResourceGroup -Name RG01 -Location eastus -Force
    New-AzureRmResourceGroupDeployment -ResourceGroupName RG01 -TemplateFile azureDeploy.json -siteName FunSite001 -repoUrl "https://github.com/he3/afunc" -Force
