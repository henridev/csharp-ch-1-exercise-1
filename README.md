# Chapter 1 - Exercise 1
##  Objectives
- Learn how to create a decent project structure
- Learn how to create a decent GIT repository
- Learn how to create a console application
- Learn how to link a `Class Library`

## Exercise
- Create the following folder structure
  - ch-1-exercise-1
    - src
- Use a `dotnet` command to create a new console application in the `src` folder called `App`
- Use a `dotnet` command to create a `.gitignore` file in the root folder `ch-1-exercise-1`
- Use a `git` command to make the root folder `ch-1-exercise-1` a GIT repository
- Use a `git` command or VS Code to commit your changes
  - Make sure there are no binary files tracked in the repository.
- Use a `dotnet` command to create a `class library` in the `src` folder called `Domain`
- Use a `dotnet` command to reference the `Domain` class library in the console application.
- Use a `git` command or VS Code to commit your changes
- Rename `Class1` to `Person`
- In the `Person` class, create a field called `name` of type `string` and initialize it with your own name.
- In the `Person` class create a public function called `SayHello` which prints `Hello, {yourname}`.
- In `Program.cs` use a top-level-statement to create a new Person object called `you` and use the function `SayHello` to print the name to the screen.
- Use a `dotnet` command to run the application.
- Use a `git` command or VS Code to commit your changes

## Solution
- Create the following folder structure
  - ch-1-exericse-1
    - src
- Use a `dotnet` command to create a new console application in the `src` folder called `App`
  ```console
  cd src
  dotnet new console -o App
  ```
- Use a `dotnet` command to create a `.gitignore` file in the root folder `ch-1-exericse-1`
  ```console
  cd ..
  dotnet new gitignore
  ```
- Use a `git` command to make the root folder `ch-1-exericse-1` a GIT repository
  ```console
  git init
  ```
- Use a `git` command or VS Code to commit your changes
  - Make sure there are no binary files tracked in the repository.
  ```console
  git add .
  git commit -m "Create Console App"
  ```
- Use a `dotnet` command to create a `class library` in the `src` folder called `Domain`
  ```console
  cd src
  dotnet new classlib -o Domain
  ```
- Use a `dotnet` command to reference the `Domain` class library in the console application.
  ```console
  dotnet add App/App.csproj reference Domain/Domain.csproj
  ```
- Use a `git` command or VS Code to commit your changes
  ```console
  git add .
  git commit -m "Add Domain Classlib"
  ```
- Rename `Class1` to `Person` 
- In the `Person` class, create a field called `name` of type `string` and initialize it with your own name.
- In the `Person` class create a public function called `SayHello` which prints `Hello, {yourname}`.
  - Don't forget to rename the file aswell!
  > See [this commit](https://github.com/HOGENT-Web/csharp-ch-1-exercise-1/commit/7506a88d9ca5e4280b96a80efb6b3d4604220287)
- In `Program.cs` use a top-level-statement to create a new Person object called `you` and use the function `SayHello` to print the name to the screen.
  > See [this commit](https://github.com/HOGENT-Web/csharp-ch-1-exercise-1/commit/07b214390622321284cdf595572aa353a8cf1a9a)
- Use a `dotnet` command to run the application.
  ```console
  cd src/App
  dotnet run
  ```
- Use a `git` command or VS Code to commit your changes
  ```console
  git commit -m "Finished"
  ```
