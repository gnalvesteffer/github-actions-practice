# github-actions-practice
Practice repo using GitHub Actions to automate the publishing of a NuGet Package.

## Publishing a new NuGet Package version
When a new commit is pushed to `main`, the [Publish NuGet Package](https://github.com/gnalvesteffer/github-actions-practice/blob/main/.github/workflows/publish-nuget-package.yaml) workflow will run, which will automatically build and publish the NuGet package for the [ExampleClassLibrary](https://github.com/gnalvesteffer/github-actions-practice/tree/main/src/GithubActionsPractice/ExampleClassLibrary) project.

To summarize:
- Push a commit to `main`
- The `Publish NuGet Package` workflow runs
- The NuGet package for the ExampleClassLibrary gets published, and is visible at https://github.com/gnalvesteffer/github-actions-practice/pkgs/nuget/gnalvesteffer_nugetpractice

### Versioning
- The package's version string is automatically generated usin the latest tag via [MinVer](https://github.com/adamralph/minver), referenced in the ExampleClassLibrary project.
- Commits pushed to `main` will have its package version suffixed with `-prerelease-0.x`.
- Releases will trigger a new publish for a release version.

To create a release:
- Create a new release via https://github.com/gnalvesteffer/github-actions-practice/releases/new and create a new version tag following the semantic versioning scheme (for example: "0.1.0")
- The `Publish NuGet Package` workflow will trigger when the release is created and generate a release version of the package.
