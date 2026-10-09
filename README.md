# A1_Plan_it_Build_it
Assignment 1 in CPRO 2501, Software Design and Development

Darren Hamilton and Travis Stahl

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