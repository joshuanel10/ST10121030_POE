In order to run the following application, the following steps must be followed:


Database:

1.	In SQL Server Management Studio right click Databases on left pane (Object Explorer)
2.	Click Restore Database
3.	Choose Device, click the “…” icon and add the farmersDB.bak file
4.	Click OK, then OK again

Visual Studio:

1.	Open the following pages:
a.	AdminLogin.aspx.cs
b.	AdminDashboard.aspx.cs
c.	FarmerLogin.aspx.cs
d.	FarmerDashboard.aspx.cs
2.	Use ctrl+f to fine the following lines of code:
a.	SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6EI4NPC\SQLEXPRESS01;Initial Catalog=farmersDB; Integrated Security=True");
3.	Find your own server’s name in SQL Server Management Studio:
a.	Right click the server’s name in the left pane (Object Explorer) – it will be the topmost item.
b.	Click on Properties
c.	Copy the value under name.
4.	Replace the value after Data Source= with your server’s name 
5.	The new Connection string should like this:
a.	SqlConnection con = new SqlConnection(@"Data Source=(your server name);Initial Catalog=farmersDB; Integrated Security=True");
b.	Put your server’s name in the brackets and then remove the brackets
6.	Close all windows and run the web application.

