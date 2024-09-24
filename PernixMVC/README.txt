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


5. Bootswatch Theme and Bootstrap Icons
		- -> https://bootswatch.com/ select theme > download css > paste in
		> wwwroot > lib > bootstrap > dist > css > bootstrap.css file
		
		- -> https://icons.getbootstrap.com/ copy cdn link and paste in '_Layout'

6. toastr Notifications
	- -> https://github.com/CodeSeven/toastr
	- Paste CDN Minified links in '_Layout' (js.cdn) + (css.cdn)
	- Add TempData to Controller
	- Add script in '_Notification' shared folder

7. ViewBag
	- ViewBag is a way to pass data from a controller to a view in ASP.NET MVC
	- It’s like a container: It allows you to send information to the view without
	having to create a complex model.

8. Scaffold Identity
	- User Management: Handles creation, updating, and deletion of user accounts.
	- Authentication: Provides login and logout functionality, including support for external providers (Google, Facebook, etc.).
	- Authorization: Manages roles and claims to control access to resources.
	- Password Management: Supports password hashing, validation, reset, and recovery features.
	- Security: Implements features like two-factor authentication (2FA) and account lockout to enhance security.
    - Data Storage: Utilizes Entity Framework to store user-related data in a database (SQL by default).




/////////////////////////////////////////////////////////////////////////////////
THIRD PARTY PLUGINS - CDN + Integrations
/////////////////////////////////////////////////////////////////////////////////
1.	Toastr (notifications) -> https://github.com/CodeSeven/toastr
2.	TinyMCE (pre-built text editor) -> https://www.tiny.cloud/
3.	DataTables (DataTable library JS-HTML) -> https://datatables.net/
4.	Sweet Alerts (Popup box library) -> https://sweetalert2.github.io/
5. Stripe (Payment integration) -> https://dashboard.stripe.com/test



/////////////////////////////////////////////////////////////////////////////////
ASP.NET IDENTITY - Login / Registration / Authenticaton / Password Hashing / Validation
/////////////////////////////////////////////////////////////////////////////////