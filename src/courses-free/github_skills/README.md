Learn how to use GitHub with interactive courses designed for beginners and experts. These courses require having a GitHub account but are free to use. Each course uses a template repository that you can fork and use to follow along with the course. For that reason, I am adding the repositories to this mono-repo as submodules. Therefore, as Git doesn’t download submodule contents by default, you need to run the following command to download the submodule contents:

```bash
git submodule update --init --recursive
```

The code on these repositories does not add a lot of value to this mono-repo. The value itself is in the repositories' history, which is why I am adding them as submodules.

Although I already know how to use GitHub (and git), I am going through these courses to see if there is anything I can learn for adding it to this mono-repo. 

## Courses

1. [GitHub Skills | First day on GitHub | Introduction to GitHub](https://github.com/skills/introduction-to-github/)
2. [GitHub Skills | First day on GitHub | Communicating using Markdown](https://github.com/skills/communicate-using-markdown)

## Extra resources

- [GitHub blog | Working with submodules](https://github.blog/2016-02-01-working-with-submodules/). Mainly for the commands on submodules: ``git submodule add <repository> <path>``. Also for reading about advantages vs disadvantages of using git submodules.