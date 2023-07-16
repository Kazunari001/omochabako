# Azure FunctionsでEntity Frameworkを使ってDB操作します
DB操作をするにあたり、本環境ではDBアクセスを、テストプロジェクトはMoqを使ってデータ操作を行うリポジトリパターンを採用しました

## 動作確認環境
* Visual Studio Code
* Windows11 Pro
* SSMS
* .Net6.0

## 開発環境構築
.\Databaseフォルダを使ってDatabase構築します
PocFuncをデバッグ実行します
PowerShellを使ってAzure Functionsにリクエストします
```powershell
Invoke-WebRequest -Uri "http://localhost:7071/api/HttpTrigger1" -Method Get
```

## 参考文献
プロジェクトを作成する際に参考にさせていただきました
* https://qiita.com/hshimo/items/1136087e1c6e5c5b0d9f
* https://learn.microsoft.com/ja-jp/azure/azure-functions/functions-dotnet-dependency-injection
* https://learn.microsoft.com/ja-jp/dotnet/architecture/modern-web-apps-azure/architectural-principles#dependency-inversion
