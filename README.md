# Prompter
* ## Wait what? Prompter is a fancy copy-and-paste app to save notes in a tree format. JJ it's a tree templating system for copy and past research conversations with AI LLM.  I started mapping out how to get AI to write an essay.  It went on about the Thesis and supporting evidence... I tried to map it so to use it against the AI with the templating.  Originally I wanted it to help me ask the AI to write books for me.  Now I like it to take notes.    
  * ### This project is a Visual Studio C# Windows Form App.
  * ### Basic Tabs and Splitters, TreeView control
  * ### MessagePack by neuecc,aarnott for object serialization.  
  * ### FCTB by Pavel Torgashov Fast Colored TextBox for Syntax Highlighting text editors.
  * ### PropertyGridEx by Danilo Corallo for editing node properties.
  * ### Visual Studio Browser with Edge so if you write a book you could print it to PDF.
  * ### ...
  * ### put them all together and wire it up and ...
  * ### Generic use case add a Template.
  </br> 

![First Page](https://mmeents.github.io/files/PrompterPage1.png)
  </br>
![Second Page](https://mmeents.github.io/files/PrompterPage2.png)
* ### Name - Tree Node Name, you can also edit it in the tree.
* ### Rank - Sort order of the node in siblings.  Used in Move Up and Down commands.
* ### Tag - Supports runtime templates. Tag is a way to identify this node to a template. encode tags in brackets
* ### Template - Output Text is to copy from and replaces \[\] tags with a lookup of tagged Templated output.
  * ### supports tree tags \[Parent\] \[GrandParent\]
* ### Type - Each node has a type.  At the root is the Project Type.
  * ### First node needs to be project.  After that you will use mostly template.