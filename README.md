# SSOExample
Single Sign On example in ASP.NET MVC, created with VS2017 and the default authentication system integrated in ASP.NET project with the individual user accounts authentication.

This example uses two projects, Project A is the one where the authentication is handled, Project B it´s configured in the web.config file to use the authentication from Project A.

Once the user is authenticated (either through Project A or Project B) he can navigate between these two projects without the need to authenticate each time by project. Also, when the user logs out, he will be logged out from both web applications.
