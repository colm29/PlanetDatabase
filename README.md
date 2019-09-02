# Planetdatabase.com

This project uses the default MVC template in Visual Studio 2019 and adds an API controller called PlanetController which is consumed by the main application upon running the application.  This data is then displayed showing each planet and its distance to the sun.

The program runs locally on https://localhost:44391 and the api can be accessed on https://localhost:44391/api/Planet

The *HomeController.cs* controller contains the code that calls the api.  The api is contained in the *PlanetController.cs* which in turn uses the service *DataService.cs* which creates a list of planets.  These are hardcoded for the sake of simplicity to demo the project rather than connecting to a database using a relational mapper like Entity Framework.

To initiate the *DataService.cs* a line is added to the *Startup.cs* code in the *ConfigureServices* method:

````cs
services.AddTransient<IDataService, DataService>();
````
