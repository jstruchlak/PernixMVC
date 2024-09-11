1. .NET Framework is like the car engine, Entity Framework is the GPS that helps you navigate
   your database more easily without getting into complex mechanics (SQL queries)

2. -.NET Framework is the platform you use to build apps (mainly on Windows).

   - Entity Framework is a tool that helps you interact with databases easily, 
	 and it works with the .NET Framework or the newer versions like .NET Core/.NET 6, 7, etc.

3. - ASP.NET (the older version) was built on the .NET Framework and only worked on Windows.

   - ASP.NETCORE is a modern, fast, and cross-platform framework,
     it can run on Windows, macOS, Linux - is much faster and more modular.


4. Create db (feature-2/setup-applicationDbContext)
		- Tools > Nuget Package Manager > Package Manager Console > run 'update-database'
   Add Tables to db
		- Data > ApplicationDbContext > Add -> public DbSet<Category> Categories  { get; set; } etc
		- Tools > Nuget Package Manager > Package Manager Console > run 'add-migration AddCategoryTableToDb'
		- run 'update-database' again and check db