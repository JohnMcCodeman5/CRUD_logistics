# CRUD_logistics (work in progress)


A GUI CRUD app (built using C#, .NET and Entity Framework) designed to connect to a remote or local server hosting databases using database logins, allowing the users the modify data as they please (or as their DB right allow) using forms and other user-friendly means.

Opening the app you are met with a login screen asking for DB credentials, the database and the table you need access to.

From there, a menu with options to list, add, update or remove data is given. Each option opens an appropriate form and table to select entries.

Users modify the DB by filling these forms and clicking a button to save changes and commit transactions.

You can switch between different databases and tables on the server, and you will gain contol if your login has access to that data.

It's much simpler and faster to use and understand than writing regular SQL, especially when working with large amounts of data and if the end user is not an SQL programmer.

Instead of triggers and procedures on the database itself, the app takes care of data consistency and implements needed restrictions, no need to worry about that.

There is also an SQL script you can run to create what is needed to test the app.

# FUTURE PLANS:
In the future I plan on implementing more features, working on the UI, but most importantly the idea is to create a module which would detect data upon establishing server connection and automatically generate corresponding data models and forms, making the app universally usable with any relational SQL DB.
