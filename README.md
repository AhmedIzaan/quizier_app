# QuizierApp - Desktop Quiz Application

## Overview

QuizierApp is a desktop quiz application developed using C# and Windows Forms (.NET). It provides a platform for users to take quizzes on various subjects and for administrators to manage the question bank and application settings. The application features distinct roles for regular users (students) and administrators.

## Features

### User Features
*   **Login/Sign Up:** Secure user authentication and registration.
*   **Dashboard:** A central hub for users after logging in.
*   **Start Quiz:** Users can select a subject and start a quiz session.
*   **Take Quiz:**
    *   Questions are presented one by one.
    *   Multiple-choice options (A, B, C, D) are displayed using radio buttons.
    *   Navigation between questions (`Next`/`Finish` button).
    *   (Optional) Time limit per quiz, configured by the admin.
    *   (Optional) Randomization of question order, configured by the admin.
*   **View Scores:** Users can view their past quiz results (Score, Subject, Date).

### Admin Features
*   **Admin Login:** Separate login credentials for administrators.
*   **Admin Panel Access:** Dedicated panel for administrative tasks. (Initial version might have required an Institution ID, but typically relies on the `IsAdmin` flag after login).
*   **Question Management:**
    *   **Add Questions:** Add new questions categorized by subject.
    *   **View/Update/Delete Questions:** Browse questions by subject, select a question to edit its text/options/answer, or delete it entirely using the dedicated `UpdateQuestionsForm`.
*   **Settings Management:**
    *   **Import Questions:** Import questions in bulk from a CSV file.
    *   **Export Questions:** Export the current question bank to a CSV file for backup or sharing.
    *   **Clear Data:** Option to clear all questions or all recorded scores from the application's memory (use with caution!).
    *   **Configure Quiz Rules:** Set the default time limit (in minutes) for quizzes and enable/disable question randomization.

## Technology Stack

*   **Language:** C#
*   **Framework:** .NET (Windows Forms)
*   **IDE:** Visual Studio 2022 (or compatible version)

## Prerequisites

*   **.NET Runtime:** Ensure you have a compatible .NET Desktop Runtime installed (e.g., .NET 6, 7, 8 or later, depending on the project target).
*   **Visual Studio (for Development):** Required to open, build, and modify the project.

## Setup and Installation

1.  **Clone or Download:** Get the source code onto your local machine.
2.  **Open Solution:** Open the `WinFormsApp1.sln` (or your renamed solution file) in Visual Studio.
3.  **Build:** Build the solution (Build > Build Solution or Ctrl+Shift+B). Visual Studio should automatically restore any necessary packages if applicable (though this project seems self-contained currently).
4.  **Run:** Start the application (Debug > Start Debugging or F5).

## Usage

1.  **Launch** the application.
2.  **Login / Sign Up:**
    *   Use the pre-defined test credentials:
        *   Admin: Username `admin`, Password `admin123`
        *   Student: Username `student`, Password `pass`
    *   Or, use the "Sign Up" button to create a new account.
3.  **Dashboard:** Users are directed to the main dashboard.
4.  **Admin Actions (If logged in as Admin):**
    *   Click "Admin Panel".
    *   Use the dropdown to select a subject.
    *   Click "Add Questions" to open the add form for the selected subject.
    *   Click "Update Questions" to open the form for viewing, editing, and deleting questions.
    *   Click "Settings" to manage data and quiz rules.
5.  **User Actions:**
    *   Click "Start Quiz".
    *   Select a subject from the available options.
    *   Answer the questions presented in the `QuizForm`.
    *   View results upon completion.
    *   Click "View Scores" on the dashboard to see past results.

## Data Storage

**Important:** Currently, all application data (Users, Questions, Scores) is stored in **static lists in memory** (`AppData.cs`, `LoginForm.cs`). This means **all data will be lost** when the application is closed.

This is suitable for initial development and testing but needs to be replaced with a persistent storage mechanism for a real application.

## Screenshots


**Login Form:**
![Login Form](C:\Users\ahmed\OneDrive\Desktop\screenshots\login.png)

**Dashboard :**
![Student Dashboard](C:\Users\ahmed\OneDrive\Desktop\screenshots\dashboard.jpg)

**Admin Panel:**
![Admin Panel](C:\Users\ahmed\OneDrive\Desktop\screenshots\adminPanel.jpg)

**Add/Edit Question Form:**
![Add/Edit Question Form](C:\Users\ahmed\OneDrive\Desktop\screenshots\addNewQuestion.jpg)

**Update Questions Form:**
![Update Questions Form](C:\Users\ahmed\OneDrive\Desktop\screenshots\updateQuestion.jpg)

**Quiz Form:**
![Quiz Form](C:\Users\ahmed\OneDrive\Desktop\screenshots\quizForm.jpg)

**Settings Form (Data Tab):**
![Settings Form Data](C:\Users\ahmed\OneDrive\Desktop\screenshots\adminSettings_dataManagement.jpg)

**Settings Form (Quiz Rules Tab):**
![Settings Form Quiz](C:\Users\ahmed\OneDrive\Desktop\screenshots\adminSettings_quizRules.jpg)

## Future Improvements

*   **Persistent Data Storage:** Implement saving/loading data to a database (e.g., SQLite, SQL Server Express) or files (e.g., JSON, XML) so data isn't lost on exit.
*   **Password Hashing:** Implement secure password hashing (e.g., using `System.Security.Cryptography` or a library like BCrypt.Net) instead of storing plain text passwords.
*   **Robust CSV Parsing:** Use a dedicated library (like CsvHelper) or more advanced manual parsing for importing/exporting CSV data to handle commas and quotes within fields reliably.
*   **User Management (Admin):** Allow admins to view, edit (e.g., reset password, change admin status), and delete user accounts.
*   **Detailed Score Review:** Allow users (and maybe admins) to review answers given for a specific quiz attempt.
*   **Enhanced Settings Persistence:** Save admin settings (time limit, randomization) to a persistent file.
*   **UI/UX Refinements:** Improve visual design, layout consistency, and user feedback.
*   **Error Handling:** Add more comprehensive error handling and logging.
*   **Testing:** Implement unit and integration tests.
