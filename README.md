# Miunie

[![Build status](https://ci.appveyor.com/api/projects/status/cpaukw10ih35jl69?svg=true)](https://ci.appveyor.com/project/discord-bot-tutorial/miunie) [![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/discord-bot-tutorial/Miunie/blob/master/LICENSE)

<p align="center">
    <img src="https://cdn.discordapp.com/attachments/530332932158783488/531892114041208863/MiunieThumb.png">
</p>

## Miunie is a community developed Disord bot

You might be familiar with Community-Bot, which is a previous version of this project. This greenfield version aims to improve architecture.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See [deployment](#deployment) for notes on how to deploy the project on a live system.

## Prerequisites

- Your favorite IDE/Code Edior
  - [Visual Studio Community 2017](https://www.visualstudio.com/thank-you-downloading-visual-studio/?sku=Community&rel=15) - Ensure you have `.NET Core cross-platform development` installed.
  - [Visual Studio Code](https://code.visualstudio.com/) - Ensure you have the extension: [C# For Visual Studio Code - Omnisharp](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp)
- The GIT CLI
  - [Git Command Line Interface (CLI)](https://git-scm.com/downloads)
  - This is going to be used to both setup and deploy the project.
- Dotnet Core
  - [.NET Core 2.2 SDK](https://dotnet.microsoft.com/download/dotnet-core/2.2)
  - Sometimes Dotnet Core 2.2 wont install by default. Use the above link to download then install it.

## Installing

This is a step by step guide to get Miunie ready on your machine and ready for development.

### Getting the source

1. [Fork The Original Repository](https://help.github.com/articles/fork-a-repo/)
2. Navigate to your fork.
3. [Clone](https://help.github.com/articles/cloning-a-repository/) your fork to your local machine.

### Setting up the environment - Visual Studio IDE

- The root directory of the project contains Miunie.sln, this is a Visual Studio solution file and you can open it with Visual Studio (See [Prerequisites](#Prerequisites))
- Once Visual Studio is open, you should try build the project.
  - Either use the shortcut `F6` or goto `Build` > `Build Solution`
- The build should complete with any erorrs. Now you can run the unit tests.
  - Either use the shortcut `CTRL+R, A` or goto `Test` > `Run` > `All Tests` [Example Output Of Tests](https://i.gyazo.com/da85fac25967d0f740cfa7c91a2fb182.png)
- **NOTE**: You can `Restore` > `Build` > `Test` via the CLI as shown below in Visual Studio Code setup below if you wish.

### Setting up the environment - Visual Studio Code

- Goto the location on your P.C where you cloned the forked repository to. [Example](https://i.gyazo.com/57b6aecdb110529c7e61cee7db5b0757.png)
- Click on the folder named `src` right click in the whitespace and click `Git Bash Here`. [Example](https://i.gyazo.com/57f3233e7ca1a488fbdef8a855a750f9.png)
- The Git Terminal should now open. Run the following commands in the this order.
  - `dotnet restore` - Restores the project dependencies & Nuget Packages.
  - `dotnet build` - Ensures your clone of the repo is complete by ensuring the bot builds. You should see the build secceeded with no warnings or errors.
  - `dotnet test` - This runs the unit tests for the project. You should see an completed output stating the all tests passed.
- Now we know the project was forked and cloned correctly, you can type `code .` to open Visual Studio Code in that directory and get started on your project.

## Running Tests

To run the unit tests already inclduded in the project folow the directions that are relevent to you.

- Visual Studio IDE
  - Either use the shortcut `CTRL+R, A` or goto `Test` > `Run` > `All Tests` [Example Output Of Tests](https://i.gyazo.com/da85fac25967d0f740cfa7c91a2fb182.png)
- Visual Studio Code
  - `dotnet test` - From the terminal.

## Deployment - TODO

## Built With

- [.Net Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2) - Platformed Used
- [DsharpPlus](https://github.com/DSharpPlus/DSharpPlus) - Discord API wrapper library
- ❤️ Love and Care 💙

## Contributing

Please read [CONTRIBUTING.md](TODO) for details on our code of conduct, and the process for submitting pull requests to us.

## Versioning

There is currently no versioning system used. Feel free to create a new Issue suggesting one.

## Authors

- Petr Sedláček - Initial work - [PetrSpelos](https://github.com/petrspelos)

See also the list of [contributors](https://github.com/discord-bot-tutorial/Miunie/graphs/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE](https://github.com/discord-bot-tutorial/Miunie/blob/master/LICENSE) file for details

## Acknowledgments

- Thank you to all people who contributed, especially those coming from my Discord-BOT-Tutorial Discord Server.
- If you're still not sure about the way to contribute, there's a [simple tutorial](https://www.youtube.com/watch?v=85s_-i4hHbM) video I made.