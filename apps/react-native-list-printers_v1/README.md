# React Native Windows (Test app)

Guide [https://microsoft.github.io/react-native-windows/]

## 1. Check if your system have all tools installed

Run on PowerShell as Administrator

`Set-ExecutionPolicy Unrestricted -Scope Process -Force; iex (New-Object System.Net.WebClient).DownloadString('https://aka.ms/rnw-deps.ps1')`

## 2. Set your Visual Studio Code (user/settings.json) | Optional

To develop faster you should have Prettier and Eslint installed in "Visual Studio Code" and also
have autoformat preconfigured for both in settings.jsonautoformat with prettier and fix slint rules

Add autoformat for prettier

    `"editor.defaultFormatter": "esbenp.prettier-vscode"`

Add autofix for slint

    `"editor.codeActionsOnSave": { "source.fixAll": true }`

## 3. Basic steps

Install all dependencies

    `yarn install`

Run the project

    `npx react-native run-windows`
