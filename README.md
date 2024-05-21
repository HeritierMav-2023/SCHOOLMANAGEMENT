CLEAN ARCHITECTURE WITH CQRS ASP NET CORE 8

1- ARCHITECTURE
	  -Core
    -Infrastructure
    -Presentation
    -Shared

Next, create the following two class library projects in the Core solution folder.
   -Domain
   -Application
Next, create the following two class library projects in the Infrastructure folder
   -Infrastructure
Finally, create the following ASP.NET 7.0 Web API project in the Presentation folder
      -WebAPI

2-PACKAGE

 A)Domain project needs the following nuget packages
   ->MediatR (12.0.1)
 
 B)Application project needs the following nuget packages
 ->MediatR (12.0.1)
 ->Microsoft.EntityFrameworkCore (8.0.0)
 ->AutoMapper (12.0.1)
 ->AutoMapper.Extensions.Microsoft.DependencyInjection (12.0.1)
 ->FluentValidation (11.5.2)
 ->FluentValidation.AspNetCore (11.3.0)

C)Persistence project needs the following nuget packages
 ->MediatR (12.0.1)
 ->Microsoft.EntityFrameworkCore (8.0.0)
 ->Microsoft.EntityFrameworkCore.SqlServer (8.0.0)
 ->Microsoft.EntityFrameworkCore.Tools (8.0.0)
 ->Microsoft.EntityFrameworkCore.Design (8.0.0)
 ->Microsoft.Extensions.Configuration (7.0.0)

D)WebAPI project needs the following nuget packages
->MediatR (12.0.1)
->Microsoft.EntityFrameworkCore.Design (8.0.0)

