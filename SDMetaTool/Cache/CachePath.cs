using System;
using System.IO.Abstractions;

namespace SDMetaTool.Cache
{
	public class CachePath
	{
		private readonly IFileSystem fileSystem;

		public CachePath(IFileSystem fileSystem) {
			this.fileSystem = fileSystem;
		}

		public string GetPath() => $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}{fileSystem.Path.DirectorySeparatorChar}SDMetaTool{fileSystem.Path.DirectorySeparatorChar}cache.json";
	}
}
