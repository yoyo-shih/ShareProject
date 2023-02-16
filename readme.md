# 這是week 3的新知分享，請 Readme

# 主題 ： .NET6 開發實戰篇
> ### .NET Console 專案
> ### .NET Web App 專案
> ### .NET NUGET 安裝
> ### 甚麼是SignalR
> ### 實戰訓練

<hr>

## 安裝.net sdk
[下載網址](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)


## 新增一個Cnsole專案
> 新增一個資料夾
<br/>
<code>$ md MyConsole</code> 
<br/>

> 進入該資料夾
<br/>
<code>$ cd MyConsole </code> 
<br/>

> 新建一個.net的console專案
<br/>
<code>$ dotnet new console</code> 
<br/>

## 新增一個Web App專案

> 新增一個資料夾
<br/>
<code>$ md WebApp</code>
<br/>

> 進入該資料夾
<br/>
<code>$ cd WebApp </code> 
<br/>

> 新建一個.net的Web專案
<br/>
<code>$ dotnet new webapp</code> 
<br/>

<hr>

## 加入方案檔

> 新增一個方案檔(.sln)
<br/>
<code>$ dotnet new sln </code> 
<br/>

> 查看.sln檔底下有哪些project
<br/>
<code>$ dotnet sln list </code> 
<br/>

> 將.csproj加入.sln檔中
<br/>
<code>$ dotnet sln add .\MyConsole\MyConsole.csproj  </code> 
<br/>
<code>$ dotnet sln add .\WebApp\WebApp.csproj  </code> 
<br/>

## 加入.gitignore
> <code>$ dotnet new gitignore </code> 
<br/>

## 建置與執行

> 建置專案
<br/>
<code>$ dotnet build </code> 
<br/>
<code>$ dotnet build .\WebApp\WebApp.csproj </code>
<br/>
<code>$ dotnet build .\MyConsole\MyConsole.csproj </code>
<br/>

> 執行專案
<br/>
<code>$ dotnet run </code> 
<br/>
<code>$ dotnet run --project .\WebApp\WebApp.csproj </code>
<br/>
<code>$ dotnet run --project .\MyConsole\MyConsole.csproj </code>
<br/>



## 新增NUGET套件
> 在WebApp新增專案
<br/>
<code>$ dotnet add package Microsoft.Azure.SignalR --version 1.21.0 </code> 



