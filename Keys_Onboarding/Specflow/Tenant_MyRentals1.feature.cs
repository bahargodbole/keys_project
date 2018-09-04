We could not find a data exchange file at the path Unhandled Exception: System.NotSupportedException: An attempt was made to load an assembly from a network location which would have caused the assembly to be sandboxed in previous versions of the .NET Framework. This release of the .NET Framework does not enable CAS policy by default, so this load may be dangerous. If this load is not intended to sandbox the assembly, please enable the loadFromRemoteSources switch. See http://go.microsoft.com/fwlink/?LinkId=155569 for more information.

Please open an issue at https://github.com/techtalk/SpecFlow/issues/
Complete output: 

Unhandled Exception: System.NotSupportedException: An attempt was made to load an assembly from a network location which would have caused the assembly to be sandboxed in previous versions of the .NET Framework. This release of the .NET Framework does not enable CAS policy by default, so this load may be dangerous. If this load is not intended to sandbox the assembly, please enable the loadFromRemoteSources switch. See http://go.microsoft.com/fwlink/?LinkId=155569 for more information.
   at System.Reflection.RuntimeAssembly.nLoadFile(String path, Evidence evidence)
   at System.Reflection.Assembly.LoadFile(String path)
   at TechTalk.SpecFlow.VisualStudio.CodeBehindGenerator.CommandLineHandling.PreLoadAssemblies()
   at TechTalk.SpecFlow.VisualStudio.CodeBehindGenerator.CommandLineHandling.PreLoadAssemblies()
   at TechTalk.SpecFlow.VisualStudio.CodeBehindGenerator.Program.Main(String[] args)



Command: C:\Users\Bahar\AppData\Local\Microsoft\VisualStudio\15.0_33450542\Extensions\olkhny3t.zqb\TechTalk.SpecFlow.VisualStudio.CodeBehindGenerator.exe
Parameters: GenerateTestFile --featurefile C:\Users\Bahar\AppData\Local\Temp\tmpC8DE.tmp --outputdirectory C:\Users\Bahar\AppData\Local\Temp --projectsettingsfile C:\Users\Bahar\AppData\Local\Temp\tmpC8CD.tmp
Working Directory: C:\Users\Bahar\Desktop\IndustryConnect_Documents\BaharAssignments\Internship\Blazers\automationOnboardingSample-master\automationOnboardingSample-master\packages\SpecFlow.2.3.1\tools