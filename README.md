<div align="center">

# Dr.Sillystringz's Factory

</div>

<div align="center">
<img src="https://github.com/agatakolohe.png" width="200px" height="auto" >
</div>
<h3 align="center">Many-To-Many Relationships Database Web Application  Independent Project for Epicodus, 01-08-2021</h3>
<h4 align="center"> By Agata Kolodziej</h4>

## Description

Tenth independent project for Epicodus to demonstrate my understanding of C#, CRUD methods, creating an MVC web application using a many-to-many database relationship with MySQL, MySQL Workbench and Entity. This application will track "Dr. Sillystringz's" (user) machine repairs. It will manage their engineers and their licenses to repair certain machines. There is a many-to-many relationship between Engineer and Machine. An Engineer can be licensed to repair many machines and a machine can have many engineers licensed to repair it.

## User Stories

<details>
  <summary>Expand User Stories</summary>

- As the factory manager, I need to be able to see a list of all engineers, and I need to be able to see a list of all machines.
- As the factory manager, I need to be able to select an engineer, see their details, and see a list of all machines that engineer is licensed to repair. I also need to be able to select a machine, see its details, and see a list of all engineers licensed to repair it.
- As the factory manager, I need to add new engineers to our system when they are hired. I also need to add new machines to our system when they are installed.
- As the factory manager, I should be able to add new machines even if no engineers are employed. I should also be able to add new engineers even if no machines are installed.
- As the factory manager, I need to be able to add or remove machines that a specific engineer is licensed to repair. I also need to be able to modify this relationship from the other side, and add or remove engineers from a specific machine.
- I should be able to navigate to a splash page that lists all engineers and machines. Users should be able to click on an individual engineer or machine to see all the engineers/machines that belong to it.

</details>

## Setup/Installation Requirements

##### Software Requirements

1. Internet browser
2. A code editor such as VSCode to view and edit the code
3. .NET or follow along with the Installing .NET instructions to install .NET

##### Open Locally

- Click on the link to my repository: [My Repository](https://github.com/agatakolohe/SillystringzFactory.Solution.git)
- Click on the green "Code" button and copy the repository URL
- Open your terminal and use the command `git clone https://github.com/agatakolohe/SillystringzFactory.Solution.git` into the directory you would like to clone the repository
- Open in text editor to view code and make changes

##### Installing .NET

In order to run the application, please install .NET for your computer to recognize the `dotnet` command.

1. Download [.NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer). Clicking this link will prompt a file download for your particular OS from Microsoft.
2. Open the file. Follow the installation steps.
3. Confirm the installation is successful by opening your terminal and running the command `dotnet --version`. The response should be something similar to this:`2.2.105`. This means it was successfully installed.

##### Installing MySQL

MySQL is a type of database software used to create, edit, query, and manage SQL data.

- For Mac Users please [Click Here](https://dev.mysql.com/downloads/file/?id=484914) to download MySQL Installer
- For Windows Users please [Click Here](https://dev.mysql.com/downloads/file/?id=484919)

- Verify MySQL installation by opening the terminal and entering the command `mysql -uroot -p[THEPASSWORDYOUSELECTED]`
- If you gain access you will see see the MYSQL command line!

##### Installing MySQL Workbench

- Please [Click Here](https://dev.mysql.com/downloads/workbench/) to install the correct version for your machine
- Open MySQL Workbench and select `Local instance 3306 server`. You will need to enter the password you selected

##### Compiling

- Navigate to the `Factory` folder in the command line
- Use the command `dotnet build` to compile

##### Installing Packages

- Navigate to the `Factory` folder in the command line
- Use the command `dotnet restore`

<details>

  <summary>Expand for Database Installation Essentials!</summary>

#### Database Connection

Create a connection string to connect the database to the web application

1. Create a file in the root directory called `appsettings.json`
2. Add the code below:

```
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=agata_kolodziej_factory;uid=root;pwd=YourPassword;"
    }
}
```

- Put in your MySQL password in `pwd=YourPassword`. Change the server, port, and uid if necessary.

### Import Database Using Entity Framework Core

1. Navigate to `Factory` directory in terminal
2. Use the command `dotnet ef database update` to generate the database through Entity Framework Core

### Update Database Using Entity Framework Core

1. Write any new code you wish to add to the database. Use the command `dotnet build` to check for any compiling errors. If there are errors please fix. If no errors, proceed to step 2.
2. To update the database with any changes made to the code, use the command `dotnet ef migrations add [MigrationsName]`
3. Use the command `dotnet ef database update` to update the database

### Update Database Using MySQL Workbench

1. Open MySQL Workbench
2. Click on Server > Data Import in the top navigation bar
3. Select `Import from Self-Contained File`
4. Select the `Default Target Schema` or create new schema
5. Select all Schema Objects you would like to import
6. Select `Dump Structure and Data`
7. Click `Start Import`

</details>

##### View In Browser

- To view in browser, navigate to `Factory` folder in the command line
- Use the command `dotnet run` to execute the compiled code and start a localhost
- In browser navigate to http://localhost:5000
- Enjoy the application!

## Known Bugs

If you decide to change the styling of the application and you do not see your updated styles in the browser, please open a new Incognito Window in your browser and you should be able to see your updated styles. The browser caches styles and therefore may not show changes.

## Support and Contact Details

If any errors or bugs occur with installation, delete both bin and obj folders and follow the Compiling and Installing Packages instructions again. Get help or report a bug you have found in the .NET platform at [.NET Support](https://dotnet.microsoft.com/platform/support). Or please email me, <agatakolohe@gmail.com>.

## Technologies Used

- .NET Core 2.2.0
- ASP.NET Core MVC
- ASP.NET Core Razor Pages
- Bootstrap
- C# 7.3
- CSS
- Entity Framework Core
- GitHub
- HTML
- MySQL
- MySQL Workbench
- [Unsplash](https://unsplash.com/)
- VS Code

### License

This software is licensed under the [MIT License](https://choosealicense.com/licenses/mit/).

Copyright (c) 2021 Agata Kolodziej <img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR8Q_3EVY7j95tTyemJwWxMR7jwvUK7gPe0_w&usqp=CAU" width="2%" height="auto">
