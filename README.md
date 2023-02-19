# Git-Analytic
An application that gives you information about pull requests and commits in a Github or Azure DevOps repository with using GraphQL and REST API’s.

<img src="https://i.imgur.com/kUN1Qps.jpg" width="600" height="500">

## Getting Personal Access Tokens
You need Personal Acces Tokens for reading repository information. 

### Github
In Github, You can create one from the Settings>Developer settings>Personal access tokens page.  
Application only needs the “repo” scope.

<img src="https://i.imgur.com/NvykC6w.jpg" width="270" height="160">  <img src="https://i.imgur.com/1nvGYbm.jpg" width="270" height="150">

<img src="https://i.imgur.com/DVDi7Wz.jpg" width="530" height="250">

### Azure DevOps
In Azure DevOps, you can create one from the User Settings page.  
While creating this PAT, you should select the “Read” and “Status” permission in the “Code” scope. 

<img src="https://i.imgur.com/akDnX11.jpg" width="230" height="350">

<img src="https://i.imgur.com/xSWgIY4.jpg" width="550" height="100">

## Configuring the Application
With PAT, application also needs user or organization name and if you want to use it with Azure DevOps, project name too.  
We store this information at appsettings.json file.  
If you want to use the application with Github profile or organization, you should enter “1” for “isGithubRepo” value.  
For understanding that is it a user or organization account, application also needs “isUserRepo” value.  
Because when requesting repositories from the GraphQL API, we must use different queries for user and organization profiles.  

![a](https://i.imgur.com/pWrdxWG.jpg)

## How Application Works

Github queries are cURL’s converted from JSON query strings with escaped double quotes and curly braces.  
The below one is a REST API URL for Azure DevOps. 

![a](https://i.imgur.com/cYGJVBr.jpg)

You can find or create queries with using APIs documentations.  

With Http Client, we send a request that includes the selected query and headers to the API and then deserialize the json response with to a Model.  

![a](https://i.imgur.com/R9zhwh0.jpg)

Application uses two different Models, one for GraphQL response and the other one for REST.  
With using models, it prints information about selected repository’s pull requests and top 10 user with the most commits, for now 😊 

Here are some useful links:  

https://docs.github.com/en/graphql  

https://graphql-dotnet.github.io/docs/getting-started/introduction

https://docs.microsoft.com/en-us/rest/api/azure/devops/git/?view=azure-devops-rest-6.0

https://www.dotnetperls.com/common-elements-list

https://app.quicktype.io/


