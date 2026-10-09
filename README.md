# A1_Plan_it_Build_it
Assignment 1 in CPRO 2501, Software Design and Development

Darren Hamilton and Travis Stahl

Purpose:

Sleep Tracker is an app that lets the users record their sleep to understand it. It allows the user to record their habits, sleep, and other information that may affect the user's sleep quality. The app is also designed to protect the user’s personal information from third parties. As user data is encrypted and will not be sent to third parties.

Requirements:

FR - 01 - Sleep Log

Records:

- Bedtime
- Waketime
- Total hours slept
- Sleep quality rated from 1 to 10


FR - 02 - Habit Log

Records:

- Last time caffeine was taken
- Last time the user ate
- Last time the user exercised
- Wake-up time
- When user takes Medication
- Sleep disturbances

FR - 03 - Alarm

The user will be able to:

- Set an alarm
- Edit an alarm
- Delete an Alarm

An automatic smart alarm will be added that sets itself (can be turned off by user).

FR - 04 - Sleep Calculator

The calculator will:

- Calculate average sleep hours
- Use the user’s record sleep hours to give sleep recommendations
- Identify habits that may affect sleep
- Recommend getting more or less sleep based on the user’s average

Future Features:

Some features may not be added to the app.

Features Include:

- Wristband or watch sleep monitoring
- Movement tracking during sleep
- Smart Alarm
- Automatic sleep data collection
- More personalized sleep recommendation

The wristband will have to be made by a third party as we have no engineering experiences. The current project is focused on the software application without the real time monitoring.


Security and Privacy:

The apps security:

- Encrypts user information
- Does not send user data to third parties
- Protects personal sleep data
- Avoids storing passwords and other personal information in Github

The app's future hardware must also avoid sharing user sleep data with third parties.

Methodology:

We chose Agile for the project as the feedback we receive from users will allow us to make improvements to the app. This will allow us to make updates regularly to fix bugs and improve the app.

Team Collaboration:

We check in with each other daily over Discord or meeting in person in class.

How the word was divided:

Travis Stahl/Eventually88: FR - 01 and FR - 01
Darren Hamilton/Darren_Hamilton: FR - 03 and FR - 04



Git WorkFlow:

We used branches so that we could slip up the work and then combine it later.

Example:

Main branch - FR - 03 and FR - 04
Eventually88-patch-1

We made changes to our own branches and then Travis merged his branch into Darrens as his is the main branch.

Deployment:

We choose Blue/Green deployment. The Blue is our current version while the Green is the version that contains new updates.

When an update is made:

Create a branch
Make the changes that are needed
Test the changes
Save the changes
Merge the branch into main
Deploy the new version to Green
Test the Green version
If everything works properly then Green become the live version 
If there are any problems we return to Blue version

Merge Conflict:

Commit to Green brack from blue to back up and create new features over our existing branch.

Documentation on Merge conflicts:
	1. On creation, Darren created a readme and a blank repository, then created a new project and attempted to upload. This created a conflict because the repository
	on the local branch did not contain the readme file commit from the remote branch. This was resolved by forcing a merge through the bash console, then unlinking and 
	relinking the repositories. This unlinking had to be done as the visual studio IDE was reading the branches wrong and committing to the repository on github, and pushing
	to the local repository. Relinking the repository properly resolved the issue.

	2. A merge conflict was created when Travis drag and dropped files onto the git hub when Darren had unpushed commits in his repository. The fix to this was simple
	and required a simple merge through Git >> Commit or Stash and the IDE easily fixed the conflict by merging the two files. A few lines of code were deleted from the 
	local repository in favor of the code from the remote hub on git/hub.

Blue/Green: 
	1. We created a seperate repository to function as our Green environment, while the Main one became our Blue environment. A slight problem arose as the Green environment
	was initially our active one, and was effectively blank, which caused pulling it to wipe out our local repository. Pulling from the Blue repository fixed it, and we pushed
	our local repositories to the new Green environment. 

Updating the App:

Bug fixes and new features will be added through branches such as feature/sleep-history. We make the changes on that branch then test them, and then merge the branch into the main branch. The update would also be deployed using the Blue/Green deployment process.

The 6 SDLC Stages:

Planning And Requirements Analysis:
We would use a questionnaire to interview prospective customers about what some of the features they would like to see in a sleep tracker app would be, and then determine if those features would be within the scope of our app. Then we would focus on what core features we need based on that user feedback and our ability to provide them, creating a time-line for the completion of our app in the process.

Design:
Create a conceptual UI for the app. Write the pseudocode for the sleep logic and based on the app needs and the logic we have written, choose the appropriate language to code the app in.

Implementation
For the implementation phase we will code the user interface for the customer to enter their sleep and behavior details, the logic around determining what they need to improve, as well as a database for holding their data. We will also code a settable alarm that they can use to wake themselves.
Testing:
We will be testing the app's security features to ensure the safety of users' personal information. The app's features will also be tested to make sure that they work correctly and that all calculations done by the app are correct and the recommendations given by the app are helpful.

Deployment:
The finished app will be released for users to download but the user will need to pay a fee or monthly subscription to use it.
Maintenance:  
We will provide regular updates which would ensure that everyone’s app works with future updates, fix bugs, and provide new QOL features for user preferences that may change over time. Because we are working with potential sensitive information, we need to provide regular security upgrades as well. We will use a crash log and user feedback to assist us.

SRS Cards:

Requirement ID:          FR-01
Requirement Name:        Record Sleep log
User/Actor:              User
Requirement Statement:   The system allows the user to enter their bedtime, waketime, total hours sleeped, and sleep quality rated from 1-10
Priority:                Must Have
Acceptance Criteria:     When the user enters valid bedtime, waketime, and sleep quality information and they save the sleep log the system will then store the information and display the                           saved sleep record.
Related SDLC Stages:     Requirements Analysis, later verified through testing

