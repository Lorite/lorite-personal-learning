This repository is a monorepo for learning about different tools, workflows, programming languages, and anything related to software development. It includes various projects, courses, examples, and exercises to help developers learn and practice their skills.

1. **Ensure Code Quality**: Maintain high standards for code quality, including clear and descriptive commit messages, clean code, and thorough documentation.
2. **Use Bazel for Builds**: Utilize Bazel for building and testing projects. Ensure reproducibility, speed, and scalability in builds.
3. **Leverage Dev Containers**: Use the provided dev container for a consistent development environment. Ensure all necessary tools and extensions are included.
4. **Follow CI/CD Practices**: Implement CI/CD using GitHub Actions. Ensure all builds and tests are automated and run on every pull request and merge.
5. **Document Thoroughly**: Keep the README.md and other documentation up to date. Provide clear instructions for getting started, using the repository, and contributing.
6. **Encourage Learning**: Use the repository as a learning tool. Include examples, exercises, and resources to help developers improve their skills.
7. **Format and Lint Code**: Ensure all code is properly formatted and linted. Use tools like `prettier` for formatting and `eslint` for linting JavaScript/TypeScript code, `flake8` for Python, and `clang-tidy` for C++.
8. **Verify Before Pushing**: Encourage the developer to run `bazel run //tools/format:format`, `bazel build //...`, and `bazel test //...` before pushing changes. Ensure all tests pass and the code builds successfully.
