<a name="readme-top"></a>
<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![CC BY-NC 4.0 License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]



<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/Lorite/lorite-personal-learning">
    <img src="images/logo.png" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">Lorite personal learning</h3>

  <p align="center">
    A monorepo for learning about different tools, workflows, programming languages, and anything related to software development.
    <br />
    <a href="https://github.com/Lorite/lorite-personal-learning"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/Lorite/lorite-personal-learning">View Demo</a>
    ·
    <a href="https://github.com/Lorite/lorite-personal-learning/issues">Report Bug</a>
    ·
    <a href="https://github.com/Lorite/lorite-personal-learning/issues">Request Feature</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#about-the-project-fun">Fun explanation</a></li>
        <li><a href="#about-the-project-boring">Boring explanation</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <ul>
        <li><a href="#container">Container</a></li>
        <li><a href="#code">Code</a></li>
        <li><a href="#github-actions">GitHub actions</a></li>
      </ul>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>

## About The Project

### Fun explanation

Imagine a vibrant digital landscape where code languages bloom like a garden of diverse flowers. At the center of this repository, a mighty Bazel tree stands tall, its branches extending to support Python vines, C++ oaks, C# cherry blossoms, Go bamboo shoots, Javascript willow branches, and dozens of undiscovered species. The air is filled with the harmonious hum of CI/CD bees buzzing around, ensuring a seamless flow of updates.

In the background, the VS Code devcontainer rises like a futuristic tower, with its windows opening to reveal a panoramic view of the coding ecosystem within. GitHub action satellites orbit overhead, keeping a watchful eye on the repository, ready to launch into action at any moment.

The colors are bold and dynamic, reflecting the energy and versatility of your monorepo. And in the foreground, the README.md serves as a welcoming path, inviting developers to step into this lush garden of code, explore its wonders, and contribute to the ever-growing landscape.

![lorite-personal-learning-monorepo](media/img/lorite-monorepo.png)


### Boring explanation

Welcome to my personal learning repository :bowtie:. I use it to learn about different tools, workflows, programming languages, and anything related to software development, really. Personally, I like to have an overview of the different tools and languages and how they work together. I am getting started with DevOps and CI/CD, so I am using this repository to learn about it, mainly using [dev containers](https://containers.dev/), [Bazel](https://bazel.build/), and [GitHub actions](https://github.com/features/actions) to build the monorepo. I also code in my everyday job, so I also follow specific language courses and try out examples on this repository. I believe that programmers should be able to do everything, from designing the architecture to deploying the software; and this repository can help me (and maybe you) to achieve that. I have high hopes for this repository :crossed_fingers:.

![Dev-ops-meme](https://imgb.ifunny.co/images/0d9aaaf8feb3e07013fe7d8f701924ff3ac02fa425a90b52176144c601338b09_1.jpg)

This repo can be directly used as a container for development. It is based on the [Ubuntu base container from the GitHub devcontainers images repo](https://github.com/devcontainers/images/tree/main/src/base-ubuntu). The container includes a lot of tools to make developing much easier for beginners and forget about ci/cd. It uses a collection of Dev Container Features from the [devcontainers features repo](https://github.com/devcontainers/features).

This repository could not have been possible without the help of the open source community. I have used a lot of open source tools and courses to learn about different topics. I have tried to include all the resources I have used in the [Resources](#resources) section. If you find any missing, please let me know.

> If I have seen further, it is by standing on the shoulders of giants.
>  
> _- Isaac Newton_

You can read the commit messages to see what I have been doing. I try to keep them as descriptive as possible. I also try to keep the code as clean as possible. I am not perfect :sweat_smile: so sometimes I have to fix my own commits!

![welcome-to-my-git-commit-history-meme](https://programmerhumor.io/wp-content/uploads/2021/10/programmerhumor-io-linux-memes-backend-memes-b020a6cb90606ee.jpg)

<p align="right">(<a href="#readme-top">back to top</a>)</p>


## Getting started

### Prerequisites

1. Install [Docker](https://docs.docker.com/get-docker/) on your machine.

2. Install [VS Code](https://code.visualstudio.com/) or [VS Code insiders](https://code.visualstudio.com/insiders/) on your machine.

3. Install [git](https://git-scm.com/downloads) on your machine and configure it with your GitHub account.

### Installation

1. If this is your first time using a development container, please check the getting started information on [VS Code remote - setting up](https://aka.ms/vscode-remote/containers/getting-started) Remote-Containers or [GitHub Docs - Creating a codespace](https://aka.ms/ghcs-open-codespace) using GitHub Codespaces.
 
2. Clone this repository.

    ```bash
    git clone git@github.com:Lorite/lorite-personal-learning.git
    ```

3. Open VS Code using the VS Code workspace file (.ws.code-workspace) in the root of the repository.

    ```bash
    cd lorite-personal-learning
    code .ws.code-workspace
    ```

4. Press <kbd>F1</kbd> and select **Remote-Containers: Reopen in Container** to build and start the container. This step may take a while the first time.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

5. Build something using bazel:
  
    ```bash
    bazel build //src/examples/bazel-test-project-cpp:hello-world
    ```

    > **_NOTE:_** You can also use the `Bazel: build target` command from the VS Code extension, or the `BAZEL BUILD TARGETS` from the `Explorer` panel (after opening any `BUILD.bazel` file).

## Usage

### Container

Some of the tools and languages included in the container are:

- [Bazel](https://bazel.build/) for building and testing software of any size, quickly and reliably.
- [LLDB](https://lldb.llvm.org/) for debugging. This extension is used along with VS Code [launch profiles](.vscode/launch.json) and [tasks](.vscode/tasks.json) that are already set up in this repo. You can try pressing <kbd>F5</kbd> on any editor-opened code file. You may need to modify the location of the output file in the [launch profiles](.vscode/launch.json) manually for now.
- [zsh + powerlevel10k + plugins](https://www.zsh.org/) for a better terminal experience.
- [Many VS Code extensions](https://code.visualstudio.com/docs/editor/extension-gallery). See [.devcontainer/devcontainer.json](.devcontainer/devcontainer.json) for the full list. You can also check the section [VS Code extensions](#vs-code-extensions) for more information.
- [LaTeX](https://www.latex-project.org/) for writing documents.
- [C++](https://www.cplusplus.com/) with [LLVM](https://llvm.org/) tools: [clangd](https://clangd.llvm.org/) with clang-format and clang-tidy when saving files.
- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [Python](https://www.python.org/)
- [pip](https://pypi.org/project/pip/) for installing Python packages.
- [Go](https://golang.org/)

### Code

Find a collection of small projects to learn about different languages and tools. All the code can be found in the [src](src) folder.

#### Courses

The open source courses can be found in the [courses-free](src/courses-free) folder. The courses are:

  - **GitHub Skills**: Learn how to use GitHub with interactive courses designed for beginners and experts. [src/courses-free/github_skills](src/courses-free/github_skills)

    [![GitHub-actions][GitHub-actions]][GitHub-actions-url]

  - **Microsoft Learning: Getting started with C#**: TODO: description. [src/courses-free/csharp-getting-started](src/courses-free/csharp-getting-started)

    [![Bazel][Bazel-build]][Bazel-url]
    [![C#][C#]][C#-url]
    [![GitHub-actions][GitHub-actions]][GitHub-actions-url]

There is also a [courses-licensed](src/courses-licensed) folder with licensed courses but the code is not included.

#### Examples

The examples can be found in the [examples](src/examples) folder. Most of the examples in my repo are really simple. For more elaborated examples, check the [bazelbuild/examples repository](https://github.com/bazelbuild/examples) and the [depracated bazelbuild/bazel/examples folder](https://github.com/bazelbuild/bazel/tree/master/examples). The examples are:

- [C++ Bazel](src/examples/bazel-test-project-cpp): A simple C++ project using Bazel.
- [C# Bazel](src/examples/bazel-test-project-csharp): A simple C# project using Bazel.
- [Python flask Bazel](src/examples/bazel-test-project-python-flask/): A simple Python flask project using Bazel.
- [Shell](src/examples/bazel-test-project-shell): A simple Shell project using Bazel.

### VS Code extensions

As stated earlier, you can check the [.devcontainer/devcontainer.json](.devcontainer/devcontainer.json) file to see al the extensions installed on the dev container by default. You can also check the [workspace settings](.ws.code-workspace) file for configuration. Remember that the workspace file must be opened in VS Code. The extensions are:

- [bazelbuild.vscode-bazel](https://marketplace.visualstudio.com/items?itemName=bazelbuild.vscode-bazel): Bazel support for VS Code. Features:
  - Syntax highlighting
  - Bazel Build Targets tree displays the build packages/targets in your workspace.
  - CodeLens links in BUILD files to directly launch a build or test by simply clicking on the targets
  - Buildifier integration to lint and format your Bazel files (requires that Buildifier be installed)
  - Debug Starlark code in your .bzl files during a build (set breakpoints, step through code, inspect variables, etc.)

- [vadimcn.vscode-lldb](https://marketplace.visualstudio.com/items?itemName=vadimcn.vscode-lldb): LLDB Debugger support for Visual Studio Code mainly for C++ and Rust. It is also usable with most compiled languages whose compiler generates compatible debugging information.

- TODO: add missing extensions from the [.devcontainer/devcontainer.json](.devcontainer/devcontainer.json) file.

### GitHub Actions

TODO: explain how the GitHub Actions are used.

<p align="right">(<a href="#readme-top">back to top</a>)</p>


## Roadmap

See the [open issues](https://github.com/Lorite/lorite-personal-learning/issues) for a full list of proposed features (and known issues).

See the [GitHub project](https://github.com/users/Lorite/projects/1) for the tasks and project roadmap. The tasks are linked to the issues.

<p align="right">(<a href="#readme-top">back to top</a>)</p>


## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated** :pray:.

## Resources

This section contains the resources for DevOps and CI/CD. The resources specific to the different languages can be found in the [courses](#courses) section.

Check individual courses for their sources.

### Documenting
- [README template](https://github.com/Lorite/lorite-personal-learning)

### Bazel
- [Bazel build](https://bazel.build/)
- [Bazel GitHub repository](https://github.com/bazelbuild/bazel/)
- [Experimentations on Bazel - GitHub actions by David Bernard](https://dev.to/davidb31/experimentations-on-bazel-github-action-5639)
- [Bazel zsh terminal completion](https://bazel.build/install/completion)
- [Alex Eagle - .bazelrc flags you should enable](https://blog.aspect.dev/bazelrc-flags)

### Dev container
- [VS Code Dev Containers](https://code.visualstudio.com/docs/devcontainers/containers)
- [Dev Container Features](https://containers.dev/implementors/features/)
- [zsh and powerlevel10k (terminal)](https://dev.to/abdfnx/oh-my-zsh-powerlevel10k-cool-terminal-1no0)

### Python
- [Python structuring your project by Kenneth Reitz](https://docs.python-guide.org/writing/structure/)
- [Python Rules for Bazel](https://rules-python.readthedocs.io)
- [Python rules for pip in Bazel](https://github.com/bazelbuild/rules_python/blob/main/docs/pip.md)
- [Simple Python flask app using Bazel](https://earthly.dev/blog/build-and-deploy-pyapp-with-bazel/)

### LaTeX
- [Bazel rules for LaTeX](https://github.com/ProdriveTechnologies/bazel-latex)

<p align="right">(<a href="#readme-top">back to top</a>)</p>


## License

Copyright (c) Alejandro Lorite Mora (a.lorite.mora@gmail.com). All rights reserved.

Licensed under the Creative Commons Attribution-NonCommercial 4.0 International License. See [LICENSE](LICENSE.txt).

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/Lorite/lorite-personal-learning.svg?style=for-the-badge
[contributors-url]: https://github.com/Lorite/lorite-personal-learning/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/Lorite/lorite-personal-learning.svg?style=for-the-badge
[forks-url]: https://github.com/Lorite/lorite-personal-learning/network/members
[stars-shield]: https://img.shields.io/github/stars/Lorite/lorite-personal-learning.svg?style=for-the-badge
[stars-url]: https://github.com/Lorite/lorite-personal-learning/stargazers
[issues-shield]: https://img.shields.io/github/issues/Lorite/lorite-personal-learning.svg?style=for-the-badge
[issues-url]: https://github.com/Lorite/lorite-personal-learning/issues
[license-shield]: https://img.shields.io/github/license/Lorite/lorite-personal-learning.svg?style=for-the-badge
[license-url]: https://github.com/Lorite/lorite-personal-learning/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/alejandro-lorite-mora/
[product-screenshot]: images/screenshot.png
[Next.js]: https://img.shields.io/badge/next.js-000000?style=for-the-badge&logo=nextdotjs&logoColor=white
[Next-url]: https://nextjs.org/
[React.js]: https://img.shields.io/badge/React-20232A?style=for-the-badge&logo=react&logoColor=61DAFB
[React-url]: https://reactjs.org/
[Vue.js]: https://img.shields.io/badge/Vue.js-35495E?style=for-the-badge&logo=vuedotjs&logoColor=4FC08D
[Vue-url]: https://vuejs.org/
[Angular.io]: https://img.shields.io/badge/Angular-DD0031?style=for-the-badge&logo=angular&logoColor=white
[Angular-url]: https://angular.io/
[Svelte.dev]: https://img.shields.io/badge/Svelte-4A4A55?style=for-the-badge&logo=svelte&logoColor=FF3E00
[Svelte-url]: https://svelte.dev/
[Laravel.com]: https://img.shields.io/badge/Laravel-FF2D20?style=for-the-badge&logo=laravel&logoColor=white
[Laravel-url]: https://laravel.com
[Bootstrap.com]: https://img.shields.io/badge/Bootstrap-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white
[Bootstrap-url]: https://getbootstrap.com
[JQuery.com]: https://img.shields.io/badge/jQuery-0769AD?style=for-the-badge&logo=jquery&logoColor=white
[JQuery-url]: https://jquery.com 
[Bazel-build]: https://img.shields.io/badge/Bazel-9be583?style=for-the-badge&logo=data:image/svg%2bxml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHZpZXdCb3g9IjAgMCA1MTIgNTEyIiB3aWR0aD0iNTEyIiBoZWlnaHQ9IjUxMiI+DQogIDxzdHlsZT4NCiAgICAucmVndWxhcntmaWxsOiM0M0EwNDc7fSAuZGFyay1sZWZ0e2ZpbGw6IzAwNzAxQTt9IC5kYXJrLXJpZ2h0e2ZpbGw6IzAwNDMwMDt9IC5saWdodHtmaWxsOiM3NkQyNzU7fQ0KICA8L3N0eWxlPg0KDQogIDxwYXRoIGNsYXNzPSJsaWdodCIgICAgICBkPSJNMTQ0IDMyIGwxMTIgMTEyIC0xMTIgMTEyIGwtMTEyIC0xMTJ6Ii8+DQogIDxwYXRoIGNsYXNzPSJyZWd1bGFyIiAgICBkPSJNMzIgMTQ0IHYxMTIgbDExMiAxMTIgdi0xMTJ6Ii8+DQoNCiAgPHBhdGggY2xhc3M9ImxpZ2h0IiAgICAgIGQ9Ik0zNjggMzIgIGwxMTIgMTEyIC0xMTIgMTEyIC0xMTIgLTExMnoiLz4NCiAgPHBhdGggY2xhc3M9InJlZ3VsYXIiICAgIGQ9Ik00ODAgMTQ0IHYxMTIgbC0xMTIgMTEyIHYtMTEyeiIvPg0KDQogIDxwYXRoIGNsYXNzPSJyZWd1bGFyIiAgICBkPSJNMjU2IDE0NCBsMTEyIDExMiAtMTEyIDExMiAtMTEyIC0xMTJ6Ii8+DQogIDxwYXRoIGNsYXNzPSJkYXJrLWxlZnQiICBkPSJNMjU2IDM2OCB2MTEyIGwtMTEyIC0xMTIgIHYtMTEyeiIvPg0KICA8cGF0aCBjbGFzcz0iZGFyay1yaWdodCIgZD0iTTI1NiAzNjggbDExMiAtMTEyIHYxMTIgbC0xMTIgMTEyeiIvPg0KPC9zdmc+DQoNCg==&logoColor=green
[Bazel-url]: https://bazel.build/
[GitHub-actions]: https://img.shields.io/badge/GitHub_Actions-000000?style=for-the-badge&logo=github-actions&logoColor=white
[GitHub-actions-url]: https://github.com/features/actions
[C++]: https://img.shields.io/badge/C++-00599C?style=for-the-badge&logo=cplusplus&logoColor=white
[C++-url]: https://www.cplusplus.com/
[C#]: https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white
[C#-url]: https://docs.microsoft.com/en-us/dotnet/csharp/
[Python]: https://img.shields.io/badge/Python-3776AB?style=for-the-badge&logo=python&logoColor=white
[Python-url]: https://www.python.org/
[Go]: https://img.shields.io/badge/Go-00ADD8?style=for-the-badge&logo=go&logoColor=white
[Go-url]: https://golang.org/
