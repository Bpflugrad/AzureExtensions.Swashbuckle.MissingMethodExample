# AzureExtensions.Swashbuckle.MissingMethodExample
Example of the System.MissingMethodException occurring when Microsoft.EntityFrameworkCore.Sqlite is present.

## Purpose
Provide an minimal reproduction of the `System.MissingMethodException` being experienced in my Function Apps.

## Exception
It appears that there is a conflict between `Microsoft.EntityFrameworkCore.Sqlite` and `Swashbuckle.AspNetCore`.
