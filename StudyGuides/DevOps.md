# DevOps

## DevOps Overview
- **Definition**:
  - DevOps is a set of practices that combines software development (Dev) and IT operations (Ops) to shorten the development lifecycle and deliver high-quality software continuously. It aims to create a culture and environment where building, testing, and releasing software can happen rapidly, frequently, and more reliably.
  
- **Goals**:
  - **Improve Deployment Frequency**: Enable more frequent software releases.
  - **Achieve Faster Time to Market**: Reduce the time it takes to deliver new features and updates to customers.
  - **Lower Failure Rate of New Releases**: Ensure new deployments are less prone to failure by using robust testing and continuous integration.
  - **Shorten Lead Time Between Fixes**: Quickly identify and fix bugs or issues, reducing the time from detection to resolution.
  - **Improve Mean Time to Recovery**: Enhance the ability to recover quickly from failures or outages, minimizing downtime.

- **Principles**:
  - **Collaboration**: Foster a culture of collaboration between development and operations teams, breaking down silos.
  - **Automation**: Automate repetitive tasks to increase efficiency and reduce human error.
  - **Continuous Improvement**: Emphasize iterative improvements to processes, tools, and practices.
  - **Customer-Centric Approach**: Focus on delivering value to the customer, incorporating their feedback continuously.

## DevOps and Agile
- **Agile Overview**:
  - Agile is an iterative approach to software development that emphasizes flexibility, collaboration, customer feedback, and small, rapid releases. Agile methodologies include Scrum, Kanban, and Lean, which prioritize adaptability and iterative progress.

- **DevOps Relationship**:
  - DevOps extends Agile principles to operations. While Agile focuses on development processes, DevOps encompasses the entire software lifecycle, including operations and infrastructure management. DevOps aims to ensure smooth, continuous delivery of software from development to production.

- **Integration**:
  - Both Agile and DevOps emphasize continuous improvement and collaboration. DevOps integrates more deeply with IT operations, ensuring faster and more reliable releases by automating the deployment pipeline and improving operational processes.

## Continuous Integration (CI)
- **Definition**:
  - Continuous Integration (CI) is the practice of merging all developers' working copies to a shared mainline several times a day. It involves automating the building and testing of code to ensure that changes integrate smoothly and any issues are detected early.

- **Benefits**:
  - **Early Detection of Issues**: CI helps in identifying integration issues early in the development process.
  - **Reduced Integration Problems**: Frequent merging and testing reduce the likelihood of significant integration problems.
  - **Improved Software Quality**: Automated testing ensures that code changes meet quality standards before being integrated.

- **Tools**:
  - Popular CI tools include Jenkins, Travis CI, CircleCI, Azure DevOps, and GitHub Actions. These tools automate the build, test, and integration processes.

- **Process**:
  - **Developers Commit Code**: Developers regularly commit code changes to a shared repository.
  - **Automated Build Triggers**: Each commit triggers an automated build process.
  - **Automated Tests Run**: Automated tests are executed to verify the integrity and functionality of the code.
  - **Feedback Provided**: Developers receive immediate feedback on the build and test results, allowing them to address any issues promptly.

## Continuous Delivery (CD)
- **Definition**:
  - Continuous Delivery (CD) is a software engineering approach where code changes are automatically prepared for a release to production. It ensures that the software can be reliably released at any time.

- **Benefits**:
  - **Deployable Code**: Ensures that the code is always in a deployable state.
  - **Reduced Deployment Risk**: Automated testing and validation reduce the risks associated with deploying new code.
  - **Faster Iterations**: Enables faster delivery of new features and updates to customers.

- **Process**:
  - CD extends CI by automatically deploying code to a staging environment and running additional tests. The pipeline might include steps for integration tests, user acceptance tests, and performance tests before the code is deemed ready for production.

## Continuous Deployment
- **Definition**:
  - Continuous Deployment automates the deployment of every code change that passes automated tests directly to production. It is the next step after Continuous Delivery, aiming for fully automated end-to-end deployment.

- **Benefits**:
  - **Eliminates Manual Deployment Steps**: Automation removes the need for manual intervention in the deployment process.
  - **Rapid Delivery of Features and Fixes**: New features and bug fixes are deployed to production as soon as they pass the tests.
  - **Maintains High Software Quality**: Automated tests ensure that only code meeting quality standards is deployed.

- **Process**:
  - Continuous Deployment extends Continuous Delivery by automating the final step of deploying the code to production. Every successful build that passes all automated tests is deployed, ensuring a seamless flow from development to production.

## Containers vs Virtual Machines (VMs)
- **Virtual Machines**:
  - Abstract physical hardware, providing a full OS for each instance.
  - Heavier, requiring more resources.
  - Slower to start and less efficient for running multiple applications.
- **Containers**:
  - Abstract the application layer, sharing the host OS kernel.
  - Lighter, using fewer resources.
  - Faster to start, making them ideal for microservices and lightweight deployments.
- **Use Cases**:
  - **Containers**: Best for microservices, stateless applications, and environments requiring rapid scaling and resource efficiency.
  - **VMs**: Suitable for applications requiring full isolation, legacy applications, and scenarios where multiple OS types need to run on the same hardware.

## Containerization
- **Definition**:
  - Containerization is the process of encapsulating an application and its dependencies into a container, ensuring that it can run consistently across different environments.
- **Benefits**:
  - **Portability**: Containers can run on any system that supports the container runtime.
  - **Consistency Across Environments**: The same container can be used in development, testing, and production environments.
  - **Efficient Resource Utilization**: Containers use system resources more efficiently than traditional VM-based approaches.
- **Tools**:
  - Popular containerization tools include Docker and Kubernetes.

## Dockerfile
- **Definition**:
  - A Dockerfile is a text document containing instructions to build a Docker image. It specifies the base image, application dependencies, and the steps to configure the environment.
- **Key Instructions**:
  - **`FROM`**: Sets the base image for subsequent instructions.
  - **`RUN`**: Executes commands in a new layer on top of the current image and commits the results.
  - **`COPY`/`ADD`**: Copies files and directories from the host filesystem into the image.
  - **`CMD`/`ENTRYPOINT`**: Specifies the command to run within the container when it starts.
- **Example**:
  ```dockerfile
  FROM node:14          # Sets the base image to Node.js 14
  WORKDIR /app          # Sets the working directory inside the container to /app
  COPY package.json .   # Copies package.json to the working directory
  RUN npm install       # Installs the dependencies specified in package.json
  COPY . .              # Copies the remaining application code to the working directory
  CMD ["npm", "start"]  # Specifies the command to start the application
  ```

## Docker Architecture
- **Components**:
  - **Docker Client**: The command-line interface (CLI) that users interact with to manage Docker containers and images.
  - **Docker Daemon**: The background service running on the host machine that manages Docker images, containers, networks, and volumes.
  - **Docker Objects**: The various entities managed by Docker, including images, containers, networks, and volumes.
- **Workflow**:
  - The Docker client sends commands (such as build, run, and stop) to the Docker daemon, which performs the requested actions. The daemon communicates with other daemons to manage Docker services.

## Docker Commands
- **Common Commands**:
  - **`docker run`**: Runs a container from an image.
  - **`docker build`**: Builds an image from a Dockerfile.
  - **`docker pull`**: Downloads an image from a registry.
  - **`docker push`**: Uploads an image to a registry.
- **Examples**:
  - **Run a container**: `docker run -d -p 80:80 nginx`
    - Runs an Nginx container in detached mode and maps port 80 on the host to port 80 in the container.
  - **Build an image**: `docker build -t myapp:latest .`
    - Builds an image from the Dockerfile in the current directory and tags it as `myapp:latest`.

## Docker Images
- **Definition**:
  - Docker images are read-only templates used to create containers. They include the application code, runtime, libraries, environment variables, and configuration files.
- **Layers**:
  - Docker images are built in layers. Each instruction in a Dockerfile creates a new layer. Layers are cached and reused to optimize the build process.
- **Registries**:
  - Docker images are stored in registries. Popular registries include DockerHub, Azure Container Registry, and Google Container Registry.

## Docker Containers
- **Definition**: Runtime instances of Docker images.
- **Lifecycle**:
  - **Create**: `docker create`
  - **Start**: `docker start`
  - **Stop**: `docker stop`
  - **Remove**: `docker rm`
- **Commands**:
  - `docker ps`: Lists running containers.
  - `docker logs <container_id>`: Fetches logs of a container.

## Docker Volumes
- **Definition**: A mechanism for persisting data generated by and used by Docker containers. Volumes are the preferred way to persist data in Docker.
- **Types**:
  - **Named Volumes**: Managed by Docker and given a name.
  - **Anonymous Volumes**: Managed by Docker but not given a name.
  - **Host Volumes**: Bind mounts a directory or file from the host filesystem into the container.
- **Commands**:
  - **Create a volume**: `docker volume create <volume_name>`
  - **List all volumes**: `docker volume ls`
  - **Attach a volume to a container**: `docker run -v <volume_name>:<container_path> <image>`

## Creating a Container
- **Process**:
  - Use `docker run` to create and start a container.
  - Specify the image, container name, and port mappings.
- **Example**:
  ```shell
  docker run -d --name mycontainer -p 8080:80 nginx
  ```

## Docker Image Configuration
- **Dockerfile Instructions**:
  - **`FROM`**: Sets the base image.
  - **`MAINTAINER`**: Adds maintainer information (deprecated in favor of `LABEL`).
  - **`RUN`**: Executes commands in a new layer.
  - **`COPY`/`ADD`**: Copies files/directories into the image.
  - **`EXPOSE`**: Specifies the port to be exposed.
  - **`CMD`/`ENTRYPOINT`**: Default command to run when the container starts.
- **Example**:
  ```dockerfile
  FROM node:14
  WORKDIR /app
  COPY package.json .
  RUN npm install
  COPY . .
  EXPOSE 8080
  CMD ["npm", "start"]
  ```

## Building an Image
- **Command**: `docker build -t <image_name>:<tag> .`
- **Process**:
  - Docker reads the Dockerfile and builds an image layer by layer.
  - Each instruction in the Dockerfile creates a new layer in the image.
- **Example**:
  ```shell
  docker build -t myapp:1.0 .
  ```

## Docker Daemon
- **Definition**: The background process that manages Docker images, containers, networks, and volumes.
- **Function**: Handles Docker API requests and performs container operations.
- **Interaction**: The Docker client communicates with the Docker daemon using REST API over UNIX sockets or a network interface.

## Managing Containers
- **Commands**:
  - **Start a container**: `docker start <container_id>`
  - **Stop a container**: `docker stop <container_id>`
  - **Restart a container**: `docker restart <container_id>`
  - **Remove a container**: `docker rm <container_id>`
- **Monitoring**:
  - **List running containers**: `docker ps`
  - **Inspect a container**: `docker inspect <container_id>`

## Docker Compose
- **Definition**: A tool for defining and running multi-container Docker applications.
- **YAML File**: Use a `docker-compose.yml` file to configure the application's services, networks, and volumes.
- **Commands**:
  - **Build, (re)create, start, and attach to containers for a service**: `docker-compose up`
  - **Stop and remove containers, networks, images, and volumes**: `docker-compose down`

## DockerHub
- **Definition**: A cloud-based registry service for storing and sharing Docker images.
- **Usage**:
  - **Upload an image to DockerHub**: `docker push <image_name>`
  - **Download an image from DockerHub**: `docker pull <image_name>`

## CICD Pipeline
- **Definition**: Automates the process of continuous integration and continuous delivery/deployment.
- **Stages**:
  - **Code**: Developers commit code to a version control system.
  - **Build**: Automated build process.
  - **Test**: Automated tests run to verify code.
  - **Deploy**: Code is deployed to production/staging environments.
- **Tools**: Jenkins, GitLab CI, Azure Pipelines, GitHub Actions.

## GitHub Actions
- **Definition**: A CI/CD platform integrated with GitHub.
- **Features**: Automates workflows, builds, tests, and deployments.
- **Workflows**:
  - Defined using YAML files in the `.github/workflows` directory.
  - **Example Workflow**:
    ```yaml
    name: CI
    on: [push]
    jobs:
      build:
        runs-on: ubuntu-latest
        steps:
        - uses: actions/checkout@v2
        - name: Set up .NET
          uses: actions/setup-dotnet@v1
          with:
            dotnet-version: 3.1.x
        - name: Install dependencies
          run: dotnet restore
        - name: Build
          run: dotnet build --no-restore
        - name: Test
          run: dotnet test --no-restore --verbosity normal
    ```
