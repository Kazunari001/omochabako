$RG = "ititarg";
$Location = "japaneast";
$TemplateFile = ".\azuredeploy.json";

New-AzResourceGroup -Name $RG -Location $Location -Force
New-AzResourceGroupDeployment -ResourceGroupName $RG -TemplateFile $TemplateFile -Force
