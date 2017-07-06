using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoKoanRunner.Core
{
	public class KoanSource
	{
		public string Extension { get; set; }
		public string ProjectName { get; set; }
		public string SourceFolder { get; set; }
		public string AssemblyPath { get; set; }
		public static readonly KoanSource CSharp = new KoanSource
		{
			Extension = ".cs",
			ProjectName = "CSharp",
			SourceFolder = @"..\..\..\CSharp",
			AssemblyPath = @"..\..\..\CSharp\bin\debug\csharp.dll"
		};

		public static readonly KoanSource[] Sources = new[] {CSharp};
	}
}
