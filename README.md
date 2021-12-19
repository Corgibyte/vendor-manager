## Corgibyte Vendor Manager

![Screenshot of Running Website](/Screenshot.png)

By Hannah Young

A simple web application to manage orders from vendors.

### Technologies Used

- C#
- .NET
- ASP.NET Core MVC
- MSTEST

### Description

This is a web application that showcases my ability to develop a robust ASP.NET Core MVC backend. 

### Setup

#### To Run Web Application

1. Download and install the [.NET 5.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/5.0) as required for your system. Be sure to add the .NET sdk to your PATH
2. Use terminal to navigate to desired parent directory and use `git clone https://github.com/Corgibyte/vendor-manager.git VendorManager.Solution`
3. Navigate into the project directory nested inside the .Solution directory: `cd VendorManager.Solution/VendorManager`
4. Build project: `dotnet restore`
5. Run project: `dotnet run`
6. Use browser to navigate to `localhost:5000`

#### To Run Tests

1. Follow steps 1 and 2 from **To Run Web Application** above if not done already
2. Use terminal to navigate into the test folder nested inside the .Solution directory `cd VendorManager.Solution/VendorManager.Tests`
3. Build tests: `dotnet restore`
4. Run tests: `dotnet test`

### Known bugs:

None at current time

### Future goals:

1. Combine with Corgibte Bakery to allow order of specific bakery items
2. Add order status
3. Allow deletion of specific vendors and/or orders
4. Phone number validation

### License

[Hippocratic License 2.1](https://github.com/Corgibyte/vendor-manager/blob/main/LICENSE.md), Copyright 2021 Hannah Young.
