# Cedita Web App Base Template

This Template contains 5 base projects to bootstrap any new web application, with default logging configuration, data project, test projects, and coding rulesets/stylecop all preconfigured.

> **WARNING**: This might crash your VS on first load of the solution. This is tracked by Issue #1 and relates to lack of .ruleset or stylecop.json being created in the root solution directory.

To install the template:

1. Download the `CeditaWebAppTemplate.zip` file.
2. Place the .zip file in `%userprofile%\Documents\Visual Studio 2017\Templates\Project Templates\Cedita`.

You will find the template when creating a new solution, under the `Visual C# -> Cedita` section.

Create your project as the Product Name, and .Data/.Tests/.Web projects will be created off that.

## Project Intentions

`HelloWorld` is used as the project name in the below samples.

### HelloWorld
Application services project containing all of your domain logic.

### HelloWorld.Data
Data project with EF Core 3 and Identity wired up.

### HelloWorld.Tests
Test project for `HelloWorld`.

### HelloWorld.Web
Web project for the solution, should be set as Startup project.

### HelloWorld.Web.Tests
Web Test Project for `HelloWorld.Web` to test controllers etc.