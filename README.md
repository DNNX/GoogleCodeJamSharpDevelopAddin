## Google Code Jam SharpDevelop Add-in ##

GoogleCodeJamSharpDevelopAddin is an add-in for [SharpDevelop IDE](http://sharpdevelop.net/OpenSource/SD/Default.aspx) which allows you to create a template solution for problems from [Google Code Jam](http://code.google.com/codejam) contests.

### Prerequisites ###
1. *.NET Framework 4.0* or higher (or any compatible, like [Mono 2.8+](http://www.mono-project.com/)). Solution templates use [Parallel LINQ](http://msdn.microsoft.com/en-us/library/dd460688.aspx) in order to run several tests simultaneously.
2. *SharpDevelop 4.0* or higher.
3. *git*
4. Any *ZIP* packaging tool. Unfortunately, Windows doesn't built-in command line `zip` tool, so I didn't unclude packaging script into the project. You have to zip files by yourself (instructions below).

### Packaging and Installation ##
1. `git clone git://github.com/DNNX/GoogleCodeJamSharpDevelopAddin.git`
2. Archive GoogleCodeJamSharpDevelopAddin directory into GoogleCodeJamSharpDevelopAddin.zip.
3. Rename GoogleCodeJamSharpDevelopAddin.zip to GoogleCodeJamSharpDevelopAddin.sdaddin.
4. Double-click GoogleCodeJamSharpDevelopAddin.sdaddin and confirm installation.

### Basic Usage ###
1. Start SharpDevelop.
2. Go to File -> Create New Project.
3. Choose "Google Code Jam Solution Project" under C# / Windows Applications.
4. Specify project name. I usually use name of a problem I'm going to solve.
5. Click "Create".

New solution template will be created with unit tests. Now you ready to create a test based on sample input/output from the problem.

### Running Tests ###
1. Go to View -> Tools -> Unit Tests.
2. In a new pad, click "Run all tests" button. Of cource, all the tests will be red.

### Writing Solution ###
Just open %PROBLEM_NAME%.cs file and override 2 methods: ReadTestCase and Solve. The first one reads/parses single test case from an input stream, the second one solves that case.

### License ###

Copyright (c) 2011 Viktar Basharymau 
twitter.com/DNNX 
%w(viktar.basharymau gmail.com) * "@"

Released under the MIT license. See LICENSE file for details.