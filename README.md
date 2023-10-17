# GitHub Actions Practice
Practice repository for automating NuGet Package publishing via GitHub Actions.

## Publishing NuGet Package
- When a commit containing changes to the [ExampleClassLibrary](https://github.com/gnalvesteffer/github-actions-practice/tree/main/src/GithubActionsPractice/ExampleClassLibrary) project is pushed to the `main` branch, the [Publish NuGet Package](https://github.com/gnalvesteffer/github-actions-practice/blob/main/.github/workflows/publish-nuget-package.yaml) workflow will automatically build and publish a **prerelease** NuGet package for it.
- When a Release is published, the workflow will trigger and publish a release version of the NuGet package, and attach a build of the .nupkg and ExampleConsoleApp to the release.

### Versioning
- The package's version string is automatically generated using the latest [tag](https://github.com/gnalvesteffer/github-actions-practice/tags) via [MinVer](https://github.com/adamralph/minver), referenced in the ExampleClassLibrary project.
- Commits pushed to `main` will have its package version suffixed with `-prerelease.x`, where `x` is the prerelease build iteration.
- Publishing a new release will trigger a NuGet Package publish as a release version.

#### Creating a Release package
- Create a new release via [this link](https://github.com/gnalvesteffer/github-actions-practice/releases/new) and create a new version tag following the semantic versioning scheme (for example: "0.1.0").
- The `Publish NuGet Package` workflow will trigger when the release is published and will generate a release version of the package.
- The [`Attach Example App To Release`](https://github.com/gnalvesteffer/github-actions-practice/blob/main/.github/workflows/attach-example-app-to-release.yaml) workflow will build the ExampleConsoleApp project and upload the artifacts to the release page.

## GitHub Action Workflow
See the [Publish NuGet Package](https://github.com/gnalvesteffer/github-actions-practice/blob/main/.github/workflows/publish-nuget-package.yaml) workflow for reference.

At a high-level the workflow:
- Checks out the repo
- Sets up .NET 6
- Builds the ExampleClassLibrary project
- Builds the NuGet package using the project's build output
- Publishes the NuGet package

### Variables & Secrets
Variables & secrets accessible to the workflow can be configured [here](https://github.com/gnalvesteffer/github-actions-practice/settings/secrets/actions).

## Testing GitHub Actions locally
To easily test Github Actions locally, you can use [act](https://github.com/nektos/act).

Once _act_ is setup in your environment, you can run `act` at the root of the repo.
This will run the workflows in a Docker container on your machine, providing the benefit of a quicker feedback loop as you develop workflows.
