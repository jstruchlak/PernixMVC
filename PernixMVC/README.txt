1.	.NET Framework is the engine for building apps (mainly on Windows).

2.	Entity Framework is like the GPS that helps you navigate your database easily.

3.	ASP.NET Core is the modern, cross-platform version that works everywhere, while ASP.NET (the older version) only works on Windows.

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
THIRD PARTY PLUGINS - CDN - INTERGRATIONS - DEPLOYMENT
/////////////////////////////////////////////////////////////////////////////////
1.	Toastr (notifications) -> https://github.com/CodeSeven/toastr
2.	TinyMCE (pre-built text editor) -> https://www.tiny.cloud/
3.	DataTables (DataTable library JS-HTML) -> https://datatables.net/
4.	Sweet Alerts (Popup box library) -> https://sweetalert2.github.io/
5.  Stripe (Payment integration) -> https://dashboard.stripe.com/test
6.  Bootstrap (Icons & Themes) -> https://icons.getbootstrap.com/ + https://bootswatch.com/
7.	Facebook Login -> https://developers.facebook.com/ ( My Apps > Create App > Other > Consumer > App name: > Facebook Login Setup > WWW )
8.	SendGrid (send emails in the project) -> https://sendgrid.com/en-us (business domain name preffered e.g. info@pernixmvc.com)
	a.Verify domain > Settings > API Keys > Create Name > Full Access > Create & View > Paste in appsettings.json ("SecretKey")
9.	Azure (Deployments) 
		a.	Azure Portal -> https://portal.azure.com/#home:
			Home > SQL database > '+ Create' > Subscription > Resource Group > Create new > [PernixMVC-RG] > Database name > [PernixMVC] > Server > Create new > [PernixMVC.database.windows.net] > Authentication method > 
			Use SQL authentication > Server admin login > [sqladmin] > Password > [password] > 'OK' > SQL elastic pool > 'no' > Environment > 'Development' > Select Plan > 'Review & Create'
		b.	Home > [PernixMVC - database] > Set server firewall > pubic access > Select 'Selected networks' > '+ Add your client IPv4 address' > Exceptions > TICK THE BOX 'Allow Azure Services and resources to access this server'
		c.	Home > [PernixMVC - database] > Settings > Connection strings > Copy the connection string and paste in 'appsettings.Production.json'
		d.	Home > App Services > '+ Create Web App' > Resource Group > [PernixMVC-RG] > Instance Details > Name > [PernixMVC.database.windows.net] > Publish > 'Code' > Runtime Stack > .NET 8 >
			Operating System > 'Windows' > Next button > GitHub Actions > 'Enable' > Github Action Details > [Add Github account, repo, main/master branch] > Next button > 'Enable Public Access > Create & Deploy
		e.	Push a branch and merge for CICD to trigger a deployment ( Double check Azure > [PernixMVC SQL server] > Networking > Public Access > Exceptions > TICK THE BOX 'Allow Azure Services and resources to access this server' )
		f.	In Azure Portal > Home > Web App > [PernixMVC] > Configuration > Application Settings > New application setting > Name > [ASPNETCORE_ENVIRONMENT] > Value > [Production] > Save
		g.	Stripe Logic will have to be altered in Controllers (CartController + OrderController) from localhost to dynamic solution -> [var domain = Request.Scheme + "://" + Request.Host.Value + "/";]
		h.	Facebook Meta Developers will also need to be updated for registartion (Redirect URI from localhost to Azure Production URL)

/////////////////////////////////////////////////////////////////////////////////
ASP.NET IDENTITY - Login / Registration / Authenticaton / Password Hashing / Validation
/////////////////////////////////////////////////////////////////////////////////