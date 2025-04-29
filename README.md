Star Wars SPA - Web Application:

This project is a single-page web application (SPA) built using .NET, Blazor, and the Star Wars API (SWAPI). 
It organizes and presents data from the Star Wars universe, such as films, characters, and starships. 
The app allows users to search, view detailed information, and navigate between related resources 
(e.g., characters in films, starships piloted by characters).


1. Project Overview:
    - The goal of this project was to build an interactive web application that:
    - Displays data from the Star Wars API.
    - Provides search functionality for multiple resource types (e.g., characters, starships, films).
    - Enables users to explore related resources via intuitive navigation (e.g., films where characters appear, starships piloted by characters).
    - Designed as a single-page application (SPA) using Blazor.

2. Technologies Used:
    - .NET (C#): Backend framework for the application.
    - Blazor: A web framework for building interactive web UIs using C#.
    - Star Wars API (SWAPI): Provides data about the Star Wars universe.
    - HTML/CSS: For structuring and styling the web pages.
    - Bootstrap: For responsive design and UI components.

3. Installation & Prerequisites:
    - .NET SDK: Ensure you have the .NET SDK (version 6.0 or higher) installed on your machine.
    - Download and install from here - https://dotnet.microsoft.com/en-us/download/dotnet/8.0
    - Blazor WebAssembly: Blazor is part of the .NET SDK. You don’t need to install it separately.
    - Text Editor/IDE: Use a text editor or IDE of your choice:
    - Visual Studio (preferred for Blazor development) or Visual Studio Code with the C# extension.

4. How to Run the Project:
    Step 1: Copy the Project Files
        - Copy the project files to a folder on your new machine.

    Step 2: Open Command Prompt
        - Open the Command Prompt on Windows.

    Step 3: Navigate to Project Directory
        - Use the cd command to navigate to the folder where the project files are located.
        - cd path/to/your/project

    Step 4: Restore the Dependencies
        - Run the following command to restore the dependencies 
        - dotnet restore

    Step 5: Build the Project
        - After restoring the dependencies, you need to build the project:
        - dotnet build -warnaserror:false

    Step 6: Run the Project
        - Once the build is complete, run the application using this command:
        - dotnet run

    The application will start running and you should see output like this:
        info: Microsoft.Hosting.Lifetime[14]
            Now listening on: http://localhost:5227
        info: Microsoft.Hosting.Lifetime[0]
            Application started. Press Ctrl+C to shut down.
        info: Microsoft.Hosting.Lifetime[0]
            Hosting environment: Development
        info: Microsoft.Hosting.Lifetime[0]


    Step 7: Open the Application in Your Browser
        - Open your web browser and go to the following URL: http://localhost:5227



How to Explore the Webpage:
Once the application is running, you can explore the following features:

1. Home Page:
    - The homepage gives an overview of the Star Wars universe with links to characters, starships, and films.

2. Characters Page:
    - Search: Search for characters by name.
    - Character List: Display a list of characters with basic information (e.g., name, gender, birth year).
    - View Details: Click the "View Details" button to navigate to detailed character information (e.g., films, homeworld, species).

3. Starships Page:
    - Search: Search for starships by name.
    - Starship List: Display a list of starships with basic information (e.g., name, model, manufacturer).
    - View Details: Click the "View Details" button to navigate to detailed starship information (e.g., pilots, starship class, films).

4. Films Page:
    - Film List: Shows a list of Star Wars films.
    - Film Details: Click on a film to view its details (e.g., title, director, producer, opening crawl).
    - Related Data: View characters, starships, species, and vehicles featured in the film.


Features Implemented:
    1. Data Fetching: The app fetches data from the Star Wars API (SWAPI) to populate the list of characters, starships, and films.

    2. Search Functionality: Users can search for characters, starships, and films by name. The search filters the displayed results in real-time.

    3. Navigation: The app uses Blazor routing to navigate between pages and view detailed information about resources.

    4. Related Data Linking: The app links related resources (e.g., characters that appear in a specific film or starships piloted by characters).

Resources:
Star Wars API (SWAPI): https://swapi.dev/
Blazor Documentation: https://docs.microsoft.com/en-us/aspnet/core/blazor
.NET Documentation: https://docs.microsoft.com/en-us/dotnet/

Conclusion:
This Star Wars SPA allows users to explore data from the Star Wars universe in a clean and interactive interface. By leveraging .NET, Blazor, and SWAPI, the application makes it easy to search, navigate, and view detailed information about characters, starships, and films.