# Prompter

## Overview
Prompter is an advanced copy-and-paste application designed to save notes in a tree format. Initially conceived as a tool to assist in writing essays with AI, it has evolved into a comprehensive note-taking system. Prompter leverages a tree templating system to facilitate research conversations with AI language models.

## Features
- **TreeView Control**: Organize notes in a hierarchical structure.
- **MessagePack**: Utilizes MessagePack by neuecc and aarnott for efficient object serialization.
- **Fast Colored TextBox (FCTB)**: Syntax highlighting text editors by Pavel Torgashov.
- **PropertyGridEx**: Enhanced property grid for editing node properties by Danilo Corallo.
- **Integrated Browser**: Visual Studio Browser with Edge for easy PDF printing of your documents.

## Usage
1. **Add a Template**: Create templates to structure your notes.
2. **Edit Node Properties**: Use the PropertyGridEx to modify node attributes.
3. **Organize Notes**: Utilize the TreeView control to manage your notes hierarchically.
4. **Add a Essay**: For an example of how the templating works.  Every node has a Tag which can be used in the template to grab the rendered version of it for use in another template. 

## Node Attributes
- **Name**: Editable name of the tree node.
- **Rank**: Sort order of the node among its siblings, used in Move Up and Down commands.
- **Tag**: Supports runtime templates. Tags are identifiers for nodes within templates, encoded in brackets.
- **Template**: Output text for copy-pasting, replacing `[]` tags with corresponding tagged templated output.
  - Supports tree tags `[Parent]`, `[GrandParent]`.
- **Type**: Each node has a type, with the root node being of Project Type. Subsequent nodes are typically templates.

## Screenshots
![First Page](https://mmeents.github.io/files/PrompterPage1.png)
![Second Page](https://mmeents.github.io/files/PrompterPage2.png)

## Project Details
- **Platform**: Visual Studio C# Windows Form App
- **.NET Framework**: 4.8

## Acknowledgements
- **MessagePack**: By neuecc, aarnott
- **Fast Colored TextBox (FCTB)**: By Pavel Torgashov
- **PropertyGridEx**: By Danilo Corallo

## License
This project is licensed under the MIT License.

## Version
3.0.1 Adds copy paste functionality to the treeview control.

