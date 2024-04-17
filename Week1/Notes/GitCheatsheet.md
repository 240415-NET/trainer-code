# Git Cheatsheet

## Intro

This document serves as a non-exhaustive cheat sheet for git commands and workflows. This document will be updated with things as we encounter them during training.

## Cloning a Github Repository

In order to work with code from a Github (or Azure DevOps, Gitlab, Bitbucket, etc) repository on our local machine, we must first clone the repo. To do this, we can use the ```git clone``` command. For example, to clone the trainer-code repository (where this file currently lives) we would run the following command:

```bash
git clone https://github.com/240415-NET/trainer-code.git
```

When you run this command, several things will happen.

1. It creates a folder to hold the repo we are cloning. In this case, it will be named ```trainer-code```. There are options we can use to change this behavior, please see the official git documentation for more details :wink:.
2. It downloads the files contained within the remote repository, in this case hosted on Github, into that folder.
3. It creates a special hidden folder (hint: we can see it with an ```ls -a```!) named ```.git```. The presence of this ```.git``` folder is what designates the folder it resides in as a git repository. This folder also contains the entire commit history of the repository, again unless we explicitly use options to avoid doing so.

### Cloning Considerations

We want to make sure that we keep things clean. Avoid creating a mess, and be smart about where you run your commands and which options you use. The same way we want to keep our code clean, we want to make sure we keep our filesystems clean. This makes it easier to work on larger applications.

**Under no circumstances do we ever want to clone/create a git repo inside of another existing repo. The CLI will yell at you.**
