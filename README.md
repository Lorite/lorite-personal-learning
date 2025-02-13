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
        <li><a href="#dev-container">Dev Container</a></li>
        <li><a href="#code">Code</a></li>
        <li><a href="#continuous-integration-continuous-deployment">Continuous Integration/Continuous Deployment</a></li>
        <li><a href="#vs-code-extensions">VS Code extensions</a></li>
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

### Try out the repository using GitHub Codespaces

1. Click on the green `Code` button on the top right of the repository and select `Open with Codespaces`.

Learn more about [GitHub Codespaces](https://github.com/features/codespaces).

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

5. Build something using bazel:

   ```bash
   bazel build //src/examples/bazel-test-project-cpp:hello-world
   ```

   > **_NOTE:_** You can also use the `Bazel: build target` command from the VS Code extension, or the `BAZEL BUILD TARGETS` from the `Explorer` panel (after opening any `BUILD.bazel` file).

<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Usage

### Dev Container

Some of the tools and languages included in the dev container are:

- [Bazel](https://bazel.build/) for building and testing software of any size, quickly and reliably. This is the main and most important tool used in this repository. Some of the reasons to use bazel over other build tools are:
  - **Reproducibility**: Bazel ensures that builds are hermetic, meaning they are isolated and deterministic.
  - **Speed and Efficiency**: Bazel uses aggressive caching and parallel execution to speed up both incremental and clean builds. It only rebuilds what is necessary by tracking dependencies between different parts of your codebase.
  - **Scalability**: Bazel is designed to handle large codebases across multiple repositories.
  - **Multi-language support**: Bazel supports a wide range of programming languages out of the box.
  - **Community**: Bazel is used and supported by many Google projects, as well as a growing number of projects in the open source community.
  - **Open source**: Bazel is open source and maintained by a growing community of contributors.
- [LLDB](https://lldb.llvm.org/) for debugging. This extension is used along with VS Code [launch profiles](.vscode/launch.json) and [tasks](.vscode/tasks.json) that are already set up in this repo. You can try pressing <kbd>F5</kbd> on any editor-opened code file. You may need to modify the location of the output file in the [launch profiles](.vscode/launch.json) manually for now.
- [zsh + powerlevel10k + plugins](https://www.zsh.org/) for a better terminal experience.
- [Many VS Code extensions](https://code.visualstudio.com/docs/editor/extension-gallery). See [.devcontainer/devcontainer.json](.devcontainer/devcontainer.json) for the full list. You can also check the section [VS Code extensions](#vs-code-extensions) for more information.
- [LaTeX](https://www.latex-project.org/) for writing documents.
- [C++](https://www.cplusplus.com/) with [LLVM](https://llvm.org/) tools: [clangd](https://clangd.llvm.org/) with clang-format and clang-tidy when saving files.
- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [Python](https://www.python.org/)
- [pip](https://pypi.org/project/pip/) for installing Python packages.
- [Go](https://golang.org/)
- [JAVA](https://www.java.com/)
- [Markdown](https://www.markdownguide.org/) for writing documentation. [Vale](https://vale.sh/) is used for linting and style checking.
- [Aspect Docs - Run linters and formatters under Bazel](https://docs.aspect.build/rulesets/aspect_rules_lint/). Run `tools/lint/scripts/aspect_lint.sh //path/to:target` to run linters under Bazel. These linters and formatters are also run in the CI/CD pipeline. Run `bazel run //:format` to format all the code in the repository. These steps will also be triggered by the GitHub actions when a PR is opened.

### Code

Find a collection of small projects to learn about different languages and tools. All the code can be found in the [src](src) folder.

#### Courses

The open source courses can be found in the [courses-free](src/courses-free) folder. The courses are:

- **GitHub Skills**: Learn how to use GitHub with interactive courses designed for beginners and experts. [src/courses-free/github_skills](src/courses-free/github_skills)

  [![GitHub-actions][GitHub-actions]][GitHub-actions-url]

- **Microsoft Learning: Getting started with C#**: Learn the basic syntax and thought processes required to build simple applications using C#. [src/courses-free/microsoft_learning/000.get_started_with_csharp](src/courses-free/microsoft_learning/000.get_started_with_csharp)

  [![C#][C#]][C#-url]
  [![Bazel][Bazel-build]][Bazel-url]
  [![GitHub-actions][GitHub-actions]][GitHub-actions-url]

- **hacking C++ - C++ Beginner's Guide**: Learn modern, idiomatic C++. It is (roughly) ordered by increasing level of C++ proficiency. [src/courses-free/hacking_cpp](src/courses-free/hacking_cpp)

  [![C++][C++]][C++-url]
  [![Bazel][Bazel-build]][Bazel-url]
  [![GitHub-actions][GitHub-actions]][GitHub-actions-url]

There is also a [courses-licensed](src/courses-licensed) folder with licensed courses but the code is not included.

#### Examples

The examples can be found in the [examples](src/examples) folder. Most of the examples in my repo are really simple. For more elaborated examples, check the [bazelbuild/examples repository](https://github.com/bazelbuild/examples) and the [depracated bazelbuild/bazel/examples folder](https://github.com/bazelbuild/bazel/tree/master/examples). The examples are:

- [C++ Bazel](src/examples/bazel-test-project-cpp): A simple C++ project using Bazel.
- [C# Bazel](src/examples/bazel-test-project-csharp): A simple C# project using Bazel.
- [Python flask Bazel](src/examples/bazel-test-project-python-flask/): A simple Python flask project using Bazel.
- [Java Bazel](src/examples/bazel_test_project_java): A simple Java project using Bazel with Maven dependencies.
- [Shell](src/examples/bazel-test-project-shell): A simple Shell project using Bazel.

#### Exercises

The exercises can be found in the [exercises](src/exercises) folder. The exercises are:

- **Leetcode**: LeetCode is the a platform to help you enhance your skills, expand your knowledge and prepare for technical interviews. The challenges cover a wide range of programming topics and come with a discussion forum for each problem, where users can discuss various solutions. Check the [src/exercises/leetcode](src/exercises/leetcode) directory for more info on how I organize the exercises and run them in an optimal way.

  [![C++][C++]][C++-url]
  [![Bazel][Bazel-build]][Bazel-url]
  [![GitHub-actions][GitHub-actions]][GitHub-actions-url]

- **Job interviews**: A collection of exercises to prepare and asked at job interviews. Check the [src/exercises/job-interviews](src/exercises/job_interviews) directory and the subfolders for more info.

  [![C++][C++]][C++-url]
  [![Bazel][Bazel-build]][Bazel-url]
  [![GitHub-actions][GitHub-actions]][GitHub-actions-url]

#### Subrepos

Bazel is used to pull most dependent repositories and build them. However, the files stay in a cache folder and are not included in the repository source code. For the sub repositories that we want to keep the files in the repository, we use the tool [git-subrepo](tools/git/git-subrepo) by [ingydotnet](https://github.com/ingydotnet/git-subrepo). This allows us to modify the files in the subrepos and still pull from the original repository.

The folder [subrepos](src/subrepos) is then used to store these repositories. The subrepos are:

- **ultimate-python**: The Ultimate Python study guide for newcomers and professionals alike. [src/subrepos/ultimate-python](src/subrepos/ultimate-python). Original repository: [huangsam/ultimate-python](https://github.com/huangsam/ultimate-python).

  [![Python][Python]][Python-url]
  [![Bazel][Bazel-build]][Bazel-url]
  [![GitHub-actions][GitHub-actions]][GitHub-actions-url]

### Continuous Integration/Continuous Deployment

GitHub Actions is a CI/CD (Continuous Integration/Continuous Deployment) service provided by GitHub. In this repository, it is used for running bazel build and bazel test on all the targets under [src/](/src). The files are also formatted automatically in a separate commit. The actions are triggered when a PR is opened and when the PR is merged. The actions are defined in the [.github/workflows](.github/workflows) folder. Bazel's cache is used to speed up the builds.

### VS Code extensions

As stated earlier, you can check the [.devcontainer/devcontainer.json](.devcontainer/devcontainer.json) file to see al the extensions installed on the dev container by default. You can also check the [workspace settings](.ws.code-workspace) file for configuration. Remember that the workspace file must be opened in VS Code. The extensions are:

- [bazelbuild.vscode-bazel](https://marketplace.visualstudio.com/items?itemName=bazelbuild.vscode-bazel): Bazel support for VS Code. Features:

  - Syntax highlighting
  - Bazel Build Targets tree displays the build packages/targets in your workspace.
  - CodeLens links in BUILD files to directly launch a build or test by simply clicking on the targets
  - Buildifier integration to lint and format your Bazel files (requires that Buildifier be installed)
  - Debug Starlark code in your .bzl files during a build (set breakpoints, step through code, inspect variables, etc.)

- [vadimcn.vscode-lldb](https://marketplace.visualstudio.com/items?itemName=vadimcn.vscode-lldb): LLDB Debugger support for Visual Studio Code mainly for C++ and Rust. It is also usable with most compiled languages whose compiler generates compatible debugging information.

- [chrischinchilla.vale-vscode](https://marketplace.visualstudio.com/items?itemName=chrischinchilla.vale-vscode): The Vale extension for VS Code provides customizable spelling, style, and grammar checking for a variety of markup formats (Markdown, AsciiDoc, reStructuredText, HTML, and DITA). It is also used it for vocabulary and style checking in the code.

- TODO: add missing extensions from the [.devcontainer/devcontainer.json](.devcontainer/devcontainer.json) file.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Roadmap

See the [open issues](https://github.com/Lorite/lorite-personal-learning/issues) for a full list of proposed features (and known issues).

See the [GitHub project](https://github.com/users/Lorite/projects/1) for the tasks and project roadmap. The tasks are linked to the issues.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated** :pray:.

## Resources

This section contains the resources for DevOps, CI/CD, and programming languages. There are hundreds of other resources that I have used to learn about these topics, but I can't include them all here. I have tried to include the most important ones. Apart from the list below, there are more links and resources scattered around this repository in subfolders. Needless to say, there are very nice repositories with a lot of resources, like [awesome-bazel](https://github.com/jin/awesome-bazel) on GitHub, so search for them if you are looking for a deeper dive into a specific topic.

### Documenting

- [README template](https://github.com/Lorite/lorite-personal-learning)

### Bazel

- [Bazel build](https://bazel.build/)
- [Bazel GitHub repository](https://github.com/bazelbuild/bazel/)
- [Bazel bzlmod migration](https://bazel.build/external/migration) and [Bazel Central Registry](https://registry.bazel.build/) from 2024-07-22 onwards.
- [Experimentations on Bazel - GitHub actions by David Bernard](https://dev.to/davidb31/experimentations-on-bazel-github-action-5639)
- [Bazel zsh terminal completion](https://bazel.build/install/completion)
- [Alex Eagle - .bazelrc flags you should enable](https://blog.aspect.dev/bazelrc-flags)

### Dev container

- [VS Code Dev Containers](https://code.visualstudio.com/docs/devcontainers/containers)
- [Dev Container Features](https://containers.dev/implementors/features/)
- [zsh and powerlevel10k (terminal)](https://dev.to/abdfnx/oh-my-zsh-powerlevel10k-cool-terminal-1no0)

### Multi-language

- [Refactoring.Guru - Design Patterns & Refactoring](https://refactoring.guru/)

### Python

- [Python structuring your project by Kenneth Reitz](https://docs.python-guide.org/writing/structure/)
- [Python Rules for Bazel](https://rules-python.readthedocs.io)
- [Python rules for pip in Bazel](https://github.com/bazelbuild/rules_python/blob/main/docs/pip.md)
- [Simple Python flask app using Bazel](https://earthly.dev/blog/build-and-deploy-pyapp-with-bazel/)

### C++

- [C++ reference](https://en.cppreference.com/w/), [hacking C++](https://hackingcpp.com/), [W3 schools - C++ Tutorial](https://www.w3schools.com/cpp/), ...
- [C++ Rules for Bazel](https://bazel.build/reference/be/c-cpp)
- [LLVM toolchain for bazel](https://github.com/grailbio/bazel-toolchain)
- [Clang: a C language family frontend for LLVM](https://clang.llvm.org/)
- [Hedron's Compile Commands Extractor for Bazel](https://github.com/hedronvision/bazel-compile-commands-extractor)
- [GoogleTest - gtest](http://google.github.io/googletest/)
- [Google benchmark](https://github.com/google/benchmark/tree/main)
- [Google logging library (glog)](https://github.com/google/glog)

### JAVA

- [bazelbuild/rules_jvm_external](https://github.com/bazelbuild/rules_jvm_external)
- [MAVEN - Introduction to the Standard Directory Layout](https://maven.apache.org/guides/introduction/introduction-to-the-standard-directory-layout.html)

### LaTeX

- [Bazel rules for LaTeX](https://github.com/ProdriveTechnologies/bazel-latex)

### Markdown

- [Markdown guide](https://www.markdownguide.org/basic-syntax/)
- [Vale - Markdown linter](https://vale.sh/)

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
[JAVA]: https://img.shields.io/badge/Java-ED8B00?style=for-the-badge&logo=openjdk&logoColor=white
[JAVA-url]: https://www.java.com/
