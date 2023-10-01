# ストレージコンテナに格納されているファイルにSASを付与する
$RG = "ititarg";

# ストレージアカウント名を設定
$storageAccountName = "ititargstorage";

# ストレージアカウントのキーを取得
$storageAccountKey = (Get-AzStorageAccountKey -ResourceGroupName $RG -Name $storageAccountName).Value[0]

# ストレージアカウントのコンテキストを作成
$ctx = New-AzStorageContext -StorageAccountName $storageAccountName -StorageAccountKey $storageAccountKey

# コンテナ名を設定
$containerName = "images"
$BlobName = "sample.png";

# SASの有効期限を設定
$expiry = (Get-Date).AddMinutes(5);

# SASの権限を設定
$permissions = "r"

# SASを生成
$sas = New-AzStorageBlobSASToken `
        -Container $containerName `
        -Blob $BlobName `
        -Permission $permissions `
        -ExpiryTime $expiry `
        -Context $ctx `
        -FullUri

# SASを出力
Write-Output $sas
