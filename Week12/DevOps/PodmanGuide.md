# Podman Guide

This guide will walk you through the setup and running of a basic containerized docker project.

## Verify Installation

Podman CLI needs to be installed on your environment in order to run podman commands from the terminal. You may use Podman Desktop for your local development but during training you will have to use the terminal.

You can verify the installation of podman through any terminal, run the command:

```bash
podman
```

A list of commands available will pop-up. If it does not, and you are sure you have installed Podman CLI then try closing down the terminal and opening it up, and attempt the same command again. If that still doesn't work, restart your system and run the terminal as an administrator.

## Containerfile

The `Containerfile` is used to guide podman through the image building. We will put the `Containerfile` inside the root of the project you are attempting to containerize.

```dockerfile
# Use the official .NET SDK image as the base image
# This image contains the .NET SDK which includes tools to build, test, and publish .NET applications
FROM mcr.microsoft.com/dotnet/sdk:8.0

# Set the working directory inside the container to /app
# All subsequent commands will be executed in this directory
WORKDIR /app

# Copy all files from the current directory on the host machine to the /app directory inside the container
# This includes your source code, project files, and any other necessary files
COPY . /app

# Run the dotnet publish command to build and publish the application
# -c Release specifies that the build configuration should be set to Release
# -o ./app/publish specifies the output directory for the published application
RUN dotnet publish -c Release -o ./app/publish

# Set the entry point for the container
# This specifies the command that will be run when the container starts
# In this case, it runs the MyWebApi.dll file using the dotnet runtime
ENTRYPOINT ["dotnet", "./publish/NAME_OF_APPLICATION.dll"]

```

Remember to replace `NAME_OF_APPLICATION` with the name of your application. You can find out what this will be by running the build command yourself.

```bash
dotnet publish -c Release -o ./publish
```

Then check inside the created `/publish` directory for the name of the `.dll` file.


## Build the Image

We will then use podman to build the image. Make sure you are in the directory where the `Containerfile` has been created, then run this command.

```bash
podman build -t AppImage
```

This will create an image with the name `AppImage`, and this tag can be whatever you want it to be, just remember what you called it as we will use this image to build a container.

If this step failed, that means your `Containerfile` is not correct and you will need to check what is happening and fix it.


## Running the Container

We will now use podman, with the image, to run a container. This command can be run anywhere in the terminal.

```bash
podman run -p 8081:8080 localhost/AppImage &
```

This command will create the container based on the image you have built. It will open the port of the container `8080` and map it to your computer network port `8081`. The `&` means it is running in no-hup mode and so the terminal will still be usable even while the container is running. If you do not have this, then the container will override the terminal and you will need to create a new terminal or kill the process and continue in the same terminal.

## Shutting down a container

To shut down a container that is running, you need the id of the container.

```bash
podman ps
```

This command will list out all the containers, look for the one that matches the build image we created and remember its ID.

```bash
podman stop <ID>
```

Replace `<ID>` with the ID of the container to stop it.
