# AspNetCoreRefitDemo
This project demonstrates how to use Refit library in ASP.NET Core.

To run the project you need to get an API key from [here](https://developers.themoviedb.org/3/getting-started/introduction) as the API makes an 
external API call to TMDB site.

Then update the following line in `Program.cs` class with your **API Read Access Token**:

```
var authToken = "***WRITE YOUR API READ ACCESS TOKEN HERE";
```

This project was originally developed as a demo project for the following post:

[Using Refit in .NET](https://medium.com/net-core/using-refit-in-net-0843bb199987)
