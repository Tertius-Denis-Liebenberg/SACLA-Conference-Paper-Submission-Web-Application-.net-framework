# SACLA Conference Paper Submission Web Application

Welcome to the SACLA Conference Paper Submission web application project developed using ASP.NET MVC5, SQL Server, and Azure. This application facilitates the submission and management of research papers for the annual SACLA conference.

## Project Overview

### Background Information

You have been contracted by the Southern African Computer Lecturers Association (SACLA) to develop a basic web application for managing the submission of research papers for their annual conference. The initial version of the application supports two user roles: Author and Admin.

### Basic Pages and Functionalities

The application includes the following basic pages and functionalities:

- **Home Page**: Landing page for the web application.
- **Papers Page**: Displays a list of all papers submitted for the conference.
- **News Page**: Provides news updates about the conference (to be designed creatively by the students).
- **Contact Page**: Allows users to contact SACLA (to be designed creatively by the students).
- **Login Page**: Allows users to log in to the application.

#### Functionalities:

- **Navigation Bar**: Fully functional navigation bar that displays links and information based on the authorization level of the user.
- **Paper Submission**: Authenticated users belonging to the Author role can submit new papers, view their submitted papers, edit submitted papers, and delete submitted papers.
- **Authentication**: Login and logout functionalities.

## Technologies Used

- **Visual Studio 2017/2019**: IDE used for development.
- **ASP.NET MVC5**: Framework for building the web application.
- **SQL Server**: Database management system for storing paper and topic information.
- **Azure**: Cloud platform used for deployment.
- **Bootstrap CSS**: Used for setting the presentation aspects of the web application.

## Models

### Paper Model

- **PaperId**: Auto-generated number.
- **PaperTitle**: Title of the paper.
- **PaperAbstract**: Short summary of the paper.
- **PaperAuthor**: Username of the user who submitted the paper.
- **PaperDateSubmitted**: Date on which the paper was first submitted.
- **TopicId**: An indication of the Topic to which the paper belongs.

### Topic Model

- **TopicId**: Auto-generated number.
- **TopicName**: String value representing the topic name.

## Deployment

The web application was deployed to Azure.

## Author

**Tertius Denis Liebenberg**  

For any questions or feedback, please contact [tertiusliebenberg7@gmail.com].