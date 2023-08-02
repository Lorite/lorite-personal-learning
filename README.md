
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
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]



<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/Lorite/lorite-personal-learning">
    <img src="images/logo.png" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">Best-README-Template</h3>

  <p align="center">
    An awesome README template to jumpstart your projects!
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
      <a href="#summary">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
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
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>



## Table of contents

3. [Usage](#usage)
    1. [Container](#container)
        1. [Tools](#tools)
        2. [Languages](#languages)
    2. [Code](#code)
        1. [Courses](#courses)
        2. [Examples](#examples)
    3. [GitHub Actions](#github-actions)
4. [Resources](#resources)
5. [License](#license)

## About The Project

This repo can be directly used as a container for development. It is based on the [Bazel (Community) dev container from the microsoft vscode dev containers repo](https://github.com/microsoft/vscode-dev-containers/blob/main/containers/bazel/README.md). The container includes a lot of tools to make developing much easier for beginners and forget about ci/cd.

| Metadata                    | Value                                                |
| --------------------------- | ---------------------------------------------------- |
| *Contributors*              | William Phetsinorath <deva.shikanime@protonmail.com> |
| *Categories*                | Community, Other                                     |
| *Definition type*           | Dockerfile                                           |
| *Supported architecture(s)* | x86-64                                               |
| *Works in Codespaces*       | Yes                                                  |
| *Container host OS support* | Linux, macOS, Windows                                |
| *Container OS*              | Debian                                               |
| *Languages, platforms*      | Any                                                  |

The project also includes a lot of examples and courses to learn about different languages and tools.

The project is also configured to use GitHub Actions to build and test the code.

Check the Usage section for more information.

### Built with

## Getting started

### Prerequisites

1. Install [Docker](https://docs.docker.com/get-docker/) on your machine.

2. Install [VS Code](https://code.visualstudio.com/) or [VS Code insiders](https://code.visualstudio.com/insiders/) on your machine.

3. Install [git](https://git-scm.com/downloads) on your machine and configure it with your GitHub account.

### Installation

1. If this is your first time using a development container, please see getting started information on [setting up](https://aka.ms/vscode-remote/containers/getting-started) Remote-Containers or [creating a codespace](https://aka.ms/ghcs-open-codespace) using GitHub Codespaces.
 
2. Clone this repository.

    ```bash
    git clone git@github.com:Lorite/lorite-personal-learning.git
    ```

3. Open VS Code using the VS Code workspace file in the root of the repository.

    ```bash
    cd lorite-personal-learning
    code .ws.code-workspace
    ```

4. Press <kbd>F1</kbd> and select **Remote-Containers: Reopen in Container** to build and start the container. This step may take a while the first time.

## Usage

### Container

#### Tools

- [Bazel](https://bazel.build/) for building and testing software of any size, quickly and reliably.
- [zsh + powerlevel10k + plugins](https://www.zsh.org/) for a better terminal experience.
- [Many VS Code extensions](https://code.visualstudio.com/docs/editor/extension-gallery). See [.devcontainer/devcontainer.json](.devcontainer/devcontainer.json) for the full list.
- [pip](https://pypi.org/project/pip/) for installing Python packages.

#### Languages

- [C++](https://www.cplusplus.com/)
- [Python](https://www.python.org/)
- [Go](https://golang.org/)

### Code

Find a collection of small projects to learn about different languages and tools. All the code can be found in the [src](src) folder.

#### Courses

The open source courses can be found in the [courses-free](src/courses-free) folder. The courses are:
- C++:
    - TODO.

There is also a [courses-paid](src/courses-paid) folder with paid courses but the code is not included.

#### Examples

- [C++ Bazel](src/examples/bazel-test-project-cpp): A simple C++ project using Bazel.
- [Python flask Bazel](src/examples/bazel-test-project-python-flask/): A simple Python flask project using Bazel.

### GitHub Actions

TODO: explain how the GitHub Actions are used.

## Resources
- [Experimentations on Bazel - GitHub actions by David Bernard](https://dev.to/davidb31/experimentations-on-bazel-github-action-5639)
- [Python rules for pip in Bazel](https://github.com/bazelbuild/rules_python/blob/main/docs/pip.md)
- [Python structuring your project by Kenneth Reitz](https://docs.python-guide.org/writing/structure/)
- [Simple Python flask app using Bazel](https://earthly.dev/blog/build-and-deploy-pyapp-with-bazel/)
- [zsh and powerlevel10k](https://dev.to/abdfnx/oh-my-zsh-powerlevel10k-cool-terminal-1no0)
- [README template](https://github.com/othneildrew/Best-README-Template)

## License

Copyright (c) Alejandro Lorite Mora (a.lorite.mora@gmail.com). All rights reserved.

Licensed under the Creative Commons Attribution-NonCommercial 4.0 International License. See [LICENSE](https://creativecommons.org/licenses/by-nc/4.0/).


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
[linkedin-url]: https://linkedin.com/in/othneildrew
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