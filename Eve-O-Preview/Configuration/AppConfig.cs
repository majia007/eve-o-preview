﻿namespace EveOPreview.Configuration
{
	class AppConfig : IAppConfig
	{
		public AppConfig()
		{
			// Default values
			this.ConfigFileName = null;
		}

		public string ConfigFileName { get; set; }
	}
}
