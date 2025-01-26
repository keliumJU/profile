# Profile
<img src="https://github.com/user-attachments/assets/714056e9-1624-4dd6-b8d3-6c9fafbd638b" style="margin-left: auto; margin-right: auto; border-radius: 25px; width: 512px; aspect-ratio: 1/1;" />

This is my personal website [keliumju.com](https://keliumju.com), here going to share anything :3

### Usage local development

1. Install in vscode the extension **C# Dev Kit**
2. Install the .net 8 SDK in ubuntu:
  ```
    sudo apt-get update && \
    sudo apt-get install -y dotnet-sdk-8.0
  ```
3. Open the project and go to **run and debugger** in vscode **(CTRL + D)** and use the **C#: Profile** default option
4. Enable the Hot reload: Go to project files `$ cd ~/profile/Profile` and run `$ dotnet watch`
5. Install TailwindCSS v4.0 [TailwindCSS 4.0](https://tailwindcss.com/docs/installation/tailwind-cli)
6. To enable the tailwind compilation run in another terminal `npx tailwindcss -i ./Styles/input.css -o ./wwwroot/styles.css --watch`

### VSCode user settings(for better dev experience with .net blazor web apps)
1. Go to User `settings.json`
2. Add the next setup for tailwind intellisense in .razor files and better autocomplete only with **tab** key:

```
  "editor.acceptSuggestionOnEnter": "off",
  "editor.acceptSuggestionOnCommitCharacter": false,
  "editor.wordBasedSuggestions": "off",
  "editor.suggest.showKeywords": false,

  "tailwindCSS.experimental.classRegex": ["class: \"(.*)\""],
  "tailwindCSS.includeLanguages": {
      "razor": "html"
  },
```

**That is all 🎉🎉**
